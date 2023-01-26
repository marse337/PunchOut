namespace PunchOut
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BoxerHealthBar = new System.Windows.Forms.ProgressBar();
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Boxer = new System.Windows.Forms.PictureBox();
            this.BoxerAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.BoxerMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxerHealthBar
            // 
            this.BoxerHealthBar.Location = new System.Drawing.Point(54, 51);
            this.BoxerHealthBar.Name = "BoxerHealthBar";
            this.BoxerHealthBar.Size = new System.Drawing.Size(179, 23);
            this.BoxerHealthBar.TabIndex = 0;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.Location = new System.Drawing.Point(472, 51);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(166, 23);
            this.PlayerHealthBar.TabIndex = 1;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::PunchOut.Properties.Resources.boxer_stand;
            this.Player.Location = new System.Drawing.Point(325, 396);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(61, 153);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // Boxer
            // 
            this.Boxer.BackColor = System.Drawing.Color.Transparent;
            this.Boxer.Image = global::PunchOut.Properties.Resources.enemy_stand;
            this.Boxer.Location = new System.Drawing.Point(382, 313);
            this.Boxer.Name = "Boxer";
            this.Boxer.Size = new System.Drawing.Size(77, 185);
            this.Boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Boxer.TabIndex = 3;
            this.Boxer.TabStop = false;
            // 
            // BoxerAttackTimer
            // 
            this.BoxerAttackTimer.Enabled = true;
            this.BoxerAttackTimer.Interval = 500;
            this.BoxerAttackTimer.Tick += new System.EventHandler(this.BoxerAttackTimerEvent);
            // 
            // BoxerMoveTimer
            // 
            this.BoxerMoveTimer.Enabled = true;
            this.BoxerMoveTimer.Interval = 20;
            this.BoxerMoveTimer.Tick += new System.EventHandler(this.BoxerMoveTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PunchOut.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayerHealthBar);
            this.Controls.Add(this.BoxerHealthBar);
            this.Controls.Add(this.Boxer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Punch Out";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BoxerHealthBar;
        private System.Windows.Forms.ProgressBar PlayerHealthBar;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Boxer;
        private System.Windows.Forms.Timer BoxerAttackTimer;
        private System.Windows.Forms.Timer BoxerMoveTimer;
    }
}

