
namespace KMS
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
            this.txtkm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtConsumo2 = new System.Windows.Forms.TextBox();
            this.txtvalorgasto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KMS Percorridos";
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(135, 41);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(100, 20);
            this.txtkm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumo Registado";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(135, 83);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(135, 120);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço de Combustivel";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(135, 159);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consumo Registado";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(58, 241);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 13);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Valor Gasto";
            // 
            // txtConsumo2
            // 
            this.txtConsumo2.Location = new System.Drawing.Point(135, 200);
            this.txtConsumo2.Name = "txtConsumo2";
            this.txtConsumo2.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo2.TabIndex = 9;
            // 
            // txtvalorgasto
            // 
            this.txtvalorgasto.Location = new System.Drawing.Point(135, 241);
            this.txtvalorgasto.Name = "txtvalorgasto";
            this.txtvalorgasto.Size = new System.Drawing.Size(100, 20);
            this.txtvalorgasto.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(351, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtvalorgasto);
            this.Controls.Add(this.txtConsumo2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtConsumo2;
        private System.Windows.Forms.TextBox txtvalorgasto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

