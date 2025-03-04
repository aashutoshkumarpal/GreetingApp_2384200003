using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IGreetingRL
    {
        string GetGreetingMessage(UsernameRequestModel request);

        Greeting AddGreeting(Greeting greeting);

        Greeting GetGreetingById(int id);

        List<Greeting> GetAllGreetings();

        Greeting UpdateGreeting(Greeting greeting);

        bool DeleteGreeting(int id);
    }
}
