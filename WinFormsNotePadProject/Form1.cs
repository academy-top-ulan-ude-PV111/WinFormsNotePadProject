namespace WinFormsNotePadProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DialogsSetup();
            
        }


        private void DialogsSetup()
        {
            dialogOpen.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы html (*.html)|*.html|Все файлы (*.*)|*.*";
            dialogSave.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы html (*.html)|*.html|Все файлы (*.*)|*.*";
            dialogFont.ShowColor = true;
            dialogFont.ShowEffects = true;
            dialogFont.ShowApply = true;

            dialogColor.FullOpen = true;
        }

        private void MenuMainSetup()
        {
            ToolStripMenuItem menuFontItem = new("Шрифт");
            ToolStripMenuItem menuFontItemChange = new("Изменить");
            ToolStripMenuItem menuFontItemColor = new("Цвет");
            ToolStripSeparator menuFontSeparator = new ToolStripSeparator();
            ToolStripMenuItem menuFontItemBackColor = new("Цвет фона");
        }





        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dialogOpen.ShowDialog() == DialogResult.Cancel)
                return;
           
            string fileName = dialogOpen.FileName;
            string text = File.ReadAllText(fileName);
            txtEditBox.Text = text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dialogSave.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = dialogSave.FileName;
            File.WriteAllText(fileName, txtEditBox.Text);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dialogFont.Font = txtEditBox.Font;
            dialogFont.Color = txtEditBox.ForeColor;

            if (dialogFont.ShowDialog() == DialogResult.Cancel)
                return;

            txtEditBox.Font = dialogFont.Font;
            txtEditBox.ForeColor = dialogFont.Color;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dialogColor.Color = txtEditBox.BackColor;
            
            if (dialogColor.ShowDialog() == DialogResult.Cancel)
                return;

            txtEditBox.BackColor = dialogColor.Color;
        }

        private void btnColorFore_Click(object sender, EventArgs e)
        {
            dialogColor.Color = txtEditBox.ForeColor;

            if (dialogColor.ShowDialog() == DialogResult.Cancel)
                return;

            txtEditBox.ForeColor = dialogColor.Color;
        }

        private void dialogFont_Apply(object sender, EventArgs e)
        {
            txtEditBox.Font = dialogFont.Font;
            txtEditBox.ForeColor = dialogFont.Color;
        }
    }
}