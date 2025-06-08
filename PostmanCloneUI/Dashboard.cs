using System;
using System.Text.Json;
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
            comboBox1.SelectedItem = "GET"; // Set default verb
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
            // enable or disable the button based on input
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

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an HTTP verb.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HttpAction action;
            if (Enum.TryParse(comboBox1.SelectedItem.ToString(), out action) == false)
            {
                MessageBox.Show("Invalid HTTP verb selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SetStatus("Calling API...");

                // Validate JSON only for POST and PUT
                if (action == HttpAction.POST || action == HttpAction.PUT)
                {
                    try
                    {
                        JsonDocument.Parse(bodyText.Text);
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show("The JSON in the Body tab is not valid.", "Invalid JSON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string jsonPayload = bodyText.Text;
                string result = await _apiAccess.CallApi(url, action: action, jsonPayload: jsonPayload);

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
            // : handle when user clicks on Results tab
        }

        private void textBoxResults_TextChanged(object sender, EventArgs e)
        {
            // : handle when result text changes
        }
    }
}
