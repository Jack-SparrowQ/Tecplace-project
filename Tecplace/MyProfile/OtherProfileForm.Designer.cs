namespace MyProfile
{
    partial class OtherProfileForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel_postsSections = new Panel();
            flowLayoutPanel_posts = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button_filter = new Button();
            pictureBox2 = new PictureBox();
            groupBox_data = new GroupBox();
            label1 = new Label();
            label_description = new Label();
            groupBox_contact = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            panel_postsSections.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox_data.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel_postsSections, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.6644955F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.3355F));
            tableLayoutPanel2.Size = new Size(956, 735);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel_postsSections
            // 
            panel_postsSections.Controls.Add(flowLayoutPanel_posts);
            panel_postsSections.Dock = DockStyle.Fill;
            panel_postsSections.Location = new Point(3, 213);
            panel_postsSections.Name = "panel_postsSections";
            panel_postsSections.Size = new Size(950, 519);
            panel_postsSections.TabIndex = 4;
            // 
            // flowLayoutPanel_posts
            // 
            flowLayoutPanel_posts.Location = new Point(3, 9);
            flowLayoutPanel_posts.Name = "flowLayoutPanel_posts";
            flowLayoutPanel_posts.Size = new Size(945, 498);
            flowLayoutPanel_posts.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox_data);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button_filter);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 204);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(954, 220);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 1;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_filter
            // 
            button_filter.Location = new Point(820, 153);
            button_filter.Name = "button_filter";
            button_filter.Size = new Size(104, 38);
            button_filter.TabIndex = 6;
            button_filter.Text = "Filtrar por:";
            button_filter.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonShadow;
            pictureBox2.Location = new Point(53, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox_data
            // 
            groupBox_data.BackColor = SystemColors.Window;
            groupBox_data.Controls.Add(groupBox_contact);
            groupBox_data.Controls.Add(label_description);
            groupBox_data.Controls.Add(label1);
            groupBox_data.Location = new Point(226, 87);
            groupBox_data.Name = "groupBox_data";
            groupBox_data.Size = new Size(511, 104);
            groupBox_data.TabIndex = 3;
            groupBox_data.TabStop = false;
            groupBox_data.Text = "Informacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 0;
            label1.Text = "Name Lastname";
            label1.Click += label1_Click;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(6, 66);
            label_description.Name = "label_description";
            label_description.Size = new Size(122, 20);
            label_description.TabIndex = 1;
            label_description.Text = "label_description";
            // 
            // groupBox_contact
            // 
            groupBox_contact.Location = new Point(235, 26);
            groupBox_contact.Name = "groupBox_contact";
            groupBox_contact.Size = new Size(130, 62);
            groupBox_contact.TabIndex = 2;
            groupBox_contact.TabStop = false;
            groupBox_contact.Text = "Contacto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.993866F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.915493F));
            tableLayoutPanel1.Size = new Size(962, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OtherProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 762);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "OtherProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += OtherProfileForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel_postsSections.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox_data.ResumeLayout(false);
            groupBox_data.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private GroupBox groupBox_data;
        private GroupBox groupBox_contact;
        private Label label_description;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button_filter;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel_postsSections;
        private FlowLayoutPanel flowLayoutPanel_posts;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
