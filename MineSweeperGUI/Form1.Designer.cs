namespace MineSweeperGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelGameBoard = new Panel();
            btnNewGame = new Button();
            label1 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            labelscore = new Label();
            lblScore = new Label();
            groupBox1 = new GroupBox();
            rBtnCalm = new RadioButton();
            rBtnTechno = new RadioButton();
            rBtnOff = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGameBoard
            // 
            panelGameBoard.BackColor = Color.LightSteelBlue;
            panelGameBoard.Location = new Point(13, 13);
            panelGameBoard.Margin = new Padding(4);
            panelGameBoard.Name = "panelGameBoard";
            panelGameBoard.Size = new Size(700, 700);
            panelGameBoard.TabIndex = 0;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(741, 294);
            btnNewGame.Margin = new Padding(4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(161, 62);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(754, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 22);
            label1.TabIndex = 2;
            label1.Text = "Time:";
            // 
            // timer
            // 
            timer.Interval = 750;
            timer.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(832, 124);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(55, 22);
            lblTime.TabIndex = 3;
            lblTime.Text = "label2";
            // 
            // labelscore
            // 
            labelscore.AutoSize = true;
            labelscore.Location = new Point(754, 164);
            labelscore.Name = "labelscore";
            labelscore.Size = new Size(53, 22);
            labelscore.TabIndex = 4;
            labelscore.Text = "Score";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(832, 164);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(55, 22);
            lblScore.TabIndex = 5;
            lblScore.Text = "label3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnCalm);
            groupBox1.Controls.Add(rBtnTechno);
            groupBox1.Controls.Add(rBtnOff);
            groupBox1.Location = new Point(754, 451);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 156);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Background Music";
            // 
            // rBtnCalm
            // 
            rBtnCalm.AutoSize = true;
            rBtnCalm.Location = new Point(18, 115);
            rBtnCalm.Name = "rBtnCalm";
            rBtnCalm.Size = new Size(66, 26);
            rBtnCalm.TabIndex = 2;
            rBtnCalm.TabStop = true;
            rBtnCalm.Text = "Calm";
            rBtnCalm.UseVisualStyleBackColor = true;
            rBtnCalm.CheckedChanged += rBtnCalm_CheckedChanged;
            // 
            // rBtnTechno
            // 
            rBtnTechno.AutoSize = true;
            rBtnTechno.Location = new Point(18, 74);
            rBtnTechno.Name = "rBtnTechno";
            rBtnTechno.Size = new Size(74, 26);
            rBtnTechno.TabIndex = 1;
            rBtnTechno.TabStop = true;
            rBtnTechno.Text = "Techo";
            rBtnTechno.UseVisualStyleBackColor = true;
            rBtnTechno.CheckedChanged += rBtnTechno_CheckedChanged;
            // 
            // rBtnOff
            // 
            rBtnOff.AutoSize = true;
            rBtnOff.Location = new Point(18, 36);
            rBtnOff.Name = "rBtnOff";
            rBtnOff.Size = new Size(51, 26);
            rBtnOff.TabIndex = 0;
            rBtnOff.TabStop = true;
            rBtnOff.Text = "Off";
            rBtnOff.UseVisualStyleBackColor = true;
            rBtnOff.CheckedChanged += rBtnOff_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 1061);
            Controls.Add(groupBox1);
            Controls.Add(lblScore);
            Controls.Add(labelscore);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Controls.Add(btnNewGame);
            Controls.Add(panelGameBoard);
            Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGameBoard;
        private Button btnNewGame;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private Label lblTime;
        private Label labelscore;
        private Label lblScore;
        private GroupBox groupBox1;
        private RadioButton rBtnOff;
        private RadioButton rBtnCalm;
        private RadioButton rBtnTechno;
    }
}
