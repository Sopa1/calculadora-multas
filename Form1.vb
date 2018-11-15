
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Defino los valores de salida como 0 por si no se da click en calcular.
        Dim suma_M% = 0
        Dim suma_P% = 0
        Dim aclaracion As String = ""

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
            aclaracion = "Vehiculo al deposito e incautacion del material."
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
            aclaracion = "Calabozos."
        End If
        If CheckBox10.Checked Then
            suma_M += 2000
            aclaracion = "Perdida de licencia y un año de carcel."
        End If
        If CheckBox11.Checked Then
            suma_M += 150
            aclaracion = "Si el conductor no esta cerca se traslada al deposito."
        End If
        If CheckBox12.Checked Then
            suma_M += 500
            aclaracion = "Traslado del coche al deposito."
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
            aclaracion = "Calabozo."
        End If
        If CheckBox27.Checked Then
            suma_M += 4000
            aclaracion = "Perdida de licencia y calabozo."
        End If
        If CheckBox28.Checked Then
            suma_M += 2500
            aclaracion = "Perdida de licencia de vuelo."
        End If
        If CheckBox29.Checked Then
            suma_M += 200
            suma_P += 1
        End If
        If CheckBox30.Checked Then
            suma_M += 3500
            aclaracion = "Embargo de vehiculo y calabozos."
        End If
        If CheckBox31.Checked Then
            suma_M += 350
        End If
        If CheckBox32.Checked Then
            suma_M += 500
            aclaracion = "Calabozo."
        End If

        disp.Text = "LA MULTA ES $ " + CStr(suma_M) + " DOLARES Y PIERDE " + CStr(suma_P) + " PUNTOS DE LICENCIA"
        acl.Text = "ACLARACIONES : " + aclaracion

    End Sub
End Class

