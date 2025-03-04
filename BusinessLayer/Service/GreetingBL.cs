using BusinessLayer.Interface;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class GreetingBL : IGreetingBL
    {
        private readonly IGreetingRL _greetingRL;

        public GreetingBL(IGreetingRL greetingRL)
        {
            _greetingRL = greetingRL;
        }

        public Greeting UpdateGreeting(Greeting greeting) // New Method
        {
            return _greetingRL.UpdateGreeting(greeting);
        }
        public List<Greeting> GetAllGreetings() 
        {
            return _greetingRL.GetAllGreetings();
        }

        public Greeting AddGreeting(Greeting greeting)
        {
            return _greetingRL.AddGreeting(greeting);
        }

        public string GetGreetingMessage(UsernameRequestModel request)
        {
            return _greetingRL.GetGreetingMessage(request);
        }

        public Greeting GetGreetingById(int id)
        {
            return _greetingRL.GetGreetingById(id);
        }

        public string GetGreet()
        {
            return "Hello World";
        }

        
    }
}
