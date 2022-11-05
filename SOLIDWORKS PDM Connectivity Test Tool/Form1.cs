using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SOLIDWORKS_PDM_Connectivity_Test_Tool
{
    public partial class Form : Form
    {
        private string MachineName;
        private string IPAdress;
        private string UserName;
        private string DomainName;

        public Form()
        {
            InitializeComponent();

            Data();
        }

        private void Data()
        {
            MachineName = Environment.MachineName;
            IPAdress = GetLocalIPAddress();
            UserName = Environment.UserName;
            DomainName = Environment.UserDomainName;

            #region Lables
            MachineNameLabel.Text = MachineName;
            IPLabel.Text = IPAdress;
            DomainNameLabel.Text = DomainName;
            UserNameLabel.Text = UserName;
            #endregion
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public bool CheckPort(string name, int port)
        {

            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(name, port);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Ping(string name)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply;
                PingOptions options = new PingOptions();
                options.DontFragment = true;

                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                reply = myPing.Send(name, 5000, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ping", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string ip;
            int port, daemon;

            if (ArchiveServerCheckBox.Checked)
            {
                ip = ArchiveServerHostTextBox.Text;

                Int32.TryParse(ArchiveServerPortTextBox.Text, out port);


                if (!Ping(ip))
                {
                    return;
                }
                if (!CheckPort(ip, port))
                {
                    MessageBox.Show("Port is closed!", "Archive Server", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Connection to Archive Server is Ok!", "Connection to Archive Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (DataBaseCheckBox.Checked)
            {
                ip = DataBaseHostTextBox.Text;

                Int32.TryParse(DataBasePortTextBox.Text, out port);

                if (!Ping(ip))
                {
                    return;
                }
                if (!CheckPort(ip, port))
                {
                    MessageBox.Show("Port is closed!", "DataBase Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Connection to DataBase server is Ok!", "Connection to DataBase server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (LicenseServerCheckBox.Checked)
            {
                ip = LicenseServerHostTextBox.Text;

                Int32.TryParse(LicenseServerPortTextBox.Text, out port);
                Int32.TryParse(LicenseServerDaemonTextBox.Text, out daemon);

                if (!Ping(ip))
                {
                    return;
                }
                if (!CheckPort(ip, port))
                {
                    MessageBox.Show("Port " + port + " is closed!", "SolidNetWork License Manager Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!CheckPort(ip, daemon))
                {
                    MessageBox.Show("Port " + daemon + " is closed!", "SolidNetWork License Manager Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Connection to SolidNetWork License Manager Server server is Ok!", "Connection to SolidNetWork License Manager Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Process.Start("http://itsapr.com/");
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
    }
}
