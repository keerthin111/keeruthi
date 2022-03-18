using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial  class Form1 : Form
    {
        static Random r = new Random();
        int value;
        int guessnum;
        int win = 10;
        int guess = 1;
        TextBox textBox1;
        RichTextBox richTextBox1;
        RichTextBox richTextBox2;
        Label label4;
        public Form1()
        {
            InitializeComponent();
            value = r.Next(100);
            this.Controls.Clear();
            this.BackColor = Color.SkyBlue;
            this.AutoSize = true;
            this.Padding = new Padding(16);
            Label label = new Label();
            label.Text = "Pick a number between 1 and 100";
            label.Bounds = new Rectangle(10, 20, 340, 40);
            label.Font = new Font("Arial", 16);
            textBox1 = new TextBox();
            textBox1.Bounds = new Rectangle(20, 50, 120, 80);
            textBox1.Font = new Font("Arial", 24);

            button1 = new Button();
            button1.Text = " Check Your Guess ";
            button1.Bounds = new Rectangle(160, 50, 120, 40);
            button1.BackColor = Color.LightGray;
            button1.Click += new EventHandler(button1_Click);
            Label label2 = new Label();
            label2.Text = "Low Guess";
            label2.Bounds = new Rectangle(20, 150, 160, 40);
            label2.Font = new Font("Arial", 18);
            richTextBox1 = new RichTextBox();
            richTextBox1.Bounds = new Rectangle(20, 190, 160, 300);
            richTextBox1.Font = new Font("Arial", 16);

            Label label3 = new Label();
            label3.Text = "High Guess";
            label3.Bounds = new Rectangle(180, 150, 160, 40);
            label3.Font = new Font("Arial", 18);
            richTextBox2 = new RichTextBox();
            richTextBox2.Bounds = new Rectangle(180, 190, 160, 300);
            richTextBox2.Font = new Font("Arial", 16);
            label4 = new Label();
            label4.Bounds = new Rectangle(20, 100, 340, 40);
            label4.Font = new Font("Arial", 16);
            this.Controls.Add(label);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(richTextBox2);

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            guessnum = Convert.ToInt32(textBox1.Text);
            textBox1.Text = String.Empty;
            if (win >= 0)
            {
                if (guessnum == value)
                {
                    MessageBox.Show("You have guessed the number! \n The number was " + value);
                    InitializeComponent();
                }
                else if (guessnum < value)
                {
                    richTextBox1.Text += guessnum + "\n";
                    label4.Text = "wrong Guess and number of guesses left are " + (10 - guess);
                }
                else if (guessnum > value)
                {
                    richTextBox2.Text += guessnum + "\n";
                    label4.Text = "wrong Guess and number of guesses left are " + (10 - guess);
                }
                guess++;
                win--;
            }
            if (guess == 11)
            {
                label4.Text = "You loose,Correct Guess is " + value;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }

