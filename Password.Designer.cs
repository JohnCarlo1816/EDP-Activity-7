namespace ShoesSystem
{
    partial class Password
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassReco = new System.Windows.Forms.Label();
            this.BTL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(210)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BTL);
            this.panel1.Controls.Add(this.Send);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PassReco);
            this.panel1.Location = new System.Drawing.Point(221, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 365);
            this.panel1.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.Send.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(178, 256);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(91, 42);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(20, 199);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(73, 27);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 42);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your email and we will send you a code \r\n                    to reco" +
    "ver your password";
            // 
            // PassReco
            // 
            this.PassReco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassReco.AutoSize = true;
            this.PassReco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassReco.Location = new System.Drawing.Point(105, 27);
            this.PassReco.Name = "PassReco";
            this.PassReco.Size = new System.Drawing.Size(227, 26);
            this.PassReco.TabIndex = 0;
            this.PassReco.Text = "Password Recovery";
            // 
            // BTL
            // 
            this.BTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.BTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTL.ForeColor = System.Drawing.Color.Black;
            this.BTL.Location = new System.Drawing.Point(147, 304);
            this.BTL.Name = "BTL";
            this.BTL.Size = new System.Drawing.Size(149, 29);
            this.BTL.TabIndex = 9;
            this.BTL.Text = "Back To Login";
            this.BTL.UseVisualStyleBackColor = false;
            this.BTL.Click += new System.EventHandler(this.BTL_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(871, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Password";
            this.Text = "Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PassReco;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTL;
    }
}