namespace MineSweeperGUI
{
    partial class FrmScores
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
            dgvScores = new DataGridView();
            btnOK = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            byNameToolStripMenuItem = new ToolStripMenuItem();
            byScoreToolStripMenuItem = new ToolStripMenuItem();
            byDateToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblAvgPoints = new Label();
            label3 = new Label();
            lblAvgTime = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvScores).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvScores
            // 
            dgvScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScores.Location = new Point(14, 31);
            dgvScores.Name = "dgvScores";
            dgvScores.Size = new Size(657, 402);
            dgvScores.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(266, 444);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 26);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, sortToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(707, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { byNameToolStripMenuItem, byScoreToolStripMenuItem, byDateToolStripMenuItem });
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(40, 20);
            sortToolStripMenuItem.Text = "Sort";
            // 
            // byNameToolStripMenuItem
            // 
            byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            byNameToolStripMenuItem.Size = new Size(122, 22);
            byNameToolStripMenuItem.Text = "By Name";
            byNameToolStripMenuItem.Click += byNameToolStripMenuItem_Click;
            // 
            // byScoreToolStripMenuItem
            // 
            byScoreToolStripMenuItem.Name = "byScoreToolStripMenuItem";
            byScoreToolStripMenuItem.Size = new Size(122, 22);
            byScoreToolStripMenuItem.Text = "By Score";
            byScoreToolStripMenuItem.Click += byScoreToolStripMenuItem_Click;
            // 
            // byDateToolStripMenuItem
            // 
            byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            byDateToolStripMenuItem.Size = new Size(122, 22);
            byDateToolStripMenuItem.Text = "By Date";
            byDateToolStripMenuItem.Click += byDateToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 449);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 3;
            label1.Text = "Average Points";
            // 
            // lblAvgPoints
            // 
            lblAvgPoints.AutoSize = true;
            lblAvgPoints.Location = new Point(169, 449);
            lblAvgPoints.Name = "lblAvgPoints";
            lblAvgPoints.Size = new Size(46, 17);
            lblAvgPoints.TabIndex = 4;
            lblAvgPoints.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 477);
            label3.Name = "label3";
            label3.Size = new Size(134, 17);
            label3.TabIndex = 5;
            label3.Text = "Average time/game";
            // 
            // lblAvgTime
            // 
            lblAvgTime.AutoSize = true;
            lblAvgTime.Location = new Point(169, 477);
            lblAvgTime.Name = "lblAvgTime";
            lblAvgTime.Size = new Size(46, 17);
            lblAvgTime.TabIndex = 6;
            lblAvgTime.Text = "label4";
            // 
            // FrmScores
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 537);
            Controls.Add(lblAvgTime);
            Controls.Add(label3);
            Controls.Add(lblAvgPoints);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(dgvScores);
            Controls.Add(menuStrip1);
            Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "FrmScores";
            Text = "Scores";
            Load += FrmScores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvScores).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvScores;
        private Button btnOK;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem byNameToolStripMenuItem;
        private ToolStripMenuItem byScoreToolStripMenuItem;
        private ToolStripMenuItem byDateToolStripMenuItem;
        private Label label1;
        private Label lblAvgPoints;
        private Label label3;
        private Label lblAvgTime;
    }
}