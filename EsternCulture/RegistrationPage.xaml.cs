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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Window
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private const string pathToData = @"Data";

        public static string UserName = ""; // Ім'я користувача яке береться з текст боксу login
        public static string UserPassword = ""; // Пароль користувача яке береться з текст боксу login
        public static string FirstName = ""; // Текст який береться з вводу в дане поле
        public static string LastName = ""; // Текст який береться з вводу в дане поле


        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(pathToData + "\\Users"))
            {
                Directory.CreateDirectory(pathToData + "\\Users");
            }

            FirstName = txtbFirstName.Text;

            if(FirstName.Length == 0)
            {
                MessageBox.Show("Поле не може бути пустим");
                return;
            }

            LastName = txtbLastName.Text;

            if (LastName.Length == 0)
            {
                MessageBox.Show("Поле не може бути пустим");
                return;
            }

            UserName = txtbLogin.Text;

            if (UserName.Length == 0) // Перевірка на пустий текст бокс
            {
                MessageBox.Show("Логін не може бути пустий");
                return;
            }

            UserPassword = pswbPassword.Password;

            if (UserPassword.Length == 0) // Перевірка на пустий текст бокс
            {
                MessageBox.Show("Пароль не може бути пустий");
                return;
            }


            if (Directory.Exists(pathToData + "\\Users\\" + UserName))
            {
                MessageBox.Show("Користувач вже інсує");
                return;
            }

            Directory.CreateDirectory(pathToData + "\\Users\\" + UserName);

            string hashOfPassword = BCrypt.Net.BCrypt.HashPassword(UserPassword);

            File.WriteAllText(pathToData + "\\Users\\" + UserName + "\\Info.txt", hashOfPassword + "\n" + FirstName + "\n" + LastName);

            MessageBox.Show("Реєстрація успішна");
            AuthorizationPage authorizationWindow = new AuthorizationPage();
            authorizationWindow.Show();
            Close();
        }

        private void btnAuthoritionPage_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationPage authorizationPage = new AuthorizationPage();
            authorizationPage.Show();
            this.Close();
        }

        private void btnPreivew_Click(object sender, RoutedEventArgs e)
        {
            Login.IsLogin = false;
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
            this.Close();
        }
    }
}
