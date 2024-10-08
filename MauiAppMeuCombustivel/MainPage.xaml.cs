namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double etanol = Convert.ToDouble(txt_etanol.Text);
                Double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";
                if(etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";
                }else
                {
                    msg = "A gasolina está compensando.";
                }
                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "fechar");
            }
        }//Fecha metodo
    }//fecha class
}//fecha namespace
