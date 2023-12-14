using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemExam
{
    public partial class AddProduct : Form
    {
        private DataBase _db;
        private string _fileName;
        
        public AddProduct()
        {
            InitializeComponent();
            _db = new DataBase();
        }


        private void cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void saveImage()
        {
            _fileName = Guid.NewGuid().ToString();
            string fileDirectory = _fileName + ".png";
            
            string pathImage = Path.Combine(Application.StartupPath, "image", fileDirectory);
            
            pictureProduct.Image.Save(pathImage,System.Drawing.Imaging.ImageFormat.Png);
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = productNameText.Text;
                int Price = Int32.Parse(priceText.Text);
                string Category = CategoryText.Text;
                string Descr = decriptionText.Text;
                string Manufacturer = ManufactyrerText.Text;
                string Measure = measureProduct.Text;
                int Count = Int32.Parse(countProductText.Text);
                string Article = articleProduct.Text;

                if (pictureProduct.Image != null)
                {
                    saveImage();
                }
                
                _db.OpenConnection();

                string query = "INSERT INTO product (ProductArticleNumber, ProductName, ProductDescription, ProductCategory, ProductPhoto, ProductManufacturer, ProductCost, ProductQuantityInStock, ProductMeasure) " +
                               "VALUES (@article, @Name, @Descr, @Category, @pathPhoto, @Manufacturer, @Cost, @Count, @Measure)";

                MySqlCommand command = new MySqlCommand(query, _db.GetConnection());
                command.Parameters.AddWithValue("@article", Article);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Cost", Price);
                command.Parameters.AddWithValue("@Category", Category);
                command.Parameters.AddWithValue("@Descr", Descr);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@Count", Count);
                command.Parameters.AddWithValue("@Measure", Measure);
                command.Parameters.AddWithValue("@pathPhoto", _fileName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Данные добавлены");
                }
                else
                {
                    MessageBox.Show("Данные не добавлены, произошла ошибка");
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