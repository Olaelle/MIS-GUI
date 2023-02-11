Public Class SaleAndInventory
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim response As Integer

        response = MsgBox("Are you sure you want to log out?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then


            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

        Dashboard.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        CashManagement.Show()
        Me.Close()


    End Sub

    Private Sub SaleAndInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Are you sure you want to clear all fields?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning,)


        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        NavigatorFrm.Show()

    End Sub
End Class