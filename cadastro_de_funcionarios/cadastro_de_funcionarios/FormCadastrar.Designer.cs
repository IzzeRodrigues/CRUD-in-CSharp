namespace cadastro_de_funcionarios
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            this.lblCad = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFun = new System.Windows.Forms.ComboBox();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVolar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.lblCad.Location = new System.Drawing.Point(42, 35);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(383, 25);
            this.lblCad.TabIndex = 2;
            this.lblCad.Text = "Cadastre um novo funcionário da Faculdade";
            this.lblCad.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCad.Click += new System.EventHandler(this.lblCad_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(47, 110);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(449, 29);
            this.textNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 21);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data de Nascimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOut);
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Controls.Add(this.radioFem);
            this.groupBox1.Location = new System.Drawing.Point(47, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // radioOut
            // 
            this.radioOut.AutoSize = true;
            this.radioOut.Location = new System.Drawing.Point(230, 19);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(109, 17);
            this.radioOut.TabIndex = 16;
            this.radioOut.TabStop = true;
            this.radioOut.Text = "Não Especificado";
            this.radioOut.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(130, 19);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 15;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Location = new System.Drawing.Point(27, 19);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(67, 17);
            this.radioFem.TabIndex = 14;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de Contratação";
            // 
            // comboFun
            // 
            this.comboFun.AllowDrop = true;
            this.comboFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFun.FormattingEnabled = true;
            this.comboFun.Items.AddRange(new object[] {
            "CLT",
            "Estagiário",
            "Jovem Aprendiz",
            "CNPJ"});
            this.comboFun.Location = new System.Drawing.Point(47, 300);
            this.comboFun.Name = "comboFun";
            this.comboFun.Size = new System.Drawing.Size(449, 21);
            this.comboFun.TabIndex = 12;
            // 
            // btnContratos
            // 
            this.btnContratos.Location = new System.Drawing.Point(187, 346);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(101, 23);
            this.btnContratos.TabIndex = 16;
            this.btnContratos.Text = "Salvar Contrato";
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(294, 346);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(98, 23);
            this.btnForm.TabIndex = 18;
            this.btnForm.Text = "Ver contratos";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(398, 346);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 23);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar Banco";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVolar
            // 
            this.btnVolar.Location = new System.Drawing.Point(47, 346);
            this.btnVolar.Name = "btnVolar";
            this.btnVolar.Size = new System.Drawing.Size(102, 23);
            this.btnVolar.TabIndex = 20;
            this.btnVolar.Text = "Voltar";
            this.btnVolar.UseVisualStyleBackColor = true;
            this.btnVolar.Click += new System.EventHandler(this.btnVolar_Click);
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.btnContratos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lblCad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrar";
            this.Text = "FormCadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.ComboBox comboFun;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVolar;
    }
}