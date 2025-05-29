namespace Profiles_interfaces
{
    partial class PostInterface
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label_price = new Label();
            pictureBox_img = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_img).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_price);
            panel1.Controls.Add(pictureBox_img);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 327);
            panel1.TabIndex = 0;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_price.Location = new Point(187, 265);
            label_price.Name = "label_price";
            label_price.Size = new Size(102, 39);
            label_price.TabIndex = 1;
            label_price.Text = "$9.99";
            // 
            // pictureBox_img
            // 
            pictureBox_img.BackColor = SystemColors.ActiveCaption;
            pictureBox_img.Location = new Point(3, 3);
            pictureBox_img.Name = "pictureBox_img";
            pictureBox_img.Size = new Size(320, 320);
            pictureBox_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_img.TabIndex = 0;
            pictureBox_img.TabStop = false;
            pictureBox_img.Click += pictureBox_img_Click;
            // 
            // PostInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PostInterface";
            Size = new Size(338, 337);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_img).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_price;
        private PictureBox pictureBox_img;
    }
}
