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
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(605, 464)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(157, 53)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(434, 464)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(160, 53)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(22, 45)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 2
        Me.lblVorname.Text = "Vorname"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(205, 34)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(557, 47)
        Me.txtVorname.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(205, 130)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(557, 47)
        Me.txtName.TabIndex = 4
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(205, 221)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(557, 47)
        Me.txtBenutzername.TabIndex = 5
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(205, 327)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(557, 47)
        Me.txtPasswort.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(22, 143)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(22, 235)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 8
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(22, 340)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(100, 25)
        Me.lblPass.TabIndex = 9
        Me.lblPass.Text = "Passwort"
        '
        'dlgNeuerMitarbeiter
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNeuerMitarbeiter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Neuer Mitarbeiter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblVorname As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPass As Label
End Class
