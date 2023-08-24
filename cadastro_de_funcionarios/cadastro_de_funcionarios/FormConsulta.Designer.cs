namespace cadastro_de_funcionarios
{
    partial class FormConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gridConst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridConst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(222, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista nomes de Funcionários Cadastrados";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(99, 393);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(83, 27);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "VOLTAR";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // gridConst
            // 
            this.gridConst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConst.Location = new System.Drawing.Point(99, 59);
            this.gridConst.Name = "gridConst";
            this.gridConst.Size = new System.Drawing.Size(602, 308);
            this.gridConst.TabIndex = 9;
            this.gridConst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConst_CellContentClick);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gridConst);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView gridConst;
    }
}