﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgKursEinzeln
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
        Me.lblZeitpunkt = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblTeilnZahl = New System.Windows.Forms.Label()
        Me.lblSchwierigkeit = New System.Windows.Forms.Label()
        Me.txtZeitpunkt = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtTeilnZahl = New System.Windows.Forms.TextBox()
        Me.lblTrainer = New System.Windows.Forms.Label()
        Me.lblSportart = New System.Windows.Forms.Label()
        Me.txtSportart = New System.Windows.Forms.TextBox()
        Me.txtTrainer = New System.Windows.Forms.TextBox()
        Me.txtSchwierigkeit = New System.Windows.Forms.TextBox()
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
        'lblZeitpunkt
        '
        Me.lblZeitpunkt.AutoSize = True
        Me.lblZeitpunkt.Location = New System.Drawing.Point(12, 85)
        Me.lblZeitpunkt.Name = "lblZeitpunkt"
        Me.lblZeitpunkt.Size = New System.Drawing.Size(101, 25)
        Me.lblZeitpunkt.TabIndex = 3
        Me.lblZeitpunkt.Text = "Zeitpunkt"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(12, 166)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(41, 25)
        Me.lblOrt.TabIndex = 4
        Me.lblOrt.Text = "Ort"
        '
        'lblTeilnZahl
        '
        Me.lblTeilnZahl.AutoSize = True
        Me.lblTeilnZahl.Location = New System.Drawing.Point(12, 251)
        Me.lblTeilnZahl.Name = "lblTeilnZahl"
        Me.lblTeilnZahl.Size = New System.Drawing.Size(159, 25)
        Me.lblTeilnZahl.TabIndex = 5
        Me.lblTeilnZahl.Text = "Teilnehmerzahl"
        '
        'lblSchwierigkeit
        '
        Me.lblSchwierigkeit.AutoSize = True
        Me.lblSchwierigkeit.Location = New System.Drawing.Point(12, 336)
        Me.lblSchwierigkeit.Name = "lblSchwierigkeit"
        Me.lblSchwierigkeit.Size = New System.Drawing.Size(193, 25)
        Me.lblSchwierigkeit.TabIndex = 6
        Me.lblSchwierigkeit.Text = "Schwierigkeitsgrad"
        '
        'txtZeitpunkt
        '
        Me.txtZeitpunkt.Location = New System.Drawing.Point(232, 76)
        Me.txtZeitpunkt.Multiline = True
        Me.txtZeitpunkt.Name = "txtZeitpunkt"
        Me.txtZeitpunkt.Size = New System.Drawing.Size(530, 41)
        Me.txtZeitpunkt.TabIndex = 7
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(232, 157)
        Me.txtOrt.Multiline = True
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(530, 41)
        Me.txtOrt.TabIndex = 8
        '
        'txtTeilnZahl
        '
        Me.txtTeilnZahl.Location = New System.Drawing.Point(232, 246)
        Me.txtTeilnZahl.Multiline = True
        Me.txtTeilnZahl.Name = "txtTeilnZahl"
        Me.txtTeilnZahl.Size = New System.Drawing.Size(530, 41)
        Me.txtTeilnZahl.TabIndex = 9
        '
        'lblTrainer
        '
        Me.lblTrainer.AutoSize = True
        Me.lblTrainer.Location = New System.Drawing.Point(12, 411)
        Me.lblTrainer.Name = "lblTrainer"
        Me.lblTrainer.Size = New System.Drawing.Size(80, 25)
        Me.lblTrainer.TabIndex = 15
        Me.lblTrainer.Text = "Trainer"
        '
        'lblSportart
        '
        Me.lblSportart.AutoSize = True
        Me.lblSportart.Location = New System.Drawing.Point(12, 19)
        Me.lblSportart.Name = "lblSportart"
        Me.lblSportart.Size = New System.Drawing.Size(88, 25)
        Me.lblSportart.TabIndex = 17
        Me.lblSportart.Text = "Sportart"
        '
        'txtSportart
        '
        Me.txtSportart.Enabled = False
        Me.txtSportart.Location = New System.Drawing.Point(232, 12)
        Me.txtSportart.Multiline = True
        Me.txtSportart.Name = "txtSportart"
        Me.txtSportart.Size = New System.Drawing.Size(530, 41)
        Me.txtSportart.TabIndex = 18
        '
        'txtTrainer
        '
        Me.txtTrainer.Enabled = False
        Me.txtTrainer.Location = New System.Drawing.Point(232, 402)
        Me.txtTrainer.Multiline = True
        Me.txtTrainer.Name = "txtTrainer"
        Me.txtTrainer.Size = New System.Drawing.Size(530, 41)
        Me.txtTrainer.TabIndex = 19
        '
        'txtSchwierigkeit
        '
        Me.txtSchwierigkeit.Enabled = False
        Me.txtSchwierigkeit.Location = New System.Drawing.Point(232, 328)
        Me.txtSchwierigkeit.Multiline = True
        Me.txtSchwierigkeit.Name = "txtSchwierigkeit"
        Me.txtSchwierigkeit.Size = New System.Drawing.Size(530, 41)
        Me.txtSchwierigkeit.TabIndex = 20
        '
        'dlgKursEinzeln
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtSchwierigkeit)
        Me.Controls.Add(Me.txtTrainer)
        Me.Controls.Add(Me.txtSportart)
        Me.Controls.Add(Me.lblSportart)
        Me.Controls.Add(Me.lblTrainer)
        Me.Controls.Add(Me.txtTeilnZahl)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtZeitpunkt)
        Me.Controls.Add(Me.lblSchwierigkeit)
        Me.Controls.Add(Me.lblTeilnZahl)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblZeitpunkt)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgKursEinzeln"
        Me.Text = "Kurs bearbeiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblZeitpunkt As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblTeilnZahl As Label
    Friend WithEvents lblSchwierigkeit As Label
    Friend WithEvents txtZeitpunkt As TextBox
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtTeilnZahl As TextBox
    Friend WithEvents lblTrainer As Label
    Friend WithEvents lblSportart As Label
    Friend WithEvents txtSportart As TextBox
    Friend WithEvents txtTrainer As TextBox
    Friend WithEvents txtSchwierigkeit As TextBox
End Class
