
namespace Temperatura
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
            this.rdfar = new System.Windows.Forms.RadioButton();
            this.rdcel = new System.Windows.Forms.RadioButton();
            this.rdkel = new System.Windows.Forms.RadioButton();
            this.txtfar = new System.Windows.Forms.TextBox();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.txtkel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdfar
            // 
            this.rdfar.AutoSize = true;
            this.rdfar.Location = new System.Drawing.Point(21, 30);
            this.rdfar.Name = "rdfar";
            this.rdfar.Size = new System.Drawing.Size(75, 17);
            this.rdfar.TabIndex = 0;
            this.rdfar.TabStop = true;
            this.rdfar.Text = "Fahrenheit";
            this.rdfar.UseVisualStyleBackColor = true;
            // 
            // rdcel
            // 
            this.rdcel.AutoSize = true;
            this.rdcel.Location = new System.Drawing.Point(21, 77);
            this.rdcel.Name = "rdcel";
            this.rdcel.Size = new System.Drawing.Size(58, 17);
            this.rdcel.TabIndex = 1;
            this.rdcel.TabStop = true;
            this.rdcel.Text = "Celsius";
            this.rdcel.UseVisualStyleBackColor = true;
            this.rdcel.CheckedChanged += new System.EventHandler(this.rdcel_CheckedChanged);
            // 
            // rdkel
            // 
            this.rdkel.AutoSize = true;
            this.rdkel.Location = new System.Drawing.Point(21, 118);
            this.rdkel.Name = "rdkel";
            this.rdkel.Size = new System.Drawing.Size(54, 17);
            this.rdkel.TabIndex = 2;
            this.rdkel.TabStop = true;
            this.rdkel.Text = "Kelvin";
            this.rdkel.UseVisualStyleBackColor = true;
            // 
            // txtfar
            // 
            this.txtfar.Location = new System.Drawing.Point(118, 30);
            this.txtfar.Name = "txtfar";
            this.txtfar.Size = new System.Drawing.Size(100, 20);
            this.txtfar.TabIndex = 3;
            this.txtfar.TextChanged += new System.EventHandler(this.txtfar_TextChanged);
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(118, 74);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(100, 20);
            this.txtcel.TabIndex = 4;
            this.txtcel.TextChanged += new System.EventHandler(this.txtcel_TextChanged);
            // 
            // txtkel
            // 
            this.txtkel.Location = new System.Drawing.Point(118, 115);
            this.txtkel.Name = "txtkel";
            this.txtkel.Size = new System.Drawing.Size(100, 20);
            this.txtkel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdfar);
            this.groupBox1.Controls.Add(this.rdcel);
            this.groupBox1.Controls.Add(this.rdkel);
            this.groupBox1.Controls.Add(this.txtkel);
            this.groupBox1.Controls.Add(this.txtcel);
            this.groupBox1.Controls.Add(this.txtfar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 167);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversor de Temperaturas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(411, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdfar;
        private System.Windows.Forms.RadioButton rdcel;
        private System.Windows.Forms.RadioButton rdkel;
        private System.Windows.Forms.TextBox txtfar;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.TextBox txtkel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

