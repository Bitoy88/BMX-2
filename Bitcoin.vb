Imports System.Security.Cryptography
Imports System.Numerics
Public Class Bitcoin
    Function BytetoString(B As Byte()) As String
        Return System.Text.Encoding.ASCII.GetString(B)
    End Function
    Function StringtoByte(S As String) As Byte()
        Return System.Text.Encoding.ASCII.GetBytes(S)
    End Function
    Private Const Digits As String = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz"
    Function chartohex(C As Char) As Integer
        Select Case C
            Case "0"
                Return 0
            Case "1"
                Return 1
            Case "2"
                Return 2
            Case "3"
                Return 3
            Case "4"
                Return 4
            Case "5"
                Return 5
            Case "6"
                Return 6
            Case "7"
                Return 7
            Case "8"
                Return 8
            Case "9"
                Return 9
            Case "a"
                Return 10
            Case "b"
                Return 11
            Case "c"
                Return 12
            Case "d"
                Return 13
            Case "e"
                Return 14
            Case "f"
                Return 15
            Case Else
                Return vbNull
        End Select
    End Function

    Private Shared Function GetCheckSum(data As Byte()) As Byte()

        Dim sha256 As SHA256 = New SHA256Managed()
        Dim hash1 As Byte() = sha256.ComputeHash(data)
        Dim hash2 As Byte() = sha256.ComputeHash(hash1)

        Dim result = New Byte(3) {}
        Buffer.BlockCopy(hash2, 0, result, 0, result.Length)

        Return result
    End Function
    Public Shared Function ConcatArrays(Of T)(ParamArray arrays As T()()) As T()

        Dim result = New T(arrays.Sum(Function(arr) arr.Length) - 1) {}
        Dim offset As Integer = 0
        For i As Integer = 0 To arrays.Length - 1
            Dim arr = arrays(i)
            Buffer.BlockCopy(arr, 0, result, offset, arr.Length)
            offset += arr.Length
        Next
        Return result
    End Function
    Public Shared Function AddCheckSum(data As Byte()) As Byte()
        Dim checkSum As Byte() = GetCheckSum(data)
        Dim dataWithCheckSum As Byte() = ConcatArrays(data, checkSum)
        Return dataWithCheckSum
    End Function
    Public Shared Function EncodeWithCheckSum(data As Byte()) As String
        Return Encode(AddCheckSum(data))
    End Function
    Public Shared Function Encode(data As Byte()) As String
        ' Decode byte[] to BigInteger
        Dim intData As BigInteger = 0
        Dim i As Integer = 0
        For i = 0 To data.Length - 1
            intData = intData * 256 + data(i)
        Next

        ' Encode BigInteger to Base58 string
        Dim result As String = ""
        While intData > 0
            Dim remainder As Integer = CInt(intData Mod 58)
            intData /= 58
            result = Digits(remainder) & result
        End While
        i = 0
        ' Append `1` for each leading 0 byte
        While i < data.Length AndAlso data(i) = 0
            result = "1"c & result
            i += 1
        End While
        Return result
    End Function
    Public Shared Function Decode(s As String) As Byte()

        ' Decode Base58 string to BigInteger 
        Dim intData As BigInteger = 0
        For i As Integer = 0 To s.Length - 1
            Dim digit As Integer = Digits.IndexOf(s(i))
            'Slow
            If digit < 0 Then
                Throw New FormatException(String.Format("Invalid Base58 character `{0}` at position {1}", s(i), i))
            End If
            intData = intData * 58 + digit
        Next

        Dim leadingZeroCount As Integer = s.TakeWhile(Function(c) c = "1"c).Count()
        Dim leadingZeros = Enumerable.Repeat(CByte(0), leadingZeroCount)
        ' to big endian
        Dim bytesWithoutLeadingZeros = intData.ToByteArray().Reverse().SkipWhile(Function(b) b = 0)
        'strip sign byte
        Dim result = leadingZeros.Concat(bytesWithoutLeadingZeros).ToArray()
        Return result
    End Function

End Class
