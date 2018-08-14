namespace InstructionSetSystem
{
    partial class instructionSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.legalTxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionTxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.styleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColourTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleUnderlineTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(64, 108);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(646, 330);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "";
            this.rtbDisplay.TextChanged += new System.EventHandler(this.rtbDisplay_TextChanged);
            this.rtbDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbDisplay_KeyDown);
            this.rtbDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbDisplay_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.createTSMI,
            this.styleTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTSMI
            // 
            this.fileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMI,
            this.saveTSMI,
            this.printTSMI,
            this.exitTSMI});
            this.fileTSMI.Name = "fileTSMI";
            this.fileTSMI.Size = new System.Drawing.Size(37, 20);
            this.fileTSMI.Text = "File";
            // 
            // createTSMI
            // 
            this.createTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionTxtMenu,
            this.legalTxtMenu});
            this.createTSMI.Name = "createTSMI";
            this.createTSMI.Size = new System.Drawing.Size(53, 20);
            this.createTSMI.Text = "Create";
            // 
            // legalTxtMenu
            // 
            this.legalTxtMenu.CheckOnClick = true;
            this.legalTxtMenu.Name = "legalTxtMenu";
            this.legalTxtMenu.Size = new System.Drawing.Size(180, 22);
            this.legalTxtMenu.Text = "Legal Text";
            this.legalTxtMenu.Click += new System.EventHandler(this.legalTxtMenu_Click);
            // 
            // instructionTxtMenu
            // 
            this.instructionTxtMenu.CheckOnClick = true;
            this.instructionTxtMenu.Name = "instructionTxtMenu";
            this.instructionTxtMenu.Size = new System.Drawing.Size(180, 22);
            this.instructionTxtMenu.Text = "Instruction Text";
            this.instructionTxtMenu.Click += new System.EventHandler(this.instructionTxtMenu_Click);
            // 
            // styleTSMI
            // 
            this.styleTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundColourTSMI,
            this.backgroundColourTSMI,
            this.underlineTSMI,
            this.doubleUnderlineTSMI});
            this.styleTSMI.Name = "styleTSMI";
            this.styleTSMI.Size = new System.Drawing.Size(44, 20);
            this.styleTSMI.Text = "Style";
            // 
            // openTSMI
            // 
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.Size = new System.Drawing.Size(180, 22);
            this.openTSMI.Text = "Open";
            this.openTSMI.Click += new System.EventHandler(this.openTSMI_Click);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Size = new System.Drawing.Size(180, 22);
            this.saveTSMI.Text = "Save";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // foregroundColourTSMI
            // 
            this.foregroundColourTSMI.CheckOnClick = true;
            this.foregroundColourTSMI.Name = "foregroundColourTSMI";
            this.foregroundColourTSMI.Size = new System.Drawing.Size(180, 22);
            this.foregroundColourTSMI.Text = "Foreground Colour";
            this.foregroundColourTSMI.Click += new System.EventHandler(this.foregroundColourTSMI_Click);
            // 
            // backgroundColourTSMI
            // 
            this.backgroundColourTSMI.CheckOnClick = true;
            this.backgroundColourTSMI.Name = "backgroundColourTSMI";
            this.backgroundColourTSMI.Size = new System.Drawing.Size(180, 22);
            this.backgroundColourTSMI.Text = "Background Colour";
            this.backgroundColourTSMI.Click += new System.EventHandler(this.backgroundColourTSMI_Click);
            // 
            // underlineTSMI
            // 
            this.underlineTSMI.CheckOnClick = true;
            this.underlineTSMI.Name = "underlineTSMI";
            this.underlineTSMI.Size = new System.Drawing.Size(180, 22);
            this.underlineTSMI.Text = "Underline";
            this.underlineTSMI.Click += new System.EventHandler(this.underlineTSMI_Click);
            // 
            // doubleUnderlineTSMI
            // 
            this.doubleUnderlineTSMI.CheckOnClick = true;
            this.doubleUnderlineTSMI.Name = "doubleUnderlineTSMI";
            this.doubleUnderlineTSMI.Size = new System.Drawing.Size(180, 22);
            this.doubleUnderlineTSMI.Text = "Double Underline";
            // 
            // printTSMI
            // 
            this.printTSMI.Name = "printTSMI";
            this.printTSMI.Size = new System.Drawing.Size(180, 22);
            this.printTSMI.Text = "Print";
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(180, 22);
            this.exitTSMI.Text = "Exit";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(64, 74);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(562, 26);
            this.txtAdd.TabIndex = 3;
            this.txtAdd.Text = " ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(716, 222);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(717, 277);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // instructionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "instructionSet";
            this.Text = "Instruction Set System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem printTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.ToolStripMenuItem createTSMI;
        private System.Windows.Forms.ToolStripMenuItem legalTxtMenu;
        private System.Windows.Forms.ToolStripMenuItem instructionTxtMenu;
        private System.Windows.Forms.ToolStripMenuItem styleTSMI;
        private System.Windows.Forms.ToolStripMenuItem foregroundColourTSMI;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourTSMI;
        private System.Windows.Forms.ToolStripMenuItem underlineTSMI;
        private System.Windows.Forms.ToolStripMenuItem doubleUnderlineTSMI;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}

