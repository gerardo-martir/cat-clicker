Public Class Form1
    Dim Contador As Integer = 0
    Dim autopatterson = False
    Dim autopatteramt = 0
    Dim timertohelp As Integer = 0
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
End Class
