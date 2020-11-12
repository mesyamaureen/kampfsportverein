<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgKursBearbeiten
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
        Me.lblZeitpunkt = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblTrainer = New System.Windows.Forms.Label()
        Me.lblTeilnZahl = New System.Windows.Forms.Label()
        Me.lblSchwierigkeit = New System.Windows.Forms.Label()
        Me.txtZeitpunkt = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtTeilnehmerzahl = New System.Windows.Forms.TextBox()
        Me.rbtnAnfaenger = New System.Windows.Forms.RadioButton()
        Me.rbtnFortgeschritten = New System.Windows.Forms.RadioButton()
        Me.rbtnExperte = New System.Windows.Forms.RadioButton()
        Me.cboxTrainer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(629, 479)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(134, 41)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(477, 479)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(134, 41)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblZeitpunkt
        '
        Me.lblZeitpunkt.AutoSize = True
        Me.lblZeitpunkt.Location = New System.Drawing.Point(12, 25)
        Me.lblZeitpunkt.Name = "lblZeitpunkt"
        Me.lblZeitpunkt.Size = New System.Drawing.Size(101, 25)
        Me.lblZeitpunkt.TabIndex = 2
        Me.lblZeitpunkt.Text = "Zeitpunkt"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(12, 112)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(41, 25)
        Me.lblOrt.TabIndex = 3
        Me.lblOrt.Text = "Ort"
        '
        'lblTrainer
        '
        Me.lblTrainer.AutoSize = True
        Me.lblTrainer.Location = New System.Drawing.Point(12, 203)
        Me.lblTrainer.Name = "lblTrainer"
        Me.lblTrainer.Size = New System.Drawing.Size(80, 25)
        Me.lblTrainer.TabIndex = 4
        Me.lblTrainer.Text = "Trainer"
        '
        'lblTeilnZahl
        '
        Me.lblTeilnZahl.AutoSize = True
        Me.lblTeilnZahl.Location = New System.Drawing.Point(12, 298)
        Me.lblTeilnZahl.Name = "lblTeilnZahl"
        Me.lblTeilnZahl.Size = New System.Drawing.Size(159, 25)
        Me.lblTeilnZahl.TabIndex = 5
        Me.lblTeilnZahl.Text = "Teilnehmerzahl"
        '
        'lblSchwierigkeit
        '
        Me.lblSchwierigkeit.AutoSize = True
        Me.lblSchwierigkeit.Location = New System.Drawing.Point(12, 393)
        Me.lblSchwierigkeit.Name = "lblSchwierigkeit"
        Me.lblSchwierigkeit.Size = New System.Drawing.Size(193, 25)
        Me.lblSchwierigkeit.TabIndex = 6
        Me.lblSchwierigkeit.Text = "Schwierigkeitsgrad"
        '
        'txtZeitpunkt
        '
        Me.txtZeitpunkt.Location = New System.Drawing.Point(229, 12)
        Me.txtZeitpunkt.Multiline = True
        Me.txtZeitpunkt.Name = "txtZeitpunkt"
        Me.txtZeitpunkt.Size = New System.Drawing.Size(534, 44)
        Me.txtZeitpunkt.TabIndex = 7
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(229, 102)
        Me.txtOrt.Multiline = True
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(533, 44)
        Me.txtOrt.TabIndex = 8
        '
        'txtTeilnehmerzahl
        '
        Me.txtTeilnehmerzahl.Location = New System.Drawing.Point(229, 290)
        Me.txtTeilnehmerzahl.Multiline = True
        Me.txtTeilnehmerzahl.Name = "txtTeilnehmerzahl"
        Me.txtTeilnehmerzahl.Size = New System.Drawing.Size(533, 44)
        Me.txtTeilnehmerzahl.TabIndex = 10
        '
        'rbtnAnfaenger
        '
        Me.rbtnAnfaenger.AutoSize = True
        Me.rbtnAnfaenger.Location = New System.Drawing.Point(229, 389)
        Me.rbtnAnfaenger.Name = "rbtnAnfaenger"
        Me.rbtnAnfaenger.Size = New System.Drawing.Size(130, 29)
        Me.rbtnAnfaenger.TabIndex = 11
        Me.rbtnAnfaenger.TabStop = True
        Me.rbtnAnfaenger.Text = "Anfänger"
        Me.rbtnAnfaenger.UseVisualStyleBackColor = True
        '
        'rbtnFortgeschritten
        '
        Me.rbtnFortgeschritten.AutoSize = True
        Me.rbtnFortgeschritten.Location = New System.Drawing.Point(415, 389)
        Me.rbtnFortgeschritten.Name = "rbtnFortgeschritten"
        Me.rbtnFortgeschritten.Size = New System.Drawing.Size(187, 29)
        Me.rbtnFortgeschritten.TabIndex = 12
        Me.rbtnFortgeschritten.TabStop = True
        Me.rbtnFortgeschritten.Text = "Fortgeschritten"
        Me.rbtnFortgeschritten.UseVisualStyleBackColor = True
        '
        'rbtnExperte
        '
        Me.rbtnExperte.AutoSize = True
        Me.rbtnExperte.Location = New System.Drawing.Point(645, 389)
        Me.rbtnExperte.Name = "rbtnExperte"
        Me.rbtnExperte.Size = New System.Drawing.Size(117, 29)
        Me.rbtnExperte.TabIndex = 13
        Me.rbtnExperte.TabStop = True
        Me.rbtnExperte.Text = "Experte"
        Me.rbtnExperte.UseVisualStyleBackColor = True
        '
        'cboxTrainer
        '
        Me.cboxTrainer.FormattingEnabled = True
        Me.cboxTrainer.Location = New System.Drawing.Point(229, 200)
        Me.cboxTrainer.Name = "cboxTrainer"
        Me.cboxTrainer.Size = New System.Drawing.Size(533, 33)
        Me.cboxTrainer.TabIndex = 14
        '
        'dlgKursBearbeiten
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.cboxTrainer)
        Me.Controls.Add(Me.rbtnExperte)
        Me.Controls.Add(Me.rbtnFortgeschritten)
        Me.Controls.Add(Me.rbtnAnfaenger)
        Me.Controls.Add(Me.txtTeilnehmerzahl)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtZeitpunkt)
        Me.Controls.Add(Me.lblSchwierigkeit)
        Me.Controls.Add(Me.lblTeilnZahl)
        Me.Controls.Add(Me.lblTrainer)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblZeitpunkt)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgKursBearbeiten"
        Me.Text = "Kurs bearbeiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblZeitpunkt As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblTrainer As Label
    Friend WithEvents lblTeilnZahl As Label
    Friend WithEvents lblSchwierigkeit As Label
    Friend WithEvents txtZeitpunkt As TextBox
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtTeilnehmerzahl As TextBox
    Friend WithEvents rbtnAnfaenger As RadioButton
    Friend WithEvents rbtnFortgeschritten As RadioButton
    Friend WithEvents rbtnExperte As RadioButton
    Friend WithEvents cboxTrainer As ComboBox
End Class
