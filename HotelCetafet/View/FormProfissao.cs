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
    public partial class FormProfissao : Form
    {
        public FormProfissao()
        {
            InitializeComponent();
        }

        private void profissaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.profissaoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdHotelCetafestDataSet);
                Msg.sucesso("Dados salvos com sucesso.");
                this.profissaoTableAdapter.Fill(this.bdHotelCetafestDataSet.Profissao);
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

        private void FormProfissao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdHotelCetafestDataSet.Profissao' table. You can move, or remove it, as needed.
            this.profissaoTableAdapter.Fill(this.bdHotelCetafestDataSet.Profissao);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Msg.simNao("Realmente Deseja Excluir?") == DialogResult.Yes)
            {

                try
                {
                    this.profissaoBindingSource.RemoveCurrent();
                    this.Validate();
                    this.profissaoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bdHotelCetafestDataSet);
                    Msg.sucesso("Removido com sucesso.");
                    this.profissaoTableAdapter.Fill(this.bdHotelCetafestDataSet.Profissao);
                }
                catch (Exception ex)
                {
                    Msg.erro("Não foi possivel remover os dados.\nO sistema não está conseguindo se conectar com o servidor!");
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            profissaoBindingSource.Filter = "descricao like '%"+txtPesquisa.Text+"%'";
        }
    }
}
