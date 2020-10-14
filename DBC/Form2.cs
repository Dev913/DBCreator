using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DBC.Properties;
using SharpYaml.Serialization;

namespace DBC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("African american");
            comboBox1.Items.Add("Caucasian/White person");
            comboBox1.Items.Add("Americans");
            comboBox1.Items.Add("Native americans of U.S.");
            comboBox1.Items.Add("Asian people");
            comboBox1.Items.Add("Alaska natives");
            comboBox1.Items.Add("Hispanic/Latino americans");
            comboBox1.Items.Add("Pacific islander");
            comboBox1.Items.Add("Black people");
            comboBox1.Items.Add("Native hawaiians");
            comboBox1.Items.Add("Pacific islander americans");
            comboBox1.Items.Add("Non-hispanic whites");
            comboBox1.Items.Add("Purerto ricans");
            comboBox1.Items.Add("Multi-racial people");
            comboBox1.Items.Add("Jewish people");
            comboBox1.Items.Add("Asian americans");
            comboBox1.Items.Add("Mexicans");
            comboBox1.Items.Add("Hispanic");
            comboBox1.Items.Add("Romzni people");
            comboBox1.Items.Add("Han chinese");
            comboBox1.Items.Add("Black hispanic and latino americans");
            comboBox1.Items.Add("White hispanic and latino americnas");
            comboBox1.Items.Add("Indigenous peoples of americas");
            comboBox1.Items.Add("Kurds");
            comboBox1.Items.Add("Irish people");
            comboBox1.Items.Add("Koreans");
            comboBox1.Items.Add("Arabs");
            comboBox1.Items.Add("Uyghurs");
            comboBox1.Items.Add("Arabs");
            comboBox1.Items.Add("Spaniards");
            comboBox1.Items.Add("Multiracial americans");
            comboBox1.Items.Add("Assyrian people");
            comboBox1.Items.Add("White americans");
            comboBox1.Items.Add("Irish travellers");
            comboBox1.Items.Add("Hmong people");
            comboBox1.Items.Add("French canadians");
            comboBox1.Items.Add("Tatars");
            comboBox1.Items.Add("Ashkenazi jews");
            comboBox1.Items.Add("White british");
            comboBox1.Items.Add("Greeks");
            comboBox1.Items.Add("Berbers");
            comboBox1.Items.Add("Mexican americans");
            comboBox1.Items.Add("Turkic peoples");
            comboBox1.Items.Add("Russian");
            comboBox1.Items.Add("Ukrainians");
            comboBox1.Items.Add("Austrians");
            comboBox1.Items.Add("Iroquois");
            comboBox1.Items.Add("Norwegians");
            comboBox1.Items.Add("Mestizo");
            comboBox1.Items.Add("People of the dominican republic");
            comboBox1.Items.Add("Kazakhs");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox4.Text =  colorDialog1.Color.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Photo of target";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string BirthPlace = textBox2.Text;
            string FulleName = textBox1.Text;
            string Ethnicity = textBox3.Text;
            string HairColor = textBox6.Text;
            string EyeColor = textBox4.Text;
            string Height = textBox5.Text;
            string BodyType = textBox7.Text;
            string Weight = textBox8.Text;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\one") == false)
            {
                Settings.Default.one = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\one");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\two") == false && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.two = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\two");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\three") == false && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.three = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\three");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\four") == false && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.four = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\four");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\five") == false && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.five = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\five");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\six") == false && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.six = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\six");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\seven") == false && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.seven = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\seven");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\eight") == false && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.eight = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\eight");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\nine") == false && File.Exists(Directory.GetCurrentDirectory() + "\\eight") && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.nine = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\nine");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\ten") == false && File.Exists(Directory.GetCurrentDirectory() + "\\nine") && File.Exists(Directory.GetCurrentDirectory() + "\\eight") && File.Exists(Directory.GetCurrentDirectory() + "\\seven") && File.Exists(Directory.GetCurrentDirectory() + "\\six") && File.Exists(Directory.GetCurrentDirectory() + "\\five") && File.Exists(Directory.GetCurrentDirectory() + "\\four") && File.Exists(Directory.GetCurrentDirectory() + "\\three") && File.Exists(Directory.GetCurrentDirectory() + "\\two") && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                Settings.Default.ten = textBox1.Text;
                Settings.Default.Save();
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\ten");
                file.Write(BirthPlace + Environment.NewLine + FulleName.ToString() + Environment.NewLine + Ethnicity.ToString() + Environment.NewLine + HairColor.ToString() + Environment.NewLine + EyeColor.ToString() + Environment.NewLine + Height.ToString() + Environment.NewLine + BodyType.ToString() + Environment.NewLine + Weight.ToString());
                file.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox6.Text = colorDialog1.Color.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = "Birth Place = " + textBox2.Text + Environment.NewLine + "Full Nmae = " + textBox1.Text + Environment.NewLine + "Ethnicity = " + textBox3.Text + Environment.NewLine + "Hair Color = " + textBox6.Text + Environment.NewLine + "Eye Color = " + textBox4.Text + Environment.NewLine + "Height = " + textBox5.Text + Environment.NewLine + "Body Type = " + textBox7.Text + Environment.NewLine + "Weight = " + textBox8.Text;
        }
    }
}
