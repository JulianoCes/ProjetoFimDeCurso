namespace MASYEV1
{
    partial class FrmPedidoDelivery
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
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.bntLocalizar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLogado = new System.Windows.Forms.Label();
            this.cbxCorte = new System.Windows.Forms.ComboBox();
            this.lblCoter = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblKgOuUnit = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.dgvPedidoDelivery = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionarPedido = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(190, 72);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(209, 21);
            this.cbxCodigo.TabIndex = 100;
            // 
            // bntLocalizar
            // 
            this.bntLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLocalizar.Location = new System.Drawing.Point(423, 70);
            this.bntLocalizar.Name = "bntLocalizar";
            this.bntLocalizar.Size = new System.Drawing.Size(116, 33);
            this.bntLocalizar.TabIndex = 99;
            this.bntLocalizar.Text = "Buscar";
            this.bntLocalizar.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(445, 158);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 20);
            this.txtUsuario.TabIndex = 98;
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.Location = new System.Drawing.Point(390, 162);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(49, 13);
            this.lblLogado.TabIndex = 97;
            this.lblLogado.Text = "Logado";
            // 
            // cbxCorte
            // 
            this.cbxCorte.FormattingEnabled = true;
            this.cbxCorte.Location = new System.Drawing.Point(445, 109);
            this.cbxCorte.Name = "cbxCorte";
            this.cbxCorte.Size = new System.Drawing.Size(151, 21);
            this.cbxCorte.TabIndex = 96;
            // 
            // lblCoter
            // 
            this.lblCoter.AutoSize = true;
            this.lblCoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoter.Location = new System.Drawing.Point(405, 112);
            this.lblCoter.Name = "lblCoter";
            this.lblCoter.Size = new System.Drawing.Size(37, 13);
            this.lblCoter.TabIndex = 94;
            this.lblCoter.Text = "Corte";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 93;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(32, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 13);
            this.lblId.TabIndex = 92;
            this.lblId.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(187, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 91;
            this.lblNome.Text = "Nome";
            // 
            // lblKgOuUnit
            // 
            this.lblKgOuUnit.AutoSize = true;
            this.lblKgOuUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgOuUnit.Location = new System.Drawing.Point(171, 162);
            this.lblKgOuUnit.Name = "lblKgOuUnit";
            this.lblKgOuUnit.Size = new System.Drawing.Size(67, 13);
            this.lblKgOuUnit.TabIndex = 90;
            this.lblKgOuUnit.Text = "Kg ou Unit";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(70, 110);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(110, 21);
            this.cbxTipo.TabIndex = 89;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(32, 113);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 88;
            this.lblTipo.Text = "Tipo";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(613, 355);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 30);
            this.btnSair.TabIndex = 87;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.Green;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(245, 355);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(154, 34);
            this.btnAdicionarItem.TabIndex = 86;
            this.btnAdicionarItem.Text = "Finalizar Pedido";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // dgvPedidoDelivery
            // 
            this.dgvPedidoDelivery.AllowUserToAddRows = false;
            this.dgvPedidoDelivery.AllowUserToDeleteRows = false;
            this.dgvPedidoDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoDelivery.Location = new System.Drawing.Point(35, 228);
            this.dgvPedidoDelivery.Name = "dgvPedidoDelivery";
            this.dgvPedidoDelivery.ReadOnly = true;
            this.dgvPedidoDelivery.Size = new System.Drawing.Size(677, 124);
            this.dgvPedidoDelivery.TabIndex = 85;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(284, 159);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 84;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(110, 155);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(55, 20);
            this.txtQuantidade.TabIndex = 83;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(32, 158);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 13);
            this.lblQuantidade.TabIndex = 82;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(242, 162);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 81;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(42, 212);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 80;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(134, 75);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 79;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(224, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 101;
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.BackColor = System.Drawing.Color.Gray;
            this.btnAdicionarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPedido.Location = new System.Drawing.Point(445, 189);
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.Size = new System.Drawing.Size(151, 33);
            this.btnAdicionarPedido.TabIndex = 102;
            this.btnAdicionarPedido.Text = "Adicional Pedido";
            this.btnAdicionarPedido.UseVisualStyleBackColor = false;
            this.btnAdicionarPedido.Click += new System.EventHandler(this.btnAdicionarPedido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 104;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(35, 365);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(69, 13);
            this.lblValorTotal.TabIndex = 103;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(613, 72);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(99, 45);
            this.btnAtualizar.TabIndex = 105;
            this.btnAtualizar.Text = "Editar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(613, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 44);
            this.btnExcluir.TabIndex = 106;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // FrmPedidoDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 397);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnAdicionarPedido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.bntLocalizar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.cbxCorte);
            this.Controls.Add(this.lblCoter);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblKgOuUnit);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.dgvPedidoDelivery);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmPedidoDelivery";
            this.Text = "Pedido Para Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.Button bntLocalizar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.ComboBox cbxCorte;
        private System.Windows.Forms.Label lblCoter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblKgOuUnit;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.DataGridView dgvPedidoDelivery;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}