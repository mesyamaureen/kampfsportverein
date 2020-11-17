Public Class AnmeldungView
    Inherits dlgAnmeldung

    Sub New(pPresenter As AnmeldungPresenter)

        MyBase.New()
        mPresenter = pPresenter

    End Sub

    Public Sub leeren()
        Me.txtBenutzername.Text = String.Empty
        Me.txtPasswort.Text = String.Empty
    End Sub

    Public Sub anzeigenAnmeldeFehler()

        MsgBox("Fehler bei Anmeldung" & "Benutezrname und Passwort sind nicht anmeldeberechtigt", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fehler bei der Anmeldung")
    End Sub

End Class
