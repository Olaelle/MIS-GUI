Public Class CashManagement
    Dim intnum1 As Integer
    Dim intnum2 As Integer
    Dim intnum3 As Integer
    Dim intnum4 As Integer
    Dim intnum5 As Integer

    Dim intnum6 As Integer
    Dim intnum7 As Integer
    Dim intnum8 As Integer
    Dim intnum9 As Integer
    Dim intnum10 As Integer

    Dim intnum11 As Integer
    Dim intnum12 As Integer
    Dim intnum13 As Integer
    Dim intnum14 As Integer

    Dim intnum15 As Integer
    Dim intnum16 As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim response As Integer

        response = MsgBox("Are you sure you want to clear all fields?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
            TextBox14.Clear()
            TextBox15.Clear()
            TextBox16.Clear()
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1 = New SaveFileDialog
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

        Dashboard.Show()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click


        intnum1 = TextBox1.Text
        intnum2 = TextBox2.Text
        intnum3 = TextBox3.Text
        intnum4 = TextBox4.Text
        intnum5 = TextBox5.Text


        TextBox6.Text = intnum1 + intnum2 + intnum3 + intnum4 + intnum5
        TextBox15.Text = intnum1 + intnum2 + intnum3 + intnum4 + intnum5
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to clear this field?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then


            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to clear this field?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()

        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to clear this field?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then

            TextBox15.Clear()
            TextBox13.Clear()
            TextBox14.Clear()
            TextBox16.Clear()

        End If
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        intnum6 = TextBox12.Text
        intnum7 = TextBox11.Text
        intnum8 = TextBox10.Text
        intnum9 = TextBox9.Text
        intnum10 = TextBox8.Text

        TextBox7.Text = intnum6 + intnum7 + intnum8 + intnum9 + intnum10
        TextBox17.Text = intnum6 + intnum7 + intnum8 + intnum9 + intnum10
        TextBox14.Text = intnum16 - intnum15
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        intnum11 = TextBox15.Text

        intnum13 = TextBox13.Text
        intnum14 = TextBox17.Text

        intnum15 = TextBox6.Text
        intnum16 = TextBox7.Text

        TextBox16.Text = intnum12 + intnum13 + intnum14

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim response As Integer

        response = MsgBox("Are you sure you want to log out?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then


            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        SaleAndInventory.Show()
        Me.Close()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("Number inputs only!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("Number inputs only!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("Number inputs only!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("Number inputs only!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("Number inputs only!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then


            e.Handled = False



            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)

        ElseIf TextBox6.Text = "" Then
            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)


        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged


    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)

        ElseIf TextBox7.Text = "" Then
            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
            TextBox7.Clear()

        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)

        ElseIf TextBox6.Text = "" Then
            MsgBox("No indications here!", MessageBoxIcon.Exclamation + MessageBoxButtons.OK,)
            TextBox16.Clear()

        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Cashier_form.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        NavigatorFrm.Show()

    End Sub
End Class
