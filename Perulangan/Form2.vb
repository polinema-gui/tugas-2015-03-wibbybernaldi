Public Class Form2

    Dim hasil As String = ""
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan As String = ComboBox1.Text
        Select Case (pilihan)
            Case Is = "Pyramid"
                pyramid()
            Case Is = "Hollow Pyramid"
                hollowPyramid()
            Case Is = "Inverted Pyramid"
                invertedPyramid()
            Case Is = "Hollow Inverted Pyramid"
                hollowInvertedPyramid()
            Case Else
                TextBox2.Text = "Pilih tipe dahulu"
        End Select
    End Sub

    Private Sub pyramid()
        Dim batas As Integer = TextBox1.Text
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        Dim baris As Integer = 1
        While (baris <= batas)
            Dim kolom As Integer = 1
            While (kolom <= batas * 2 - 1)
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    hasil &= "  "
                Else
                    hasil &= "*"
                End If
                kolom += 1
            End While
            batasKolom1 -= 1
            batasKolom2 += 1
            hasil &= vbCrLf
            baris += 1
        End While
        TextBox2.Text = hasil
        hasil = ""
    End Sub
    Private Sub hollowPyramid()
        Dim batas As Integer = TextBox1.Text
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        Dim baris As Integer = 1
        While (baris <= batas)
            Dim kolom As Integer = 1
            While (kolom <= batas * 2 - 1)
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        hasil &= "*"
                    Else
                        hasil &= "  "
                    End If
                Else
                    hasil &= "*"
                End If
                kolom += 1
            End While
            batasKolom1 -= 1
            batasKolom2 += 1
            hasil &= vbCrLf
            baris += 1
        End While
        TextBox2.Text = hasil
        hasil = ""
    End Sub
    Private Sub invertedPyramid()
        Dim batas As Integer = TextBox1.Text
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        Dim baris As Integer = 1
        While (baris <= batas)
            Dim kolom As Integer = 1
            While (kolom <= batas * 2 - 1)
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    hasil &= "*"
                Else
                    hasil &= "  "
                End If
                kolom += 1
            End While
            batasKolom1 += 1
            batasKolom2 -= 1
            hasil &= vbCrLf
            baris += 1
        End While
        TextBox2.Text = hasil
        hasil = ""
    End Sub
    Private Sub hollowInvertedPyramid()
        Dim batas As Integer = TextBox1.Text
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        Dim baris As Integer = 1
        While (baris <= batas)
            Dim kolom As Integer = 1
            While (kolom <= batas * 2 - 1)
                If (baris = 1) Then
                    hasil &= "*"
                ElseIf (kolom = batasKolom1 Or kolom = batasKolom2) Then
                    hasil &= "*"
                Else
                    hasil &= "  "
                End If
                kolom += 1
            End While
            batasKolom1 += 1
            batasKolom2 -= 1
            hasil &= vbCrLf
            baris += 1
        End While
        TextBox2.Text = hasil
        hasil &= ""
    End Sub
End Class