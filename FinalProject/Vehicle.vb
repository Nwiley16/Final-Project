Public Class Vehicle

    Private adapter As New _
        DealerDataSetTableAdapters.Inventory1TableAdapter


    Public ReadOnly Property InventoryList As DataTable
        Get
            Dim listAdapter As New DealerDataSetTableAdapters.Inventory1TableAdapter

            Return listAdapter.GetData()
        End Get
    End Property



    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function GetByStockNumber(ByVal StockNumber As Short) As DataTable

        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "Stock Number = " & StockNumber
        Return table
    End Function




    Public Function FindByStockNumber(ByVal StockNumber As Short) As DealerDataSet.Inventory1Row

        Dim table As DealerDataSet.Inventory1DataTable
        table = adapter.GetData()
        Return table.FindByStockNumber(StockNumber)

    End Function


End Class
