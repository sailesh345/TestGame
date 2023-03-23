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

namespace WpfApp1
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

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Aadhar.IsOpen = true;
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = "I have already deposited 20K USD into your account, if you share your Aadhar number, I'll deposit 20K more";
        }

        private void OK2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BOOM!! You're hacked");
        }
    }
}
