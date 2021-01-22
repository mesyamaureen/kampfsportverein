Public Class MitarbeiterDAO
    Inherits DAO

    'SQL-Anweisung, um alle Sportarten zu ermitteln
    Private Const SQL_SELECT_SPORTART As String = "SELECT * FROM tblSportarten"

    ' 'SQL-Anweisung, um eine Sportart nach ID zu filtern - benötigt?
    'Private Const SQL_SELECT_SPORTART_BY_SAID As String = "SELECT * FROM tblSportarten WHERE SaIdPk = @IdPk"

    ' SQL-Anweisung, um eine Aufgabe zu aktualisieren
    Private Const SQL_UPDATE As String = "UPDATE tblSportarten SET SaName = @name, SaHerkunft = @herkunft, SaZielgruppe = @zielgruppe, SaMindestalter = @mindestalter, SaVersion = @version"

    ' SQL-Anweisung, um eine Sportart neu hinzuzufügen
    Private Const SQL_INSERT As String = "INSERT INTO tblSportarten(SaName, SaHerkunft, SaZielgruppe, SaMindestalter, SaVersion)" &
        "VALUES @name, @herkunft, @zielgruppe, @mindestalter, @version"


    ' SQL-Anweisung, um eine Sportart zu löschen
    Private Const SQL_DELETE_BY_VERSION As String = "DELETE FROM tblSportart WHERE SaIdPk = @IdPk AND SaVersion = @Version;"






    Public Function findenAlleMitBenutzerId(plngIdPk As Long) As List(Of Sportart)

        'Deklaratiom
        'Eigenschaften der Sportart
        Dim lngIdPk As Long
        Dim strName As String
        Dim strHerkunft As String
        Dim strZielgruppe As String
        Dim bytMindestalter As Byte
        Dim lngVersion As Long

        'Aufgabe und Aufgabenliste
        Dim spor As Sportart
        Dim lstSport As List(Of Sportart)

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader


        'Initialisierung Liste
        spor = Nothing
        lstSport = New List(Of Sportart)


        'Öffnen DBVerbindung durch Methode

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_BY_BENUTZERID, mConnection)

        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@IdPk", plngIdPk)

        dr = cmd.ExecuteReader

        Do While dr.Read

            lngIdPk = Long.Parse(dr("SaIdPk"))
            strName = dr("SaName")
            strHerkunft = dr("SaHerkunft")
            strZielgruppe = dr("SaZielgruppe")
            bytMindestalter = Byte.Parse(dr("SaMindestalter"))
            lngVersion = Long.Parse(dr("SaVersion"))


            spor = New Sportart(lngIdPk, strName, strHerkunft, strZielgruppe, bytMindestalter, lngVersion)

        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstSport

    End Function

    Public Sub findenMitBenutzerId()

    End Sub

    Public Sub loeschen()



    End Sub

    Public Function loeschenMitSportartId(plngIdPk As Long, plngVersion As Long) As Boolean

        'Deklaration
        Dim lngAnzahlDatensätze As Long
        Dim cmd As OleDbCommand

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
        cmd.Parameters.AddWithValue("@IdPk", plngIdPk)
        cmd.Parameters.AddWithValue("@version", plngVersion)

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


    Public Function hinzufuegen(pSportart As Sportart) As Long

        Dim lngAnzahlDatensätze As Long
        Dim lngIdPk As Long
        Dim cmd As OleDbCommand

        lngIdPk = -1
        cmd = New OleDbCommand(SQL_INSERT, mConnection)
        cmd.Parameters.AddWithValue("@name", pSportart.Name)
        cmd.Parameters.AddWithValue("@herkunft", pSportart.Herkunftsland)
        cmd.Parameters.AddWithValue("@zielgruppe", pSportart.Zielgruppe)
        cmd.Parameters.AddWithValue("@mindestalter", pSportart.Mindestalter)
        cmd.Parameters.AddWithValue("@version", pSportart.Version)

        lngAnzahlDatensätze = cmd.ExecuteNonQuery
        If lngAnzahlDatensätze = 1 Then
            lngAnzahlDatensätze = ermittleId()
        End If
        schliessenDatenbank()
        Return lngIdPk


    End Function





End Class
