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
    public partial class SearchBarPage : ContentPage
    {
        private List<string> empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();

            empresasTI = new List<string>();

            empresasTI.Add("Microsoft");
            empresasTI.Add("Oracle");
            empresasTI.Add("Apple");
            empresasTI.Add("Tesla");
            empresasTI.Add("Uber");
            empresasTI.Add("Nubank");
            empresasTI.Add("IBM");

            PreencherLista(empresasTI);
        }

        private void PreencherLista(List<string> empresasTI)
        {
            listaResultado.Children.Clear();
            empresasTI.ForEach(empresa => listaResultado.Children.Add(new Label { Text = empresa}));
        }

        private void Pesquisar(object s, TextChangedEventArgs t)
        {
            var resultado = empresasTI.Where(e => e.Contains(t.NewTextValue)).ToList<string>();

            PreencherLista(resultado);
        }
    }
}