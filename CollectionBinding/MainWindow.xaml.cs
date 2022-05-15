using System;
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

namespace CollectionBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataSource data = new DataSource();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = data;
        }

        private void AddNonNotifiableValue_Click(object sender, RoutedEventArgs e)
        {
            data.AddValueToNonNotifiableCollection();
        }

        private void AddNotifiableValue_Click(object sender, RoutedEventArgs e)
        {
            data.AddValueToNotifiableCollection();
        }
    }
}
