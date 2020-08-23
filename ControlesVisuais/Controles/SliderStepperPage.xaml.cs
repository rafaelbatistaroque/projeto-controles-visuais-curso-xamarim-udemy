using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuais.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }

        private void MudarValor(object s, ValueChangedEventArgs e)
        {
            lblResultado.Text = e.NewValue.ToString();
        }
        
        private void MudarValorStapper(object s, ValueChangedEventArgs e)
        {
            lblStapperResultado.Text = e.NewValue.ToString();
        }
    }
}