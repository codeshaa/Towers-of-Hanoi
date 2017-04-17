namespace Towers_of_Hanoi
{
    partial class MainForm
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
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk4 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMoves
            // 
            this.txtMoves.Enabled = false;
            this.txtMoves.Location = new System.Drawing.Point(1225, 44);
            this.txtMoves.Margin = new System.Windows.Forms.Padding(6);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(396, 650);
            this.txtMoves.TabIndex = 17;
            this.txtMoves.Visible = false;
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.Lime;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Location = new System.Drawing.Point(196, 421);
            this.lblDisk1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(94, 44);
            this.lblDisk1.TabIndex = 16;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.Lime;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Location = new System.Drawing.Point(164, 467);
            this.lblDisk2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(158, 44);
            this.lblDisk2.TabIndex = 15;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.Lime;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Location = new System.Drawing.Point(132, 513);
            this.lblDisk3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(222, 44);
            this.lblDisk3.TabIndex = 14;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk4
            // 
            this.lblDisk4.BackColor = System.Drawing.Color.Lime;
            this.lblDisk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk4.Location = new System.Drawing.Point(100, 560);
            this.lblDisk4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisk4.Name = "lblDisk4";
            this.lblDisk4.Size = new System.Drawing.Size(286, 44);
            this.lblDisk4.TabIndex = 13;
            this.lblDisk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(26, 606);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(6);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1168, 92);
            this.pnlBase.TabIndex = 9;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Location = new System.Drawing.Point(218, 360);
            this.lblPeg1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(48, 277);
            this.lblPeg1.TabIndex = 10;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Location = new System.Drawing.Point(586, 360);
            this.lblPeg2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(48, 277);
            this.lblPeg2.TabIndex = 11;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Location = new System.Drawing.Point(954, 360);
            this.lblPeg3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(48, 277);
            this.lblPeg3.TabIndex = 12;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(26, 44);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(138, 43);
            this.btnNewGame.TabIndex = 18;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(26, 107);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(138, 43);
            this.btnAnimate.TabIndex = 19;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(513, 44);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(71, 25);
            this.lblMove.TabIndex = 21;
            this.lblMove.Text = "Move:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(581, 44);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(24, 25);
            this.lblMoves.TabIndex = 22;
            this.lblMoves.Text = "0";
            // 
            // animateTimer
            // 
            this.animateTimer.Interval = 400;
            this.animateTimer.Tick += new System.EventHandler(this.animateTimer_Elapsed);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Location = new System.Drawing.Point(26, 178);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(138, 39);
            this.btnSaveGame.TabIndex = 23;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(191, 44);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(131, 43);
            this.btnLoadGame.TabIndex = 24;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // txtMove
            // 
            this.txtMove.Location = new System.Drawing.Point(1225, 41);
            this.txtMove.Multiline = true;
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(427, 636);
            this.txtMove.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 786);
            this.Controls.Add(this.txtMove);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk4;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Timer animateTimer;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.TextBox txtMove;
    }
}

