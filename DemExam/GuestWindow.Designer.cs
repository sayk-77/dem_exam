using System.ComponentModel;

namespace DemExam
{
    partial class GuestWindow
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
            this.listProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // listProduct
            // 
            this.listProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct.GridColor = System.Drawing.SystemColors.Window;
            this.listProduct.Location = new System.Drawing.Point(4, 78);
            this.listProduct.Name = "listProduct";
            this.listProduct.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProduct.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProduct.RowTemplate.ReadOnly = true;
            this.listProduct.Size = new System.Drawing.Size(776, 304);
            this.listProduct.TabIndex = 7;
            // 
            // GuestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listProduct);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GuestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestWindow";
            this.Load += new System.EventHandler(this.GuestWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView listProduct;

        #endregion
    }
}