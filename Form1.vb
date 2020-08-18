Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim num1 As Decimal
        num1 = txtcantidad.Text
        If cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Hectogramos" Then
            lblresultado.Text = num1 * 10
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Decagramos" Then
            lblresultado.Text = num1 * 100
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Gramos" Then
            lblresultado.Text = num1 * 1000
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Decigramos" Then
            lblresultado.Text = num1 * 10000
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Centigramos" Then
            lblresultado.Text = num1 * 100000
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Miligramos" Then
            lblresultado.Text = num1 * 1000000.0
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Libras" Then
            lblresultado.Text = num1 * 2.20462
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Onzas" Then
            lblresultado.Text = num1 * 35.2739199982575
        ElseIf cbxunidades.Text = "Kilogramos" And cbxpasar.Text = "Quilates" Then
            lblresultado.Text = num1 * 5000
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Kilogramos" Then
            lblresultado.Text = num1 / 0.1
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Decagramos" Then
            lblresultado.Text = num1 * 10
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Gramos" Then
            lblresultado.Text = num1 * 100
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Decigramos" Then
            lblresultado.Text = num1 * 1000
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Centigramos" Then
            lblresultado.Text = num1 * 10000
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Miligramos" Then
            lblresultado.Text = num1 * 100000
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Libras" Then
            lblresultado.Text = num1 / 0.220462
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Onzas" Then
            lblresultado.Text = num1 * 3.5273920000021159
        ElseIf cbxunidades.Text = "Hectogramos" And cbxpasar.Text = "Quilates" Then
            lblresultado.Text = num1 * 500
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Kilogramos" Then
            lblresultado.Text = num1 / 0.01
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Hectogramos" Then
            lblresultado.Text = num1 / 0.1
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Gramos" Then
            lblresultado.Text = num1 * 10
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Decigramos" Then
            lblresultado.Text = num1 * 100
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Centigramos" Then
            lblresultado.Text = num1 * 1000
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Miligramos" Then
            lblresultado.Text = num1 * 10000
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Libras" Then
            lblresultado.Text = num1 / 0.0220462
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Onzas" Then
            lblresultado.Text = num1 / 0.35274
        ElseIf cbxunidades.Text = "Decagramos" And cbxpasar.Text = "Quilates" Then
            lblresultado.Text = num1 * 50
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Kilogramos" Then
            lblresultado.Text = num1 * 1000
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Hectogramos" Then
            lblresultado.Text = num1 / 0.01
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Decagramos" Then
            lblresultado.Text = num1 / 0.1
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Decigramos" Then
            lblresultado.Text = num1 * 10
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Centigramos" Then
            lblresultado.Text = num1 * 100
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Miligramos" Then
            lblresultado.Text = num1 * 1000
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Libras" Then
            lblresultado.Text = num1 / 0.00220462
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Onzas" Then
            lblresultado.Text = num1 / 0.035274
        ElseIf cbxunidades.Text = "Gramos" And cbxpasar.Text = "Quilates" Then
            lblresultado.Text = num1 * 5
        ElseIf cbxunidades.Text = "Decigramos" And cbxpasar.Text = "Kilogramos" Then
            lblresultado.Text = num1 * 10000
        ElseIf cbxunidades.Text = "Decigramos" And cbxpasar.Text = "Hectogramos" Then
            lblresultado.Text = num1 / 0.001
        End If
    End Sub
End Class
