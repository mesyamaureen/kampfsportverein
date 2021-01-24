Public Class TrainerDAO
    Inherits DAO

    'SQL-Anweisung, um alle Schüler zu ermitteln
    Private Const SQL_SELECT_Schueler As String = SELECT * FROM tblSchueler

    ' 'SQL-Anweisung, um Schueler nach ID zu filtern
    'Private Const SQL_SELECT_SCHUELER_BY_SAID As String = SELECT * FROM tblSchueler WHERE SaIdPk = @IdPk"

    ' SQL-Anweisung, um einen Schueler neu hinzuzufügen
    Private Const SQL_INSERT As String = INSERT INTO tblSchueler(SchuIdPk, SchuVorname, SchuName, SchuEMail, SchuVersion)" &
        "VALUES @vorname, @name, @email, @version

    ' SQL-Anweisung, um eine Schueler zu löschen
    Private Const SQL_DELETE_BY_VERSION As String = DELETE FROM tblSchueler WHERE SchuIdPk = @IdPk And SchuVersion = @Version
    Public Sub findenAlleMitSchuelerId(plngIdPk As Long) As List(Of Schueler)

        'Deklaratiom
        'Eigenschaften der Schueler
        Dim lngIdPk As Long
        Dim strName As String
        Dim strVorname As String
        Dim strEmail As String
        Dim lngVersion As Long

        'Aufgabe Schuelerliste
        Dim schu As Schueler
        Dim lstSchueler As List(Of Schueler)

        'Datenbank Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader


        'Initialisierung der Schuelerliste
        schu = Nothing
        lstSchueler = New List(Of Schueler)

        'Datebankverbindung oeffnen
        Main()
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_BY_BENUTZERID, mConnection)

        'Platzhalter ersetzen
        cmd.Parameter.AddWithValue(plngIdPk)

        dr = cmd.ExecuteReader

        Do While dr.Read

            lngIdPk = Long.Parse(dr(SchuIdPk))
            strName = dr(SchuName))
            strVorname = (dr(SchuVorname))
            strEmail = (dr(SchuEMail))
            lngVersion = Long.Parse(dr(SchuVersion))

            schu = New Schueler(lngIdPk, strName, strVorname, strEmail, lngVersion)

        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstSchueler
    End Sub

    Public Sub findenMitBenutzernamePasswort()

    End Sub

End Class
Public Function loeschenMitSchuelerId(plngIdPk As Long, plngVersion As Long) As Boolean

    'Deklaration
    Dim lngAnzahlDatensätze As Long
    Dim cmd As OleDbCommand

    oeffnenDatenbank()

    cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
    cmd.Parameters.AddWithValue(plngIdPk)
    cmd.Parameters.AddWithValue(@version, plngVersion)

    lngAnzahlDatensätze = cmd.ExecuteNonQuery()

    schliessenDatenbank()

    If lngAnzahlDatensätze = 1 Then
        Return True
    Else Return False
    End If

End Function
Public Function Speichern() As Integer

    Return 0
End Function

Public Function hinzufuegen(pSchu As Schueler) As Long

    Dim lngAnzahlDatensätze As Long
    Dim lngIdPk As Long
    Dim cmd As OleDbCommand

    lngIdPk = -1
    cmd = New OleDbCommand(SQL_INSERT, mConnection)
    cmd.Parameters.AddWithValue(@name, pSchu.Name)
    cmd.Parameters.AddWithValue(@vorname, pSchu.Vorname)
    cmd.Parameters.AddWithValue(@email, pSchu.email)
    cmd.Parameters.AddWithValue(@version, pSchu.Version)

    lngAnzahlDatensätze = cmd.ExecuteNonQuery
    If lngAnzahlDatensätze = 1 Then
        lngAnzahlDatensätze = ermittleId()
    End If
    schliessenDatenbank()
    Return lngIdPk


End Function