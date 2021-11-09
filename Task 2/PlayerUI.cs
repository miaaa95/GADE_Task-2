using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task_1
{
    public partial class frmUI : Form
    {
        public frmUI()
        {
            InitializeComponent();
        }

        GameEngine game = new GameEngine();

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PlayerUI_Load(object sender, EventArgs e)
        {
            label1.Text = game.ToString();
            label2.Text = game.GetMap.GetPlayer.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
