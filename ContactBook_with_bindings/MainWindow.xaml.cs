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

namespace ContactBook_with_bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Модель даних для відображення
        private ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();

            // Встановлення контексту даних, який містить властивості
            // до яких будуть прив'язуватися елементи вікна
            this.DataContext = viewModel;

            
            // Встановлення властивості для відображення в ListBox
            contactListBox.DisplayMemberPath = nameof(Contact.FullName); // при використанні ItemTemplate,
                                                                         // властивсть DisplayMemberPath 
                                                                         // не працює
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DublicateSelectedContact();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.RemoveSelectedContact();
        }
    }
}
