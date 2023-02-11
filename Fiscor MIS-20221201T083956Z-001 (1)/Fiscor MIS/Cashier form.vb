Public Class Cashier_form
    Dim intnum1 As Double
    Dim intnum2 As Double
    Dim intnum3 As Double
    Dim intnum4 As Double
    Dim intnum5 As Double
    Dim intnum6 As Double
    Dim intnum7 As Double
    Dim intnum8 As Double
    Dim intnum9 As Double
    Dim intnum10 As Double
    Dim intnum11 As Double
    Dim intnum12 As Double
    Dim intnum13 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intnum1 = TextBox1.Text
        intnum2 = TextBox2.Text


        TextBox3.Text = intnum1 * intnum2

        LblWeight.Text = TextBox1.Text
        LblPrice.Text = TextBox2.Text
        LblTotal.Text = TextBox3.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        TextBox3.Text = intnum1 * intnum2

        LblPrice.Text = TextBox2.Text
        LblWeight.Text = TextBox1.Text
        LblTotal.Text = TextBox3.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intnum4 = TextBox4.Text
        intnum5 = TextBox5.Text
        intnum6 = TextBox6.Text
        intnum7 = TextBox7.Text
        intnum8 = TextBox8.Text
        intnum9 = TextBox9.Text
        intnum10 = TextBox10.Text
        intnum11 = TextBox11.Text
        intnum12 = TextBox12.Text
        intnum13 = TextBox13.Text

        TextBox14.Text = intnum4 + intnum5 + intnum6 + intnum7 + intnum8 + intnum9 + intnum10 + intnum11 + intnum12 + intnum13
        TextBox1.Text = TextBox14.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to clear all fields?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()

            LblWeight.Text = "0"
            LblTotal.Text = "0"
            LblPrice.Text = "0"
        End If

    End Sub

    Private Sub Cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NavigatorFrm.Show()
    End Sub
End Class