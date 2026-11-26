namespace Pereklu4nyaMizhViknami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Оберіть фото";
                dialog.Filter = "Зображення (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picPhoto.Image = Image.FromFile(dialog.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не вдалося відкрити зображення.",
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заповніть усі поля.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Реєстрація успішна, " + txtLogin.Text + "!", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}