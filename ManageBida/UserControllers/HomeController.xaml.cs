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

namespace ManageBida.UserControllers
{
    /// <summary>
    /// Interaction logic for HomeController.xaml
    /// </summary>
    public partial class HomeController : UserControl
    {
        public HomeController()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new TotalController());

        }

        private void btnTong_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new TotalController());
        }

        private void btnNote_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new NoteController());
        }
    }
}
