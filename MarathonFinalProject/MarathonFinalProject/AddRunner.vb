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


        For i As Integer = Controls.Count - 1 To 0 Step -1

            If TypeOf Controls(i) Is TextBox Then


                Dim txt As TextBox = CType(Controls(i), TextBox)

                txt.Text = ""


            End If

            If TypeOf Controls(i) Is ComboBox Then


                Dim cbo As ComboBox = CType(Controls(i), ComboBox)

                cbo.SelectedIndex = -1

            End If



        Next



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

        errProvider.Clear()

        'waterBottle += -1

        'snack += -1

        'If radbtn5KMedal.Checked Then

        '    fiveKMedal += -1

        'ElseIf radbtn10KMedal.Checked Then

        '    tenKMedal += -1

        'Else



        'End If


        For i As Integer = Controls.Count - 1 To 0 Step -1

            If TypeOf Controls(i) Is ComboBox Then


                Dim cbobox As ComboBox = CType(Controls(i), ComboBox)

                If cbobox.SelectedIndex = -1 Then


                    errProvider.SetError(cbobox, cbobox.Tag.ToString & " is not selected.")

                    cbobox.Focus()

                    Return

                End If


            End If
            'If a control is a listbox.
            If TypeOf Controls(i) Is TextBox Then


                Dim textbox As TextBox = CType(Controls(i), TextBox)

                If textbox.Enabled Then

                    If textbox.Text = "" Then

                        errProvider.SetError(textbox, textbox.Tag.ToString & " is not selected.")

                        textbox.Focus()
                        Return


                    End If


                End If

                End If






        Next


        waterBottle -= -1

        snack -= -1

        If radbtn5KMedal.Checked Then

            fiveKMedal -= -1

        ElseIf radbtn10KMedal.Checked Then

            tenKMedal -= -1

        Else



        End If



    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles StatusStrip.Click

    End Sub

    Private Sub txtBibnumber_TextChanged(sender As Object, e As EventArgs) Handles txtBibnumber.TextChanged

    End Sub

    Private Sub txtBibnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBibnumber.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = vbBack Then

            e.Handled = False

        End If
        '4 Digits only for the Bib number.
        If txtBibnumber.Text.Length = 4 Then

            e.Handled = True

        End If

    End Sub
End Class