namespace _732_2
{
    public partial class Form1 : Form
    {
        private Sort sorter;

        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();

            sorter = new Sort();
        }

        private void MakeSort_Click(object sender, EventArgs e)
        {
            string input = Input.Text;
            string key = KeyWord.Text;
            Sort sorter = new Sort();
            Output2.Text = sorter.Encrypt(input, key);
        }

        private void MakeSort1_Click(object sender, EventArgs e)
        {
            string input = Input.Text;
            string key = KeyWord.Text;
            Sort sorter = new Sort();
            Output2.Text = sorter.Decrypt(input, key);

        }

        private void KeyWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "Test files|*.txt";
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
                {
                    sw.WriteLine(Output2.Text);
                    sw.Close();
                }
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog readfile = new OpenFileDialog();
            if (readfile.ShowDialog() == DialogResult.OK)
            {
                Name = readfile.FileName;
                Input.Clear();
                Input.Text = File.ReadAllText(Name);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
