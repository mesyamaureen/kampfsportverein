<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMeinKontoTrainer
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
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrainerID = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBenutzername = New System.Windows.Forms.TextBox()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSchliessen
        '
        Me.btnSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSchliessen.Location = New System.Drawing.Point(808, 449)
        Me.btnSchliessen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(124, 45)
        Me.btnSchliessen.TabIndex = 0
        Me.btnSchliessen.Text = "Schließen"
        Me.btnSchliessen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Trainer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vorname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Benutzername"
        '
        'txtTrainerID
        '
        Me.txtTrainerID.Location = New System.Drawing.Point(183, 34)
        Me.txtTrainerID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTrainerID.Multiline = True
        Me.txtTrainerID.Name = "txtTrainerID"
        Me.txtTrainerID.ReadOnly = True
        Me.txtTrainerID.Size = New System.Drawing.Size(209, 35)
        Me.txtTrainerID.TabIndex = 6
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(183, 107)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVorname.Multiline = True
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(750, 35)
        Me.txtVorname.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(183, 181)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(750, 35)
        Me.txtName.TabIndex = 8
        '
        'txtBenutzername
        '
        Me.txtBenutzername.Location = New System.Drawing.Point(183, 252)
        Me.txtBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBenutzername.Multiline = True
        Me.txtBenutzername.Name = "txtBenutzername"
        Me.txtBenutzername.Size = New System.Drawing.Size(750, 35)
        Me.txtBenutzername.TabIndex = 10
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(27, 333)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(74, 20)
        Me.lblPasswort.TabIndex = 11
        Me.lblPasswort.Text = "Passwort"
        '
        'txtPasswort
        '
        Me.txtPasswort.Location = New System.Drawing.Point(183, 327)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.Size = New System.Drawing.Size(750, 26)
        Me.txtPasswort.TabIndex = 12
        '
        'dlgMeinKontoTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSchliessen
        Me.ClientSize = New System.Drawing.Size(940, 503)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.txtBenutzername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.txtTrainerID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSchliessen)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgMeinKontoTrainer"
        Me.Text = "Mein Trainerkonto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSchliessen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrainerID As TextBox
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents lblPasswort As Label
    Friend WithEvents txtPasswort As TextBox
End Class
