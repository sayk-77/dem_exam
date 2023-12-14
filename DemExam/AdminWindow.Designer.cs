using System.ComponentModel;

namespace DemExam
{
    partial class AdminWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameUser = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.DataGridView();
            this.searchProduct = new System.Windows.Forms.TextBox();
            this.filterCategorys = new System.Windows.Forms.ComboBox();
            this.countProducts = new System.Windows.Forms.Label();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.changeProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // nameUser
            // 
            this.nameUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUser.Location = new System.Drawing.Point(547, 9);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(250, 23);
            this.nameUser.TabIndex = 0;
            // 
            // listProduct
            // 
            this.listProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct.Location = new System.Drawing.Point(12, 81);
            this.listProduct.Name = "listProduct";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProduct.RowTemplate.ReadOnly = true;
            this.listProduct.Size = new System.Drawing.Size(776, 304);
            this.listProduct.TabIndex = 1;
            // 
            // searchProduct
            // 
            this.searchProduct.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchProduct.Location = new System.Drawing.Point(12, 42);
            this.searchProduct.Multiline = true;
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(129, 28);
            this.searchProduct.TabIndex = 2;
            this.searchProduct.TextChanged += new System.EventHandler(this.searchProduct_TextChanged);
            // 
            // filterCategorys
            // 
            this.filterCategorys.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCategorys.FormattingEnabled = true;
            this.filterCategorys.Location = new System.Drawing.Point(609, 39);
            this.filterCategorys.Name = "filterCategorys";
            this.filterCategorys.Size = new System.Drawing.Size(179, 31);
            this.filterCategorys.TabIndex = 3;
            this.filterCategorys.SelectedIndexChanged += new System.EventHandler(this.filterCategorys_SelectedIndexChanged);
            // 
            // countProducts
            // 
            this.countProducts.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProducts.Location = new System.Drawing.Point(263, 43);
            this.countProducts.Name = "countProducts";
            this.countProducts.Size = new System.Drawing.Size(237, 27);
            this.countProducts.TabIndex = 4;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(695, 402);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(93, 36);
            this.deleteProduct.TabIndex = 5;
            this.deleteProduct.Text = "Удалить";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(12, 402);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(93, 36);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Добавить";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // changeProduct
            // 
            this.changeProduct.Location = new System.Drawing.Point(111, 402);
            this.changeProduct.Name = "changeProduct";
            this.changeProduct.Size = new System.Drawing.Size(93, 36);
            this.changeProduct.TabIndex = 5;
            this.changeProduct.Text = "Редактировать";
            this.changeProduct.UseVisualStyleBackColor = true;
            this.changeProduct.Click += new System.EventHandler(this.changeProduct_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.countProducts);
            this.Controls.Add(this.filterCategorys);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.nameUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button changeProduct;

        private System.Windows.Forms.Label countProducts;

        private System.Windows.Forms.ComboBox filterCategorys;

        private System.Windows.Forms.TextBox searchProduct;

        private System.Windows.Forms.DataGridView listProduct;

        private System.Windows.Forms.Label nameUser;

        #endregion
    }
}