<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgKursEinzelTrainer
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
        Me.btnAbsagen = New System.Windows.Forms.Button()
        Me.lblZeitpunkt = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblTeilnZahl = New System.Windows.Forms.Label()
        Me.lblSchwierigkeit = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(634, 480)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(128, 37)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(496, 480)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(128, 37)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbsagen
        '
        Me.btnAbsagen.Location = New System.Drawing.Point(359, 480)
        Me.btnAbsagen.Name = "btnAbsagen"
        Me.btnAbsagen.Size = New System.Drawing.Size(128, 37)
        Me.btnAbsagen.TabIndex = 2
        Me.btnAbsagen.Text = "Absagen"
        Me.btnAbsagen.UseVisualStyleBackColor = True
        '
        'lblZeitpunkt
        '
        Me.lblZeitpunkt.AutoSize = True
        Me.lblZeitpunkt.Location = New System.Drawing.Point(12, 38)
        Me.lblZeitpunkt.Name = "lblZeitpunkt"
        Me.lblZeitpunkt.Size = New System.Drawing.Size(101, 25)
        Me.lblZeitpunkt.TabIndex = 3
        Me.lblZeitpunkt.Text = "Zeitpunkt"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(12, 127)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(41, 25)
        Me.lblOrt.TabIndex = 4
        Me.lblOrt.Text = "Ort"
        '
        'lblTeilnZahl
        '
        Me.lblTeilnZahl.AutoSize = True
        Me.lblTeilnZahl.Location = New System.Drawing.Point(12, 212)
        Me.lblTeilnZahl.Name = "lblTeilnZahl"
        Me.lblTeilnZahl.Size = New System.Drawing.Size(159, 25)
        Me.lblTeilnZahl.TabIndex = 5
        Me.lblTeilnZahl.Text = "Teilnehmerzahl"
        '
        'lblSchwierigkeit
        '
        Me.lblSchwierigkeit.AutoSize = True
        Me.lblSchwierigkeit.Location = New System.Drawing.Point(12, 308)
        Me.lblSchwierigkeit.Name = "lblSchwierigkeit"
        Me.lblSchwierigkeit.Size = New System.Drawing.Size(193, 25)
        Me.lblSchwierigkeit.TabIndex = 6
        Me.lblSchwierigkeit.Text = "Schwierigkeitsgrad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(530, 41)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(232, 118)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(530, 41)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(232, 207)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(530, 41)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(232, 302)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(530, 41)
        Me.TextBox4.TabIndex = 10
        '
        'dlgKursEinzelTrainer
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSchwierigkeit)
        Me.Controls.Add(Me.lblTeilnZahl)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblZeitpunkt)
        Me.Controls.Add(Me.btnAbsagen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgKursEinzelTrainer"
        Me.Text = "Kurs bearbeiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbsagen As Button
    Friend WithEvents lblZeitpunkt As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblTeilnZahl As Label
    Friend WithEvents lblSchwierigkeit As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
