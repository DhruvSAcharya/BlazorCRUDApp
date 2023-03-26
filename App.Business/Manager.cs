using App.DataAccess;
using App.Models;
using BaseModules.BaseManager;

namespace App.Business
{
    public class Manager : IManager
    {
        private readonly Repository repository;

        public Manager()
        {
            repository = new();
        }

        public List<People> GetPeoples()
        {
            List<People> peoples = repository.GetPeoples();
            return peoples;
        }

        public People GetPeopleById(int id)
        {
            return repository.GetPeopleById(id);
        }

        public void AddPeople(People p)
        {
            repository.AddPeople(p);
        }

        public void UpdatePle(People ple)
        {
            repository.UpdatePle(ple);
        }

        public void DeletePeople(int id)
        {

            repository.DeletePeople(id);
        }

    }
}