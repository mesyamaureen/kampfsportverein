Public Module Kampfsportverein
    Public mlstTrainer As List(Of Trainer) = New List(Of Trainer)
    Public mlstMitarbeiter As List(Of Mitarbeiter) = New List(Of Mitarbeiter)
    Public mlstKurs As List(Of Kurs)
    Public mlstSportart As List(Of Sportart)
    Public mlstSchueler As List(Of Schueler)

    Public Sub Main()
        Dim mSitzung As BenutzerSitzung
        mSitzung = BenutzerSitzung.Instanz
        erzeugeBeispieldaten()
        mSitzung.start()
    End Sub
    'Hier kommt das DAO rein NH 2021-01-27
    'Hole Daten aus der Datenbank
    'Pushe Veränderungen in die Datenbank

    Public Sub erzeugeBeispieldaten()

        Dim Tra1, Tra2 As Trainer
        Dim Ma1, Ma2, Ma3 As Mitarbeiter
        Dim kurs1, kurs2 As Kurs
        Dim sport1, sport2, sport3 As Sportart
        Dim schueler1, schueler2, schueler3 As Schueler

        Tra1 = New Trainer("m.meier", "pw", "Michael", "Meier", 1, 1, Nothing)
        Tra2 = New Trainer("t.off", "pw", "Thomas", "Off", 2, 1, Nothing)
        Ma1 = New Mitarbeiter("c.pennig", "pw", "Charlene", "Pennig", 3, 1, Nothing)
        Ma2 = New Mitarbeiter("c.lammel", "pw", "Carina", "Lammel", 4, 1, Nothing)
        Ma3 = New Mitarbeiter("m.jeynie", "pw", "Mesya Maureen", "Jeynie", 5, 1, Nothing)
        sport1 = New Sportart(1, "Judo", "Japan", "Zielgruppe weiß jetzt noch nicht", 10, 1)
        sport2 = New Sportart(2, "Karate", "Japan", "Zielgruppe weiß jetzt noch nicht", 12, 1)
        sport3 = New Sportart(3, "Muay Thai", "Thailand", "Zielgruppe weiß jetzt noch nicht", 10, 1)
        kurs1 = New Kurs(#12/11/2020#, "B101", 10, "Fortgeschritten", 1, 1, 1) '21,
        kurs2 = New Kurs(#12/18/2020#, "C101", 10, "Fortgeschritten", 2, 2, 1) '22, 
        schueler1 = New Schueler("Anna", "Müller", "annamueler@gmail.com", 10, 1)
        schueler2 = New Schueler("Hans", "Klaus", "hansklaus@gmail.com", 11, 1)
        schueler3 = New Schueler("Andreas", "Zimmermann", "andreaszimmermann@gmail.com", 12, 1)

        mlstTrainer = New List(Of Trainer)
        mlstTrainer.Add(Tra1)
        mlstTrainer.Add(Tra2)

        mlstMitarbeiter = New List(Of Mitarbeiter)
        mlstMitarbeiter.Add(Ma1)
        mlstMitarbeiter.Add(Ma2)
        mlstMitarbeiter.Add(Ma3)

        mlstKurs = New List(Of Kurs)
        mlstKurs.Add(kurs1)
        mlstKurs.Add(kurs2)

        mlstSportart = New List(Of Sportart)
        mlstSportart.Add(sport1)
        mlstSportart.Add(sport2)
        mlstSportart.Add(sport3)

        mlstSchueler = New List(Of Schueler)
        mlstSchueler.Add(schueler1)
        mlstSchueler.Add(schueler2)
        mlstSchueler.Add(schueler3)

    End Sub




End Module
