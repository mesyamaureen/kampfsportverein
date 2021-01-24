Imports Kampfsportvereinverwaltung
Imports System.Data.OleDb


Public Class DAO

    Private Const SQL_DELETE_BY_VERSION As String = "DELETE FROM @table WHERE SaIdPk = @IdPk AND SaVersion = @Version;"
    Private Const SQL_SELECT_SPORTART As String = "SELECT * FROM @table WHERE @Suchfeld = @Suchbegriff"
    'Eintrag Löschen
    Public Function ElementLoeschen(pstrTable As String, plngIdPk As Long, plngVersion As Long) As Boolean
        oeffnenDatenbank()

        Dim cmd As OleDbCommand
        Dim bytresult As Byte
        cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
        '''Optional: Prüfung ob Datensatz vorhanden ist
        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@IdPk", plngIdPk)
        cmd.Parameters.AddWithValue("@table", pstrTable)
        cmd.Parameters.AddWithValue("@Version", plngVersion)

        bytresult = cmd.ExecuteNonQuery()

        schliessenDatenbank()
        Return (1 = bytresult)

    End Function

    'Muss in die unterklassen
    Public Function SucheMitQuery(pstrTable As String, pstrSuchfeld As String, pstrSuchbegriff As String) As OleDbDataReader

        oeffnenDatenbank()

        Dim dr As OleDbDataReader
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)

        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@Suchbegriff", pstrSuchbegriff)
        cmd.Parameters.AddWithValue("@SuchFeld", pstrSuchfeld)
        cmd.Parameters.AddWithValue("@table", pstrTable)

        dr = cmd.ExecuteReader

        schliessenDatenbank()
        Return dr

    End Function



End Class

