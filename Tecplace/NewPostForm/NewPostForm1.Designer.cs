namespace NewPostForm
{
    partial class NewPostForm1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            checkBox_withoutprice = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox_snack = new CheckBox();
            checkBox_Bebidas = new CheckBox();
            checkBox_almuezos = new CheckBox();
            checkBox_desayunos = new CheckBox();
            label2 = new Label();
            textBox_price = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            button_upload = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.61774F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.38226F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(947, 587);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 581);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_withoutprice);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_price);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(16, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 279);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar descripcion";
            // 
            // checkBox_withoutprice
            // 
            checkBox_withoutprice.AutoSize = true;
            checkBox_withoutprice.Location = new Point(6, 180);
            checkBox_withoutprice.Name = "checkBox_withoutprice";
            checkBox_withoutprice.Size = new Size(97, 24);
            checkBox_withoutprice.TabIndex = 6;
            checkBox_withoutprice.Text = "Sin precio";
            checkBox_withoutprice.UseVisualStyleBackColor = true;
            checkBox_withoutprice.CheckedChanged += checkBox_withoutprice_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(checkBox_snack);
            flowLayoutPanel1.Controls.Add(checkBox_Bebidas);
            flowLayoutPanel1.Controls.Add(checkBox_almuezos);
            flowLayoutPanel1.Controls.Add(checkBox_desayunos);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(130, 147);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(120, 126);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // checkBox_snack
            // 
            checkBox_snack.AutoSize = true;
            checkBox_snack.Location = new Point(3, 3);
            checkBox_snack.Name = "checkBox_snack";
            checkBox_snack.Size = new Size(69, 24);
            checkBox_snack.TabIndex = 0;
            checkBox_snack.Text = "Snack";
            checkBox_snack.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bebidas
            // 
            checkBox_Bebidas.AutoSize = true;
            checkBox_Bebidas.Location = new Point(3, 33);
            checkBox_Bebidas.Name = "checkBox_Bebidas";
            checkBox_Bebidas.Size = new Size(84, 24);
            checkBox_Bebidas.TabIndex = 1;
            checkBox_Bebidas.Text = "Bebidas";
            checkBox_Bebidas.UseVisualStyleBackColor = true;
            // 
            // checkBox_almuezos
            // 
            checkBox_almuezos.AutoSize = true;
            checkBox_almuezos.Location = new Point(3, 63);
            checkBox_almuezos.Name = "checkBox_almuezos";
            checkBox_almuezos.Size = new Size(96, 24);
            checkBox_almuezos.TabIndex = 2;
            checkBox_almuezos.Text = "Almuezos";
            checkBox_almuezos.UseVisualStyleBackColor = true;
            // 
            // checkBox_desayunos
            // 
            checkBox_desayunos.AutoSize = true;
            checkBox_desayunos.Location = new Point(3, 93);
            checkBox_desayunos.Name = "checkBox_desayunos";
            checkBox_desayunos.Size = new Size(102, 24);
            checkBox_desayunos.TabIndex = 3;
            checkBox_desayunos.Text = "Desayunos";
            checkBox_desayunos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 124);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Categoria ";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(6, 147);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(91, 27);
            textBox_price.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Precio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 86);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(54, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(435, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 581);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button_upload
            // 
            button_upload.Location = new Point(211, 502);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(133, 47);
            button_upload.TabIndex = 1;
            button_upload.Text = "Publicar";
            button_upload.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 35);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 0;
            label3.Text = "Preview";
            // 
            // NewPostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 589);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "NewPostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo post";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox_price;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox_withoutprice;
        private CheckBox checkBox_snack;
        private CheckBox checkBox_Bebidas;
        private CheckBox checkBox_almuezos;
        private CheckBox checkBox_desayunos;
        private Panel panel2;
        private Label label3;
        private Button button_upload;
    }
}
