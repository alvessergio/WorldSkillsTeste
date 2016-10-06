using HotelCetafet.Modelo;
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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            this.paisTableAdapter.Fill(this.bdHotelCetafestDataSet.Pais);
        }

        private void paisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdHotelCetafestDataSet);
                Msg.sucesso("Dados salvos com sucesso.");
                this.paisTableAdapter.Fill(this.bdHotelCetafestDataSet.Pais);
            }
            catch (Exception ex) 
            {
                if (ex.Message.Contains("null"))
                {
                    Msg.atencao("Preencha todos os campos.");
                }
                else
                {
                    Msg.erro("Não foi possivel salvar os dados.\nO sistema não está conseguindo se conectar com o servidor!");
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            paisBindingSource.Filter = "nome like '"+txtPesquisa.Text+"%' or sigla like '"+txtPesquisa.Text+"%' or continente like '"+txtPesquisa.Text+"%'";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Msg.simNao("Realmente Deseja Excluir?") == DialogResult.Yes)
            {
               
                try
                {
                    this.paisBindingSource.RemoveCurrent();
                    this.Validate();
                    this.paisBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bdHotelCetafestDataSet);
                    Msg.sucesso("Removido com sucesso.");
                    this.paisTableAdapter.Fill(this.bdHotelCetafestDataSet.Pais);
                }
                catch (Exception ex)
                {
                    Msg.erro("Não foi possivel remover os dados.\nO sistema não está conseguindo se conectar com o servidor!");
                }
            }
        }
    }
}
