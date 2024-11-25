namespace MauiAppConvertisseur
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


       private double Button_Clicked_CF(double celsius)  //conversion de ⁰C a ⁰F
        {
            return (celsius * 9 / 5) + 32;
        }

        private double Button_Clicked_FC(double fahrenheit) //conversion de  ⁰F a ⁰C 
        {
            
            return (fahrenheit-32)* 5/9;
        }

        private void Button_Clicked_CF(object sender, EventArgs e)
        {
            if (double.TryParse(celEntry.Text, out double celsius))
            {

                double fahrenheit = Button_Clicked_CF(celsius ) ;
                convfahLabel.Text = $"{fahrenheit:F2} ⁰F";   //Renvoi la conversion dans le Label ⁰C
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
                convceLabel.Text = $"{celsius:F2} ⁰C";  //Renvoi la conversion dans le Label ⁰F
            }

            else
            {
                DisplayAlert("Ce n'est pas une valeur valide", "Veuillez entrer une valeur valide pour Fahrenheit.", "OK");
            }
        }

    }

}   