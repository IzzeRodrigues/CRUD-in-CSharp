namespace cadastro_de_funcionarios
{
    partial class FormInfos
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
            this.textInfos = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInfos
            // 
            this.textInfos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textInfos.Enabled = false;
            this.textInfos.Location = new System.Drawing.Point(93, 70);
            this.textInfos.Multiline = true;
            this.textInfos.Name = "textInfos";
            this.textInfos.Size = new System.Drawing.Size(609, 322);
            this.textInfos.TabIndex = 0;
            this.textInfos.TextChanged += new System.EventHandler(this.textInfos_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(282, 398);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 27);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(225, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista nomes de Funcionários Cadastrados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(422, 398);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 27);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "SALVAR COMO";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textInfos);
            this.Name = "FormInfos";
            this.Text = "FormInfos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInfos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
    }
}