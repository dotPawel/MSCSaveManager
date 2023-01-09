using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Windows.Forms.Design;

namespace MSCSaveManager
{
    public partial class Form1 : Form
    {
        static string SaveDataPath;
        static string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + @"\Amistech\My Summer Car\";
        static string SelectedSlot;
        static string version = "1.0";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionLabel.Text = version;
            if (Directory.Exists(defaultPath))
            {
                SaveDataPath = defaultPath;
                PathText.Text = "Path : " + defaultPath;
                PathText.ForeColor = Color.Green;

                if (!Directory.Exists(defaultPath + "MSCSM_Data"))
                {
                    Directory.CreateDirectory(defaultPath + "MSCSM_Data");
                }

                RefreshSlotTree();
            }
            else
            {
                MessageBox.Show("Could not find LocalLow/Amistech/My Summer Car/\nthe default path will be set to empty\n\nMake sure to create a save file before using this tool", "Save data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PathText.Text = "Path : Not Found!";
                PathText.ForeColor = Color.Red;

                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
            }

        }
        private void RefreshSlotTree()
        {
            slotsTree.BeginUpdate();
            slotsTree.Nodes.Clear();
            string[] slots = Directory.GetDirectories(SaveDataPath + "MSCSM_Data", "*", SearchOption.TopDirectoryOnly);
            foreach (string slot in slots)
            {
                string slotname = Path.GetFileName(slot).ToString();
                slotsTree.Nodes.Add(slotname);
            }
            slotsTree.EndUpdate();
        }
        private void slotsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedSlot = e.Node.Text;
            selectedslotText.Text = "Selected slot : " + SelectedSlot;
        }

        private void loadslotButton_Click(object sender, EventArgs e)
        {
            string slotdir = defaultPath + @"MSCSM_Data\" + SelectedSlot + @"\";
            try
            {
                File.Copy(slotdir + @"defaultES2File.txt", defaultPath + "defaultES2File.txt", true);
                File.Copy(slotdir + @"graveyard.txt", defaultPath + "graveyard.txt", true);
                File.Copy(slotdir + @"items.txt", defaultPath + "items.txt", true);
                File.Copy(slotdir + @"meshsave.txt", defaultPath + "meshsave.txt", true);
                File.Copy(slotdir + @"notepad.txt", defaultPath + "notepad.txt", true);
                File.Copy(slotdir + @"options.txt", defaultPath + "options.txt", true);
                File.Copy(slotdir + @"trophies.txt", defaultPath + "trophies.txt", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load save\n\nException : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Successfully loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveslotButton_Click(object sender, EventArgs e)
        {
            if (slotnameBox.Text.Length > 0 && !Directory.Exists(defaultPath + @"MSCSM_Data\" + slotnameBox.Text))
            {
                Directory.CreateDirectory(defaultPath + @"MSCSM_Data\" + slotnameBox.Text);

                string slotdir = defaultPath + @"MSCSM_Data\" + slotnameBox.Text + @"\";

                string[] files = Directory.GetFiles(defaultPath, "*", SearchOption.TopDirectoryOnly);
                foreach (string data in files)
                {
                    if (data.EndsWith("defaultES2File.txt") || data.EndsWith("graveyard.txt") || data.EndsWith("items.txt") || data.EndsWith("meshsave.txt") || data.EndsWith("notepad.txt") || data.EndsWith("options.txt") || data.EndsWith("trophies.txt"))
                    {
                        string FileName = Path.GetFileName(data);
                        File.Copy(defaultPath + FileName, slotdir + FileName);
                    }
                }
                MessageBox.Show("Successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slotnameBox.Text = "";
                RefreshSlotTree();
            }
            else
            {
                MessageBox.Show("Invalid slot name", "Slot name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshtreeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshSlotTree();
        }

        private void deleteslotButton_Click(object sender, EventArgs e)
        {
            if (SelectedSlot != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure", "Slot deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(defaultPath + @"MSCSM_Data\" + SelectedSlot, true);
                        RefreshSlotTree();
                        MessageBox.Show("Successfully deleted save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete save\n\nException : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }         
            }
            else
            {
                MessageBox.Show("Cannot delete a slot that isnt selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openslotButton_Click(object sender, EventArgs e)
        {
            if (SelectedSlot != null)
            {
                Process.Start("explorer.exe", defaultPath + @"MSCSM_Data\" + SelectedSlot);
            }
            else
            {
                MessageBox.Show("Cannot open a slot that isnt selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}