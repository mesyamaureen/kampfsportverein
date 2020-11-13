<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeuerTrainer
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.lblPassWiederh = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtPassWiederh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(637, 478)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(125, 39)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(506, 478)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(125, 39)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(23, 26)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 2
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 101)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(23, 186)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 5
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(23, 264)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(100, 25)
        Me.lblPasswort.TabIndex = 6
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPassWiederh
        '
        Me.lblPassWiederh.AutoSize = True
        Me.lblPassWiederh.Location = New System.Drawing.Point(23, 342)
        Me.lblPassWiederh.Name = "lblPassWiederh"
        Me.lblPassWiederh.Size = New System.Drawing.Size(222, 25)
        Me.lblPassWiederh.TabIndex = 7
        Me.lblPassWiederh.Text = "Passwort wiederholen"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(253, 22)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(509, 43)
        Me.txtVorname.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(253, 95)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(509, 43)
        Me.txtName.TabIndex = 9
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(253, 179)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(509, 43)
        Me.txtBenutzername.TabIndex = 11
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(253, 256)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(509, 43)
        Me.txtPass.TabIndex = 12
        '
        'txtPassWiederh
        '
        Me.txtPassWiederh.Location = New System.Drawing.Point(253, 334)
        Me.txtPassWiederh.Multiline = True
        Me.txtPassWiederh.Name = "txtPassWiederh"
        Me.txtPassWiederh.Size = New System.Drawing.Size(509, 43)
        Me.txtPassWiederh.TabIndex = 13
        '
        'dlgNeuerTrainer
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtPassWiederh)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.lblPassWiederh)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgNeuerTrainer"
        Me.Text = "Neuer Trainer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents lblPassWiederh As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtPassWiederh As TextBox
End Class
