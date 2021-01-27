Public Class DAOFactory
    'Attribut vom eigenen Typ des Singletons
    Private Shared mInstanz As DAOFactory
    Private mAktuelleFactory As MitarbeiterDAO
    Private mMitarbeiterDAO As MitarbeiterDAO
    Private mTrainerDAO As TrainerDAO

    'privater Konstruktor des Singletons
    Private Sub New()
        mAktuelleFactory = Nothing
        mMitarbeiterDAO = Nothing
        mTrainerDAO = Nothing
    End Sub
    'implementierung eines Singletons
    Public Shared ReadOnly Property Instanz As DAOFactory
        Get
            If IsNothing(mInstanz) Then
                mInstanz = New DAOFactory
            End If
            Return mInstanz

        End Get
    End Property

    Public Property TrainerDAO As TrainerDAO
        Get
            If IsNothing(mTrainerDAO) Then
                mTrainerDAO = New TrainerDAO
            End If
            Return mTrainerDAO 'die Instanz des TrainerDAOs zurückgeben
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Property MitarbeiterDAO As MitarbeiterDAO
        Get
            If IsNothing(mMitarbeiterDAO) Then
                mMitarbeiterDAO = New MitarbeiterDAO
            End If
            Return mMitarbeiterDAO 'die Instanz des TrainerDAOs zurückgeben
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property
End Class
