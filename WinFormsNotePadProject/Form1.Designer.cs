namespace WinFormsNotePadProject
{
    partial class Form1
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
            this.txtEditBox = new System.Windows.Forms.TextBox();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.dialogFont = new System.Windows.Forms.FontDialog();
            this.dialogColor = new System.Windows.Forms.ColorDialog();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditBox
            // 
            this.txtEditBox.Location = new System.Drawing.Point(21, 55);
            this.txtEditBox.Multiline = true;
            this.txtEditBox.Name = "txtEditBox";
            this.txtEditBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEditBox.Size = new System.Drawing.Size(741, 491);
            this.txtEditBox.TabIndex = 1;
            // 
            // dialogOpen
            // 
            this.dialogOpen.FileName = "openFileDialog1";
            // 
            // dialogFont
            // 
            this.dialogFont.Apply += new System.EventHandler(this.dialogFont_Apply);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(791, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileNew,
            this.menuItemFileOpen,
            this.menuItemFileSave,
            this.menuItemFileSaveAs,
            this.menuItemFileClose,
            this.toolStripMenuItem1,
            this.menuItemAppExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(48, 20);
            this.menuItemFile.Text = "Файл";
            // 
            // menuItemFileNew
            // 
            this.menuItemFileNew.Name = "menuItemFileNew";
            this.menuItemFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuItemFileNew.Text = "Создать";
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuItemFileOpen.Text = "Открыть";
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.Name = "menuItemFileSave";
            this.menuItemFileSave.Size = new System.Drawing.Size(180, 22);
            this.menuItemFileSave.Text = "Сохранить";
            // 
            // menuItemFileSaveAs
            // 
            this.menuItemFileSaveAs.Name = "menuItemFileSaveAs";
            this.menuItemFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuItemFileSaveAs.Text = "Сохранить как...";
            // 
            // menuItemFileClose
            // 
            this.menuItemFileClose.Name = "menuItemFileClose";
            this.menuItemFileClose.Size = new System.Drawing.Size(180, 22);
            this.menuItemFileClose.Text = "Закрыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemAppExit
            // 
            this.menuItemAppExit.Name = "menuItemAppExit";
            this.menuItemAppExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemAppExit.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 645);
            this.Controls.Add(this.txtEditBox);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtEditBox;
        private OpenFileDialog dialogOpen;
        private SaveFileDialog dialogSave;
        private FontDialog dialogFont;
        private ColorDialog dialogColor;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuItemFile;
        private ToolStripMenuItem menuItemFileNew;
        private ToolStripMenuItem menuItemFileOpen;
        private ToolStripMenuItem menuItemFileSave;
        private ToolStripMenuItem menuItemFileSaveAs;
        private ToolStripMenuItem menuItemFileClose;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuItemAppExit;
    }
}