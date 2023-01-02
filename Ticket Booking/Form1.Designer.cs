namespace Ticket_Booking
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.password_label = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.password_label.Location = new System.Drawing.Point(372, 336);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(94, 27);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.Location = new System.Drawing.Point(501, 288);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(157, 22);
            this.username_txtbox.TabIndex = 2;
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txtbox.Location = new System.Drawing.Point(501, 343);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(157, 20);
            this.password_txtbox.TabIndex = 3;
            this.password_txtbox.UseSystemPasswordChar = true;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.username_label.Location = new System.Drawing.Point(372, 288);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(102, 27);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.username_txtbox);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 477);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 79);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(120, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitesss";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Snow;
            this.submit.Location = new System.Drawing.Point(450, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(109, 45);
            this.submit.TabIndex = 6;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

