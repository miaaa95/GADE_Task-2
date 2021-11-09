
namespace Task_1
{
    partial class frmUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnUp = new System.Windows.Forms.Button();
            this.bttnRight = new System.Windows.Forms.Button();
            this.bttnDown = new System.Windows.Forms.Button();
            this.bttnLeft = new System.Windows.Forms.Button();
            this.grpBxStats = new System.Windows.Forms.GroupBox();
            this.grpBxAttack = new System.Windows.Forms.GroupBox();
            this.drpDwnEnemy = new System.Windows.Forms.DomainUpDown();
            this.rchTxtBxEnemyStats = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.rchtTxtBxLog = new System.Windows.Forms.RichTextBox();
            this.bttnAttack = new System.Windows.Forms.Button();
            this.lblMap = new System.Windows.Forms.Label();
            this.grpBxStats.SuspendLayout();
            this.grpBxAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnUp
            // 
            this.bttnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUp.Font = new System.Drawing.Font("Simple Outline Pat", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnUp.Location = new System.Drawing.Point(535, 362);
            this.bttnUp.Name = "bttnUp";
            this.bttnUp.Size = new System.Drawing.Size(69, 48);
            this.bttnUp.TabIndex = 0;
            this.bttnUp.Text = "^";
            this.bttnUp.UseVisualStyleBackColor = false;
            this.bttnUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnRight
            // 
            this.bttnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRight.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnRight.Location = new System.Drawing.Point(612, 420);
            this.bttnRight.Name = "bttnRight";
            this.bttnRight.Size = new System.Drawing.Size(69, 48);
            this.bttnRight.TabIndex = 1;
            this.bttnRight.Text = ">";
            this.bttnRight.UseVisualStyleBackColor = false;
            // 
            // bttnDown
            // 
            this.bttnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDown.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnDown.Location = new System.Drawing.Point(535, 478);
            this.bttnDown.Name = "bttnDown";
            this.bttnDown.Size = new System.Drawing.Size(69, 48);
            this.bttnDown.TabIndex = 2;
            this.bttnDown.Text = "V";
            this.bttnDown.UseVisualStyleBackColor = false;
            // 
            // bttnLeft
            // 
            this.bttnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLeft.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnLeft.Location = new System.Drawing.Point(457, 420);
            this.bttnLeft.Name = "bttnLeft";
            this.bttnLeft.Size = new System.Drawing.Size(69, 48);
            this.bttnLeft.TabIndex = 3;
            this.bttnLeft.Text = "<";
            this.bttnLeft.UseVisualStyleBackColor = false;
            // 
            // grpBxStats
            // 
            this.grpBxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.grpBxStats.Controls.Add(this.richTextBox2);
            this.grpBxStats.Controls.Add(this.grpBxAttack);
            this.grpBxStats.Location = new System.Drawing.Point(399, 12);
            this.grpBxStats.Name = "grpBxStats";
            this.grpBxStats.Size = new System.Drawing.Size(324, 344);
            this.grpBxStats.TabIndex = 4;
            this.grpBxStats.TabStop = false;
            this.grpBxStats.Text = "Stats";
            // 
            // grpBxAttack
            // 
            this.grpBxAttack.Controls.Add(this.bttnAttack);
            this.grpBxAttack.Controls.Add(this.rchtTxtBxLog);
            this.grpBxAttack.Controls.Add(this.rchTxtBxEnemyStats);
            this.grpBxAttack.Controls.Add(this.drpDwnEnemy);
            this.grpBxAttack.Location = new System.Drawing.Point(6, 92);
            this.grpBxAttack.Name = "grpBxAttack";
            this.grpBxAttack.Size = new System.Drawing.Size(312, 246);
            this.grpBxAttack.TabIndex = 0;
            this.grpBxAttack.TabStop = false;
            this.grpBxAttack.Text = "Attack";
            // 
            // drpDwnEnemy
            // 
            this.drpDwnEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.drpDwnEnemy.Location = new System.Drawing.Point(6, 26);
            this.drpDwnEnemy.Name = "drpDwnEnemy";
            this.drpDwnEnemy.Size = new System.Drawing.Size(296, 27);
            this.drpDwnEnemy.TabIndex = 1;
            this.drpDwnEnemy.Text = "Goblin";
            // 
            // rchTxtBxEnemyStats
            // 
            this.rchTxtBxEnemyStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.rchTxtBxEnemyStats.Location = new System.Drawing.Point(6, 59);
            this.rchTxtBxEnemyStats.Name = "rchTxtBxEnemyStats";
            this.rchTxtBxEnemyStats.Size = new System.Drawing.Size(300, 64);
            this.rchTxtBxEnemyStats.TabIndex = 2;
            this.rchTxtBxEnemyStats.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.richTextBox2.Location = new System.Drawing.Point(12, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 59);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // rchtTxtBxLog
            // 
            this.rchtTxtBxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.rchtTxtBxLog.Location = new System.Drawing.Point(6, 164);
            this.rchtTxtBxLog.Name = "rchtTxtBxLog";
            this.rchtTxtBxLog.Size = new System.Drawing.Size(300, 76);
            this.rchtTxtBxLog.TabIndex = 3;
            this.rchtTxtBxLog.Text = "";
            // 
            // bttnAttack
            // 
            this.bttnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(97)))), ((int)(((byte)(52)))));
            this.bttnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAttack.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAttack.Location = new System.Drawing.Point(6, 129);
            this.bttnAttack.Name = "bttnAttack";
            this.bttnAttack.Size = new System.Drawing.Size(296, 29);
            this.bttnAttack.TabIndex = 4;
            this.bttnAttack.Text = "ATTACK";
            this.bttnAttack.UseVisualStyleBackColor = false;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.lblMap.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMap.Location = new System.Drawing.Point(44, 39);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(270, 45);
            this.lblMap.TabIndex = 5;
            this.lblMap.Text = "XXXXXXXXXX";
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task_1.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(772, 538);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.grpBxStats);
            this.Controls.Add(this.bttnLeft);
            this.Controls.Add(this.bttnDown);
            this.Controls.Add(this.bttnRight);
            this.Controls.Add(this.bttnUp);
            this.Name = "frmUI";
            this.Text = "Goblins and Heroes - The Game";
            this.Load += new System.EventHandler(this.PlayerUI_Load);
            this.grpBxStats.ResumeLayout(false);
            this.grpBxAttack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUp;
        private System.Windows.Forms.Button bttnRight;
        private System.Windows.Forms.Button bttnDown;
        private System.Windows.Forms.Button bttnLeft;
        private System.Windows.Forms.GroupBox grpBxStats;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox grpBxAttack;
        private System.Windows.Forms.Button bttnAttack;
        private System.Windows.Forms.RichTextBox rchtTxtBxLog;
        private System.Windows.Forms.RichTextBox rchTxtBxEnemyStats;
        private System.Windows.Forms.DomainUpDown drpDwnEnemy;
        private System.Windows.Forms.Label lblMap;
    }
}