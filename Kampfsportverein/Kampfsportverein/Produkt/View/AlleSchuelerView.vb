Public Class AlleSchuelerView
    Inherits dlgSchueler

    Sub New(pPresenter As SchuelerAllePresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Property IstSchueler As AlleSchuelerView
        Get
            Return Nothing
        End Get
        Set(value As AlleSchuelerView)
        End Set
    End Property

    Public Sub anzeigenSchueler()
        Me.txtSchuelerID.Enabled = False
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtEmail.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtSchuelerID.Clear()
        Me.txtVorname.Clear()
        Me.txtName.Clear()
        Me.txtEmail.Clear()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'AlleSchuelerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(580, 423)
        Me.Name = "AlleSchuelerView"
        Me.Text = "gibt dem benutzer ei"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
