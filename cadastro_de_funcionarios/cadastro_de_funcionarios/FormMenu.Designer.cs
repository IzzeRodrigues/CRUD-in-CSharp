namespace cadastro_de_funcionarios
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblWel = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnNovoFun = new System.Windows.Forms.Button();
            this.btnNovoProd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.lblWel.Location = new System.Drawing.Point(305, 43);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(64, 25);
            this.lblWel.TabIndex = 0;
            this.lblWel.Text = "INFOS";
            this.lblWel.Click += new System.EventHandler(this.lblWel_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.lblMenu.Location = new System.Drawing.Point(253, 103);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(279, 25);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Selecione uma Função a Operar";
            this.lblMenu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnNovoFun
            // 
            this.btnNovoFun.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFun.Location = new System.Drawing.Point(228, 152);
            this.btnNovoFun.Name = "btnNovoFun";
            this.btnNovoFun.Size = new System.Drawing.Size(127, 80);
            this.btnNovoFun.TabIndex = 2;
            this.btnNovoFun.Text = "Cadastrar novo funcionário";
            this.btnNovoFun.UseVisualStyleBackColor = true;
            this.btnNovoFun.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoProd
            // 
            this.btnNovoProd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProd.Location = new System.Drawing.Point(418, 152);
            this.btnNovoProd.Name = "btnNovoProd";
            this.btnNovoProd.Size = new System.Drawing.Size(127, 80);
            this.btnNovoProd.TabIndex = 3;
            this.btnNovoProd.Text = "Solicitar Material Didático";
            this.btnNovoProd.UseVisualStyleBackColor = true;
            this.btnNovoProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(418, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 80);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fechar Programa";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(228, 272);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(127, 80);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver Operadores cadastrados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNovoProd);
            this.Controls.Add(this.btnNovoFun);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblWel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnNovoFun;
        private System.Windows.Forms.Button btnNovoProd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVer;
    }
}