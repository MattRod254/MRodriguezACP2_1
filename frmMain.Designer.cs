
namespace MRodriguezACP2_1
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainGoToItm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainInOutItm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMouserItm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelpItm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainAboutItm = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainGoToItm,
            this.mnuMainHelpItm});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(471, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainGoToItm
            // 
            this.mnuMainGoToItm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainInOutItm,
            this.mnuMainMouserItm});
            this.mnuMainGoToItm.Name = "mnuMainGoToItm";
            this.mnuMainGoToItm.Size = new System.Drawing.Size(46, 20);
            this.mnuMainGoToItm.Text = "&GoTo";
            // 
            // mnuMainInOutItm
            // 
            this.mnuMainInOutItm.Name = "mnuMainInOutItm";
            this.mnuMainInOutItm.Size = new System.Drawing.Size(143, 22);
            this.mnuMainInOutItm.Text = "&Input Output";
            this.mnuMainInOutItm.Click += new System.EventHandler(this.mnuMainInOutItm_Click);
            // 
            // mnuMainMouserItm
            // 
            this.mnuMainMouserItm.Name = "mnuMainMouserItm";
            this.mnuMainMouserItm.Size = new System.Drawing.Size(143, 22);
            this.mnuMainMouserItm.Text = "&Mouser";
            this.mnuMainMouserItm.Click += new System.EventHandler(this.mnuMainMouserItm_Click);
            // 
            // mnuMainHelpItm
            // 
            this.mnuMainHelpItm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainAboutItm});
            this.mnuMainHelpItm.Name = "mnuMainHelpItm";
            this.mnuMainHelpItm.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelpItm.Text = "&Help";
            // 
            // mnuMainAboutItm
            // 
            this.mnuMainAboutItm.Name = "mnuMainAboutItm";
            this.mnuMainAboutItm.Size = new System.Drawing.Size(107, 22);
            this.mnuMainAboutItm.Text = "&About";
            this.mnuMainAboutItm.Click += new System.EventHandler(this.mnuMainAboutItm_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 20;
            this.lbxResults.Location = new System.Drawing.Point(12, 67);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(215, 264);
            this.lbxResults.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(243, 139);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 40);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "&Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(354, 139);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(105, 40);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContains.Location = new System.Drawing.Point(243, 212);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(105, 40);
            this.btnContains.TabIndex = 4;
            this.btnContains.Text = "&Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(354, 212);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(105, 40);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(295, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(240, 109);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 13);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "label1";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(243, 67);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(172, 20);
            this.tbxInput.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainGoToItm;
        private System.Windows.Forms.ToolStripMenuItem mnuMainInOutItm;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMouserItm;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelpItm;
        private System.Windows.Forms.ToolStripMenuItem mnuMainAboutItm;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbxInput;
    }
}

