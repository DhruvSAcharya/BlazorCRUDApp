using App.Models;

namespace App.DataAccess
{
    public class Repository : IRepository
    {
        private List<People> peoples;

        public Repository() {
            peoples = new List<People>();
        }
        public List<People> GetPeoples()
        {
            if(peoples.Count <= 0)
            {
                List<People> peoples = CreateDummyPeoples();
            }
            return peoples;
        }

        public People GetPeopleById(int id)
        {
            return peoples.Where(x => x.Id == id).FirstOrDefault() as People;
        }

        public void AddPeople(People p)
        {
            p.Id = getID();
            peoples.Add(p);
        }

        public void UpdatePle(People ple)
        {
            People p =  GetPeopleById(ple.Id);
            if(p != null)
            {
                p.Name = ple.Name;
                p.Mobile = ple.Mobile;
                p.Email = ple.Email;
                p.Address = ple.Address;
            }
        }
        
        public void DeletePeople(int id)
        {
            peoples.Remove(GetPeopleById(id));
        }

        
        public List<People> CreateDummyPeoples()
        {
            People people = new People();
            people.Id = getID();
            people.Name = "Dhruv";
            people.Email = "dhruv@gmail.com";
            people.Mobile = "7778877737";
            people.Address = "My house";

            peoples.Add(people);
            return peoples;
        }

        private int getID()
        {
            int id = 0;
            if(peoples.Count > 0)
            {
                id = peoples.Max(p => p.Id);
            }
            return ++id;

        }
    }
}