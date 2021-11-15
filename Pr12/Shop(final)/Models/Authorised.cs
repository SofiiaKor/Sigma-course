namespace Pr9.Models
{
    class Authorised
    {
        private string _password;
        private string _personalCabinet; // поки string, потім зробити класом

        public Authorised(string password, string personalCabinet)
        {
            _password = password;
            _personalCabinet = personalCabinet;
        }

        public void LogIn()
        {
            
        }

        public void LogOut()
        {

        }

        public void EditPersonalCabinet()
        {

        }

        public void ViewPersonalCabinet()
        {

        }
    }
}