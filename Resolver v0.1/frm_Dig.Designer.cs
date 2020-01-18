namespace dnsResolver
{
    partial class frm_dig
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
            this.btn_closeFormDig = new System.Windows.Forms.Button();
            this.txt_digInfo = new System.Windows.Forms.TextBox();
            this.lbl_domain = new System.Windows.Forms.Label();
            this.lbl_nsToQuery = new System.Windows.Forms.Label();
            this.txt_domainToDig = new System.Windows.Forms.TextBox();
            this.cmb_nsToQuery = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_closeFormDig
            // 
            this.btn_closeFormDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeFormDig.Location = new System.Drawing.Point(331, 381);
            this.btn_closeFormDig.Name = "btn_closeFormDig";
            this.btn_closeFormDig.Size = new System.Drawing.Size(75, 23);
            this.btn_closeFormDig.TabIndex = 0;
            this.btn_closeFormDig.Text = "Close";
            this.btn_closeFormDig.UseVisualStyleBackColor = true;
            this.btn_closeFormDig.Click += new System.EventHandler(this.btn_closeFormDig_Click);
            // 
            // txt_digInfo
            // 
            this.txt_digInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_digInfo.Location = new System.Drawing.Point(12, 84);
            this.txt_digInfo.Multiline = true;
            this.txt_digInfo.Name = "txt_digInfo";
            this.txt_digInfo.Size = new System.Drawing.Size(394, 291);
            this.txt_digInfo.TabIndex = 13;
            this.txt_digInfo.Text = "This is not yet working";
            // 
            // lbl_domain
            // 
            this.lbl_domain.AutoSize = true;
            this.lbl_domain.Location = new System.Drawing.Point(9, 9);
            this.lbl_domain.Name = "lbl_domain";
            this.lbl_domain.Size = new System.Drawing.Size(43, 13);
            this.lbl_domain.TabIndex = 2;
            this.lbl_domain.Text = "Domain";
            // 
            // lbl_nsToQuery
            // 
            this.lbl_nsToQuery.AutoSize = true;
            this.lbl_nsToQuery.Location = new System.Drawing.Point(9, 39);
            this.lbl_nsToQuery.Name = "lbl_nsToQuery";
            this.lbl_nsToQuery.Size = new System.Drawing.Size(112, 13);
            this.lbl_nsToQuery.TabIndex = 3;
            this.lbl_nsToQuery.Text = "Name Server to Query";
            // 
            // txt_domainToDig
            // 
            this.txt_domainToDig.Location = new System.Drawing.Point(127, 6);
            this.txt_domainToDig.Name = "txt_domainToDig";
            this.txt_domainToDig.Size = new System.Drawing.Size(174, 20);
            this.txt_domainToDig.TabIndex = 1;
            // 
            // cmb_nsToQuery
            // 
            this.cmb_nsToQuery.FormattingEnabled = true;
            this.cmb_nsToQuery.Location = new System.Drawing.Point(127, 36);
            this.cmb_nsToQuery.Name = "cmb_nsToQuery";
            this.cmb_nsToQuery.Size = new System.Drawing.Size(174, 21);
            this.cmb_nsToQuery.TabIndex = 2;
            // 
            // frm_dig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 416);
            this.Controls.Add(this.cmb_nsToQuery);
            this.Controls.Add(this.txt_domainToDig);
            this.Controls.Add(this.lbl_nsToQuery);
            this.Controls.Add(this.lbl_domain);
            this.Controls.Add(this.txt_digInfo);
            this.Controls.Add(this.btn_closeFormDig);
            this.Name = "frm_dig";
            this.Text = "Dig";
            this.Load += new System.EventHandler(this.frm_dig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeFormDig;
        private System.Windows.Forms.TextBox txt_digInfo;
        private System.Windows.Forms.Label lbl_domain;
        private System.Windows.Forms.Label lbl_nsToQuery;
        private System.Windows.Forms.TextBox txt_domainToDig;
        private System.Windows.Forms.ComboBox cmb_nsToQuery;
    }
}