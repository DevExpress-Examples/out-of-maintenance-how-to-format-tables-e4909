Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors.Controls

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private workbook As IWorkbook
        Private table As Table
        Public Sub New()
            InitializeComponent()
            workbook = spreadsheetControl1.Document

            GetDataFromDataTable(workbook)
            table = CreateTable(workbook)
            ApplyInitialBuiltInTableStyle()
            PopulateComboBoxWithBuiltInTableStyles(workbook)
            AddHandler comboBuiltInTableStyles.SelectedIndexChanged, AddressOf comboBuiltInTableStyles_SelectedIndexChanged
        End Sub

        Private Sub comboBuiltInTableStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            workbook.BeginUpdate()
            Try
                ' Get the name of the table style to be applied to a table
                ' (from the combo box that lists all built-in table styles).
                Dim styleName As String = comboBuiltInTableStyles.SelectedItem.ToString()

                ApplyBuiltInTableStyle(workbook, table, styleName)
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub btnChangeDefaultStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChangeDefaultStyle.Click
            If comboBuiltInTableStyles.SelectedItem Is Nothing Then
                Return
            End If
            Dim styleName As String = comboBuiltInTableStyles.SelectedItem.ToString()
            ChangeDefaultTableStyle(workbook, styleName)
            labelControl3.Text = workbook.TableStyles.DefaultStyle.Name
        End Sub

        Private Sub btnCreateNewTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateNewTable.Click
            ' Create a new table including the cell range that is currently selected in the spreadsheet control.
            ' The default style (workbook.TableStyles.DefaultStyle) is automatically applied to the created table.
            Try
                Dim newTable As Table = workbook.Worksheets.ActiveWorksheet.Tables.Add(spreadsheetControl1.Selection, True)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub btnDuplicateTableStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDuplicateTableStyle.Click
            workbook.BeginUpdate()
            Try
                ' Get the name of the table style to be duplicated 
                ' (from the combo box that lists all built-in table styles).
                Dim styleName As String = comboBuiltInTableStyles.SelectedItem.ToString()

                Dim newTableStyle As TableStyle = DuplicateAndModifyTableStyle(workbook, styleName)
                table.Style = newTableStyle
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub btnCreateCustomTableStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateCustomTableStyle.Click
            workbook.BeginUpdate()
            Try
                Dim customStyle As TableStyle = CreateCustomTableStyle(workbook, table)
                table.Style = customStyle
                table.ShowTableStyleRowStripes = True
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        #Region "#PopulateComboBoxWithBuiltInTableStyles"
        Private Sub PopulateComboBoxWithBuiltInTableStyles(ByVal workbook As IWorkbook)
            ' Add names of all built-in table styles contained in the workbook to the combo box.
            Dim comboBoxItems As ComboBoxItemCollection = comboBuiltInTableStyles.Properties.Items
            comboBoxItems.BeginUpdate()
            Try
                Dim builtInTableStyleIds As Array = System.Enum.GetValues(GetType(BuiltInTableStyleId))
                For i As Integer = 0 To builtInTableStyleIds.Length - 1
                    comboBoxItems.Add(workbook.TableStyles(DirectCast(builtInTableStyleIds.GetValue(i), BuiltInTableStyleId)).Name)
                Next i
            Finally
                comboBoxItems.EndUpdate()
            End Try
        End Sub
        #End Region ' #PopulateComboBoxWithBuiltInTableStyles

        #Region "#GetDataFromDataTable"
        Private Sub GetDataFromDataTable(ByVal workbook As IWorkbook)
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            Dim sourceTable As DataTable = CreateDataTable()
            spreadsheetControl1.BeginUpdate()
            For j As Integer = 0 To sourceTable.Columns.Count - 1
                worksheet.Cells(1, j + 1).SetValue(sourceTable.Columns(j).ColumnName)
            Next j
            For i As Integer = 0 To sourceTable.Rows.Count - 1
                For j As Integer = 0 To sourceTable.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1).SetValue(sourceTable.Rows(i)(j))
                Next j
            Next i
            spreadsheetControl1.EndUpdate()
        End Sub
        #End Region ' #GetDataFromDataTable

        #Region "#CreateTable"
        Private Function CreateTable(ByVal workbook As IWorkbook) As Table
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            ' Create a table in the worksheet.
            Dim table As Table = worksheet.Tables.Add(worksheet("B2:F5"), True)
            table.Columns(0).Name = "Product"
            table.Columns(1).Name = "Price"
            table.Columns(2).Name = "Quantity"
            table.Columns(3).Name = "Discount"
            table.Columns(4).Name = "Amount"
            table.ShowTotals = True
            ' Set the label and a function to display the sum of the "Amount" column.
            table.Columns(4).Formula = "=[Price]*[Quantity]*(1-[Discount])"
            table.Columns(4).TotalRowFunction = TotalRowFunction.Sum
            table.Columns(3).TotalRowLabel = "Total:"
            ' Specify the number format for each column.
            table.Columns(1).DataRange.NumberFormat = "$#,##0.00"
            table.Columns(3).DataRange.NumberFormat = "0.0%"
            table.Columns(4).Range.NumberFormat = "$#,##0.00;$#,##0.00;"""";@"
            ' Specify horizontal alignment for header and total rows of the table.
            table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            ' Specify horizontal alignment to display data in all columns except the first one.
            For i As Integer = 1 To table.Columns.Count - 1
                table.Columns(i).DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            Next i
            ' Set the table column width.
            table.Range.ColumnWidthInCharacters = 12
            Return table
        End Function
        #End Region ' #CreateTable

        Private Shared Function CreateDataTable() As DataTable
            ' Create the "Products" DataTable object with four columns.
            Dim sourceTable As New DataTable("Products")
            sourceTable.Columns.Add("Product", GetType(String))
            sourceTable.Columns.Add("Price", GetType(Single))
            sourceTable.Columns.Add("Quantity", GetType(Int32))
            sourceTable.Columns.Add("Discount", GetType(Single))

            sourceTable.Rows.Add("Chocolade", 5, 15, 0.03)
            sourceTable.Rows.Add("Konbu", 9, 55, 0.1)
            sourceTable.Rows.Add("Geitost", 15, 70, 0.07)
            Return sourceTable
        End Function

        Private Sub ApplyInitialBuiltInTableStyle()
'            #Region "#ApplyInitialBuiltInTableStyle"
            spreadsheetControl1.BeginUpdate()
            ' Access the workbook's collection of table styles.
            Dim tableStyles As TableStyleCollection = spreadsheetControl1.Document.TableStyles
            ' Access the built-in table style from the collection by its Id.
            Dim tableStyle As TableStyle = tableStyles(BuiltInTableStyleId.TableStyleDark9)

            ' Apply the table style to the existing table.
            Dim myTable As Table = spreadsheetControl1.ActiveWorksheet.Tables(0)
            myTable.Style = tableStyle

            ' Show header and total rows.
            myTable.ShowHeaders = True
            myTable.ShowTotals = True
            ' Apply banded column formatting to the table.
            myTable.ShowTableStyleRowStripes = False
            myTable.ShowTableStyleColumnStripes = True

            spreadsheetControl1.EndUpdate()
'            #End Region ' #ApplyInitialBuiltInTableStyle
        End Sub


        #Region "#ApplyBuiltInTableStyle"
        Private Sub ApplyBuiltInTableStyle(ByVal workbook As IWorkbook, ByVal table As Table, ByVal styleName As String)
            ' Access the workbook's collection of table styles.
            Dim tableStyles As TableStyleCollection = workbook.TableStyles

            ' Access the built-in table style from the collection by its name.
            Dim tableStyle As TableStyle = tableStyles(styleName)

            ' Apply the table style to the existing table.
            table.Style = tableStyle

            ' Show header and total rows.
            table.ShowHeaders = True
            table.ShowTotals = True

            ' Apply banded column formatting to the table.
            table.ShowTableStyleRowStripes = False
            table.ShowTableStyleColumnStripes = True
        End Sub
        #End Region ' #ApplyBuiltInTableStyle

        #Region "#ChangeDefaultTableStyle"
        Private Sub ChangeDefaultTableStyle(ByVal workbook As IWorkbook, ByVal styleName As String)
            ' Set the style to be applied to created tables by default.
            workbook.TableStyles.DefaultStyle = workbook.TableStyles(styleName)
        End Sub
        #End Region ' #ChangeDefaultTableStyle

        #Region "#DuplicateAndModifyStyle"
        Private Function DuplicateAndModifyTableStyle(ByVal workbook As IWorkbook, ByVal sourceStyleName As String) As TableStyle
            ' Get the table style to be duplicated.
            Dim sourceTableStyle As TableStyle = workbook.TableStyles(sourceStyleName)

            ' Duplicate the table style.
            Dim newTableStyle As TableStyle = sourceTableStyle.Duplicate()

            ' Modify the required formatting characteristics of the created table style.
            ' For example, remove exisitng formatting from the header row element.
            newTableStyle.TableStyleElements(TableStyleElementType.HeaderRow).Clear()

            Return newTableStyle
        End Function
        #End Region ' #DuplicateAndModifyStyle

        #Region "#CreateCustomStyle"
        Private Function CreateCustomTableStyle(ByVal workbook As IWorkbook, ByVal table As Table) As TableStyle
            Dim styleName As String = "testTableStyle"

            ' If the style under the specified name already exists in the collection, return this style.
            If workbook.TableStyles.Contains(styleName) Then
                Return workbook.TableStyles(styleName)
            Else
                ' Add a new table style under the "testTableStyle" name to the TableStyles collection.
                Dim customTableStyle As TableStyle = workbook.TableStyles.Add("testTableStyle")

                ' Modify the required formatting characteristics of the table style. 
                ' Specify the format for different table elements.
                customTableStyle.BeginUpdate()
                Try
                    customTableStyle.TableStyleElements(TableStyleElementType.WholeTable).Font.Color = Color.FromArgb(107, 107, 107)

                    ' Specify formatting characteristics for the table header row. 
                    Dim headerRowStyle As TableStyleElement = customTableStyle.TableStyleElements(TableStyleElementType.HeaderRow)
                    headerRowStyle.Fill.BackgroundColor = Color.FromArgb(64, 66, 166)
                    headerRowStyle.Font.Color = Color.White
                    headerRowStyle.Font.Bold = True

                    ' Specify formatting characteristics for the table total row. 
                    Dim totalRowStyle As TableStyleElement = customTableStyle.TableStyleElements(TableStyleElementType.TotalRow)
                    totalRowStyle.Fill.BackgroundColor = Color.FromArgb(115, 193, 211)
                    totalRowStyle.Font.Color = Color.White
                    totalRowStyle.Font.Bold = True

                    ' Specify banded row formatting for the table.
                    Dim secondRowStripeStyle As TableStyleElement = customTableStyle.TableStyleElements(TableStyleElementType.SecondRowStripe)
                    secondRowStripeStyle.Fill.BackgroundColor = Color.FromArgb(234, 234, 234)
                    secondRowStripeStyle.StripeSize = 1
                Finally
                    customTableStyle.EndUpdate()
                End Try
                Return customTableStyle
            End If
        End Function
        #End Region ' #CreateCustomStyle

    End Class
End Namespace