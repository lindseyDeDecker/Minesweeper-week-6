namespace MineSweeperGUI
{
    partial class FormName
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
            btnName = new Button();
            lblName = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnName
            // 
            btnName.Location = new Point(70, 125);
            btnName.Name = "btnName";
            btnName.Size = new Size(75, 23);
            btnName.TabIndex = 0;
            btnName.Text = "OK";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Please enter your first name";
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 248);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnName);
            Name = "FormName";
            Text = "Name Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnName;
        private Label lblName;
        private TextBox txtName;
    }
}