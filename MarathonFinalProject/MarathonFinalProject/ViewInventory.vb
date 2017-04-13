Public Class frmViewInventory



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ItemDictionary.Add(1, 16)


        ItemDictionary.Add(2, 16)
        ItemDictionary.Add(3, 22)
        ItemDictionary.Add(4, 9)
        ItemDictionary.Add(5, 15)
        ItemDictionary.Add(6, 14)
        ItemDictionary.Add(7, 25)
        ItemDictionary.Add(8, 20)

        txtboxWaterCount.Text = ItemDictionary.Item(1)

        txtboxSnackCount.Text = ItemDictionary.Item(2)

        txt5KMedalCount.Text = ItemDictionary.Item(3)

        txtbox10KMedalCount.Text = ItemDictionary.Item(4)

        txtboxsmallShirtCount.Text = ItemDictionary.Item(5)

        txtboxMediumShirtCount.Text = ItemDictionary.Item(6)

        txtboxLargeShirtCount.Text = ItemDictionary.Item(7)

        txtXlargeShirtCount.Text = ItemDictionary.Item(8)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click



        If chkboxOrder.Checked Then

            For i As Integer = Controls.Count - 1 To 0 Step -1


                If TypeOf Controls(i) Is TextBox Then

                    Dim textbox As TextBox = CType(Me.Controls(i), TextBox)

                    Dim value As Integer = 10
                    Dim newvalue As String


                    If CInt(textbox.Text) < value Then

                        newvalue = (CInt(textbox.Text) + value)

                        textbox.Text = newvalue



                    End If














                End If



            Next



        End If

        'For i As Integer = Controls.Count - 1 To 0 Step -1

        '    If TypeOf Controls(i) Is TextBox Then

        '        Dim textbox As TextBox = CType(Me.Controls(i), TextBox)



        '        Dim value As Integer = 10


        '        If TypeOf Controls(i) Is CheckBox Then

        '            Dim checkbox As CheckBox = CType(Me.Controls(i), CheckBox)

        '            If checkbox.Checked Then

        '                For a As Integer = Controls.Count - 1 To 0 Step -1

        '                Next


        '            End If
        '        End If




        '        End If


        'Dim value As Integer = 10

        'If CheckBox.Checked Then

        '    If CInt(TextBox.Text) < value Then

        '        If CheckBox.Tag = TextBox.Tag Then


        '            MessageBox.Show("Yeah!")

        '        End If

        '    End If

        'End If
        'Next




        'For i As Integer = Controls.Count - 1 To 0 Step -1
        '    Dim cbo As ComboBox = CType(GroupBox1.Controls(i), ComboBox)



        '    If cboCourseNumber.SelectedIndex = -1 Then

        '        errProvider.SetError(cboCourseNumber, "Course Number is not selected.")

        '    End If

        '    If cboGrade.SelectedIndex = -1 Then


        '        errProvider.SetError(cboGrade, "Grade is not selected.")

        '    End If



        'Next

    End Sub
End Class