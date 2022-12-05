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
    /// Логика взаимодействия для musicPage.xaml
    /// </summary>
    public partial class musicPage : Window
    {
        public musicPage()
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

        Style iconPause = Application.Current.FindResource("menuButtonIconPause") as Style;
        Style iconPlay = Application.Current.FindResource("menuButtonIconMusic") as Style;
        Style styleActive = Application.Current.FindResource("menuButtonActive") as Style;

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void stylePassive()
        {
            Style stylePassive = Application.Current.FindResource("menuButton") as Style;

            btnHome.Style = stylePassive;
            btnMusic.Style = stylePassive;
        }

        private void stylePassiveMusic()
        {
            Style stylePassiveMusic = Application.Current.FindResource("menuButtonIconMusic") as Style;

            iconPlayTurkish1.Style = stylePassiveMusic;
            iconPlayTurkish2.Style = stylePassiveMusic;
            iconPlayTurkish3.Style = stylePassiveMusic;
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

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            stylePassive();
            cnvsMain.Children.Clear();

            if (btnMusic.Style != styleActive)
            {
                btnMusic.Style = styleActive;
                mainPageVisivble();
            }
            else
            {
                stylePassive();
            }
        }

        private void btnLiteraturePage_Click(object sender, RoutedEventArgs e)
        {
            LiteraturePage literaturePage = new LiteraturePage();
            literaturePage.Show();
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
        /// Інформація Турція
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurkish_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyvg");
        }

        private void btnTM1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacyw");
        }

        private void btnTM2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dacza");
        }

        private void btnTM3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczf");
        }

        /// <summary>
        /// Інформація Єгипет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEgypt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czyvl");
        }

        private void btnME1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczj");
        }

        private void btnME2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczo");
        }

        private void btnME3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczt");
        }
        
        /// <summary>
        /// Інформація Ірак
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIraq_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czycj");
        }

        private void btnMI1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczv");
        }

        private void btnMI2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daczy");
        }

        private void btnMI3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadaa");
        }

        /// <summary>
        /// Інформація Кіпр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCyprus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czycb");
        }

        private void btnMC1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadct");
        }

        private void btnMC2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daddj");
        }

        private void btnMC3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daddr");
        }

        /// <summary>
        /// Інформація Саудівська Аравія
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaudiArabia_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czybg");
        }

        private void btnMSA1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daddv");
        }

        private void btnMSA2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/daded");
        }

        private void btnMSA3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadep");
        }

        /// <summary>
        /// Інформація Катар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQatar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/czycp");
        }

        private void btnMQ1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadeu");
        }

        private void btnMQ2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadey");
        }

        private void btnMQ3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surl.li/dadfb");
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
