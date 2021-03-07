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
        Me.lblAltPass = New System.Windows.Forms.Label()
        Me.txtMitarbeiterID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtAltPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(729, 360)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(87, 30)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(635, 360)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(82, 30)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblMitarbeiterID
        '
        Me.lblMitarbeiterID.AutoSize = True
        Me.lblMitarbeiterID.Location = New System.Drawing.Point(23, 20)
        Me.lblMitarbeiterID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMitarbeiterID.Name = "lblMitarbeiterID"
        Me.lblMitarbeiterID.Size = New System.Drawing.Size(92, 17)
        Me.lblMitarbeiterID.TabIndex = 2
        Me.lblMitarbeiterID.Text = "Mitarbeiter ID"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(23, 69)
        Me.lblVorname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(65, 17)
        Me.lblVorname.TabIndex = 3
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 120)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(23, 173)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(100, 17)
        Me.lblBenutzername.TabIndex = 6
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblAltPass
        '
        Me.lblAltPass.AutoSize = True
        Me.lblAltPass.Location = New System.Drawing.Point(23, 221)
        Me.lblAltPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAltPass.Name = "lblAltPass"
        Me.lblAltPass.Size = New System.Drawing.Size(100, 17)
        Me.lblAltPass.TabIndex = 7
        Me.lblAltPass.Text = "Altes Passwort"
        '
        'txtMitarbeiterID
        '
        Me.txtMitarbeiterID.Location = New System.Drawing.Point(203, 16)
        Me.txtMitarbeiterID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMitarbeiterID.Multiline = True
        Me.txtMitarbeiterID.Name = "txtMitarbeiterID"
        Me.txtMitarbeiterID.ReadOnly = True
        Me.txtMitarbeiterID.Size = New System.Drawing.Size(115, 23)
        Me.txtMitarbeiterID.TabIndex = 9
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(203, 69)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.ReadOnly = True
        Me.txtVorname.Size = New System.Drawing.Size(614, 23)
        Me.txtVorname.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(203, 118)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(614, 23)
        Me.txtName.TabIndex = 11
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(203, 168)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.ReadOnly = True
        Me.txtBenutzername.Size = New System.Drawing.Size(614, 23)
        Me.txtBenutzername.TabIndex = 13
        '
        'txtAltPass
        '
        Me.txtAltPass.Location = New System.Drawing.Point(203, 215)
        Me.txtAltPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAltPass.Multiline = True
        Me.txtAltPass.Name = "txtAltPass"
        Me.txtAltPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAltPass.Size = New System.Drawing.Size(614, 23)
        Me.txtAltPass.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Neues Passwort"
        '
        'txtNeuesPasswort
        '
        Me.txtNeuesPasswort.Location = New System.Drawing.Point(202, 259)
        Me.txtNeuesPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNeuesPasswort.Multiline = True
        Me.txtNeuesPasswort.Name = "txtNeuesPasswort"
        Me.txtNeuesPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNeuesPasswort.Size = New System.Drawing.Size(614, 23)
        Me.txtNeuesPasswort.TabIndex = 16
        '
        'dlgMeinKontoMit
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(836, 403)
        Me.Controls.Add(Me.txtNeuesPasswort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAltPass)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtMitarbeiterID)
        Me.Controls.Add(Me.lblAltPass)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblMitarbeiterID)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents lblAltPass As Label
    Friend WithEvents txtMitarbeiterID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtAltPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNeuesPasswort As TextBox
End Class
