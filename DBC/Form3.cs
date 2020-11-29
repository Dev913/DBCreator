using DBC.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace DBC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peopleToolStripMenuItem.DropDownItems.Count < 1)
            {
                MessageBox.Show("You have to create a file of a person before clicking on this. If you have please refresh.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void refreshPeopleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Width = 380;
            richTextBox1.Height = 118;
            MessageBox.Show("Make sure to select a person before using the screenshot function.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Vehicle_registration_plate#:~:text=A%20vehicle%20registration%20plate%2C%20also,trailer%20for%20official%20identification%20purposes.&text=There%20are%20also%20electronic%20license%20plates.");
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void textBox6_DoubleClick(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
        }

        private void textBox7_DoubleClick(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
        }

        private void textBox8_DoubleClick(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
        }

        private void textBox10_DoubleClick(object sender, EventArgs e)
        {
            textBox10.Enabled = false;
        }

        private void textBox9_DoubleClick(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Width = 380;
            richTextBox1.Height = 92;
            dateTimePicker1.Visible = true;
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(Width, Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            var empty = System.Drawing.Point.Empty;
            g.CopyFromScreen(new System.Drawing.Point(Bounds.Left, Bounds.Top), empty, Bounds.Size);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image (*.PNG) | *.png";
            saveFileDialog.ShowDialog();
            bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
        }

        private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dateTimePicker1.Visible = false;
        }
    }
}
