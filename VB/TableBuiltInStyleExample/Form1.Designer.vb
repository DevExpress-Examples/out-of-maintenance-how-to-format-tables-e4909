Namespace WindowsFormsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.btnCreateCustomTableStyle = New System.Windows.Forms.Button()
            Me.btnDuplicateTableStyle = New System.Windows.Forms.Button()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.btnChangeDefaultStyle = New System.Windows.Forms.Button()
            Me.btnCreateNewTable = New System.Windows.Forms.Button()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.comboBuiltInTableStyles = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            DirectCast(Me.comboBuiltInTableStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
            Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Size = New System.Drawing.Size(623, 382)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.groupControl3)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.groupControl2)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.labelControl1)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.comboBuiltInTableStyles)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(950, 382)
            Me.splitContainerControl1.SplitterPosition = 315
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl3)
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 354)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(315, 28)
            Me.panelControl1.TabIndex = 12
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl3.Appearance.Options.UseFont = True
            Me.labelControl3.Location = New System.Drawing.Point(78, 6)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(28, 13)
            Me.labelControl3.TabIndex = 8
            Me.labelControl3.Text = "None"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(6, 6)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(66, 13)
            Me.labelControl2.TabIndex = 7
            Me.labelControl2.Text = "Default Style:"
            ' 
            ' groupControl3
            ' 
            Me.groupControl3.Controls.Add(Me.btnCreateCustomTableStyle)
            Me.groupControl3.Controls.Add(Me.btnDuplicateTableStyle)
            Me.groupControl3.Location = New System.Drawing.Point(12, 168)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(285, 128)
            Me.groupControl3.TabIndex = 11
            Me.groupControl3.Text = "Custom Table Style"
            ' 
            ' btnCreateCustomTableStyle
            ' 
            Me.btnCreateCustomTableStyle.Location = New System.Drawing.Point(9, 90)
            Me.btnCreateCustomTableStyle.Name = "btnCreateCustomTableStyle"
            Me.btnCreateCustomTableStyle.Size = New System.Drawing.Size(266, 23)
            Me.btnCreateCustomTableStyle.TabIndex = 2
            Me.btnCreateCustomTableStyle.Text = "Create and apply a custom table style"
            Me.btnCreateCustomTableStyle.UseVisualStyleBackColor = True
            ' 
            ' btnDuplicateTableStyle
            ' 
            Me.btnDuplicateTableStyle.Location = New System.Drawing.Point(9, 20)
            Me.btnDuplicateTableStyle.Name = "btnDuplicateTableStyle"
            Me.btnDuplicateTableStyle.Size = New System.Drawing.Size(266, 64)
            Me.btnDuplicateTableStyle.TabIndex = 1
            Me.btnDuplicateTableStyle.Text = "Duplicate and modify the selected built-in table style." & ControlChars.CrLf & "Apply the new style to a" & " table."
            Me.btnDuplicateTableStyle.UseVisualStyleBackColor = True
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Controls.Add(Me.btnChangeDefaultStyle)
            Me.groupControl2.Controls.Add(Me.btnCreateNewTable)
            Me.groupControl2.Location = New System.Drawing.Point(12, 61)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(285, 88)
            Me.groupControl2.TabIndex = 10
            Me.groupControl2.Text = "Default Style"
            ' 
            ' btnChangeDefaultStyle
            ' 
            Me.btnChangeDefaultStyle.Location = New System.Drawing.Point(8, 21)
            Me.btnChangeDefaultStyle.Name = "btnChangeDefaultStyle"
            Me.btnChangeDefaultStyle.Size = New System.Drawing.Size(267, 23)
            Me.btnChangeDefaultStyle.TabIndex = 3
            Me.btnChangeDefaultStyle.Text = "Set the selected table style as default "
            Me.btnChangeDefaultStyle.UseVisualStyleBackColor = True
            ' 
            ' btnCreateNewTable
            ' 
            Me.btnCreateNewTable.Location = New System.Drawing.Point(8, 50)
            Me.btnCreateNewTable.Name = "btnCreateNewTable"
            Me.btnCreateNewTable.Size = New System.Drawing.Size(267, 23)
            Me.btnCreateNewTable.TabIndex = 6
            Me.btnCreateNewTable.Text = "Create a new table using default style"
            Me.btnCreateNewTable.UseVisualStyleBackColor = True
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(21, 13)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(126, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "Select Built-In Table Style:"
            ' 
            ' comboBuiltInTableStyles
            ' 
            Me.comboBuiltInTableStyles.Location = New System.Drawing.Point(165, 12)
            Me.comboBuiltInTableStyles.Name = "comboBuiltInTableStyles"
            Me.comboBuiltInTableStyles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.comboBuiltInTableStyles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBuiltInTableStyles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBuiltInTableStyles.Size = New System.Drawing.Size(122, 20)
            Me.comboBuiltInTableStyles.TabIndex = 4
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(950, 382)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "TableBuiltInStyleExample"
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            DirectCast(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            DirectCast(Me.comboBuiltInTableStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents btnDuplicateTableStyle As System.Windows.Forms.Button
        Private WithEvents btnCreateCustomTableStyle As System.Windows.Forms.Button
        Private WithEvents btnChangeDefaultStyle As System.Windows.Forms.Button
        Private comboBuiltInTableStyles As DevExpress.XtraEditors.ComboBoxEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents btnCreateNewTable As System.Windows.Forms.Button
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private groupControl3 As DevExpress.XtraEditors.GroupControl
        Private groupControl2 As DevExpress.XtraEditors.GroupControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

