using System.Xml;
using System.IO;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CheckList
{
    class ListManager
    {
        private List<string> labels;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +  @"\SebPas\Checklist";

        private CheckListForm mainForm;

        public ListManager(CheckListForm mainForm)
        {
            labels = new List<string>();

            this.mainForm = mainForm;

            init();
        }

        public int GetXPosition(Label label)
        {
            int i = 3;

            if (SettingsClass.instance.rightScreenSide)
            {
                i = mainForm.Size.Width - label.Width - 25;
            }

            return i;
        }

        // reloads the labels on the windows form and updates them (called when a label was removed)
        public void reload()
        {
            try
            {
                labels.Clear();
                mainForm.ClearPanel();
                XmlDocument doc = new XmlDocument();
                doc.Load(path + @"\checklist.xml");

                foreach (XmlNode node in doc.GetElementsByTagName("checklist").Item(0).ChildNodes)
                {
                    labels.Add(node.InnerText);
                }

                foreach (string l in labels)
                {
                    mainForm.diplayLabel(l);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //load label list from xml file
        private void init()
        {
            if(!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }

            if(!File.Exists(path + @"\checklist.xml"))
            {
                save();
                return;
            }

            reload();
        }

        // adds a new label item
        public void add(string label)
        {
            labels.Add(label);
        }

        // removes a label item
        public void remove(string label)
        {
            labels.Remove(label);
        }

        //saves the label list as xml file
        public void save()
        {
            if (File.Exists(path + @"\checklist.xml"))
            {
                File.Delete(path + @"\checklist.xml");
            }

            XmlWriter writer = XmlWriter.Create(path + @"\checklist.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("checklist");

            foreach (string item in labels)
            {
                writer.WriteStartElement("item");
                writer.WriteString(item);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
    }
}
