using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemExam
{
    public partial class ChangeProduct : Form
    {
        private string _articleProduct;
        private DataBase _db;

        public ChangeProduct(string articleProduct)
        {
            _articleProduct = articleProduct;
            InitializeComponent();
            _db = new DataBase();
        }

        private void ChangeProduct_Load(object sender, EventArgs e)
        {
            LoadProductInfo(_articleProduct);
        }

        private void LoadProductInfo(string article)
        {
            try
            {
                _db.OpenConnection();

                DataTable tempTable = new DataTable();

                string queryForProduct = $"select * from product where ProductArticleNumber = @article";
                MySqlCommand command = new MySqlCommand(queryForProduct, _db.GetConnection());
                command.Parameters.AddWithValue("@article", article);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(tempTable);
                }

                string pathImage;

                foreach (DataRow row in tempTable.Rows)
                {
                    productNameText.Text = row["ProductName"].ToString();
                    priceText.Text = row["ProductCost"].ToString();
                    decriptionText.Text = row["ProductDescription"].ToString();
                    ManufactyrerText.Text = row["ProductManufacturer"].ToString();
                    CategoryText.SelectedItem = row["ProductCategory"].ToString();
                    measureProduct.Text = row["ProductMeasure"].ToString();
                    countProduct.Text = row["ProductQuantityInStock"].ToString();

                    pathImage = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.jpg";
                    if (!File.Exists(pathImage))
                    {
                        pathImage = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.png";
    
                        if (!File.Exists(pathImage))
                        {
                            pathImage = $"{Directory.GetCurrentDirectory()}\\image\\picture.png";
                        }
                    }

                    Image productImage = Image.FromFile(pathImage);

                    int width = 220;
                    int height = 180;

                    Image resizedImage = new Bitmap(width, height);

                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(productImage, 0, 0, width, height);
                    }

                    pictureProduct.Image = resizedImage;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void cancelChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChange_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = productNameText.Text;
                int newPrice = Int32.Parse(priceText.Text);
                string newCategory = CategoryText.Text;
                string newDescr = decriptionText.Text;
                string newManufacturer = ManufactyrerText.Text;
                string newMeasure = measureProduct.Text;
                string newCount = countProduct.Text;

                if (pictureProduct.Image != null)
                {
                    saveImage();
                }
                
                _db.OpenConnection();

                string query =
                    "UPDATE product SET ProductName = @newName," +
                    "ProductCost = @newPrice, ProductCategory = @newCategory," +
                    "ProductDescription = @newDescr," +
                    "ProductManufacturer = @newManufacturer," +
                    "ProductQuantityInStock = @newCount, ProductMeasure = @newMeasure WHERE ProductArticleNumber = @article";

                MySqlCommand command = new MySqlCommand(query, _db.GetConnection());
                command.Parameters.AddWithValue("@article", _articleProduct);
                command.Parameters.AddWithValue("@newName", newName);
                command.Parameters.AddWithValue("@newPrice", newPrice);
                command.Parameters.AddWithValue("@newCategory", newCategory);
                command.Parameters.AddWithValue("@newDescr", newDescr);
                command.Parameters.AddWithValue("@newManufacturer", newManufacturer);
                command.Parameters.AddWithValue("@newMeasure", newMeasure);
                command.Parameters.AddWithValue("@newCount", newCount);

                int rowsAffect = command.ExecuteNonQuery();

                if (rowsAffect > 0)
                {
                    MessageBox.Show("Данные успешно обновлены");
                }
                else
                {
                    MessageBox.Show("Изменения не внесены");
                }

                this.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void saveImage()
        {
            _db.OpenConnection();

            string fileName = Guid.NewGuid().ToString();
            string fileDirectory = fileName + ".png";
            
            string pathImage = Path.Combine(Application.StartupPath, "image", fileDirectory);
            
            pictureProduct.Image.Save(pathImage,System.Drawing.Imaging.ImageFormat.Png);
            
            string updateQuery = $"UPDATE product SET ProductPhoto = @fileName WHERE ProductArticleNumber = @article";
            MySqlCommand command = new MySqlCommand(updateQuery, _db.GetConnection());
            command.Parameters.AddWithValue("@fileName", fileName);
            command.Parameters.AddWithValue("@article", _articleProduct);
            command.ExecuteNonQuery();
            
            _db.CloseConnection();
        }

        private void pictureProduct_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения PNG (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedImagePath);
                pictureProduct.Image = selectedImage;
            }
        }
    }
}