namespace Main_project
{
    partial class FeedForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            profileBtn = new Button();
            pictureBox2 = new PictureBox();
            settingsBtn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            panelContedor = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContedor.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(profileBtn);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(settingsBtn);
            flowLayoutPanel1.Location = new Point(1012, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(236, 138);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgprofile;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // profileBtn
            // 
            profileBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBtn.Location = new Point(88, 3);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(134, 59);
            profileBtn.TabIndex = 0;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings_icon;
            pictureBox2.Location = new Point(3, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // settingsBtn
            // 
            settingsBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBtn.Location = new Point(56, 87);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(134, 44);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(285, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(217, 163);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(20);
            flowLayoutPanel.Size = new Size(789, 614);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.Paint += flowLayoutPanel_Paint;
            // 
            // panelContedor
            // 
            panelContedor.AutoScroll = true;
            panelContedor.AutoSize = true;
            panelContedor.Controls.Add(tableLayoutPanel1);
            panelContedor.Dock = DockStyle.Fill;
            panelContedor.Location = new Point(0, 0);
            panelContedor.Name = "panelContedor";
            panelContedor.Size = new Size(1251, 780);
            panelContedor.TabIndex = 2;
            panelContedor.Paint += panelContedor_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2091179F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.79088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.51724F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48276F));
            tableLayoutPanel1.Size = new Size(1251, 780);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(groupBox1);
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Controls.Add(groupBox2);
            flowLayoutPanel3.Location = new Point(3, 163);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(208, 455);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(11, 104);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Snaks";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Drinks";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(109, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Breakfasts";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button1.Location = new Point(3, 181);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 2;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(205, 160);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sugerencias";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button2);
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(1012, 163);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(227, 151);
            flowLayoutPanel4.TabIndex = 3;
            flowLayoutPanel4.Paint += flowLayoutPanel4_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(25, 3);
            button2.Name = "button2";
            button2.Size = new Size(199, 61);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Text = "Vender";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(66, 70);
            button3.Name = "button3";
            button3.Size = new Size(158, 62);
            button3.TabIndex = 1;
            button3.Text = "Peticion";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(208, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 780);
            Controls.Add(panelContedor);
            Controls.Add(flowLayoutPanel2);
            Name = "FeedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FeedForm_Load;
            Resize += FeedForm_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContedor.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void CentrarFlowLayoutPanel()
        {
            int x = (panelContedor.Width - flowLayoutPanel.Width) / 2;
            if (x < 0) x = 0; // Evitar posiciones negativas
            flowLayoutPanel.Location = new System.Drawing.Point(x, 20);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button profileBtn;
        private PictureBox pictureBox2;
        private Button settingsBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panelContedor;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
    }
}
