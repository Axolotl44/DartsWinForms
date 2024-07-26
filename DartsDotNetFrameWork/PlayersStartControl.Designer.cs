namespace DartsDotNetFrameWork
{
    partial class PlayersStartControl
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
            this.setLabel = new System.Windows.Forms.Label();
            this.legLabel = new System.Windows.Forms.Label();
            this.gameTypeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.gameStartButton = new System.Windows.Forms.Button();
            this.MagaAGame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveGameCheckBox = new System.Windows.Forms.CheckBox();
            this.MagaAGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékszabályok:";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setLabel.ForeColor = System.Drawing.Color.Silver;
            this.setLabel.Location = new System.Drawing.Point(15, 139);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(42, 24);
            this.setLabel.TabIndex = 1;
            this.setLabel.Text = "Set:";
            // 
            // legLabel
            // 
            this.legLabel.AutoSize = true;
            this.legLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.legLabel.ForeColor = System.Drawing.Color.Silver;
            this.legLabel.Location = new System.Drawing.Point(15, 97);
            this.legLabel.Name = "legLabel";
            this.legLabel.Size = new System.Drawing.Size(47, 24);
            this.legLabel.TabIndex = 2;
            this.legLabel.Text = "Leg:";
            // 
            // gameTypeLabel
            // 
            this.gameTypeLabel.AutoSize = true;
            this.gameTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameTypeLabel.ForeColor = System.Drawing.Color.Silver;
            this.gameTypeLabel.Location = new System.Drawing.Point(15, 55);
            this.gameTypeLabel.Name = "gameTypeLabel";
            this.gameTypeLabel.Size = new System.Drawing.Size(53, 24);
            this.gameTypeLabel.TabIndex = 3;
            this.gameTypeLabel.Text = "Pont:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(21, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Label5";
            // 
            // playerNameInput
            // 
            this.playerNameInput.Location = new System.Drawing.Point(26, 45);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(172, 20);
            this.playerNameInput.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 20;
            this.playersListBox.Location = new System.Drawing.Point(562, 132);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(155, 184);
            this.playersListBox.TabIndex = 7;
            // 
            // gameStartButton
            // 
            this.gameStartButton.Location = new System.Drawing.Point(26, 108);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(172, 55);
            this.gameStartButton.TabIndex = 9;
            this.gameStartButton.Text = "Kezdés";
            this.gameStartButton.UseVisualStyleBackColor = true;
            this.gameStartButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MagaAGame
            // 
            this.MagaAGame.Controls.Add(this.panel2);
            this.MagaAGame.Controls.Add(this.panel1);
            this.MagaAGame.Controls.Add(this.playersListBox);
            this.MagaAGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagaAGame.Location = new System.Drawing.Point(0, 0);
            this.MagaAGame.Name = "MagaAGame";
            this.MagaAGame.Size = new System.Drawing.Size(826, 521);
            this.MagaAGame.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.playerNameInput);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.gameStartButton);
            this.panel2.Location = new System.Drawing.Point(309, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 182);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveGameCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gameTypeLabel);
            this.panel1.Controls.Add(this.legLabel);
            this.panel1.Controls.Add(this.setLabel);
            this.panel1.Location = new System.Drawing.Point(56, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 221);
            this.panel1.TabIndex = 10;
            // 
            // saveGameCheckBox
            // 
            this.saveGameCheckBox.AutoSize = true;
            this.saveGameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveGameCheckBox.ForeColor = System.Drawing.Color.Silver;
            this.saveGameCheckBox.Location = new System.Drawing.Point(19, 175);
            this.saveGameCheckBox.Name = "saveGameCheckBox";
            this.saveGameCheckBox.Size = new System.Drawing.Size(150, 28);
            this.saveGameCheckBox.TabIndex = 4;
            this.saveGameCheckBox.Text = "Játék mentése";
            this.saveGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayersStartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MagaAGame);
            this.Name = "PlayersStartControl";
            this.Size = new System.Drawing.Size(826, 521);
            this.MagaAGame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Label legLabel;
        private System.Windows.Forms.Label gameTypeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Panel MagaAGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox saveGameCheckBox;
    }
}
