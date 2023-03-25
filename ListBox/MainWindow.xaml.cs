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

namespace ListBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Mumbai", Team2 = "Banglore", Score1 = 259, Score2 = 234, Completion = 75 }); matches.Add(new Match() { Team1 = "Delhi", Team2 = "Kolkata", Score1 = 322, Score2 = 243, Completion = 65 });
            matches.Add(new Match() { Team1 = "Hydrabad", Team2 = "RCB", Score1 = 234, Score2 = 235, Completion = 56 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected March: " + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Team2 + " " +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                     (lbMatches.SelectedItem as Match).Score2 + " " 

            );
            }

        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }

    }
}