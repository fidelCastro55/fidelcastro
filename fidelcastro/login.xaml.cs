using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fidelcastro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btn_ingresar_Clicked(object sender, EventArgs e)
        {
            try {
                if (txt_usuario.Text.Equals("fidel2022") && txt_contrasena.Text.Equals("uisrael2022"))
                {
                    await Navigation.PushAsync(new registro(txt_usuario.Text));
                }
                else
                {
                    DisplayAlert("alerta", "Datos incorrectos", "ok");
                }
                    
            }
            catch (Exception)
            {

            }
        }
    }
}