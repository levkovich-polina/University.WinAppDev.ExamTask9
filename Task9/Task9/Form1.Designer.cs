namespace Task9
{
    partial class Form1
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
            this.Panel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ColorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(1, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(400, 400);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(459, 23);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 38);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(459, 352);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(141, 38);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Воспроизвести";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ColorListBox
            // 
            this.ColorListBox.FormattingEnabled = true;
            this.ColorListBox.ItemHeight = 20;
            this.ColorListBox.Location = new System.Drawing.Point(428, 77);
            this.ColorListBox.Name = "ColorListBox";
            this.ColorListBox.Size = new System.Drawing.Size(197, 264);
            this.ColorListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.ColorListBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel;
        private Button ResetButton;
        private Button PlayButton;
        private ListBox ColorListBox;
    }
}