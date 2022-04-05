Public Class Form1
    Dim total, bayar, kembali As Double
    Dim bycuci, tottambah, totmakan As Double
    Dim makan As CheckBox()
    Dim tambah As CheckBox()
    Dim txttambah As TextBox()
    Dim txtmakan As TextBox()
    Dim txtjumlah As TextBox()
    Dim hargamakan() As Double = {5000, 5000, 10000, 6000}
    Dim hargatambah() As Double = {100000, 100000, 50000, 100000}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        makan = New CheckBox() {makan1, makan2, makan3, makan4}
        txtmakan = New TextBox() {txtmakan1, txtmakan2, txtmakan3, txtmakan4}
        txtjumlah = New TextBox() {txtjumlah1, txtjumlah2, txtjumlah3, txtjumlah4}
        tambah = New CheckBox() {tambah1, tambah2, tambah3, tambah4}
        txttambah = New TextBox() {txttambah1, txttambah2, txttambah3, txttambah4}

        For i = 0 To 3
            txtmakan(i).Text = "Rp. " & Format(hargamakan(i), "#,#.##")
        Next

        For i = 0 To 3
            txttambah(i).Text = "Rp. " & Format(hargatambah(i), "#,#.##")
        Next
        bycuci = 0
    End Sub
    Private Sub motor1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles motor1.CheckedChanged
        bycuci = 15000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub
    Private Sub motor2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles motor2.CheckedChanged
        bycuci = 20000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jenis1.CheckedChanged
        bycuci = 30000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jenis2.CheckedChanged
        bycuci = 70000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jenis3.CheckedChanged
        bycuci = 100000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jenis4.CheckedChanged
        bycuci = 0
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Dim i As Integer
        totmakan = 0
        tottambah = 0
        For i = 0 To 3
            If tambah(i).Checked Then
                tottambah = tottambah + hargatambah(i)
            End If
        Next
        For i = 0 To 3
            If makan(i).Checked Then
                totmakan = totmakan + (hargamakan(i) * Val(txtjumlah(i).Text))
            End If
        Next
        total = bycuci + tottambah + totmakan
        txttotal.Text = "Rp. " & Format(total, "#,#.##")
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To 3
            makan(i).Checked = False
        Next
        For i = 0 To 3
            txtjumlah(i).Text = 0
        Next
        For i = 0 To 3
            tambah(i).Checked = False
        Next
        txttotal.Clear()
        txtbayar.Clear()
        txtkembali.Clear()
    End Sub

    Private Sub btnreset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Dim i As Integer
        For i = 0 To 3
            makan(i).Checked = False
        Next
        For i = 0 To 3
            txtjumlah(i).Text = 0
        Next
        For i = 0 To 3
            tambah(i).Checked = False
        Next
        txttotal.Clear()
        txtbayar.Clear()
        txtkembali.Clear()
    End Sub

    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            kembali = Val(txtbayar.Text) - total
            txtkembali.Text = "Rp. " & Format(kembali, "#,#.##")
        End If
    End Sub
End Class
