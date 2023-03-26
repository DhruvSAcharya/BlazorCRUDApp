using App.Business;
using App.DataAccess;
using App.Models;

namespace App.Service
{
    public class Service
    {
        private readonly Manager manager;

        public Service()
        {
            manager = new();
        }


        public List<People> getPeoples()
        {
            return manager.GetPeoples();
        }

        public People GetPeopleById(int id)
        {
            return manager.GetPeopleById(id);
        }

        public void AddPeople(People p)
        {
            manager.AddPeople(p);
        }

        public void UpdatePle(People ple)
        {
            manager.UpdatePle(ple);
        }

        public void DeletePeople(int id)
        {

            manager.DeletePeople(id);
        }

    }
}