<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTrainerKonto
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
        Me.lblTrainerID = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblNeuesPassw = New System.Windows.Forms.Label()
        Me.lblPassWiederh = New System.Windows.Forms.Label()
        Me.txtTrainerID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGebDat = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtNeuesPass = New System.Windows.Forms.TextBox()
        Me.txtPassWiederh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1116, 580)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(126, 37)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSpeichern.Location = New System.Drawing.Point(973, 580)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(124, 37)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblTrainerID
        '
        Me.lblTrainerID.AutoSize = True
        Me.lblTrainerID.Location = New System.Drawing.Point(26, 33)
        Me.lblTrainerID.Name = "lblTrainerID"
        Me.lblTrainerID.Size = New System.Drawing.Size(106, 25)
        Me.lblTrainerID.TabIndex = 2
        Me.lblTrainerID.Text = "Trainer ID"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(26, 105)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 3
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 182)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(26, 258)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(147, 25)
        Me.lblGebDat.TabIndex = 5
        Me.lblGebDat.Text = "Geburtsdatum"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(26, 340)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 6
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblNeuesPassw
        '
        Me.lblNeuesPassw.AutoSize = True
        Me.lblNeuesPassw.Location = New System.Drawing.Point(26, 422)
        Me.lblNeuesPassw.Name = "lblNeuesPassw"
        Me.lblNeuesPassw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNeuesPassw.Size = New System.Drawing.Size(168, 25)
        Me.lblNeuesPassw.TabIndex = 7
        Me.lblNeuesPassw.Text = "Neues Passwort"
        '
        'lblPassWiederh
        '
        Me.lblPassWiederh.AutoSize = True
        Me.lblPassWiederh.Location = New System.Drawing.Point(26, 507)
        Me.lblPassWiederh.Name = "lblPassWiederh"
        Me.lblPassWiederh.Size = New System.Drawing.Size(222, 25)
        Me.lblPassWiederh.TabIndex = 8
        Me.lblPassWiederh.Text = "Passwort wiederholen"
        '
        'txtTrainerID
        '
        Me.txtTrainerID.Location = New System.Drawing.Point(280, 20)
        Me.txtTrainerID.Multiline = True
        Me.txtTrainerID.Name = "txtTrainerID"
        Me.txtTrainerID.ReadOnly = True
        Me.txtTrainerID.Size = New System.Drawing.Size(175, 38)
        Me.txtTrainerID.TabIndex = 9
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(280, 102)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(962, 38)
        Me.txtVorname.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(280, 179)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(962, 38)
        Me.txtName.TabIndex = 11
        '
        'txtGebDat
        '
        Me.txtGebDat.Location = New System.Drawing.Point(280, 245)
        Me.txtGebDat.Multiline = True
        Me.txtGebDat.Name = "txtGebDat"
        Me.txtGebDat.Size = New System.Drawing.Size(962, 38)
        Me.txtGebDat.TabIndex = 12
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(280, 327)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(962, 38)
        Me.txtBenutzername.TabIndex = 13
        '
        'txtNeuesPass
        '
        Me.txtNeuesPass.Location = New System.Drawing.Point(280, 419)
        Me.txtNeuesPass.Multiline = True
        Me.txtNeuesPass.Name = "txtNeuesPass"
        Me.txtNeuesPass.Size = New System.Drawing.Size(962, 38)
        Me.txtNeuesPass.TabIndex = 14
        '
        'txtPassWiederh
        '
        Me.txtPassWiederh.Location = New System.Drawing.Point(280, 504)
        Me.txtPassWiederh.Multiline = True
        Me.txtPassWiederh.Name = "txtPassWiederh"
        Me.txtPassWiederh.Size = New System.Drawing.Size(962, 38)
        Me.txtPassWiederh.TabIndex = 15
        '
        'dlgTrainerKonto
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.txtPassWiederh)
        Me.Controls.Add(Me.txtNeuesPass)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtGebDat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtTrainerID)
        Me.Controls.Add(Me.lblPassWiederh)
        Me.Controls.Add(Me.lblNeuesPassw)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblTrainerID)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgTrainerKonto"
        Me.Text = "Trainerkonto bearbeiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblTrainerID As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblNeuesPassw As Label
    Friend WithEvents lblPassWiederh As Label
    Friend WithEvents txtTrainerID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGebDat As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtNeuesPass As TextBox
    Friend WithEvents txtPassWiederh As TextBox
End Class
