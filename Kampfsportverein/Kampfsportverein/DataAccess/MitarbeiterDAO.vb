Imports Kampfsportvereinverwaltung
Imports System.Data.OleDb

Public Class MitarbeiterDAO
    Inherits DAO

    'SQL-Anweisung, um einen Mitarbeiter anhand des Benutzernamens und des Passwortes zu ermitteln
    Private Const SQL_SELECT_BY_BENUTZERNAME_PASSWORT As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenBenutzerName = @benutzername AND BenPw = @passwort AND BenTyp = 'M';"

    'SQL-Anweisung, um einen Mitarbeiter anhand der ID zu ermitteln
    Private Const SQL_SELECT_BY_ID As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenIdPk = @idPk;"

    'SQL-Anweisung, um alle Sportarten zu ermitteln
    Private Const SQL_SELECT_SPORTART As String = "SELECT * FROM tblSportarten"

    ' SQL-Anweisung, um eine Sportart zu aktualisieren
    Private Const SQL_UPDATE As String = "UPDATE tblSportarten SET SaName = @name, SaHerkunftsland = @herkunft, SaZielgruppe = @zielgruppe, SaMindestalter = @mindestalter, SaVersion = @version WHERE SaIdPk = @idPk "

    ' SQL-Anweisung, um eine Sportart neu hinzuzufügen
    Private Const SQL_INSERT As String = "INSERT INTO tblSportarten(SaName, SaHerkunftsland, SaZielgruppe, SaMindestalter, SaVersion) VALUES (@name, @herkunft, @zielgruppe, @mindestalter, @version)"

    ' SQL-Anweisung, um eine Sportart zu löschen
    Private Const SQL_DELETE_SA_BY_VERSION As String = "DELETE FROM tblSportarten WHERE SaIdPk = @IdPk AND SaVersion = @Version;"

    'SQL-Anweisung, um eine Sportart anhand der ID zu ermitteln
    Private Const SQL_SELECT_SPORTART_BY_ID As String = "SELECT * FROM tblSportarten WHERE SaIdPk = @SaIdPk"

    'SQL-Anweisung, um einen Kurs anhand der Benutzer
    Private Const SQL_SELECT_KURS_BY_BENUTZERID As String = "SELECT * FROM tblKurse WHERE KuBenIdFk = @kBenIdFk"

    'SQL-Anweisung, um einen Kurs nach ID zu ermitteln
    Private Const SQL_SELECT_KURS_BY_ID As String = "SELECT * FROM tblKurse WHERE KuIdPk = @kIdPk"

    'SQL-Anweisung, um alle Kurse zu ermitteln
    Private Const SQL_SELECT_KURS As String = "SELECT * FROM tblKurse"

    'SQL-Anweisung, um Kurse nach Sportart zu ermitteln
    Private Const SQL_SELECT_KURS_BY_SPORTART As String = "SELECT * FROM tblKurse WHERE KuSaIdFk = @kSaIdFk"

    'SQL-Anweisung, um Kurse zu aktualisieren
    Private Const SQL_UPDATE_KURS As String = "UPDATE tblKurse SET KuZeitpunkt = @kZeitpunkt, KuOrt = @kOrt, KuTeilnehmerZahl = @kTeilnehmer, KuSchwierigkeit = @kSchwierigkeit, KuVersion = @kVersion WHERE KuIdPk = @kIdPk;"

    'SQL-Anweisung, um neuer Kurs hinzufügen
    Private Const SQL_INSERT_KURS As String = "INSERT INTO tblKurse(KuZeitpunkt, KuOrt, KuTeilnehmerzahl, KuSchwierigkeit, KuSaIdFk, KuBenIdFk, KuVersion) VALUES (@KuZeitpunkt, @KuOrt, @KuTeilnehmerzahl, @KuSchwierigkeit, @KuSaIdFk, @KuBenIdFk, @version)"

    'SQL-Anweisung, um einen Kurs zu löschen
    Private Const SQL_DELETE_BY_VERSION_KURS As String = "DELETE FROM tblKurse WHERE KuIdPk = @KuIdPk AND KuVersion = @version;"

    ' SQL-Anweisung, um einen Mitarbeiter zu aktualisieren
    Private Const SQL_UPDATE_MITARBEITER As String = "UPDATE [tblBenutzer/Mitarbeiter/Trainer] SET BenName = @BenName, BenBenutzername = @BenBenutzername, BenPw = @BenPw, BenVersion = @BenVersion WHERE BenIdPk = @BenIdPk"

    ' SQL-Anweisung, um einen Mitarbeiter neu hinzuzufügen
    Private Const SQL_INSERT_MITARBEITER As String = "INSERT INTO [tblBenutzer/Mitarbeiter/Trainer] (BenVorname, BenName, BenBenutzername, BenPw, BenTyp, BenVersion) VALUES (@BenVorname, @BenName, @BenBenutzername, @BenPw, M, @BenVersion)"


    'finden Mitarbeiter zur Anmeldung
    Public Function findenMitBenutzernamePasswort(pstrBenutzername As String, pstrPasswort As String)
        'Deklaration
        'Alle Eigenschaften eines Benutzers
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long
        Dim charTyp As Char

        'Gesuchter Benutzer
        Dim mit As Mitarbeiter

        'Alles für den Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        mit = Nothing

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
            lngVersion = Long.Parse(dr("BenVersion"))
            charTyp = Char.Parse(dr("BenTyp"))

            mit = New Mitarbeiter(strBenutzername, strPasswort, strVorname, strName, lngBenutzerIdPk, lngVersion, charTyp)
        End If
        dr.Close()
        schliessenDatenbank()
        'Rückgabe des Benutzers
        Return mit
    End Function

    'Mitarbeiter auswählen anhand Benutzer ID
    Public Function findenMitarbeiterId(plngBenIdPk As Long) As Mitarbeiter
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim charTyp As Char
        Dim lngVersion As Long

        'Gesuchter Benutzer
        Dim mit As Mitarbeiter

        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        mit = Nothing
        oeffnenDatenbank()
        cmd = New OleDbCommand(SQL_SELECT_BY_ID, mConnection)
        cmd.Parameters.AddWithValue("@BenIdPk", plngBenIdPk)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lngBenutzerIdPk = Long.Parse(dr("BenIdPk"))
            strBenutzername = dr("BenBenutzerName")
            strPasswort = dr("BenPw")
            strVorname = dr("BenVorname")
            strName = dr("BenName")
            charTyp = Char.Parse(dr("BenTyp"))
            lngVersion = Long.Parse(dr("BenVersion"))
            mit = New Mitarbeiter(strBenutzername, strPasswort,
                                  strVorname, strName, lngBenutzerIdPk,
                                  lngVersion, charTyp)
        End If
        dr.Close()
        schliessenDatenbank()
        Return mit
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
            strHerkunft = dr("SaHerkunftsland")
            strZielgruppe = dr("SaZielgruppe")
            bytMindestalter = Byte.Parse(dr("SaMindestalter"))
            lngVersion = Long.Parse(dr("SaVersion"))

            spor = New Sportart(lngIdPk, strName, strHerkunft,
                                strZielgruppe, bytMindestalter, lngVersion)
            lstSport.Add(spor)
        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstSport
    End Function

    Public Function findeSportart(plngIdPk As Long) As Sportart

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

        cmd = New OleDbCommand(SQL_SELECT_SPORTART_BY_ID, mConnection)
        cmd.Parameters.AddWithValue("@SaIdPk", plngIdPk)

        dr = cmd.ExecuteReader
        If dr.Read() Then
            lngIdPk = Long.Parse(dr("SaIdPk"))
            'Debug.Print(lngIdPk)
            strName = dr("SaName")
            strHerkunft = dr("SaHerkunftsland")
            strZielgruppe = dr("SaZielgruppe")
            bytMindestalter = Byte.Parse(dr("SaMindestalter"))
            lngVersion = Long.Parse(dr("SaVersion"))

            spor = New Sportart(lngIdPk, strName, strHerkunft, strZielgruppe, bytMindestalter, lngVersion)
        End If
        dr.Close()
        schliessenDatenbank()
        Return spor

    End Function


    Public Shared Function loeschenMitSportartId(plngIdPk As Long, plngVersion As Long) As Boolean
        'Deklaration
        Dim lngAnzahlDatensätze As Long
        Dim cmd As OleDbCommand

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_DELETE_SA_BY_VERSION, mConnection)
        cmd.Parameters.AddWithValue("@IdPk", plngIdPk)
        cmd.Parameters.AddWithValue("@version", plngVersion)

        lngAnzahlDatensätze = cmd.ExecuteNonQuery()

        schliessenDatenbank()

        If lngAnzahlDatensätze = 1 Then
            Return True
        Else Return False
        End If

    End Function

    Public Shared Function speichern(pSport As Sportart) As Long

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


    Private Shared Function aktualisieren(pSpor As Sportart) As Long
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


    Private Shared Function hinzufuegen(pSportart As Sportart) As Long

        Dim lngAnzahlDatensätze As Long
        Dim lngIdPk As Long
        Dim cmd As OleDbCommand

        lngIdPk = -1

        oeffnenDatenbank()

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

    'finden Alle Kurse nach zugeordneter Sportart
    Public Function findenAlleSaKurse(pSportart As Sportart) As List(Of Kurs)

        'Deklaration der Eigenschaften des Kurs
        Dim lngKursIdPk As Long
        Dim datKursZeitpunkt As Date
        Dim strKursOrt As String
        Dim intKursTeilnZahl As Integer
        Dim strKursSchwierigkeit As String
        Dim lngSportartIdFk As Long
        Dim lngBenIdFK As Long
        Dim lngVersion As Long

        'Aufgabe und Aufgabenliste
        Dim kurs As Kurs
        Dim lstKurs As List(Of Kurs)

        'Initialisierung Liste
        kurs = Nothing
        lstKurs = New List(Of Kurs)

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_KURS_BY_SPORTART, mConnection)
        Dim paramId As Long = pSportart.ID
        'cmd.Parameters.AddWithValue("@KuSaIdFk", lngSportartIdFk)
        cmd.Parameters.AddWithValue("@KuSaIdFk", paramId)
        dr = cmd.ExecuteReader

        Do While dr.Read

            lngKursIdPk = Long.Parse(dr("KuIdPk"))
            datKursZeitpunkt = Date.Parse(dr("KuZeitpunkt"))
            strKursOrt = dr("KuOrt")
            intKursTeilnZahl = Integer.Parse(dr("KuTeilnehmerzahl"))
            strKursSchwierigkeit = dr("KuSchwierigkeit")
            lngSportartIdFk = paramId
            lngBenIdFK = Long.Parse(dr("KuBenIdFk"))
            lngVersion = Long.Parse(dr("KuVersion"))

            kurs = New Kurs(lngKursIdPk, datKursZeitpunkt, strKursOrt, intKursTeilnZahl, strKursSchwierigkeit,
                            lngSportartIdFk, lngBenIdFK, lngVersion)

            lstKurs.Add(kurs) 'Neuer Kurs zur Liste der Kursen hinzufügen
        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstKurs
    End Function

    'findenAlleKurse
    Public Function findeAlleKurse() As List(Of Kurs)

        'Deklaration der Eigenschaften des Kurs
        Dim lngKursIdPk As Long
        Dim datKursZeitpunkt As Date
        Dim strKursOrt As String
        Dim intKursTeilnZahl As Integer
        Dim strKursSchwierigkeit As String
        Dim lngSaIdFk As Long
        Dim lngBenIdFk As Long
        Dim lngVersion As Long

        'Aufgabe und Aufgabenliste
        Dim kurs As Kurs
        Dim lstKurs As List(Of Kurs)

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        'Initialisierung Liste
        kurs = Nothing
        lstKurs = New List(Of Kurs)

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_KURS, mConnection)
        dr = cmd.ExecuteReader
        Do While dr.Read()
            lngKursIdPk = Long.Parse(dr("KuIdPk"))
            datKursZeitpunkt = Date.Parse(dr("KuZeitpunkt"))
            strKursOrt = dr("KuOrt")
            intKursTeilnZahl = Integer.Parse(dr("KuTeilnehmerzahl"))
            strKursSchwierigkeit = dr("KuSchwierigkeit")
            lngSaIdFk = Long.Parse(dr("KuSaIdFk"))
            lngBenIdFk = Long.Parse(dr("KuBenIdFk"))
            lngVersion = Long.Parse(dr("KuVersion"))

            'Neuer Kurs erzeugen und mit den gelesenen Werten initialisieren
            kurs = New Kurs(lngKursIdPk, datKursZeitpunkt, strKursOrt, intKursTeilnZahl,
                            strKursSchwierigkeit, lngSaIdFk, lngBenIdFk, lngVersion)

            lstKurs.Add(kurs)
        Loop
        dr.Close()
        schliessenDatenbank()
        Return lstKurs
    End Function

    'finden Kurs von Benutzer
    Public Function findenBenKurs(pBenutzer As Benutzer) As List(Of Kurs)
        'Deklaration der Eigenschaften des Kurs
        Dim lngKursIdPk As Long
        Dim datKursZeitpunkt As Date
        Dim strKursOrt As String
        Dim intKursTeilnZahl As Integer
        Dim strKursSchwierigkeit As String
        Dim lngSaIdFk As Long
        Dim lngBenIdFk As Long
        Dim lngVersion As Long

        'Aufgaben und Aufgabenliste
        Dim kurs As Kurs 'gelesene Aufgabe, die zur Liste der Kurs hinzugefügt werden soll
        Dim lstKurs As List(Of Kurs) 'Liste von Kurs, die als Ergebnis zurückgeliefert werden soll

        'Kommando und REader für Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        kurs = Nothing 'Aufgabe leer initialisieren, um deutlich zu machen, dass keine Aufgabe gelesen wurde
        lstKurs = New List(Of Kurs) 'Rückgabewert initialisieren
        'Oeffnen der Datenbankverbindung durch geerbte Methode der Oberklasse
        oeffnenDatenbank()
        cmd = New OleDbCommand(SQL_SELECT_KURS_BY_BENUTZERID, mConnection)
        'Platzhalter in SQL-Anweisung durch Eigenschaften ersetzen
        'Hier nur ein Platzhalter für die ID
        cmd.Parameters.AddWithValue("@KuBenIdFk", pBenutzer.BenutzerID)
        dr = cmd.ExecuteReader()

        Do While dr.Read
            'Aus dem Data-reader die Werte auslesen
            lngKursIdPk = Long.Parse(dr("KuIdPk"))
            datKursZeitpunkt = Date.Parse(dr("KuZeitpunkt"))
            strKursOrt = dr("KuOrt")
            intKursTeilnZahl = Integer.Parse(dr("KuTeilnehmerzahl"))
            strKursSchwierigkeit = dr("KuSchwierigkeit")
            lngSaIdFk = Long.Parse(dr("KuSaIdFk"))
            lngBenIdFk = Long.Parse(dr("KuBenIdFk"))
            lngVersion = Long.Parse(dr("KuVersion"))

            'Neue Aufgabe erstellen und mit den gelesenen Werten initialisieren
            kurs = New Kurs(lngKursIdPk, datKursZeitpunkt, strKursOrt, intKursTeilnZahl, strKursSchwierigkeit, lngSaIdFk, lngBenIdFk, lngVersion)
            'Aufgabe dem Benutzer zuordnen
            kurs.Benutzer = pBenutzer
            'Neue Aufgabe zur Liste der Aufgaben hinzufügen
            lstKurs.Add(kurs)
        Loop

        dr.Close() 'DataReader schließen
        schliessenDatenbank() 'Methode der Oberklasse nutzen, um Datenbankverbindung zu schließen
        'Rückgabewert
        Return lstKurs
    End Function

    'findenKurs
    Public Function findeKurs(plngKursIdPk As Long) As Kurs

        'Deklaration der Eigenschaften des Kurs
        Dim lngKursIdPk As Long
        Dim datKursZeitpunkt As Date
        Dim strKursOrt As String
        Dim intKursTeilnZahl As Integer
        Dim strKursSchwierigkeit As String
        Dim lngSaIdFk As Long
        Dim lngBenIdFk As Long
        Dim lngVersion As Long

        'Aufgabe und Aufgabenliste
        Dim kurs As Kurs

        'Initialisierung Liste
        kurs = Nothing

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_KURS_BY_ID, mConnection)
        cmd.Parameters.AddWithValue("@KuIdPk", plngKursIdPk)

        dr = cmd.ExecuteReader
        If dr.Read() Then
            lngKursIdPk = Long.Parse(dr("KuIdPk"))
            datKursZeitpunkt = Date.Parse(dr("KuZeitpunkt"))
            strKursOrt = dr("KuOrt")
            intKursTeilnZahl = Integer.Parse(dr("KuTeilnehmerzahl"))
            strKursSchwierigkeit = dr("KuSchwierigkeit")
            lngSaIdFk = Long.Parse(dr("KuSaIdFk"))
            lngBenIdFk = Long.Parse(dr("KuBenIdFk"))
            lngVersion = Long.Parse(dr("KuVersion"))

            'Neuer Kurs erzeugen und mit den gelesenen Werten initialisieren
            kurs = New Kurs(lngKursIdPk, datKursZeitpunkt, strKursOrt, intKursTeilnZahl,
                            strKursSchwierigkeit, lngSaIdFk, lngBenIdFk, lngVersion)

        End If
        dr.Close()
        schliessenDatenbank()
        Return kurs

    End Function


    'loeschenKurs
    Public Shared Function loeschenKursTraId(plngKursIdPk As Long, plngVersion As Long) As Boolean
        'Deklaration
        Dim lngAnzahlDatensaetze As Long
        Dim cmd As OleDbCommand

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_DELETE_BY_VERSION_KURS, mConnection)
        cmd.Parameters.AddWithValue("@KuIdPk", plngKursIdPk)
        cmd.Parameters.AddWithValue("@version", plngVersion)

        lngAnzahlDatensaetze = cmd.ExecuteNonQuery()

        schliessenDatenbank()

        If lngAnzahlDatensaetze = 1 Then
            Return True 'Nicht erfolgreich, deshalb False zurückgeben
        Else
            Return False 'erfolgreich, deshalb True
        End If

    End Function

    Public Shared Function speichernKurs(pKurs As Kurs) As Long

        ' Deklarationen
        Dim lngKursIdPK As Long ' zurückzugebender Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufagbe

        ' Wenn die Aufgabe bereits als Datensatz gespeichert ist (also ihr Primärschlüsselwert > 0 ist)
        If pKurs.IdPk > 0 Then
            ' Muss die Aufgabe aktualisiert werden 
            lngKursIdPK = aktualisierenKurs(pKurs)
        Else
            ' Andernfalls muss die Aufgabe neu hinzugefügt werden
            lngKursIdPK = hinzufuegenKurs(pKurs)
        End If

        ' Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufgabe zurückliefern
        Return lngKursIdPK

    End Function

    'aktualisierenKurs
    Private Shared Function aktualisierenKurs(pKurs As Kurs) As Long
        ' Deklarationen
        Dim lngKursIdPk As Long ' Primärschlüssel des zu aktualisierenden Datensatzes
        Dim lngAnzahlDatensätze As Long ' Anzahl der von der Operation betroffenen Datensätze
        Dim cmd As OleDbCommand ' Kommando für den Datenbankzugriff

        ' Initialisierung
        lngKursIdPk = -1 ' Wert für Primärschlüssel, der erkennbar macht, dass Datensatz (noch) nicht aktualisierenden wurde


        'Öffnen der Datenbankverbindung durch geerbte Methode der Oberklasse
        oeffnenDatenbank()

        ' Kommando für den Datenbankzugriff vorbereiten
        ' SQL-Anweisung aus Konstante verwenden (Deklaration oben) und initialisierte Datenbankverbindung (aus Oberklasse geerbt)
        cmd = New OleDbCommand(SQL_UPDATE_KURS, mConnection)

        cmd.Parameters.AddWithValue("@KuZeitpunkt", pKurs.Zeitpunkt)
        cmd.Parameters.AddWithValue("@KuOrt", pKurs.Ort)
        cmd.Parameters.AddWithValue("@KuTeilnehmerzahl", pKurs.Teilnehmerzahl)
        cmd.Parameters.AddWithValue("@KuSchwierigkeit", pKurs.Schwierigkeitsgrad)
        cmd.Parameters.AddWithValue("@KuVersion", pKurs.Version)
        cmd.Parameters.AddWithValue("@KuIdPk", pKurs.IdPk)

        ' Ausführen des Kommandos, als Ergebnis die Anzahl betroffener Datensätze merken
        lngAnzahlDatensätze = cmd.ExecuteNonQuery

        ' Wenn ein Datensatz betroffen ist
        If lngAnzahlDatensätze = 1 Then
            ' Aktualisieren war erfolgreich, nun Primärschlüssel als Ergebnis zurückliefern
            lngKursIdPk = pKurs.IdPk
        End If

        'Schließen der Datenbankverbindung durch geerbte Methode der Oberklasse
        schliessenDatenbank()

        ' Rückgabe des Primärschlüssel-Wertes der aktualisierten Aufgabe
        Return lngKursIdPk

    End Function

    'hinzufuegenKurs
    Public Shared Function hinzufuegenKurs(pKurs As Kurs) As Long

        Dim lngAnzahlDatensaetze As Long
        Dim lngKursIdPk As Long
        Dim cmd As OleDbCommand

        lngKursIdPk = -1
        lngAnzahlDatensaetze = 0

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_INSERT_KURS, mConnection)
        cmd.Parameters.AddWithValue("@KuZeitpunkt", pKurs.Zeitpunkt)
        cmd.Parameters.AddWithValue("@KuOrt", pKurs.Ort)
        cmd.Parameters.AddWithValue("@KuTeilnehmerzahl", pKurs.Teilnehmerzahl)
        cmd.Parameters.AddWithValue("@KuSchwierigkeit", pKurs.Schwierigkeitsgrad)
        cmd.Parameters.AddWithValue("@KuSaIdFk", pKurs.SaIdFk)
        cmd.Parameters.AddWithValue("@KuBenIdFk", pKurs.BenIdFk)
        cmd.Parameters.AddWithValue("@version", pKurs.Version)

        lngAnzahlDatensaetze = cmd.ExecuteNonQuery
        If lngAnzahlDatensaetze = 1 Then
            lngKursIdPk = ermittleId()
        End If
        schliessenDatenbank()
        Return lngKursIdPk
    End Function

    Public Shared Function speichernMitarbeiter(pMit As Mitarbeiter)

        ' Deklarationen
        Dim lngIdPK As Long ' zurückzugebender Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufagbe

        ' Wenn die Aufgabe bereits als Datensatz gespeichert ist (also ihr Primärschlüsselwert > 0 ist)
        If pMit.BenutzerID > 0 Then
            ' Muss die Aufgabe aktualisiert werden 
            lngIdPK = aktualisierenMitarbeiter(pMit)
        Else
            ' Andernfalls muss die Aufgabe neu hinzugefügt werden
            lngIdPK = hinzufuegenMitarbeiter(pMit)
        End If

        ' Primärschlüsselwert der neu hinzugefügten oder aktualisierten Aufgabe zurückliefern
        Return lngIdPK


    End Function


    Private Shared Function aktualisierenMitarbeiter(pMit As Mitarbeiter) As Long
        Dim lngIdPk As Long '
        Dim lngAnzahlDatensätze As Long
        Dim cmd As OleDbCommand
        lngIdPk = -1 ' Wert für Primärschlüssel, der erkennbar macht, dass Datensatz (noch) nicht aktualisierenden wurde
        oeffnenDatenbank()
        cmd = New OleDbCommand(SQL_UPDATE_MITARBEITER, mConnection)
        cmd.Parameters.AddWithValue("@BenName", pMit.Name)
        cmd.Parameters.AddWithValue("@BenBenutzername", pMit.Benutzername)
        cmd.Parameters.AddWithValue("@BenPw", pMit.Passwort)
        cmd.Parameters.AddWithValue("@BenVersion", pMit.Version + 1)
        cmd.Parameters.AddWithValue("@BenIdPk", pMit.BenutzerID)
        lngAnzahlDatensätze = cmd.ExecuteNonQuery
        ' Wenn ein Datensatz betroffen ist
        If lngAnzahlDatensätze = 1 Then
            ' Aktualisieren war erfolgreich, nun Primärschlüssel als Ergebnis zurückliefern
            lngIdPk = pMit.BenutzerID
        End If
        schliessenDatenbank()
        Return lngIdPk
    End Function


    Public Shared Function hinzufuegenMitarbeiter(pMit As Mitarbeiter) As Long

        Dim lngAnzahlDatensätze As Long
        Dim lngIdPk As Long
        Dim cmd As OleDbCommand

        lngIdPk = -1

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_INSERT_MITARBEITER, mConnection)

        cmd.Parameters.AddWithValue("@BenVorname", pMit.Vorname)
        cmd.Parameters.AddWithValue("@BenName", pMit.Name)
        cmd.Parameters.AddWithValue("@BenBenutzername", pMit.Benutzername)
        cmd.Parameters.AddWithValue("@BenPw", pMit.Passwort)
        cmd.Parameters.AddWithValue("@BenTyp", pMit.Typ)
        cmd.Parameters.AddWithValue("@BenVersion", pMit.Version)

        lngAnzahlDatensätze = cmd.ExecuteNonQuery
        If lngAnzahlDatensätze = 1 Then
            lngAnzahlDatensätze = ermittleId()
        End If
        schliessenDatenbank()
        Return lngIdPk


    End Function


End Class
