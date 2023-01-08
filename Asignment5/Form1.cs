using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment5
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void BTNWrite_Click(object sender, EventArgs e)
        {
            StreamWriter content = new StreamWriter("content.txt",true);
            foreach (string words in TXTWrite.Text.Split(' '))
            {
                if (TXTWrite.Text.Trim() == "") 
                {
                    MessageBox.Show("بلاش استهبال، مربع الكتابة في الملف فارغ، عاوزني احفظ لك فراغ يعني 🤔؟");
                }
                else
                {
                    content.WriteLine(words);
                }                
            }
            content.Close();
            TXTWrite.Clear();
            TXTWrite.Focus();
        }

        private void BTNRead_Click(object sender, EventArgs e)
        {
            StreamReader content = new StreamReader("content.txt");
            TXTRead.Text = content.ReadToEnd();
            content.Close();
            TXTWrite.Clear();
            TXTRead.Focus();
        }
    }
}
