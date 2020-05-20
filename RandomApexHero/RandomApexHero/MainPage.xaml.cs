using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomApexHero
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string[] heroes = { "Bloodhound", "Gibralta", "Bangalore", "Caustic", "Crypto", "Lifeline", "Loba", "Mirage", "Octane", "Pathfinder", "Revenant", "Wattson", "Wraith" };

        public string pickRandomHero()
        {
            Random rand = new Random();

            return heroes[rand.Next(0, 13)];


        }

        public void randomHeroButtonClicked(object sender, EventArgs args)
        {
            randomHeroLabel.Text = pickRandomHero();
        }


    }
}
