namespace ShoesSystem
{
    partial class ProductInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ExportProd = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 340);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ExportProd
            // 
            this.ExportProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ExportProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportProd.ForeColor = System.Drawing.Color.Black;
            this.ExportProd.Location = new System.Drawing.Point(288, 377);
            this.ExportProd.Name = "ExportProd";
            this.ExportProd.Size = new System.Drawing.Size(192, 43);
            this.ExportProd.TabIndex = 35;
            this.ExportProd.Text = "Export Product";
            this.ExportProd.UseVisualStyleBackColor = false;
            this.ExportProd.Click += new System.EventHandler(this.ExportProd_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.returnbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.Color.Black;
            this.returnbtn.Location = new System.Drawing.Point(288, 426);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(192, 43);
            this.returnbtn.TabIndex = 36;
            this.returnbtn.Text = "Return";
            this.returnbtn.UseVisualStyleBackColor = false;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // ProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.ExportProd);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ProductInventory";
            this.Text = "ProductInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ExportProd;
        private System.Windows.Forms.Button returnbtn;
    }
}