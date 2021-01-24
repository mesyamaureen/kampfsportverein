Imports System.Data.OleDb

'Module Program
'Sub Main(args As String())
'Console.WriteLine("Hello World!")
'End Sub
'End Module

Public Module Datenbank
    'auf die Datenbank zugreifen
    Dim conn As OleDbConnection

    Public Sub Main()
        oeffnenDbVerbindung()
        schließenDbVerbindung()
    End Sub

    'Oeffnen der Datenbankverbindung
    Private Sub oeffnenDbVerbindung()
        Dim strConnectionString As String
        strConnectionString = My.Settings.ConnectionString

        conn = New OleDbConnection(strConnectionString)
        conn.Open()
    End Sub

    'Schließen der Datenbankverbindung
    Private Sub schließenDbVerbindung()
        If Not (conn Is Nothing) Then
            conn.Close()
        End If
    End Sub

    ''' <summary>
    ''' Abstrakte Oberklasse (MustInherit) für den Datenbankzugriff nach DAO-Muster
    ''' </summary>
    ''' <remarks></remarks>


    ' SQL-Anweisung zur Ermittlung des zuletzt eingefügten Autowertes
    Public Const SQL_SELECT_IDENTITY As String = "SELECT @@IDENTITY;"
    ' Verbindung zur Datenbank
    Public mConnection As OleDbConnection

    ''' <summary>
    ''' Öffnet die Datenbankverbindung entsprechend des in den Eigenschaften eingestellten
    ''' ConnectionStrings.
    ''' </summary>
    ''' <remarks>Änderungen über Projekteigenschaften > Einstellungen > ConnectionString.</remarks>
    Public Sub oeffnenDatenbank()
        Dim strConn As String
        strConn = My.Settings.ConnectionString

        If mConnection Is Nothing Then
            mConnection = New OleDbConnection(strConn)
        End If

        If mConnection.State = ConnectionState.Closed Then
            mConnection.Open()
        End If

    End Sub

    ''' <summary>
    ''' Schließt die aktuell geöffnete Datenbankverbindung.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub schliessenDatenbank()
        If mConnection IsNot Nothing Then
            If Not (mConnection.State = ConnectionState.Closed) Then
                mConnection.Close()
                mConnection = Nothing
            End If
        End If
    End Sub

    ''' <summary>
    ''' Ermittelt den zuletzt als Autowert vergebenen Wert und liefert ihn zurück. 
    ''' </summary>
    ''' <returns>Zuletzt als Autowert vergebener Wert</returns>
    ''' <remarks>Diese Funktion muss mit der selben Daenbankverbindung und ggf. innerhalb 
    ''' der selben Transaktion aufgerufen werden, wie die vorangegangene Einfüge-Operation.</remarks>
    Public Function ermittleId()
        Dim lngIdPk As Long
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(SQL_SELECT_IDENTITY, mConnection)
        lngIdPk = Long.Parse(cmd.ExecuteScalar())
        Return lngIdPk
    End Function







End Module
