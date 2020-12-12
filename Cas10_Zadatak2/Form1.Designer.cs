namespace Cas10zadatak2
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPuta = new System.Windows.Forms.Button();
            this.btnPodeljeno = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(5, 35);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 27);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(87, 35);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 27);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPuta
            // 
            this.btnPuta.Location = new System.Drawing.Point(169, 35);
            this.btnPuta.Name = "btnPuta";
            this.btnPuta.Size = new System.Drawing.Size(49, 27);
            this.btnPuta.TabIndex = 2;
            this.btnPuta.Text = "*";
            this.btnPuta.UseVisualStyleBackColor = true;
            this.btnPuta.Click += new System.EventHandler(this.btnPuta_Click);
            // 
            // btnPodeljeno
            // 
            this.btnPodeljeno.Location = new System.Drawing.Point(251, 35);
            this.btnPodeljeno.Name = "btnPodeljeno";
            this.btnPodeljeno.Size = new System.Drawing.Size(49, 27);
            this.btnPodeljeno.TabIndex = 3;
            this.btnPodeljeno.Text = "/";
            this.btnPodeljeno.UseVisualStyleBackColor = true;
            this.btnPodeljeno.Click += new System.EventHandler(this.btnPodeljeno_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(5, 12);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 4;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(112, 11);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 5;
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(251, 11);
            this.tbR.Name = "tbR";
            this.tbR.ReadOnly = true;
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 6;
            this.tbR.TextChanged += new System.EventHandler(this.tbR_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 219);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btnPodeljeno);
            this.Controls.Add(this.btnPuta);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPuta;
        private System.Windows.Forms.Button btnPodeljeno;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbR;
    }
}

