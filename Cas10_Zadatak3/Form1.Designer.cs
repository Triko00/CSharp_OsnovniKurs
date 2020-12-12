namespace Cas10zadatak3
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
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(13, 13);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(100, 20);
            this.tbTimer.TabIndex = 0;
            this.tbTimer.TextChanged += new System.EventHandler(this.tbTimer_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNapred
            // 
            this.btnNapred.Location = new System.Drawing.Point(13, 40);
            this.btnNapred.Name = "btnNapred";
            this.btnNapred.Size = new System.Drawing.Size(75, 23);
            this.btnNapred.TabIndex = 1;
            this.btnNapred.Text = "Napred";
            this.btnNapred.UseVisualStyleBackColor = true;
            this.btnNapred.Click += new System.EventHandler(this.btnNapred_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(13, 70);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(13, 100);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(75, 23);
            this.btnZaustavi.TabIndex = 3;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(13, 130);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 4;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 228);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnNapred);
            this.Controls.Add(this.tbTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnResetuj;
    }
}

