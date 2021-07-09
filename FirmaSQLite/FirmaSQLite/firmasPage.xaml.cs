using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class firmasPage : ContentPage
    {
        public firmasPage(Byte[] imagen, string name, string desc)
        {
            InitializeComponent();


            firmaIMG.Source = ImageSource.FromStream(() => new MemoryStream(imagen));

            nameFirma.Text = name;
            descFirma.Text = desc;

        }
    }
}