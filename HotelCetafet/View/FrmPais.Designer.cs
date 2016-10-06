namespace HotelCetafet.View
{
    partial class FrmPais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label siglaLabel;
            System.Windows.Forms.Label populacaoLabel;
            System.Windows.Forms.Label continenteLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPais));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdHotelCetafestDataSet = new HotelCetafet.bdHotelCetafestDataSet();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter = new HotelCetafet.bdHotelCetafestDataSetTableAdapters.PaisTableAdapter();
            this.tableAdapterManager = new HotelCetafet.bdHotelCetafestDataSetTableAdapters.TableAdapterManager();
            this.paisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.paisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.siglaTextBox = new System.Windows.Forms.TextBox();
            this.populacaoTextBox = new System.Windows.Forms.TextBox();
            this.continenteTextBox = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            siglaLabel = new System.Windows.Forms.Label();
            populacaoLabel = new System.Windows.Forms.Label();
            continenteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdHotelCetafestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingNavigator)).BeginInit();
            this.paisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 49);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // siglaLabel
            // 
            siglaLabel.AutoSize = true;
            siglaLabel.Location = new System.Drawing.Point(12, 97);
            siglaLabel.Name = "siglaLabel";
            siglaLabel.Size = new System.Drawing.Size(31, 13);
            siglaLabel.TabIndex = 6;
            siglaLabel.Text = "sigla:";
            // 
            // populacaoLabel
            // 
            populacaoLabel.AutoSize = true;
            populacaoLabel.Location = new System.Drawing.Point(125, 97);
            populacaoLabel.Name = "populacaoLabel";
            populacaoLabel.Size = new System.Drawing.Size(61, 13);
            populacaoLabel.TabIndex = 8;
            populacaoLabel.Text = "Populacao:";
            // 
            // continenteLabel
            // 
            continenteLabel.AutoSize = true;
            continenteLabel.Location = new System.Drawing.Point(314, 97);
            continenteLabel.Name = "continenteLabel";
            continenteLabel.Size = new System.Drawing.Size(61, 13);
            continenteLabel.TabIndex = 10;
            continenteLabel.Text = "Continente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(258, 161);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 13;
            label1.Text = "Pesquisa:";
            // 
            // bdHotelCetafestDataSet
            // 
            this.bdHotelCetafestDataSet.DataSetName = "bdHotelCetafestDataSet";
            this.bdHotelCetafestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.bdHotelCetafestDataSet;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = this.paisTableAdapter;
            this.tableAdapterManager.ProfissaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelCetafet.bdHotelCetafestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paisBindingNavigator
            // 
            this.paisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paisBindingNavigator.BindingSource = this.paisBindingSource;
            this.paisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paisBindingNavigator.DeleteItem = null;
            this.paisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.paisBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.paisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paisBindingNavigator.Name = "paisBindingNavigator";
            this.paisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paisBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.paisBindingNavigator.TabIndex = 0;
            this.paisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(56, 22);
            this.bindingNavigatorAddNewItem.Text = "Novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // paisBindingNavigatorSaveItem
            // 
            this.paisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paisBindingNavigatorSaveItem.Image")));
            this.paisBindingNavigatorSaveItem.Name = "paisBindingNavigatorSaveItem";
            this.paisBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.paisBindingNavigatorSaveItem.Text = "Salvar";
            this.paisBindingNavigatorSaveItem.Click += new System.EventHandler(this.paisBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Excluir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // paisDataGridView
            // 
            this.paisDataGridView.AllowUserToAddRows = false;
            this.paisDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.paisDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paisDataGridView.AutoGenerateColumns = false;
            this.paisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.paisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paisDataGridView.DataSource = this.paisBindingSource;
            this.paisDataGridView.Location = new System.Drawing.Point(12, 184);
            this.paisDataGridView.Name = "paisDataGridView";
            this.paisDataGridView.ReadOnly = true;
            this.paisDataGridView.Size = new System.Drawing.Size(503, 236);
            this.paisDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sigla";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sigla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Populacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Populacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Continente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Continente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(15, 65);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(500, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // siglaTextBox
            // 
            this.siglaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "sigla", true));
            this.siglaTextBox.Location = new System.Drawing.Point(15, 113);
            this.siglaTextBox.Name = "siglaTextBox";
            this.siglaTextBox.Size = new System.Drawing.Size(100, 20);
            this.siglaTextBox.TabIndex = 7;
            // 
            // populacaoTextBox
            // 
            this.populacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "Populacao", true));
            this.populacaoTextBox.Location = new System.Drawing.Point(128, 113);
            this.populacaoTextBox.Name = "populacaoTextBox";
            this.populacaoTextBox.Size = new System.Drawing.Size(178, 20);
            this.populacaoTextBox.TabIndex = 9;
            // 
            // continenteTextBox
            // 
            this.continenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "Continente", true));
            this.continenteTextBox.Location = new System.Drawing.Point(317, 113);
            this.continenteTextBox.Name = "continenteTextBox";
            this.continenteTextBox.Size = new System.Drawing.Size(198, 20);
            this.continenteTextBox.TabIndex = 11;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(317, 158);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(198, 20);
            this.txtPesquisa.TabIndex = 12;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 440);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(siglaLabel);
            this.Controls.Add(this.siglaTextBox);
            this.Controls.Add(populacaoLabel);
            this.Controls.Add(this.populacaoTextBox);
            this.Controls.Add(continenteLabel);
            this.Controls.Add(this.continenteTextBox);
            this.Controls.Add(this.paisDataGridView);
            this.Controls.Add(this.paisBindingNavigator);
            this.Name = "FrmPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Pais";
            this.Load += new System.EventHandler(this.FrmPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdHotelCetafestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingNavigator)).EndInit();
            this.paisBindingNavigator.ResumeLayout(false);
            this.paisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdHotelCetafestDataSet bdHotelCetafestDataSet;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private bdHotelCetafestDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private bdHotelCetafestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paisBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton paisBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView paisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox siglaTextBox;
        private System.Windows.Forms.TextBox populacaoTextBox;
        private System.Windows.Forms.TextBox continenteTextBox;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}