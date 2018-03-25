<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.lblSysTimeDate = New System.Windows.Forms.Label()
        Me.tmrTimeTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblBDate = New System.Windows.Forms.Label()
        Me.pnlMainPanel = New System.Windows.Forms.Panel()
        Me.pnlOrderSummary = New System.Windows.Forms.Panel()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.pnlCheckout = New System.Windows.Forms.Panel()
        Me.cbxApplySeniorDiscount = New System.Windows.Forms.CheckBox()
        Me.lblChangeAmt = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblDiscountAmt = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.pnlTransactionDetail = New System.Windows.Forms.Panel()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnClearCash = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.lblOrderSummary = New System.Windows.Forms.Label()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.lblNoItems = New System.Windows.Forms.Label()
        Me.pnlItemCategory = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSides = New System.Windows.Forms.Button()
        Me.btnPremToppings = New System.Windows.Forms.Button()
        Me.btnRegTopping = New System.Windows.Forms.Button()
        Me.btnBatter = New System.Windows.Forms.Button()
        Me.btnViewTransactions = New System.Windows.Forms.Button()
        Me.pnlMainPanel.SuspendLayout()
        Me.pnlOrderSummary.SuspendLayout()
        Me.pnlCheckout.SuspendLayout()
        Me.pnlTransactionDetail.SuspendLayout()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItems.SuspendLayout()
        Me.pnlItemCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCashier
        '
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Location = New System.Drawing.Point(417, 26)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(460, 25)
        Me.lblCashier.TabIndex = 0
        Me.lblCashier.Text = "CashierName"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.BackColor = System.Drawing.Color.Transparent
        Me.lblCashierName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierName.Location = New System.Drawing.Point(821, 9)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(51, 17)
        Me.lblCashierName.TabIndex = 1
        Me.lblCashierName.Text = "Cashier"
        '
        'lblSysTimeDate
        '
        Me.lblSysTimeDate.AutoSize = True
        Me.lblSysTimeDate.BackColor = System.Drawing.Color.Transparent
        Me.lblSysTimeDate.Location = New System.Drawing.Point(12, 30)
        Me.lblSysTimeDate.Name = "lblSysTimeDate"
        Me.lblSysTimeDate.Size = New System.Drawing.Size(110, 21)
        Me.lblSysTimeDate.TabIndex = 2
        Me.lblSysTimeDate.Text = "Time and Date"
        '
        'tmrTimeTick
        '
        Me.tmrTimeTick.Interval = 1000
        '
        'lblBDate
        '
        Me.lblBDate.AutoSize = True
        Me.lblBDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBDate.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDate.Location = New System.Drawing.Point(14, 9)
        Me.lblBDate.Name = "lblBDate"
        Me.lblBDate.Size = New System.Drawing.Size(88, 17)
        Me.lblBDate.TabIndex = 3
        Me.lblBDate.Text = "Business Date"
        '
        'pnlMainPanel
        '
        Me.pnlMainPanel.Controls.Add(Me.pnlOrderSummary)
        Me.pnlMainPanel.Controls.Add(Me.pnlItems)
        Me.pnlMainPanel.Controls.Add(Me.pnlItemCategory)
        Me.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMainPanel.Location = New System.Drawing.Point(0, 71)
        Me.pnlMainPanel.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.pnlMainPanel.Name = "pnlMainPanel"
        Me.pnlMainPanel.Size = New System.Drawing.Size(884, 590)
        Me.pnlMainPanel.TabIndex = 4
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.Controls.Add(Me.btnCheckout)
        Me.pnlOrderSummary.Controls.Add(Me.pnlCheckout)
        Me.pnlOrderSummary.Controls.Add(Me.btnRemoveItem)
        Me.pnlOrderSummary.Controls.Add(Me.dgvOrderList)
        Me.pnlOrderSummary.Controls.Add(Me.lblOrderSummary)
        Me.pnlOrderSummary.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlOrderSummary.Location = New System.Drawing.Point(417, 0)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(467, 590)
        Me.pnlOrderSummary.TabIndex = 2
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.LawnGreen
        Me.btnCheckout.Enabled = False
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(315, 262)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(140, 39)
        Me.btnCheckout.TabIndex = 9
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'pnlCheckout
        '
        Me.pnlCheckout.Controls.Add(Me.cbxApplySeniorDiscount)
        Me.pnlCheckout.Controls.Add(Me.lblChangeAmt)
        Me.pnlCheckout.Controls.Add(Me.lblChange)
        Me.pnlCheckout.Controls.Add(Me.lblDiscountAmt)
        Me.pnlCheckout.Controls.Add(Me.lblDiscount)
        Me.pnlCheckout.Controls.Add(Me.pnlTransactionDetail)
        Me.pnlCheckout.Controls.Add(Me.lblTotalAmt)
        Me.pnlCheckout.Controls.Add(Me.lblTotalAmount)
        Me.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCheckout.Enabled = False
        Me.pnlCheckout.Location = New System.Drawing.Point(0, 307)
        Me.pnlCheckout.Name = "pnlCheckout"
        Me.pnlCheckout.Size = New System.Drawing.Size(467, 283)
        Me.pnlCheckout.TabIndex = 7
        '
        'cbxApplySeniorDiscount
        '
        Me.cbxApplySeniorDiscount.AutoSize = True
        Me.cbxApplySeniorDiscount.Location = New System.Drawing.Point(11, 137)
        Me.cbxApplySeniorDiscount.Name = "cbxApplySeniorDiscount"
        Me.cbxApplySeniorDiscount.Size = New System.Drawing.Size(103, 25)
        Me.cbxApplySeniorDiscount.TabIndex = 19
        Me.cbxApplySeniorDiscount.Text = "Apply SCD"
        Me.cbxApplySeniorDiscount.UseVisualStyleBackColor = True
        '
        'lblChangeAmt
        '
        Me.lblChangeAmt.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmt.Location = New System.Drawing.Point(3, 187)
        Me.lblChangeAmt.Name = "lblChangeAmt"
        Me.lblChangeAmt.Size = New System.Drawing.Size(111, 50)
        Me.lblChangeAmt.TabIndex = 15
        Me.lblChangeAmt.Text = "0"
        Me.lblChangeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(8, 170)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(52, 17)
        Me.lblChange.TabIndex = 14
        Me.lblChange.Text = "Change"
        '
        'lblDiscountAmt
        '
        Me.lblDiscountAmt.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountAmt.Location = New System.Drawing.Point(3, 84)
        Me.lblDiscountAmt.Name = "lblDiscountAmt"
        Me.lblDiscountAmt.Size = New System.Drawing.Size(111, 50)
        Me.lblDiscountAmt.TabIndex = 13
        Me.lblDiscountAmt.Text = "0"
        Me.lblDiscountAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(8, 67)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(58, 17)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "Discount"
        '
        'pnlTransactionDetail
        '
        Me.pnlTransactionDetail.Controls.Add(Me.btn10)
        Me.pnlTransactionDetail.Controls.Add(Me.lblCustomerName)
        Me.pnlTransactionDetail.Controls.Add(Me.txtCustomerName)
        Me.pnlTransactionDetail.Controls.Add(Me.btnClearCash)
        Me.pnlTransactionDetail.Controls.Add(Me.btnSave)
        Me.pnlTransactionDetail.Controls.Add(Me.btnCancel)
        Me.pnlTransactionDetail.Controls.Add(Me.btn20)
        Me.pnlTransactionDetail.Controls.Add(Me.btn50)
        Me.pnlTransactionDetail.Controls.Add(Me.btn100)
        Me.pnlTransactionDetail.Controls.Add(Me.txtCash)
        Me.pnlTransactionDetail.Controls.Add(Me.btn1000)
        Me.pnlTransactionDetail.Controls.Add(Me.btn500)
        Me.pnlTransactionDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTransactionDetail.Location = New System.Drawing.Point(120, 0)
        Me.pnlTransactionDetail.Name = "pnlTransactionDetail"
        Me.pnlTransactionDetail.Size = New System.Drawing.Size(347, 283)
        Me.pnlTransactionDetail.TabIndex = 11
        '
        'btn10
        '
        Me.btn10.BackColor = System.Drawing.Color.Chocolate
        Me.btn10.FlatAppearance.BorderSize = 0
        Me.btn10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10.ForeColor = System.Drawing.Color.White
        Me.btn10.Location = New System.Drawing.Point(3, 198)
        Me.btn10.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(55, 55)
        Me.btn10.TabIndex = 22
        Me.btn10.Text = "10"
        Me.btn10.UseVisualStyleBackColor = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(196, 85)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(103, 17)
        Me.lblCustomerName.TabIndex = 17
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Nirmala UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(159, 105)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(176, 47)
        Me.txtCustomerName.TabIndex = 18
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClearCash
        '
        Me.btnClearCash.BackColor = System.Drawing.Color.Crimson
        Me.btnClearCash.FlatAppearance.BorderSize = 0
        Me.btnClearCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnClearCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCash.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCash.ForeColor = System.Drawing.Color.White
        Me.btnClearCash.Location = New System.Drawing.Point(281, 13)
        Me.btnClearCash.Name = "btnClearCash"
        Me.btnClearCash.Size = New System.Drawing.Size(54, 54)
        Me.btnClearCash.TabIndex = 21
        Me.btnClearCash.Text = "X"
        Me.btnClearCash.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LawnGreen
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(159, 170)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(176, 39)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(159, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(176, 39)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btn20
        '
        Me.btn20.BackColor = System.Drawing.Color.OrangeRed
        Me.btn20.FlatAppearance.BorderSize = 0
        Me.btn20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20.ForeColor = System.Drawing.Color.White
        Me.btn20.Location = New System.Drawing.Point(64, 198)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(55, 55)
        Me.btn20.TabIndex = 15
        Me.btn20.Text = "20"
        Me.btn20.UseVisualStyleBackColor = False
        '
        'btn50
        '
        Me.btn50.BackColor = System.Drawing.Color.Crimson
        Me.btn50.FlatAppearance.BorderSize = 0
        Me.btn50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.ForeColor = System.Drawing.Color.White
        Me.btn50.Location = New System.Drawing.Point(3, 137)
        Me.btn50.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(55, 55)
        Me.btn50.TabIndex = 14
        Me.btn50.Text = "50"
        Me.btn50.UseVisualStyleBackColor = False
        '
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.Purple
        Me.btn100.FlatAppearance.BorderSize = 0
        Me.btn100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet
        Me.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.ForeColor = System.Drawing.Color.White
        Me.btn100.Location = New System.Drawing.Point(64, 137)
        Me.btn100.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(55, 55)
        Me.btn100.TabIndex = 13
        Me.btn100.Text = "100"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Nirmala UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(3, 13)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(3, 3, 3, 4)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(272, 54)
        Me.txtCash.TabIndex = 12
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn1000
        '
        Me.btn1000.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn1000.FlatAppearance.BorderSize = 0
        Me.btn1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1000.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000.ForeColor = System.Drawing.Color.White
        Me.btn1000.Location = New System.Drawing.Point(64, 76)
        Me.btn1000.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(55, 55)
        Me.btn1000.TabIndex = 11
        Me.btn1000.Text = "1000"
        Me.btn1000.UseVisualStyleBackColor = False
        '
        'btn500
        '
        Me.btn500.BackColor = System.Drawing.Color.Gold
        Me.btn500.FlatAppearance.BorderSize = 0
        Me.btn500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn500.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn500.ForeColor = System.Drawing.Color.White
        Me.btn500.Location = New System.Drawing.Point(3, 76)
        Me.btn500.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(55, 55)
        Me.btn500.TabIndex = 10
        Me.btn500.Text = "500"
        Me.btn500.UseVisualStyleBackColor = False
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(3, 17)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(111, 50)
        Me.lblTotalAmt.TabIndex = 10
        Me.lblTotalAmt.Text = "0"
        Me.lblTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(7, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(36, 17)
        Me.lblTotalAmount.TabIndex = 0
        Me.lblTotalAmount.Text = "Total"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.FlatAppearance.BorderSize = 0
        Me.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Location = New System.Drawing.Point(10, 262)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(140, 39)
        Me.btnRemoveItem.TabIndex = 6
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.AllowUserToDeleteRows = False
        Me.dgvOrderList.AllowUserToResizeColumns = False
        Me.dgvOrderList.AllowUserToResizeRows = False
        Me.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvOrderList.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOrderList.EnableHeadersVisualStyles = False
        Me.dgvOrderList.Location = New System.Drawing.Point(10, 27)
        Me.dgvOrderList.MultiSelect = False
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.ReadOnly = True
        Me.dgvOrderList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvOrderList.RowHeadersVisible = False
        Me.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOrderList.ShowEditingIcon = False
        Me.dgvOrderList.Size = New System.Drawing.Size(445, 229)
        Me.dgvOrderList.TabIndex = 1
        '
        'lblOrderSummary
        '
        Me.lblOrderSummary.AutoSize = True
        Me.lblOrderSummary.Location = New System.Drawing.Point(6, 3)
        Me.lblOrderSummary.Name = "lblOrderSummary"
        Me.lblOrderSummary.Size = New System.Drawing.Size(124, 21)
        Me.lblOrderSummary.TabIndex = 0
        Me.lblOrderSummary.Text = "Order Summary"
        '
        'pnlItems
        '
        Me.pnlItems.AutoScroll = True
        Me.pnlItems.Controls.Add(Me.lblNoItems)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlItems.Location = New System.Drawing.Point(146, 0)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.pnlItems.Size = New System.Drawing.Size(271, 590)
        Me.pnlItems.TabIndex = 1
        '
        'lblNoItems
        '
        Me.lblNoItems.Location = New System.Drawing.Point(0, 140)
        Me.lblNoItems.Name = "lblNoItems"
        Me.lblNoItems.Size = New System.Drawing.Size(271, 100)
        Me.lblNoItems.TabIndex = 0
        Me.lblNoItems.Text = "Select a Category on the left panel"
        Me.lblNoItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlItemCategory
        '
        Me.pnlItemCategory.Controls.Add(Me.btnViewTransactions)
        Me.pnlItemCategory.Controls.Add(Me.btnClear)
        Me.pnlItemCategory.Controls.Add(Me.btnSides)
        Me.pnlItemCategory.Controls.Add(Me.btnPremToppings)
        Me.pnlItemCategory.Controls.Add(Me.btnRegTopping)
        Me.pnlItemCategory.Controls.Add(Me.btnBatter)
        Me.pnlItemCategory.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlItemCategory.Location = New System.Drawing.Point(0, 0)
        Me.pnlItemCategory.Name = "pnlItemCategory"
        Me.pnlItemCategory.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.pnlItemCategory.Size = New System.Drawing.Size(146, 590)
        Me.pnlItemCategory.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Crimson
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(16, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 39)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSides
        '
        Me.btnSides.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSides.FlatAppearance.BorderSize = 0
        Me.btnSides.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSides.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSides.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSides.ForeColor = System.Drawing.Color.White
        Me.btnSides.Location = New System.Drawing.Point(16, 231)
        Me.btnSides.Name = "btnSides"
        Me.btnSides.Size = New System.Drawing.Size(127, 70)
        Me.btnSides.TabIndex = 4
        Me.btnSides.Text = "Sides"
        Me.btnSides.UseVisualStyleBackColor = False
        '
        'btnPremToppings
        '
        Me.btnPremToppings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPremToppings.FlatAppearance.BorderSize = 0
        Me.btnPremToppings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPremToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPremToppings.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremToppings.ForeColor = System.Drawing.Color.White
        Me.btnPremToppings.Location = New System.Drawing.Point(16, 155)
        Me.btnPremToppings.Name = "btnPremToppings"
        Me.btnPremToppings.Size = New System.Drawing.Size(127, 70)
        Me.btnPremToppings.TabIndex = 3
        Me.btnPremToppings.Text = "Premium Toppings"
        Me.btnPremToppings.UseVisualStyleBackColor = False
        '
        'btnRegTopping
        '
        Me.btnRegTopping.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegTopping.FlatAppearance.BorderSize = 0
        Me.btnRegTopping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRegTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegTopping.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegTopping.ForeColor = System.Drawing.Color.White
        Me.btnRegTopping.Location = New System.Drawing.Point(16, 79)
        Me.btnRegTopping.Name = "btnRegTopping"
        Me.btnRegTopping.Size = New System.Drawing.Size(127, 70)
        Me.btnRegTopping.TabIndex = 2
        Me.btnRegTopping.Text = "Regular Toppings"
        Me.btnRegTopping.UseVisualStyleBackColor = False
        '
        'btnBatter
        '
        Me.btnBatter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBatter.FlatAppearance.BorderSize = 0
        Me.btnBatter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBatter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatter.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatter.ForeColor = System.Drawing.Color.White
        Me.btnBatter.Location = New System.Drawing.Point(16, 3)
        Me.btnBatter.Name = "btnBatter"
        Me.btnBatter.Size = New System.Drawing.Size(127, 70)
        Me.btnBatter.TabIndex = 1
        Me.btnBatter.Text = "Pancake Batter"
        Me.btnBatter.UseVisualStyleBackColor = False
        '
        'btnViewTransactions
        '
        Me.btnViewTransactions.BackColor = System.Drawing.Color.Indigo
        Me.btnViewTransactions.FlatAppearance.BorderSize = 0
        Me.btnViewTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.btnViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTransactions.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTransactions.ForeColor = System.Drawing.Color.White
        Me.btnViewTransactions.Location = New System.Drawing.Point(16, 477)
        Me.btnViewTransactions.Name = "btnViewTransactions"
        Me.btnViewTransactions.Size = New System.Drawing.Size(127, 67)
        Me.btnViewTransactions.TabIndex = 6
        Me.btnViewTransactions.Text = "View Transactions"
        Me.btnViewTransactions.UseVisualStyleBackColor = False
        Me.btnViewTransactions.Visible = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.pnlMainPanel)
        Me.Controls.Add(Me.lblBDate)
        Me.Controls.Add(Me.lblSysTimeDate)
        Me.Controls.Add(Me.lblCashierName)
        Me.Controls.Add(Me.lblCashier)
        Me.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiana's Pancake Station"
        Me.pnlMainPanel.ResumeLayout(False)
        Me.pnlOrderSummary.ResumeLayout(False)
        Me.pnlOrderSummary.PerformLayout()
        Me.pnlCheckout.ResumeLayout(False)
        Me.pnlCheckout.PerformLayout()
        Me.pnlTransactionDetail.ResumeLayout(False)
        Me.pnlTransactionDetail.PerformLayout()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItemCategory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCashier As Label
    Friend WithEvents lblCashierName As Label
    Friend WithEvents lblSysTimeDate As Label
    Friend WithEvents tmrTimeTick As Timer
    Friend WithEvents lblBDate As Label
    Friend WithEvents pnlMainPanel As Panel
    Friend WithEvents pnlItemCategory As Panel
    Friend WithEvents btnBatter As Button
    Friend WithEvents btnSides As Button
    Friend WithEvents btnPremToppings As Button
    Friend WithEvents btnRegTopping As Button
    Friend WithEvents pnlItems As Panel
    Friend WithEvents lblNoItems As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents lblOrderSummary As Label
    Friend WithEvents dgvOrderList As DataGridView
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents pnlCheckout As Panel
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents pnlTransactionDetail As Panel
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents lblDiscountAmt As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblChangeAmt As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btn20 As Button
    Friend WithEvents cbxApplySeniorDiscount As CheckBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClearCash As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btnViewTransactions As Button
End Class
