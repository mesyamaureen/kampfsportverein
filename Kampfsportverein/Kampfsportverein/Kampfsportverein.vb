Public Module Kampfsportverein
    Public Sub Main()
        Dim mSitzung As BenutzerSitzung
        mSitzung = BenutzerSitzung.Instanz
        mSitzung.start()
    End Sub

    Public Sub erzeugeBeispieldaten()

        Dim Tra1, Tra2 As Trainer
        Dim Ma1, Ma2, Ma3 As Mitarbeiter

        Tra1 = ("m.meier", "pw", "Michael", "Meier", 1)
        Tra2 = ("t.off", "pw", "Thomas", "Off", 2)
        Ma1 = ("c.pennig", "pw", "Charlene", "Pennig", 3)
        Ma2 = ("c.lammel", "pw", "Carina", "Lammel", 4)
        Ma3 = ("m.jeynie", "pw", "Mesya Maureen", "Jeynie", 5)

        Dim mlstTrainer As New List(Of Trainer)
        mlstTrainer.Add(Tra1)
        mlstTrainer.Add(Tra2)

        Dim mlstMitarbeiter As New List(Of Mitarbeiter)
        mlstMitarbeiter.Add(Ma1)
        mlstMitarbeiter.Add(Ma2)
        mlstMitarbeiter.Add(Ma3)


    End Sub




End Module
