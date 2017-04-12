Public Class ViewInventory
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtboxWaterCount.Text = waterBottle.ToString

        txtboxSnackCount.Text = snack.ToString

        txt5KMedalCount.Text = fiveKMedal.ToString

        txtbox10KMedalCount.Text = tenKMedal.ToString

        txtboxsmallShirtCount.Text = smallShirt.ToString

        txtboxMediumShirtCount.Text = mediumShirt.ToString

        txtboxLargeShirtCount.Text = largeShirt.ToString

        txtXlargeShirtCount.Text = xlargeShirt.ToString

    End Sub
End Class