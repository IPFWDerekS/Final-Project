Public Class Runner



    Private adapter As New RunnerDataSetTableAdapters.RunnerTableAdapter

    Public ReadOnly Property Items() As DataTable

        Get
            Dim table As DataTable = adapter.GetData()

            Return table

        End Get


    End Property

    Public Function Insert(ByVal pBib As Integer, ByVal pFirst As String,
                           ByVal pLast As String, ByVal pAge As Integer,
                           ByVal pShirtSize As String, ByVal pRace As String,
                           ByVal pCorral As String, ByVal pMedal As String) As Boolean

        Dim result As Boolean = False

        Try

            If adapter.Insert(pBib, pFirst, pLast, pAge, pShirtSize, pRace, pCorral, pMedal) Then

                result = True


            End If

        Catch ex As Exception



        End Try

        Return result

    End Function


End Class
'Public Function Insert(ByVal pID As Integer, ByVal pName As String, ByVal PMajor As String) As Boolean

'    Dim result As Boolean = False


'    Try
'        If adapter.Insert(pID, pName, PMajor) > 0 Then

'            LastStatus = "Record added to the database."

'            result = True

'        Else
'            LastStatus = "Error adding to the database."


'        End If





'    Catch ex As Exception

'        LastStatus = "Exception thrown adding to the database."

'    End Try

'    Return result


'End Function
