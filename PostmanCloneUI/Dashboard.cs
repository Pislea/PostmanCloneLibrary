using System;
using System.Windows.Forms;
using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _apiAccess = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "GET";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetStatus("Ready");
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Postman Clone!");
        }

        private void textBoxApi_TextChanged(object sender, EventArgs e)
        {
            // enable/disable the Call API button
        }

        private async void buttonCallApi_Click(object sender, EventArgs e)
        {
            string url = textBoxApi.Text.Trim();

            if (string.IsNullOrWhiteSpace(url) == true)
            {
                MessageBox.Show("Please enter an API URL.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_apiAccess.IsValidUrl(url) == false)
            {
                MessageBox.Show("Please enter a valid HTTPS URL.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SetStatus("Calling API...");

                string result = await _apiAccess.CallApi(url);

                callData.SelectedTab = resultsTab;

                textBoxResults.Text = result;

                if (result.StartsWith("Error:") == true)
                {
                    SetStatus(result);
                }
                else
                {
                    SetStatus("Call successful.");
                }
            }
            catch (Exception ex)
            {
                textBoxResults.Text = $"Exception: {ex.Message}";
                SetStatus("Error");
            }
        }

        private void SetStatus(string message)
        {
            statusLabel.Text = message;
        }

        private void outputTab_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
