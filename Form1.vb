Public Class Form1

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox8.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox21.Enabled = False
            CheckBox22.Enabled = False
            CheckBox23.Enabled = False
            CheckBox24.Enabled = False
            CheckBox25.Enabled = False
        Else
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox8.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox15.Enabled = True
            CheckBox16.Enabled = True
            CheckBox17.Enabled = True
            CheckBox18.Enabled = True
            CheckBox19.Enabled = True
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            CheckBox25.Enabled = True
        End If
    End Sub
    Private Sub CheckBox10_Click(sender As Object, e As EventArgs) Handles CheckBox10.Click
        If CheckBox10.Checked Then
            CheckBox1.Enabled = False
            If CheckBox1.Checked Then
                CheckBox1.Checked = False
            End If
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox8.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox21.Enabled = False
            CheckBox22.Enabled = False
            CheckBox23.Enabled = False
            CheckBox24.Enabled = False
            CheckBox25.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox8.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox15.Enabled = True
            CheckBox16.Enabled = True
            CheckBox17.Enabled = True
            CheckBox18.Enabled = True
            CheckBox19.Enabled = True
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            CheckBox25.Enabled = True
        End If
    End Sub
    Private Sub CheckBox27_Click(sender As Object, e As EventArgs) Handles CheckBox27.Click
        If CheckBox27.Checked Then
            CheckBox1.Enabled = False
            If CheckBox1.Checked Then
                CheckBox1.Checked = False
            End If
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox8.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox21.Enabled = False
            CheckBox22.Enabled = False
            CheckBox23.Enabled = False
            CheckBox24.Enabled = False
            CheckBox25.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox8.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox15.Enabled = True
            CheckBox16.Enabled = True
            CheckBox17.Enabled = True
            CheckBox18.Enabled = True
            CheckBox19.Enabled = True
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            CheckBox25.Enabled = True
        End If
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        'Defino los valores de salida como 0 por si no se da click en calcular.
        Dim suma_M% = 0
        Dim suma_P% = 0
        'Creo las variables de aclaracion.
        Dim aclaracion0 As String = ""
        Dim aclaracion1 As String = ""
        Dim aclaracion2 As String = ""
        Dim aclaracion3 As String = ""
        Dim aclaracion4 As String = ""
        Dim aclaracion5 As String = ""
        Dim aclaracion6 As String = ""
        Dim aclaracion7 As String = ""
        Dim aclaracion8 As String = ""
        Dim aclaracion9 As String = ""
        Dim aclaracion10 As String = ""

        'Compruebo cuales fueron tildadas y sumo la multa y punto correspondiente.
        If CheckBox1.Checked Then
            suma_M += 4000
            suma_P += 3
        End If
        If CheckBox2.Checked Then
            suma_M += 1500
            aclaracion0 = "1.02 - Debe pagar el valor de los daños." & vbCrLf
        End If
        If CheckBox3.Checked Then
            suma_M += 500 * cantsem.Value
            suma_P += 2 * cantsem.Value
        End If
        If CheckBox4.Checked Then
            suma_M += 400
            suma_P += 1
        End If
        If CheckBox5.Checked Then
            suma_M += 600
            suma_P += 6
        End If
        If CheckBox6.Checked Then
            aclaracion1 = "1.06 - Vehiculo al deposito e incautacion del material." & vbCrLf
        End If
        If CheckBox7.Checked Then
            suma_M += 800
            suma_P += 6
        End If
        If CheckBox8.Checked Then
            suma_M += 700
            suma_P += 2
        End If
        If CheckBox9.Checked Then
            suma_M += 2500
            aclaracion2 = "1.09 - Calabozos. " & vbCrLf
        End If
        If CheckBox10.Checked Then
            suma_M += 4000
            aclaracion3 = "1.10 - Perdida de licencia y un año de carcel." & vbCrLf
        End If
        If CheckBox11.Checked Then
            suma_M += 250
            aclaracion4 = "1.11 - Si el conductor no esta cerca se traslada al deposito. " & vbCrLf
        End If
        If CheckBox12.Checked Then
            suma_M += 900
            aclaracion5 = "1.12 - Traslado del coche al deposito. " & vbCrLf
        End If
        If CheckBox13.Checked Then
            suma_M += 500
            suma_P += 1
        End If
        If CheckBox14.Checked Then
            suma_M += 450
            suma_P += 2
        End If
        If CheckBox15.Checked Then
            suma_M += 400
            suma_P += 2
        End If
        If CheckBox16.Checked Then
            suma_M += 600
        End If
        If CheckBox17.Checked Then
            suma_M += 200
            suma_P += 1
        End If
        If CheckBox18.Checked Then
            suma_M += 500
            suma_P += 2
        End If
        If CheckBox19.Checked Then
            suma_M += 350
            suma_P += 1
        End If
        If CheckBox20.Checked Then
            suma_M += 400
            suma_P += 2
        End If
        If CheckBox21.Checked Then
            suma_M += 250
            suma_P += 1
        End If
        If CheckBox22.Checked Then
            suma_M += 250
            suma_P += 1
        End If
        If CheckBox23.Checked Then
            suma_M += 250
            suma_P += 1
        End If
        If CheckBox24.Checked Then
            suma_M += 350
            suma_P += 2
        End If
        If CheckBox25.Checked Then
            suma_M += 100
        End If
        If CheckBox26.Checked Then
            suma_M += 4000
            aclaracion6 = "1.26 - Calabozo. " & vbCrLf
        End If
        If CheckBox27.Checked Then
            suma_M += 6000
            aclaracion7 = "1.27 - Perdida de licencia y calabozo." & vbCrLf
        End If
        If CheckBox28.Checked Then
            suma_M += 6500
            aclaracion8 = "1.28 -Perdida de licencia de vuelo." & vbCrLf
        End If
        If CheckBox29.Checked Then
            suma_M += 400
            suma_P += 1
        End If
        If CheckBox30.Checked Then
            suma_M += 5500
            aclaracion9 = "1.30 - Embargo de vehiculo y calabozos." & vbCrLf
        End If
        If CheckBox31.Checked Then
            suma_M += 450
        End If
        If CheckBox32.Checked Then
            suma_M += 1500
            aclaracion10 = "1.32 - Calabozo." & vbCrLf
        End If

        disp.Text = "LA MULTA ES $ " + CStr(suma_M) + " DOLARES Y PIERDE " + CStr(suma_P) + " PUNTOS DE LICENCIA"
        acl.Text = "ACLARACIONES : " & vbCrLf + aclaracion0 + aclaracion1 + aclaracion2 + aclaracion3 + aclaracion4 + aclaracion5 + aclaracion6 + aclaracion7 + aclaracion8 + aclaracion9 + aclaracion10


    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        CheckBox1.CheckState = False
        CheckBox2.CheckState = False
        CheckBox3.CheckState = False
        CheckBox4.CheckState = False
        CheckBox5.CheckState = False
        CheckBox6.CheckState = False
        CheckBox7.CheckState = False
        CheckBox8.CheckState = False
        CheckBox9.CheckState = False
        CheckBox10.CheckState = False
        CheckBox11.CheckState = False
        CheckBox12.CheckState = False
        CheckBox13.CheckState = False
        CheckBox14.CheckState = False
        CheckBox15.CheckState = False
        CheckBox16.CheckState = False
        CheckBox17.CheckState = False
        CheckBox18.CheckState = False
        CheckBox19.CheckState = False
        CheckBox20.CheckState = False
        CheckBox21.CheckState = False
        CheckBox22.CheckState = False
        CheckBox23.CheckState = False
        CheckBox24.CheckState = False
        CheckBox25.CheckState = False
        CheckBox26.CheckState = False
        CheckBox27.CheckState = False
        CheckBox28.CheckState = False
        CheckBox29.CheckState = False
        CheckBox30.CheckState = False
        CheckBox31.CheckState = False
        CheckBox32.CheckState = False

        CheckBox1.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox8.Enabled = True
        CheckBox12.Enabled = True
        CheckBox13.Enabled = True
        CheckBox15.Enabled = True
        CheckBox16.Enabled = True
        CheckBox17.Enabled = True
        CheckBox18.Enabled = True
        CheckBox19.Enabled = True
        CheckBox21.Enabled = True
        CheckBox22.Enabled = True
        CheckBox23.Enabled = True
        CheckBox24.Enabled = True
        CheckBox25.Enabled = True

        disp.Text = "LA MULTA ES $ 0 DOLARES Y PIERDE 0 PUNTOS DE LICENCIA"
        acl.Text = "ACLARACIONES :"

    End Sub
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Switch(checkState As CheckState)
        Throw New NotImplementedException
    End Sub

End Class

