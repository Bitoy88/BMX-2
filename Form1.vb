'Bitoy bmxwallet@gmail (c) 2013 

Imports System
Imports System.IO
Imports System.Net
Imports System.Numerics
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Class Form1
    Const SendType As Integer = 0
    ' 0 - Simple Send

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        My.Settings.YourBTCA = txtYourBTCA.Text
        My.Settings.BlockChainGUI = txtGUI.Text
        My.Settings.SendtoBTCA = txtSendToBTCA.Text
        My.Settings.YourMSC = txtMSC.Text
        My.Settings.YourTestMSC = txtTestMSC.Text
        My.Settings.YourBTC = txtBTC.Text
        My.Settings.Save()


        Dim result = MessageBox.Show("Are you sure you want to send " + txtAmount.Text + " " + cboCoinType.Text + " to " + txtSendToBTCA.Text, "Send Coins", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim CoinType As Integer = 1
            If cboCoinType.Text = "Test Master Coins" Then
                CoinType = 2
            End If

            'Get Sequence Number of BTC Address to Sent to
            Dim recipientBytes As Byte() = Bitcoin.Decode(txtSendToBTCA.Text)
            Dim recipientSequenceNum As Integer = recipientBytes(1)
            Dim dataSequenceNum As Integer = recipientSequenceNum - 1
            If dataSequenceNum < 0 Then
                dataSequenceNum = dataSequenceNum + 256
            End If


            Dim Amount100 As BigInteger = Val(txtAmount.Text) * 100000000
            Dim dataString As String = 0.ToString("x2") + dataSequenceNum.ToString("x2") + SendType.ToString("x8") + CoinType.ToString("x8") + Amount100.ToString("x16") + 0.ToString("x6")

            Dim Bytes As Byte() = (New Bitcoin).StringtoByte(dataString)
            Dim dataResult As String = Space(21)
            Dim Bytes2 As Byte() = (New Bitcoin).StringtoByte(dataResult)
            For Index As Integer = 0 To dataString.Length - 1 Step 2
                Dim Index2 As Integer = CInt(Index / 2)
                Bytes2(Index2) = (New Bitcoin).chartohex(Chr(Bytes(Index))) * 16 + (New Bitcoin).chartohex(Chr(Bytes(Index + 1)))
            Next
            Dim dataAddress As String = Bitcoin.EncodeWithCheckSum(Bytes2)
            txtData.Text = dataAddress

            Dim recipients As String = "{""1EXoDusjGwvnjZUyKkxZ4UHEf77z6A5S4P"":6000," + _
        """" + txtSendToBTCA.Text + """:6000," + _
        """" + txtData.Text + """:6000}"

            recipients = System.Uri.EscapeDataString(recipients)
            Dim PostURL As String = "https://blockchain.info/merchant/" + txtGUI.Text + "/sendmany?password=" + txtPassword.Text + "&recipients=" + recipients + "&from=" + txtYourBTCA.Text
            TextBox1.Text = PostReq(PostURL, "")
        End If


    End Sub
    Function PostReq(pURL As String, pstrPost As String) As String
        Dim objStream As StreamWriter
        Dim URL As String = pURL
        Dim strPost As String = pstrPost


        Dim objRequest As HttpWebRequest = CType(WebRequest.Create(URL), HttpWebRequest)
        objRequest.Method = "POST"
        objRequest.ContentLength = strPost.Length
        objRequest.ContentType = "application/x-www-form-urlencoded"

        objStream = New StreamWriter(objRequest.GetRequestStream())
        objStream.Write(strPost)
        objStream.Close()
        Dim strResponse As String = ""
        Try
            Dim objResponse As HttpWebResponse
            objResponse = CType(objRequest.GetResponse(), HttpWebResponse)
            Dim sr As StreamReader
            sr = New StreamReader(objResponse.GetResponseStream())
            strResponse = sr.ReadToEnd()
            sr.Close()
        Catch e As Exception
            TextBox1.Text = URL + " " + strPost
            MessageBox.Show(URL + " " + e.Message)
        End Try


        Return strResponse


    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtYourBTCA.Text = My.Settings.YourBTCA
        txtGUI.Text = My.Settings.BlockChainGUI
        txtSendToBTCA.Text = My.Settings.SendtoBTCA
        txtMSC.Text = My.Settings.YourMSC
        txtTestMSC.Text = My.Settings.YourTestMSC
        txtBTC.Text = My.Settings.YourBTC

        UpdateCoinBalances()
        GetTransactions()

    End Sub

    Function getjson(PostURL As String) As String
        Dim request As WebRequest = _
  WebRequest.Create(PostURL)
        request.Credentials = CredentialCache.DefaultCredentials
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim result As String = reader.ReadToEnd()
        reader.Close()
        response.Close()
        Return result
    End Function

    Sub UpdateCoinBalances()

        If txtYourBTCA.Text.Length = 34 Then
            Dim PostURL As String = "http://mastercoin-explorer.com/api/v1/addresses/" + txtYourBTCA.Text + ".json"
            '        PostURL = "http://blockchain.info/address/" + txtYourBTCA.Text + "?format=json"

            'get msc balance from mastercoin-explorer api 
            Dim obj As New JObject
            Dim json As String = getjson(PostURL)
            Dim deserializedProduct As Object = JsonConvert.DeserializeObject(Of Object)(json)
            obj = JsonConvert.DeserializeObject(json)
            txtMSC.Text = obj.Item("balance").ToString
            txtTestMSC.Text = obj.Item("test_balance").ToString

            'Get Bitcoin balance from blockchain api
            PostURL = "http://blockchain.info/address/" + txtYourBTCA.Text + "?format=json"
            json = getjson(PostURL)
            deserializedProduct = JsonConvert.DeserializeObject(Of Object)(json)
            obj = JsonConvert.DeserializeObject(json)
            Dim BTC As Double = Val(obj.Item("final_balance")) / 100000000
            txtBTC.Text = BTC.ToString


            My.Settings.YourMSC = txtMSC.Text
            My.Settings.YourTestMSC = txtTestMSC.Text
            My.Settings.YourBTC = txtBTC.Text

            My.Settings.Save()

        End If


    End Sub
    Sub GetTransactions()
        'get msc balance from mastercoin-explorer api
        DGTrans.Rows.Clear()
        Dim PostURL As String = "http://blockchain.info/address/" + txtYourBTCA.Text + "?format=json"
        Dim obj As New JObject
        Dim json As String = getjson(PostURL)
        Dim deserializedProduct As Object = JsonConvert.DeserializeObject(Of Object)(json)
        obj = JsonConvert.DeserializeObject(json)
        Dim i As Integer = 0
        Dim Hash As String = "x"
        Dim obj2 As New JObject

        For i = 0 To obj.Item("txs").Count - 1
            Hash = obj.Item("txs").Item(i).Item("hash").ToString
            PostURL = "http://mastercoin-explorer.com/api/v1/transactions/" + Hash + ".json"
            Dim json2 As String = getjson(PostURL)
            If (json2 <> "null") Then
                Dim deserializedProduct2 As Object = JsonConvert.DeserializeObject(Of Object)(json2)
                obj2 = JsonConvert.DeserializeObject(json2)

                Dim Currency As String = "MSC"
                If obj2.Item("currency_id") = "2" Then
                    Currency = "Test MSC"
                End If
                Dim cStatus As String = "Valid"
                If obj2.Item("invalid_tx") = "true" Then
                    cStatus = "Invalid"
                End If
                DGTrans.Rows.Add(Hash, obj2.Item("receiving_address"), obj2.Item("address"), Currency, obj2.Item("amount"), cStatus, obj2.Item("tx_date"))
            End If
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.YourBTCA = txtYourBTCA.Text
        My.Settings.BlockChainGUI = txtGUI.Text
        My.Settings.Save()

        UpdateCoinBalances()
        GetTransactions()

        TextBox1.Text = "Updated."
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTrans.CellContentClick

    End Sub
End Class
