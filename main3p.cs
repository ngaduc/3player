using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3player
{
    public partial class main3p : Form
    {
        private _3playercore _3player = new _3playercore();
        public main3p()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3player.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _3player.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.Filter = "Mp3 Files | *.mp3";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    _3player.open(openfile.FileName);
                }
            }
        }
    }
}
