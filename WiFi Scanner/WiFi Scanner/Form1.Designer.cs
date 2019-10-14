namespace WiFi_Scanner
{
    partial class title
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
            this.myList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.signalStrength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyright = new System.Windows.Forms.Label();
            this.tableTitle = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myList
            // 
            this.myList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.accessPoint,
            this.signalStrength});
            this.myList.HideSelection = false;
            this.myList.Location = new System.Drawing.Point(25, 56);
            this.myList.Margin = new System.Windows.Forms.Padding(2);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(269, 232);
            this.myList.TabIndex = 0;
            this.myList.UseCompatibleStateImageBehavior = false;
            this.myList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "No";
            this.id.Width = 30;
            // 
            // accessPoint
            // 
            this.accessPoint.Text = "Access Point";
            this.accessPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accessPoint.Width = 125;
            // 
            // signalStrength
            // 
            this.signalStrength.Text = "Signal Strength";
            this.signalStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signalStrength.Width = 110;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(78, 333);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(160, 13);
            this.copyright.TabIndex = 1;
            this.copyright.Text = "@2019 - Flux Hydra Technology";
            // 
            // tableTitle
            // 
            this.tableTitle.AutoSize = true;
            this.tableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTitle.Location = new System.Drawing.Point(92, 24);
            this.tableTitle.Name = "tableTitle";
            this.tableTitle.Size = new System.Drawing.Size(142, 16);
            this.tableTitle.TabIndex = 2;
            this.tableTitle.Text = "Available Networks";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(123, 298);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 355);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tableTitle);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.myList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "title";
            this.Text = "WiFi Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader accessPoint;
        private System.Windows.Forms.ColumnHeader signalStrength;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label tableTitle;
        private System.Windows.Forms.Button RefreshButton;
    }
}

