using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstadisticaVista
{
            
    public partial class Main : Form
    {
        MantPelotero vistapelotero = new MantPelotero();
        
        public Main()
        {
            InitializeComponent();
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            vistapelotero.MdiParent = this; // hacemos el formulario form1 como padre
            vistapelotero.Show();// Mostramos el form mantenimiento pelotero
            vistapelotero.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = ""); //Limpiamos todos los texto box


                

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
