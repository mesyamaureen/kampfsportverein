Public Module Kampfsportverein
    Public Sub Main()
        Dim mSitzung As BenutzerSitzung
        mSitzung = BenutzerSitzung.Instanz
        mSitzung.start()
    End Sub
End Module
