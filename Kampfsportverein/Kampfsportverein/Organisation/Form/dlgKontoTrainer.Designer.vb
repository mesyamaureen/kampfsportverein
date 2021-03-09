<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgKontoTrainer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrainerID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.txtNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1060, 561)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(182, 56)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Trainer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vorname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Benutzername"
        '
        'txtTrainerID
        '
        Me.txtTrainerID.Location = New System.Drawing.Point(266, 39)
        Me.txtTrainerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTrainerID.Multiline = True
        Me.txtTrainerID.Name = "txtTrainerID"
        Me.txtTrainerID.ReadOnly = True
        Me.txtTrainerID.Size = New System.Drawing.Size(277, 43)
        Me.txtTrainerID.TabIndex = 6
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(266, 134)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(977, 43)
        Me.txtVorname.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(266, 226)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(977, 43)
        Me.txtName.TabIndex = 8
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(266, 315)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(977, 43)
        Me.txtBenutzername.TabIndex = 10
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(36, 416)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(168, 25)
        Me.lblPasswort.TabIndex = 11
        Me.lblPasswort.Text = "Neues Passwort"
        '
        'txtNeuesPasswort
        '
        Me.txtNeuesPasswort.Location = New System.Drawing.Point(266, 409)
        Me.txtNeuesPasswort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNeuesPasswort.Multiline = True
        Me.txtNeuesPasswort.Name = "txtNeuesPasswort"
        Me.txtNeuesPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNeuesPasswort.Size = New System.Drawing.Size(977, 44)
        Me.txtNeuesPasswort.TabIndex = 14
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(852, 561)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(186, 56)
        Me.btnSpeichern.TabIndex = 13
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'dlgKontoTrainer
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1253, 629)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.txtNeuesPasswort)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtTrainerID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgKontoTrainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Trainerkonto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrainerID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents lblPasswort As Label
    Friend WithEvents txtNeuesPasswort As TextBox
    Friend WithEvents btnSpeichern As Button
End Class
