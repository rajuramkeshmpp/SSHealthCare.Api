namespace SSHealthCare.Api.DTO.Request
{
    public class UserRegister
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Mobile { get; set; }
    }
}
