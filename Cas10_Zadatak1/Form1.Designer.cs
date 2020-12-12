namespace Cas10zadatak1_opet_
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tbR1 = new System.Windows.Forms.TextBox();
            this.tbG1 = new System.Windows.Forms.TextBox();
            this.tbB1 = new System.Windows.Forms.TextBox();
            this.tbR2 = new System.Windows.Forms.TextBox();
            this.tbG2 = new System.Windows.Forms.TextBox();
            this.tbB2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbVreme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pokreni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbR1
            // 
            this.tbR1.Location = new System.Drawing.Point(13, 43);
            this.tbR1.Name = "tbR1";
            this.tbR1.Size = new System.Drawing.Size(100, 20);
            this.tbR1.TabIndex = 1;
            this.tbR1.TextChanged += new System.EventHandler(this.tbR1_TextChanged);
            // 
            // tbG1
            // 
            this.tbG1.Location = new System.Drawing.Point(13, 70);
            this.tbG1.Name = "tbG1";
            this.tbG1.Size = new System.Drawing.Size(100, 20);
            this.tbG1.TabIndex = 2;
            this.tbG1.TextChanged += new System.EventHandler(this.tbG1_TextChanged);
            // 
            // tbB1
            // 
            this.tbB1.Location = new System.Drawing.Point(13, 97);
            this.tbB1.Name = "tbB1";
            this.tbB1.Size = new System.Drawing.Size(100, 20);
            this.tbB1.TabIndex = 3;
            this.tbB1.TextChanged += new System.EventHandler(this.tbB1_TextChanged);
            // 
            // tbR2
            // 
            this.tbR2.Location = new System.Drawing.Point(120, 42);
            this.tbR2.Name = "tbR2";
            this.tbR2.Size = new System.Drawing.Size(100, 20);
            this.tbR2.TabIndex = 4;
            this.tbR2.TextChanged += new System.EventHandler(this.tbR2_TextChanged);
            // 
            // tbG2
            // 
            this.tbG2.Location = new System.Drawing.Point(120, 69);
            this.tbG2.Name = "tbG2";
            this.tbG2.Size = new System.Drawing.Size(100, 20);
            this.tbG2.TabIndex = 5;
            this.tbG2.TextChanged += new System.EventHandler(this.tbG2_TextChanged);
            // 
            // tbB2
            // 
            this.tbB2.Location = new System.Drawing.Point(120, 96);
            this.tbB2.Name = "tbB2";
            this.tbB2.Size = new System.Drawing.Size(100, 20);
            this.tbB2.TabIndex = 6;
            this.tbB2.TextChanged += new System.EventHandler(this.tbB2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbVreme
            // 
            this.tbVreme.Location = new System.Drawing.Point(94, 15);
            this.tbVreme.Name = "tbVreme";
            this.tbVreme.Size = new System.Drawing.Size(100, 20);
            this.tbVreme.TabIndex = 7;
            this.tbVreme.TextChanged += new System.EventHandler(this.tbVreme_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 444);
            this.Controls.Add(this.tbVreme);
            this.Controls.Add(this.tbB2);
            this.Controls.Add(this.tbG2);
            this.Controls.Add(this.tbR2);
            this.Controls.Add(this.tbB1);
            this.Controls.Add(this.tbG1);
            this.Controls.Add(this.tbR1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbR1;
        private System.Windows.Forms.TextBox tbG1;
        private System.Windows.Forms.TextBox tbB1;
        private System.Windows.Forms.TextBox tbR2;
        private System.Windows.Forms.TextBox tbG2;
        private System.Windows.Forms.TextBox tbB2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbVreme;
    }
}

