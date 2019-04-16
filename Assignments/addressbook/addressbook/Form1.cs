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
        //declaring variables and list
        string person = "";
        List<string> vs = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }
        //form loads the data text file and displays text through a listbox
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
                    string[] tokens = lines.Split(','); //lines breaks for comma
                    
                    PersonEntry person = new PersonEntry(tokens[0], tokens[1], tokens[2]);
                    vs.Add(person.Name + ";" + person.Email + ";" + person.Phone);
                    listBox1.Items.Add(person.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //for form2 output, displays selected persons details by arrays and tokens
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            person = listBox1.SelectedItem.ToString();
            Form2 newForm = new Form2();

            Label label2 = new Label();
            label2.Size = new Size(270, 75);
            label2.Location = new Point(10, 10);

            foreach (string str in vs)
            {
                if (str.Contains(person))
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
