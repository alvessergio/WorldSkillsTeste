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

        private void button1_Click(object sender, EventArgs e)
        {            
            Pais novoPais = new Pais();
            novoPais.nome = textBox1.Text;
            novoPais.sigla = textBox2.Text;
            novoPais.Populacao = Convert.ToInt32(textBox3.Text);
            PaisDAO savePais = new PaisDAO();
           // savePais.setCadastrarPais(novoPais);
        }
        

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            PaisDAO listaPais = new PaisDAO();
            bindingSource1.DataSource = listaPais.getPaises();
            dataGridView1.DataSource = bindingSource1;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            PaisDAO listaPais = new PaisDAO();
            bindingSource1.DataSource = listaPais.getPaisLetraInicial(textBox4.Text);
            dataGridView1.DataSource = bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pais paisAlterar = (Pais)bindingSource1.Current;
            PaisDAO dao = new PaisDAO();
            dao.setAtualizar(paisAlterar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaisDAO dao = new PaisDAO();
            dao.setApagar((Pais) bindingSource1.Current);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            PaisDAO dao = new PaisDAO();
            dao.setApagar((Pais)bindingSource1.Current);
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            PaisDAO listaPais = new PaisDAO();
            bindingSource1.DataSource = listaPais.getPaises();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = false;

            textBox1.DataBindings.Add("Text", bindingSource1, "nome", true);
            textBox2.DataBindings.Add("Text", bindingSource1, "sigla", true);
            textBox3.DataBindings.Add("Text", bindingSource1, "Populacao", true);
        }
    }
}
