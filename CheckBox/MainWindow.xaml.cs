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

namespace CheckBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToping.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushroom.IsChecked = newVal;
            cbMozzarela.IsChecked = newVal;
        }
        private void cbSingleChekedChnaged(object sender, RoutedEventArgs e)
        {
            cbAllToping.IsChecked = null;
            if ((cbSalami.IsChecked == true) && (cbMushroom.IsChecked == true) && (cbMozzarela.IsChecked == true))
            {
                cbAllToping.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMushroom.IsChecked == false) && (cbMozzarela.IsChecked == false))
            {
                cbAllToping.IsChecked = false;
            }
        }
    }
}
