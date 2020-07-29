namespace SorteoRifa
{
    using Data.Entities;
    using SorteoRifa.Data;
    using System.Windows;
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly DataContext context = new DataContext();
        public readonly IPersonaRepository personaRepository = new PersonaRepository(context);
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Nombre, Direccion;
            Nombre = tbNombre.Text;
            Direccion = tbDireccion.Text;
            Persona persona = new Persona();
            persona.Name = Nombre;
            persona.Address = Direccion;
            personaRepository.Create(persona);
        }
    }
}
