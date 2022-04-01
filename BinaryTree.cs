using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApp10
{
    public partial class Form1 : Form

    {
        private Node root;
        public Form1()
        {
            InitializeComponent();
            this.root = null;
            test();

        }
        void test()
        {
            textBox1.Text = "5";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "3";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "2";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "1";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "4";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "7";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "6";
            btnAdd_Click(btnAdd, null);
            textBox1.Text = "8";
            btnAdd_Click(btnAdd, null);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            if (root == null)
                root = new Node(value);
            else

            {
                if (root.Add(value) == false)
                    MessageBox.Show("The value already exists!");

            }
            drawTree();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            root = null;
            pictureBox1.Image = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            if (root != null)

            {
                bool status = root.Remove(value, root, ref root);
                if (status == false)

                {
                    MessageBox.Show("the value does not exists");

                }

            }
            drawTree();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string msg;
            int value = int.Parse(textBox1.Text);
            if (root == null)

            {
                msg = "Tree is empty";
            }
            else

            {
                if (root.Exists(value))

                {
                    msg = "Value found";
                }
                else

                {
                    msg = "Value not found";

                }

            }
            MessageBox.Show(msg);

        }
        void drawTree()
        {
            if (root != null)
                pictureBox1.Image = root.Draw();
            else
                pictureBox1.Image = null;
            this.Update();
        }
        
    }
    class Node
    {
        internal Node left { get; set; }
        internal Node right { get; set; }
        internal int value;
        internal int center = 12;
        private static Bitmap nodeBg = new Bitmap(30, 25);
        private static Font font = new Font("Arial", 14);
        internal Node(int value)
        {
            this.value = value;
        }
        internal bool Add(int value)
        {
            Node node = new Node(value);
            if (value < this.value)
            {
                if (this.left == null)
                {
                    this.left = node;
                    return true;
                }
                else
                    return this.left.Add(value);
            }
            else if (value > this.value)
            {
                if (this.right == null)
                {
                    this.right = node;
                    return true;
                }
                else
                    return this.right.Add(value);
            }
            return false;
        }
        internal bool Remove(int value, Node parent, ref Node root)
        {
            if (value < this.value)
            {
                if (left != null)
                {
                    return left.Remove(value, this, ref root);
                }
            }
            else if (value > this.value)
            {
                if (right != null)
                {
                    return right.Remove(value, this, ref root);
                }
            }
            else if (value == this.value)
            {
                bool isLeft = (this == parent.left);
                if (left == null && right == null)
                {
                    if (root == this)
                        root = null;
                    else
                    if (isLeft) parent.left = null; else parent.right = null;
                }
                else if (right == null)
                {
                    if (isLeft) parent.left = left; else parent.right = left;
                    if (root == this)
                        root = left;
                }
                else
                {
                    if (right.left == null)
                    {
                        right.left = left;
                        if (isLeft) parent.left = right;
                        else
                            parent.right = right;
                        if (root == this)
                            root = right;
                    }
                    else
                    {
                        Node node = right;
                        while (node.left.left != null)
                            node = node.left;
                        Console.WriteLine("Node: " + node.value);
                        this.value = node.left.value;
                        Console.WriteLine("here");
                        node.left = null;
                    }
                }
                return true;
            }
            return false;
        }
        public Image Draw()
        {
            Size lSize = new Size(nodeBg.Width / 2, 0);
            Size rSize = new Size(nodeBg.Width / 2, 0);
            Image lNodeImg = null;
            Image rNodeImg = null;
            int lCenter = 0, rCenter = 0;

            if (this.left != null)
            {
                lNodeImg = left.Draw();
                lSize = lNodeImg.Size;
                this.center = lSize.Width;
                lCenter = left.center;
            }
            if (this.right != null)
            {
                rNodeImg = right.Draw();
                rSize = rNodeImg.Size;
                rCenter = right.center;
            }
            int maxHeight = (lSize.Height < rSize.Height) ? rSize.Height : lSize.Height;
            if (maxHeight > 0) maxHeight += 35;
            Size resultSize = new Size(lSize.Width + rSize.Width, nodeBg.Size.Height +
maxHeight);
            Bitmap result = new Bitmap(resultSize.Width, resultSize.Height);

            Graphics g = Graphics.FromImage(result);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(Brushes.White, new Rectangle(new Point(0, 0), resultSize));
            g.DrawImage(nodeBg, lSize.Width - nodeBg.Width / 2, 0);

            string str = "" + value;
            g.DrawString(str, font, Brushes.Black, lSize.Width - nodeBg.Width / 2 + 7,
           nodeBg.Height / 2f - 12);
            Pen pen = new Pen(Brushes.Black, 1.2f);
            float x1 = center;
            float y1 = nodeBg.Height;
            float y2 = nodeBg.Height + 35;
            float x2 = lCenter;
            var h = Math.Abs(y2 - y1);
            var w = Math.Abs(x2 - x1);
            if (lNodeImg != null)
            {
                g.DrawImage(lNodeImg, 0, nodeBg.Size.Height + 35);
                var points1 = new List<PointF>
 {
 new PointF(x1, y1),
 new PointF(x1 - w/6, y1 + h/3.5f),
 new PointF(x2 + w/6, y2 - h/3.5f),
 new PointF(x2, y2),
 };
                g.DrawCurve(pen, points1.ToArray(), 0.5f);
            }
            if (rNodeImg != null)
            {
                g.DrawImage(rNodeImg, lSize.Width, nodeBg.Size.Height + 35);
                x2 = rCenter + lSize.Width;
                w = Math.Abs(x2 - x1);
                var points = new List<PointF>
 {
 new PointF(x1, y1),
 new PointF(x1 + w/6, y1 + h/3.5f),
 new PointF(x2 - w/6, y2 - h/3.5f),
 new PointF(x2, y2)
 };
                g.DrawCurve(pen, points.ToArray(), 0.5f);
            }
            return result;
        }
        public bool Exists(int value)
        {
            bool res = value == this.value;
            if (!res && left != null)
                res = left.Exists(value);
            if (!res && right != null)
                res = right.Exists(value);
            return res;
          }
        }
}
