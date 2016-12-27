namespace Exercise10_1gui
{
    partial class ExploreTheHouseForm
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
            this.goHereButton = new System.Windows.Forms.Button();
            this.exitsComboBox = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoorButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goHereButton
            // 
            this.goHereButton.Location = new System.Drawing.Point(12, 287);
            this.goHereButton.Name = "goHereButton";
            this.goHereButton.Size = new System.Drawing.Size(111, 23);
            this.goHereButton.TabIndex = 0;
            this.goHereButton.Text = "Go Here";
            this.goHereButton.UseVisualStyleBackColor = true;
            this.goHereButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goHereButton_Click);
            // 
            // exitsComboBox
            // 
            this.exitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitsComboBox.FormattingEnabled = true;
            this.exitsComboBox.Location = new System.Drawing.Point(138, 287);
            this.exitsComboBox.Name = "exitsComboBox";
            this.exitsComboBox.Size = new System.Drawing.Size(217, 21);
            this.exitsComboBox.TabIndex = 1;
            // 
            // goThroughTheDoorButton
            // 
            this.goThroughTheDoorButton.Location = new System.Drawing.Point(12, 316);
            this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
            this.goThroughTheDoorButton.Size = new System.Drawing.Size(343, 23);
            this.goThroughTheDoorButton.TabIndex = 2;
            this.goThroughTheDoorButton.Text = "Go through the door ";
            this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.goThroughTheDoorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goThroughTheDoorButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(372, 269);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // ExploreTheHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 349);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.goThroughTheDoorButton);
            this.Controls.Add(this.exitsComboBox);
            this.Controls.Add(this.goHereButton);
            this.Name = "ExploreTheHouseForm";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goHereButton;
        private System.Windows.Forms.ComboBox exitsComboBox;
        private System.Windows.Forms.Button goThroughTheDoorButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}

