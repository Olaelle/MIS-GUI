Public Class NavigatorFrm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dashboard.Show()
        Me.Close()
        Cashier_form.Close()
        CashManagement.Close()
        SaleAndInventory.Close()
        Customer.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Customer.Show()
        Me.Close()
        Cashier_form.Close()
        Cashier_form.Close()
        CashManagement.Close()
        SaleAndInventory.Close()
        Dashboard.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SaleAndInventory.Show()
        Me.Close()
        Cashier_form.Close()
        Dashboard.Close()
        Cashier_form.Close()
        CashManagement.Close()
        Customer.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Cashier_form.Show()
        Me.Close()
        CashManagement.Close()
        SaleAndInventory.Close()
        Customer.Close()
        Dashboard.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CashManagement.Show()
        Me.Close()
        Cashier_form.Close()
        SaleAndInventory.Close()
        Customer.Close()
        Dashboard.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to log out? Some changes might not save", MessageBoxIcon.Question + MessageBoxButtons.YesNo,)

        If response = vbYes Then
            Me.Close()
            Cashier_form.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim response As Integer

        response = MsgBox("do you wish to close the navigator?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then
            Me.Close()
        End If
    End Sub
End Class