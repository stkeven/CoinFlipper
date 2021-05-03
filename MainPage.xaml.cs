using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SCPart13
{
    public partial class MainPage : ContentPage
    {
        //Calls the coin class and its constructor method to connect it to the mainpage
        Coin coin = new Coin();
        //Creates new coinResults Lists
        List<string> coinResults = new List<string>();
        public MainPage()
        {   
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {//flips the coin by telling the computer to run the logic in the coin class
           coin.FlipCoin();
            //Display the coin flip results to the user
            DisplayAlert("Coin Results", coin.GetSideUp(), "Close");
        }
        /// <summary>
        /// Flip the coin 5 times and display the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip5x_Clicked(object sender, EventArgs e)
        {//Creates new lists of the results wiping the old ones
            LstViewCoin.ItemsSource = new List<string>();
            //does the same thing but a different way using the coinResults
            coinResults.Clear();

            //Loop that runs flipcoin 5 times
            for (int i = 0; i < 5; i++)
            {//runs flipcoin
                coin.FlipCoin();
                //each time it runs flipcoin, it will add it to the result receiver
                coinResults.Add(coin.GetSideUp());
            }//sets the list view values equal to the coinResults
            LstViewCoin.ItemsSource = coinResults;
        }
    }
}
