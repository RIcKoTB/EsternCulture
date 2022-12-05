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
    /// Логика взаимодействия для CarsPage.xaml
    /// </summary>
    public partial class CarsPage : Window
    {
        public CarsPage()
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

        private void btnReligion_Click(object sender, RoutedEventArgs e)
        {
            ReligionPage religionPage = new ReligionPage();
            religionPage.Show();
            this.Close();
        }

        private void btnLiteraturePage_Click(object sender, RoutedEventArgs e)
        {
            LiteraturePage literaturePage = new LiteraturePage();
            literaturePage.Show();
            this.Close();
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            musicPage musicPage = new musicPage();
            musicPage.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Інформація про Турцію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurkish_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacii");
        }

        private void btnCT1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacib");
        }

        private void btnCT2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacid");
        }

        private void btnCT3_Click(object sender, RoutedEventArgs e)
        {
            Ford();
        }


        /// <summary>
        /// Інформація про Єгипет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEgypt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacjh");
        }

        private void btnCE1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacia");
        }

        private void btnCE2_Click(object sender, RoutedEventArgs e)
        {
            Hyndai();
        }

        private void btnCE3_Click(object sender, RoutedEventArgs e)
        {
            Toyota();
        }


        /// <summary>
        /// Інформація про Ірак
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIraq_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacik");
        }

        private void btnCI1_Click(object sender, RoutedEventArgs e)
        {
            Kia();
        }

        private void btnCI2_Click(object sender, RoutedEventArgs e)
        {
            Toyota();
        }

        private void btnCI3_Click(object sender, RoutedEventArgs e)
        {
            Hyndai();
        }

        /// <summary>
        /// Інформація про Кіпр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCyprus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacka");
        }

        private void btnCC1_Click(object sender, RoutedEventArgs e)
        {
            Toyota();
        }

        private void btnCC2_Click(object sender, RoutedEventArgs e)
        {
            Ford();
        }

        private void btnCC3_Click(object sender, RoutedEventArgs e)
        {
            Kia();
        }

        /// <summary>
        /// Інформація про Саудівську Аравію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaudiArabia_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacio");
        }

        private void btnCSA1_Click(object sender, RoutedEventArgs e)
        {
            Toyota();
        }

        private void btnCSA2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacgw");
        }

        private void btnCSA3_Click(object sender, RoutedEventArgs e)
        {
            Ford();
        }

        /// <summary>
        /// Інформація про Катар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQatar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacit");
        }

        private void btnCQ1_Click(object sender, RoutedEventArgs e)
        {
            Toyota();
        }

        private void btnCQ2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacix");
        }

        private void btnCQ3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacjc");
        }

        private void Toyota()
        {
            System.Diagnostics.Process.Start("http://surl.li/dacez");
        }

        private void Ford()
        {
            System.Diagnostics.Process.Start("http://surl.li/dacfp");
        }

        private void Kia()
        {
            System.Diagnostics.Process.Start("http://surl.li/dacfr");
        }

        private void Hyndai()
        {
            System.Diagnostics.Process.Start("http://surl.li/dachc");
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
