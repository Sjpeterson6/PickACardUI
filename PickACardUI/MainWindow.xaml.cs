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

namespace PickACardUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // create an array of cards based on "numberOfCards" slider
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            // clear the previous items in the "listOfCards" list box
            listOfCards.Items.Clear();
            // add each item in the pickedCards array to the list box
            foreach (string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
