using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Threading;


namespace SpDeploy
{
    public partial class MainForm : Form
    {
        static string server, database; // , procedure;
        static List<string> procedures = new List<string>();
        static StringBuilder SPSQL = new StringBuilder();
        static string[] servers = { "DEV-IFSQL", "TST-SQL", "NAVDB" };

        public MainForm()
        {
            InitializeComponent();
            ServerList.Items.AddRange(servers);
        }

        private void ServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            server = ServerList.Text;
            procedures.Clear();
            SPSQL.Clear();
            SPTextBox.Text = string.Empty;
            AllProceduresCheckbox.Checked = false;

            if (!string.IsNullOrEmpty(server))
            {
                DatabaseList.Enabled = ServerList.SelectedIndex != -1;
                DatabaseList.Text = string.Empty;
                DatabaseList.Items.Clear();

                // Setup database list.                
                var connectionString = @"Server=" + server + ";Initial Catalog=master;Integrated Security=SSPI";

                using (var conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        var sql = @"";

                        using (var cmd = new SqlCommand("SELECT name FROM master..sysdatabases WHERE name LIKE '%_App'", conn))
                        {
                            using (var result = cmd.ExecuteReader())
                            {
                                if (result.HasRows)
                                {
                                    while (result.Read())
                                    {
                                        DatabaseList.Items.Add(result["name"]);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                        this.Cursor = Cursors.Default;
                    }
                }

                DatabaseList.Focus();
            }
        }

        private void DatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            database = DatabaseList.Text;
            SPList.Enabled = DatabaseList.SelectedIndex != -1;
            AllProceduresCheckbox.Enabled = SPList.Enabled;
            AllProceduresCheckbox.Checked = false;
            SPList.Text = string.Empty;
            SPList.Items.Clear();
            procedures.Clear();
            SPSQL.Clear();
            SPTextBox.Text = string.Empty;

            if (string.IsNullOrEmpty(database))
            {
                return;
            }

            var connectionString = string.Format(@"Server={0};Initial Catalog={1};Integrated Security=SSPI", server, database);

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    var sql = @"
                        SELECT ROUTINE_NAME, ROUTINE_DEFINITION
                        FROM information_schema.routines 
                        WHERE routine_type = 'PROCEDURE' AND ROUTINE_NAME LIKE 'fe_%'
                        ORDER BY ROUTINE_NAME ASC;";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var result = cmd.ExecuteReader())
                        {
                            if (result.HasRows)
                            {
                                while (result.Read())
                                {
                                    SPList.Items.Add(result["ROUTINE_NAME"]);
                                }
                            }

                            result.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                    this.Cursor = Cursors.Default;
                }
            }

            SPList.Focus();
        }

