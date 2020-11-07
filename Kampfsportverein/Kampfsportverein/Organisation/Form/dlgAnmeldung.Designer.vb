<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAnmeldung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnAnmelden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(106, 26)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(347, 25)
        Me.txtBenutzername.TabIndex = 0
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(106, 75)
        Me.txtPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(347, 25)
        Me.txtPasswort.TabIndex = 1
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(11, 32)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(75, 13)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(11, 80)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(376, 242)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(77, 28)
        Me.btnAbbrechen.TabIndex = 4
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnAnmelden
        '
        Me.btnAnmelden.Location = New System.Drawing.Point(284, 242)
        Me.btnAnmelden.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnmelden.Name = "btnAnmelden"
        Me.btnAnmelden.Size = New System.Drawing.Size(77, 28)
        Me.btnAnmelden.TabIndex = 6
        Me.btnAnmelden.Text = "Anmelden"
        Me.btnAnmelden.UseVisualStyleBackColor = True
        '
        'dlgAnmeldung
        '
        Me.AcceptButton = Me.btnAnmelden
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(464, 281)
        Me.Controls.Add(Me.btnAnmelden)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgAnmeldung"
        Me.Text = "Anmeldung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnAnmelden As Button

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPasswort.Click

    End Sub

    Private Sub dlgAnmeldung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
