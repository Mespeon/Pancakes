<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.tbcTransactionsWindow = New System.Windows.Forms.TabControl()
        Me.tabTransactions = New System.Windows.Forms.TabPage()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransactionList = New System.Windows.Forms.Label()
        Me.dgvTransactionItems = New System.Windows.Forms.DataGridView()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.tabDatabase = New System.Windows.Forms.TabPage()
        Me.btnRefreshDb = New System.Windows.Forms.Button()
        Me.btnViewDb = New System.Windows.Forms.Button()
        Me.pnlDatabaseQuickView = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTransactions2 = New System.Windows.Forms.DataGridView()
        Me.tbcTransactionsWindow.SuspendLayout()
        Me.tabTransactions.SuspendLayout()
        CType(Me.dgvTransactionItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatabase.SuspendLayout()
        Me.pnlDatabaseQuickView.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.Location = New System.Drawing.Point(8, 3)
        Me.lblTransactions.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(210, 47)
        Me.lblTransactions.TabIndex = 1
        Me.lblTransactions.Text = "Transactions"
        '
        'tbcTransactionsWindow
        '
        Me.tbcTransactionsWindow.Controls.Add(Me.tabTransactions)
        Me.tbcTransactionsWindow.Controls.Add(Me.tabDatabase)
        Me.tbcTransactionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcTransactionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tbcTransactionsWindow.Name = "tbcTransactionsWindow"
        Me.tbcTransactionsWindow.SelectedIndex = 0
        Me.tbcTransactionsWindow.Size = New System.Drawing.Size(884, 641)
        Me.tbcTransactionsWindow.TabIndex = 3
        '
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.btnRefresh)
        Me.tabTransactions.Controls.Add(Me.Label1)
        Me.tabTransactions.Controls.Add(Me.lblTransactionList)
        Me.tabTransactions.Controls.Add(Me.dgvTransactionItems)
        Me.tabTransactions.Controls.Add(Me.dgvTransactions)
        Me.tabTransactions.Controls.Add(Me.lblTransactions)
        Me.tabTransactions.Location = New System.Drawing.Point(4, 26)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransactions.Size = New System.Drawing.Size(876, 611)
        Me.tabTransactions.TabIndex = 0
        Me.tabTransactions.Text = "Transactions"
        Me.tabTransactions.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(717, 42)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(138, 35)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 327)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Items in this Transaction"
        '
        'lblTransactionList
        '
        Me.lblTransactionList.AutoSize = True
        Me.lblTransactionList.Location = New System.Drawing.Point(13, 60)
        Me.lblTransactionList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.lblTransactionList.Name = "lblTransactionList"
        Me.lblTransactionList.Size = New System.Drawing.Size(119, 17)
        Me.lblTransactionList.TabIndex = 5
        Me.lblTransactionList.Text = "Saved Transactions"
        '
        'dgvTransactionItems
        '
        Me.dgvTransactionItems.AllowUserToAddRows = False
        Me.dgvTransactionItems.AllowUserToDeleteRows = False
        Me.dgvTransactionItems.AllowUserToResizeColumns = False
        Me.dgvTransactionItems.AllowUserToResizeRows = False
        Me.dgvTransactionItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactionItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTransactionItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactionItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransactionItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvTransactionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactionItems.EnableHeadersVisualStyles = False
        Me.dgvTransactionItems.Location = New System.Drawing.Point(16, 357)
        Me.dgvTransactionItems.MultiSelect = False
        Me.dgvTransactionItems.Name = "dgvTransactionItems"
        Me.dgvTransactionItems.ReadOnly = True
        Me.dgvTransactionItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactionItems.RowHeadersVisible = False
        Me.dgvTransactionItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTransactionItems.ShowEditingIcon = False
        Me.dgvTransactionItems.Size = New System.Drawing.Size(839, 229)
        Me.dgvTransactionItems.TabIndex = 4
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.AllowUserToResizeColumns = False
        Me.dgvTransactions.AllowUserToResizeRows = False
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions.EnableHeadersVisualStyles = False
        Me.dgvTransactions.Location = New System.Drawing.Point(16, 90)
        Me.dgvTransactions.MultiSelect = False
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTransactions.ShowEditingIcon = False
        Me.dgvTransactions.Size = New System.Drawing.Size(839, 229)
        Me.dgvTransactions.TabIndex = 3
        '
        'tabDatabase
        '
        Me.tabDatabase.Controls.Add(Me.btnRefreshDb)
        Me.tabDatabase.Controls.Add(Me.btnViewDb)
        Me.tabDatabase.Controls.Add(Me.pnlDatabaseQuickView)
        Me.tabDatabase.Location = New System.Drawing.Point(4, 26)
        Me.tabDatabase.Name = "tabDatabase"
        Me.tabDatabase.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatabase.Size = New System.Drawing.Size(876, 611)
        Me.tabDatabase.TabIndex = 1
        Me.tabDatabase.Text = "Database Quick View"
        Me.tabDatabase.UseVisualStyleBackColor = True
        '
        'btnRefreshDb
        '
        Me.btnRefreshDb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefreshDb.FlatAppearance.BorderSize = 0
        Me.btnRefreshDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshDb.ForeColor = System.Drawing.Color.White
        Me.btnRefreshDb.Location = New System.Drawing.Point(730, 13)
        Me.btnRefreshDb.Name = "btnRefreshDb"
        Me.btnRefreshDb.Size = New System.Drawing.Size(138, 35)
        Me.btnRefreshDb.TabIndex = 9
        Me.btnRefreshDb.Text = "Refresh"
        Me.btnRefreshDb.UseVisualStyleBackColor = False
        Me.btnRefreshDb.Visible = False
        '
        'btnViewDb
        '
        Me.btnViewDb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewDb.FlatAppearance.BorderSize = 0
        Me.btnViewDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDb.ForeColor = System.Drawing.Color.White
        Me.btnViewDb.Location = New System.Drawing.Point(8, 13)
        Me.btnViewDb.Margin = New System.Windows.Forms.Padding(3, 10, 3, 5)
        Me.btnViewDb.Name = "btnViewDb"
        Me.btnViewDb.Size = New System.Drawing.Size(261, 35)
        Me.btnViewDb.TabIndex = 8
        Me.btnViewDb.Text = "View Database Tables"
        Me.btnViewDb.UseVisualStyleBackColor = False
        '
        'pnlDatabaseQuickView
        '
        Me.pnlDatabaseQuickView.AutoScroll = True
        Me.pnlDatabaseQuickView.Controls.Add(Me.Label4)
        Me.pnlDatabaseQuickView.Controls.Add(Me.dgvUsers)
        Me.pnlDatabaseQuickView.Controls.Add(Me.Label3)
        Me.pnlDatabaseQuickView.Controls.Add(Me.dgvProducts)
        Me.pnlDatabaseQuickView.Controls.Add(Me.Label2)
        Me.pnlDatabaseQuickView.Controls.Add(Me.dgvTransactions2)
        Me.pnlDatabaseQuickView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDatabaseQuickView.Location = New System.Drawing.Point(3, 56)
        Me.pnlDatabaseQuickView.Name = "pnlDatabaseQuickView"
        Me.pnlDatabaseQuickView.Size = New System.Drawing.Size(870, 552)
        Me.pnlDatabaseQuickView.TabIndex = 0
        Me.pnlDatabaseQuickView.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 371)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Users"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeColumns = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUsers.EnableHeadersVisualStyles = False
        Me.dgvUsers.Location = New System.Drawing.Point(5, 396)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUsers.ShowEditingIcon = False
        Me.dgvUsers.Size = New System.Drawing.Size(860, 150)
        Me.dgvUsers.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Products"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.Location = New System.Drawing.Point(5, 213)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProducts.ShowEditingIcon = False
        Me.dgvProducts.Size = New System.Drawing.Size(860, 150)
        Me.dgvProducts.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Saved Transactions"
        '
        'dgvTransactions2
        '
        Me.dgvTransactions2.AllowUserToAddRows = False
        Me.dgvTransactions2.AllowUserToDeleteRows = False
        Me.dgvTransactions2.AllowUserToResizeColumns = False
        Me.dgvTransactions2.AllowUserToResizeRows = False
        Me.dgvTransactions2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTransactions2.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransactions2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvTransactions2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions2.EnableHeadersVisualStyles = False
        Me.dgvTransactions2.Location = New System.Drawing.Point(8, 30)
        Me.dgvTransactions2.MultiSelect = False
        Me.dgvTransactions2.Name = "dgvTransactions2"
        Me.dgvTransactions2.ReadOnly = True
        Me.dgvTransactions2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactions2.RowHeadersVisible = False
        Me.dgvTransactions2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTransactions2.ShowEditingIcon = False
        Me.dgvTransactions2.Size = New System.Drawing.Size(857, 150)
        Me.dgvTransactions2.TabIndex = 6
        '
        'Transactions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 641)
        Me.Controls.Add(Me.tbcTransactionsWindow)
        Me.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        Me.tbcTransactionsWindow.ResumeLayout(False)
        Me.tabTransactions.ResumeLayout(False)
        Me.tabTransactions.PerformLayout()
        CType(Me.dgvTransactionItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatabase.ResumeLayout(False)
        Me.pnlDatabaseQuickView.ResumeLayout(False)
        Me.pnlDatabaseQuickView.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTransactions As Label
    Friend WithEvents tbcTransactionsWindow As TabControl
    Friend WithEvents tabTransactions As TabPage
    Friend WithEvents tabDatabase As TabPage
    Friend WithEvents lblTransactionList As Label
    Friend WithEvents dgvTransactionItems As DataGridView
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnViewDb As Button
    Friend WithEvents pnlDatabaseQuickView As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTransactions2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnRefreshDb As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvUsers As DataGridView
End Class
