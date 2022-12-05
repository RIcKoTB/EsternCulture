using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace EsternCulture
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Window
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private const string pathToData = @"Data";

        private static string userName = ""; // Ім'я користувача яке береться з текст боксу login
        public static string UserPassword = ""; // Пароль користувача яке береться з текст боксу 
        public static string UserName { get => userName; set => userName = value; }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(pathToData + "\\Users"))
            {
                Directory.CreateDirectory(pathToData + "\\Users");
            }

            userName = txtbLogin.Text;

            if (userName.Length == 0)
            {
                MessageBox.Show("Логін не може бути пустий");
                return;
            }

            UserPassword = pswbPassword.Password;

            if (UserPassword.Length == 0)
            {
                MessageBox.Show("Пароль не може бути пустий");
                return;
            }

            try
            {
                string[] tmpStringArray = File.ReadAllLines(pathToData + "\\Users\\" + userName + "\\" + "Info.txt");

                string hashOfPassword = BCrypt.Net.BCrypt.HashPassword(UserPassword);

                if (BCrypt.Net.BCrypt.Verify(UserPassword, tmpStringArray[0]) == true)
                {
                    Login.IsLogin = true;
                    MessageBox.Show("Авторизація успішна");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не вірний логін або пароль");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проблеми з автризацією");
            }
        }

        private void btnRegisterPage_Click(object sender, RoutedEventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Close();
        }

        private void btnPrieview_Click(object sender, RoutedEventArgs e)
        {
            Login.IsLogin = false;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
