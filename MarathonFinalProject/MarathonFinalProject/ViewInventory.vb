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



        txtboxWaterCount.Text = waterBottle

        txtboxSnackCount.Text = snack

        txt5KMedalCount.Text = fiveKMedal

        txtbox10KMedalCount.Text = tenKMedal

        txtboxsmallShirtCount.Text = smallShirt

        txtboxMediumShirtCount.Text = mediumShirt

        txtboxLargeShirtCount.Text = largeShirt

        txtXlargeShirtCount.Text = xlargeShirt

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        errProvider1.Clear()

        If chkboxOrder.Checked Then

            For i As Integer = Controls.Count - 1 To 0 Step -1


                If TypeOf Controls(i) Is TextBox Then

                    Dim textbox As TextBox = CType(Me.Controls(i), TextBox)

                    Dim value As Integer = 10
                    Dim newvalue As String


                    If CInt(textbox.Text) < value Then

                        newvalue = (CInt(textbox.Text) + value)

                        textbox.Text = newvalue

                    Else
                        StatusLabel.Text = "Inventory are sufficient."


                    End If

                End If



            Next

        Else

            errProvider1.SetError(chkboxOrder, chkboxOrder.Tag & " is not checked.")

            chkboxOrder.Focus()


            Return


        End If


    End Sub
End Class