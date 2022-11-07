namespace WinFormsNotePadProject
{
    public partial class Form1 : Form
    {
        string fileName;
        bool fileSave;

        int row;
        int col;

        string buffer;

        public Form1()
        {
            InitializeComponent();
            DialogsSetup();
            MenuMainSetup();

            fileName = "noname.txt";
            fileSave = true;
            row = col = 1;

            stLabelRow.Text = row.ToString();
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
            ToolStripMenuItem menuFontItemColor = new("Цвет шрифта");
            ToolStripSeparator menuFontSeparator = new ToolStripSeparator();
            ToolStripMenuItem menuFontItemBackColor = new("Цвет фона");

            menuMain.Items.Add(menuFontItem);
            menuFontItem.DropDownItems.Add(menuFontItemChange);
            menuFontItem.DropDownItems.Add(menuFontItemColor);
            menuFontItem.DropDownItems.Add(menuFontSeparator);
            menuFontItem.DropDownItems.Add(menuFontItemBackColor);

            menuFontItemChange.Click += menuFontItemChange_Click!;
            menuFontItemChange.ShortcutKeys = Keys.Alt | Keys.F;
        }



        /*
        
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

        
        */


        private void menuItemFileNew_Click(object sender, EventArgs e)
        {
            // проверить есть ли сейчас в окне несохраненный текст.
            
            if(!fileSave)
            {
                string message = "Сохранить в файле " + fileName + "?";
                DialogResult result = MessageBox.Show(message, "Сохраненить содержимое?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (dialogSave.ShowDialog() == DialogResult.Cancel)
                            return;
                        string fileName = dialogSave.FileName;
                        File.WriteAllText(fileName, txtEditBox.Text);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            
            txtEditBox.Text = "";
            fileName = "noname.txt";
            fileSave = true;
            return;
        }


        private void menuFontItemChange_Click(object sender, EventArgs e)
        {
            dialogFont.Font = txtEditBox.Font;
            dialogFont.Color = txtEditBox.ForeColor;

            if (dialogFont.ShowDialog() == DialogResult.Cancel)
                return;

            txtEditBox.Font = dialogFont.Font;
            txtEditBox.ForeColor = dialogFont.Color;
        }

        private void txtEditBox_TextChanged(object sender, EventArgs e)
        {
            fileSave = false;
        }

        private void dialogFont_Apply(object sender, EventArgs e)
        {
            txtEditBox.Font = dialogFont.Font;
            txtEditBox.ForeColor = dialogFont.Color;
        }

        private void txtEditBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Keys keys = (Keys)e.KeyChar;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    row++;
                    break;
                case Keys.Up:
                    if(row > 1)
                        row--;
                    break;
                case Keys.Down:
                    if(row < txtEditBox.Lines.Length)
                        row++;
                    break;
                default:
                    break;
            }

            stLabelRow.Text = row.ToString();
        }

        private void cntMenuEditCopy_Click(object sender, EventArgs e)
        {
            if(txtEditBox.SelectionLength > 0)
                buffer = txtEditBox.SelectedText;
        }

        private void cntMenuEditCut_Click(object sender, EventArgs e)
        {
            if (txtEditBox.SelectionLength > 0)
            {
                string text = txtEditBox.Text;
                buffer = txtEditBox.SelectedText;
                text = text.Remove(txtEditBox.SelectionStart, txtEditBox.SelectionLength);
                txtEditBox.Text = text;
            }
        }

        private void cntMenuEditPaste_Click(object sender, EventArgs e)
        {
            int position = txtEditBox.SelectionStart;
            string text = txtEditBox.Text;
            text = text.Insert(txtEditBox.SelectionStart, buffer);
            txtEditBox.Text = text;
            txtEditBox.SelectionStart = position + buffer.Length;
        }
    }
}