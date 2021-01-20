Imports System.Data.OleDb

'Module Program
'Sub Main(args As String())
'Console.WriteLine("Hello World!")
'End Sub
'End Module

Module Datenbank
    'auf die Datenbank zugreifen
    Dim conn As OleDbConnection

    Public Sub Main()
        oeffnenDbVerbindung()
        schlie�enDbVerbindung()
    End Sub

    'Oeffnen der Datenbankverbindung
    Private Sub oeffnenDbVerbindung()
        Dim strConnectionString As String
        strConnectionString = My.Settings.ConnectionString

        conn = New OleDbConnection(strConnectionString)
        conn.Open()
    End Sub

    'Schlie�en der Datenbankverbindung
    Private Sub schlie�enDbVerbindung()
        If Not (conn Is Nothing) Then
            conn.Close()
        End If
    End Sub
End Module
