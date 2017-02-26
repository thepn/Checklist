using System;
using System.Drawing;
using System.Windows.Forms;


namespace CheckList
{
    public partial class CheckListForm : Form
    {
        // indicates how many labels are visible
        private int labelIndex = 0;

        private ListManager listManager;

        //makes the form draggable
        public ControlDrag controlBag;

        public CheckListForm()
        {
            InitializeComponent();
            TransparencyKey = BackColor;

            controlBag = new ControlDrag(null, this, label1, false, false);
            controlBag.Enabled = false;

            setColors();

            listManager = new ListManager(this);
            ReloadPanel();

            if (SettingsClass.instance.draggable)
            {
                Location = new Point(SettingsClass.instance.xpos, SettingsClass.instance.ypos);
                controlBag.Enabled = true;
            }
        }

        // create the "add" textbox
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newCheckTextBox.Location = new Point(newCheckTextBox.Location.X, labelIndex * 25 + 50);
            newCheckTextBox.Visible = true;
            newCheckTextBox.Focus();
            if (!panel1.Controls.Contains(newCheckTextBox))
            {
                panel1.Controls.Add(newCheckTextBox);
            }
        }

        private void settingsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }

        // (re)loads all the colors from the labels
        public void setColors()
        {
            label1.BackColor = Color.FromArgb(255, (int)SettingsClass.instance.bgR, (int)SettingsClass.instance.bgG, (int)SettingsClass.instance.bgB);
            label1.ForeColor = Color.FromArgb(255, (int)SettingsClass.instance.textR, (int)SettingsClass.instance.textG, (int)SettingsClass.instance.textB);

            foreach (Control l in panel1.Controls)
            {
                if(l.GetType() == typeof(Label))
                {
                    Label label = (Label)l;

                    label.BackColor = Color.FromArgb(255, (int)SettingsClass.instance.bgR, (int)SettingsClass.instance.bgG, (int)SettingsClass.instance.bgB);
                    label.ForeColor = Color.FromArgb(255, (int)SettingsClass.instance.textR, (int)SettingsClass.instance.textG, (int)SettingsClass.instance.textB);
                }
            }
        }

        // adds a label to the form (called when loading labels from file; not by user action)
        public void diplayLabel(string text)
        {
            labelIndex++;
            Label label = new Label();
            label.Text = text;
            label.BackColor = Color.FromArgb(255, (int)SettingsClass.instance.bgR, (int)SettingsClass.instance.bgG, (int)SettingsClass.instance.bgB);
            label.ForeColor = Color.FromArgb(255, (int)SettingsClass.instance.textR, (int)SettingsClass.instance.textG, (int)SettingsClass.instance.textB);
            label.Font = new Font(label.Font.Name, 14, label.Font.Style);
            label.Size = new Size((int)Math.Round(GetStringWidth(label, label.Text, label.Font)) + 3, 27);
            label.Location = new Point(listManager.GetXPosition(label), labelIndex * 27);
            panel1.Controls.Add(label);

            label.DoubleClick += removeLabel;
        }

        public void removeLabel(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            listManager.remove(label.Text);

            panel1.Controls.Remove((Control) sender);
            listManager.save();
            ReloadPanel();
        }

        // adds a label to the form (called when a new label was created by the user)
        public void addLabel(string text)
        {
            labelIndex++;
            listManager.add(text);
            Label label = new Label();
            label.Text = text;
            label.BackColor = Color.FromArgb(255, (int)SettingsClass.instance.bgR, (int)SettingsClass.instance.bgG, (int)SettingsClass.instance.bgB);
            label.ForeColor = Color.FromArgb(255, (int)SettingsClass.instance.textR, (int)SettingsClass.instance.textG, (int)SettingsClass.instance.textB);
            label.Font = new Font(label.Font.Name, 14, label.Font.Style);
            label.Size = new Size((int)Math.Round(GetStringWidth(label, label.Text, label.Font)) + 3, 27);
            label.Location = new Point(listManager.GetXPosition(label), labelIndex * 27);
            panel1.Controls.Add(label);

            // hide the textbox
            newCheckTextBox.Visible = false;
            newCheckTextBox.Text = "";
            
            listManager.save();
            label.DoubleClick += removeLabel;
        }

        // event stuff

        private void CheckListForm_LocationChanged(object sender, EventArgs e)
        {
            SettingsClass.instance.xpos = Location.X;
            SettingsClass.instance.ypos = Location.Y;
        }

        private void newCheckTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && newCheckTextBox.Visible)
            {
                addLabel(newCheckTextBox.Text);
            }
        }

        // returns the width of a string using font 'font'
        public double GetStringWidth(Control control, string text, Font font)
        {
            Graphics g = control.CreateGraphics();
            SizeF stringSize = g.MeasureString(text, font);
            g.Dispose();
            return stringSize.Width + 3;
        }

        //clears the panel which contains the notice labels
        public void ClearPanel()
        {
            labelIndex = 0;
            panel1.Controls.Clear();
        }

        // reloads the checklist panel and updates its orientation
        public void ReloadPanel()
        {
            if (SettingsClass.instance.rightScreenSide)
            {
                label1.Location = new Point(Size.Width - label1.Size.Width, label1.Location.Y);
                settingsLabel.Location = new Point(13 + 350, settingsLabel.Location.Y);
                linkLabel1.Location = new Point(64 + 350, linkLabel1.Location.Y);
            }
            else
            {
                label1.Location = new Point(13, label1.Location.Y);
                settingsLabel.Location = new Point(13, settingsLabel.Location.Y);
                linkLabel1.Location = new Point(64, linkLabel1.Location.Y);
            }

            TopMost = SettingsClass.instance.alwaysOnTop;

            UpdateDragSettings();
            listManager.reload();
        }

        public void UpdateDragSettings()
        {
            controlBag = new ControlDrag(null, this, label1, false, false);
            controlBag.Enabled = SettingsClass.instance.draggable;
            Console.Write(controlBag.Enabled + " ");
        }

        private void CheckListForm_MouseMove(object sender, MouseEventArgs e)
        {
            bool hover = e.X > Location.X && e.X < (Location.X + Size.Width) && e.Y > Location.Y && e.Y < (Location.Y + Size.Height);

            Console.WriteLine(hover);
        }
    }
}
