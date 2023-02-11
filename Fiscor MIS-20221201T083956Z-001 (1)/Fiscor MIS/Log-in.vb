Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.AdminUser And TextBox2.Text = My.Settings.AdminPass Then
            TextBox1.Clear()
            TextBox2.Clear()

            Call Admin()

        ElseIf TextBox1.Text = My.Settings.UserUser And TextBox2.Text = My.Settings.UserPass Then
            TextBox1.Clear()
            TextBox2.Clear()

            Call CMUser()

        ElseIf TextBox1.Text = My.Settings.SalesUser And TextBox2.Text = My.Settings.SalesPass Then
            TextBox1.Clear()
            TextBox2.Clear()

            Call Sales()

        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text <> "" And TextBox2.Text = My.Settings.AdminPass Then
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()
        ElseIf TextBox1.Text <> "" And TextBox2.Text = My.Settings.UserPass Then
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()
        ElseIf TextBox1.Text <> "" And TextBox2.Text = My.Settings.SalesPass Then
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()



        ElseIf TextBox1.Text = My.Settings.AdminUser And TextBox2.Text <> "" Then
            TextBox1.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text = My.Settings.UserUser And TextBox2.Text <> "" Then
            TextBox1.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text = My.Settings.SalesUser And TextBox2.Text <> "" Then
            TextBox1.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()






        ElseIf TextBox1.Text <> My.Settings.AdminUser And TextBox2.Text = My.Settings.UserPass Then
            TextBox1.Focus()
            TextBox2.Focus()


            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()


        ElseIf TextBox1.Text <> My.Settings.AdminUser And TextBox2.Text <> my.Settings.SalesPass Then
            TextBox1.Focus()
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text <> My.Settings.UserUser And TextBox2.Text = My.Settings.AdminPass Then
            TextBox1.Focus()
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()


        ElseIf TextBox1.Text <> My.Settings.UserUser And TextBox2.Text = My.Settings.SalesPass Then
            TextBox1.Focus()
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text <> My.Settings.SalesUser And TextBox2.Text = My.Settings.AdminPass Then
            TextBox1.Focus()
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()

        ElseIf TextBox1.Text <> My.Settings.SalesUser And TextBox2.Text = My.Settings.UserPass Then
            TextBox1.Focus()
            TextBox2.Focus()

            MsgBox("Either of the credentials are wrong", MessageBoxIcon.Warning + MessageBoxButtons.OK,)
            TextBox2.Clear()


        End If
    End Sub
    Private Sub Admin()
        Dashboard.Show()
        Me.Hide()

        Dashboard.Text = ("Admin")

        Dashboard.Visible = True

    End Sub

    Private Sub CMUser()
        CashManagement.Show()
        Me.Hide()


        CashManagement.Text = ("Cash Management User")

        Dashboard.Visible = False
        Dashboard.Hide()
    End Sub
    Private Sub Sales()
        SaleAndInventory.Show()
        Me.Close()

        Dashboard.Hide()
        Dashboard.Visible = False


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to exit the application?", MessageBoxIcon.Question + MessageBoxButtons.YesNo, )

        If response = vbYes Then

            Application.ExitThread()
        End If


    End Sub

End Class
