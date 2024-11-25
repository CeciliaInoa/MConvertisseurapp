namespace MauiAppConvertisseur
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


       private double Button_Clicked_CF(double celsius)  //conversion de C a F
        {
            return (celsius * 9 / 5) + 32;
        }

        private double Button_Clicked_FC(double fahrenheit) //conversion de  F a C 
        {
            
            return (fahrenheit-32)*  5/9;
        }

        private void Button_Clicked_CF(object sender, EventArgs e)
        {
            if (double.TryParse(celEntry.Text, out double celsius))
            {

                double fahrenheit = Button_Clicked_CF(celsius ) ; 
                celEntry.Text = fahrenheit.ToString("F2");
            }

            else

            {
                DisplayAlert("Ce n'est pas une valeur valide", "Veuillez entrer une valeur valide pour Celsius.", "OK");
            }
        }
        private void Button_Clicked_FC(object sender, EventArgs e)
        {
            if  (double.TryParse(fahEntry.Text, out double fahrenheit))


            {
                double celsius = Button_Clicked_FC(fahrenheit) ;
                fahEntry.Text = celsius.ToString("F2");
            }

            else
            {
                DisplayAlert("Ce n'est pas une valeur valide", "Veuillez entrer une valeur valide pour Fahrenheit.", "OK");
            }
        }

    }

}   