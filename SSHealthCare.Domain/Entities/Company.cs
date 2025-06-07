

namespace SSHealthCare.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateOfIncorporation{ get; set; }
        public string BusinessType {  get; set; }
        public string BusinessDescription { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Logo { get; set; }


    }
}
