using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstadisticaPelotaEnlaceDatos;

namespace EstadisticaVista
{
    public partial class MantPelotero : Form
    {
        jugadoresDALC datos = new jugadoresDALC();
        public MantPelotero()
        {
            InitializeComponent();
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int equipo = Convert.ToInt32(equipoIdComboBox.SelectedValue.ToString());
            int posicion = Convert.ToInt32(posicionIDComboBox.SelectedValue.ToString());
           int liga = Convert.ToInt32(ligasComboBox.SelectedValue.ToString());
            
            datos.SetJugadores(nombreTextBox.Text, poncheTextBox.Text, hitsTextBox.Text, carrerasTextBox.Text, homeRunTextBox.Text, equipo, posicion, liga);
            
            
        }

        private void MantPelotero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estadisticaDbDataSet.Ligas' table. You can move, or remove it, as needed.
            this.ligasTableAdapter1.Fill(this.estadisticaDbDataSet.Ligas);
            // TODO: This line of code loads data into the 'estadisticaDbDataSet.Posiciones' table. You can move, or remove it, as needed.
            this.posicionesTableAdapter1.Fill(this.estadisticaDbDataSet.Posiciones);
            // TODO: This line of code loads data into the 'estadisticaDbDataSet.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter1.Fill(this.estadisticaDbDataSet.Equipos);
            // TODO: This line of code loads data into the 'estadisticaDbDataSet.Jugadores' table. You can move, or remove it, as needed.
            //this.jugadoresTableAdapter1.Fill(this.estadisticaDbDataSet.Jugadores);
         
        }
    }
}
