using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using XMLReader;
using XMLReader.Helpers;

namespace AdvancedRPC
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clientIDTextBox.AppendText(xml.ReadSettings().clientId);
            largeImg.AppendText(xml.ReadSettings().largeImg);
            largeImgText.AppendText(xml.ReadSettings().largeImgText);
            smallImg.AppendText(xml.ReadSettings().smallImg);
            smallImgText.AppendText(xml.ReadSettings().smallImgText);
            deviceDetail.Checked = xml.ReadSettings().deviceDetail == "True";
            partyCheckBox.Checked = xml.ReadSettings().partyEnable == "True";
            buttonCheck.Checked = xml.ReadSettings().button == "True";
            presenceUpdate.Checked = xml.ReadSettings().updatePresence == "True";
            partyInputMessage.AppendText(xml.ReadSettings().partyMessage);
            partyMax.Value = xml.ReadSettings().partyMax;
            partySize.Value = xml.ReadSettings().partySize;
            buttonText.AppendText(xml.ReadSettings().buttonText);
            buttonLink.AppendText(xml.ReadSettings().buttonLink);
            partyShow(xml.ReadSettings().partyEnable == "True");
            buttonShow(xml.ReadSettings().button == "True");

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void presenceUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveSettings()
        {
            if (partySize.Value > partyMax.Value || partyMax.Value < partySize.Value) MessageBox.Show("Party size cant be higher than party max or lower than party size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                XmlSettings settings = new XmlSettings();

                if (!long.TryParse(clientIDTextBox.Text, out _))
                {
                    MessageBox.Show("Client ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (clientIDTextBox.Text != xml.ReadSettings().clientId) MessageBox.Show("Client ID has changed. Please restart the application.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                settings.clientId = clientIDTextBox.Text;
                settings.largeImg = largeImg.Text;
                settings.largeImgText = largeImgText.Text;
                settings.smallImg = smallImg.Text;
                settings.smallImgText = smallImgText.Text;
                settings.deviceDetail = deviceDetail.Checked.ToString();
                settings.partyEnable = partyCheckBox.Checked.ToString();
                settings.updatePresence = presenceUpdate.Checked.ToString();
                settings.partySize = Convert.ToInt32(partySize.Value);
                settings.partyMax = Convert.ToInt32(partyMax.Value);
                settings.partyMessage = partyInputMessage.Text;
                settings.button = buttonCheck.Checked.ToString();
                settings.buttonText = buttonText.Text;
                settings.buttonLink = buttonLink.Text;
                xml.SaveToXml(settings);
                MessageBox.Show("Settings Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            XmlSettings currentSettings = xml.ReadSettings();
            bool hasChanges = false;

            if (clientIDTextBox.Text != currentSettings.clientId) hasChanges = true;
            if (largeImg.Text != currentSettings.largeImg) hasChanges = true;
            if (largeImgText.Text != currentSettings.largeImgText) hasChanges = true;
            if (smallImg.Text != currentSettings.smallImg) hasChanges = true;
            if (smallImgText.Text != currentSettings.smallImgText) hasChanges = true;
            if (deviceDetail.Checked.ToString() != currentSettings.deviceDetail) hasChanges = true;
            if (partyCheckBox.Checked.ToString() != currentSettings.partyEnable) hasChanges = true;
            if (presenceUpdate.Checked.ToString() != currentSettings.updatePresence) hasChanges = true;
            if (Convert.ToInt32(partySize.Value) != currentSettings.partySize) hasChanges = true;
            if (Convert.ToInt32(partyMax.Value) != currentSettings.partyMax) hasChanges = true;
            if (partyInputMessage.Text != currentSettings.partyMessage) hasChanges = true;
            if (buttonCheck.Checked.ToString() != currentSettings.button) hasChanges = true;
            if (buttonText.Text != currentSettings.buttonText) hasChanges = true;
            if (buttonLink.Text != currentSettings.buttonLink) hasChanges = true;

            if (!hasChanges)
            {
                MessageBox.Show("No changes detected. Settings have not been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                SaveSettings();
            }
        }

        private void partyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (partyCheckBox.Checked)
            {
                partyShow(true);
                deviceDetail.Checked = false;
                deviceDetail.Enabled = false;
            }
            else
            {
                partyShow(false);
                deviceDetail.Checked = true;
                deviceDetail.Enabled = true;
            }
        }

        private void partyShow(bool value)
        {
            partySize.Enabled = value;
            partyMax.Enabled = value;
            partyInputMessage.Enabled = value;
            partyMessage.Enabled = value;
            partyLabel.Enabled = value;
            partyOf.Enabled = value;
        }

        private void buttonShow(bool value)
        {
            buttonText.Enabled = value;
            label10.Enabled = value;
            label11.Enabled = value;
            buttonLink.Enabled = value;
        }

        private void partySize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/iseizuu");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (buttonCheck.Checked) { buttonShow(true); }
            else { buttonShow(false); }
        }

        private void buttonText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}