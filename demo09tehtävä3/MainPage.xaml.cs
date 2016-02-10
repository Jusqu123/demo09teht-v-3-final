using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace demo09tehtävä3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {

        public int lasipinta;

        public int ikkunapinta;

        public int piiri;

        public MainPage()
        {
            this.InitializeComponent();
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            int korkeus = int.Parse(textBox1.Text);

            int leveys = int.Parse(textBox.Text);

            int karmi = int.Parse(textBox2.Text);


            ikkunapinta = ((leveys + karmi) * (korkeus + karmi));

            lasipinta = (leveys * korkeus);

            piiri = ((korkeus * leveys * 2));

            textBox3.Text = lasipinta.ToString();

            textBox4.Text = ikkunapinta.ToString();

            textBox5.Text = piiri.ToString();
        }
    }
}