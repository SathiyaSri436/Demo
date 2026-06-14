using System.Windows;
using System.IO;
namespace demo
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

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            if(!File.Exists("C:\\Jsquare\\sathiya.txt"))
            {
                File.Create("C:\\Jsquare\\sathiya.txt");
            }
            
        }

        private void btnwrite_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("C:\\Jsquare\\sathiya.txt","hello I am Jsquare");
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("C:\\Jsquare\\sathiya.txt");
        }

        private void btnread_Click(object sender, RoutedEventArgs e)
        {
            string value = File.ReadAllText("C:\\Jsquare\\sathiya.txt");
            MessageBox.Show(value);
        }

        private void btnfoldercreate_Click(object sender, RoutedEventArgs e)
        {
            if(Directory.Exists("C:\\Jsquare\\Student"))
            {
                MessageBox.Show("Folder already exists");
            }
            else
            {
                Directory.CreateDirectory("C:\\Jsquare\\Student");
            }
            
        }

        private void btnfolderdelete_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists("C:\\Jsquare\\Student"))
            {
                Directory.Delete("C:\\Jsquare\\Student");
            }
        }

        private void btngetfile_Click(object sender, RoutedEventArgs e)
        {
            string[] filepath= Directory.GetFiles("C:\\Jsquare\\Student");
            foreach(string filename in filepath)
            {
                MessageBox.Show($"{filename}");

            }
        }
    }
}