using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lista
{
    public partial class MainPage : ContentPage
    {
        public IList<Cancion> Canciones { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            Canciones = new List<Cancion>();

            Canciones.Add(new Cancion("Adan y Eva"));
            Canciones.Add(new Cancion("Mala"));
            Canciones.Add(new Cancion("Vas a quedarte"));
            Canciones.Add(new Cancion("Adictiva"));
            Canciones.Add(new Cancion("Mia"));

            Canciones.Add(new Cancion("Booty"));
            Canciones.Add(new Cancion("Ella quiere beber"));
            Canciones.Add(new Cancion("Taki Taki"));
            Canciones.Add(new Cancion("Vas a quedarte"));
            Canciones.Add(new Cancion("Imposible"));

            Canciones.Add(new Cancion("Solo de mi"));
            Canciones.Add(new Cancion("Amanece"));
            Canciones.Add(new Cancion("Ni bien ni mal"));
            Canciones.Add(new Cancion("Calma"));
            Canciones.Add(new Cancion("Mujer bruja"));

            Canciones.Add(new Cancion("Malamente"));
            Canciones.Add(new Cancion("Telefono"));
            Canciones.Add(new Cancion("Vaina loca"));
            Canciones.Add(new Cancion("Bubalu"));
            Canciones.Add(new Cancion("Esta rico"));

            Canciones.Add(new Cancion("Lo siento"));
            Canciones.Add(new Cancion("Ibiza"));
            Canciones.Add(new Cancion("Replay"));
            Canciones.Add(new Cancion("Asesina"));
            Canciones.Add(new Cancion("ta to gucci"));

            Canciones.Add(new Cancion("Mujeres"));
            Canciones.Add(new Cancion("Mala mia"));
            Canciones.Add(new Cancion("Bebe"));
            Canciones.Add(new Cancion("Cuando te bese"));
            Canciones.Add(new Cancion("Sin pijama"));

            BindingContext = this;
        }


    }
}
