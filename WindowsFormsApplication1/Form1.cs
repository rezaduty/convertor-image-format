using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Image im;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                im = Image.FromFile(op.FileName);

            }
        }

        SaveFileDialog sv = new SaveFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            im.Save(sv.FileName+".gif",System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Successed", "Success");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            im.Save(sv.FileName +".gif", System.Drawing.Imaging.ImageFormat.Gif);
            MessageBox.Show("Successed", "Success");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sv.ShowDialog();
            im.Save(sv.FileName+".png",System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Successed", "Success");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Environment.CurrentDirectory + @"\" + "a (8)" + @".ssk";
            this.skinEngine1.Active = true;
        }
    }
}
