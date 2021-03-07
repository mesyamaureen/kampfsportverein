<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeuerMitarbeiter
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
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(242, 12)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(511, 43)
        Me.txtVorname.TabIndex = 0
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(32, 25)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 1
        Me.lblVorname.Text = "Vorname"
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(618, 473)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(135, 44)
        Me.btnAbbrechen.TabIndex = 2
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(462, 473)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(135, 44)
        Me.btnErstellen.TabIndex = 3
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(32, 210)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 5
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(32, 306)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(100, 25)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Passwort"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(242, 106)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(511, 43)
        Me.txtName.TabIndex = 7
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(242, 203)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(511, 43)
        Me.txtBenutzername.TabIndex = 8
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(242, 298)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(511, 43)
        Me.txtPass.TabIndex = 9
        '
        'dlgNeuerMitarbeiter
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.txtVorname)
        Me.Name = "dlgNeuerMitarbeiter"
        Me.Text = "Neuer Mitarbeiter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVorname As TextBox
    Friend WithEvents lblVorname As Label
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPass As TextBox
End Class
