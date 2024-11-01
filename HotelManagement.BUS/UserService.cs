using HotelManagement.DAL.MODEL;

namespace HotelManagement.BUS
{
    public class UserService
    {
        
        private User User = new User();

        public bool Login(string username, string password)
        {
            return User.CheckLogin(username, password);
        }
    }
}

