using System.ComponentModel;

namespace DemExam
{
    partial class ChangeProduct
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
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productNameTitle = new System.Windows.Forms.Label();
            this.priceProductTitle = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.CategoryProductTitle = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.ManufacturerProductTitle = new System.Windows.Forms.Label();
            this.ManufactyrerText = new System.Windows.Forms.TextBox();
            this.DescriptionProductTitle = new System.Windows.Forms.Label();
            this.decriptionText = new System.Windows.Forms.TextBox();
            this.saveChange = new System.Windows.Forms.Button();
            this.cancelChange = new System.Windows.Forms.Button();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.productTextTitle = new System.Windows.Forms.Label();
            this.countProductTitle = new System.Windows.Forms.Label();
            this.countProduct = new System.Windows.Forms.TextBox();
            this.measureTitle = new System.Windows.Forms.Label();
            this.measureProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(12, 44);
            this.productNameText.Multiline = true;
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(203, 64);
            this.productNameText.TabIndex = 0;
            // 
            // productNameTitle
            // 
            this.productNameTitle.Location = new System.Drawing.Point(12, 9);
            this.productNameTitle.Name = "productNameTitle";
            this.productNameTitle.Size = new System.Drawing.Size(87, 23);
            this.productNameTitle.TabIndex = 1;
            this.productNameTitle.Text = "Название";
            // 
            // priceProductTitle
            // 
            this.priceProductTitle.Location = new System.Drawing.Point(12, 111);
            this.priceProductTitle.Name = "priceProductTitle";
            this.priceProductTitle.Size = new System.Drawing.Size(52, 23);
            this.priceProductTitle.TabIndex = 1;
            this.priceProductTitle.Text = "Цена";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(12, 137);
            this.priceText.Multiline = true;
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(123, 33);
            this.priceText.TabIndex = 0;
            // 
            // CategoryProductTitle
            // 
            this.CategoryProductTitle.Location = new System.Drawing.Point(12, 173);
            this.CategoryProductTitle.Name = "CategoryProductTitle";
            this.CategoryProductTitle.Size = new System.Drawing.Size(96, 23);
            this.CategoryProductTitle.TabIndex = 1;
            this.CategoryProductTitle.Text = "Категория";
            // 
            // CategoryText
            // 
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Items.AddRange(new object[] { "Вилки", "Ложки", "наборы", "ножи" });
            this.CategoryText.Location = new System.Drawing.Point(14, 199);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(121, 31);
            this.CategoryText.TabIndex = 2;
            // 
            // ManufacturerProductTitle
            // 
            this.ManufacturerProductTitle.Location = new System.Drawing.Point(12, 233);
            this.ManufacturerProductTitle.Name = "ManufacturerProductTitle";
            this.ManufacturerProductTitle.Size = new System.Drawing.Size(137, 23);
            this.ManufacturerProductTitle.TabIndex = 1;
            this.ManufacturerProductTitle.Text = "Производитель";
            // 
            // ManufactyrerText
            // 
            this.ManufactyrerText.Location = new System.Drawing.Point(14, 259);
            this.ManufactyrerText.Multiline = true;
            this.ManufactyrerText.Name = "ManufactyrerText";
            this.ManufactyrerText.Size = new System.Drawing.Size(201, 33);
            this.ManufactyrerText.TabIndex = 0;
            // 
            // DescriptionProductTitle
            // 
            this.DescriptionProductTitle.Location = new System.Drawing.Point(288, 9);
            this.DescriptionProductTitle.Name = "DescriptionProductTitle";
            this.DescriptionProductTitle.Size = new System.Drawing.Size(166, 23);
            this.DescriptionProductTitle.TabIndex = 1;
            this.DescriptionProductTitle.Text = "Описание";
            // 
            // decriptionText
            // 
            this.decriptionText.Location = new System.Drawing.Point(288, 44);
            this.decriptionText.Multiline = true;
            this.decriptionText.Name = "decriptionText";
            this.decriptionText.Size = new System.Drawing.Size(235, 126);
            this.decriptionText.TabIndex = 0;
            // 
            // saveChange
            // 
            this.saveChange.Location = new System.Drawing.Point(412, 424);
            this.saveChange.Name = "saveChange";
            this.saveChange.Size = new System.Drawing.Size(111, 45);
            this.saveChange.TabIndex = 3;
            this.saveChange.Text = "Сохранить";
            this.saveChange.UseVisualStyleBackColor = true;
            this.saveChange.Click += new System.EventHandler(this.saveChange_Click);
            // 
            // cancelChange
            // 
            this.cancelChange.Location = new System.Drawing.Point(288, 424);
            this.cancelChange.Name = "cancelChange";
            this.cancelChange.Size = new System.Drawing.Size(111, 45);
            this.cancelChange.TabIndex = 3;
            this.cancelChange.Text = "Отменить";
            this.cancelChange.UseVisualStyleBackColor = true;
            this.cancelChange.Click += new System.EventHandler(this.cancelChange_Click);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(288, 225);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(235, 185);
            this.pictureProduct.TabIndex = 4;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.DoubleClick += new System.EventHandler(this.pictureProduct_DoubleClick);
            // 
            // productTextTitle
            // 
            this.productTextTitle.Location = new System.Drawing.Point(288, 199);
            this.productTextTitle.Name = "productTextTitle";
            this.productTextTitle.Size = new System.Drawing.Size(166, 23);
            this.productTextTitle.TabIndex = 1;
            this.productTextTitle.Text = "Изображение";
            // 
            // countProductTitle
            // 
            this.countProductTitle.Location = new System.Drawing.Point(14, 295);
            this.countProductTitle.Name = "countProductTitle";
            this.countProductTitle.Size = new System.Drawing.Size(137, 23);
            this.countProductTitle.TabIndex = 1;
            this.countProductTitle.Text = "Количество";
            // 
            // countProduct
            // 
            this.countProduct.Location = new System.Drawing.Point(14, 321);
            this.countProduct.Multiline = true;
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(137, 33);
            this.countProduct.TabIndex = 0;
            // 
            // measureTitle
            // 
            this.measureTitle.Location = new System.Drawing.Point(14, 357);
            this.measureTitle.Name = "measureTitle";
            this.measureTitle.Size = new System.Drawing.Size(137, 23);
            this.measureTitle.TabIndex = 1;
            this.measureTitle.Text = "Единица измерения";
            // 
            // measureProduct
            // 
            this.measureProduct.Location = new System.Drawing.Point(14, 383);
            this.measureProduct.Multiline = true;
            this.measureProduct.Name = "measureProduct";
            this.measureProduct.Size = new System.Drawing.Size(137, 33);
            this.measureProduct.TabIndex = 0;
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 481);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.cancelChange);
            this.Controls.Add(this.saveChange);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.measureTitle);
            this.Controls.Add(this.countProductTitle);
            this.Controls.Add(this.ManufacturerProductTitle);
            this.Controls.Add(this.CategoryProductTitle);
            this.Controls.Add(this.priceProductTitle);
            this.Controls.Add(this.productTextTitle);
            this.Controls.Add(this.DescriptionProductTitle);
            this.Controls.Add(this.productNameTitle);
            this.Controls.Add(this.measureProduct);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.ManufactyrerText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.decriptionText);
            this.Controls.Add(this.productNameText);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangeProduct";
            this.Text = "ChangeProduct";
            this.Load += new System.EventHandler(this.ChangeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label countProductTitle;
        private System.Windows.Forms.TextBox countProduct;
        private System.Windows.Forms.Label measureTitle;
        private System.Windows.Forms.TextBox measureProduct;

        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Label productTextTitle;

        private System.Windows.Forms.Button saveChange;
        private System.Windows.Forms.Button cancelChange;

        private System.Windows.Forms.Label ManufacturerProductTitle;
        private System.Windows.Forms.TextBox ManufactyrerText;
        private System.Windows.Forms.Label DescriptionProductTitle;
        private System.Windows.Forms.TextBox decriptionText;

        private System.Windows.Forms.ComboBox CategoryText;

        private System.Windows.Forms.Label priceProductTitle;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label CategoryProductTitle;

        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label productNameTitle;

        #endregion
    }
}