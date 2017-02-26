using System;
using System.Windows.Forms;

namespace CheckList
{
    public partial class Settings : Form
    {

        private CheckListForm instance;

        public Settings(CheckListForm instance)
        {
            InitializeComponent();
            
            bgRed.Value = (int) Math.Round(SettingsClass.instance.bgR / 255 * 100);
            bgGreen.Value = (int)Math.Round(SettingsClass.instance.bgG / 255 * 100);
            bgBlue.Value = (int)Math.Round(SettingsClass.instance.bgB / 255 * 100);

            textRed.Value = (int)Math.Round(SettingsClass.instance.textR / 255 * 100);
            textGreen.Value = (int)Math.Round(SettingsClass.instance.textG / 255 * 100);
            textBlue.Value = (int)Math.Round(SettingsClass.instance.textB / 255 * 100);

            this.instance = instance;

            checkBoxAlwaysOnTop.Checked = SettingsClass.instance.alwaysOnTop;
            checkBoxDragable.Checked = SettingsClass.instance.draggable;
            checkBoxAutoRun.Checked = SettingsClass.instance.autoStart;
            
            rBtnLeftScreen.Checked = !SettingsClass.instance.rightScreenSide;
            rBtnRightScreen.Checked = SettingsClass.instance.rightScreenSide;
        }

        // events

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            updateColors();
            SettingsClass.instance.draggable = checkBoxDragable.Checked;
            SettingsClass.instance.alwaysOnTop = checkBoxAlwaysOnTop.Checked;
            SettingsClass.instance.autoStart = checkBoxAutoRun.Checked;
            SettingsClass.instance.save();

            instance.UpdateDragSettings();
            Close();
        }

        //----------

        
        
        // updates the label colors
        private void updateColors()
        {
            SettingsClass.instance.bgR = bgRed.Value * 255 / 100;
            SettingsClass.instance.bgG = bgGreen.Value * 255 / 100;
            SettingsClass.instance.bgB = bgBlue.Value * 255 / 100;

            SettingsClass.instance.textR = textRed.Value * 255 / 100;
            SettingsClass.instance.textG = textGreen.Value * 255 / 100;
            SettingsClass.instance.textB = textBlue.Value * 255 / 100;

            instance.setColors();
        }

        // even more events (thats funny because i sad "even" and "events")

        private void bgRed_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void bgGreen_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void bgBlue_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void textRed_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void textGreen_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void textBlue_Scroll(object sender, EventArgs e)
        {
            updateColors();
        }

        private void rBtnLeftScreen_CheckedChanged(object sender, EventArgs e)
        {
            SettingsClass.instance.rightScreenSide = rBtnRightScreen.Checked;
            instance.ReloadPanel();
        }

        private void rBtnRightScreen_CheckedChanged(object sender, EventArgs e)
        {
            SettingsClass.instance.rightScreenSide = rBtnRightScreen.Checked;
            instance.ReloadPanel();
        }
    }
}
