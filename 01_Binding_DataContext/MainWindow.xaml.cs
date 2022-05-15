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

namespace _01_Binding_DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }

    public class ViewModel
    {
        public User CurrentUser { get; set; }
        public string Email { get; set; }

        public ViewModel()
        {
            CurrentUser = new User()
            {
                Name = "Bob",
                Age = 33
            };

            Email = "pupkin44@gmail.com";
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
