Option Strict On
Option Explicit On

Public Class frmAddRunner
    Dim mRunner As New Runner()


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



        For i As Integer = grpboxRaceType.Controls.Count - 1 To 0 Step -1


            If TypeOf grpboxRaceType.Controls(i) Is RadioButton Then

                Dim radbtn As RadioButton = CType(grpboxRaceType.Controls(i), RadioButton)

                If Not radbtn.Checked Then

                    'Increase it.
                    RaceCount += 1


                End If

            End If



        Next


        If RaceCount = 2 Then

            errProvider.SetError(grpboxRaceType, grpboxRaceType.Tag.ToString & " wasn't selected.")

            grpboxRaceType.Focus()

            Return



        End If

        For i As Integer = grpboxCorralNumber.Controls.Count - 1 To 0 Step -1


            If TypeOf grpboxCorralNumber.Controls(i) Is RadioButton Then

                Dim radbtn As RadioButton = CType(grpboxCorralNumber.Controls(i), RadioButton)

                If Not radbtn.Checked Then

                    'Increase it.
                    CorralNumber += 1


                End If

            End If



        Next


        If CorralNumber = 3 Then


            errProvider.SetError(grpboxCorralNumber, grpboxCorralNumber.Tag.ToString & " wasn't selected.")

            grpboxCorralNumber.Focus()

            Return

        End If


        For i As Integer = grpboxMedals.Controls.Count - 1 To 0 Step -1

            If TypeOf grpboxMedals.Controls(i) Is RadioButton Then

                Dim radbtn As RadioButton = CType(grpboxMedals.Controls(i), RadioButton)

                If Not radbtn.Checked Then

                    MedalCount += 1

                End If


            End If

        Next

        If MedalCount = 2 Then

            errProvider.SetError(grpboxMedals, grpboxMedals.Tag.ToString & " wasn't selected.")

            grpboxMedals.Focus()


            Return

        End If




        waterBottle -= -1

        snack -= -1

        If radbtn5KMedal.Checked Then

            fiveKMedal -= -1

        ElseIf radbtn10KMedal.Checked Then

            tenKMedal -= -1

        Else



        End If

        If radbtn10KMedal.Checked Then

            MedalAwarded = "10K "

        ElseIf radbtn5KMedal.Checked Then

            MedalAwarded = "5K"

        End If


        If radbtnCorralA.Checked Then

            CorralLane = "A"

        ElseIf radbtnCorralB.Checked Then


            CorralLane = "B"

        Else

            CorralLane = "C"

        End If

        If radbtn10KRace.Checked Then

            RaceToRun = "10K"
        Else
            RaceToRun = "5K"

        End If

        ShirtSize = cboShirts.SelectedItem.ToString

        'dgvStudents.DataSource = mStudents.Items()
        'mStudents.Insert(CInt(txtID.Text), txtName.Text, txtMajor.Text)
        mRunner.Insert(CInt(txtBibnumber.Text), txtFirst.Text,
                       txtLast.Text, CInt(txtboxAge.Text),
                       ShirtSize, RaceToRun,
                       CorralLane, MedalAwarded)


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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAge.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True


        End If

        If e.KeyChar = vbBack Then

            e.Handled = False

        End If

    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged

    End Sub
    ''' <summary>
    ''' Key press for the First Name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtFirst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirst.KeyPress

        If Not Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = vbBack Then


            e.Handled = False


        End If


    End Sub

    Private Sub txtLast_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLast.KeyPress


        If Not Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = vbBack Then


            e.Handled = False


        End If


    End Sub
End Class