using LibreriasJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace InterfazJuego
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Inicializar el Juego
            Juego.dameElJuego();
            cargarContinentes();

        }

        private void cargarContinentes()
        {
            Juego.dameElJuego().baseDatosGeografica.getContinentes().ToList().ForEach(
                (continente) => cmb_Continentes.Items.Add(continente.nombre));
            
        }

        private void Btn_Jugar_Click(object sender, RoutedEventArgs e)
        {
            var nombreJugador = txt_Jugador.Text;
            string nombreContinente = cmb_Continentes.SelectedItem.ToString();

            //Creamos un objeto continente
            IContinente continente = Juego.dameElJuego().baseDatosGeografica.getContinente(nombreContinente);

            // Mirar si el jugador existe.
            // Si existe, lo recupero. Si no existe, lo doy de alta
            IJugador jugador = Juego.dameElJuego().baseDatosJugadores.getOrCreateJugador(nombreJugador);

            // Crear una partida para el jugador 
            IPartida partida = jugador.nuevaPartida(continente);

            // Lanzar la ventana del juego
            GameWindow ventanaJuego = new GameWindow(partida);
            ventanaJuego.Show();

        }
    }
}
