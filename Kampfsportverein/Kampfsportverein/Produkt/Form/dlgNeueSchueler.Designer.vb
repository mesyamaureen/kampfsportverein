<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeueSchueler
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
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(610, 475)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(152, 42)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnErstellen.Location = New System.Drawing.Point(453, 475)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(151, 42)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Location = New System.Drawing.Point(29, 29)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(98, 25)
        Me.lblVorname.TabIndex = 2
        Me.lblVorname.Text = "Vorname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(29, 231)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 25)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "E-Mail"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(190, 22)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(572, 47)
        Me.txtVorname.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(190, 124)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(572, 47)
        Me.txtName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(190, 220)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(572, 47)
        Me.txtEmail.TabIndex = 9
        '
        'dlgNeueSchueler
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNeueSchueler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Neue Schüler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
