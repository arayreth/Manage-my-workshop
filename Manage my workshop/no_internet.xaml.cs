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
using System.Windows.Shapes;

namespace Manage_my_workshop
{
    /// <summary>
    /// Interaction logic for no_internet.xaml
    /// </summary>
    public partial class no_internet : Window
    {
        public no_internet()
        {
            InitializeComponent();
        }

        private void Button_reload_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            this.Close();
        }
    }
}
