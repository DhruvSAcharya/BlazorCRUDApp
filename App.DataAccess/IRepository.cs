using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess
{
    public interface IRepository
    {
        public List<People> GetPeoples();
        public People GetPeopleById(int id);
        public void AddPeople(People p);
        public void DeletePeople(int id);
        public void UpdatePle(People ple);
        public List<People> CreateDummyPeoples();
    }
}
