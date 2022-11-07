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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEditBox = new System.Windows.Forms.TextBox();
            this.cntMenuEditBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntMenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cntMenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cntMenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.stLabelRowTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLabelRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.cntMenuEditBox.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditBox
            // 
            this.txtEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditBox.ContextMenuStrip = this.cntMenuEditBox;
            this.txtEditBox.Location = new System.Drawing.Point(0, 52);
            this.txtEditBox.Multiline = true;
            this.txtEditBox.Name = "txtEditBox";
            this.txtEditBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEditBox.Size = new System.Drawing.Size(791, 512);
            this.txtEditBox.TabIndex = 1;
            this.txtEditBox.TextChanged += new System.EventHandler(this.txtEditBox_TextChanged);
            this.txtEditBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEditBox_KeyDown);
            // 
            // cntMenuEditBox
            // 
            this.cntMenuEditBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntMenuEditCopy,
            this.cntMenuEditPaste,
            this.cntMenuEditCut});
            this.cntMenuEditBox.Name = "cntMenuEditBox";
            this.cntMenuEditBox.Size = new System.Drawing.Size(181, 92);
            // 
            // cntMenuEditCopy
            // 
            this.cntMenuEditCopy.Name = "cntMenuEditCopy";
            this.cntMenuEditCopy.Size = new System.Drawing.Size(180, 22);
            this.cntMenuEditCopy.Text = "Скопировать";
            this.cntMenuEditCopy.Click += new System.EventHandler(this.cntMenuEditCopy_Click);
            // 
            // cntMenuEditPaste
            // 
            this.cntMenuEditPaste.Name = "cntMenuEditPaste";
            this.cntMenuEditPaste.Size = new System.Drawing.Size(180, 22);
            this.cntMenuEditPaste.Text = "Вставить";
            this.cntMenuEditPaste.Click += new System.EventHandler(this.cntMenuEditPaste_Click);
            // 
            // cntMenuEditCut
            // 
            this.cntMenuEditCut.Name = "cntMenuEditCut";
            this.cntMenuEditCut.Size = new System.Drawing.Size(180, 22);
            this.cntMenuEditCut.Text = "Вырезать";
            this.cntMenuEditCut.Click += new System.EventHandler(this.cntMenuEditCut_Click);
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
            this.menuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemFileNew.Size = new System.Drawing.Size(163, 22);
            this.menuItemFileNew.Text = "Создать";
            this.menuItemFileNew.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.Size = new System.Drawing.Size(163, 22);
            this.menuItemFileOpen.Text = "Открыть";
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.Name = "menuItemFileSave";
            this.menuItemFileSave.Size = new System.Drawing.Size(163, 22);
            this.menuItemFileSave.Text = "Сохранить";
            // 
            // menuItemFileSaveAs
            // 
            this.menuItemFileSaveAs.Name = "menuItemFileSaveAs";
            this.menuItemFileSaveAs.Size = new System.Drawing.Size(163, 22);
            this.menuItemFileSaveAs.Text = "Сохранить как...";
            // 
            // menuItemFileClose
            // 
            this.menuItemFileClose.Name = "menuItemFileClose";
            this.menuItemFileClose.Size = new System.Drawing.Size(163, 22);
            this.menuItemFileClose.Text = "Закрыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // menuItemAppExit
            // 
            this.menuItemAppExit.Name = "menuItemAppExit";
            this.menuItemAppExit.Size = new System.Drawing.Size(163, 22);
            this.menuItemAppExit.Text = "Выход";
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(791, 25);
            this.toolMain.TabIndex = 3;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton1.Text = "Создать";
            this.toolStripButton1.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLabelRowTitle,
            this.stLabelRow});
            this.statusMain.Location = new System.Drawing.Point(0, 567);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(791, 22);
            this.statusMain.TabIndex = 4;
            this.statusMain.Text = "statusStrip1";
            // 
            // stLabelRowTitle
            // 
            this.stLabelRowTitle.Name = "stLabelRowTitle";
            this.stLabelRowTitle.Size = new System.Drawing.Size(46, 17);
            this.stLabelRowTitle.Text = "Строка";
            // 
            // stLabelRow
            // 
            this.stLabelRow.Name = "stLabelRow";
            this.stLabelRow.Size = new System.Drawing.Size(19, 17);
            this.stLabelRow.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 589);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.txtEditBox);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cntMenuEditBox.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
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
        private ToolStrip toolMain;
        private ToolStripButton toolStripButton1;
        private StatusStrip statusMain;
        private ToolStripStatusLabel stLabelRowTitle;
        private ToolStripStatusLabel stLabelRow;
        private ContextMenuStrip cntMenuEditBox;
        private ToolStripMenuItem cntMenuEditCopy;
        private ToolStripMenuItem cntMenuEditPaste;
        private ToolStripMenuItem cntMenuEditCut;
    }
}