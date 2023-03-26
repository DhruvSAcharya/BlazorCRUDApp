using App.Models;

namespace BlazorLearningApp.Models
{
    public class DisplayPeople
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public People ConverDbModel()
        {
            return new People {
                Id = this.Id,
                Name = this.Name,
                Mobile = this.Mobile,
                Email = this.Email,
                Address = this.Address};
        }

        public void SetDisplayModel(People p)
        {
            if(p != null)
            {
                this.Id = p.Id;
                this.Name = p.Name;
                this.Mobile = p.Mobile;
                this.Email = p.Email;
                this.Address = p.Address;
            }
               
        }
    }
}
