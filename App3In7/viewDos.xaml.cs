using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3In7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        //usuario = rtoasa   clave = 12345
        public viewDos(string usuario, string clave)
        {
            InitializeComponent();
            //visualizar datos
            lblUsuario.Text = usuario; //rtoasa
            lblClave.Text = clave; //12345

            
        }
    }
}