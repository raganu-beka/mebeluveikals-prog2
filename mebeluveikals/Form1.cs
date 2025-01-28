using Microsoft.Data.Sqlite;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mebeluveikals
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;

        public Form1()
        {
            InitializeComponent();

            furnitureManager = new FurnitureManager("Data Source=furniture.db");

            var furniture = furnitureManager.ReadFurniture();

            var furnitureNames = furniture.Select(x => x.Name).ToList();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;

            furnitureManager.ExportToCsv("D:\\Files\\fails.csv");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);

            nameTextBox.Text = furniture.Name;
            descTextBox.Text = furniture.Description;
            priceTextBox.Text = furniture.Price.ToString();
            hTextBox.Text = furniture.Height.ToString();
            wTextBox.Text = furniture.Width.ToString();
            lTextBox.Text = furniture.Length.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts nosaukums.");
                }
                else if (string.IsNullOrEmpty(descTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts apraksts.");
                }
                else if (string.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Nav norādīta cena.");
                }
                else if (string.IsNullOrEmpty(hTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts augstums.");
                }
                else if (string.IsNullOrEmpty(wTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts platums.");
                }
                else if (string.IsNullOrEmpty(lTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts garums.");
                }


                furnitureManager.AddFurniture(nameTextBox.Text, descTextBox.Text,
                    Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(hTextBox.Text),
                    Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                furnitureList.Add(nameTextBox.Text);

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Ieraksts tika pievienots datubāzei");
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Notikusi SQL kļūda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

            List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
            furnitureList.Remove(selectProductComboBox.Text);

            selectProductComboBox.DataSource = null;
            selectProductComboBox.DataSource = furnitureList;

            MessageBox.Show("Mēbele tika izdzēsta no datubāzes.");
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    var fileName = Guid.NewGuid().ToString() + ".csv";
                    furnitureManager.ExportToCsv(fbd.SelectedPath + "\\" + fileName);

                    MessageBox.Show("Fails saglābāts!");
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var furniture = new Furniture(nameTextBox.Text, descTextBox.Text,
                Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(hTextBox.Text),
                Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));
            furnitureManager.UpdateFurniture(furniture);


            MessageBox.Show("Ieraksts tika atjaunots");
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    MessageBox.Show(filePath);
                }
            }
        }
    }
}
