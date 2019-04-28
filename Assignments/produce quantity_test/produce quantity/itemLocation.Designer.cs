namespace produce_quantity
{
    partial class itemLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label nutrient_InformationLabel;
            System.Windows.Forms.Label storesLabel;
            System.Windows.Forms.Label random_FactLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groceryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet = new produce_quantity.GroceryDBDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.random_FactTextBox = new System.Windows.Forms.TextBox();
            this.storesTextBox = new System.Windows.Forms.TextBox();
            this.nutrient_InformationTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.grocery_ItemsTableAdapter = new produce_quantity.GroceryDBDataSetTableAdapters.Grocery_ItemsTableAdapter();
            this.tableAdapterManager = new produce_quantity.GroceryDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            categoryLabel = new System.Windows.Forms.Label();
            nutrient_InformationLabel = new System.Windows.Forms.Label();
            storesLabel = new System.Windows.Forms.Label();
            random_FactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groceryItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(55, 61);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Category:";
            // 
            // nutrient_InformationLabel
            // 
            nutrient_InformationLabel.AutoSize = true;
            nutrient_InformationLabel.Location = new System.Drawing.Point(5, 101);
            nutrient_InformationLabel.Name = "nutrient_InformationLabel";
            nutrient_InformationLabel.Size = new System.Drawing.Size(102, 13);
            nutrient_InformationLabel.TabIndex = 2;
            nutrient_InformationLabel.Text = "Nutrient Information:";
            // 
            // storesLabel
            // 
            storesLabel.AutoSize = true;
            storesLabel.Location = new System.Drawing.Point(67, 134);
            storesLabel.Name = "storesLabel";
            storesLabel.Size = new System.Drawing.Size(40, 13);
            storesLabel.TabIndex = 4;
            storesLabel.Text = "Stores:";
            // 
            // random_FactLabel
            // 
            random_FactLabel.AutoSize = true;
            random_FactLabel.Location = new System.Drawing.Point(33, 169);
            random_FactLabel.Name = "random_FactLabel";
            random_FactLabel.Size = new System.Drawing.Size(74, 13);
            random_FactLabel.TabIndex = 6;
            random_FactLabel.Text = "Random Fact:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.groceryItemsBindingSource;
            this.listBox1.DisplayMember = "Grocery Item";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 0;
            // 
            // groceryItemsBindingSource
            // 
            this.groceryItemsBindingSource.DataMember = "Grocery_Items";
            this.groceryItemsBindingSource.DataSource = this.groceryDBDataSet;
            // 
            // groceryDBDataSet
            // 
            this.groceryDBDataSet.DataSetName = "GroceryDBDataSet";
            this.groceryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 293);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(random_FactLabel);
            this.panel1.Controls.Add(this.random_FactTextBox);
            this.panel1.Controls.Add(storesLabel);
            this.panel1.Controls.Add(this.storesTextBox);
            this.panel1.Controls.Add(nutrient_InformationLabel);
            this.panel1.Controls.Add(this.nutrient_InformationTextBox);
            this.panel1.Controls.Add(categoryLabel);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Location = new System.Drawing.Point(218, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 237);
            this.panel1.TabIndex = 15;
            // 
            // random_FactTextBox
            // 
            this.random_FactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groceryItemsBindingSource, "Random Fact", true));
            this.random_FactTextBox.Location = new System.Drawing.Point(113, 166);
            this.random_FactTextBox.Name = "random_FactTextBox";
            this.random_FactTextBox.Size = new System.Drawing.Size(429, 20);
            this.random_FactTextBox.TabIndex = 7;
            // 
            // storesTextBox
            // 
            this.storesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groceryItemsBindingSource, "Stores", true));
            this.storesTextBox.Location = new System.Drawing.Point(113, 131);
            this.storesTextBox.Name = "storesTextBox";
            this.storesTextBox.Size = new System.Drawing.Size(429, 20);
            this.storesTextBox.TabIndex = 5;
            // 
            // nutrient_InformationTextBox
            // 
            this.nutrient_InformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groceryItemsBindingSource, "Nutrient Information", true));
            this.nutrient_InformationTextBox.Location = new System.Drawing.Point(113, 98);
            this.nutrient_InformationTextBox.Name = "nutrient_InformationTextBox";
            this.nutrient_InformationTextBox.Size = new System.Drawing.Size(429, 20);
            this.nutrient_InformationTextBox.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groceryItemsBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(113, 61);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(429, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // grocery_ItemsTableAdapter
            // 
            this.grocery_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Grocery_ItemsTableAdapter = this.grocery_ItemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = produce_quantity.GroceryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select a grocery Item to read more about it!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Location";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groceryItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private GroceryDBDataSet groceryDBDataSet;
        private System.Windows.Forms.BindingSource groceryItemsBindingSource;
        private GroceryDBDataSetTableAdapters.Grocery_ItemsTableAdapter grocery_ItemsTableAdapter;
        private System.Windows.Forms.TextBox random_FactTextBox;
        private System.Windows.Forms.TextBox storesTextBox;
        private System.Windows.Forms.TextBox nutrient_InformationTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private GroceryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}