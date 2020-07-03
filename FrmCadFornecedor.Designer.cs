namespace MASYEV1
{
    partial class FrmCadFornecedor
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
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInseri = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(53, 291);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(485, 100);
            this.dgvFornecedor.TabIndex = 13;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(108, 257);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 7;
            // 
            // txtCnpj
            // 
            this.txtCnpj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCnpj.Location = new System.Drawing.Point(83, 128);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(199, 20);
            this.txtCnpj.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Location = new System.Drawing.Point(453, 220);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 46);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.Location = new System.Drawing.Point(453, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 50);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.Location = new System.Drawing.Point(453, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 46);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInseri
            // 
            this.btnInseri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInseri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInseri.Location = new System.Drawing.Point(453, 57);
            this.btnInseri.Name = "btnInseri";
            this.btnInseri.Size = new System.Drawing.Size(98, 47);
            this.btnInseri.TabIndex = 9;
            this.btnInseri.Text = "Cadastrar";
            this.btnInseri.UseVisualStyleBackColor = true;
            this.btnInseri.Click += new System.EventHandler(this.btnInseri_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBusca.Location = new System.Drawing.Point(303, 57);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(98, 32);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(83, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTelefone.Location = new System.Drawing.Point(83, 194);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(199, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEndereco.Location = new System.Drawing.Point(83, 160);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(318, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(83, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtId.Location = new System.Drawing.Point(83, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 95;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 94;
            this.lblEmail.Text = "E-mail";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(11, 257);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 13);
            this.lblData.TabIndex = 93;
            this.lblData.Text = "Dada Cadastro";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(15, 194);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(57, 13);
            this.lblTelefone.TabIndex = 92;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(42, 131);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 13);
            this.lblCpf.TabIndex = 91;
            this.lblCpf.Text = "CNPJ";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(11, 163);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 90;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 89;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(50, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 13);
            this.lblId.TabIndex = 88;
            this.lblId.Text = "ID";
            // 
            // FrmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 406);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInseri);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "FrmCadFornecedor";
            this.Text = "FrmCadFornecedor";
            this.Load += new System.EventHandler(this.FrmCadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInseri;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
    }
}