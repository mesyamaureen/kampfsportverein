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
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnAnmelden = New System.Windows.Forms.Button()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(317, 200)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(125, 37)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnAnmelden
        '
        Me.btnAnmelden.Location = New System.Drawing.Point(184, 200)
        Me.btnAnmelden.Name = "btnAnmelden"
        Me.btnAnmelden.Size = New System.Drawing.Size(125, 37)
        Me.btnAnmelden.TabIndex = 1
        Me.btnAnmelden.Text = "Anmelden"
        Me.btnAnmelden.UseVisualStyleBackColor = True
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(9, 23)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(151, 25)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(12, 85)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(100, 25)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(184, 21)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(258, 32)
        Me.txtBenutzername.TabIndex = 4
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(184, 78)
        Me.txtPasswort.Multiline = True
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(258, 32)
        Me.txtPasswort.TabIndex = 5
        '
        'dlgAnmeldung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 249)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.btnAnmelden)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgAnmeldung"
        Me.Text = "Anmeldung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnAnmelden As Button
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
End Class
