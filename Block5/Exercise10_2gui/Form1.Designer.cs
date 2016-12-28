namespace Exercise10_2gui
{
    partial class HideAndSeek
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.goHereButton = new System.Windows.Forms.Button();
            this.goThroughTheDoorButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(417, 298);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(152, 318);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(277, 21);
            this.exitsComboBox.TabIndex = 1;
            // 
            // goHereButton
            // 
            this.goHereButton.Location = new System.Drawing.Point(12, 316);
            this.goHereButton.Name = "goHereButton";
            this.goHereButton.Size = new System.Drawing.Size(118, 23);
            this.goHereButton.TabIndex = 2;
            this.goHereButton.Text = "Go Here:";
            this.goHereButton.UseVisualStyleBackColor = true;
            this.goHereButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goHereButton_Click);
            // 
            // goThroughTheDoorButton
            // 
            this.goThroughTheDoorButton.Location = new System.Drawing.Point(12, 345);
            this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
            this.goThroughTheDoorButton.Size = new System.Drawing.Size(417, 23);
            this.goThroughTheDoorButton.TabIndex = 3;
            this.goThroughTheDoorButton.Text = "GoThrough TheDoor ";
            this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.goThroughTheDoorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goThroughTheDoorButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 374);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(417, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(12, 403);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(417, 23);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "Hide!";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hideButton_Click);
            // 
            // HideAndSeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 438);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.goThroughTheDoorButton);
            this.Controls.Add(this.goHereButton);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "HideAndSeek";
            this.Text = "Hide & Seek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox exitsComboBox;
        private System.Windows.Forms.Button goHereButton;
        private System.Windows.Forms.Button goThroughTheDoorButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
    }
}

