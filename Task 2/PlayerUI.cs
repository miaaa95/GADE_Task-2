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
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
            fillEnemyBox();
            //EnemycomboBox.Text = game.GetMap.GetEnemies[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillEnemyBox()
        {
            EnemycomboBox.Items.Clear();
            for (int i = 0; i < game.GetMap.GetEnemies.Length; i++)
            {
                EnemycomboBox.Items.Add(game.GetMap.GetEnemies[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.MovePlayer(movementEnum.Up);

            game.GetMap.UpdateGame();
            game.MoveEnemies(movementEnum.NoMovement);
            fillEnemyBox();
            game.GetMap.UpdateGame();
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
        }

        private void bttnDown_Click(object sender, EventArgs e)
        {
            game.MovePlayer(movementEnum.Down);
            game.EnemyAttack();
            game.GetMap.UpdateGame();
            game.MoveEnemies(movementEnum.NoMovement);
            fillEnemyBox();
            game.GetMap.UpdateGame();
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
        }

        private void bttnRight_Click(object sender, EventArgs e)
        {
            game.MovePlayer(movementEnum.Right);
            game.EnemyAttack();
            game.GetMap.UpdateGame();
            game.MoveEnemies(movementEnum.NoMovement);
            fillEnemyBox();
            game.GetMap.UpdateGame();
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
        }

        private void bttnLeft_Click(object sender, EventArgs e)
        {
            game.MovePlayer(movementEnum.Left);
            game.EnemyAttack();
            game.GetMap.UpdateGame();
            game.MoveEnemies(movementEnum.NoMovement);
            fillEnemyBox();
            game.GetMap.UpdateGame();
            lblMap.Text = game.ToString();
            rchTxtStats.Text = game.GetMap.GetPlayer.ToString();
        }

        private void bttnAttack_Click(object sender, EventArgs e)
        {
            rchtTxtBxLog.Text = game.PlayerAttack(EnemycomboBox.SelectedIndex);
            fillEnemyBox();

        }
    }
}
