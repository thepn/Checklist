namespace CheckList
{
    partial class Settings
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
            this.Backgroundcolor = new System.Windows.Forms.GroupBox();
            this.bgRed = new System.Windows.Forms.TrackBar();
            this.bgGreen = new System.Windows.Forms.TrackBar();
            this.bgBlue = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRed = new System.Windows.Forms.TrackBar();
            this.textGreen = new System.Windows.Forms.TrackBar();
            this.textBlue = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxDragable = new System.Windows.Forms.CheckBox();
            this.rBtnLeftScreen = new System.Windows.Forms.RadioButton();
            this.rBtnRightScreen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.Backgroundcolor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgBlue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // Backgroundcolor
            // 
            this.Backgroundcolor.Controls.Add(this.bgRed);
            this.Backgroundcolor.Controls.Add(this.bgGreen);
            this.Backgroundcolor.Controls.Add(this.bgBlue);
            this.Backgroundcolor.Controls.Add(this.label4);
            this.Backgroundcolor.Controls.Add(this.label3);
            this.Backgroundcolor.Controls.Add(this.label2);
            this.Backgroundcolor.Location = new System.Drawing.Point(12, 12);
            this.Backgroundcolor.Name = "Backgroundcolor";
            this.Backgroundcolor.Size = new System.Drawing.Size(343, 160);
            this.Backgroundcolor.TabIndex = 0;
            this.Backgroundcolor.TabStop = false;
            this.Backgroundcolor.Text = "Background color";
            // 
            // bgRed
            // 
            this.bgRed.Location = new System.Drawing.Point(58, 17);
            this.bgRed.Maximum = 100;
            this.bgRed.Name = "bgRed";
            this.bgRed.Size = new System.Drawing.Size(279, 42);
            this.bgRed.TabIndex = 20;
            this.bgRed.TickFrequency = 5;
            this.bgRed.Scroll += new System.EventHandler(this.bgRed_Scroll);
            // 
            // bgGreen
            // 
            this.bgGreen.Location = new System.Drawing.Point(58, 65);
            this.bgGreen.Maximum = 100;
            this.bgGreen.Name = "bgGreen";
            this.bgGreen.Size = new System.Drawing.Size(279, 42);
            this.bgGreen.TabIndex = 19;
            this.bgGreen.TickFrequency = 5;
            this.bgGreen.Scroll += new System.EventHandler(this.bgGreen_Scroll);
            // 
            // bgBlue
            // 
            this.bgBlue.Location = new System.Drawing.Point(58, 113);
            this.bgBlue.Maximum = 100;
            this.bgBlue.Name = "bgBlue";
            this.bgBlue.Size = new System.Drawing.Size(279, 42);
            this.bgBlue.TabIndex = 16;
            this.bgBlue.TickFrequency = 5;
            this.bgBlue.Scroll += new System.EventHandler(this.bgBlue_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Red";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRed);
            this.groupBox1.Controls.Add(this.textGreen);
            this.groupBox1.Controls.Add(this.textBlue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text color";
            // 
            // textRed
            // 
            this.textRed.Location = new System.Drawing.Point(58, 17);
            this.textRed.Maximum = 100;
            this.textRed.Name = "textRed";
            this.textRed.Size = new System.Drawing.Size(279, 42);
            this.textRed.TabIndex = 20;
            this.textRed.TickFrequency = 5;
            this.textRed.Scroll += new System.EventHandler(this.textRed_Scroll);
            // 
            // textGreen
            // 
            this.textGreen.Location = new System.Drawing.Point(58, 65);
            this.textGreen.Maximum = 100;
            this.textGreen.Name = "textGreen";
            this.textGreen.Size = new System.Drawing.Size(279, 42);
            this.textGreen.TabIndex = 19;
            this.textGreen.TickFrequency = 5;
            this.textGreen.Scroll += new System.EventHandler(this.textGreen_Scroll);
            // 
            // textBlue
            // 
            this.textBlue.Location = new System.Drawing.Point(58, 113);
            this.textBlue.Maximum = 100;
            this.textBlue.Name = "textBlue";
            this.textBlue.Size = new System.Drawing.Size(279, 42);
            this.textBlue.TabIndex = 16;
            this.textBlue.TickFrequency = 5;
            this.textBlue.Scroll += new System.EventHandler(this.textBlue_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Red";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(273, 486);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(192, 486);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 23;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(12, 367);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(143, 17);
            this.checkBoxAlwaysOnTop.TabIndex = 24;
            this.checkBoxAlwaysOnTop.Text = "Window is always on top";
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxDragable
            // 
            this.checkBoxDragable.AutoSize = true;
            this.checkBoxDragable.Location = new System.Drawing.Point(176, 367);
            this.checkBoxDragable.Name = "checkBoxDragable";
            this.checkBoxDragable.Size = new System.Drawing.Size(183, 17);
            this.checkBoxDragable.TabIndex = 25;
            this.checkBoxDragable.Text = "Moveable when dragging the title";
            this.checkBoxDragable.UseVisualStyleBackColor = true;
            // 
            // rBtnLeftScreen
            // 
            this.rBtnLeftScreen.AutoSize = true;
            this.rBtnLeftScreen.Location = new System.Drawing.Point(12, 439);
            this.rBtnLeftScreen.Name = "rBtnLeftScreen";
            this.rBtnLeftScreen.Size = new System.Drawing.Size(80, 17);
            this.rBtnLeftScreen.TabIndex = 26;
            this.rBtnLeftScreen.TabStop = true;
            this.rBtnLeftScreen.Text = "Left Screen";
            this.rBtnLeftScreen.UseVisualStyleBackColor = true;
            this.rBtnLeftScreen.CheckedChanged += new System.EventHandler(this.rBtnLeftScreen_CheckedChanged);
            // 
            // rBtnRightScreen
            // 
            this.rBtnRightScreen.AutoSize = true;
            this.rBtnRightScreen.Location = new System.Drawing.Point(176, 439);
            this.rBtnRightScreen.Name = "rBtnRightScreen";
            this.rBtnRightScreen.Size = new System.Drawing.Size(87, 17);
            this.rBtnRightScreen.TabIndex = 27;
            this.rBtnRightScreen.TabStop = true;
            this.rBtnRightScreen.Text = "Right Screen";
            this.rBtnRightScreen.UseVisualStyleBackColor = true;
            this.rBtnRightScreen.CheckedChanged += new System.EventHandler(this.rBtnRightScreen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Screen side (format of the checklist: orientation to the left or right side)";
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Location = new System.Drawing.Point(12, 390);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(234, 17);
            this.checkBoxAutoRun.TabIndex = 29;
            this.checkBoxAutoRun.Text = "Run application while starting your computer";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 521);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnRightScreen);
            this.Controls.Add(this.rBtnLeftScreen);
            this.Controls.Add(this.checkBoxDragable);
            this.Controls.Add(this.checkBoxAlwaysOnTop);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backgroundcolor);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Backgroundcolor.ResumeLayout(false);
            this.Backgroundcolor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgBlue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Backgroundcolor;
        private System.Windows.Forms.TrackBar bgRed;
        private System.Windows.Forms.TrackBar bgGreen;
        private System.Windows.Forms.TrackBar bgBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar textRed;
        private System.Windows.Forms.TrackBar textGreen;
        private System.Windows.Forms.TrackBar textBlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxDragable;
        private System.Windows.Forms.RadioButton rBtnLeftScreen;
        private System.Windows.Forms.RadioButton rBtnRightScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAutoRun;
    }
}