using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void distribuidoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.distribuidoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ferreteriaDBDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDBDataSet.Distribuidores' Puede moverla o quitarla según sea necesario.
            this.distribuidoresTableAdapter.Fill(this.ferreteriaDBDataSet.Distribuidores);

        }
    }
}
