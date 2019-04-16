using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace addressbook
{
    public partial class Form1 : Form
    {

        string selectedName = "";
        List<string> values = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("../../data.txt");

                string lines;

                while (!inputFile.EndOfStream)
                {
                    lines = inputFile.ReadLine();
                    string[] tokens = lines.Split(',');

                    PersonEntry person = new PersonEntry(tokens[0], tokens[1], tokens[2]);
                    values.Add(person.Name + ";" + person.Email + ";" + person.PhoneNum);
                    listBox1.Items.Add(person.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedName = listBox1.SelectedItem.ToString();
            Form2 newForm = new Form2();

            Label label2 = new Label();
            label2.Size = new Size(270, 75);
            label2.Location = new Point(10, 10);

            foreach (string str in values)
            {
                if (str.Contains(selectedName))
                {
                    string[] tokens = str.Split(';');
                    label2.Text += "Name: " + tokens[0] + "\n" +
                                   "Email: " + tokens[1] + "\n" +
                                   "Phone number: " + tokens[2];
                }
            }

            newForm.Controls.Add(label2);
            newForm.ShowDialog();
        }
    }
}
