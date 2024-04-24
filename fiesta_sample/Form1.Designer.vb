<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        invoice_number = New TextBox()
        Button1 = New Button()
        api_response = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' invoice_number
        ' 
        invoice_number.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        invoice_number.Location = New Point(101, 107)
        invoice_number.Name = "invoice_number"
        invoice_number.PlaceholderText = "Invoice Number"
        invoice_number.Size = New Size(713, 33)
        invoice_number.TabIndex = 0
        invoice_number.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(101, 139)
        Button1.Name = "Button1"
        Button1.Size = New Size(713, 66)
        Button1.TabIndex = 2
        Button1.Text = "SEND REQUEST"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' api_response
        ' 
        api_response.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        api_response.Location = New Point(101, 398)
        api_response.Multiline = True
        api_response.Name = "api_response"
        api_response.Size = New Size(713, 284)
        api_response.TabIndex = 3
        api_response.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(373, 358)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 37)
        Label1.TabIndex = 4
        Label1.Text = "API RESPONSE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(181, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(573, 37)
        Label2.TabIndex = 5
        Label2.Text = "ENTER A NEW INVOICE NUMBER FOR TESTING"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(904, 727)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(api_response)
        Controls.Add(Button1)
        Controls.Add(invoice_number)
        DoubleBuffered = True
        Name = "Form1"
        Text = "GRA E-VAT"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents invoice_number As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents api_response As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
