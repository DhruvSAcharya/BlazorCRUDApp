using App.DataAccess;
using App.Models;
using App.Service;

namespace BlazorLearningApp.Controller
{
    public class PeopleHandlar
    {
        private Service service;

        
        public PeopleHandlar(Service service)
        {
            this.service = service;
        }

        public List<People> GetPeoples()
        {
            List<People> peoples = service.getPeoples();
            return peoples;
        }

        public People GetPeopleById(int id)
        {
            return service.GetPeopleById(id);
        }

        public void AddPeople(People p)
        {
            service.AddPeople(p);
        }

        public void UpdatePle(People ple)
        {
            service.UpdatePle(ple);
        }

        public void DeletePeople(int id)
        {

            service.DeletePeople(id);
        }

    }
}
