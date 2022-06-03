
namespace IRS
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblirs = new System.Windows.Forms.Label();
            this.lblSSocial = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtirs = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário";
            // 
            // lblirs
            // 
            this.lblirs.AutoSize = true;
            this.lblirs.Location = new System.Drawing.Point(12, 122);
            this.lblirs.Name = "lblirs";
            this.lblirs.Size = new System.Drawing.Size(25, 13);
            this.lblirs.TabIndex = 1;
            this.lblirs.Text = "IRS";
            // 
            // lblSSocial
            // 
            this.lblSSocial.AutoSize = true;
            this.lblSSocial.Location = new System.Drawing.Point(5, 150);
            this.lblSSocial.Name = "lblSSocial";
            this.lblSSocial.Size = new System.Drawing.Size(58, 13);
            this.lblSSocial.TabIndex = 2;
            this.lblSSocial.Text = "Seg.Social";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(5, 180);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 3;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(65, 147);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(130, 20);
            this.txtSS.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(80, 177);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(130, 20);
            this.txtSL.TabIndex = 5;
            this.txtSL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtirs
            // 
            this.txtirs.Location = new System.Drawing.Point(65, 121);
            this.txtirs.Name = "txtirs";
            this.txtirs.Size = new System.Drawing.Size(130, 20);
            this.txtirs.TabIndex = 6;
            // 
            // txtSalario
            // 
            this.txtSalario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSalario.Location = new System.Drawing.Point(65, 46);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(65, 86);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 259);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtirs);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSSocial);
            this.Controls.Add(this.lblirs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblirs;
        private System.Windows.Forms.Label lblSSocial;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtirs;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

