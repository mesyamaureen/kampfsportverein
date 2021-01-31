Imports Kampfsportvereinverwaltung
Imports System.Data.OleDb

Public Class TrainerDAO
    Inherits DAO

    'SQL-Anweisung, um einen Mitarbeiter anhand des Benutzernamens und des Passwortes zu ermitteln
    Private Const SQL_SELECT_BY_BENUTZERNAME_PASSWORT As String = "SELECT * FROM [tblBenutzer/Mitarbeiter/Trainer] WHERE BenBenutzerName = @benutzername AND BenPw = @passwort AND BenTyp = 'T';"

    'SQL-Anweisung, um Trainer anhand Benutzer ID zu ermitteln
    Private Const SQL_SELECT_TRAINER_BY_BENUTZERID As String = "SELECT * FROM tblBenutzer/Mitarbeiter/Trainer WHERE BenIdPk = @idPk"

    'SQL-Anweisung, um alle Trainer zu ermitteln
    Private Const SQL_SELECT_TRAINER_ALL As String = "SELECT * FROM tblBenutzer/Mitarbeiter/Trainer WHERE BenTyp = 'T'"

    'SQL-Anweisung, um alle Schüler zu ermitteln
    Private Const SQL_SELECT_Schueler As String = "SELECT * FROM tblSchueler"

    ' 'SQL-Anweisung, um Schueler nach ID zu filtern
    'Private Const SQL_SELECT_SCHUELER_BY_SAID As String = SELECT * FROM tblSchueler WHERE SaIdPk = @IdPk"

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
            tra = New Trainer(lngBenutzerIdPk, strBenutzername, strPasswort, strVorname, strName, lngVersion)
        End If
        dr.Close() 'DataReader schließen
        'Schließen der Datenbankverbindung
        schliessenDatenbank()
        'Rückgabe 
        Return tra
    End Function

    Public Function findeAlleTrainer(pBenutzer As Benutzer) As List(Of Trainer)

        'Deklaration der Eigenschaften des Kurs
        Dim lngBenutzerIdPk As Long
        Dim strBenutzername As String
        Dim strPasswort As String
        Dim strVorname As String
        Dim strName As String
        Dim lngVersion As Long

        'Trainer und Trainerliste
        Dim tra As Trainer
        Dim lstTrainer As List(Of Trainer)

        'Benutzer zu dem die Aufgabe gehört muss geladen werden
        'Dim mitDAO As MitarbeiterDAO???

        'Kommando und Reader für DB Zugriff
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        'Initialisierung Liste
        tra = Nothing
        lstTrainer = New List(Of Trainer)

        'Öffnen DBVerbindung durch Methode
        oeffnenDatenbank()

        cmd = New OleDbCommand(SQL_SELECT_TRAINER_ALL, mConnection)
        cmd.Parameters.AddWithValue("@BenIdPk", pBenutzer.BenutzerID)

        dr = cmd.ExecuteReader
        Do While dr.Read()
            lngBenutzerIdPk = Long.Parse(dr("BenIdPk"))
            strBenutzername = dr("BenBenutzerName")
            strPasswort = dr("BenPw")
            strVorname = dr("BenVorname")
            strName = dr("BenName")
            lngVersion = Long.Parse(dr("BenVersion"))

            'Neuer Kurs erzeugen und mit den gelesenen Werten initialisieren
            tra = New Trainer(lngBenutzerIdPk, strBenutzername, strPasswort, strVorname, strName, lngVersion)
            tra = pBenutzer
            lstTrainer.Add(tra)
        Loop
        dr.Close()
        schliessenDatenbank()
        Return lstTrainer
    End Function


    Public Function findenAlleMitSchuelerId(plngIdPk As Long) As List(Of Schueler)

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

        cmd = New OleDbCommand(SQL_SELECT_TRAINER_BY_BENUTZERID, mConnection)

        'Platzhalter ersetzen
        cmd.Parameters.AddWithValue("@SchuIdPk", plngIdPk)

        dr = cmd.ExecuteReader

        Do While dr.Read

            lngIdPk = Long.Parse(dr("SchuIdPk"))
            strName = dr("SchuName")
            strVorname = dr("SchuVorname")
            strEmail = dr("SchuEMail")
            lngVersion = Long.Parse(dr("SchuVersion"))

            schu = New Schueler(lngIdPk, strName, strVorname, strEmail, lngVersion)

        Loop

        dr.Close()
        schliessenDatenbank()
        Return lstSchueler
    End Function


    Public Function loeschenMitSchuelerId(plngIdPk As Long, plngVersion As Long) As Boolean

    'Deklaration
    Dim lngAnzahlDatensätze As Long
    Dim cmd As OleDbCommand

    oeffnenDatenbank()

    cmd = New OleDbCommand(SQL_DELETE_BY_VERSION, mConnection)
    cmd.Parameters.AddWithValue("@SchuIdPk", plngIdPk)
    cmd.Parameters.AddWithValue("@version", plngVersion)

    lngAnzahlDatensätze = cmd.ExecuteNonQuery()

    schliessenDatenbank()

    If lngAnzahlDatensätze = 1 Then
        Return True
    Else Return False
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