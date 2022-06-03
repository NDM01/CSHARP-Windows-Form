
namespace IMC
{
    partial class Form1
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
            this.gbgen = new System.Windows.Forms.GroupBox();
            this.rdfem = new System.Windows.Forms.RadioButton();
            this.rdmasc = new System.Windows.Forms.RadioButton();
            this.gbut = new System.Windows.Forms.GroupBox();
            this.ndalt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ndpeso = new System.Windows.Forms.NumericUpDown();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.bntrepor = new System.Windows.Forms.Button();
            this.gbinf = new System.Windows.Forms.GroupBox();
            this.txtrisc = new System.Windows.Forms.TextBox();
            this.txtclasp = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbgen.SuspendLayout();
            this.gbut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndpeso)).BeginInit();
            this.gbinf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbgen
            // 
            this.gbgen.Controls.Add(this.rdfem);
            this.gbgen.Controls.Add(this.rdmasc);
            this.gbgen.Location = new System.Drawing.Point(51, 42);
            this.gbgen.Name = "gbgen";
            this.gbgen.Size = new System.Drawing.Size(281, 94);
            this.gbgen.TabIndex = 0;
            this.gbgen.TabStop = false;
            this.gbgen.Text = "Género";
            // 
            // rdfem
            // 
            this.rdfem.AutoSize = true;
            this.rdfem.Location = new System.Drawing.Point(117, 38);
            this.rdfem.Name = "rdfem";
            this.rdfem.Size = new System.Drawing.Size(67, 17);
            this.rdfem.TabIndex = 1;
            this.rdfem.TabStop = true;
            this.rdfem.Text = "Feminino";
            this.rdfem.UseVisualStyleBackColor = true;
            // 
            // rdmasc
            // 
            this.rdmasc.AutoSize = true;
            this.rdmasc.Location = new System.Drawing.Point(19, 38);
            this.rdmasc.Name = "rdmasc";
            this.rdmasc.Size = new System.Drawing.Size(73, 17);
            this.rdmasc.TabIndex = 0;
            this.rdmasc.TabStop = true;
            this.rdmasc.Text = "Masculino";
            this.rdmasc.UseVisualStyleBackColor = true;
            // 
            // gbut
            // 
            this.gbut.Controls.Add(this.ndalt);
            this.gbut.Controls.Add(this.label3);
            this.gbut.Controls.Add(this.ndpeso);
            this.gbut.Controls.Add(this.txtid);
            this.gbut.Controls.Add(this.label2);
            this.gbut.Controls.Add(this.label1);
            this.gbut.Location = new System.Drawing.Point(51, 155);
            this.gbut.Name = "gbut";
            this.gbut.Size = new System.Drawing.Size(316, 103);
            this.gbut.TabIndex = 1;
            this.gbut.TabStop = false;
            this.gbut.Text = "Dados Utente";
            // 
            // ndalt
            // 
            this.ndalt.DecimalPlaces = 2;
            this.ndalt.Location = new System.Drawing.Point(235, 69);
            this.ndalt.Name = "ndalt";
            this.ndalt.Size = new System.Drawing.Size(63, 20);
            this.ndalt.TabIndex = 5;
            this.ndalt.Value = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura";
            // 
            // ndpeso
            // 
            this.ndpeso.Location = new System.Drawing.Point(63, 67);
            this.ndpeso.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ndpeso.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ndpeso.Name = "ndpeso";
            this.ndpeso.Size = new System.Drawing.Size(99, 20);
            this.ndpeso.TabIndex = 3;
            this.ndpeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(66, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(82, 20);
            this.txtid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(384, 164);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 43);
            this.btncalc.TabIndex = 2;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // bntrepor
            // 
            this.bntrepor.Location = new System.Drawing.Point(384, 211);
            this.bntrepor.Name = "bntrepor";
            this.bntrepor.Size = new System.Drawing.Size(75, 39);
            this.bntrepor.TabIndex = 3;
            this.bntrepor.Text = "Repor";
            this.bntrepor.UseVisualStyleBackColor = true;
            this.bntrepor.Click += new System.EventHandler(this.btnrepor_Click);
            // 
            // gbinf
            // 
            this.gbinf.Controls.Add(this.txtrisc);
            this.gbinf.Controls.Add(this.txtclasp);
            this.gbinf.Controls.Add(this.txtimc);
            this.gbinf.Controls.Add(this.label6);
            this.gbinf.Controls.Add(this.label5);
            this.gbinf.Controls.Add(this.label4);
            this.gbinf.Location = new System.Drawing.Point(51, 277);
            this.gbinf.Name = "gbinf";
            this.gbinf.Size = new System.Drawing.Size(298, 121);
            this.gbinf.TabIndex = 4;
            this.gbinf.TabStop = false;
            this.gbinf.Text = "Informações";
            // 
            // txtrisc
            // 
            this.txtrisc.Location = new System.Drawing.Point(117, 87);
            this.txtrisc.Name = "txtrisc";
            this.txtrisc.Size = new System.Drawing.Size(100, 20);
            this.txtrisc.TabIndex = 5;
            // 
            // txtclasp
            // 
            this.txtclasp.Location = new System.Drawing.Point(117, 56);
            this.txtclasp.Name = "txtclasp";
            this.txtclasp.Size = new System.Drawing.Size(100, 20);
            this.txtclasp.TabIndex = 4;
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(117, 20);
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(100, 20);
            this.txtimc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor IMC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Risco Saúde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Classificação peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 416);
            this.Controls.Add(this.gbinf);
            this.Controls.Add(this.bntrepor);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.gbut);
            this.Controls.Add(this.gbgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbgen.ResumeLayout(false);
            this.gbgen.PerformLayout();
            this.gbut.ResumeLayout(false);
            this.gbut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndpeso)).EndInit();
            this.gbinf.ResumeLayout(false);
            this.gbinf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbgen;
        private System.Windows.Forms.RadioButton rdfem;
        private System.Windows.Forms.RadioButton rdmasc;
        private System.Windows.Forms.GroupBox gbut;
        private System.Windows.Forms.NumericUpDown ndalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ndpeso;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button bntrepor;
        private System.Windows.Forms.GroupBox gbinf;
        private System.Windows.Forms.TextBox txtrisc;
        private System.Windows.Forms.TextBox txtclasp;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

