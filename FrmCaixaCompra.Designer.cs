namespace MASYEV1
{
    partial class FrmCaixaCompra
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.DgvCaixaCompra = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblKgOuUnit = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxNomeProduto = new System.Windows.Forms.ComboBox();
            this.cbxMarcaProduto = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLogado = new System.Windows.Forms.Label();
            this.bntLocalizar = new System.Windows.Forms.Button();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaixaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(481, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 30);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.Green;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(17, 339);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(133, 40);
            this.btnAdicionarItem.TabIndex = 29;
            this.btnAdicionarItem.Text = "Adicionar Estoque";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // DgvCaixaCompra
            // 
            this.DgvCaixaCompra.AllowUserToAddRows = false;
            this.DgvCaixaCompra.AllowUserToDeleteRows = false;
            this.DgvCaixaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCaixaCompra.Location = new System.Drawing.Point(20, 208);
            this.DgvCaixaCompra.Name = "DgvCaixaCompra";
            this.DgvCaixaCompra.ReadOnly = true;
            this.DgvCaixaCompra.Size = new System.Drawing.Size(546, 124);
            this.DgvCaixaCompra.TabIndex = 28;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(269, 161);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 26;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(95, 157);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(55, 20);
            this.txtQuantidade.TabIndex = 25;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(17, 160);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 13);
            this.lblQuantidade.TabIndex = 22;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(227, 164);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(27, 186);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(119, 66);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(55, 112);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(131, 21);
            this.cbxTipo.TabIndex = 65;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(17, 115);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 64;
            this.lblTipo.Text = "Tipo";
            // 
            // lblKgOuUnit
            // 
            this.lblKgOuUnit.AutoSize = true;
            this.lblKgOuUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgOuUnit.Location = new System.Drawing.Point(156, 164);
            this.lblKgOuUnit.Name = "lblKgOuUnit";
            this.lblKgOuUnit.Size = new System.Drawing.Size(67, 13);
            this.lblKgOuUnit.TabIndex = 66;
            this.lblKgOuUnit.Text = "Kg ou Unit";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(192, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 70;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(17, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 13);
            this.lblId.TabIndex = 69;
            this.lblId.Text = "ID";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(367, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 71;
            this.lblMarca.Text = "Marca";
            // 
            // cbxNomeProduto
            // 
            this.cbxNomeProduto.FormattingEnabled = true;
            this.cbxNomeProduto.Location = new System.Drawing.Point(230, 112);
            this.cbxNomeProduto.Name = "cbxNomeProduto";
            this.cbxNomeProduto.Size = new System.Drawing.Size(131, 21);
            this.cbxNomeProduto.TabIndex = 73;
            // 
            // cbxMarcaProduto
            // 
            this.cbxMarcaProduto.FormattingEnabled = true;
            this.cbxMarcaProduto.Location = new System.Drawing.Point(415, 112);
            this.cbxMarcaProduto.Name = "cbxMarcaProduto";
            this.cbxMarcaProduto.Size = new System.Drawing.Size(151, 21);
            this.cbxMarcaProduto.TabIndex = 74;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(430, 160);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 20);
            this.txtUsuario.TabIndex = 76;
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.Location = new System.Drawing.Point(375, 164);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(49, 13);
            this.lblLogado.TabIndex = 75;
            this.lblLogado.Text = "Logado";
            // 
            // bntLocalizar
            // 
            this.bntLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLocalizar.Location = new System.Drawing.Point(464, 59);
            this.bntLocalizar.Name = "bntLocalizar";
            this.bntLocalizar.Size = new System.Drawing.Size(102, 33);
            this.bntLocalizar.TabIndex = 77;
            this.bntLocalizar.Text = "Buscar";
            this.bntLocalizar.UseVisualStyleBackColor = false;
            this.bntLocalizar.Click += new System.EventHandler(this.bntLocalizar_Click);
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(175, 63);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(194, 21);
            this.cbxCodigo.TabIndex = 78;
            this.cbxCodigo.SelectedIndexChanged += new System.EventHandler(this.cbxCodigo_SelectedIndexChanged);
            // 
            // FrmCaixaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 386);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.bntLocalizar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.cbxMarcaProduto);
            this.Controls.Add(this.cbxNomeProduto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblKgOuUnit);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.DgvCaixaCompra);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCaixaCompra";
            this.Text = "Caixa Para Compra";
            this.Load += new System.EventHandler(this.FrmCaixaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaixaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.DataGridView DgvCaixaCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblKgOuUnit;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxNomeProduto;
        private System.Windows.Forms.ComboBox cbxMarcaProduto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.Button bntLocalizar;
        private System.Windows.Forms.ComboBox cbxCodigo;
    }
}