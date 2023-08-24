namespace cadastro_de_funcionarios
{
    partial class FormAdministar
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
            this.gridAdm = new System.Windows.Forms.DataGridView();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAdm
            // 
            this.gridAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdm.Location = new System.Drawing.Point(99, 51);
            this.gridAdm.Name = "gridAdm";
            this.gridAdm.Size = new System.Drawing.Size(602, 308);
            this.gridAdm.TabIndex = 0;
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(446, 365);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(120, 47);
            this.btnExclui.TabIndex = 2;
            this.btnExclui.Text = "EXCLUIR";
            this.btnExclui.UseVisualStyleBackColor = true;
            // 
            // btnAltera
            // 
            this.btnAltera.Location = new System.Drawing.Point(581, 365);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(120, 47);
            this.btnAltera.TabIndex = 3;
            this.btnAltera.Text = "ALTERAR";
            this.btnAltera.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(309, 365);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(120, 47);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "CONSULTAR";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(99, 385);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(83, 27);
            this.btnVolta.TabIndex = 5;
            this.btnVolta.Text = "VOLTAR";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(222, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista nomes de operadores Cadastrados";
            // 
            // FormAdministar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.gridAdm);
            this.Name = "FormAdministar";
            this.Text = "FormAdministar";
            this.Load += new System.EventHandler(this.FormAdministar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAdm;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Label label1;
    }
}