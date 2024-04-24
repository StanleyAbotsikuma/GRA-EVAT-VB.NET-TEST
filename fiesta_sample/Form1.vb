Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Text.Json
Imports Newtonsoft.Json
Public Class Form1



    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As String = "https://vsdcstaging.vat-gh.com/vsdc/api/v1/taxpayer/CXX000000YY-001/invoice"

        ' Create the JSON payload
        Dim invoice As New Invoice()
        invoice.currency = "GHS"
        invoice.exchangeRate = "1.0"
        invoice.invoiceNumber = invoice_number.Text
        invoice.totalLevy = "63.99"
        invoice.userName = "Kofi Ghana"
        invoice.flag = "INVOICE"
        invoice.calculationType = "INCLUSIVE"
        invoice.totalVat = "169.57"
        invoice.transactionDate = DateTime.Parse("2023-09-13T08:43:28Z")
        invoice.totalAmount = "1300.0"
        invoice.voucherAmount = "0.0"
        invoice.businessPartnerName = "fred(cash customer)"
        invoice.businessPartnerTin = "C0000000000"
        invoice.saleType = "NORMAL"
        invoice.discountType = "GENERAL"
        invoice.discountAmount = "0.0"
        invoice.reference = ""
        invoice.groupReferenceId = ""
        invoice.purchaseOrderReference = ""

        Dim item As New Item()
        item.itemCode = "TXC00389165855"
        item.itemCategory = ""
        item.expireDate = DateTime.Parse("2025-01-01")
        item.description = "1SFA611130R1101"
        item.quantity = "10.0"
        item.levyAmountA = "26.66"
        item.levyAmountB = "26.66"
        item.levyAmountC = "10.66"
        item.levyAmountD = "0.0"
        item.levyAmountE = "0.0"
        item.discountAmount = "0.0"
        item.batchCode = ""
        item.unitPrice = "130.0"
        invoice.items = New List(Of Item)()
        invoice.items.Add(item)


        Dim jsonPayload As String = JsonConvert.SerializeObject(invoice)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            client.DefaultRequestHeaders.Add("security_key", "Z60gftKe9sei3xOZhvvDa0StkVILKR3j5MBM9ygi1zg=")

            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                Dim responseText As String = Await response.Content.ReadAsStringAsync()
                api_response.Text = responseText
                MessageBox.Show("Request was successful")
            Else
                Dim responseText As String = Await response.Content.ReadAsStringAsync()
                api_response.Text = responseText
                MessageBox.Show("Request Failed.....")
            End If

        End Using
    End Sub
End Class
