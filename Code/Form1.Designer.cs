
namespace ONURCANCANSU_2017100144_RESTAURANTMANAGEMENT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtID = new System.Windows.Forms.RichTextBox();
            this.Txtpass = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.ForeColor = System.Drawing.Color.OrangeRed;
            this.TxtID.Location = new System.Drawing.Point(332, 278);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(353, 35);
            this.TxtID.TabIndex = 0;
            this.TxtID.Text = "Username";
            this.TxtID.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.TxtID.Enter += new System.EventHandler(this.TxtID_Enter);
            this.TxtID.Leave += new System.EventHandler(this.TxtID_Leave);
            // 
            // Txtpass
            // 
            this.Txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.Txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtpass.ForeColor = System.Drawing.Color.OrangeRed;
            this.Txtpass.Location = new System.Drawing.Point(332, 375);
            this.Txtpass.Name = "Txtpass";
            this.Txtpass.Size = new System.Drawing.Size(353, 35);
            this.Txtpass.TabIndex = 1;
            this.Txtpass.Text = "Password";
            this.Txtpass.Enter += new System.EventHandler(this.Txtpass_Enter);
            this.Txtpass.Leave += new System.EventHandler(this.Txtpass_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(327, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(327, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(374, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "WELCOME BACK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.BackColor = System.Drawing.Color.OrangeRed;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(411, 434);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(179, 37);
            this.Login.TabIndex = 6;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 64);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(756, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(273, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "S.O.S. RESTAURANT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(407, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(461, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "ADMIN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 477);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpass);
            this.Controls.Add(this.TxtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtID;
        private System.Windows.Forms.RichTextBox Txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

