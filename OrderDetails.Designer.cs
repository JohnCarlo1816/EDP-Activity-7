namespace ShoesSystem
{
    partial class OrderDetails
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
            this.returnbtn = new System.Windows.Forms.Button();
            this.ExportDetails = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.returnbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.Color.Black;
            this.returnbtn.Location = new System.Drawing.Point(364, 464);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(178, 45);
            this.returnbtn.TabIndex = 39;
            this.returnbtn.Text = "Return";
            this.returnbtn.UseVisualStyleBackColor = false;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // ExportDetails
            // 
            this.ExportDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ExportDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportDetails.ForeColor = System.Drawing.Color.Black;
            this.ExportDetails.Location = new System.Drawing.Point(364, 415);
            this.ExportDetails.Name = "ExportDetails";
            this.ExportDetails.Size = new System.Drawing.Size(178, 45);
            this.ExportDetails.TabIndex = 38;
            this.ExportDetails.Text = "Export Details";
            this.ExportDetails.UseVisualStyleBackColor = false;
            this.ExportDetails.Click += new System.EventHandler(this.ExportDetails_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(870, 387);
            this.dataGridView3.TabIndex = 40;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 519);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.ExportDetails);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnbtn;
        private System.Windows.Forms.Button ExportDetails;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}