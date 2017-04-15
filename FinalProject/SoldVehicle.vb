Public Class SoldVehicle

    Public Property LastStatus As String
    Private adapter As New DealerDataSetTableAdapters.SoldTableAdapter


    Public ReadOnly Property SoldList As DataTable
        Get
            Dim listAdapter As New DealerDataSetTableAdapters.SoldTableAdapter

            Return listAdapter.GetData()
        End Get
    End Property

    Private adapter1 As New DealerDataSetTableAdapters.SoldTableAdapter

    Public Function Sell(pSaleID As Integer, pYear As Integer,
                      pMake As String, pModel As String, pTrim As String,
                      pColor As String, pDriveTrain As String, pMiles As Integer,
                      pSalePrice As Decimal, pProfit As Decimal, pStockNumber As Integer) As Boolean
        Dim Result As Boolean = False
        Try

            If adapter1.Insert(pSaleID, pYear, pMake, pModel, pTrim, pColor, pDriveTrain,
                              pMiles, pSalePrice, pProfit, pStockNumber) > 0 Then
                LastStatus = "Vehicle sold successfully!"
                Result = True
            Else
                LastStatus = "Error Selling Vehicle"

            End If
        Catch ex As Exception
            LastStatus = "Exception thrown while selling vehicle."

        End Try
        Return Result
    End Function


End Class
