namespace cadastro_de_funcionarios
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblTextoLogon = new System.Windows.Forms.Label();
            this.lblTextoCadastro = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTextoLogon
            // 
            this.lblTextoLogon.AutoSize = true;
            this.lblTextoLogon.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoLogon.Location = new System.Drawing.Point(270, 107);
            this.lblTextoLogon.Name = "lblTextoLogon";
            this.lblTextoLogon.Size = new System.Drawing.Size(243, 21);
            this.lblTextoLogon.TabIndex = 0;
            this.lblTextoLogon.Text = "Entre com seu Login de Operador";
            this.lblTextoLogon.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTextoCadastro
            // 
            this.lblTextoCadastro.AutoSize = true;
            this.lblTextoCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCadastro.Location = new System.Drawing.Point(213, 61);
            this.lblTextoCadastro.Name = "lblTextoCadastro";
            this.lblTextoCadastro.Size = new System.Drawing.Size(367, 25);
            this.lblTextoCadastro.TabIndex = 1;
            this.lblTextoCadastro.Text = "Gerenciamento de Funcionários da UniLus";
            // 
            // textUsuario
            // 
            this.textUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsuario.Location = new System.Drawing.Point(257, 142);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(274, 35);
            this.textUsuario.TabIndex = 2;
            this.textUsuario.Text = "Usuário";
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(257, 193);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '•';
            this.textSenha.Size = new System.Drawing.Size(274, 36);
            this.textSenha.TabIndex = 3;
            this.textSenha.Text = "Senha";
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(290, 267);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel.Location = new System.Drawing.Point(402, 267);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(96, 20);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Cadastre-se";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblTextoCadastro);
            this.Controls.Add(this.lblTextoLogon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoLogon;
        private System.Windows.Forms.Label lblTextoCadastro;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

