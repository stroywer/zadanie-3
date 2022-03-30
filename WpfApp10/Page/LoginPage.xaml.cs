using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10.Page
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var Login = LoginBox.Text.Trial();

            var password = PasswordBox.Text.Trial();

            var LoginStatus = LoginServise.Login(Login, password);

            if(LoginStatus == "Вход выполнен")
            {
                var mainWindow = mainWindow.GetWindow(this);
            }
            else
            {
                MessageBox.Show.(LoginStatus);
            }
        }
    }
}
