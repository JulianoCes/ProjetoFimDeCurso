namespace MASYEV1
{
    partial class FrmCadUsuario
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
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.AllowUserToAddRows = false;
            this.DgvUsuario.AllowUserToDeleteRows = false;
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Location = new System.Drawing.Point(7, 278);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.ReadOnly = true;
            this.DgvUsuario.Size = new System.Drawing.Size(423, 97);
            this.DgvUsuario.TabIndex = 61;
            this.DgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuario_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(235, 69);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 60;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 181);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 27);
            this.btnSair.TabIndex = 59;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(342, 146);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 27);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(342, 108);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 27);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(55, 178);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(174, 20);
            this.txtFone.TabIndex = 56;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(56, 139);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(177, 20);
            this.txtCpf.TabIndex = 55;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 54;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(11, 181);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 53;
            this.lblFone.Text = "Fone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(11, 146);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 52;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 74);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 50;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 49;
            this.lblId.Text = "ID";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(342, 69);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(88, 27);
            this.btnInserir.TabIndex = 48;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(56, 246);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(125, 20);
            this.txtFuncao.TabIndex = 65;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(55, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 64;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(11, 253);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(43, 13);
            this.lblFuncao.TabIndex = 63;
            this.lblFuncao.Text = "Funcão";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "E-mail";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.DgvUsuario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnInserir);
            this.Name = "FrmCadUsuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblEmail;
    }
}