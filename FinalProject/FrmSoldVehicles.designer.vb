<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoldVehicles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DealerDataSet = New FinalProject.DealerDataSet()
        Me.SoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldTableAdapter = New FinalProject.DealerDataSetTableAdapters.SoldTableAdapter()
        Me.SaleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrivetrainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MileageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleIDDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.TrimDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.DrivetrainDataGridViewTextBoxColumn, Me.MileageDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn})
        Me.dgvInventory.DataSource = Me.SoldBindingSource
        Me.dgvInventory.Location = New System.Drawing.Point(8, 120)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.Size = New System.Drawing.Size(1041, 222)
        Me.dgvInventory.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Azure
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(87, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(482, 55)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Dream Vehicles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DealerDataSet
        '
        Me.DealerDataSet.DataSetName = "DealerDataSet"
        Me.DealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoldBindingSource
        '
        Me.SoldBindingSource.DataMember = "Sold"
        Me.SoldBindingSource.DataSource = Me.DealerDataSet
        '
        'SoldTableAdapter
        '
        Me.SoldTableAdapter.ClearBeforeFill = True
        '
        'SaleIDDataGridViewTextBoxColumn
        '
        Me.SaleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID"
        Me.SaleIDDataGridViewTextBoxColumn.HeaderText = "SaleID"
        Me.SaleIDDataGridViewTextBoxColumn.Name = "SaleIDDataGridViewTextBoxColumn"
        Me.SaleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'MakeDataGridViewTextBoxColumn
        '
        Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
        Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
        Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'TrimDataGridViewTextBoxColumn
        '
        Me.TrimDataGridViewTextBoxColumn.DataPropertyName = "Trim"
        Me.TrimDataGridViewTextBoxColumn.HeaderText = "Trim"
        Me.TrimDataGridViewTextBoxColumn.Name = "TrimDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'DrivetrainDataGridViewTextBoxColumn
        '
        Me.DrivetrainDataGridViewTextBoxColumn.DataPropertyName = "Drivetrain"
        Me.DrivetrainDataGridViewTextBoxColumn.HeaderText = "Drivetrain"
        Me.DrivetrainDataGridViewTextBoxColumn.Name = "DrivetrainDataGridViewTextBoxColumn"
        '
        'MileageDataGridViewTextBoxColumn
        '
        Me.MileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage"
        Me.MileageDataGridViewTextBoxColumn.HeaderText = "Mileage"
        Me.MileageDataGridViewTextBoxColumn.Name = "MileageDataGridViewTextBoxColumn"
        '
        'SalePriceDataGridViewTextBoxColumn
        '
        Me.SalePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice"
        Me.SalePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice"
        Me.SalePriceDataGridViewTextBoxColumn.Name = "SalePriceDataGridViewTextBoxColumn"
        '
        'ProfitDataGridViewTextBoxColumn
        '
        Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        '
        'FrmSoldVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 381)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvInventory)
        Me.Name = "FrmSoldVehicles"
        Me.Text = "FrmSoldVehicles"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DealerDataSet As DealerDataSet
    Friend WithEvents SoldBindingSource As BindingSource
    Friend WithEvents SoldTableAdapter As DealerDataSetTableAdapters.SoldTableAdapter
    Friend WithEvents SaleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrivetrainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MileageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
