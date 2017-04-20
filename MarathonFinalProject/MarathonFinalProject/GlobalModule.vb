Module GlobalModule

    'The inventory count

    Public waterBottle As Integer = 16
    'water bottle is item #1
    Public snack As Integer = 16
    'Snack is item #2
    Public fiveKMedal As Integer = 22
    '5K Medal is item #3
    Public tenKMedal As Integer = 9
    '10K Medal is item #4

    Public smallShirt As Integer = 15
    'Small shirt is item #5
    Public mediumShirt As Integer = 14
    'Medium Shirt is item #6
    Public largeShirt As Integer = 25
    'Large Shirt is item #7
    Public xlargeShirt As Integer = 20
    'Xlarge Shirt is item #8

    Public RaceCount As Integer = 0

    Public CorralNumber As Integer = 0

    Public MedalCount As Integer = 0


    'The names of the selected objects respectively.
    Public RaceToRun As String

    Public CorralLane As String

    Public MedalAwarded As String


    Public ShirtSize As String




    Public ItemDictionary As New Dictionary(Of Integer, Integer)





    Public Function Add() As Integer

        Dim supplier As Integer = 10



        Return supplier

        'do something with typeNext

    End Function

    'Click event will send a number,
    'And then it'll compare with the number in the text! :)

    'Loop through the controls-to find textbox.
    'If textbox tag = tag
    'If checkboxed. Then do the function

    'Loop through the controls of the View Inventory.
    'Once you do, check the controls. If textbox is less than 10 AND checkbox is checked.
    'Then add it!

    'For Each cntrl As Control In Me.Controls
    'If TypeOf cntrl Is PictureBox Then
    'If cntrl.BackColor = Color.Black Then
    ''Do Something
    'End If
    'End If

    'You can loop through and do it but if 

End Module
