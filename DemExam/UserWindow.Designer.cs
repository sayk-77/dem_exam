using System.ComponentModel;

namespace DemExam
{
    partial class UserWindow
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
            this.countProducts = new System.Windows.Forms.Label();
            this.filterCategorys = new System.Windows.Forms.ComboBox();
            this.searchProduct = new System.Windows.Forms.TextBox();
            this.listProduct = new System.Windows.Forms.DataGridView();
            this.nameUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // countProducts
            // 
            this.countProducts.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProducts.Location = new System.Drawing.Point(249, 65);
            this.countProducts.Name = "countProducts";
            this.countProducts.Size = new System.Drawing.Size(237, 27);
            this.countProducts.TabIndex = 9;
            // 
            // filterCategorys
            // 
            this.filterCategorys.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCategorys.FormattingEnabled = true;
            this.filterCategorys.Location = new System.Drawing.Point(602, 67);
            this.filterCategorys.Name = "filterCategorys";
            this.filterCategorys.Size = new System.Drawing.Size(179, 31);
            this.filterCategorys.TabIndex = 8;
            this.filterCategorys.SelectedIndexChanged += new System.EventHandler(this.filterCategorys_SelectedIndexChanged);
            // 
            // searchProduct
            // 
            this.searchProduct.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchProduct.Location = new System.Drawing.Point(5, 70);
            this.searchProduct.Multiline = true;
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(129, 28);
            this.searchProduct.TabIndex = 7;
            this.searchProduct.TextChanged += new System.EventHandler(this.searchProduct_TextChanged);
            // 
            // listProduct
            // 
            this.listProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct.Location = new System.Drawing.Point(5, 109);
            this.listProduct.Name = "listProduct";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProduct.RowTemplate.ReadOnly = true;
            this.listProduct.Size = new System.Drawing.Size(776, 304);
            this.listProduct.TabIndex = 6;
            // 
            // nameUser
            // 
            this.nameUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUser.Location = new System.Drawing.Point(531, 17);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(250, 23);
            this.nameUser.TabIndex = 5;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.countProducts);
            this.Controls.Add(this.filterCategorys);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.nameUser);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWindow";
            this.Load += new System.EventHandler(this.UserWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label countProducts;
        private System.Windows.Forms.ComboBox filterCategorys;
        private System.Windows.Forms.TextBox searchProduct;
        private System.Windows.Forms.DataGridView listProduct;
        private System.Windows.Forms.Label nameUser;

        #endregion
    }
}