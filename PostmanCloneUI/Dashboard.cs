using System;
using System.Net.Http;
using System.Windows.Forms;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // This will run when the form loads
            statusLabel.Text = "Ready";
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            // Optional action when clicking the title
            MessageBox.Show("Welcome to the Postman Clone!");
        }

        private void textBoxApi_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle changes in the API textbox if needed
        }

        private async void buttonCallApi_Click(object sender, EventArgs e)
        {
            string url = textBoxApi.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a valid API URL.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                statusLabel.Text = "Calling API...";
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    string result = await response.Content.ReadAsStringAsync();

                    textBoxResults.Text = result;
                    statusLabel.Text = $"Status: {(int)response.StatusCode} {response.ReasonPhrase}";
                }
            }
            catch (Exception ex)
            {
                textBoxResults.Text = "Error: " + ex.Message;
                statusLabel.Text = "Error";
            }
        }
    }
}
