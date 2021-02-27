using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlClienteApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            LoadChart();
        }

        public void LoadChart()
        {
            var entries = new[]
 {
     new ChartEntry(212)
     {
         Label = "Finalizadas",
         ValueLabel = "25",
         TextColor = SKColor.Parse("#27AE60"),        
         ValueLabelColor = SKColor.Parse("#27AE60"),
         Color = SKColor.Parse("#27AE60")
     },
     new ChartEntry(248)
     {
         Label = "Canceladas",
         ValueLabel = "3",
        TextColor = SKColor.Parse("#E74C3C"),
         ValueLabelColor = SKColor.Parse("#E74C3C"),
         Color = SKColor.Parse("#E74C3C")
     },
     new ChartEntry(128)
     {
         Label = "Pendientes",
         ValueLabel = "10",
         TextColor = SKColor.Parse("#F5B041"),
         ValueLabelColor = SKColor.Parse("#F5B041"),
         Color = SKColor.Parse("#F5B041")
     }
     };

            var chart = new DonutChart()
            {
                Entries = entries,
                AnimationDuration = TimeSpan.FromSeconds(3),
                LabelTextSize = 20

            };
            this.chartView.Chart = chart;

        }

    }
}