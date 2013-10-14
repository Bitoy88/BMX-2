<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGUI = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYourBTCA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSendToBTCA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMSC = New System.Windows.Forms.TextBox()
        Me.txtBTC = New System.Windows.Forms.TextBox()
        Me.txtTestMSC = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCoinType = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGTrans = New System.Windows.Forms.DataGridView()
        Me.colTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReceiving = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blockchain Identifier:"
        '
        'txtGUI
        '
        Me.txtGUI.Location = New System.Drawing.Point(117, 16)
        Me.txtGUI.Name = "txtGUI"
        Me.txtGUI.Size = New System.Drawing.Size(226, 20)
        Me.txtGUI.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(149, 101)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(84, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Blockchain Password:"
        '
        'txtYourBTCA
        '
        Me.txtYourBTCA.Location = New System.Drawing.Point(118, 41)
        Me.txtYourBTCA.Name = "txtYourBTCA"
        Me.txtYourBTCA.Size = New System.Drawing.Size(225, 20)
        Me.txtYourBTCA.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Your BTC Address:"
        '
        'txtSendToBTCA
        '
        Me.txtSendToBTCA.Location = New System.Drawing.Point(149, 23)
        Me.txtSendToBTCA.Name = "txtSendToBTCA"
        Me.txtSendToBTCA.Size = New System.Drawing.Size(225, 20)
        Me.txtSendToBTCA.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Send to:"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(132, 287)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(256, 20)
        Me.txtData.TabIndex = 9
        Me.txtData.Text = "1AfUdLNfBi34pyuWaCKdayd24qTZBzYDH8"
        Me.txtData.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data Address:"
        Me.Label5.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(149, 135)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(157, 37)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send Coins"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(149, 75)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmount.Size = New System.Drawing.Size(84, 20)
        Me.txtAmount.TabIndex = 12
        Me.txtAmount.Text = "1.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Coins to Send:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 313)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(628, 51)
        Me.TextBox1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Your Master Coins"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Bitcoins:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(485, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Test MSC:"
        '
        'txtMSC
        '
        Me.txtMSC.Enabled = False
        Me.txtMSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSC.Location = New System.Drawing.Point(36, 50)
        Me.txtMSC.Name = "txtMSC"
        Me.txtMSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMSC.Size = New System.Drawing.Size(186, 31)
        Me.txtMSC.TabIndex = 17
        Me.txtMSC.Text = "0.00"
        '
        'txtBTC
        '
        Me.txtBTC.Enabled = False
        Me.txtBTC.Location = New System.Drawing.Point(538, 41)
        Me.txtBTC.Name = "txtBTC"
        Me.txtBTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBTC.Size = New System.Drawing.Size(103, 20)
        Me.txtBTC.TabIndex = 18
        Me.txtBTC.Text = "0.00"
        '
        'txtTestMSC
        '
        Me.txtTestMSC.Enabled = False
        Me.txtTestMSC.Location = New System.Drawing.Point(538, 61)
        Me.txtTestMSC.Name = "txtTestMSC"
        Me.txtTestMSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTestMSC.Size = New System.Drawing.Size(103, 20)
        Me.txtTestMSC.TabIndex = 19
        Me.txtTestMSC.Text = "0.00"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(36, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(628, 204)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtGUI)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtYourBTCA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(620, 178)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.cboCoinType)
        Me.TabPage2.Controls.Add(Me.btnSend)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtAmount)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtSendToBTCA)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(620, 178)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Send Coins"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Coin Type:"
        '
        'cboCoinType
        '
        Me.cboCoinType.FormattingEnabled = True
        Me.cboCoinType.Items.AddRange(New Object() {"Master Coins", "Test Master Coins"})
        Me.cboCoinType.Location = New System.Drawing.Point(149, 49)
        Me.cboCoinType.Name = "cboCoinType"
        Me.cboCoinType.Size = New System.Drawing.Size(121, 21)
        Me.cboCoinType.TabIndex = 13
        Me.cboCoinType.Text = "Master Coins"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGTrans)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(620, 178)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transactions"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGTrans
        '
        Me.DGTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTrans, Me.colReceiving, Me.colSource, Me.colCurrency, Me.colAmount, Me.colStatus, Me.colDate})
        Me.DGTrans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGTrans.Location = New System.Drawing.Point(0, 0)
        Me.DGTrans.Name = "DGTrans"
        Me.DGTrans.Size = New System.Drawing.Size(624, 175)
        Me.DGTrans.TabIndex = 0
        '
        'colTrans
        '
        Me.colTrans.HeaderText = "Trans. No."
        Me.colTrans.Name = "colTrans"
        '
        'colReceiving
        '
        Me.colReceiving.HeaderText = "Receiving"
        Me.colReceiving.Name = "colReceiving"
        Me.colReceiving.Width = 125
        '
        'colSource
        '
        Me.colSource.HeaderText = "Source"
        Me.colSource.Name = "colSource"
        Me.colSource.Width = 125
        '
        'colCurrency
        '
        Me.colCurrency.HeaderText = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Width = 75
        '
        'colAmount
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N6"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Width = 75
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 50
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 376)
        Me.Controls.Add(Me.txtTestMSC)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtBTC)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtMSC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Form1"
        Me.Text = "BMX Wallet"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGUI As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtYourBTCA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSendToBTCA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMSC As System.Windows.Forms.TextBox
    Friend WithEvents txtBTC As System.Windows.Forms.TextBox
    Friend WithEvents txtTestMSC As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCoinType As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DGTrans As System.Windows.Forms.DataGridView
    Friend WithEvents colTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReceiving As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSource As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCurrency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
