namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClickToPlay = new System.Windows.Forms.Label();
            this.GameWillStart = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickToPlay
            // 
            this.ClickToPlay.AutoSize = true;
            this.ClickToPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClickToPlay.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickToPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClickToPlay.Location = new System.Drawing.Point(37, 50);
            this.ClickToPlay.Name = "ClickToPlay";
            this.ClickToPlay.Size = new System.Drawing.Size(246, 71);
            this.ClickToPlay.TabIndex = 0;
            this.ClickToPlay.Text = "\r\nCLICK TO PLAY GAME\r\n\r\n";
            this.ClickToPlay.Click += new System.EventHandler(this.ClickToPlay_Click);
            // 
            // GameWillStart
            // 
            this.GameWillStart.AutoSize = true;
            this.GameWillStart.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameWillStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameWillStart.Location = new System.Drawing.Point(23, 186);
            this.GameWillStart.Name = "GameWillStart";
            this.GameWillStart.Size = new System.Drawing.Size(0, 21);
            this.GameWillStart.TabIndex = 1;
            this.GameWillStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Go
            // 
            this.Go.AutoSize = true;
            this.Go.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(137, 186);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(0, 21);
            this.Go.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(318, 370);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.GameWillStart);
            this.Controls.Add(this.ClickToPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arcade Central";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClickToPlay;
        private System.Windows.Forms.Label GameWillStart;
        private System.Windows.Forms.Label Go;
    }
}

