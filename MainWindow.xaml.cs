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

namespace pwns6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lb2.Visibility = Visibility.Hidden;
            lb3.Visibility = Visibility.Hidden;
            lb4.Visibility = Visibility.Hidden;
            lb5.Visibility = Visibility.Hidden;
            ls1.Visibility = Visibility.Hidden;
            ls2.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
            bt2.Visibility = Visibility.Hidden;
            bt3.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;
            dp1.Visibility = Visibility.Hidden;

            ls1.IsEnabled = false;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ls1.IsEnabled = true;
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string pass = "blabla";
            if (tb1.Text == pass)
            {
                //tb1.Background = Brushes.Green;
                tb1.Visibility = Visibility.Hidden;
                lbps.Visibility = Visibility.Hidden;
                btps.Visibility = Visibility.Hidden;
                lb2.Visibility = Visibility.Visible;
                lb3.Visibility = Visibility.Visible;
                lb4.Visibility = Visibility.Visible;
                lb5.Visibility = Visibility.Visible;
                ls1.Visibility = Visibility.Visible;
                ls2.Visibility = Visibility.Visible;
                tb2.Visibility = Visibility.Visible;
                bt2.Visibility = Visibility.Visible;
                bt3.Visibility = Visibility.Visible;
                bt4.Visibility = Visibility.Visible;
                bt5.Visibility = Visibility.Visible;
                dp1.Visibility = Visibility.Visible;

            }

            else
            {
                tb1.Background = Brushes.Red;
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            tb2.AppendText(ls2.Text + Environment.NewLine);
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)ls1.SelectedItem).Content.ToString();
            tb2.AppendText(text + Environment.NewLine);
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
