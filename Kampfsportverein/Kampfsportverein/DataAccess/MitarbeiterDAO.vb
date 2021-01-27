Imports Kampfsportvereinverwaltung
Imports System.Data.OleDb

Public Class MitarbeiterDAO
    Inherits DAO

    'SQL-Anweisung, um einen Mitarbeiter anhand des Benutzernamens und des Passwortes zu ermitteln
    Private Const SQL_SELECT_BY_BENUTZERNAME_PASSWORT As String = "SELECT * FROM tblBenutzer/Mitarbeiter/Trainer WHERE BenBenutzerName = @benutzername AND BenPw = @passwort;"

    'SQL-Anweisung, um einen Mitarbeiter anhand der ID zu ermitteln
    Private Const SQL_SELECT_BY_ID As String = "SELECT * FROM tblBenutzer/Mitarbeiter/Trainer WHERE BenIdPk = @idPk;"

    'SQL-Anweisung, um alle Mitarbeiter zu ermitteln
    Private Const SQL_SELECT_ALL As String = "SELECT * FROM tblBenutzer/Mitarbeiter/Trainer;"

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

    Private Const SQL_SELECT_SPORTART_BY_ID As String = "SELECT FROM tblSportarten WHERE SaIdPk = @SaIdPk"

    Public Function findenMitBenutzernamePasswort(pstrBenutzername As String, pstrPasswort As String)
        'Deklaration
        'Alle Eigenschaften eines Benutzers
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long
        Dim intTyp As Integer

        'Gesuchter Benutzer
        Dim ben As Benutzer

        'Alles für den Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        ben = Nothing

        'Datenbank oeffnen
        oeffnenDatenbank()
        'Kommando für Datenbankzugriff
        cmd = New OleDbCommand(SQL_SELECT_BY_BENUTZERNAME_PASSWORT, mConnection)
        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@benutzername", pstrBenutzername)
        cmd.Parameters.AddWithValue("@passwort", pstrPasswort)
        'Ausführen der Anweisung
        dr = cmd.ExecuteReader()
        'Wenn etwas gefunden wurde - vergleich mit diesen Angaben
        If dr.Read Then
            lngBenutzerIdPk = Long.Parse(dr("BenIdPk"))
            strBenutzername = dr("BenBenutzerName")
            strPasswort = dr("BenPw")
            strVorname = dr("BenVorname")
            strName = dr("BenName")
            lngVersion = Long.Parse(dr("BenVersion")) 'soll hier eine neue Eigenschaft bei Benutzer.vb hinzugefügt werden?
            intTyp = Integer.Parse(dr("BenTyp")) 'soll hier eine neue Eigenschaft bei Benutzer.vb hinzugefügt werden?

            ben = New Benutzer(strBenutzername, strPasswort, strVorname, strName, lngBenutzerIdPk) 'lngVersion, intTyp? -mesya
        End If
        dr.Close()
        schliessenDatenbank()
        'Rückgabe des Benutzers
        Return ben
    End Function

    Public Function findenAlleSportarten() As List(Of Sportart)

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

        'Initialisierung Liste
        spor = Nothing
        lstSport = New List(Of Sportart)

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_SPORTART, mConnection)
        dr = cmd.ExecuteReader

        Do While dr.Read

            lngIdPk = Long.Parse(dr("SaIdPk"))
            strName = dr("SaName")
            strHerkunft = dr("SaHerkunft")
            strZielgruppe = dr("SaZielgruppe")
            bytMindestalter = Byte.Parse(dr("SaMindestalter"))
            lngVersion = Long.Parse(dr("SaVersion"))

            spor = New Sportart(lngIdPk, strName, strHerkunft, strZielgruppe, bytMindestalter, lngVersion)
            lstSport.Add(spor)
        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstSport
    End Function

    Public Function findeSportart(plngIdPk) As Sportart

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

        'Initialisierung Liste
        spor = Nothing

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_SPORTART, mConnection)
        cmd.Parameters.AddWithValue("@SaIdPk", plngIdPk)

        dr = cmd.ExecuteReader

        lngIdPk = Long.Parse(dr("SaIdPk"))
            strName = dr("SaName")
            strHerkunft = dr("SaHerkunft")
            strZielgruppe = dr("SaZielgruppe")
            bytMindestalter = Byte.Parse(dr("SaMindestalter"))
            lngVersion = Long.Parse(dr("SaVersion"))

            spor = New Sportart(lngIdPk, strName, strHerkunft, strZielgruppe, bytMindestalter, lngVersion)

            dr.Close()
        schliessenDatenbank()
        Return spor

    End Function


    Public Function loeschenMitSportartId(plngIdPk As Long, plngVersion As Long) As Boolean
        Return ElementLoeschen("tblSportarten", plngIdPk, plngVersion)
        'Deklaration
        'Dim lngAnzahlDatensätze As Long
        'Dim cmd As OleDbCommand

        'oeffnenDatenbank()

        'cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
        'cmd.Parameters.AddWithValue("@IdPk", plngIdPk)
        'cmd.Parameters.AddWithValue("@version", plngVersion)

        'lngAnzahlDatensätze = cmd.ExecuteNonQuery()

        'schliessenDatenbank()

        'If lngAnzahlDatensätze = 1 Then
        'Return True
        'Else Return False
        'End If

    End Function

    Public Function speichern(pSport As Sportart) As Long

        ' Deklarationen
        Dim lngIdPK As Long ' zurückzugebender Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufagbe

        ' Wenn die Aufgabe bereits als Datensatz gespeichert ist (also ihr Primärschlüsselwert > 0 ist)
        If pSport.ID > 0 Then
            ' Muss die Aufgabe aktualisiert werden 
            lngIdPK = aktualisieren(pSport)
        Else
            ' Andernfalls muss die Aufgabe neu hinzugefügt werden
            lngIdPK = hinzufuegen(pSport)
        End If

        ' Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufgabe zurückliefern
        Return lngIdPK

    End Function


    Private Function aktualisieren(pSpor As Sportart) As Long
        ' Deklarationen
        Dim lngIdPk As Long ' Primärschlüssel des zu aktualisierenden Datensatzes
        Dim lngAnzahlDatensätze As Long ' Anzahl der von der Operation betroffenen Datensätze
        Dim cmd As OleDbCommand ' Kommando für den Datenbankzugriff

        ' Initialisierung
        lngIdPk = -1 ' Wert für Primärschlüssel, der erkennbar macht, dass Datensatz (noch) nicht aktualisierenden wurde


        'Öffnen der Datenbankverbindung durch geerbte Methode der Oberklasse
        oeffnenDatenbank()

        ' Kommando für den Datenbankzugriff vorbereiten
        ' SQL-Anweisung aus Konstante verwenden (Deklaration oben) und initialisierte Datenbankverbindung (aus Oberklasse geerbt)
        cmd = New OleDbCommand(SQL_UPDATE, mConnection)

        ' Platzhalter in der SQL-Anweisung durch Eigenschaften der als Parameter übergebenen Aufgabe ersetzen
        ' Wichtig: Bei Zugriff auf MS Access-Datenbank müssen die Parameter in der Reihenfolge befüllt werden,
        ' in der sie in der SQL-Anweisung vorkommen (z.B. erst Titel und dann Beschreibung)!
        cmd.Parameters.AddWithValue("@name", pSpor.Name)
        cmd.Parameters.AddWithValue("@herkunft", pSpor.Herkunftsland)
        cmd.Parameters.AddWithValue("@zielgruppe", pSpor.Zielgruppe)
        cmd.Parameters.AddWithValue("@mindestalter", pSpor.Mindestalter)
        cmd.Parameters.AddWithValue("@version", pSpor.Version)
        cmd.Parameters.AddWithValue("@idPk", pSpor.ID)


        ' Ausführen des Kommandos, als Ergebnis die Anzahl betroffener Datensätze merken
        lngAnzahlDatensätze = cmd.ExecuteNonQuery

        ' Wenn ein Datensatz betroffen ist
        If lngAnzahlDatensätze = 1 Then
            ' Aktualisieren war erfolgreich, nun Primärschlüssel als Ergebnis zurückliefern
            lngIdPk = pSpor.ID
        End If

        'Schließen der Datenbankverbindung durch geerbte Methode der Oberklasse
        schliessenDatenbank()

        ' Rückgabe des Primärschlüssel-Wertes der aktualisierten Aufgabe
        Return lngIdPk

    End Function

    ''' <summary>
    ''' Hinzufügen einer neuen Aufgabe, indem diese als Datenstaz in die Tabelle tblAufgaben eingefügt wird
    ''' </summary>
    ''' <param name="pSpor">Zu speichernde neue Aufgabe</param>
    ''' <returns>Liefert die ID der neu eingefügten Aufgabe zurück. Wenn das Einfügen fehlschlug, wird -1 zurückgeliefert.</returns>
    ''' <remarks></remarks>
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
