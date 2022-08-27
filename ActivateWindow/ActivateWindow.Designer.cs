namespace ActivateWindow
{
    partial class ActivateWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sleepButton = new System.Windows.Forms.Button();
            this.hibernateButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.shutDownButton = new System.Windows.Forms.Button();
            this.activateWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sleepButton
            // 
            this.sleepButton.Location = new System.Drawing.Point(12, 68);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(75, 23);
            this.sleepButton.TabIndex = 0;
            this.sleepButton.Text = "Sleep";
            this.sleepButton.UseVisualStyleBackColor = true;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // hibernateButton
            // 
            this.hibernateButton.Location = new System.Drawing.Point(93, 68);
            this.hibernateButton.Name = "hibernateButton";
            this.hibernateButton.Size = new System.Drawing.Size(75, 23);
            this.hibernateButton.TabIndex = 1;
            this.hibernateButton.Text = "Hibernate";
            this.hibernateButton.UseVisualStyleBackColor = true;
            this.hibernateButton.Click += new System.EventHandler(this.hibernateButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(174, 68);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // shutDownButton
            // 
            this.shutDownButton.Location = new System.Drawing.Point(255, 68);
            this.shutDownButton.Name = "shutDownButton";
            this.shutDownButton.Size = new System.Drawing.Size(75, 23);
            this.shutDownButton.TabIndex = 3;
            this.shutDownButton.Text = "Shut Down";
            this.shutDownButton.UseVisualStyleBackColor = true;
            this.shutDownButton.Click += new System.EventHandler(this.shutDownButton_Click);
            // 
            // activateWindowButton
            // 
            this.activateWindowButton.Location = new System.Drawing.Point(37, 26);
            this.activateWindowButton.Name = "activateWindowButton";
            this.activateWindowButton.Size = new System.Drawing.Size(261, 23);
            this.activateWindowButton.TabIndex = 4;
            this.activateWindowButton.Text = "Activate Window";
            this.activateWindowButton.UseVisualStyleBackColor = true;
            this.activateWindowButton.Click += new System.EventHandler(this.activateWindowButton_Click);
            // 
            // ActivateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 113);
            this.Controls.Add(this.activateWindowButton);
            this.Controls.Add(this.shutDownButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.hibernateButton);
            this.Controls.Add(this.sleepButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivateWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button sleepButton;
        private Button hibernateButton;
        private Button restartButton;
        private Button shutDownButton;
        private Button activateWindowButton;
    }
}