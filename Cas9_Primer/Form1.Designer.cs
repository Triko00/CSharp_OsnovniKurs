namespace primer
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbCounter = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Konvertuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 67);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(100, 20);
            this.tbOutput.TabIndex = 2;
            // 
            // tbCounter
            // 
            this.tbCounter.Location = new System.Drawing.Point(12, 154);
            this.tbCounter.Name = "tbCounter";
            this.tbCounter.Size = new System.Drawing.Size(100, 20);
            this.tbCounter.TabIndex = 3;
            this.tbCounter.Text = "1";
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(129, 152);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(75, 23);
            this.timer.TabIndex = 4;
            this.timer.Text = "Tajmer";
            this.timer.UseVisualStyleBackColor = true;
            this.timer.Click += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.tbCounter);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "primer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbCounter;
        private System.Windows.Forms.Button timer;
    }
}

