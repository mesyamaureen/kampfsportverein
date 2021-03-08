<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSchueler
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
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.lblSchuelerID = New System.Windows.Forms.Label()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSchuelerID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(615, 477)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(147, 40)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSpeichern.Location = New System.Drawing.Point(445, 477)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(154, 40)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblSchuelerID
        '
        Me.lblSchuelerID.AutoSize = True
        Me.lblSchuelerID.Location = New System.Drawing.Point(26, 36)
        Me.lblSchuelerID.Name = "lblSchuelerID"
        Me.lblSchuelerID.Size = New System.Drawing.Size(111, 25)
        Me.lblSchuelerID.TabIndex = 2
        Me.lblSchuelerID.Text = "Schüler ID"
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(26, 112)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 3
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 198)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(26, 289)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 25)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "E-Mail"
        '
        'txtSchuelerID
        '
        Me.txtSchuelerID.Enabled = False
        Me.txtSchuelerID.Location = New System.Drawing.Point(191, 24)
        Me.txtSchuelerID.Multiline = True
        Me.txtSchuelerID.Name = "txtSchuelerID"
        Me.txtSchuelerID.Size = New System.Drawing.Size(161, 48)
        Me.txtSchuelerID.TabIndex = 7
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(191, 101)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(571, 48)
        Me.txtVorname.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(191, 186)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(571, 48)
        Me.txtName.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(191, 275)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(571, 48)
        Me.txtEmail.TabIndex = 11
        '
        'dlgSchueler
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtSchuelerID)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.lblSchuelerID)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSchueler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Schüler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblSchuelerID As Label
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtSchuelerID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
