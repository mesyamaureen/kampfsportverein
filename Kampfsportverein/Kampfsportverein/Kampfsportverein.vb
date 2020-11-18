Public Module Kampfsportverein
    Public mlstTrainer As List(Of Trainer)
    Public mlstMitarbeiter As List(Of Mitarbeiter)

    Public Sub Main()
        Dim mSitzung As BenutzerSitzung
        mSitzung = BenutzerSitzung.Instanz
        mSitzung.start()
        erzeugeBeispieldaten()
    End Sub

    Public Sub erzeugeBeispieldaten()

        Dim Tra1, Tra2 As Trainer
        Dim Ma1, Ma2, Ma3 As Mitarbeiter

        Tra1 = New Trainer("m.meier", "pw", "Michael", "Meier", 1)
        Tra2 = New Trainer("t.off", "pw", "Thomas", "Off", 2)
        Ma1 = New Mitarbeiter("c.pennig", "pw", "Charlene", "Pennig", 3)
        Ma2 = New Mitarbeiter("c.lammel", "pw", "Carina", "Lammel", 4)
        Ma3 = New Mitarbeiter("m.jeynie", "pw", "Mesya Maureen", "Jeynie", 5)

        mlstTrainer = New List(Of Trainer)
        mlstTrainer.Add(Tra1)
        mlstTrainer.Add(Tra2)

        mlstMitarbeiter = New List(Of Mitarbeiter)
        mlstMitarbeiter.Add(Ma1)
        mlstMitarbeiter.Add(Ma2)
        mlstMitarbeiter.Add(Ma3)


    End Sub




End Module
