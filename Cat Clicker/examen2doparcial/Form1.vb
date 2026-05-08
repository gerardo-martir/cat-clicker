Public Class Form1
    Dim Contador As Integer = 0
    Dim autopatterson = False
    Dim autopatteramt = 0
    Dim timertohelp As Integer = 0
    Dim finalistamt = 0
    Dim finaliston = False
    Dim timerforfinalist As Integer = 0
    Dim victory = False
    Private Sub cat1_Click(sender As Object, e As EventArgs) Handles cat1.Click
        If ComboBox1.Text = "" Then
            warning.Visible = True
        ElseIf ComboBox1.Text = "Normal Mode" Then
            warning.Visible = False
            Contador = Contador + 1
            counter.Text = Contador.ToString()
        ElseIf ComboBox1.Text = "Bonus Mode" Then
            warning.Visible = False
            Contador = Contador + 2
            counter.Text = Contador.ToString()
        ElseIf ComboBox1.Text = "Bonus Mode X3" Then
            warning.Visible = False
            Contador = Contador + 3
            counter.Text = Contador.ToString()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            warning.Visible = True
        ElseIf ComboBox1.Text = "Normal Mode" Then
            PictureBox7.Visible = False
            PictureBox8.Visible = False
        ElseIf ComboBox1.Text = "Bonus Mode" Then
            PictureBox7.Visible = True
            PictureBox8.Visible = False
        ElseIf ComboBox1.Text = "Bonus Mode X3" Then
            PictureBox8.Visible = True
            PictureBox7.Visible = True
        End If


    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            warning.Visible = True
        ElseIf ComboBox1.Text = "Normal Mode" Then
            warning.Visible = False
            Contador = Contador + 1
            counter.Text = Contador.ToString()
        ElseIf ComboBox1.Text = "Bonus Mode" Then
            warning.Visible = False
            Contador = Contador + 2
            counter.Text = Contador.ToString()
        ElseIf ComboBox1.Text = "Bonus Mode X3" Then
            warning.Visible = False
            Contador = Contador + 3
            counter.Text = Contador.ToString()
        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private tiempopasado As DateTime = DateTime.Now
    Private tiemporestante As TimeSpan = TimeSpan.Zero
    Private Startingtime As DateTime
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter.Text = Contador.ToString()
        Dim Current = tiempopasado - DateTime.Now
        Label8.Text = Current.ToString("mm\:ss")
        If autopatterson = False Then
        ElseIf autopatterson = True Then
            Timer2.Enabled = True
        End If
        If finaliston = False Then
        ElseIf finaliston = True Then
            Timer3.Enabled = True
        End If
        If victory = False Then
        ElseIf victory = True Then
            Timer2.Enabled = False
            Timer3.Enabled = False
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Contador < 100 Then

        ElseIf Contador >= 100 Then
            Contador = Contador - 100
            autopatterson = True
            autopatteramt = autopatteramt + 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Bignumber = 500
        Dim patterayuda As Integer = Bignumber
        If autopatteramt <= 5 Then
            patterayuda = Bignumber / autopatteramt
        ElseIf autopatteramt >= 6 Then
            patterayuda = 35
        End If
        autopattercounter.Text = autopatteramt
        timertohelp = timertohelp + 1
        Label10.Text = Bignumber.ToString()
        Label11.Text = timertohelp.ToString()
        Label12.Text = patterayuda.ToString()
        If timertohelp >= patterayuda Then
            timertohelp = timertohelp - patterayuda
            Contador = Contador + autopatteramt
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Contador < 1000 Then

        ElseIf Contador > 1000 Then
            Contador = Contador - 1000
            autopatterson = True
            autopatteramt = autopatteramt + 10
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Contador < 5000 Then

        ElseIf Contador > 5000 Then
            Contador = Contador - 5000
            autopatterson = True
            autopatteramt = autopatteramt + 50
        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'finalist
        If Contador < 10000 Then

        ElseIf Contador > 10000 Then
            Contador = Contador - 10000
            finalistamt = finalistamt + 1
            If finaliston = False Then
                finaliston = True
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim lessernumber = 150
        Dim finalistmult As Double = 0
        If finalistamt = 0 Then
            Return
        ElseIf finalistamt = 1 Then
            finalistmult = 1.5
        ElseIf finalistamt = 2 Then
            finalistmult = 2
        ElseIf finalistamt = 3 Then
            finalistmult = 3
        ElseIf finalistamt > 3 Then
            finalistmult = 3
        End If
        timerforfinalist = timerforfinalist + 1
        Label15.Text = timerforfinalist.ToString()
        Label17.Text = finalistmult.ToString()
        If timerforfinalist > lessernumber Then
            Contador = Contador * finalistmult
            timerforfinalist = timerforfinalist - lessernumber
        ElseIf timerforfinalist < lessernumber Then
            Return
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'party button
        Contador = Contador + 100

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Yes!" Then
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label15.Visible = True
            Label17.Visible = True
        ElseIf ComboBox2.Text = "No!" Then
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label15.Visible = False
            Label17.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Contador > 5000000 Then
            Contador = Contador - 5000000
            PictureBox10.Visible = True
            Label19.Visible = True
            victory = True
        ElseIf Contador < 5000000 Then
            Return
        End If
    End Sub
End Class
