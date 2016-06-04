using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace メニュー
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 右に行くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ゲームオーバー");
        }

        private void 左に行くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ゲームクリア");
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
