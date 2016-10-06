using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCetafet.View
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdHotelCetafestDataSet.Profissao' table. You can move, or remove it, as needed.
            this.profissaoTableAdapter.Fill(this.bdHotelCetafestDataSet.Profissao);
            // TODO: This line of code loads data into the 'bdHotelCetafestDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bdHotelCetafestDataSet.Pais);
            // TODO: This line of code loads data into the 'bdHotelCetafestDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bdHotelCetafestDataSet.Cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdHotelCetafestDataSet);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "nome like '"+txtPesquisa.Text+"%'";
        }
    }
}
