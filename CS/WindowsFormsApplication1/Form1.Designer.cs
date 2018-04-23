namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCreateCustomTableStyle = new System.Windows.Forms.Button();
            this.btnDuplicateTableStyle = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnChangeDefaultStyle = new System.Windows.Forms.Button();
            this.btnCreateNewTable = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBuiltInTableStyles = new DevExpress.XtraEditors.ComboBoxEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuiltInTableStyles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl1.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Size = new System.Drawing.Size(743, 515);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.comboBuiltInTableStyles);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1062, 515);
            this.splitContainerControl1.SplitterPosition = 315;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 487);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(315, 28);
            this.panelControl1.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(78, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "None";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Default Style:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCreateCustomTableStyle);
            this.groupControl3.Controls.Add(this.btnDuplicateTableStyle);
            this.groupControl3.Location = new System.Drawing.Point(12, 168);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(285, 128);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Custom Table Style";
            // 
            // btnCreateCustomTableStyle
            // 
            this.btnCreateCustomTableStyle.Location = new System.Drawing.Point(9, 90);
            this.btnCreateCustomTableStyle.Name = "btnCreateCustomTableStyle";
            this.btnCreateCustomTableStyle.Size = new System.Drawing.Size(266, 23);
            this.btnCreateCustomTableStyle.TabIndex = 2;
            this.btnCreateCustomTableStyle.Text = "Create and apply a custom table style";
            this.btnCreateCustomTableStyle.UseVisualStyleBackColor = true;
            this.btnCreateCustomTableStyle.Click += new System.EventHandler(this.btnCreateCustomTableStyle_Click);
            // 
            // btnDuplicateTableStyle
            // 
            this.btnDuplicateTableStyle.Location = new System.Drawing.Point(9, 20);
            this.btnDuplicateTableStyle.Name = "btnDuplicateTableStyle";
            this.btnDuplicateTableStyle.Size = new System.Drawing.Size(266, 64);
            this.btnDuplicateTableStyle.TabIndex = 1;
            this.btnDuplicateTableStyle.Text = "Duplicate and modify the selected built-in table style.\r\nApply the new style to a" +
    " table.";
            this.btnDuplicateTableStyle.UseVisualStyleBackColor = true;
            this.btnDuplicateTableStyle.Click += new System.EventHandler(this.btnDuplicateTableStyle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnChangeDefaultStyle);
            this.groupControl2.Controls.Add(this.btnCreateNewTable);
            this.groupControl2.Location = new System.Drawing.Point(12, 61);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(285, 88);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Default Style";
            // 
            // btnChangeDefaultStyle
            // 
            this.btnChangeDefaultStyle.Location = new System.Drawing.Point(8, 21);
            this.btnChangeDefaultStyle.Name = "btnChangeDefaultStyle";
            this.btnChangeDefaultStyle.Size = new System.Drawing.Size(267, 23);
            this.btnChangeDefaultStyle.TabIndex = 3;
            this.btnChangeDefaultStyle.Text = "Set the selected table style as default ";
            this.btnChangeDefaultStyle.UseVisualStyleBackColor = true;
            this.btnChangeDefaultStyle.Click += new System.EventHandler(this.btnChangeDefaultStyle_Click);
            // 
            // btnCreateNewTable
            // 
            this.btnCreateNewTable.Location = new System.Drawing.Point(8, 50);
            this.btnCreateNewTable.Name = "btnCreateNewTable";
            this.btnCreateNewTable.Size = new System.Drawing.Size(267, 23);
            this.btnCreateNewTable.TabIndex = 6;
            this.btnCreateNewTable.Text = "Create a new table using default style";
            this.btnCreateNewTable.UseVisualStyleBackColor = true;
            this.btnCreateNewTable.Click += new System.EventHandler(this.btnCreateNewTable_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Select Built-In Table Style:";
            // 
            // comboBuiltInTableStyles
            // 
            this.comboBuiltInTableStyles.Location = new System.Drawing.Point(165, 12);
            this.comboBuiltInTableStyles.Name = "comboBuiltInTableStyles";
            this.comboBuiltInTableStyles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.comboBuiltInTableStyles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuiltInTableStyles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBuiltInTableStyles.Size = new System.Drawing.Size(122, 22);
            this.comboBuiltInTableStyles.TabIndex = 4;
            this.comboBuiltInTableStyles.SelectedIndexChanged += new System.EventHandler(this.comboBuiltInTableStyles_SelectedIndexChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 515);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBuiltInTableStyles.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button btnDuplicateTableStyle;
        private System.Windows.Forms.Button btnCreateCustomTableStyle;
        private System.Windows.Forms.Button btnChangeDefaultStyle;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuiltInTableStyles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnCreateNewTable;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

