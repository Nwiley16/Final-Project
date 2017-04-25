<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventory
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
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.StockNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrueMarketValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStockNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToOrderColumns = True
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNumber, Me.TrueMarketValue, Me.ArrivalDate})
        Me.dgvInventory.Location = New System.Drawing.Point(-1, 198)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.Size = New System.Drawing.Size(1268, 283)
        Me.dgvInventory.TabIndex = 48
        '
        'StockNumber
        '
        Me.StockNumber.DataPropertyName = "StockNumber"
        Me.StockNumber.HeaderText = "StockNumber"
        Me.StockNumber.Name = "StockNumber"
        Me.StockNumber.ReadOnly = True
        '
        'TrueMarketValue
        '
        Me.TrueMarketValue.DataPropertyName = "TrueMarketValue"
        Me.TrueMarketValue.HeaderText = "TrueMarketValue"
        Me.TrueMarketValue.Name = "TrueMarketValue"
        '
        'ArrivalDate
        '
        Me.ArrivalDate.DataPropertyName = "ArrivalDate"
        Me.ArrivalDate.HeaderText = "ArrivalDate"
        Me.ArrivalDate.Name = "ArrivalDate"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Azure
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(301, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(369, 98)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Dream Vehicles"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStockNum
        '
        Me.txtStockNum.Location = New System.Drawing.Point(441, 162)
        Me.txtStockNum.Name = "txtStockNum"
        Me.txtStockNum.Size = New System.Drawing.Size(104, 20)
        Me.txtStockNum.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Stock Number:"
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(570, 156)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(100, 28)
        Me.btnSell.TabIndex = 63
        Me.btnSell.Text = "Sell Vehicle"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(703, 154)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 64
        Me.btnUpdate.Text = "Update Vehicle"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'FrmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 493)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStockNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvInventory)
        Me.Name = "FrmInventory"
        Me.Text = "Inventory Report"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents StockNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockNumber As DataGridViewTextBoxColumn
    Friend WithEvents TrueMarketValue As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDate As DataGridViewTextBoxColumn
    Friend WithEvents txtStockNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSell As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents errProvider As ErrorProvider
End Class
