using System.ComponentModel;

namespace DemExam
{
    partial class AddProduct
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
            this.cancelChange = new System.Windows.Forms.Button();
            this.saveChange = new System.Windows.Forms.Button();
            this.measureTitle = new System.Windows.Forms.Label();
            this.countProductTitle = new System.Windows.Forms.Label();
            this.measureProduct = new System.Windows.Forms.TextBox();
            this.countProduct = new System.Windows.Forms.TextBox();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.saveProduct = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.measureTextTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManufacturerProductTitle = new System.Windows.Forms.Label();
            this.CategoryProductTitle = new System.Windows.Forms.Label();
            this.priceProductTitle = new System.Windows.Forms.Label();
            this.productTextTitle = new System.Windows.Forms.Label();
            this.DescriptionProductTitle = new System.Windows.Forms.Label();
            this.productNameTitle = new System.Windows.Forms.Label();
            this.measuteProductText = new System.Windows.Forms.TextBox();
            this.countProductText = new System.Windows.Forms.TextBox();
            this.ManufactyrerText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.decriptionText = new System.Windows.Forms.TextBox();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.articleProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelChange
            // 
            this.cancelChange.Location = new System.Drawing.Point(477, 743);
            this.cancelChange.Margin = new System.Windows.Forms.Padding(5);
            this.cancelChange.Name = "cancelChange";
            this.cancelChange.Size = new System.Drawing.Size(185, 80);
            this.cancelChange.TabIndex = 21;
            this.cancelChange.Text = "Отменить";
            this.cancelChange.UseVisualStyleBackColor = true;
            // 
            // saveChange
            // 
            this.saveChange.Location = new System.Drawing.Point(683, 743);
            this.saveChange.Margin = new System.Windows.Forms.Padding(5);
            this.saveChange.Name = "saveChange";
            this.saveChange.Size = new System.Drawing.Size(185, 80);
            this.saveChange.TabIndex = 20;
            this.saveChange.Text = "Сохранить";
            this.saveChange.UseVisualStyleBackColor = true;
            // 
            // measureTitle
            // 
            this.measureTitle.Location = new System.Drawing.Point(20, 625);
            this.measureTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.measureTitle.Name = "measureTitle";
            this.measureTitle.Size = new System.Drawing.Size(228, 41);
            this.measureTitle.TabIndex = 17;
            this.measureTitle.Text = "Единица измерения";
            // 
            // countProductTitle
            // 
            this.countProductTitle.Location = new System.Drawing.Point(20, 515);
            this.countProductTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countProductTitle.Name = "countProductTitle";
            this.countProductTitle.Size = new System.Drawing.Size(228, 41);
            this.countProductTitle.TabIndex = 16;
            this.countProductTitle.Text = "Количество";
            // 
            // measureProduct
            // 
            this.measureProduct.Location = new System.Drawing.Point(20, 671);
            this.measureProduct.Margin = new System.Windows.Forms.Padding(5);
            this.measureProduct.Multiline = true;
            this.measureProduct.Name = "measureProduct";
            this.measureProduct.Size = new System.Drawing.Size(226, 55);
            this.measureProduct.TabIndex = 9;
            // 
            // countProduct
            // 
            this.countProduct.Location = new System.Drawing.Point(20, 561);
            this.countProduct.Margin = new System.Windows.Forms.Padding(5);
            this.countProduct.Multiline = true;
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(226, 55);
            this.countProduct.TabIndex = 8;
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(293, 221);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(235, 185);
            this.pictureProduct.TabIndex = 39;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.DoubleClick += new System.EventHandler(this.pictureProduct_DoubleClick);
            // 
            // cancelAdd
            // 
            this.cancelAdd.Location = new System.Drawing.Point(293, 420);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(111, 45);
            this.cancelAdd.TabIndex = 38;
            this.cancelAdd.Text = "Отменить";
            this.cancelAdd.UseVisualStyleBackColor = true;
            this.cancelAdd.Click += new System.EventHandler(this.cancelAdd_Click);
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(417, 420);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(111, 45);
            this.saveProduct.TabIndex = 37;
            this.saveProduct.Text = "Добавить";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Items.AddRange(new object[] { "Вилки", "Ложки", "наборы", "ножи" });
            this.CategoryText.Location = new System.Drawing.Point(14, 242);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(121, 31);
            this.CategoryText.TabIndex = 36;
            // 
            // measureTextTitle
            // 
            this.measureTextTitle.Location = new System.Drawing.Point(14, 400);
            this.measureTextTitle.Name = "measureTextTitle";
            this.measureTextTitle.Size = new System.Drawing.Size(137, 23);
            this.measureTextTitle.TabIndex = 34;
            this.measureTextTitle.Text = "Единица измерения";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Количество";
            // 
            // ManufacturerProductTitle
            // 
            this.ManufacturerProductTitle.Location = new System.Drawing.Point(12, 276);
            this.ManufacturerProductTitle.Name = "ManufacturerProductTitle";
            this.ManufacturerProductTitle.Size = new System.Drawing.Size(137, 23);
            this.ManufacturerProductTitle.TabIndex = 32;
            this.ManufacturerProductTitle.Text = "Производитель";
            // 
            // CategoryProductTitle
            // 
            this.CategoryProductTitle.Location = new System.Drawing.Point(12, 216);
            this.CategoryProductTitle.Name = "CategoryProductTitle";
            this.CategoryProductTitle.Size = new System.Drawing.Size(96, 23);
            this.CategoryProductTitle.TabIndex = 35;
            this.CategoryProductTitle.Text = "Категория";
            // 
            // priceProductTitle
            // 
            this.priceProductTitle.Location = new System.Drawing.Point(12, 154);
            this.priceProductTitle.Name = "priceProductTitle";
            this.priceProductTitle.Size = new System.Drawing.Size(52, 23);
            this.priceProductTitle.TabIndex = 31;
            this.priceProductTitle.Text = "Цена";
            // 
            // productTextTitle
            // 
            this.productTextTitle.Location = new System.Drawing.Point(293, 195);
            this.productTextTitle.Name = "productTextTitle";
            this.productTextTitle.Size = new System.Drawing.Size(166, 23);
            this.productTextTitle.TabIndex = 30;
            this.productTextTitle.Text = "Изображение";
            // 
            // DescriptionProductTitle
            // 
            this.DescriptionProductTitle.Location = new System.Drawing.Point(293, 5);
            this.DescriptionProductTitle.Name = "DescriptionProductTitle";
            this.DescriptionProductTitle.Size = new System.Drawing.Size(166, 23);
            this.DescriptionProductTitle.TabIndex = 29;
            this.DescriptionProductTitle.Text = "Описание";
            // 
            // productNameTitle
            // 
            this.productNameTitle.Location = new System.Drawing.Point(12, 71);
            this.productNameTitle.Name = "productNameTitle";
            this.productNameTitle.Size = new System.Drawing.Size(87, 23);
            this.productNameTitle.TabIndex = 28;
            this.productNameTitle.Text = "Название";
            // 
            // measuteProductText
            // 
            this.measuteProductText.Location = new System.Drawing.Point(14, 426);
            this.measuteProductText.Multiline = true;
            this.measuteProductText.Name = "measuteProductText";
            this.measuteProductText.Size = new System.Drawing.Size(137, 33);
            this.measuteProductText.TabIndex = 26;
            // 
            // countProductText
            // 
            this.countProductText.Location = new System.Drawing.Point(14, 364);
            this.countProductText.Multiline = true;
            this.countProductText.Name = "countProductText";
            this.countProductText.Size = new System.Drawing.Size(137, 33);
            this.countProductText.TabIndex = 25;
            // 
            // ManufactyrerText
            // 
            this.ManufactyrerText.Location = new System.Drawing.Point(14, 302);
            this.ManufactyrerText.Multiline = true;
            this.ManufactyrerText.Name = "ManufactyrerText";
            this.ManufactyrerText.Size = new System.Drawing.Size(201, 33);
            this.ManufactyrerText.TabIndex = 24;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(12, 180);
            this.priceText.Multiline = true;
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(123, 33);
            this.priceText.TabIndex = 23;
            // 
            // decriptionText
            // 
            this.decriptionText.Location = new System.Drawing.Point(293, 40);
            this.decriptionText.Multiline = true;
            this.decriptionText.Name = "decriptionText";
            this.decriptionText.Size = new System.Drawing.Size(235, 126);
            this.decriptionText.TabIndex = 27;
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(12, 97);
            this.productNameText.Multiline = true;
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(203, 54);
            this.productNameText.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Артикль";
            // 
            // articleProduct
            // 
            this.articleProduct.Location = new System.Drawing.Point(14, 35);
            this.articleProduct.Multiline = true;
            this.articleProduct.Name = "articleProduct";
            this.articleProduct.Size = new System.Drawing.Size(123, 33);
            this.articleProduct.TabIndex = 23;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 471);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.measureTextTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManufacturerProductTitle);
            this.Controls.Add(this.CategoryProductTitle);
            this.Controls.Add(this.priceProductTitle);
            this.Controls.Add(this.productTextTitle);
            this.Controls.Add(this.DescriptionProductTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productNameTitle);
            this.Controls.Add(this.measuteProductText);
            this.Controls.Add(this.countProductText);
            this.Controls.Add(this.ManufactyrerText);
            this.Controls.Add(this.articleProduct);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.decriptionText);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.cancelChange);
            this.Controls.Add(this.saveChange);
            this.Controls.Add(this.measureTitle);
            this.Controls.Add(this.countProductTitle);
            this.Controls.Add(this.measureProduct);
            this.Controls.Add(this.countProduct);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Button cancelAdd;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.Label measureTextTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ManufacturerProductTitle;
        private System.Windows.Forms.Label CategoryProductTitle;
        private System.Windows.Forms.Label priceProductTitle;
        private System.Windows.Forms.Label productTextTitle;
        private System.Windows.Forms.Label DescriptionProductTitle;
        private System.Windows.Forms.Label productNameTitle;
        private System.Windows.Forms.TextBox measuteProductText;
        private System.Windows.Forms.TextBox countProductText;
        private System.Windows.Forms.TextBox ManufactyrerText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox decriptionText;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox articleProduct;

        private System.Windows.Forms.Button cancelChange;
        private System.Windows.Forms.Button saveChange;
        private System.Windows.Forms.Label measureTitle;
        private System.Windows.Forms.Label countProductTitle;
        private System.Windows.Forms.TextBox measureProduct;
        private System.Windows.Forms.TextBox countProduct;

        #endregion
    }
}