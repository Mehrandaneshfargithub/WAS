using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connection_refresh_Click(object sender, EventArgs e)
        {
            connection_string.Text = generated_string.Text = "";
            txtDbName.Text = "";
            txtDbSource.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            connection_error.Visible = connection_success.Visible = false;
            lblCopy.Visible = false;
        }

        private void licence_refresh_Click(object sender, EventArgs e)
        {
            licence_key.Text = serial.Text = "";
            licence_error.Visible = licence_success.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expire_date.Value = DateTime.Now;
        }

        private void connection_create_Click(object sender, EventArgs e)
        {
            try
            {
                connection_error.Visible = connection_success.Visible = false;
                string txt_connection = connection_string.Text;

                if (string.IsNullOrWhiteSpace(txt_connection))
                {
                    connection_error.Text = "connection string is empty";
                    connection_error.Visible = true;
                    return;
                }
                txtDbName.Text = GetDbNameFromconnectionString();
                txtDbSource.Text = GetDataSourceFromconnectionString();
                txtUsername.Text = GetUserIdFromconnectionString();
                txtPassword.Text = GetPasswordFromconnectionString();
                generated_string.Text = EncryptConnectionString.GetEncryptString(txt_connection);

                connection_success.Text = "connection string encrypted successfully";
                connection_success.Visible = true;
            }
            catch (Exception ex)
            {
                connection_error.Text = ex.ToString();
                connection_error.Visible = true;
            }
        }
        public string GetDbNameFromconnectionString()
        {
            string[] separators = { ";", "=" };
            string connectionString = connection_string.Text;
            string[] conList = connectionString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var kv = conList.Select((element, index) => new KeyValuePair<string, int>(element.Replace(" ", "").ToLower(), index+1));
            int pos = kv.FirstOrDefault(x => x.Key.Equals("initialcatalog")).Value;//Array.IndexOf(conList, "InitialCatalog");
            if (pos == 0)
            {
                pos = kv.FirstOrDefault(x => x.Key.Equals("database")).Value; //Array.IndexOf(conList, "Database");
            }
            string dbName = conList[pos];
            return dbName;
        }

        public string GetDataSourceFromconnectionString()
        {
            string[] separators = { ";", "=" };
            string connectionString = connection_string.Text;
            string[] conList = connectionString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var kv = conList.Select((element, index) => new KeyValuePair<string, int>(element.Replace(" ", "").ToLower(), index+1));
            int pos = kv.FirstOrDefault(x => x.Key.Equals("datasource")).Value;
            if (pos == 0)
            {
                pos = kv.FirstOrDefault(x => x.Key.Equals("server")).Value;
            }
            string dbSource = conList[pos];
            return dbSource;
        }
        public string GetUserIdFromconnectionString()
        {
            string[] separators = { ";", "=" };
            string connectionString = connection_string.Text;
            string[] conList = connectionString.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            var kv = conList.Select((element, index) => new KeyValuePair<string, int>(element.Replace(" ", "").ToLower(), index + 1));
            var pos = kv.FirstOrDefault(x => x.Key.Equals("userid")).Value;
            string UserId = "";
            if (pos == 0)
                UserId = "";
            UserId = conList[pos];
            return UserId;
        }
        public string GetPasswordFromconnectionString()
        {
            string[] separators = { ";", "=" };
            string connectionString = connection_string.Text;
            string[] conList = connectionString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var kv = conList.Select((element, index) => new KeyValuePair<string, int>(element.Replace(" ", "").ToLower(), index + 1));
            var pos = kv.FirstOrDefault(x => x.Key.Equals("password")).Value;
            string password = "";
            if (pos == 0)
                password = "";
            password = conList[pos];
            return password;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultures = new CultureInfo("en-US");
                licence_error.Visible = licence_success.Visible = false;
                string txt_serial = serial.Text;
                string date = expire_date.Value.ToString("dd/MM/yyyy", cultures).Replace("/", "");

                if (string.IsNullOrWhiteSpace(txt_serial))
                {
                    licence_error.Text = "serial is empty";
                    licence_error.Visible = true;
                    return;
                }

                licence_key.Text = GenerateSerialKey.GetSerialKey(txt_serial, date);

                licence_success.Text = "licence key generated successfully";
                licence_success.Visible = true;
            }
            catch (Exception ex)
            {
                licence_error.Text = ex.ToString();
                licence_error.Visible = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generated_string.Text);
            lblCopy.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDbSource.Text) || String.IsNullOrEmpty(txtDbName.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Complete All Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connection_string.Text = $"Data Source={txtDbSource.Text};Initial Catalog={txtDbName.Text};User ID={txtUsername.Text};Password={txtPassword.Text};Persist Security Info=True;";
            generated_string.Text = EncryptConnectionString.GetEncryptString(connection_string.Text);

            connection_success.Text = "connection string encrypted successfully";
            connection_success.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(generated_string.Text))
            {
                MessageBox.Show("Please Insert Generated Key", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var key = "B9SupmNM1gV/0nyli1qS3o5akkzFhO+CoqByEb0yU9A=";
            var IVBase64 = "dCsOgZ3hl3pe7RlRrH6Aig==";
            connection_string.Text = GenerateSerialKey.Decrypt(generated_string.Text, IVBase64, key);
            txtDbName.Text = GetDbNameFromconnectionString();
            txtDbSource.Text = GetDataSourceFromconnectionString();
            txtUsername.Text = GetUserIdFromconnectionString();
            txtPassword.Text = GetPasswordFromconnectionString();
            generated_string.Text = EncryptConnectionString.GetEncryptString(connection_string.Text);

            connection_success.Text = "connection string encrypted successfully";
            connection_success.Visible = true;
        }
    }
}
