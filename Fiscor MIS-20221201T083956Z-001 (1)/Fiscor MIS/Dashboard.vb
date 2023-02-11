Public Class Dashboard
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CashManagement.Show()
        Me.Close()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to log out?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaleAndInventory.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Cashier_form.Show()

        Me.Close()

    End Sub
End Class