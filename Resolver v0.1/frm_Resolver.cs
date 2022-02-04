using DnsClient;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

/*
 * Built using DnsClient.NET by Michael Conrad
 * http://dnsclient.michaco.net/
 */

namespace dnsResolver
{
    public partial class frm_resolver : Form
    {
        private void frm_resolver_Load(object sender, EventArgs e)
        {
            this.WindowState = Properties.Settings.Default.F1State;
            this.Location = Properties.Settings.Default.F1Location;
            cmb_nsToQuery.SelectedIndex = 0;
        }

        public frm_resolver()
        {
            InitializeComponent();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            var domainToQuery = txt_domainToQuery.Text;
            var nsToQuery = cmb_nsToQuery.Text;

            // make sure all fields are filled out properly

            Regex domainPattern = new Regex("(?:\\/\\/|[A-Za-z0-9][A-Za-z0-9\\-]{0,61}[A-Za-z0-9]|[A-Za-z0-9])");
            Regex dnsServerPattern = new Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");

            if (string.IsNullOrEmpty(domainToQuery) || !domainPattern.IsMatch(domainToQuery))
            {
                txt_domainToQuery.SelectAll();
                MessageBox.Show("Enter a valid Domain");
            }

            else if (string.IsNullOrEmpty(nsToQuery) || !dnsServerPattern.IsMatch(nsToQuery))
            {
                MessageBox.Show("Enter a valid DNS Server");
            }

            else
            {
                // Ping the DNS server
                Ping x = new Ping();
                PingReply reply = x.Send(IPAddress.Parse(nsToQuery));
                TcpClient tcP = new System.Net.Sockets.TcpClient();

                if (reply.Status == IPStatus.TimedOut)
                {
                    cmb_nsToQuery.SelectAll();
                    MessageBox.Show("The requested name server " + nsToQuery + "timed out");
                }

                else
                {
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        try
                        {
                            tcpClient.Connect(nsToQuery, 53);

                            {
                                dgv_nameServers.Rows.Clear();
                                dgv_nameServers.Refresh();

                                dgv_mailExchanger.Rows.Clear();
                                dgv_mailExchanger.Refresh();

                                dgv_txtRecords.Rows.Clear();
                                dgv_txtRecords.Refresh();

                                dgv_address.Rows.Clear();
                                dgv_address.Refresh();

                                var endpoint = new IPEndPoint(IPAddress.Parse(nsToQuery), 53);
                                var client = new LookupClient(endpoint);

                                foreach (var aRecord in client.Query(domainToQuery, QueryType.A).Answers.ARecords())
                                {
                                    // A Records
                                    // MessageBox.Show(aRecord.TimeToLive.ToString());
                                    this.dgv_address.Rows.Add(new object[] { domainToQuery, aRecord.Address.ToString(), aRecord.TimeToLive });
                                }

                                foreach (var mxRecords in client.Query(domainToQuery, QueryType.MX).Answers.MxRecords())
                                {
                                    // MX Record
                                    // MessageBox.Show(mxRecords.ToString());
                                    string originalMXServer = mxRecords.Exchange;
                                    string dotlessMXServer = originalMXServer.TrimEnd('.');
                                    this.dgv_mailExchanger.Rows.Add(new object[] { domainToQuery, mxRecords.Preference, dotlessMXServer, mxRecords.TimeToLive });
                                }

                                foreach (var txtRecords in client.Query(domainToQuery, QueryType.TXT).Answers.TxtRecords())
                                {
                                    // MessageBox.Show(txtRecords.ToString());
                                    string originalTxtRecordDomain = txtRecords.DomainName.ToString();
                                    string dotlessTxtRecordDomain = originalTxtRecordDomain.TrimEnd('.');

                                    string completeTxtRecord = txtRecords.ToString();
                                    string[] txtRecordArray = completeTxtRecord.Split('"');

                                    this.dgv_txtRecords.Rows.Add(new object[] { dotlessTxtRecordDomain, txtRecordArray[1],txtRecords.TimeToLive });
                                }

                                foreach (var nameServers in client.Query(domainToQuery, QueryType.NS).Answers.NsRecords())
                                {
                                    // MessageBox.Show(nameServers.NSDName.ToString());
                                    string originalNameServer = nameServers.NSDName.ToString();
                                    string dotlessNameServer = originalNameServer.TrimEnd('.');
                                    this.dgv_nameServers.Rows.Add(new object[] { domainToQuery, dotlessNameServer });
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("The IP " + nsToQuery + " seems not to be a DNS server" + "\n" + "Please check the IP and try again.");
                        }
                    }
                }
                
            }
        }

        private void frm_resolver_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.F1State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // Save location and size if the state is normal
                Properties.Settings.Default.F1Location = this.Location;
            }
            else
            {
                // Save the RestoreBounds if the form is minimized or maximized
                Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
            }

            // Save the settings
            Properties.Settings.Default.Save();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}