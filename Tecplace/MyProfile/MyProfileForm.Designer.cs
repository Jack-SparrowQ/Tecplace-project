namespace MyProfile
{
    partial class MyProfileForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel_postsSections = new Panel();
            button_managePosts = new Button();
            button2 = new Button();
            flowLayoutPanel_posts = new FlowLayoutPanel();
            flowLayoutPanel_userdata = new FlowLayoutPanel();
            pictureProfile = new PictureBox();
            groupBox_data = new GroupBox();
            groupBox_contact = new GroupBox();
            label_description = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button_edittada = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_postsSections.SuspendLayout();
            flowLayoutPanel_userdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
            groupBox_data.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.993866F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.006134F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel_userdata, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.915493F));
            tableLayoutPanel1.Size = new Size(978, 620);
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.Size = new Size(747, 614);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 170);
            panel1.TabIndex = 3;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel_postsSections
            // 
            panel_postsSections.Controls.Add(button_managePosts);
            panel_postsSections.Controls.Add(button2);
            panel_postsSections.Controls.Add(flowLayoutPanel_posts);
            panel_postsSections.Dock = DockStyle.Fill;
            panel_postsSections.Location = new Point(3, 179);
            panel_postsSections.Name = "panel_postsSections";
            panel_postsSections.Size = new Size(741, 432);
            panel_postsSections.TabIndex = 4;
            // 
            // button_managePosts
            // 
            button_managePosts.Location = new Point(371, 353);
            button_managePosts.Name = "button_managePosts";
            button_managePosts.Size = new Size(94, 52);
            button_managePosts.TabIndex = 6;
            button_managePosts.Text = "Administrar posts";
            button_managePosts.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(263, 353);
            button2.Name = "button2";
            button2.Size = new Size(102, 52);
            button2.TabIndex = 0;
            button2.Text = "Nuevo post";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_posts
            // 
            flowLayoutPanel_posts.Location = new Point(13, 3);
            flowLayoutPanel_posts.Name = "flowLayoutPanel_posts";
            flowLayoutPanel_posts.Size = new Size(725, 426);
            flowLayoutPanel_posts.TabIndex = 5;
            // 
            // flowLayoutPanel_userdata
            // 
            flowLayoutPanel_userdata.Controls.Add(pictureProfile);
            flowLayoutPanel_userdata.Controls.Add(groupBox_data);
            flowLayoutPanel_userdata.Controls.Add(panel2);
            flowLayoutPanel_userdata.Location = new Point(756, 3);
            flowLayoutPanel_userdata.Name = "flowLayoutPanel_userdata";
            flowLayoutPanel_userdata.Size = new Size(219, 614);
            flowLayoutPanel_userdata.TabIndex = 1;
            // 
            // pictureProfile
            // 
            pictureProfile.BackColor = SystemColors.Control;
            pictureProfile.Location = new Point(3, 3);
            pictureProfile.Name = "pictureProfile";
            pictureProfile.Size = new Size(219, 219);
            pictureProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProfile.TabIndex = 2;
            pictureProfile.TabStop = false;
            // 
            // groupBox_data
            // 
            groupBox_data.Controls.Add(groupBox_contact);
            groupBox_data.Controls.Add(label_description);
            groupBox_data.Controls.Add(label1);
            groupBox_data.Location = new Point(3, 228);
            groupBox_data.Name = "groupBox_data";
            groupBox_data.Size = new Size(212, 206);
            groupBox_data.TabIndex = 3;
            groupBox_data.TabStop = false;
            groupBox_data.Text = "Informacion";
            // 
            // groupBox_contact
            // 
            groupBox_contact.Location = new Point(6, 101);
            groupBox_contact.Name = "groupBox_contact";
            groupBox_contact.Size = new Size(168, 73);
            groupBox_contact.TabIndex = 2;
            groupBox_contact.TabStop = false;
            groupBox_contact.Text = "Contacto";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 0;
            label1.Text = "Name Lastname";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_edittada);
            panel2.Location = new Point(3, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 125);
            panel2.TabIndex = 4;
            // 
            // button_edittada
            // 
            button_edittada.Location = new Point(37, 29);
            button_edittada.Name = "button_edittada";
            button_edittada.Size = new Size(137, 57);
            button_edittada.TabIndex = 0;
            button_edittada.Text = "Editar informacion";
            button_edittada.UseVisualStyleBackColor = true;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 635);
            Controls.Add(tableLayoutPanel1);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_postsSections.ResumeLayout(false);
            flowLayoutPanel_userdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
            groupBox_data.ResumeLayout(false);
            groupBox_data.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel_postsSections;
        private Button button_managePosts;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel_posts;
        private FlowLayoutPanel flowLayoutPanel_userdata;
        private PictureBox pictureProfile;
        private GroupBox groupBox_data;
        private Label label_description;
        private Label label1;
        private GroupBox groupBox_contact;
        private Panel panel2;
        private Button button_edittada;
    }
}
