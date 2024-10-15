using System;
using Microsoft.Maui.Controls;

namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //evento do botao para mudar o tema
        private void MudarTema(object sender, EventArgs e)
        {
            if (Application.Current.UserAppTheme == AppTheme.Light)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double etanol = Convert.ToDouble(txt_etanol.Text);
                Double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";

                //adicao das variaveis modelo e marca
                string modelo = txt_modelo.Text;
                string marca = txt_marca.Text;


                if (etanol <= (gasolina * 0.7))
                {
                    //alteracao no retorno da msg,concatenando as strings
                    msg = "O etanol está compensando para o seu " + marca + " " + modelo;
                }
                else
                {
                    msg = "A gasolina está compensando para o seu " + marca + " " + modelo;
                }


                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // Fecha método
    } // Fecha classe
} // Fecha namespace
