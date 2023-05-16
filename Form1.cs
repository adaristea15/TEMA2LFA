using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace TEMA2LFA
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Node> nodes;
        private List<Edge> edges;
        private int nodeCount = 0;
        private int nodeSpacing = 100;
        private const int NodeRadius = 25;
        private Node selectedNode;
        private Point mouseOffset;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            nodes = new Dictionary<string, Node>();
            edges = new List<Edge>();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var node in nodes.Values)
            {
                // Draw the node
                var nodeRectangle = new Rectangle(node.Location.X, node.Location.Y + 50, 50, 50);
                e.Graphics.FillEllipse(Brushes.LightBlue, nodeRectangle);
                e.Graphics.DrawEllipse(Pens.Black, nodeRectangle);

                // Draw the node label
                var nodeLabel = node.Name;
                var labelFont = new Font(FontFamily.GenericSansSerif, 10);
                var labelSize = e.Graphics.MeasureString(nodeLabel, labelFont);
                var labelLocation = new PointF(nodeRectangle.X + (nodeRectangle.Width - labelSize.Width) / 2,
                    nodeRectangle.Y + (nodeRectangle.Height - labelSize.Height) / 2);
                e.Graphics.DrawString(nodeLabel, labelFont, Brushes.Black, labelLocation);
            }

            foreach (var edge in edges)
            {
                var startPoint = new Point(edge.Node1.Location.X + NodeRadius, edge.Node1.Location.Y + (nodes.Count - 1) * nodeSpacing - 50);
                var endPoint = new Point(edge.Node2.Location.X + NodeRadius, edge.Node2.Location.Y  + (nodes.Count - 1) * nodeSpacing - 50);

                // Calculate the midpoint between the start and end points
                var midpoint = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);

                // Draw the edge (line) between the nodes
                e.Graphics.DrawLine(Pens.Black, startPoint, endPoint);

                // Draw the distance as text at the midpoint of the edge
                var distanceText = edge.Distance.ToString();
                var distanceTextSize = e.Graphics.MeasureString(distanceText, Font);
                var distanceTextLocation = new PointF(midpoint.X - distanceTextSize.Width / 2, midpoint.Y - distanceTextSize.Height / 2);
                e.Graphics.DrawString(distanceText, Font, Brushes.Black, distanceTextLocation);
            }
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            string nodeName = NodeNameTextBox.Text.Trim();

            // Check if the node name is empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(nodeName))
            {
                MessageBox.Show("Please enter a valid node name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the node name already exists
            if (nodes.ContainsKey(nodeName))
            {
                MessageBox.Show("A node with the same name already exists.", "Duplicate Node", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new node and add it to the nodes dictionary
            Node newNode = new Node(nodeName);
            nodes.Add(nodeName, newNode);

            // Update the node list
            UpdateNodeList();

            // Clear the node name textbox
            NodeNameTextBox.Clear();

            // Calculate the new node's position
            int nodeX = 400; // Adjust the x-coordinate as desired
            int nodeY = 150 + (nodes.Count - 1) * nodeSpacing; // Calculate the y-coordinate based on the number of nodes

            // Set the location of the new node
            newNode.Location = new Point(nodeX, nodeY);

            // Redraw the form
            Refresh();
        }

            private void AddVertexButton_Click(object sender, EventArgs e)
            {
            var node1Name = Node1NameTextBox.Text;
            var node2Name = Node2NameTextBox.Text;
            var distance = (int)DistanceNumericUpDown.Value;

            if (nodes.ContainsKey(node1Name) && nodes.ContainsKey(node2Name))
            {
                var node1 = nodes[node1Name];
                var node2 = nodes[node2Name];

                Edge existingEdge = edges.FirstOrDefault(edge => (edge.Node1 == node1 && edge.Node2 == node2) || (edge.Node1 == node2 && edge.Node2 == node1));
                if (existingEdge != null)
                {
                    // Ask the user to edit the distance
                    var editDistanceForm = new EditDistanceForm(existingEdge.Distance);
                    if (editDistanceForm.ShowDialog() == DialogResult.OK)
                    {
                        existingEdge.Distance = editDistanceForm.Distance;
                    }
                }
                else
                {
                    // Add a new edge
                    var edge = new Edge(node1, node2, distance);
                    edges.Add(edge);
                }

                Refresh();
            }
            else
            {
                MessageBox.Show("Please select valid nodes.");
            }
        }

        private bool HasEdge(Node node1, Node node2)
        {
            foreach (var edge in edges)
            {
                if ((edge.Node1 == node1 && edge.Node2 == node2) ||
                    (edge.Node1 == node2 && edge.Node2 == node1))
                {
                    return true;
                }
            }
            return false;
        }

        private void NodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NodeListBox.SelectedItem != null)
            {
                selectedNode = nodes[NodeListBox.SelectedItem.ToString()];
                NodeNameTextBox.Text = selectedNode.Name;
            }
        }
        private void EditNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                string newName = NodeNameTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(newName))
                {
                    // Update the node name
                    selectedNode.Name = newName;

                    // Update the displayed name in the list box
                    int selectedIndex = NodeListBox.SelectedIndex;
                    NodeListBox.Items[selectedIndex] = selectedNode;

                    Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid node name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a node to edit.");
            }
        }

        private void DeleteNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                string nodeName = selectedNode.Name;

                nodes.Remove(nodeName);
                edges.RemoveAll(edge => edge.Node1 == selectedNode || edge.Node2 == selectedNode);

                selectedNode = null;
                Refresh();

                // Update the node list
                UpdateNodeList();
            }
            else
            {
                MessageBox.Show("Please select a node to delete.");
            }
        }

        private void UpdateNodeList()
        {
            NodeListBox.DataSource = null;
            NodeListBox.DataSource = nodes.Values.ToList();
            NodeListBox.DisplayMember = "Name";
        }

        private void MoveNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                MoveNodeStatusLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a node to move.");
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedNode != null && MoveNodeStatusLabel.Visible)
            {
                mouseOffset = new Point(e.X - selectedNode.Location.X, e.Y - selectedNode.Location.Y);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedNode != null && MoveNodeStatusLabel.Visible && e.Button == MouseButtons.Left)
            {
                var newX = e.X - mouseOffset.X;
                var newY = e.Y - mouseOffset.Y;
                selectedNode.Location = new Point(newX, newY);
                Refresh();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            MoveNodeStatusLabel.Visible = false;
        }
    }

    public class Node
    {
        public string Name { get; set; }
        public Point Location { get; set; }

        public Node(string name)
        {
            Name = name;
            Location = Point.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Edge
    {
        public Node Node1 { get; }
        public Node Node2 { get; }
        public int Distance { get; set; }

        public Edge(Node node1, Node node2, int distance)
        {
            Node1 = node1;
            Node2 = node2;
            Distance = distance;
        }
    }
}