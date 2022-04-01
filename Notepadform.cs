using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string fileName;
        private RichTextBox txtContent;
        private ToolBar toolBar;
        internal Form1()
        {

            fileName = null;
            initializeComponents(); 
        }
        void initializeComponents()
        {
            this.Text = "My notepad";
            this.MinimumSize = new Size(600, 450);
            this.FormClosing += new FormClosingEventHandler(NotepadClosing);
            this.MaximizeBox = true;
            toolBar = new ToolBar();
            toolBar.Font = new Font("Arial", 16);
            toolBar.Padding = new Padding(4);
            toolBar.ButtonClick += new ToolBarButtonClickEventHandler(toolBarClicked);
            ToolBarButton toolBarButton1 = new ToolBarButton();
            ToolBarButton toolBarButton2 = new ToolBarButton();
            ToolBarButton toolBarButton3 = new ToolBarButton();
            toolBarButton1.Text = "New";
            toolBarButton2.Text = "Open";
            toolBarButton3.Text = "Save";
            toolBar.Buttons.Add(toolBarButton1);
            toolBar.Buttons.Add(toolBarButton2);
            toolBar.Buttons.Add(toolBarButton3);
            txtContent = new RichTextBox();
            txtContent.Size = this.ClientSize;
            txtContent.Height -= toolBar.Height;
            txtContent.Top = toolBar.Height;
            txtContent.Anchor = AnchorStyles.Left | AnchorStyles.Right |
           AnchorStyles.Top | AnchorStyles.Bottom;
            txtContent.Font = new Font("Arial", 16);
            txtContent.AcceptsTab = true;
            txtContent.Padding = new Padding(8);
            this.Controls.Add(toolBar);
            this.Controls.Add(txtContent);
        }
        private void toolBarClicked(Object sender, ToolBarButtonClickEventArgs e)
        {
            saveFile();
            switch (toolBar.Buttons.IndexOf(e.Button))
            {
                case 0:
                    this.Text += "My notepad";
                    txtContent.Text = string.Empty;
                    fileName = null;
                    break;
                case 1:
                    OpenFileDialog openDlg = new OpenFileDialog();
                    if (DialogResult.OK == openDlg.ShowDialog())
                    {
                        fileName = openDlg.FileName;
                        txtContent.LoadFile(fileName);
                        this.Text = "My notepad " + fileName;
                    }
                    break;
            }
        }
        void saveFile()
        {
            if (fileName == null)
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                if (DialogResult.OK == saveDlg.ShowDialog())
                {
                    fileName = saveDlg.FileName;
                    this.Text += " " + fileName;
                }
            }
            else
            {
                txtContent.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
        }
        private void NotepadClosing(Object sender, FormClosingEventArgs e)
        {
            saveFile();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
