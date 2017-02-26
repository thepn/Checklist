namespace CheckList
{
    partial class CheckListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newCheckTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECKLIST";
            // 
            // settingsLabel
            // 
            this.settingsLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(13, 517);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(45, 13);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.TabStop = true;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.settingsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newCheckTextBox);
            this.panel1.Location = new System.Drawing.Point(20, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 455);
            this.panel1.TabIndex = 2;
            // 
            // newCheckTextBox
            // 
            this.newCheckTextBox.Location = new System.Drawing.Point(3, 3);
            this.newCheckTextBox.Name = "newCheckTextBox";
            this.newCheckTextBox.Size = new System.Drawing.Size(200, 20);
            this.newCheckTextBox.TabIndex = 0;
            this.newCheckTextBox.Visible = false;
            this.newCheckTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newCheckTextBox_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(64, 517);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(26, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CheckListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(452, 542);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Checklist";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.LocationChanged += new System.EventHandler(this.CheckListForm_LocationChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckListForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel settingsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox newCheckTextBox;
    }
}

