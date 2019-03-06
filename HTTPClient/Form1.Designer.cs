namespace HTTPClient
{
    partial class HTTPClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.DataEntry1 = new System.Windows.Forms.TextBox();
            this.DataEntry2 = new System.Windows.Forms.TextBox();
            this.DataEntry3 = new System.Windows.Forms.TextBox();
            this.DataEntry4 = new System.Windows.Forms.TextBox();
            this.DataEntry5 = new System.Windows.Forms.TextBox();
            this.Response = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.GetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(375, 252);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(101, 38);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(64, 84);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(412, 22);
            this.URLTextbox.TabIndex = 1;
            this.URLTextbox.Text = "https://localhost:44382/api/datamodel";
            // 
            // DataEntry1
            // 
            this.DataEntry1.Location = new System.Drawing.Point(166, 112);
            this.DataEntry1.Name = "DataEntry1";
            this.DataEntry1.Size = new System.Drawing.Size(310, 22);
            this.DataEntry1.TabIndex = 2;
            this.DataEntry1.Text = "12";
            // 
            // DataEntry2
            // 
            this.DataEntry2.Location = new System.Drawing.Point(166, 140);
            this.DataEntry2.Name = "DataEntry2";
            this.DataEntry2.Size = new System.Drawing.Size(310, 22);
            this.DataEntry2.TabIndex = 3;
            this.DataEntry2.Text = "56.8";
            // 
            // DataEntry3
            // 
            this.DataEntry3.Location = new System.Drawing.Point(166, 168);
            this.DataEntry3.Name = "DataEntry3";
            this.DataEntry3.Size = new System.Drawing.Size(310, 22);
            this.DataEntry3.TabIndex = 4;
            this.DataEntry3.Text = "Hi";
            // 
            // DataEntry4
            // 
            this.DataEntry4.Location = new System.Drawing.Point(166, 196);
            this.DataEntry4.Name = "DataEntry4";
            this.DataEntry4.Size = new System.Drawing.Size(310, 22);
            this.DataEntry4.TabIndex = 5;
            this.DataEntry4.Text = "true";
            // 
            // DataEntry5
            // 
            this.DataEntry5.Location = new System.Drawing.Point(166, 224);
            this.DataEntry5.Name = "DataEntry5";
            this.DataEntry5.Size = new System.Drawing.Size(310, 22);
            this.DataEntry5.TabIndex = 6;
            this.DataEntry5.Text = "12345";
            // 
            // Response
            // 
            this.Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Response.Location = new System.Drawing.Point(611, 84);
            this.Response.Multiline = true;
            this.Response.Name = "Response";
            this.Response.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Response.Size = new System.Drawing.Size(296, 297);
            this.Response.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data 1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data 2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data 5";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data 4";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data 3";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Response";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "URL";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(64, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(412, 22);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "https://localhost:44382/api/datamodel";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(166, 361);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(310, 22);
            this.textBox6.TabIndex = 18;
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(375, 389);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(101, 38);
            this.GetData.TabIndex = 19;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // HTTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.DataEntry5);
            this.Controls.Add(this.DataEntry4);
            this.Controls.Add(this.DataEntry3);
            this.Controls.Add(this.DataEntry2);
            this.Controls.Add(this.DataEntry1);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.Submit);
            this.Name = "HTTPClient";
            this.Text = "HTTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.TextBox DataEntry1;
        private System.Windows.Forms.TextBox DataEntry2;
        private System.Windows.Forms.TextBox DataEntry3;
        private System.Windows.Forms.TextBox DataEntry4;
        private System.Windows.Forms.TextBox DataEntry5;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button GetData;
    }
}

