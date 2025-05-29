namespace PostForm
{
    partial class PostForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_buy = new Button();
            groupBox3 = new GroupBox();
            label_price = new Label();
            groupBox2 = new GroupBox();
            label_username = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label_description = new Label();
            pictureBox1 = new PictureBox();
            button_back = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_back);
            panel1.Controls.Add(btn_buy);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 433);
            panel1.TabIndex = 0;
            // 
            // btn_buy
            // 
            btn_buy.Location = new Point(514, 339);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(140, 59);
            btn_buy.TabIndex = 4;
            btn_buy.Text = "Comprar";
            btn_buy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label_price);
            groupBox3.Location = new Point(416, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(103, 66);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Precio";
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(12, 32);
            label_price.Name = "label_price";
            label_price.Size = new Size(50, 20);
            label_price.TabIndex = 0;
            label_price.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_username);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(422, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 111);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acerca del vendor";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.Location = new Point(71, 42);
            label_username.Name = "label_username";
            label_username.Size = new Size(179, 31);
            label_username.TabIndex = 1;
            label_username.Text = "Name Lastname";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(6, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 59);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_description);
            groupBox1.Location = new Point(416, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descripcion ";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(6, 23);
            label_description.Name = "label_description";
            label_description.Size = new Size(109, 20);
            label_description.TabIndex = 0;
            label_description.Text = "Sin descripcion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 379);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            button_back.Location = new Point(0, 0);
            button_back.Name = "button_back";
            button_back.Size = new Size(98, 40);
            button_back.TabIndex = 5;
            button_back.Text = "Regresar";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label_username;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label_description;
        private Button btn_buy;
        private Label label_price;
        private Button button_back;
    }
}
