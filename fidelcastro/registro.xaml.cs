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
    public partial class registro : ContentPage
    {
        public string usuario = "";
        public double interes = 0;
        public double MontoFinal = 0;
        public registro( string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lbl_usuario.Text = this.usuario;
            
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
             
                   
                        interes = 3000 * 0.05;
                        double cuotas = (3000 - Convert.ToDouble(txt_inicial.Text))/5;
                        double cuotasfinal = cuotas + interes;
                        this.txt_pago_mensual.Text = Convert.ToString(cuotasfinal);
                        this.MontoFinal = 3000 + (interes * 5);


                
            }
            catch (Exception) { }
        }

        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "elemento guardado con exito", "entedido");

            await Navigation.PushAsync(new resumen(this.lbl_usuario.Text, txt_nombre.Text, MontoFinal));
        }
    }
}