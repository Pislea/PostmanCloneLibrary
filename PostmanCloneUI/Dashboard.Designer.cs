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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelApi = new System.Windows.Forms.Label();
            this.textBoxApi = new System.Windows.Forms.TextBox();
            this.buttonCallApi = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelResults = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(28, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(308, 59);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Postman Clone";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // labelApi
            // 
            this.labelApi.AutoSize = true;
            this.labelApi.Location = new System.Drawing.Point(37, 66);
            this.labelApi.Name = "labelApi";
            this.labelApi.Size = new System.Drawing.Size(69, 41);
            this.labelApi.TabIndex = 1;
            this.labelApi.Text = "API:";
            // 
            // textBoxApi
            // 
            this.textBoxApi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApi.Location = new System.Drawing.Point(99, 64);
            this.textBoxApi.Name = "textBoxApi";
            this.textBoxApi.Size = new System.Drawing.Size(656, 40);
            this.textBoxApi.TabIndex = 2;
            this.textBoxApi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.textBoxApi.TextChanged += new System.EventHandler(this.textBoxApi_TextChanged);
            // 
            // buttonCallApi
            // 
            this.buttonCallApi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCallApi.Location = new System.Drawing.Point(761, 64);
            this.buttonCallApi.Name = "buttonCallApi";
            this.buttonCallApi.Size = new System.Drawing.Size(74, 40);
            this.buttonCallApi.TabIndex = 3;
            this.buttonCallApi.Text = "GO";
            this.buttonCallApi.UseVisualStyleBackColor = true;
            this.buttonCallApi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.buttonCallApi.Click += new System.EventHandler(this.buttonCallApi_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(38, 151);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(912, 385);
            this.textBoxResults.TabIndex = 4;
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.WordWrap = false;
            this.textBoxResults.Font = new System.Drawing.Font("Consolas", 10);
            this.textBoxResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.textBoxResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(980, 44);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 38);
            this.statusLabel.Text = "Ready";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(37, 107);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(98, 41);
            this.labelResults.TabIndex = 6;
            this.labelResults.Text = "Result";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 583);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonCallApi);
            this.Controls.Add(this.textBoxApi);
            this.Controls.Add(this.labelApi);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Dashboard";
            this.Text = "Postman Clone by Gheorghe Pislea";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelApi;
        private System.Windows.Forms.TextBox textBoxApi;
        private System.Windows.Forms.Button buttonCallApi;
        private System.Windows.Forms.RichTextBox textBoxResults;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
