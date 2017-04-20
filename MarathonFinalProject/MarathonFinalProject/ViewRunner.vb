Public Class frmViewRunner

    Dim mRunner As New Runner()

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click

    End Sub

    Private Sub frmViewRunner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RunnerDataSet.Runner' table. You can move, or remove it, as needed.
        Me.RunnerTableAdapter.Fill(Me.RunnerDataSet.Runner)

        dgvRunners.DataSource = mRunner.Items()


    End Sub
End Class