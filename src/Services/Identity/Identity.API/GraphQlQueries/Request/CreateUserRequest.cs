namespace Identity.API.GraphQlQueries
{
    public class CreateUserRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}