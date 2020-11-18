Public Module Kampfsportverein
    Public mlstTrainer As List(Of Trainer) = New List(Of Trainer)
    Public mlstMitarbeiter As List(Of Mitarbeiter) = New List(Of Mitarbeiter)
    Public mlstKurs As List(Of Kurse)


    Public Sub Main()
        Dim mSitzung As BenutzerSitzung
        mSitzung = BenutzerSitzung.Instanz
        erzeugeBeispieldaten()
        mSitzung.start()
    End Sub

    Public Sub erzeugeBeispieldaten()

        Dim Tra1, Tra2 As Trainer
        Dim Ma1, Ma2, Ma3 As Mitarbeiter
        Dim kurs1, kurs2 As Kurse

        Tra1 = New Trainer("m.meier", "pw", "Michael", "Meier", 1)
        Tra2 = New Trainer("t.off", "pw", "Thomas", "Off", 2)
        Ma1 = New Mitarbeiter("c.pennig", "pw", "Charlene", "Pennig", 3)
        Ma2 = New Mitarbeiter("c.lammel", "pw", "Carina", "Lammel", 4)
        Ma3 = New Mitarbeiter("m.jeynie", "pw", "Mesya Maureen", "Jeynie", 5)
        kurs1 = New Kurse(#12/11/2020#, "101", Tra1, 10, "Fortgeschritten", "Judo (F)")
        kurs2 = New Kurse(#12/18/2020#, "101", Tra1, 10, "Fortgeschritten", "Judo (F)")

        mlstTrainer = New List(Of Trainer)
        mlstTrainer.Add(Tra1)
        mlstTrainer.Add(Tra2)

        mlstMitarbeiter = New List(Of Mitarbeiter)
        mlstMitarbeiter.Add(Ma1)
        mlstMitarbeiter.Add(Ma2)
        mlstMitarbeiter.Add(Ma3)

        mlstKurs = New List(Of Kurse)
        mlstKurs.Add(kurs1)
        mlstKurs.Add(kurs2)


    End Sub




End Module
