namespace PostmanCloneUI
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelHeader = new Label();
            labelApi = new Label();
            textBoxApi = new TextBox();
            buttonCallApi = new Button();
            textBoxResults = new TextBox();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            labelResults = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(38, 9);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(308, 59);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Postman Clone";
            labelHeader.Click += labelHeader_Click;
            // 
            // labelApi
            // 
            labelApi.AutoSize = true;
            labelApi.Location = new Point(37, 68);
            labelApi.Name = "labelApi";
            labelApi.Size = new Size(69, 41);
            labelApi.TabIndex = 1;
            labelApi.Text = "API:";
            // 
            // textBoxApi
            // 
            textBoxApi.BorderStyle = BorderStyle.None;
            textBoxApi.Location = new Point(112, 71);
            textBoxApi.Name = "textBoxApi";
            textBoxApi.Size = new Size(638, 40);
            textBoxApi.TabIndex = 2;
            textBoxApi.TextChanged += textBoxApi_TextChanged;
            // 
            // buttonCallApi
            // 
            buttonCallApi.Location = new Point(756, 68);
            buttonCallApi.Name = "buttonCallApi";
            buttonCallApi.RightToLeft = RightToLeft.No;
            buttonCallApi.Size = new Size(74, 41);
            buttonCallApi.TabIndex = 3;
            buttonCallApi.Text = "GO";
            buttonCallApi.UseVisualStyleBackColor = true;
            buttonCallApi.Click += buttonCallApi_Click;
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(37, 158);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ScrollBars = ScrollBars.Both;
            textBoxResults.WordWrap = false;
            textBoxResults.Size = new Size(883, 342);
            textBoxResults.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 539);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(980, 44);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 38);
            statusLabel.Text = "Ready";
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(38, 114);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(98, 41);
            labelResults.TabIndex = 6;
            labelResults.Text = "Result";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 583);
            Controls.Add(labelResults);
            Controls.Add(statusStrip);
            Controls.Add(textBoxResults);
            Controls.Add(buttonCallApi);
            Controls.Add(textBoxApi);
            Controls.Add(labelApi);
            Controls.Add(labelHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone by Gheorghe Pislea";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelApi;
        private TextBox textBoxApi;
        private Button buttonCallApi;
        private TextBox textBoxResults;
        private StatusStrip statusStrip;
        private Label labelResults;
        private ToolStripStatusLabel statusLabel;
    }
}
