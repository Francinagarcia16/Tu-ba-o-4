using System;
using System.Windows.Forms;

namespace Tu_baño_4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /* ya que esta es una beta, 
           me limite a no crear una base de datos, 
           ya que esta app para escritorio,
           esta diseñada para visualizar funciones futuras,
           y la paleta de colores mas agradable al publico
        */
       
        private void Acceder_Click(object sender, EventArgs e)
        {   
            // Comprovacion
          
            if (Usuario.Text == "21-SIIN-1-124" && Contraseña.Text == "12345")
            {
                //Abrir otro formulario
                Catalogo Cata = new Catalogo();
                Cata.Show();
                this.Hide();
            }
            else
            {
                //MSM en pantalla
                Contra_I.Text = "Contraseña o usuario incorrectos";           
            }
        }

    }
}
