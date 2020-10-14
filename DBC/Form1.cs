using DBC.Properties;
using System;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peopleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void refreshDBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult diagres = MessageBox.Show("Do you have to refresh? Refreshing when you already have, can cause confusion as well as bugs.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diagres == DialogResult.Yes)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.one).Click += one_Click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\two"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.two).Click += two_click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\three"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += three_click;
                    }
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\four"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += four_click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\five"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += five_click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\six"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += six_click;
                    }
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\seven"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += seven_click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\eight") && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\eight"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += eight_click;
                    }
                }
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\nine") && File.Exists(Directory.GetCurrentDirectory() + "\\eight") && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\nine"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.three).Click += nine_click;
                    }
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\ten") && File.Exists(Directory.GetCurrentDirectory() + "\\nine") && File.Exists(Directory.GetCurrentDirectory() + "\\eight") && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    MessageBox.Show("You have reached 10 people. The limit of people you can have is 10.");
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten");
                    Settings.Default.Reload();
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\ten"))
                    {
                        peopleToolStripMenuItem.DropDownItems.Add(Settings.Default.nine).Click += ten_click;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void two_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void three_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void four_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void five_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void six_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void seven_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void eight_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void nine_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void ten_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create a '" + label3.Text + "' folder.";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option will reset the settings. It will not delete the old number files. Do that manually.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Settings.Default.Reset();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peopleToolStripMenuItem.DropDownItems.Count < 1)
            {
                MessageBox.Show("You have to create a file of a person before clicking on this. If you have please refresh.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + label3.Text);
            DialogResult res = MessageBox.Show("Do you wish for a file to be put inside the folder? If not you will have to do it manually.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\one");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "Information on POI");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "Information on POI", text);
                }
            }
            else return;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section will be available soon.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            string version = webClient.DownloadString("https://www.dbcreator.info/dbc/version.html");
            if (version == ProductVersion.ToString())
            {
                MessageBox.Show("There are no updates at this time.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult isUserWantingUpdate = MessageBox.Show("There are updates. Do you want to go to the downloads wepage?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isUserWantingUpdate == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.dbcreator.info");
                }
                else
                {
                    return;
                }
            }
        }
    }
}