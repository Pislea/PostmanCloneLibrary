namespace PostmanCloneUI
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelApi;
        private System.Windows.Forms.TextBox textBoxApi;
        private System.Windows.Forms.Button buttonCallApi;
        private System.Windows.Forms.RichTextBox textBoxResults;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl callData;
        private System.Windows.Forms.TabPage bodyTab;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.RichTextBox bodyText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelHeader = new System.Windows.Forms.Label();
            labelApi = new System.Windows.Forms.Label();
            textBoxApi = new System.Windows.Forms.TextBox();
            buttonCallApi = new System.Windows.Forms.Button();
            textBoxResults = new System.Windows.Forms.RichTextBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            callData = new System.Windows.Forms.TabControl();
            bodyTab = new System.Windows.Forms.TabPage();
            bodyText = new System.Windows.Forms.RichTextBox();
            resultsTab = new System.Windows.Forms.TabPage();

            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            resultsTab.SuspendLayout();
            SuspendLayout();

            // labelHeader
            labelHeader.AutoSize = true;
            labelHeader.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            labelHeader.Location = new System.Drawing.Point(28, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new System.Drawing.Size(308, 59);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Postman Clone";
            labelHeader.Click += new System.EventHandler(labelHeader_Click);

            // labelApi
            labelApi.AutoSize = true;
            labelApi.Location = new System.Drawing.Point(40, 72);
            labelApi.Name = "labelApi";
            labelApi.Size = new System.Drawing.Size(69, 41);
            labelApi.TabIndex = 1;
            labelApi.Text = "API:";

            // comboBox1
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            comboBox1.DropDownHeight = 100;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "GET", "POST", "PUT", "DELETE" });
            comboBox1.Location = new System.Drawing.Point(103, 77);
            comboBox1.Margin = new System.Windows.Forms.Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(124, 36);
            comboBox1.TabIndex = 7;

            // textBoxApi
            textBoxApi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxApi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxApi.Location = new System.Drawing.Point(232, 76);
            textBoxApi.Name = "textBoxApi";
            textBoxApi.Size = new System.Drawing.Size(638, 40);
            textBoxApi.TabIndex = 2;
            textBoxApi.TextChanged += new System.EventHandler(textBoxApi_TextChanged);

            // buttonCallApi
            buttonCallApi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCallApi.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            buttonCallApi.Location = new System.Drawing.Point(876, 76);
            buttonCallApi.Name = "buttonCallApi";
            buttonCallApi.Size = new System.Drawing.Size(74, 40);
            buttonCallApi.TabIndex = 3;
            buttonCallApi.Text = "GO";
            buttonCallApi.UseVisualStyleBackColor = true;
            buttonCallApi.Click += new System.EventHandler(buttonCallApi_Click);

            // callData
            callData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultsTab);
            callData.Location = new System.Drawing.Point(44, 141);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new System.Drawing.Size(906, 380);
            callData.TabIndex = 8;

            // bodyTab
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new System.Drawing.Point(4, 50);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new System.Windows.Forms.Padding(3);
            bodyTab.Size = new System.Drawing.Size(898, 326);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;

            // bodyText
            bodyText.Dock = System.Windows.Forms.DockStyle.Fill;
            bodyText.Font = new System.Drawing.Font("Consolas", 10F);
            bodyText.Location = new System.Drawing.Point(3, 3);
            bodyText.Name = "bodyText";
            bodyText.Size = new System.Drawing.Size(892, 320);
            bodyText.TabIndex = 5;
            bodyText.Text = "";
            bodyText.WordWrap = false;
            bodyText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;

            // resultsTab
            resultsTab.Controls.Add(textBoxResults);
            resultsTab.Location = new System.Drawing.Point(4, 50);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new System.Windows.Forms.Padding(0); // Needed to avoid clipping scrollbar
            resultsTab.Size = new System.Drawing.Size(898, 326);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Results";
            resultsTab.UseVisualStyleBackColor = true;
            resultsTab.Click += new System.EventHandler(outputTab_Click);

            // textBoxResults
            textBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxResults.Font = new System.Drawing.Font("Consolas", 10F);
            textBoxResults.Location = new System.Drawing.Point(0, 0);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ReadOnly = true;
            textBoxResults.Size = new System.Drawing.Size(898, 326);
            textBoxResults.TabIndex = 4;
            textBoxResults.Text = "";
            textBoxResults.WordWrap = false; //  Required for horizontal scrollbar
            textBoxResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both; //  Shows both scrollbars
            textBoxResults.TextChanged += new System.EventHandler(textBoxResults_TextChanged);

            // statusStrip
            statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 539);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(980, 44);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";

            // statusLabel
            statusLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(92, 38);
            statusLabel.Text = "Ready";

            // Dashboard
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(980, 583);
            Controls.Add(callData);
            Controls.Add(comboBox1);
            Controls.Add(statusStrip);
            Controls.Add(buttonCallApi);
            Controls.Add(textBoxApi);
            Controls.Add(labelApi);
            Controls.Add(labelHeader);
            Font = new System.Drawing.Font("Segoe UI", 18F);
            Margin = new System.Windows.Forms.Padding(6);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "Dashboard";
            Text = "Postman Clone by Gheorghe Pislea";
            Load += new System.EventHandler(Dashboard_Load);

            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            resultsTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
