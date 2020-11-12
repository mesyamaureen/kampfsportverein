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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.rbtnAnfaenger = New System.Windows.Forms.RadioButton()
        Me.rbtnFortgeschritten = New System.Windows.Forms.RadioButton()
        Me.rbtnExperte = New System.Windows.Forms.RadioButton()
        Me.cboxTrainer = New System.Windows.Forms.ComboBox()
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
        Me.lblZeitpunkt.Location = New System.Drawing.Point(12, 31)
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
        Me.lblTrainer.Location = New System.Drawing.Point(12, 199)
        Me.lblTrainer.Name = "lblTrainer"
        Me.lblTrainer.Size = New System.Drawing.Size(80, 25)
        Me.lblTrainer.TabIndex = 4
        Me.lblTrainer.Text = "Trainer"
        '
        'lblTeilnZahl
        '
        Me.lblTeilnZahl.AutoSize = True
        Me.lblTeilnZahl.Location = New System.Drawing.Point(12, 285)
        Me.lblTeilnZahl.Name = "lblTeilnZahl"
        Me.lblTeilnZahl.Size = New System.Drawing.Size(159, 25)
        Me.lblTeilnZahl.TabIndex = 5
        Me.lblTeilnZahl.Text = "Teilnehmerzahl"
        '
        'lblSchwierigkeitsgrad
        '
        Me.lblSchwierigkeitsgrad.AutoSize = True
        Me.lblSchwierigkeitsgrad.Location = New System.Drawing.Point(12, 379)
        Me.lblSchwierigkeitsgrad.Name = "lblSchwierigkeitsgrad"
        Me.lblSchwierigkeitsgrad.Size = New System.Drawing.Size(193, 25)
        Me.lblSchwierigkeitsgrad.TabIndex = 6
        Me.lblSchwierigkeitsgrad.Text = "Schwierigkeitsgrad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(244, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(518, 42)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(244, 103)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(518, 42)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(244, 274)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(518, 42)
        Me.TextBox3.TabIndex = 9
        '
        'rbtnAnfaenger
        '
        Me.rbtnAnfaenger.AutoSize = True
        Me.rbtnAnfaenger.Location = New System.Drawing.Point(244, 377)
        Me.rbtnAnfaenger.Name = "rbtnAnfaenger"
        Me.rbtnAnfaenger.Size = New System.Drawing.Size(130, 29)
        Me.rbtnAnfaenger.TabIndex = 10
        Me.rbtnAnfaenger.TabStop = True
        Me.rbtnAnfaenger.Text = "Anfänger"
        Me.rbtnAnfaenger.UseVisualStyleBackColor = True
        '
        'rbtnFortgeschritten
        '
        Me.rbtnFortgeschritten.AutoSize = True
        Me.rbtnFortgeschritten.Location = New System.Drawing.Point(423, 379)
        Me.rbtnFortgeschritten.Name = "rbtnFortgeschritten"
        Me.rbtnFortgeschritten.Size = New System.Drawing.Size(187, 29)
        Me.rbtnFortgeschritten.TabIndex = 11
        Me.rbtnFortgeschritten.TabStop = True
        Me.rbtnFortgeschritten.Text = "Fortgeschritten"
        Me.rbtnFortgeschritten.UseVisualStyleBackColor = True
        '
        'rbtnExperte
        '
        Me.rbtnExperte.AutoSize = True
        Me.rbtnExperte.Location = New System.Drawing.Point(645, 379)
        Me.rbtnExperte.Name = "rbtnExperte"
        Me.rbtnExperte.Size = New System.Drawing.Size(117, 29)
        Me.rbtnExperte.TabIndex = 12
        Me.rbtnExperte.TabStop = True
        Me.rbtnExperte.Text = "Experte"
        Me.rbtnExperte.UseVisualStyleBackColor = True
        '
        'cboxTrainer
        '
        Me.cboxTrainer.FormattingEnabled = True
        Me.cboxTrainer.Location = New System.Drawing.Point(244, 194)
        Me.cboxTrainer.Name = "cboxTrainer"
        Me.cboxTrainer.Size = New System.Drawing.Size(518, 33)
        Me.cboxTrainer.TabIndex = 13
        '
        'dlgNeuerKurs
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.cboxTrainer)
        Me.Controls.Add(Me.rbtnExperte)
        Me.Controls.Add(Me.rbtnFortgeschritten)
        Me.Controls.Add(Me.rbtnAnfaenger)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents rbtnAnfaenger As RadioButton
    Friend WithEvents rbtnFortgeschritten As RadioButton
    Friend WithEvents rbtnExperte As RadioButton
    Friend WithEvents cboxTrainer As ComboBox
End Class
