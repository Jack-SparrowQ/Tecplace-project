using CommonUtils.Interfaces;
namespace NewPostForm
{
    public partial class NewPostForm1 : Form
    {
        private INavegation nav;
        public NewPostForm1(INavegation nav)
        {

            InitializeComponent();
            this.nav = nav;
        }

        private void checkBox_withoutprice_CheckedChanged(object sender, EventArgs e)
        {
            textBox_price.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que de quires salir?", "Confirmar salida");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                // El usuario eligió cancelar, no hacemos nada
            }
        }
    }
}
