<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeuerKurs
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
        Me.lblZeitpunkt = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblTrainer = New System.Windows.Forms.Label()
        Me.lblTeilnZahl = New System.Windows.Forms.Label()
        Me.lblSchwierigkeitsgrad = New System.Windows.Forms.Label()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtTeilnZahl = New System.Windows.Forms.TextBox()
        Me.cmbTrainer = New System.Windows.Forms.ComboBox()
        Me.cmbSportart = New System.Windows.Forms.ComboBox()
        Me.lblSportart = New System.Windows.Forms.Label()
        Me.datKurs = New System.Windows.Forms.DateTimePicker()
        Me.txtSchwierigkeit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(626, 478)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(136, 39)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(500, 478)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(120, 39)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
        '
        'lblZeitpunkt
        '
        Me.lblZeitpunkt.AutoSize = True
        Me.lblZeitpunkt.Location = New System.Drawing.Point(12, 99)
        Me.lblZeitpunkt.Name = "lblZeitpunkt"
        Me.lblZeitpunkt.Size = New System.Drawing.Size(101, 25)
        Me.lblZeitpunkt.TabIndex = 2
        Me.lblZeitpunkt.Text = "Zeitpunkt"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Location = New System.Drawing.Point(12, 174)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(41, 25)
        Me.lblOrt.TabIndex = 3
        Me.lblOrt.Text = "Ort"
        '
        'lblTrainer
        '
        Me.lblTrainer.AutoSize = True
        Me.lblTrainer.Location = New System.Drawing.Point(12, 400)
        Me.lblTrainer.Name = "lblTrainer"
        Me.lblTrainer.Size = New System.Drawing.Size(80, 25)
        Me.lblTrainer.TabIndex = 4
        Me.lblTrainer.Text = "Trainer"
        '
        'lblTeilnZahl
        '
        Me.lblTeilnZahl.AutoSize = True
        Me.lblTeilnZahl.Location = New System.Drawing.Point(12, 254)
        Me.lblTeilnZahl.Name = "lblTeilnZahl"
        Me.lblTeilnZahl.Size = New System.Drawing.Size(159, 25)
        Me.lblTeilnZahl.TabIndex = 5
        Me.lblTeilnZahl.Text = "Teilnehmerzahl"
        '
        'lblSchwierigkeitsgrad
        '
        Me.lblSchwierigkeitsgrad.AutoSize = True
        Me.lblSchwierigkeitsgrad.Location = New System.Drawing.Point(12, 331)
        Me.lblSchwierigkeitsgrad.Name = "lblSchwierigkeitsgrad"
        Me.lblSchwierigkeitsgrad.Size = New System.Drawing.Size(193, 25)
        Me.lblSchwierigkeitsgrad.TabIndex = 6
        Me.lblSchwierigkeitsgrad.Text = "Schwierigkeitsgrad"
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(244, 165)
        Me.txtOrt.Multiline = True
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(518, 42)
        Me.txtOrt.TabIndex = 8
        '
        'txtTeilnZahl
        '
        Me.txtTeilnZahl.Location = New System.Drawing.Point(244, 243)
        Me.txtTeilnZahl.Multiline = True
        Me.txtTeilnZahl.Name = "txtTeilnZahl"
        Me.txtTeilnZahl.Size = New System.Drawing.Size(518, 42)
        Me.txtTeilnZahl.TabIndex = 9
        '
        'cmbTrainer
        '
        Me.cmbTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrainer.FormattingEnabled = True
        Me.cmbTrainer.Location = New System.Drawing.Point(244, 395)
        Me.cmbTrainer.Name = "cmbTrainer"
        Me.cmbTrainer.Size = New System.Drawing.Size(518, 33)
        Me.cmbTrainer.TabIndex = 13
        '
        'cmbSportart
        '
        Me.cmbSportart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSportart.FormattingEnabled = True
        Me.cmbSportart.Location = New System.Drawing.Point(244, 23)
        Me.cmbSportart.Name = "cmbSportart"
        Me.cmbSportart.Size = New System.Drawing.Size(518, 33)
        Me.cmbSportart.TabIndex = 16
        '
        'lblSportart
        '
        Me.lblSportart.AutoSize = True
        Me.lblSportart.Location = New System.Drawing.Point(12, 28)
        Me.lblSportart.Name = "lblSportart"
        Me.lblSportart.Size = New System.Drawing.Size(88, 25)
        Me.lblSportart.TabIndex = 15
        Me.lblSportart.Text = "Sportart"
        '
        'datKurs
        '
        Me.datKurs.Location = New System.Drawing.Point(244, 93)
        Me.datKurs.MinDate = New Date(2021, 3, 6, 0, 0, 0, 0)
        Me.datKurs.Name = "datKurs"
        Me.datKurs.Size = New System.Drawing.Size(518, 31)
        Me.datKurs.TabIndex = 17
        '
        'txtSchwierigkeit
        '
        Me.txtSchwierigkeit.Location = New System.Drawing.Point(244, 323)
        Me.txtSchwierigkeit.Multiline = True
        Me.txtSchwierigkeit.Name = "txtSchwierigkeit"
        Me.txtSchwierigkeit.Size = New System.Drawing.Size(518, 42)
        Me.txtSchwierigkeit.TabIndex = 18
        '
        'dlgNeuerKurs
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.txtSchwierigkeit)
        Me.Controls.Add(Me.datKurs)
        Me.Controls.Add(Me.cmbSportart)
        Me.Controls.Add(Me.lblSportart)
        Me.Controls.Add(Me.cmbTrainer)
        Me.Controls.Add(Me.txtTeilnZahl)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.lblSchwierigkeitsgrad)
        Me.Controls.Add(Me.lblTeilnZahl)
        Me.Controls.Add(Me.lblTrainer)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblZeitpunkt)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgNeuerKurs"
        Me.Text = "Neuer Kurs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblZeitpunkt As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblTrainer As Label
    Friend WithEvents lblTeilnZahl As Label
    Friend WithEvents lblSchwierigkeitsgrad As Label
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtTeilnZahl As TextBox
    Friend WithEvents cmbTrainer As ComboBox
    Friend WithEvents cmbSportart As ComboBox
    Friend WithEvents lblSportart As Label
    Friend WithEvents datKurs As DateTimePicker
    Friend WithEvents txtSchwierigkeit As TextBox
End Class
