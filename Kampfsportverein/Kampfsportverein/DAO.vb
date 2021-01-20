Public Class DAO


    ''' <summary>
    ''' Abstrakte Oberklasse (MustInherit) für den Datenbankzugriff nach DAO-Muster
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class DAO

        ' SQL-Anweisung zur Ermittlung des zuletzt eingefügten Autowertes
        Protected Const SQL_SELECT_IDENTITY As String = "SELECT @@IDENTITY;"
        ' Verbindung zur Datenbank
        Protected mConnection As OleDbConnection

        ''' <summary>
        ''' Öffnet die Datenbankverbindung entsprechend des in den Eigenschaften eingestellten
        ''' ConnectionStrings.
        ''' </summary>
        ''' <remarks>Änderungen über Projekteigenschaften > Einstellungen > ConnectionString.</remarks>
        Protected Sub oeffnenDatenbank()
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
        Protected Sub schliessenDatenbank()
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
        Protected Function ermittleId()
            Dim lngIdPk As Long
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(SQL_SELECT_IDENTITY, mConnection)
            lngIdPk = Long.Parse(cmd.ExecuteScalar())
            Return lngIdPk
        End Function

    End Class



End Class
