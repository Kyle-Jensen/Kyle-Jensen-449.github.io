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
using produce_quantity.Objectssssss;

namespace produce_quantity
{
    public partial class groceryCategoryItems : Form
    {
        //Initialize new list to store items selected
        string items = "";
        List<string> vs = new List<string>();

        //Changes text of each title label based on the contents of
        //the category object
        Category _Category;
        public groceryCategoryItems(Category category)
        {   //depending on what category the user selects, this tells the forms labels to what it should display
            _Category = category;
            InitializeComponent();
            categoryName.Text = category._CategoryName;
            label1.Text = category._Items.ElementAtOrDefault(0)._Name;
            label2.Text = category._Items.ElementAtOrDefault(1)._Name;
            label3.Text = category._Items.ElementAtOrDefault(2)._Name;
            label4.Text = category._Items.ElementAtOrDefault(3)._Name;
            label5.Text = category._Items.ElementAtOrDefault(4)._Name;

           
        }
        //add to list event handler
        //creates a .txt file of what the user selected for grocery items
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                string nameOfCategory = "";

                nameOfCategory = _Category._CategoryName;
                //Depending on what category the user selects, this will specify the text file name
                outputFile = File.CreateText(_Category._CategoryName + ".txt");

                
                //if textbox1-5 is empty, the text file will not display all the items within the category
                if (!String.IsNullOrEmpty(textBox1.Text))
                {   //0 is referencing label1
                    outputFile.WriteLine(_Category._Items.ElementAtOrDefault(0)._Name + ": " + textBox1.Text);
                }
                if (!String.IsNullOrEmpty(textBox2.Text))
                {   //1 is referencing label2
                    outputFile.WriteLine(_Category._Items.ElementAtOrDefault(1)._Name + ": " + textBox2.Text);
                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {   //2 is referencing label3
                    outputFile.WriteLine(_Category._Items.ElementAtOrDefault(2)._Name + ": " + textBox3.Text);
                }
                if (!String.IsNullOrEmpty(textBox4.Text))
                {   //3 is referencing label4
                    outputFile.WriteLine(_Category._Items.ElementAtOrDefault(3)._Name + ": " + textBox4.Text);
                }
                if (!String.IsNullOrEmpty(textBox5.Text))
                {   //4 is referencing label5
                    outputFile.WriteLine(_Category._Items.ElementAtOrDefault(4)._Name + ": " + textBox5.Text);
                }

                outputFile.Close();




            }
            //for catch exception 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //opens groceryList
        private void button2_Click(object sender, EventArgs e)
        {
            groceryList f = new groceryList();
            f.Show();
            this.Hide();
        }
        //Empty Event handler
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //goes back to groceryCategories form
        private void backButton_Click(object sender, EventArgs e)
        {
            groceryCategories f = new groceryCategories();
            f.Show();
            this.Hide();
        }
        //loads data.txt by utilizing arrays, delimiters, and tokens
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("data.txt");

                string lines;

                while (!inputFile.EndOfStream)
                {   //, is the dlimiter for txt file
                    lines = inputFile.ReadLine();
                    string[] tokens = lines.Split(',');
                    //referencings iteminfo class for tokens
                    itemInfo items = new itemInfo(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);
                    vs.Add(items.Item + ";" + items.Nutrient + ";" + items.Store + ";" + items.Store1 + ";" + items.Store2 + ";" + items.Fact);

                    //https://stackoverflow.com/questions/4937060/how-to-check-if-listt-element-contains-an-item-with-a-particular-property-valu
                    // Check to see if item exists in our category before adding it to our itemListBox.Items list.
                    int index = _Category._Items.FindIndex(it => it._Name == items.Item);
                    if (index >= 0)
                    {
                        itemListBox.Items.Add(items.Item);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Event handler to adjust listbox based on what items are selected
        //When a user clicks on an item the information of the item is outputted
        //to form4 
        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            items = itemListBox.SelectedItem.ToString();
            itemInformation newForm = new itemInformation();

            Label label2 = new Label();
            label2.Size = new Size(500, 500);
            label2.Location = new Point(10, 10);
            label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            foreach (string str in vs)
            {
                if (str.Contains(items))
                {
                    string[] tokens = str.Split(';');
                    label2.Text += "Item: " + tokens[0] + "\n" +
                                    "Nutrient Information: " + tokens[1] + "\n" +
                                    "Stores that Carry: " + tokens[2] + ", "  + tokens[3] + ", " + tokens[4] + "\n" +
                                    "Random Fact: " + tokens[5];
                }
            }

            newForm.Controls.Add(label2);
            newForm.ShowDialog();
        }
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int d = 0;
        private int ee = 0;

        //The following up ArrowPictureBox event handlers increment an int
        //then converts the value into a string outputted to their respective textboxes

        //The downArrowPictureBox event handlers decrement an int
        //and converts the value into a string outputted to their respective textboxes
        //Negative numbers will be caught using an if statement

        private void upArrowPictureBox_Click(object sender, EventArgs e)
        {
            a++;
            textBox1.Text = a.ToString();
        }

        private void downArrowPictureBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = (--a).ToString();
            if (a < 0)
            {
                MessageBox.Show("You can't have negative items!");
            }
        }
        
        private void upArrow1PictureBox_Click(object sender, EventArgs e)
        {
            b++;
            textBox2.Text = b.ToString();
        }

        private void downArrow1PictureBox_Click(object sender, EventArgs e)
        {
            textBox2.Text = (--b).ToString();
            if (b < 0)
            {
                MessageBox.Show("You can't have negative items!");
            }
        }

        private void upArrow2PictureBox_Click(object sender, EventArgs e)
        {
            c++;
            textBox5.Text = c.ToString();
        }

        private void downArrow2PictureBox_Click(object sender, EventArgs e)
        {
            textBox5.Text = (--c).ToString();
            if (c < 0)
            {
                MessageBox.Show("You can't have negative items!");
            }
        }

        private void upArrow3PictureBox_Click(object sender, EventArgs e)
        {
            d++;
            textBox3.Text = d.ToString();
        }

        private void downArrow3PictureBox_Click(object sender, EventArgs e)
        {
            textBox3.Text = (--d).ToString();
            if (d < 0)
            {
                MessageBox.Show("You can't have negative items!");
            }
        }

        private void upArrow4PictureBox_Click(object sender, EventArgs e)
        {
            ee++;
            textBox4.Text = ee.ToString();
        }

        private void downArrow4PictureBox_Click(object sender, EventArgs e)
        {
            textBox4.Text = (--ee).ToString();
            if (ee < 0)
            {
                MessageBox.Show("You can't have negative items!");
            }
        }
    }
    
}
