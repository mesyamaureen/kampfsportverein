<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMeinKontoMit
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
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.lblMitarbeiterID = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblNeuesPass = New System.Windows.Forms.Label()
        Me.txtMitarbeiterID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtNeuesPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1093, 563)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(130, 47)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(952, 563)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(123, 47)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblMitarbeiterID
        '
        Me.lblMitarbeiterID.AutoSize = True
        Me.lblMitarbeiterID.Location = New System.Drawing.Point(35, 32)
        Me.lblMitarbeiterID.Name = "lblMitarbeiterID"
        Me.lblMitarbeiterID.Size = New System.Drawing.Size(140, 25)
        Me.lblMitarbeiterID.TabIndex = 2
        Me.lblMitarbeiterID.Text = "Mitarbeiter ID"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(35, 108)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 3
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 188)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(35, 271)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 6
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblNeuesPass
        '
        Me.lblNeuesPass.AutoSize = True
        Me.lblNeuesPass.Location = New System.Drawing.Point(35, 345)
        Me.lblNeuesPass.Name = "lblNeuesPass"
        Me.lblNeuesPass.Size = New System.Drawing.Size(168, 25)
        Me.lblNeuesPass.TabIndex = 7
        Me.lblNeuesPass.Text = "Neues Passwort"
        '
        'txtMitarbeiterID
        '
        Me.txtMitarbeiterID.Location = New System.Drawing.Point(304, 25)
        Me.txtMitarbeiterID.Multiline = True
        Me.txtMitarbeiterID.Name = "txtMitarbeiterID"
        Me.txtMitarbeiterID.ReadOnly = True
        Me.txtMitarbeiterID.Size = New System.Drawing.Size(171, 34)
        Me.txtMitarbeiterID.TabIndex = 9
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(304, 108)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(919, 34)
        Me.txtVorname.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(304, 185)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(919, 34)
        Me.txtName.TabIndex = 11
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(304, 262)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(919, 34)
        Me.txtBenutzername.TabIndex = 13
        '
        'txtNeuesPass
        '
        Me.txtNeuesPass.Location = New System.Drawing.Point(304, 336)
        Me.txtNeuesPass.Multiline = True
        Me.txtNeuesPass.Name = "txtNeuesPass"
        Me.txtNeuesPass.Size = New System.Drawing.Size(919, 34)
        Me.txtNeuesPass.TabIndex = 14
        '
        'dlgMeinKontoMit
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.txtNeuesPass)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtMitarbeiterID)
        Me.Controls.Add(Me.lblNeuesPass)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblMitarbeiterID)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgMeinKontoMit"
        Me.Text = "Mein Mitarbeiterkonto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblMitarbeiterID As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblNeuesPass As Label
    Friend WithEvents txtMitarbeiterID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtNeuesPass As TextBox
End Class
