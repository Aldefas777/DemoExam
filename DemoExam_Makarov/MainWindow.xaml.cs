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

namespace DemoExam_Makarov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameObj.FrameMain = FrmMain;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObj.FrameMain.CanGoBack)
            {
                FrameObj.FrameMain.GoBack();
            }
        }

        private void btnFAQ_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new PageFAQ());
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new PagePostavchik());
        }

        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Model());
        }

        private void btnSdelka_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new PageSdelka());
        }
    }
}
