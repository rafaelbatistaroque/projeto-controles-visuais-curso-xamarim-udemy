using ControlesVisuais.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuais.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void IrParaPaginaActivityIndicator(object s, EventArgs e)
        {
            Detail = new ActivityIndicatorPage();
        }

        private void IrParaPaginaProgressBar(object s, EventArgs e)
        {
            Detail = new ProgressBarPage();
        }

        private void IrParaPaginaBoxView(object s, EventArgs e)
        {
            Detail = new BoxViewPage();
        }

        private void IrParaPaginaLabel(object s, EventArgs e)
        {
            Detail = new LabelPage();
        }

        private void IrParaPaginaButton(object s, EventArgs e)
        {
            Detail = new ButtonPage();
        }

        private void IrParaPaginaEntryEditor(object s, EventArgs e)
        {
            Detail = new EntryEditorPage();
        }

        private void IrParaPaginaDatePicker(object s, EventArgs e)
        {
            Detail = new DatePickerPage();
        }

        private void IrParaPaginaPicker(object s, EventArgs e)
        {
            Detail = new PickerPage();
        }

        private void IrParaPaginaSearchBar(object s, EventArgs e)
        {
            Detail = new SearchBarPage();
        }

        private void IrParaPaginaSliderStepper(object s, EventArgs e)
        {
            Detail = new SliderStepperPage();
        }

        private void IrParaPaginaSwitch(object s, EventArgs e)
        {
            Detail = new SwitchPage();
        }
        private void IrParaPaginaWebView(object s, EventArgs e)
        {
            Detail = new WebViewPage();
        }
    }
}