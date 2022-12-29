using System;
using System.Windows.Forms;

namespace Tu_baño_4
{
    public partial class Catalogo : Form
    {
        int CAC=1;
        
        public Catalogo()
        {
            InitializeComponent();
        }
        private void canva_Paint(object sender, PaintEventArgs e)
        {

        }
        private void XXX_Click(object sender, EventArgs e)
        {
            //Para cerrar Aplicacion
            Application.Exit();

        }
        private void Cotizar_Click_1(object sender, EventArgs e)
        {
            //Limpiamos pantalla 
            Pantalla.Clear();
            //Definimos variable
            double N1=0, N2=0, N3 = 0, N4 = 0, N5 = 0, N6 = 0, N7 = 0, N8 = 0, N9 = 0, N10 = 0, N11 = 0, N12 = 0;
            double TT, ITB_T, TTTT;
            string L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12;
            // Proceso de registro
            if (A1.Checked== true)
            {
                N1= 15500; 
                L1 = "A1  Tina de baño                 " + N1;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L1 + "\r\n");
            }
            if (A2.Checked == true)
            {
                N2 = 15500;
                L2 = "A2  Tina de baño                 " + N2;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L2 + "\r\n");
            }
            if (A3.Checked == true)
            {
                N3 = 15500;
                L3 = "A3  Tina de baño                 " + N3;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L3 + "\r\n");
            }
            if (A4.Checked == true)
            {
                N4 = 12350;
                L4= "A4  Lava manos                    " + N4;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L4 + "\r\n");

            }
            if (A5.Checked == true)
            {
                N5 = 10350;
                L5 = "A5  Espejo                       " + N5;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L5 + "\r\n");
            }
            if (A6.Checked == true)
            {
                N6 = 10350; 
                L6 = "A6  Espejo                       " + N6;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L6) + "\r\n";
            }
            if (A7.Checked == true)
            {
                N7 = 6350;
                L7 = "A7  Dispensador                  " + N7;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L7 + "\r\n");
            }
            if (A8.Checked == true)
            {
                N8 = 10350;
                L8 = "A8  Espejo                       " + N8;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L8 + "\r\n");
            }
            if (A9.Checked == true)
            {
                N9 = 5350;
                L9 = "A9  Dispensadores                " + N9;
                    Pantalla.Text = Pantalla.Text + Convert.ToString(L9 + "\r\n");
            }
            if (A10.Checked == true)
            {
                N10 = 7350;
                L10= "A10 Lava manos                   " + N10;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L10 + "\r\n");
            }
            if (A11.Checked == true)
            {
                N11 = 9350;
                L11 = "A11 Lava manos                  " + N11;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L11 + "\r\n");

            }
            if (A12.Checked == true)
            {
                N12 = 3350;
                L12 = "A12 Pota Toalla                 " + N12;
                Pantalla.Text = Pantalla.Text + Convert.ToString(L12 + "\r\n");
            }
            //Sobrescribir datos y operaciones
            ITB.Text = ""; 
            TTT.Text = ""; 
            Sub_TT.Text = "";
            TT = N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 + N10 + N11 + N12;
            ITB_T = TT/100*18;
            TTTT = TT + ITB_T;
            ITB.Text=ITB.Text +Convert.ToString(ITB_T);
            Sub_TT.Text = Sub_TT.Text + Convert.ToString(TT);
            TTT.Text=TTT.Text + Convert.ToString(TTTT);
        }
        private void Comprar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CAC; i++)
            {

                //en este bloque se guardaran las facturas en euna base de datos en una vesion mejorada en la posteridad

                if (CAC==10)
                {
                    DialogResult F = MessageBox.Show(Convert.ToString(CAC), " ya esta bueno, Pa tu casa", MessageBoxButtons.OK);
                } 
            }  
            DialogResult E = MessageBox.Show(" Numero de factura  "+Convert.ToString(CAC), "Cantidad", MessageBoxButtons.OK);
            CAC++;
            //Entrar o salir de la app
            DialogResult R =MessageBox.Show("Comprar mas?","Factura Registrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.No) 
            {
                Application.Exit();
            }
            if (R == DialogResult.Yes)
            {
                Pantalla.Clear();
                ITB.Text = "";
                TTT.Text = "";
                Sub_TT.Text = "";
            }
        }
    }
}
