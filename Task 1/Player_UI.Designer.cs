
namespace Task_1
{
    partial class Player_UI
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
            this.UpBtn = new System.Windows.Forms.Button();
            this.Downbtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(626, 261);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(68, 39);
            this.UpBtn.TabIndex = 0;
            this.UpBtn.Text = "^";
            this.UpBtn.UseVisualStyleBackColor = true;
            // 
            // Downbtn
            // 
            this.Downbtn.Location = new System.Drawing.Point(626, 361);
            this.Downbtn.Name = "Downbtn";
            this.Downbtn.Size = new System.Drawing.Size(68, 39);
            this.Downbtn.TabIndex = 1;
            this.Downbtn.Text = "v";
            this.Downbtn.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(548, 306);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(68, 39);
            this.LeftBtn.TabIndex = 2;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = true;
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(702, 306);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(68, 39);
            this.RightBtn.TabIndex = 3;
            this.RightBtn.Text = ">";
            this.RightBtn.UseVisualStyleBackColor = true;
            // 
            // Player_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.Downbtn);
            this.Controls.Add(this.UpBtn);
            this.Name = "Player_UI";
            this.Text = "Player_UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button Downbtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RightBtn;
    }
}