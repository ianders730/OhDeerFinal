namespace OhDeer1
{
    partial class Game
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.LevelName = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ScoreName = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.car1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // LevelName
            // 
            this.LevelName.AutoSize = true;
            this.LevelName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LevelName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LevelName.Location = new System.Drawing.Point(9, 419);
            this.LevelName.Name = "LevelName";
            this.LevelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LevelName.Size = new System.Drawing.Size(54, 22);
            this.LevelName.TabIndex = 0;
            this.LevelName.Text = "Level: ";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LevelLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LevelLabel.Location = new System.Drawing.Point(54, 419);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(18, 22);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "1";
            // 
            // ScoreName
            // 
            this.ScoreName.AutoSize = true;
            this.ScoreName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ScoreName.Location = new System.Drawing.Point(9, 382);
            this.ScoreName.Name = "ScoreName";
            this.ScoreName.Size = new System.Drawing.Size(51, 22);
            this.ScoreName.TabIndex = 2;
            this.ScoreName.Text = "Score:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ScoreLabel.Location = new System.Drawing.Point(54, 382);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(18, 22);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "1";
            // 
            // car1
            // 
            this.car1.Tick += new System.EventHandler(this.car1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ScoreName);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelName);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label LevelName;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ScoreName;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer car1;
    }
}

