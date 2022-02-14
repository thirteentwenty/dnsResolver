namespace dnsResolver
{
    partial class frm_resolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_resolver));
            this.txt_domainToQuery = new System.Windows.Forms.TextBox();
            this.lbl_query = new System.Windows.Forms.Label();
            this.lbl_nsToQuery = new System.Windows.Forms.Label();
            this.dgv_address = new System.Windows.Forms.DataGridView();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arecordTTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mailExchanger = new System.Windows.Forms.DataGridView();
            this.mailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailExchanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mxTTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nameServers = new System.Windows.Forms.DataGridView();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoritativeNmeServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_query = new System.Windows.Forms.Button();
            this.lbl_atRecord = new System.Windows.Forms.Label();
            this.lbl_mxRecord = new System.Windows.Forms.Label();
            this.lbl_nameServers = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.cmb_nsToQuery = new System.Windows.Forms.ComboBox();
            this.lbl_txtRecords = new System.Windows.Forms.Label();
            this.dgv_txtRecords = new System.Windows.Forms.DataGridView();
            this.txtDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mailExchanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nameServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_txtRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_domainToQuery
            // 
            this.txt_domainToQuery.Location = new System.Drawing.Point(154, 12);
            this.txt_domainToQuery.Name = "txt_domainToQuery";
            this.txt_domainToQuery.Size = new System.Drawing.Size(175, 20);
            this.txt_domainToQuery.TabIndex = 0;
            // 
            // lbl_query
            // 
            this.lbl_query.AutoSize = true;
            this.lbl_query.Location = new System.Drawing.Point(9, 15);
            this.lbl_query.Name = "lbl_query";
            this.lbl_query.Size = new System.Drawing.Size(87, 13);
            this.lbl_query.TabIndex = 1;
            this.lbl_query.Text = "Domain to query:";
            // 
            // lbl_nsToQuery
            // 
            this.lbl_nsToQuery.AutoSize = true;
            this.lbl_nsToQuery.Location = new System.Drawing.Point(9, 50);
            this.lbl_nsToQuery.Name = "lbl_nsToQuery";
            this.lbl_nsToQuery.Size = new System.Drawing.Size(140, 13);
            this.lbl_nsToQuery.TabIndex = 2;
            this.lbl_nsToQuery.Text = "Name Server to be queried: ";
            // 
            // dgv_address
            // 
            this.dgv_address.AllowUserToAddRows = false;
            this.dgv_address.AllowUserToDeleteRows = false;
            this.dgv_address.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_address.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hostname,
            this.IP,
            this.arecordTTL});
            this.dgv_address.Location = new System.Drawing.Point(12, 101);
            this.dgv_address.Name = "dgv_address";
            this.dgv_address.ReadOnly = true;
            this.dgv_address.RowHeadersVisible = false;
            this.dgv_address.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_address.Size = new System.Drawing.Size(500, 85);
            this.dgv_address.TabIndex = 5;
            // 
            // Hostname
            // 
            this.Hostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hostname.FillWeight = 26.96153F;
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.Name = "Hostname";
            this.Hostname.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IP.FillWeight = 39.59127F;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // arecordTTL
            // 
            this.arecordTTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arecordTTL.FillWeight = 39.67562F;
            this.arecordTTL.HeaderText = "TTL";
            this.arecordTTL.Name = "arecordTTL";
            this.arecordTTL.ReadOnly = true;
            // 
            // dgv_mailExchanger
            // 
            this.dgv_mailExchanger.AllowUserToAddRows = false;
            this.dgv_mailExchanger.AllowUserToDeleteRows = false;
            this.dgv_mailExchanger.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_mailExchanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mailExchanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAddress,
            this.preference,
            this.mailExchanger,
            this.mxTTL});
            this.dgv_mailExchanger.Location = new System.Drawing.Point(12, 205);
            this.dgv_mailExchanger.Name = "dgv_mailExchanger";
            this.dgv_mailExchanger.ReadOnly = true;
            this.dgv_mailExchanger.RowHeadersVisible = false;
            this.dgv_mailExchanger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_mailExchanger.Size = new System.Drawing.Size(500, 85);
            this.dgv_mailExchanger.TabIndex = 6;
            // 
            // mailAddress
            // 
            this.mailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailAddress.FillWeight = 91.37056F;
            this.mailAddress.HeaderText = "Mail Address";
            this.mailAddress.Name = "mailAddress";
            this.mailAddress.ReadOnly = true;
            // 
            // preference
            // 
            this.preference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preference.FillWeight = 28.25817F;
            this.preference.HeaderText = "Preference";
            this.preference.Name = "preference";
            this.preference.ReadOnly = true;
            // 
            // mailExchanger
            // 
            this.mailExchanger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailExchanger.FillWeight = 180.3713F;
            this.mailExchanger.HeaderText = "Mail Exchanger";
            this.mailExchanger.Name = "mailExchanger";
            this.mailExchanger.ReadOnly = true;
            // 
            // mxTTL
            // 
            this.mxTTL.HeaderText = "TTL";
            this.mxTTL.Name = "mxTTL";
            this.mxTTL.ReadOnly = true;
            // 
            // dgv_nameServers
            // 
            this.dgv_nameServers.AllowUserToAddRows = false;
            this.dgv_nameServers.AllowUserToDeleteRows = false;
            this.dgv_nameServers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_nameServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nameServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.authoritativeNmeServer});
            this.dgv_nameServers.Location = new System.Drawing.Point(9, 413);
            this.dgv_nameServers.Name = "dgv_nameServers";
            this.dgv_nameServers.ReadOnly = true;
            this.dgv_nameServers.RowHeadersVisible = false;
            this.dgv_nameServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_nameServers.Size = new System.Drawing.Size(500, 85);
            this.dgv_nameServers.TabIndex = 8;
            // 
            // host
            // 
            this.host.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.host.FillWeight = 60.9137F;
            this.host.HeaderText = "Host";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            // 
            // authoritativeNmeServer
            // 
            this.authoritativeNmeServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authoritativeNmeServer.FillWeight = 139.0863F;
            this.authoritativeNmeServer.HeaderText = "Authoritative Name Server";
            this.authoritativeNmeServer.Name = "authoritativeNmeServer";
            this.authoritativeNmeServer.ReadOnly = true;
            // 
            // btn_query
            // 
            this.btn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_query.Location = new System.Drawing.Point(356, 509);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 3;
            this.btn_query.Text = "Query";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // lbl_atRecord
            // 
            this.lbl_atRecord.AutoSize = true;
            this.lbl_atRecord.Location = new System.Drawing.Point(12, 85);
            this.lbl_atRecord.Name = "lbl_atRecord";
            this.lbl_atRecord.Size = new System.Drawing.Size(97, 13);
            this.lbl_atRecord.TabIndex = 13;
            this.lbl_atRecord.Text = "@ Record Address";
            // 
            // lbl_mxRecord
            // 
            this.lbl_mxRecord.AutoSize = true;
            this.lbl_mxRecord.Location = new System.Drawing.Point(9, 189);
            this.lbl_mxRecord.Name = "lbl_mxRecord";
            this.lbl_mxRecord.Size = new System.Drawing.Size(66, 13);
            this.lbl_mxRecord.TabIndex = 14;
            this.lbl_mxRecord.Text = "MX Records";
            // 
            // lbl_nameServers
            // 
            this.lbl_nameServers.AutoSize = true;
            this.lbl_nameServers.Location = new System.Drawing.Point(9, 397);
            this.lbl_nameServers.Name = "lbl_nameServers";
            this.lbl_nameServers.Size = new System.Drawing.Size(74, 13);
            this.lbl_nameServers.TabIndex = 15;
            this.lbl_nameServers.Text = "Name Servers";
            // 
            // btn_quit
            // 
            this.btn_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quit.Location = new System.Drawing.Point(437, 509);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // cmb_nsToQuery
            // 
            this.cmb_nsToQuery.FormattingEnabled = true;
            this.cmb_nsToQuery.Items.AddRange(new object[] {
            "8.8.8.8",
            "8.8.4.4",
            "208.67.222.222",
            "208.67.220.220",
            "1.1.1.1",
            "9.9.9.9",
            "- - Enter DNS Server IP - -"});
            this.cmb_nsToQuery.Location = new System.Drawing.Point(155, 47);
            this.cmb_nsToQuery.Name = "cmb_nsToQuery";
            this.cmb_nsToQuery.Size = new System.Drawing.Size(174, 21);
            this.cmb_nsToQuery.TabIndex = 2;
            // 
            // lbl_txtRecords
            // 
            this.lbl_txtRecords.AutoSize = true;
            this.lbl_txtRecords.Location = new System.Drawing.Point(12, 293);
            this.lbl_txtRecords.Name = "lbl_txtRecords";
            this.lbl_txtRecords.Size = new System.Drawing.Size(71, 13);
            this.lbl_txtRecords.TabIndex = 16;
            this.lbl_txtRecords.Text = "TXT Records";
            // 
            // dgv_txtRecords
            // 
            this.dgv_txtRecords.AllowUserToAddRows = false;
            this.dgv_txtRecords.AllowUserToDeleteRows = false;
            this.dgv_txtRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_txtRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_txtRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDomain,
            this.txtRecord,
            this.txtTTL});
            this.dgv_txtRecords.Location = new System.Drawing.Point(12, 309);
            this.dgv_txtRecords.Name = "dgv_txtRecords";
            this.dgv_txtRecords.ReadOnly = true;
            this.dgv_txtRecords.RowHeadersVisible = false;
            this.dgv_txtRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_txtRecords.Size = new System.Drawing.Size(500, 85);
            this.dgv_txtRecords.TabIndex = 7;
            // 
            // txtDomain
            // 
            this.txtDomain.HeaderText = "Domain";
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            // 
            // txtRecord
            // 
            this.txtRecord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtRecord.HeaderText = "TXT Record";
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            // 
            // txtTTL
            // 
            this.txtTTL.HeaderText = "TTL";
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.ReadOnly = true;
            // 
            // frm_resolver
            // 
            this.AcceptButton = this.btn_query;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 539);
            this.Controls.Add(this.dgv_txtRecords);
            this.Controls.Add(this.lbl_txtRecords);
            this.Controls.Add(this.cmb_nsToQuery);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.lbl_nameServers);
            this.Controls.Add(this.lbl_mxRecord);
            this.Controls.Add(this.lbl_atRecord);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.dgv_nameServers);
            this.Controls.Add(this.dgv_mailExchanger);
            this.Controls.Add(this.dgv_address);
            this.Controls.Add(this.lbl_nsToQuery);
            this.Controls.Add(this.lbl_query);
            this.Controls.Add(this.txt_domainToQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_resolver";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "";
            this.Text = "dnsResolver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_resolver_Closing);
            this.Load += new System.EventHandler(this.frm_resolver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mailExchanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nameServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_txtRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_query;
        private System.Windows.Forms.Label lbl_nsToQuery;
        private System.Windows.Forms.DataGridView dgv_address;
        private System.Windows.Forms.DataGridView dgv_mailExchanger;
        private System.Windows.Forms.DataGridView dgv_nameServers;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoritativeNmeServer;
        private System.Windows.Forms.Label lbl_atRecord;
        private System.Windows.Forms.Label lbl_mxRecord;
        private System.Windows.Forms.Label lbl_nameServers;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.ComboBox cmb_nsToQuery;
        internal System.Windows.Forms.TextBox txt_domainToQuery;
        private System.Windows.Forms.Label lbl_txtRecords;
        private System.Windows.Forms.DataGridView dgv_txtRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn arecordTTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailExchanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn mxTTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTTL;
    }
}