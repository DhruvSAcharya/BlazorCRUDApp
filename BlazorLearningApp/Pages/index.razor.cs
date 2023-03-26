using App.Models;
using BlazorLearningApp.Controller;
using Microsoft.AspNetCore.Components;

namespace BlazorLearningApp.Pages
{
    public partial class Index
    {
        private List<People> peoples;

        [Inject]
        public PeopleHandlar peopleHandlar { get; set; }


        protected override void OnInitialized()
        {
            peoples = peopleHandlar.GetPeoples();
        }

        private void DeleteUser(int id)
        {
            peopleHandlar.DeletePeople(id);
        }

        private void UpdateList()
        {
            peoples = peopleHandlar.GetPeoples();
        }

    }
}
