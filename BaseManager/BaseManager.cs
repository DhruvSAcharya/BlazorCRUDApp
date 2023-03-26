using App.Models;

namespace BaseModules.BaseManager
{
    public interface BaseManager
    {
        public List<People> GetPeoples();

        public void AddPeople(People p);
    }
}