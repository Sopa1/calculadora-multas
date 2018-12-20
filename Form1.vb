Public Class Form1

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        'Defino los valores de salida como 0 por si no se da click en calcular.
        Dim suma_M% = 0
        Dim suma_P% = 0
        'Creo las variables de aclaracion.
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
            suma_M += 1500
            suma_P += 3
        End If
        If CheckBox2.Checked Then
            suma_M += 1000
        End If
        If CheckBox3.Checked Then
            suma_M += 100 * cantsem.Value
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
            suma_M += 600
            suma_P += 6
        End If
        If CheckBox8.Checked Then
            suma_M += 600
            suma_P += 2
        End If
        If CheckBox9.Checked Then
            suma_M += 1500
            aclaracion2 = "1.09 - Calabozos. " & vbCrLf
        End If
        If CheckBox10.Checked Then
            suma_M += 2000
            aclaracion3 = "1.10 - Perdida de licencia y un año de carcel." & vbCrLf
        End If
        If CheckBox11.Checked Then
            suma_M += 150
            aclaracion4 = "1.11 - Si el conductor no esta cerca se traslada al deposito. " & vbCrLf
        End If
        If CheckBox12.Checked Then
            suma_M += 500
            aclaracion5 = "1.12 - Traslado del coche al deposito. " & vbCrLf
        End If
        If CheckBox13.Checked Then
            suma_M += 300
            suma_P += 1
        End If
        If CheckBox14.Checked Then
            suma_M += 150
            suma_P += 1
        End If
        If CheckBox15.Checked Then
            suma_M += 400
            suma_P += 2
        End If
        If CheckBox16.Checked Then
            suma_M += 600
        End If
        If CheckBox17.Checked Then
            suma_M += 100
            suma_P += 1
        End If
        If CheckBox18.Checked Then
            suma_M += 300
            suma_P += 2
        End If
        If CheckBox19.Checked Then
            suma_M += 150
            suma_P += 1
        End If
        If CheckBox20.Checked Then
            suma_M += 200
            suma_P += 2
        End If
        If CheckBox21.Checked Then
            suma_M += 150
            suma_P += 1
        End If
        If CheckBox22.Checked Then
            suma_M += 150
            suma_P += 1
        End If
        If CheckBox23.Checked Then
            suma_M += 150
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
            suma_M += 2000
            aclaracion6 = "1.26 - Calabozo. " & vbCrLf
        End If
        If CheckBox27.Checked Then
            suma_M += 4000
            aclaracion7 = "1.27 - Perdida de licencia y calabozo." & vbCrLf
        End If
        If CheckBox28.Checked Then
            suma_M += 2500
            aclaracion8 = "1.28 -Perdida de licencia de vuelo." & vbCrLf
        End If
        If CheckBox29.Checked Then
            suma_M += 200
            suma_P += 1
        End If
        If CheckBox30.Checked Then
            suma_M += 3500
            aclaracion9 = "1.30 - Embargo de vehiculo y calabozos." & vbCrLf
        End If
        If CheckBox31.Checked Then
            suma_M += 350
        End If
        If CheckBox32.Checked Then
            suma_M += 500
            aclaracion10 = "1.32 - Calabozo." & vbCrLf
        End If

        disp.Text = "LA MULTA ES $ " + CStr(suma_M) + " DOLARES Y PIERDE " + CStr(suma_P) + " PUNTOS DE LICENCIA"
        acl.Text = "ACLARACIONES : " & vbCrLf + aclaracion1 + aclaracion2 + aclaracion3 + aclaracion4 + aclaracion5 + aclaracion6 + aclaracion7 + aclaracion8 + aclaracion9 + aclaracion10


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

        disp.Text = "LA MULTA ES $ 0 DOLARES Y PIERDE 0 PUNTOS DE LICENCIA"
        acl.Text = "ACLARACIONES :"

    End Sub
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class

