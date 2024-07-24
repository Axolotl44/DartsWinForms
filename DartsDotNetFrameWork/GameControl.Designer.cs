namespace DartsDotNetFrameWork
{
    partial class GameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentRoundLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YesNewGame = new System.Windows.Forms.Button();
            this.NoNewGame = new System.Windows.Forms.Button();
            this.NewGamePanel = new System.Windows.Forms.Panel();
            this.ThrowPanel = new System.Windows.Forms.Panel();
            this.NewGamePanel.SuspendLayout();
            this.ThrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(213, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 480);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CurrentRoundLabel
            // 
            this.CurrentRoundLabel.AutoSize = true;
            this.CurrentRoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentRoundLabel.ForeColor = System.Drawing.Color.Silver;
            this.CurrentRoundLabel.Location = new System.Drawing.Point(54, 83);
            this.CurrentRoundLabel.Name = "CurrentRoundLabel";
            this.CurrentRoundLabel.Size = new System.Drawing.Size(95, 20);
            this.CurrentRoundLabel.TabIndex = 2;
            this.CurrentRoundLabel.Text = "1.Set, 1.Leg";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dobás:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(43, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Új játék?";
            // 
            // YesNewGame
            // 
            this.YesNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YesNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YesNewGame.ForeColor = System.Drawing.Color.Black;
            this.YesNewGame.Location = new System.Drawing.Point(12, 58);
            this.YesNewGame.Name = "YesNewGame";
            this.YesNewGame.Size = new System.Drawing.Size(76, 28);
            this.YesNewGame.TabIndex = 7;
            this.YesNewGame.Text = "Igen";
            this.YesNewGame.UseVisualStyleBackColor = false;
            this.YesNewGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoNewGame
            // 
            this.NoNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NoNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoNewGame.ForeColor = System.Drawing.Color.Black;
            this.NoNewGame.Location = new System.Drawing.Point(103, 58);
            this.NoNewGame.Name = "NoNewGame";
            this.NoNewGame.Size = new System.Drawing.Size(76, 28);
            this.NoNewGame.TabIndex = 8;
            this.NoNewGame.Text = "Nem";
            this.NoNewGame.UseVisualStyleBackColor = false;
            this.NoNewGame.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewGamePanel
            // 
            this.NewGamePanel.Controls.Add(this.label2);
            this.NewGamePanel.Controls.Add(this.NoNewGame);
            this.NewGamePanel.Controls.Add(this.YesNewGame);
            this.NewGamePanel.Location = new System.Drawing.Point(16, 337);
            this.NewGamePanel.Name = "NewGamePanel";
            this.NewGamePanel.Size = new System.Drawing.Size(191, 100);
            this.NewGamePanel.TabIndex = 9;
            // 
            // ThrowPanel
            // 
            this.ThrowPanel.Controls.Add(this.label3);
            this.ThrowPanel.Controls.Add(this.textBox1);
            this.ThrowPanel.Controls.Add(this.button1);
            this.ThrowPanel.Location = new System.Drawing.Point(28, 148);
            this.ThrowPanel.Name = "ThrowPanel";
            this.ThrowPanel.Size = new System.Drawing.Size(158, 139);
            this.ThrowPanel.TabIndex = 10;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThrowPanel);
            this.Controls.Add(this.NewGamePanel);
            this.Controls.Add(this.CurrentRoundLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(842, 560);
            this.NewGamePanel.ResumeLayout(false);
            this.NewGamePanel.PerformLayout();
            this.ThrowPanel.ResumeLayout(false);
            this.ThrowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label CurrentRoundLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YesNewGame;
        private System.Windows.Forms.Button NoNewGame;
        private System.Windows.Forms.Panel NewGamePanel;
        private System.Windows.Forms.Panel ThrowPanel;
    }
}
