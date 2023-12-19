using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemExam
{
    public partial class UserWindow : Form
    {
        private string _userName;
        private DataBase _db;
        private int _maxCountProducts;
        private int _currentCountProducts;
        public UserWindow(string userName)
        {
            InitializeComponent();
            _userName = userName;
            _db = new DataBase();
        }
        
        private void LoadProduct()
        {
            listProduct.Columns.Clear();
            try
            {
                //resetSearch();
                _db.OpenConnection();
                
                DataTable tempTable = new DataTable();
                
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM product", _db.GetConnection()))
                {
                    adapter.Fill(tempTable);
                }

                listProduct.Columns.Add("Артикул", "Артикул");
                listProduct.Columns.Add("Фото", "Фото");
                listProduct.Columns.Add("О товаре", "О товаре");
                listProduct.Columns.Add("Наличие на складе", "Наличие на складе");
                listProduct.Columns["Артикул"].FillWeight = 1;
                listProduct.Columns["О товаре"].FillWeight = 3;
                listProduct.Columns["Фото"].FillWeight = 2;
                listProduct.Columns["Наличие на складе"].FillWeight = 1;
                listProduct.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                listProduct.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                listProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                
                //подсчет общего количества товаров
                _maxCountProducts = tempTable.Rows.Count;
                
                foreach (DataRow row in tempTable.Rows)
                {
                    string article = row["ProductArticleNumber"].ToString();
                    string imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.jpg";
                    string description = $"{row["ProductName"]}\n\n{row["ProductDescription"]}\nПроизводитель: {row["ProductManufacturer"]}\nЦена: {row["ProductCost"]}";
                    string stock = $"{row["ProductQuantityInStock"].ToString()} {row["ProductMeasure"]}";

                    if (!File.Exists(imagePath))
                    {
                        imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.png";
    
                        if (!File.Exists(imagePath))
                        {
                            imagePath = $"{Directory.GetCurrentDirectory()}\\image\\picture.png";
                        }
                    }

                    Image productImage = Image.FromFile(imagePath);

                    int width = 150;
                    int height = 150;

                    Image resizedImage = new Bitmap(width, height);

                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(productImage, 0, 0, width, height);
                    }

                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = resizedImage;

                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = article });
                    dataGridViewRow.Cells.Add(imageCell);
                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = description });
                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = stock });

                    listProduct.Rows.Add(dataGridViewRow);
                }
            }
            catch (MySqlException ex) { Console.WriteLine(ex);}
            finally
            {
                _db.CloseConnection();
            }
        }
        private void FilterManufacturer(string manufacturer)
        {
            try
            {
                resetSearch();
                if (manufacturer == "Все производители")
                {
                    LoadProduct();
                    _currentCountProducts = _maxCountProducts;
                    countProducts.Text = $"Количество: {_currentCountProducts} из {_maxCountProducts}";
                }
                else
                {
                    _db.OpenConnection();
                    
                    DataTable tempTable = new DataTable();
                    
                    string queryForProduct = $"select ProductArticleNumber, ProductPhoto, ProductDescription, ProductQuantityInStock, ProductCost, ProductMeasure from product where ProductManufacturer = @manufacturer";
                    MySqlCommand command = new MySqlCommand(queryForProduct, _db.GetConnection());
                    command.Parameters.AddWithValue("@manufacturer", manufacturer);
                    
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(tempTable);
                    }
                    
                    // количество продуктов с выбранным фильтром
                    _currentCountProducts = tempTable.Rows.Count;
                    countProducts.Text = $"Количество: {_currentCountProducts} из {_maxCountProducts}";
                    
                    listProduct.Rows.Clear();

                    foreach (DataRow row in tempTable.Rows)
                    {
                        string article = row["ProductArticleNumber"].ToString();
                        string imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.jpg";
                        string description = $"{row["ProductDescription"]}\nПроизводитель: {manufacturer}\nЦена: {row["ProductCost"]}";
                        string stock = $"{row["ProductQuantityInStock"].ToString()} {row["ProductMeasure"]}";

                        if (!File.Exists(imagePath))
                        {
                            imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.png";
    
                            if (!File.Exists(imagePath))
                            {
                                imagePath = $"{Directory.GetCurrentDirectory()}\\image\\picture.png";
                            }
                        }

                        Image productImage = Image.FromFile(imagePath);

                        int width = 150;
                        int height = 150;

                        Image resizedImage = new Bitmap(width, height);

                        using (Graphics graphics = Graphics.FromImage(resizedImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(productImage, 0, 0, width, height);
                        }

                        DataGridViewImageCell imageCell = new DataGridViewImageCell();
                        imageCell.Value = resizedImage;

                        DataGridViewRow dataRow = new DataGridViewRow();
                        dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = article });
                        dataRow.Cells.Add(imageCell);
                        dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = description });
                        dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = stock });

                        listProduct.Rows.Add(dataRow);
                    }
                }
            }
            catch (MySqlException ex) { Console.WriteLine(ex); }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void resetSearch()
        {
            searchProduct.Text = "";
        }
        
        private void searchProducts(string searchQuery)
        {
            try
            {
                _db.OpenConnection();
        
                DataTable tempTable = new DataTable();
        
                string[] searchTerms = searchQuery.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> conditions = new List<string>();

                foreach (string term in searchTerms)
                {
                    conditions.Add(
                        $"(ProductName LIKE @term{conditions.Count} OR ProductDescription LIKE @term{conditions.Count} OR ProductManufacturer LIKE @term{conditions.Count} OR ProductCost LIKE @term{conditions.Count} OR ProductQuantityInStock LIKE @term{conditions.Count})"
                    );
                }

                string queryForProduct = $@"
                    SELECT * 
                    FROM product 
                    WHERE 
                        {string.Join(" AND ", conditions)}
                ";

                MySqlCommand command = new MySqlCommand(queryForProduct, _db.GetConnection());

                for (int i = 0; i < searchTerms.Length; i++)
                {
                    command.Parameters.AddWithValue($"@term{i}", $"%{searchTerms[i]}%");
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(tempTable);
                }
        
                listProduct.Rows.Clear();

                foreach (DataRow row in tempTable.Rows)
                {
                    string article = row["ProductArticleNumber"].ToString();
                    string imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"].ToString()}.jpg";
                    string description = $"{row["ProductDescription"]}\nПроизводитель: {row["ProductManufacturer"]}\nЦена: {row["ProductCost"]}";
                    string stock = $"{row["ProductQuantityInStock"].ToString()} {row["ProductMeasure"]}";

                    if (!File.Exists(imagePath))
                    {
                        imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.png";
    
                        if (!File.Exists(imagePath))
                        {
                            imagePath = $"{Directory.GetCurrentDirectory()}\\image\\picture.png";
                        }
                    }

                    Image productImage = Image.FromFile(imagePath);

                    int width = 150;
                    int height = 150;

                    Image resizedImage = new Bitmap(width, height);

                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(productImage, 0, 0, width, height);
                    }

                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = resizedImage;

                    DataGridViewRow dataRow = new DataGridViewRow();
                    dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = article });
                    dataRow.Cells.Add(imageCell);
                    dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = description });
                    dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = stock });

                    listProduct.Rows.Add(dataRow);
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


        private void LoadManufacturer()
        {
            try
            {
                resetSearch();
                _db.OpenConnection();
                
                DataTable tempTable = new DataTable();
                
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT DISTINCT ProductManufacturer FROM product", _db.GetConnection()))
                {
                    adapter.Fill(tempTable);
                }

                filterCategorys.Items.Add("Все производители");

                foreach (DataRow row in tempTable.Rows)
                {
                    filterCategorys.Items.Add(row["ProductManufacturer"]);
                }

                filterCategorys.SelectedIndex = 0;
            }
            catch (MySqlException ex) { Console.WriteLine(ex); }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            string querySearch = searchProduct.Text;
            searchProducts(querySearch);
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            LoadManufacturer();
            nameUser.Text = _userName;
        }

        private void filterCategorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectManufacturer = filterCategorys.Text;
            FilterManufacturer(selectManufacturer);
        }
    }
}