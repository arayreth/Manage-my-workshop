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
    /// Interaction logic for section_choices.xaml
    /// </summary>
    public partial class section_choices : Window
    {
        public section_choices()
        {
            InitializeComponent();
        }

        private void Button_help_Click(object sender, RoutedEventArgs e)
        {
            help h = new help();
            h.Show();
            this.Close();
        }

        private void Button_setting_Click(object sender, RoutedEventArgs e)
        {
            settings user_setting = new settings();
            user_setting.Show();
            this.Close();
        }

        private void Button_risc_Click(object sender, RoutedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
        private void Button_ared_Click(object sender, RoutedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
        private void Button_global_Click(object sender, RoutedEventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
