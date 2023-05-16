
namespace TEMA2LFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
       
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox NodeListBox;
        private System.Windows.Forms.TextBox NodeNameTextBox;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Button EditNodeButton;
        private System.Windows.Forms.Button DeleteNodeButton;
        private System.Windows.Forms.Label NodeLabel;
        private System.Windows.Forms.Label NodeNameLabel;
        private System.Windows.Forms.Label AddVertexLabel;
        private System.Windows.Forms.TextBox Node1NameTextBox;
        private System.Windows.Forms.TextBox Node2NameTextBox;
        private System.Windows.Forms.NumericUpDown DistanceNumericUpDown;
        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.Label Node1Label;
        private System.Windows.Forms.Label Node2Label;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label MoveNodeStatusLabel;
        private System.Windows.Forms.Button MoveNodeButton;

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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.components = new System.ComponentModel.Container();
            this.NodeListBox = new System.Windows.Forms.ListBox();
            this.NodeNameTextBox = new System.Windows.Forms.TextBox();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.EditNodeButton = new System.Windows.Forms.Button();
            this.DeleteNodeButton = new System.Windows.Forms.Button();
            this.NodeLabel = new System.Windows.Forms.Label();
            this.NodeNameLabel = new System.Windows.Forms.Label();
            this.AddVertexLabel = new System.Windows.Forms.Label();
            this.Node1NameTextBox = new System.Windows.Forms.TextBox();
            this.Node2NameTextBox = new System.Windows.Forms.TextBox();
            this.DistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.Node1Label = new System.Windows.Forms.Label();
            this.Node2Label = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.MoveNodeStatusLabel = new System.Windows.Forms.Label();
            this.MoveNodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // NodeListBox
            this.NodeListBox.FormattingEnabled = true;
            this.NodeListBox.Location = new System.Drawing.Point(12, 32);
            this.NodeListBox.Name = "NodeListBox";
            this.NodeListBox.Size = new System.Drawing.Size(120, 186);
            this.NodeListBox.TabIndex = 0;
            this.NodeListBox.SelectedIndexChanged += new System.EventHandler(this.NodeListBox_SelectedIndexChanged);

            // NodeNameTextBox
            this.NodeNameTextBox.Location = new System.Drawing.Point(12, 246);
            this.NodeNameTextBox.Name = "NodeNameTextBox";
            this.NodeNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NodeNameTextBox.TabIndex = 1;

            // AddNodeButton
            this.AddNodeButton.Location = new System.Drawing.Point(138, 244);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(75, 23);
            this.AddNodeButton.TabIndex = 2;
            this.AddNodeButton.Text = "Add Node";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);

            // EditNodeButton
            this.EditNodeButton.Location = new System.Drawing.Point(138, 273);
            this.EditNodeButton.Name = "EditNodeButton";
            this.EditNodeButton.Size = new System.Drawing.Size(75, 23);
            this.EditNodeButton.TabIndex = 3;
            this.EditNodeButton.Text = "Edit Node";
            this.EditNodeButton.UseVisualStyleBackColor = true;

            // DeleteNodeButton
            this.DeleteNodeButton.Location = new System.Drawing.Point(138, 302);
            this.DeleteNodeButton.Name = "DeleteNodeButton";
            this.DeleteNodeButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNodeButton.TabIndex = 4;
            this.DeleteNodeButton.Text = "Delete Node";
            this.DeleteNodeButton.UseVisualStyleBackColor = true;
            this.DeleteNodeButton.Click += new System.EventHandler(this.DeleteNodeButton_Click);

            // NodeLabel
            this.NodeLabel.AutoSize = true;
            this.NodeLabel.Location = new System.Drawing.Point(12, 13);
            this.NodeLabel.Name = "NodeLabel";
            this.NodeLabel.Size = new System.Drawing.Size(36, 13);
            this.NodeLabel.TabIndex = 5;
            this.NodeLabel.Text = "Nodes";

            // NodeNameLabel
            this.NodeNameLabel.AutoSize = true;
            this.NodeNameLabel.Location = new System.Drawing.Point(12, 230);
            this.NodeNameLabel.Name = "NodeNameLabel";
            this.NodeNameLabel.Size = new System.Drawing.Size(38, 13);
            this.NodeNameLabel.TabIndex = 6;
            this.NodeNameLabel.Text = "Name";

            // AddVertexLabel
            this.AddVertexLabel.AutoSize = true;
            this.AddVertexLabel.Location = new System.Drawing.Point(259, 13);
            this.AddVertexLabel.Name = "AddVertexLabel";
            this.AddVertexLabel.Size = new System.Drawing.Size(62, 13);
            this.AddVertexLabel.TabIndex = 7;
            this.AddVertexLabel.Text = "Add Vertex";

            // Node1NameTextBox
            this.Node1NameTextBox.Location = new System.Drawing.Point(259, 32);
            this.Node1NameTextBox.Name = "Node1NameTextBox";
            this.Node1NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Node1NameTextBox.TabIndex = 8;

            // Node2NameTextBox
            this.Node2NameTextBox.Location = new System.Drawing.Point(259, 73);
            this.Node2NameTextBox.Name = "Node2NameTextBox";
            this.Node2NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Node2NameTextBox.TabIndex = 9;

            // DistanceNumericUpDown
            this.DistanceNumericUpDown.Location = new System.Drawing.Point(259, 114);
            this.DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            this.DistanceNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.DistanceNumericUpDown.TabIndex = 10;

            // AddVertexButton
            this.AddVertexButton.Location = new System.Drawing.Point(278, 146);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(75, 23);
            this.AddVertexButton.TabIndex = 11;
            this.AddVertexButton.Text = "Add Vertex";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.AddVertexButton_Click);

            // Node1Label
            this.Node1Label.AutoSize = true;
            this.Node1Label.Location = new System.Drawing.Point(187, 35);
            this.Node1Label.Name = "Node1Label";
            this.Node1Label.Size = new System.Drawing.Size(45, 13);
            this.Node1Label.TabIndex = 12;
            this.Node1Label.Text = "Node 1";

            // Node2Label
            this.Node2Label.AutoSize = true;
            this.Node2Label.Location = new System.Drawing.Point(187, 76);
            this.Node2Label.Name = "Node2Label";
            this.Node2Label.Size = new System.Drawing.Size(45, 13);
            this.Node2Label.TabIndex = 13;
            this.Node2Label.Text = "Node 2";

            // DistanceLabel
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(187, 116);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.DistanceLabel.TabIndex = 14;
            this.DistanceLabel.Text = "Distance";

            // MoveNodeStatusLabel
            this.MoveNodeStatusLabel.AutoSize = true;
            this.MoveNodeStatusLabel.Location = new System.Drawing.Point(259, 193);
            this.MoveNodeStatusLabel.Name = "MoveNodeStatusLabel";
            this.MoveNodeStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.MoveNodeStatusLabel.TabIndex = 15;

            // MoveNodeButton
            this.MoveNodeButton.Location = new System.Drawing.Point(259, 209);
            this.MoveNodeButton.Name = "MoveNodeButton";
            this.MoveNodeButton.Size = new System.Drawing.Size(75, 23);
            this.MoveNodeButton.TabIndex = 16;
            this.MoveNodeButton.Text = "Move Node";
            this.MoveNodeButton.UseVisualStyleBackColor = true;
            this.MoveNodeButton.Click += new System.EventHandler(this.MoveNodeButton_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.MoveNodeButton);
            this.Controls.Add(this.MoveNodeStatusLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.Node2Label);
            this.Controls.Add(this.Node1Label);
            this.Controls.Add(this.AddVertexButton);
            this.Controls.Add(this.DistanceNumericUpDown);
            this.Controls.Add(this.Node2NameTextBox);
            this.Controls.Add(this.Node1NameTextBox);
            this.Controls.Add(this.AddVertexLabel);
            this.Controls.Add(this.NodeNameLabel);
            this.Controls.Add(this.NodeLabel);
            this.Controls.Add(this.DeleteNodeButton);
            this.Controls.Add(this.EditNodeButton);
            this.Controls.Add(this.AddNodeButton);
            this.Controls.Add(this.NodeNameTextBox);
            this.Controls.Add(this.NodeListBox);
            this.Name = "MainForm";
            this.Text = "City Graph";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}