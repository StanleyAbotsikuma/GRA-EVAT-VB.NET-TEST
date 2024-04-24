Public Class Invoice
    Public Property currency As String
    Public Property exchangeRate As String
    Public Property invoiceNumber As String
    Public Property totalLevy As String
    Public Property userName As String
    Public Property flag As String
    Public Property calculationType As String
    Public Property totalVat As String
    Public Property transactionDate As Date
    Public Property totalAmount As String
    Public Property voucherAmount As String
    Public Property businessPartnerName As String
    Public Property businessPartnerTin As String
    Public Property saleType As String
    Public Property discountType As String
    Public Property discountAmount As String
    Public Property reference As String
    Public Property groupReferenceId As String
    Public Property purchaseOrderReference As String
    Public Property items As List(Of Item)
End Class
