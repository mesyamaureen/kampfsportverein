Imports Kampfsportverein

Public Class Trainer
    Inherits Benutzer

    Private mName As String
    Private mVorname As String
    Private mPasswort As String
    Private mGeburtsdatum As Date
    Private mBenutzername As String
    Private mBenutzerId As Long

    Sub New()

        MyBase.New()

    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, plngBenutzerID As Long, plngVersion As Long) ', pcharTyp As Char)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, plngBenutzerID, plngVersion) ', pcharTyp)

    End Sub

End Class

'Interface IMyInterface
'    Sub Trainer()
'    Function Trainer(value As Integer) As Integer
'End Interface

'Class MyImplementation
'    Implements IMyInterface
'    Public Sub Trainer() Implements IMyInterface.Trainer
'        Throw New NotImplementedException()
'    End Sub

'    Public Function Trainer(value As Integer) As Integer Implements IMyInterface.Trainer
'        Throw New NotImplementedException()
'    End Function
'End Class
'End Interface

'Interface IMyInterface
'    Sub TrainerDao()
'    Function TrainerDao(value As Integer) As Integer
'End Interface

'Class MyImplementation
'    Implements IMyInterface
'    Public Sub TrainerDao() Implements IMyInterface.TrainerDao
'        Throw New NotImplementedException()
'    End Sub

'    Public Function TrainerDao(value As Integer) As Integer Implements IMyInterface.TrainerDao
'        Throw New NotImplementedException()
'    End Function
'End Class
'End Interface