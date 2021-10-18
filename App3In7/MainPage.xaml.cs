using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3In7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //almacenar en variable, el contenido de las cajas de texto
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
           await DisplayAlert("mensaje", usuario, "ok");
             //Abrir pantalla dos - envio de datos entre pantallas
            await Navigation.PushAsync(new viewDos(usuario, clave)); //rtoasa   12345
        }
    }
}
