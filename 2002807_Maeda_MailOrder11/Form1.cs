using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _2002807_Maeda_MailOrder11
{
    public partial class Form1 : Form
    {
        public bool isChange = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //saves contents to a file
            StreamWriter catalogStreamWriter = new StreamWriter("Catalogs.txt");
            int indexInteger, maximumInteger;

            maximumInteger = catalogList.Items.Count;
            for (indexInteger = 0; indexInteger < maximumInteger; indexInteger++)
            {
                catalogStreamWriter.WriteLine(catalogList.Items[indexInteger]);
            }
            catalogStreamWriter.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clears combo box
            DialogResult confirmDialogResult = MessageBox.Show("Remove all catalogs?",
"Clear Catalog List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDialogResult == DialogResult.Yes)
            {
                catalogList.Items.Clear();
                catalogList.Text = null;
                isChange = true;
            }

        }

        private void catalogAmount_Click(object sender, EventArgs e)
        {
           //displays amount of catalogs
           MessageBox.Show("Catalog Count: " +
           catalogList.Items.Count.ToString(),
           "Mail Order", MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void deleteCatalog_Click(object sender, EventArgs e)
        {
            if (catalogList.SelectedIndex != -1)
            {
                //remove selected catalog
                catalogList.Items.RemoveAt(catalogList.SelectedIndex);
                isChange = true;

            }
            else
            {
                //if no catalog selected
                MessageBox.Show("Select a catalog to remove.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void addCatalog_Click(object sender, EventArgs e)
        {
            //adds new catalog
            int indexInteger = 0;
            bool itemFoundBoolean = false;
            //Checks for duplicates
            if (catalogList.Text != string.Empty)
            {
                while (indexInteger < catalogList.Items.Count &&
                !itemFoundBoolean)
                {
                    if (catalogList.Items[indexInteger++].ToString().ToUpper()
                    == catalogList.Text.ToUpper())
                    {
                        MessageBox.Show("Duplicate catalog.", "Catalog Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemFoundBoolean = true;
                    }
                }
                if (!itemFoundBoolean)
                {
                    // Adds to list.
                    catalogList.Items.Add(catalogList.Text);
                    isChange = true;
                }
            }
            else
            {
                MessageBox.Show("Enter new catalog",
                "No catalog Entered", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //prompts user to save file
            DialogResult responseDialogResult;

            if (isChange)
            {
                responseDialogResult = MessageBox.Show("Catalog list has changed. Save the list?", "Catalog List Changed",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    save_Click(sender, new System.EventArgs());
                }
            }
                //closes the application
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load the combo box
            DialogResult responseDialogResult;
            try
            {
                StreamReader catalogStreamReader = new StreamReader("Catalogs.txt");
                while (catalogStreamReader.Peek() != -1)
                {
                    catalogList.Items.Add(catalogStreamReader.ReadLine());
                }
                catalogStreamReader.Close();
            }
            catch
            {
                responseDialogResult = MessageBox.Show("Create a new file?", "File not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (responseDialogResult == DialogResult.No)
                {
                    //exit the project
                    exit_Click(e, new System.EventArgs());
                }
            }
        }


    }
}