        StringBuilder BuildSPSQL()
        {
            SPSQL.Clear();
            var connectionString = string.Format(@"Server={0};Initial Catalog={1};Integrated Security=SSPI", server, database);

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (var procedure in procedures)
                    {
                        var sql = string.Format(@"EXEC SP_HELPTEXT [{0}]", procedure);

                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            using (var result = cmd.ExecuteReader())
                            {
                                if (result.HasRows)
                                {
                                    var spTextBuilder = new StringBuilder();

                                    while (result.Read())
                                    {
                                        spTextBuilder.Append(result["Text"].ToString());
                                    }

                                    var spText = spTextBuilder.ToString();
                                    spText = spText.Replace("USE [", "-- USE [");
                                    spText = spText.Replace("ALTER PROCEDURE", "CREATE PROCEDURE");

                                    spText = string.Format(@"
-- *** {0} ***
-- DROP PROCEDURE [dbo].[{0}]
{1}
", procedure, spText);
                                    SPSQL.Append(spText);
                                    spTextBuilder.Clear();
                                }

                                result.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return SPSQL;
                }
                finally
                {
                    conn.Close();
                    this.Cursor = Cursors.Default;
                }
            }

            return SPSQL;
        }

        private void SPList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            procedures.Clear();
            procedures.Add(SPList.Text);
            var cond = SPList.SelectedIndex != -1;
            EnvironmentsGroup.Enabled = cond;
            SitesGroup.Enabled = cond;
            BrowseButton.Enabled = cond;
            DeployButton.Enabled = cond;
            SPTextBox.Enabled = cond;
            SPSQL = BuildSPSQL();
            SPTextBox.Text = SPSQL.ToString();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = LocationTextBox.Text;
                dialog.Filter = "SQL Script|.sql";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LocationTextBox.Enabled = true;
                    LocationTextBox.Text = dialog.FileName;
                }
            }
        }

        private void LocationTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateScriptsButton.Enabled = LocationTextBox.TextLength > 0;
        }

        private void SPList_Enter(object sender, EventArgs e)
        {
        }

        void CheckAll(GroupBox group, string tag, bool state)
        {
            foreach (var control in group.Controls)
            {
                if (control is CheckBox)
                {
                    var checkbox = (CheckBox)control;

                    if (checkbox.Tag != null && checkbox.Tag == tag)
                    {
                        checkbox.Checked = state;
                        checkbox.Enabled = !state;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(EnvironmentsGroup, "Environment", AllEnvironmentsCheckbox.Checked);
        }

        private void AllSitesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll(SitesGroup, "Site", AllSitesCheckbox.Checked);
        }

        string[] GetSites()
        {
            var sites = new List<String>();

            foreach (var control in SitesGroup.Controls)
            {
                if (control is CheckBox)
                {
                    var checkbox = (CheckBox)control;

                    if (checkbox.Checked && checkbox.Tag != null && checkbox.Tag == "Site")
                    {
                        sites.Add(checkbox.Text);
                    }
                }
            }

            return sites.ToArray<string>();
        }

        string[] GetEnvironments()
        {
            var environments = new List<String>();

            foreach (var control in EnvironmentsGroup.Controls)
            {
                if (control is CheckBox)
                {
                    var checkbox = (CheckBox)control;

                    if (checkbox.Checked && checkbox.Tag != null && checkbox.Tag == "Environment")
                    {
                        environments.Add(checkbox.Text);
                    }
                }
            }

            return environments.ToArray<string>();
        }


        private void GenerateScriptsButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                File.WriteAllText(LocationTextBox.Text, SPSQL.ToString());
                DeployButton.Enabled = true;
            }
            catch (Exception ex)
            {
                DeployButton.Enabled = false;
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show("Script written successfully.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var cond = AllProceduresCheckbox.Checked;
            SPTextBox.Enabled = cond;
            SPTextBox.Text = "Generating script...";
            SPTextBox.Refresh();
            SPList.Text = string.Empty;
            SPList.Enabled = !cond;
            EnvironmentsGroup.Enabled = cond;
            SitesGroup.Enabled = cond;
            BrowseButton.Enabled = cond;

            if (!AllProceduresCheckbox.Checked)
            {
                SPSQL.Clear();
                procedures.Clear();
                SPTextBox.Enabled = false;
                SPTextBox.Text = string.Empty;
                this.Cursor = Cursors.Default;
                return;
            }

            var connectionString = @"Server=" + server + ";Initial Catalog=" + database + ";Integrated Security=SSPI";
            procedures.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = @"
                            SELECT ROUTINE_NAME, ROUTINE_DEFINITION
                            FROM information_schema.routines 
                            WHERE routine_type = 'PROCEDURE' AND ROUTINE_NAME LIKE 'fe_%'
                            ORDER BY ROUTINE_NAME ASC;";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var result = cmd.ExecuteReader())
                        {
                            if (result.HasRows)
                            {
                                while (result.Read())
                                {
                                    procedures.Add(result["ROUTINE_NAME"].ToString());
                                }
                            }

                            result.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            SPSQL = BuildSPSQL();
            SPTextBox.Text = SPSQL.ToString();
            this.Cursor = Cursors.Default;
        }

        private void Deploy(string server, string database, string SQL)
        {
            using (var conn = new SqlConnection(string.Format("Server={0};Initial Catalog={1};Integrated Security=SSPI", server, database)))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(SQL, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    SPTextBox.Text += "\r\nDeployment failed: " + ex.Message;
                    SPTextBox.Tag = "error";
                    // MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void DeployButton_Click(object sender, EventArgs e)
        {
            var servers = new Dictionary<string, string>()
            {
                {"Development", "dev-ifsql"},
                {"Testing", "tst-sql"},
                {"Pilot", "tst-sql"},
                {"Production", "inbasqlclus001"}
            };

            SPTextBox.Text = "Preparing to deploy...";
            SPTextBox.Text += "\r\nDeploying to:\r\n";

            foreach (var environment in GetEnvironments())
            {
                foreach (var site in GetSites())
                {
                    var server = servers[environment];
                    SPTextBox.Text += "\r\n" + environment + " (" + server + ") " + site;
                    Deploy(server, site + "_App", SPSQL.ToString());
                    SPTextBox.SelectionStart = SPTextBox.TextLength;
                    SPTextBox.ScrollToCaret();
                    SPTextBox.Refresh();
                }
            }

            if (SPTextBox.Tag != null && string.IsNullOrEmpty(SPTextBox.Tag.ToString()))
            {
                SPTextBox.Text += "\r\nDeployment successful";
            }

            SPTextBox.Text += "\r\nDeployment complete.";
            SPTextBox.Tag = string.Empty;
        }
    }
}
