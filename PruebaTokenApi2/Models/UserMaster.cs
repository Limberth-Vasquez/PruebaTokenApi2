namespace PruebaTokenApi2.Models
{
	public class UserMaster
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRoles { get; set; }
        public string UserEmailID { get; set; }

        public UserMaster() { }
    }
}