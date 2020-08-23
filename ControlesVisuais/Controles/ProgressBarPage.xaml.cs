﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuais.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        private void ModificarBarras(object s, EventArgs e)
        {
            bar1.Progress = 1;
            bar2.ProgressTo(1, 5000, Easing.Linear);
            bar3.ProgressTo(1, 5000, Easing.SinIn);

        }
    }
}