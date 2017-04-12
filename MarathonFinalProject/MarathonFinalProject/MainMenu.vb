Public Class frmMainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The main form the user will use is 
        'a Form that has 3 buttons Or 
        '3 menustrip buttons to open 3 other forms.
        'So there are 4 forms in total. 
        'One of the three Is the 'Add runner’ 
        'Form, this form will have:  3 Textboxes; f
        'Or Name, Age, BIB Number. 1 combobox for 
        'the shirt sizes: small, medium , large, 
        'extra large. 5 radio Button for either5K '
        'Or 10K, then the rest for the Corral A, B, C.
        '4 Check boxes for the inventory: water bottle, snacks,
        '5K Medal, 10K Medal. 3 Button called; 'Submit’, 
        'Clear’, and ‘Exit’. A second will ‘Runners Form’ will 
        'have a data grid view of the Runners. It'll enable the
        'user to search and select runners. Fourth form is 'View Inventory’, 
        'where the user will see the amount Of the water, snacks, medals, And shirts.




    End Sub

    Private Sub VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuitemRunnerForm.Click

        frmViewRunner.ShowDialog()

    End Sub

    Private Sub menustrpbtnAddRunner_Click(sender As Object, e As EventArgs) Handles menustrpbtnAddRunner.Click

        frmAddRunner.ShowDialog()


    End Sub

    Private Sub menustrpViewInventory_Click(sender As Object, e As EventArgs) Handles menustrpViewInventory.Click


        frmViewInventory.ShowDialog()


    End Sub

    Private Sub menustrpExit_Click(sender As Object, e As EventArgs) Handles menustrpExit.Click

    End Sub
End Class
