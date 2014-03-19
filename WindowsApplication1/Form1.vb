Public Class Form1
    Dim lblCurrentCard As System.Windows.Forms.Label
    Dim lblFirstCard As System.Windows.Forms.Label
    Dim numOpenCard As Integer = 0

    Private Sub lblCard1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCard1.Click, lblCard2.Click, lblCard3.Click, lblCard4.Click, lblCard5.Click, lblCard6.Click
        lblCurrentCard = CType(sender, System.Windows.Forms.Label)
        txtBox.Text = "Now,Which card do you think will match this one"
        Select Case lblCurrentCard.Name
            Case "lblCard1"
                lblCurrentCard.Text = "Apple"
                PictureBox1.Visible = True
            Case "lblCard2"
                lblCurrentCard.Text = "Apple"
                PictureBox2.Visible = True
            Case "lblCard3"
                lblCurrentCard.Text = "Grape"
                PictureBox3.Visible = True
            Case "lblCard4"
                lblCurrentCard.Text = "Grape"
                PictureBox4.Visible = True
            Case "lblCard5"
                lblCurrentCard.Text = "Orange"
                PictureBox5.Visible = True
            Case "lblCard6"
                lblCurrentCard.Text = "Orange"
                PictureBox6.Visible = True
        End Select
        If numOpenCard = 0 Then
            lblFirstCard = lblCurrentCard
            numOpenCard += 1
        Else
            If lblCurrentCard.Text = lblFirstCard.Text And
               lblCurrentCard.Name <> lblFirstCard.Name Then
                lblFirstCard.Visible = False
                lblCurrentCard.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                txtBox.Text = "You are right"
            Else
                lblFirstCard.Text = ""
                lblCurrentCard.Text = ""
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                txtBox.Text = "No, try again"
            End If
            numOpenCard = 0
        End If
        If lblCard1.Visible = False And lblCard2.Visible = False And lblCard3.Visible = False And lblCard4.Visible = False And lblCard5.Visible = False And lblCard6.Visible = False Then
            txtBox.Text = "You won!"
        End If
    End Sub

    Private Sub btnShuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShuffle.Click
        lblCard1.Visible = True
        PictureBox1.Visible = False
        lblCard2.Visible = True
        PictureBox2.Visible = False
        lblCard3.Visible = True
        PictureBox3.Visible = False
        lblCard4.Visible = True
        PictureBox4.Visible = False
        lblCard5.Visible = True
        PictureBox5.Visible = False
        lblCard6.Visible = True
        PictureBox6.Visible = False
        lblCard1.Text = ""
        lblCard2.Text = ""
        lblCard3.Text = ""
        lblCard4.Text = ""
        lblCard5.Text = ""
        lblCard6.Text = ""

        generateValues(a, b, c, d, x, f)
        Dim margin As Integer = 35
        Dim dimention As Integer = 75
        Dim space As Integer = 6
        Dim c1 As Integer = margin + (dimention + space) * a
        Dim c2 As Integer = margin + (dimention + space) * b
        Dim c3 As Integer = margin + (dimention + space) * c
        Dim c4 As Integer = margin + (dimention + space) * d
        Dim c5 As Integer = margin + (dimention + space) * x
        Dim c6 As Integer = margin + (dimention + space) * f

        lblCard1.Location = New Point(c1, 35)
        PictureBox1.Location = New Point(c1, 35)
        lblCard2.Location = New Point(c2, 35)
        PictureBox2.Location = New Point(c2, 35)
        lblCard3.Location = New Point(c3, 35)
        PictureBox3.Location = New Point(c3, 35)
        lblCard4.Location = New Point(c4, 35)
        PictureBox4.Location = New Point(c4, 35)
        lblCard5.Location = New Point(c5, 35)
        PictureBox5.Location = New Point(c5, 35)
        lblCard6.Location = New Point(c6, 35)
        PictureBox6.Location = New Point(c6, 35)

    End Sub
    Dim a, b, c, d, x, f As Integer
    Function generateValues(ByRef a As Integer, ByRef b As Integer, ByRef c As Integer, ByRef d As Integer, ByRef x As Integer, ByRef f As Integer) As Integer
        a = CInt(Int((1000 * Rnd()) Mod 6))
        b = CInt(Int((1000 * Rnd()) Mod 6))
        c = CInt(Int((1000 * Rnd()) Mod 6))
        d = CInt(Int((1000 * Rnd()) Mod 6))
        x = CInt(Int((1000 * Rnd()) Mod 6))
        f = CInt(Int((1000 * Rnd()) Mod 6))
        If a = b Or a = c Or a = d Or a = x Or a = f Or
           b = c Or b = d Or b = x Or b = f Or
           c = d Or c = x Or c = f Or
           d = x Or d = f Or
           x = f Then
            generateValues(a, b, c, d, x, f)
        End If
        Return 0
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class
