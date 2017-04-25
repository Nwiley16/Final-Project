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
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrivetrainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MileageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrueMarketValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventory1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DealerDataSet1 = New FinalProject.DealerDataSet()
        Me.DealerDataSet = New FinalProject.DealerDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Inventory1TableAdapter = New FinalProject.DealerDataSetTableAdapters.Inventory1TableAdapter()
        Me.txtStockNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToOrderColumns = True
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNumber, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.TrimDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.DrivetrainDataGridViewTextBoxColumn, Me.MileageDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TrueMarketValue, Me.ArrivalDate})
        Me.dgvInventory.DataSource = Me.Inventory1BindingSource
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
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MakeDataGridViewTextBoxColumn
        '
        Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
        Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
        Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
        Me.MakeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrimDataGridViewTextBoxColumn
        '
        Me.TrimDataGridViewTextBoxColumn.DataPropertyName = "Trim"
        Me.TrimDataGridViewTextBoxColumn.HeaderText = "Trim"
        Me.TrimDataGridViewTextBoxColumn.Name = "TrimDataGridViewTextBoxColumn"
        Me.TrimDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DrivetrainDataGridViewTextBoxColumn
        '
        Me.DrivetrainDataGridViewTextBoxColumn.DataPropertyName = "Drivetrain"
        Me.DrivetrainDataGridViewTextBoxColumn.HeaderText = "Drivetrain"
        Me.DrivetrainDataGridViewTextBoxColumn.Name = "DrivetrainDataGridViewTextBoxColumn"
        Me.DrivetrainDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MileageDataGridViewTextBoxColumn
        '
        Me.MileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage"
        Me.MileageDataGridViewTextBoxColumn.HeaderText = "Mileage"
        Me.MileageDataGridViewTextBoxColumn.Name = "MileageDataGridViewTextBoxColumn"
        Me.MileageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
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
        'Inventory1BindingSource
        '
        Me.Inventory1BindingSource.DataMember = "Inventory1"
        Me.Inventory1BindingSource.DataSource = Me.DealerDataSet1
        '
        'DealerDataSet1
        '
        Me.DealerDataSet1.DataSetName = "DealerDataSet"
        Me.DealerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DealerDataSet
        '
        Me.DealerDataSet.DataSetName = "DealerDataSet"
        Me.DealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Inventory1TableAdapter
        '
        Me.Inventory1TableAdapter.ClearBeforeFill = True
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
        CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents DealerDataSet As DealerDataSet
    Friend WithEvents StockNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DealerDataSet1 As DealerDataSet
    Friend WithEvents Inventory1BindingSource As BindingSource
    Friend WithEvents Inventory1TableAdapter As DealerDataSetTableAdapters.Inventory1TableAdapter
    Friend WithEvents StockNumber As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrivetrainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MileageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrueMarketValue As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDate As DataGridViewTextBoxColumn
    Friend WithEvents txtStockNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSell As Button
    Friend WithEvents btnUpdate As Button
End Class
