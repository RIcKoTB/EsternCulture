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
    /// Логика взаимодействия для ReligionPage.xaml
    /// </summary>
    public partial class ReligionPage : Window
    {
        public ReligionPage()
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

        private void btnLiteraturePage_Click(object sender, RoutedEventArgs e)
        {
            LiteraturePage literaturePage = new LiteraturePage();
            literaturePage.Show();
            this.Close();
        }

        private void btnCarsPage_Click(object sender, RoutedEventArgs e)
        {
            CarsPage carsPage = new CarsPage();
            carsPage.Show();
            this.Close();
        }

        /// <summary>
        /// Інформація про Турцію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurkish_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/ayfbq");
        }

        private void btnRT1_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRT2_Click(object sender, RoutedEventArgs e)
        {
            Christianity();
        }

        private void btnRT3_Click(object sender, RoutedEventArgs e)
        {
            Hinduism();
        }

        /// <summary>
        /// Інформація про Єгипет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEgypt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daapj");
        }

        private void btnRE1_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRE2_Click(object sender, RoutedEventArgs e)
        {
            Christianity();
        }

        private void btnRE3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daapj");
        }

        /// <summary>
        /// Інформація про Ірак
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIraq_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dabgu");
        }

        private void btnRI1_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRI2_Click(object sender, RoutedEventArgs e)
        {
            Hinduism();
        }

        private void btnRI3_Click(object sender, RoutedEventArgs e)
        {
            Christianity();
        }

        /// <summary>
        /// Інформація про Кіпр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCyprus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dabhd");
        }

        private void btnRC1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cutt.ly/sC1MXvt");
        }

        private void btnRC2_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRC3_Click(object sender, RoutedEventArgs e)
        {
            Hinduism();
        }


        /// <summary>
        /// Інформація про Саудівську Аравію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaudiArabia_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dabhg");
        }

        private void btnRSA1_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRSA2_Click(object sender, RoutedEventArgs e)
        {
            Christianity();
        }

        private void btnRSA3_Click(object sender, RoutedEventArgs e)
        {
            Hinduism();
        }

        /// <summary>
        /// Інформація про Катар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQatar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dabhk");
        }

        private void btnRQ1_Click(object sender, RoutedEventArgs e)
        {
            Islam();
        }

        private void btnRQ2_Click(object sender, RoutedEventArgs e)
        {
            Christianity();
        }

        private void btnRQ3_Click(object sender, RoutedEventArgs e)
        {
            Hinduism();
        }

        private void Islam()
        {
            System.Diagnostics.Process.Start("https://cutt.ly/uC1NLxY");
        }

        private void Christianity()
        {
            System.Diagnostics.Process.Start("https://cutt.ly/XC1NX05");
        }

        private void Hinduism()
        {
            System.Diagnostics.Process.Start("https://cutt.ly/8C1NNlw");
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
