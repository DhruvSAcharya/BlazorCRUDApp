using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public interface IManager
    {
        public List<People> GetPeoples();
        public People GetPeopleById(int id);
        public void AddPeople(People p);
        public void UpdatePle(People ple);
    }
}
