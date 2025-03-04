using ModelLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {

        private readonly GreetingDbContext _context;

        public List<Greeting> GetAllGreetings() 
        {
            return _context.Greetings.ToList();
        }
        public GreetingRL(GreetingDbContext context)
        {
            _context = context;
        }

        public bool DeleteGreeting(int id) // New delete method
        {
            var greeting = _context.Greetings.Find(id);
            if (greeting != null)
            {
                _context.Greetings.Remove(greeting);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Greeting UpdateGreeting(Greeting greeting) // New Method
        {
            var existingGreeting = _context.Greetings.Find(greeting.Id);
            if (existingGreeting != null)
            {
                existingGreeting.Message = greeting.Message;
                _context.SaveChanges();
            }
            return existingGreeting;
        }

        public Greeting AddGreeting(Greeting greeting)
        {
            _context.Greetings.Add(greeting);
            _context.SaveChanges();
            return greeting;
        }

        public Greeting GetGreetingById(int id)
        {
            return _context.Greetings.Find(id);
        }

        public string GetGreetingMessage(UsernameRequestModel request)
        {
            if (!string.IsNullOrWhiteSpace(request.FirstName) && !string.IsNullOrWhiteSpace(request.LastName))
            {
                return $"Hello, {request.FirstName} {request.LastName}!";
            }
            else if (!string.IsNullOrWhiteSpace(request.FirstName))
            {
                return $"Hello, {request.FirstName}!";
            }
            else if (!string.IsNullOrWhiteSpace(request.LastName))
            {
                return $"Hello, {request.LastName}!";
            }
            return "Hello World!";
        }
    }
}
