using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace EstadisticaVista.Equipo
{
    public partial class Ligaagregar : Form
    {
        public Ligaagregar()
        {
            InitializeComponent();
        }
  

        private void ligasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ligasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estadisticaDbDataSet);

        }

        private void Ligaagregar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estadisticaDbDataSet.Ligas' table. You can move, or remove it, as needed.
            this.ligasTableAdapter.Fill(this.estadisticaDbDataSet.Ligas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ligaagregar liga = new Ligaagregar();
            JugadoresCN.LimpiarTextBox(liga);

        }
    }
}
