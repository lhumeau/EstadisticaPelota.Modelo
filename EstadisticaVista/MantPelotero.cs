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
            int posicion = Convert.ToInt32(tipoComboBox.SelectedValue.ToString());
            int liga = Convert.ToInt32(tipoComboBox1.SelectedValue.ToString());
            
            datos.SetJugadores(nombreTextBox.Text, poncheTextBox.Text, hitsTextBox.Text, carrerasTextBox.Text, homeRunTextBox.Text, equipo, posicion, liga);
            
            
        }

        private void MantPelotero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbestadisticaDataSetVista.Ligas' Puede moverla o quitarla según sea necesario.
    
            // TODO: esta línea de código carga datos en la tabla 'dbestadisticaDataSetVista.Posiciones' Puede moverla o quitarla según sea necesario.
            this.posicionesTableAdapter.Fill(this.dbestadisticaDataSetVista.Posiciones);
            // TODO: esta línea de código carga datos en la tabla 'dbestadisticaDataSetVista.Jugadores' Puede moverla o quitarla según sea necesario.
            this.jugadoresTableAdapter.Fill(this.dbestadisticaDataSetVista.Jugadores);
            // TODO: esta línea de código carga datos en la tabla 'dbestadisticaDataSetVista.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.dbestadisticaDataSetVista.Equipos);

        }
    }
}
