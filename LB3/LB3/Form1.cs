using System.Xml;

namespace LB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCesarShoose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCesarShoose.Checked == true)
            {
                listBoxInfo.Items.Clear();
                groupBoxCesarSifer.Enabled = true;
                groupBoxPolybius.Enabled = false;
                listBoxInfo.Items.Add("Caesar encryption");
                listBoxInfo.Items.Add("Enter key and k value");
            }
            else if (radioButtonCesarShoose.Checked == false)
            {
                groupBoxPolybius.Enabled = true;
                groupBoxCesarSifer.Enabled = false;
                listBoxInfo.Items.Clear();
                listBoxInfo.Items.Add("Polybius encryption");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonToEncryptCesar_Click(object sender, EventArgs e)
        {
            string keyword = "";
            int key = 0;
            keyword = textBoxCesarKey.Text.ToLower();
            key = Convert.ToInt32(textBoxKValue.Text);
            CesarEncryptor cesar = new CesarEncryptor();
            cesar.createNewAlphapet(keyword, key);
            textBoxEncrypted.Text = cesar.toEncrypt(textBoxDecrypted.Text.ToLower());
        }

        private void buttonToDecryptCesar_Click(object sender, EventArgs e)
        {
            string keyword = "";
            int key = 0;
            keyword = textBoxCesarKey.Text.ToLower();
            key = Convert.ToInt32(textBoxKValue.Text);
            CesarEncryptor cesar = new CesarEncryptor();
            cesar.createNewAlphapet(keyword, key);
            textBoxDecrypted.Text = cesar.toDecrypt(textBoxEncrypted.Text.ToLower());
        }

        private void buttonToEncryptPolybius_Click(object sender, EventArgs e)
        {
            Polubius poly = new Polubius(textBoxDecryptedPolybius.Text);
            textBoxEncryptedPolybius.Text = poly.toEncryptMessage();
        }

        private void buttonToDecrytpPolybius_Click(object sender, EventArgs e)
        {
            Polubius poly = new Polubius(textBoxEncryptedPolybius.Text);
            textBoxDecryptedPolybius.Text = poly.toDecryptMessage();
        }
    }
}