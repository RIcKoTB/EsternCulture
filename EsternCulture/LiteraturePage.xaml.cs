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
using System.Windows.Shapes;
using Application = System.Windows.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace EsternCulture
{
    /// <summary>
    /// Логика взаимодействия для LiteraturePage.xaml
    /// </summary>
    public partial class LiteraturePage : Window
    {
        public LiteraturePage()
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

                txtbUserNameText.Text = tmpStringArray[1].Substring(0, 1) + tmpStringArray[2].Substring(0, 1);

                txtbPrievew.Text = "Full Access";

            }

            if (Login.IsLogin == false)
            {
                txtbPrievew.Text = "Preview";
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            musicPage musicPage = new musicPage();
            musicPage.Show();
            this.Close();
        }

        private void btnReligion_Click(object sender, RoutedEventArgs e)
        {
            ReligionPage religionPage = new ReligionPage(); 
            religionPage.Show();
            this.Close();
        }

        private void btnCarsPage_Click(object sender, RoutedEventArgs e)
        {
            CarsPage carsPage = new CarsPage();
            carsPage.Show();
            this.Close();
        }


        /// <summary>
        /// Інформація Туреччини 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnTurkish_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daabo");
        }

        private void btnBT1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaiw");
        }

        private void btnBT2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaba");
        }

        private void btnBT3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajf");
        }

        /// <summary>
        /// Інформація Єгипту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnEgypt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daach");
        }

        private void btnBE1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaji");
        }

        private void btnBE2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajn");
        }

        private void btnBE3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajp");
        }

        /// <summary>
        /// Інформація Іраку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnIraq_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daacp");
        }

        private void btnBI1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajs");
        }

        private void btnBI2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaju");
        }

        private void btnBI3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajw");
        }

        /// <summary>
        /// Інформація Кіпру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCyprus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaed");
        }

        private void btnBC1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daajx");
        }

        private void btnBC2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daakb");
        }

        private void btnBC3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daakd");
        }

        /// <summary>
        /// Інформація Саудівської Аравії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSaudiArabia_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daaei");
        }

        private void btnBSA1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daakg");
        }

        private void btnBSA2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daakh");
        }

        private void btnBSA3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daakk");
        }


        /// <summary>
        /// Інформація Катару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnQatar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daadz");
        }

        private void btnBQ1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cutt.ly/xC1VJj4");
        }

        private void btnBQ2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cutt.ly/vC1VXE0");
        }

        private void btnBQ3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cutt.ly/AC1VBI8");
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
