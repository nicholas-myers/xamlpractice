using Microsoft.Win32;
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

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName;

        public MainWindow()
        {
            InitializeComponent();

            this.Title = "Hello World";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The App is Closing");
            this.Close();
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void ButtonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            usersName = UsersName.Text;
            MessageBox.Show($"Hello {usersName}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
