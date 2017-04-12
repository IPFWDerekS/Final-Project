Option Strict On
Option Explicit On

Public Class frmAddRunner
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpboxRaceType.Enter

    End Sub

    Private Sub txtdisplayWater_TextChanged(sender As Object, e As EventArgs) Handles txtdisplayWater.TextChanged



    End Sub

    Private Sub frmAddRunner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDisplaySnack.Text = snack.ToString

        txtdisplayWater.Text = waterBottle.ToString

        txtdisplay5K.Text = fiveKMedal.ToString

        txtdisplay10K.Text = tenKMedal.ToString


    End Sub

    Private Sub txtdisplayShirts_TextChanged(sender As Object, e As EventArgs) Handles txtdisplayShirts.TextChanged




    End Sub

    Private Sub cboShirts_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboShirts.SelectedValueChanged

        Dim value As Integer

        value = cboShirts.SelectedIndex

        If value = 0 Then

            txtdisplayShirts.Text = smallShirt.ToString

        ElseIf value = 1 Then

            txtdisplayShirts.Text = mediumShirt.ToString

        ElseIf value = 2 Then

            txtdisplayShirts.Text = largeShirt.ToString


        Else

            txtdisplayShirts.Text = xlargeShirt.ToString

        End If




    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click





        For i As Integer = Controls.Count - 1 To 0 Step -1

            If TypeOf Controls(i) Is TextBox Then

                Dim textbox As TextBox = CType(Me.Controls(i), TextBox)

                If textbox.Enabled = False Then


                    MessageBox.Show(textbox.Tag.ToString)


                End If
                    'If value < 10 Then

                    '    StatusStrip.Text = textbox.Name & " is running low. Please goo and order more."

                    'End If

                End If


        Next

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles StatusStrip.Click

    End Sub
End Class