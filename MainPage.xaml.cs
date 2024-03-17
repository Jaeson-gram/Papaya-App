using Papaya.Models;

namespace Papaya
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public List<FruitInformation> PapayaInfo { get; set; }

        public MainPage()
        {


            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();


            PapayaInfo = new List<FruitInformation>()
            {
                new FruitInformation
                {
                    Micronutrient = "Vitamin C",
                    Percentage = 101
                },

                new FruitInformation
                {
                    Micronutrient = "Vitamin A",
                    Percentage = 19
                },

                new FruitInformation
                {
                    Micronutrient = "Calcium",
                    Percentage = 2
                },

                new FruitInformation
                {
                    Micronutrient = "Magnesium",
                    Percentage = 5
                },

                new FruitInformation
                {
                    Micronutrient = "Potassium",
                    Percentage = 5
                }
            };

            BindingContext = this;
        }


    }

}
