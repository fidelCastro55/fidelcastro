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
    public partial class resumen : ContentPage
    {
        public resumen(string usuario, string nombre,double total)
        {
            InitializeComponent();
            this.lbl_usuario.Text = "Usuario conectado" + usuario;
            this.lbl_nombre.Text = "Nombre:" + nombre;
            this.lbl_total.Text ="Total a pagar:" + Convert.ToString(total);
        }
    }
}