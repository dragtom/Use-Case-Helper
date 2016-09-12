namespace Use_Case_helper
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
            this.lbExistingSymbols = new System.Windows.Forms.ListBox();
            this.pnlDrawSpace = new System.Windows.Forms.Panel();
            this.gbElements = new System.Windows.Forms.GroupBox();
            this.rbAddLine = new System.Windows.Forms.RadioButton();
            this.rbAddUseCase = new System.Windows.Forms.RadioButton();
            this.rbAddActor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModeSelect = new System.Windows.Forms.RadioButton();
            this.rbModeAdd = new System.Windows.Forms.RadioButton();
            this.lblEditX1 = new System.Windows.Forms.Label();
            this.tbEditX1 = new System.Windows.Forms.TextBox();
            this.tbEditY1 = new System.Windows.Forms.TextBox();
            this.lblEditY1 = new System.Windows.Forms.Label();
            this.tbEditX2 = new System.Windows.Forms.TextBox();
            this.lblEditX2 = new System.Windows.Forms.Label();
            this.tbEditY2 = new System.Windows.Forms.TextBox();
            this.lblEditY2 = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditText = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbElements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbExistingSymbols
            // 
            this.lbExistingSymbols.FormattingEnabled = true;
            this.lbExistingSymbols.ItemHeight = 16;
            this.lbExistingSymbols.Location = new System.Drawing.Point(1019, 12);
            this.lbExistingSymbols.Name = "lbExistingSymbols";
            this.lbExistingSymbols.Size = new System.Drawing.Size(131, 772);
            this.lbExistingSymbols.TabIndex = 0;
            this.lbExistingSymbols.SelectedIndexChanged += new System.EventHandler(this.lbExistingSymbols_SelectedIndexChanged);
            // 
            // pnlDrawSpace
            // 
            this.pnlDrawSpace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDrawSpace.Location = new System.Drawing.Point(12, 133);
            this.pnlDrawSpace.Name = "pnlDrawSpace";
            this.pnlDrawSpace.Size = new System.Drawing.Size(1000, 650);
            this.pnlDrawSpace.TabIndex = 1;
            this.pnlDrawSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawSpace_Paint);
            this.pnlDrawSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDrawSpace_MouseClick);
            // 
            // gbElements
            // 
            this.gbElements.Controls.Add(this.rbAddLine);
            this.gbElements.Controls.Add(this.rbAddUseCase);
            this.gbElements.Controls.Add(this.rbAddActor);
            this.gbElements.Location = new System.Drawing.Point(146, 12);
            this.gbElements.Name = "gbElements";
            this.gbElements.Size = new System.Drawing.Size(128, 100);
            this.gbElements.TabIndex = 2;
            this.gbElements.TabStop = false;
            this.gbElements.Text = "Elements";
            this.gbElements.Enter += new System.EventHandler(this.gbElements_Enter);
            // 
            // rbAddLine
            // 
            this.rbAddLine.AutoSize = true;
            this.rbAddLine.Location = new System.Drawing.Point(6, 73);
            this.rbAddLine.Name = "rbAddLine";
            this.rbAddLine.Size = new System.Drawing.Size(56, 21);
            this.rbAddLine.TabIndex = 5;
            this.rbAddLine.Text = "Line";
            this.rbAddLine.UseVisualStyleBackColor = true;
            // 
            // rbAddUseCase
            // 
            this.rbAddUseCase.AutoSize = true;
            this.rbAddUseCase.Location = new System.Drawing.Point(6, 48);
            this.rbAddUseCase.Name = "rbAddUseCase";
            this.rbAddUseCase.Size = new System.Drawing.Size(90, 21);
            this.rbAddUseCase.TabIndex = 4;
            this.rbAddUseCase.Text = "Use Case";
            this.rbAddUseCase.UseVisualStyleBackColor = true;
            // 
            // rbAddActor
            // 
            this.rbAddActor.AutoSize = true;
            this.rbAddActor.Checked = true;
            this.rbAddActor.Location = new System.Drawing.Point(6, 21);
            this.rbAddActor.Name = "rbAddActor";
            this.rbAddActor.Size = new System.Drawing.Size(62, 21);
            this.rbAddActor.TabIndex = 3;
            this.rbAddActor.TabStop = true;
            this.rbAddActor.Text = "Actor";
            this.rbAddActor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbModeSelect);
            this.groupBox1.Controls.Add(this.rbModeAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rbModeSelect
            // 
            this.rbModeSelect.AutoSize = true;
            this.rbModeSelect.Location = new System.Drawing.Point(6, 48);
            this.rbModeSelect.Name = "rbModeSelect";
            this.rbModeSelect.Size = new System.Drawing.Size(68, 21);
            this.rbModeSelect.TabIndex = 5;
            this.rbModeSelect.Text = "Select";
            this.rbModeSelect.UseVisualStyleBackColor = true;
            // 
            // rbModeAdd
            // 
            this.rbModeAdd.AutoSize = true;
            this.rbModeAdd.Checked = true;
            this.rbModeAdd.Location = new System.Drawing.Point(6, 21);
            this.rbModeAdd.Name = "rbModeAdd";
            this.rbModeAdd.Size = new System.Drawing.Size(54, 21);
            this.rbModeAdd.TabIndex = 4;
            this.rbModeAdd.TabStop = true;
            this.rbModeAdd.Text = "Add";
            this.rbModeAdd.UseVisualStyleBackColor = true;
            // 
            // lblEditX1
            // 
            this.lblEditX1.AutoSize = true;
            this.lblEditX1.Location = new System.Drawing.Point(280, 12);
            this.lblEditX1.Name = "lblEditX1";
            this.lblEditX1.Size = new System.Drawing.Size(22, 17);
            this.lblEditX1.TabIndex = 6;
            this.lblEditX1.Text = "x1";
            this.lblEditX1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEditX1
            // 
            this.tbEditX1.Location = new System.Drawing.Point(308, 9);
            this.tbEditX1.Name = "tbEditX1";
            this.tbEditX1.Size = new System.Drawing.Size(50, 22);
            this.tbEditX1.TabIndex = 7;
            // 
            // tbEditY1
            // 
            this.tbEditY1.Location = new System.Drawing.Point(308, 37);
            this.tbEditY1.Name = "tbEditY1";
            this.tbEditY1.Size = new System.Drawing.Size(50, 22);
            this.tbEditY1.TabIndex = 9;
            // 
            // lblEditY1
            // 
            this.lblEditY1.AutoSize = true;
            this.lblEditY1.Location = new System.Drawing.Point(280, 40);
            this.lblEditY1.Name = "lblEditY1";
            this.lblEditY1.Size = new System.Drawing.Size(23, 17);
            this.lblEditY1.TabIndex = 8;
            this.lblEditY1.Text = "y1";
            // 
            // tbEditX2
            // 
            this.tbEditX2.Location = new System.Drawing.Point(308, 65);
            this.tbEditX2.Name = "tbEditX2";
            this.tbEditX2.Size = new System.Drawing.Size(50, 22);
            this.tbEditX2.TabIndex = 11;
            // 
            // lblEditX2
            // 
            this.lblEditX2.AutoSize = true;
            this.lblEditX2.Location = new System.Drawing.Point(280, 68);
            this.lblEditX2.Name = "lblEditX2";
            this.lblEditX2.Size = new System.Drawing.Size(22, 17);
            this.lblEditX2.TabIndex = 10;
            this.lblEditX2.Text = "x2";
            // 
            // tbEditY2
            // 
            this.tbEditY2.Location = new System.Drawing.Point(308, 93);
            this.tbEditY2.Name = "tbEditY2";
            this.tbEditY2.Size = new System.Drawing.Size(50, 22);
            this.tbEditY2.TabIndex = 13;
            // 
            // lblEditY2
            // 
            this.lblEditY2.AutoSize = true;
            this.lblEditY2.Location = new System.Drawing.Point(280, 96);
            this.lblEditY2.Name = "lblEditY2";
            this.lblEditY2.Size = new System.Drawing.Size(23, 17);
            this.lblEditY2.TabIndex = 12;
            this.lblEditY2.Text = "y2";
            // 
            // tbEditName
            // 
            this.tbEditName.Location = new System.Drawing.Point(423, 9);
            this.tbEditName.Multiline = true;
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(123, 58);
            this.tbEditName.TabIndex = 14;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(364, 12);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(53, 17);
            this.lblEditName.TabIndex = 15;
            this.lblEditName.Text = "Name /";
            // 
            // lblEditText
            // 
            this.lblEditText.AutoSize = true;
            this.lblEditText.Location = new System.Drawing.Point(387, 33);
            this.lblEditText.Name = "lblEditText";
            this.lblEditText.Size = new System.Drawing.Size(30, 17);
            this.lblEditText.TabIndex = 16;
            this.lblEditText.Text = "text";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(938, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(938, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 795);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEditText);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.tbEditName);
            this.Controls.Add(this.tbEditY2);
            this.Controls.Add(this.lblEditY2);
            this.Controls.Add(this.tbEditX2);
            this.Controls.Add(this.lblEditX2);
            this.Controls.Add(this.tbEditY1);
            this.Controls.Add(this.lblEditY1);
            this.Controls.Add(this.tbEditX1);
            this.Controls.Add(this.lblEditX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbElements);
            this.Controls.Add(this.lbExistingSymbols);
            this.Controls.Add(this.pnlDrawSpace);
            this.Name = "frmMain";
            this.Text = "Use Case Helper Main";
            this.gbElements.ResumeLayout(false);
            this.gbElements.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbExistingSymbols;
        private System.Windows.Forms.Panel pnlDrawSpace;
        private System.Windows.Forms.GroupBox gbElements;
        private System.Windows.Forms.RadioButton rbAddLine;
        private System.Windows.Forms.RadioButton rbAddUseCase;
        private System.Windows.Forms.RadioButton rbAddActor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModeSelect;
        private System.Windows.Forms.RadioButton rbModeAdd;
        private System.Windows.Forms.Label lblEditX1;
        private System.Windows.Forms.TextBox tbEditX1;
        private System.Windows.Forms.TextBox tbEditY1;
        private System.Windows.Forms.Label lblEditY1;
        private System.Windows.Forms.TextBox tbEditX2;
        private System.Windows.Forms.Label lblEditX2;
        private System.Windows.Forms.TextBox tbEditY2;
        private System.Windows.Forms.Label lblEditY2;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

