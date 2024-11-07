using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace twenty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class User
        {
            public string Username { get; set; }
            public string Email { get; set; }
            private string Password { get; set; }
            public DateTime RegistrationDate { get; private set; }

            public User(string username, string email, string password)
            {
                Username = username;
                Email = email;
                Password = password;
                RegistrationDate = DateTime.Now;
            }

            public bool ChangePassword(string oldPassword, string newPassword)
            {
                if (oldPassword == Password)
                {
                    Password = newPassword;
                    return true;
                }
                return false;
            }

            public int GetAccountAgeInDays()
            {
                return (DateTime.Now - RegistrationDate).Days;
            }
        }

       
    }
}