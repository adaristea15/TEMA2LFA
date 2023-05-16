namespace TEMA2LFA
{
    partial class EditDistanceForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.Node2Label = new System.Windows.Forms.Label();
            this.Node1Label = new System.Windows.Forms.Label();
            this.DistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Node2NameTextBox = new System.Windows.Forms.TextBox();
            this.Node1NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(121, 120);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(12, 91);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(52, 15);
            this.DistanceLabel.TabIndex = 10;
            this.DistanceLabel.Text = "Distance";
            // 
            // Node2Label
            // 
            this.Node2Label.AutoSize = true;
            this.Node2Label.Location = new System.Drawing.Point(12, 57);
            this.Node2Label.Name = "Node2Label";
            this.Node2Label.Size = new System.Drawing.Size(49, 15);
            this.Node2Label.TabIndex = 9;
            this.Node2Label.Text = "Node 2";
            // 
            // Node1Label
            // 
            this.Node1Label.AutoSize = true;
            this.Node1Label.Location = new System.Drawing.Point(12, 23);
            this.Node1Label.Name = "Node1Label";
            this.Node1Label.Size = new System.Drawing.Size(49, 15);
            this.Node1Label.TabIndex = 8;
            this.Node1Label.Text = "Node 1";
            // 
            // DistanceNumericUpDown
            // 
            this.DistanceNumericUpDown.Location = new System.Drawing.Point(92, 89);
            this.DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            this.DistanceNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.DistanceNumericUpDown.TabIndex = 7;
            // 
            // Node2NameTextBox
            // 
    
            // 
            this.Node2NameTextBox.Location = new System.Drawing.Point(92, 54);
            this.Node2NameTextBox.Name = "Node2NameTextBox";
            this.Node2NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.Node2NameTextBox.TabIndex = 6;
            // 
            // Node1NameTextBox
            // 
            this.Node1NameTextBox.Location = new System.Drawing.Point(92, 20);
            this.Node1NameTextBox.Name = "Node1NameTextBox";
            this.Node1NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.Node1NameTextBox.TabIndex = 5;
            // 
            // EditDistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 157);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.Node2Label);
            this.Controls.Add(this.Node1Label);
            this.Controls.Add(this.DistanceNumericUpDown);
            this.Controls.Add(this.Node2NameTextBox);
            this.Controls.Add(this.Node1NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDistanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Distance";
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label Node2Label;
        private System.Windows.Forms.Label Node1Label;
        private System.Windows.Forms.NumericUpDown DistanceNumericUpDown;
        private System.Windows.Forms.TextBox Node2NameTextBox;
        private System.Windows.Forms.TextBox Node1NameTextBox;
    }
}