using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemExam
{
    public partial class GuestWindow : Form
    {
        private DataBase _db;
        public GuestWindow()
        {
            InitializeComponent();
            _db = new DataBase();
        }

        private void GuestWindow_Load(object sender, EventArgs e)
        {
            LoadProduct();
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
                
                foreach (DataRow row in tempTable.Rows)
                {
                    string article = row["ProductArticleNumber"].ToString();
                    string imagePath = $"{Directory.GetCurrentDirectory()}\\image\\{row["ProductPhoto"]}.jpg";
                    string description = $"{row["ProductName"]}\n\n{row["ProductDescription"]}\nПроизводитель: {row["ProductManufacturer"]}\nЦена: {row["ProductCost"]}";
                    string stock = $"{row["ProductQuantityInStock"]} {row["ProductMeasure"]}";

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
    }
}