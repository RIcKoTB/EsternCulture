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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application = System.Windows.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace EsternCulture
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextChange();
        }

        private const string pathToData = @"Data";

        private void TextChange()
        {
            if (Login.IsLogin == true)
            {
                string[] tmpStringArray = File.ReadAllLines(pathToData + "\\Users\\" + AuthorizationPage.UserName + "\\" + "Info.txt");

                txtbNameUser.Text = tmpStringArray[1].ToString() + " " + tmpStringArray[2].ToString();
                
                txtbUserNameText.Text = tmpStringArray[1].Substring(0, 1) + tmpStringArray[2].Substring(0,1);

                txtbPrievew.Text = "Full Access";
               
            }

            if(Login.IsLogin == false)
            {
                txtbPrievew.Text = "Preview";
            }
        }


        private void Boreder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

       

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Style styleActive = Application.Current.FindResource("menuButtonActive") as Style;

            stylePassive();
            cnvsMain.Children.Clear();

            if (btnHome.Style != styleActive)
            {
                btnHome.Style = styleActive;
                mainPageVisivble();

            }
            else
            {
                stylePassive();
            }
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            if(Login.IsLogin == true)
            {
                musicPage musicPage = new musicPage();
                musicPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вам не доступний цей розділ, пройдіть реєстрацію");
            }
            
        }

        private void stylePassive()
        {
            Style stylePassive = Application.Current.FindResource("menuButton") as Style;
            btnHome.Style = stylePassive;
            btnMusic.Style = stylePassive;
        }

        private void mainPageVisivble()
        {
            try
            {
                cnvsMain.Children.Add(mainGrid);
            }
            catch (Exception ex)
            {

            }
            
        }

        private void LiteraturePage_Click(object sender, RoutedEventArgs e)
        {
            if (Login.IsLogin == true)
            {
                LiteraturePage literaturePage = new LiteraturePage();
                literaturePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вам не доступний цей розділ, пройдіть реєстрацію");
            }
        }

        private void btnReligion_Click(object sender, RoutedEventArgs e)
        {
            if (Login.IsLogin == true)
            {
                ReligionPage religionPage = new ReligionPage();
                religionPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вам не доступний цей розділ, пройдіть реєстрацію");
            }
                
        }

        private void btnCarsPage_Click(object sender, RoutedEventArgs e)
        {
            if (Login.IsLogin == true)
            {
                CarsPage carsPage = new CarsPage();
                carsPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вам не доступний цей розділ, пройдіть реєстрацію");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTurkish_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/cdme");
        }

        private void btnEgypt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/cgbx");
        }

        private void btnIraq_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyum");
        }

        private void btnCyprus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyun");
        }

        private void btnSaudiArabia_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyus");
        }

        private void btnQatar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyut");
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {

            if(Login.IsLogin == true)
            {
                string message = "Ви хочете вийти з аккаунту?";
                string title = "Вихід з аккаунту";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Login.IsLogin = false;
                    AuthorizationPage authorizathionPage = new AuthorizationPage();
                    authorizathionPage.Show();
                    Close();
                }
            }
            else
            {
                string message = "Ви хочете перейти до реєстрації?";
                string title = "Вихід в меню реєстрації";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Login.IsLogin = false;
                    AuthorizationPage authorizathionPage = new AuthorizationPage();
                    authorizathionPage.Show();
                    Close();
                }
            }
        }
    }
}
