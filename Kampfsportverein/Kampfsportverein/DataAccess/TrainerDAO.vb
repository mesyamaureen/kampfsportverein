Imports Kampfsportvereinverwaltung
Imports System.Data.OleDb

Public Class TrainerDAO
    Inherits DAO

    'SQL-Anweisung, um einen Mitarbeiter anhand des Benutzernamens und des Passwortes zu ermitteln
    Private Const SQL_SELECT_BY_BENUTZERNAME_PASSWORT As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenBenutzerName = @benutzername AND BenPw = @passwort AND BenTyp = 'T';"

    'SQL-Anweisung, um Trainer anhand Benutzer ID zu ermitteln
    Private Const SQL_SELECT_TRAINER_BY_BENUTZERID As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenIdPk = @idPk"

    'SQL-Anweisung, um alle Trainer zu ermitteln
    Private Const SQL_SELECT_TRAINER_ALL As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenTyp = 'T'"

    'SQL-Anweisung, um alle Schüler zu ermitteln
    Private Const SQL_SELECT_SCHUELER As String = "SELECT * FROM tblSchueler"

    'SQL-Anweisung, um Schueler nach ID zu filtern
    Private Const SQL_SELECT_SCHUELER_BY_SCHUID As String = "SELECT * FROM tblSchueler WHERE SchuIdPk = @IdPk"

    ' SQL-Anweisung, um einen Schueler neu hinzuzufügen
    Private Const SQL_INSERT As String = "INSERT INTO tblSchueler(SchuIdPk, SchuVorname, SchuName, SchuEMail, SchuVersion)" &
        "VALUES @vorname, @name, @email, @version"

    ' SQL-Anweisung, um eine Schueler zu löschen
    Private Const SQL_DELETE_BY_VERSION As String = "DELETE FROM tblSchueler WHERE SchuIdPk = @IdPk And SchuVersion = @Version"

    'finden Trainer zur Anmeldung
    Public Function findenTraBenutzernamePasswort(pstrBenutzername As String, pstrPasswort As String) As Trainer
        'Deklaration
        'Alle Eigenschaften eines Benutzers
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long
        'Dim charTyp As Char

        'Gesuchter Benutzer
        Dim tra As Trainer

        'Alles für den Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        tra = Nothing

        'Datenbank oeffnen
        oeffnenDatenbank()
        'Kommando für Datenbankzugriff
        cmd = New OleDbCommand(SQL_SELECT_BY_BENUTZERNAME_PASSWORT, mConnection)
        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@BenBenutzerName", pstrBenutzername)
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
            'charTyp = Char.Parse(dr("BenTyp"))

            tra = New Trainer(strBenutzername, strPasswort, strVorname, strName, lngBenutzerIdPk, lngVersion) ', charTyp)
        End If
        dr.Close()
        schliessenDatenbank()
        'Rückgabe des Benutzers
        Return tra
    End Function

    Public Function findenTrainerId(plngBenutzerIdPk As Long) As Trainer
        'Deklaration der Eigenschaften
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long

        'Gelesener Trainer, die zurückgeben werden soll
        Dim tra As Trainer

        'Kommando und Reader für Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        tra = Nothing

        'Oeffnen der Dbverbindung
        oeffnenDatenbank()

        'Kommando vorbereiten und SQL-Anweisung
        cmd = New OleDbCommand(SQL_SELECT_TRAINER_BY_BENUTZERID, mConnection)

        'Platzhalter in SQL-Anweisung für die ID
        cmd.Parameters.AddWithValue("@BenIdPk", plngBenutzerIdPk)

        'Ausführen des Kommandos, als Ergebnis einen DataReader erhalten, mit dem auf die einzelnen Datensätze zugegriffen werden kann
        dr = cmd.ExecuteReader()

        'Ob es etwas im DataReader zu lesen gibt
        If dr.Read() Then
            lngBenutzerIdPk = Long.Parse(dr("BenIdPk"))
            strBenutzername = dr("BenBenutzerName")
            strPasswort = dr("BenPw")
            strVorname = dr("BenVorname")
            strName = dr("BenName")
            lngVersion = Long.Parse(dr("BenVersion"))
            'Neuer Trainer erzeugen und mit den gelesenen Werten initialisieren
            tra = New Trainer(strBenutzername, strPasswort, strVorname, strName, lngBenutzerIdPk, lngVersion)
        End If
        dr.Close() 'DataReader schließen
        'Schließen der Datenbankverbindung
        schliessenDatenbank()
        'Rückgabe 
        Return tra
    End Function

    Public Function findeAlleTrainer() As List(Of Trainer)

        'Deklaration der Eigenschaften des Kurs
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long

        'Aufgabe und Aufgabenliste
        Dim tra As Trainer
        Dim lstTrainer As List(Of Trainer)

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        'Initialisierung Liste
        tra = Nothing
        lstTrainer = New List(Of Trainer)

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_TRAINER_ALL, mConnection)
        dr = cmd.ExecuteReader
        Do While dr.Read()
            lngBenutzerIdPk = Long.Parse(dr("BenIdPk"))
            strBenutzername = dr("BenBenutzerName")
            strPasswort = dr("BenPw")
            strVorname = dr("BenVorname")
            strName = dr("BenName")
            lngVersion = Long.Parse(dr("BenVersion"))
            'Neuer Trainer erzeugen und mit den gelesenen Werten initialisieren
            tra = New Trainer(strBenutzername, strPasswort, strVorname, strName, lngBenutzerIdPk, lngVersion)

            lstTrainer.Add(tra)
        Loop
        dr.Close()
        schliessenDatenbank()
        Return lstTrainer
    End Function


    Public Function findenAlleMitSchuelerId(plngIdPk As Long) As Schueler

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
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_SCHUELER_BY_SCHUID, mConnection)

        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@SchuIdPk", plngIdPk)

        dr = cmd.ExecuteReader()

        Do While dr.Read()

            lngIdPk = Long.Parse(dr("SchuIdPk"))
            strName = dr("SchuName")
            strVorname = dr("SchuVorname")
            strEmail = dr("SchuEMail")
            lngVersion = Long.Parse(dr("SchuVersion"))

            schu = New Schueler(strVorname, strName, strEmail, lngIdPk, lngVersion)

        Loop

        dr.Close()
        schliessenDatenbank()
        Return schu
    End Function

    Public Function findeAlleSchueler() As List(Of Schueler)
        'Deklaration der Eigenschaften des Kurs
        Dim lngIdPk As Long
        Dim strName As String
        Dim strVorname As String
        Dim strEmail As String
        Dim lngVersion As Long

        'Aufgaben und Aufgabenliste
        Dim schu As Schueler 'gelesene Aufgabe, die zur Liste der Kurs hinzugefügt werden soll
        Dim lstSchueler As List(Of Schueler) 'Liste von Kurs, die als Ergebnis zurückgeliefert werden soll

        'Kommando und REader für Datenbankzugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Initialisierung
        schu = Nothing 'Aufgabe leer initialisieren, um deutlich zu machen, dass keine Aufgabe gelesen wurde
        lstSchueler = New List(Of Schueler) 'Rückgabewert initialisieren
        'Oeffnen der Datenbankverbindung durch geerbte Methode der Oberklasse
        oeffnenDatenbank()
        cmd = New OleDbCommand(SQL_SELECT_SCHUELER, mConnection)
        'Platzhalter in SQL-Anweisung durch Eigenschaften ersetzen
        dr = cmd.ExecuteReader()

        Do While dr.Read
            'Aus dem Data-reader die Werte auslesen
            lngIdPk = Long.Parse(dr("SchuIdPk"))
            strName = dr("SchuName")
            strVorname = dr("SchuVorname")
            strEmail = dr("SchuEMail")
            lngVersion = Long.Parse(dr("SchuVersion"))

            schu = New Schueler(strVorname, strName, strEmail, lngIdPk, lngVersion)
            lstSchueler.Add(schu)
        Loop

        dr.Close() 'DataReader schließen
        schliessenDatenbank() 'Methode der Oberklasse nutzen, um Datenbankverbindung zu schließen
        'Rückgabewert
        Return lstSchueler
    End Function

    Public Shared Function loeschenMitSchuelerId(plngIdPk As Long, plngVersion As Long) As Boolean
        Return ElementLoeschen("tblSchueler", plngIdPk, plngVersion)
        'Deklaration
        Dim lngAnzahlDatensätze As Long
        Dim cmd As OleDbCommand

        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
        cmd.Parameters.AddWithValue("@SchuIdPk", plngIdPk)
        cmd.Parameters.AddWithValue("@version", plngVersion)

        lngAnzahlDatensätze = cmd.ExecuteNonQuery()

        schliessenDatenbank()

        If lngAnzahlDatensätze = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    'Public Function Speichern() As Integer

    'Return 0
    'End Function

    Public Function hinzufuegen(pSchu As Schueler) As Long

        Dim lngAnzahlDatensätze As Long
        Dim lngIdPk As Long
        Dim cmd As OleDbCommand

        lngIdPk = -1
        cmd = New OleDbCommand(SQL_INSERT, mConnection)
        cmd.Parameters.AddWithValue("@SchuName", pSchu.Name)
        cmd.Parameters.AddWithValue("@SchuVorname", pSchu.Vorname)
        cmd.Parameters.AddWithValue("@SchuEmail", pSchu.EMailAdresse)
        cmd.Parameters.AddWithValue("@SchuVersion", pSchu.Version)

        lngAnzahlDatensätze = cmd.ExecuteNonQuery
        If lngAnzahlDatensätze = 1 Then
            lngAnzahlDatensätze = ermittleId()
        End If
        schliessenDatenbank()
        Return lngIdPk


    End Function

End Class

