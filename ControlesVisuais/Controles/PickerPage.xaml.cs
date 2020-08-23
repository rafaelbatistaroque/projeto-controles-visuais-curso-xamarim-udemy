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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }

        private void MudarIndiceLista(object s, EventArgs e)
        {
            Picker obj = s as Picker;
            
            lblResultadoIndex.Text = obj.SelectedIndex.ToString();
            lblResultadoItem.Text = obj.SelectedItem.ToString();
        }
    }
}