<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSportEinzel
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHerkunftsland = New System.Windows.Forms.Label()
        Me.lblMindestalter = New System.Windows.Forms.Label()
        Me.tabSportart = New System.Windows.Forms.TabControl()
        Me.tabZielgruppe = New System.Windows.Forms.TabPage()
        Me.tabKurs = New System.Windows.Forms.TabPage()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHerkunftsland = New System.Windows.Forms.TextBox()
        Me.txtMindestalter = New System.Windows.Forms.TextBox()
        Me.rtxtZielgruppe = New System.Windows.Forms.RichTextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colZeitpunkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTrainer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchwierigkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnNeuerKurs = New System.Windows.Forms.Button()
        Me.btnBearbeiten = New System.Windows.Forms.Button()
        Me.tabSportart.SuspendLayout()
        Me.tabZielgruppe.SuspendLayout()
        Me.tabKurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(1110, 571)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(132, 46)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(962, 571)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(132, 46)
        Me.btnSpeichern.TabIndex = 1
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblHerkunftsland
        '
        Me.lblHerkunftsland.AutoSize = True
        Me.lblHerkunftsland.Location = New System.Drawing.Point(12, 92)
        Me.lblHerkunftsland.Name = "lblHerkunftsland"
        Me.lblHerkunftsland.Size = New System.Drawing.Size(145, 25)
        Me.lblHerkunftsland.TabIndex = 3
        Me.lblHerkunftsland.Text = "Herkunftsland"
        '
        'lblMindestalter
        '
        Me.lblMindestalter.AutoSize = True
        Me.lblMindestalter.Location = New System.Drawing.Point(12, 158)
        Me.lblMindestalter.Name = "lblMindestalter"
        Me.lblMindestalter.Size = New System.Drawing.Size(130, 25)
        Me.lblMindestalter.TabIndex = 4
        Me.lblMindestalter.Text = "Mindestalter"
        '
        'tabSportart
        '
        Me.tabSportart.Controls.Add(Me.tabZielgruppe)
        Me.tabSportart.Controls.Add(Me.tabKurs)
        Me.tabSportart.Location = New System.Drawing.Point(17, 222)
        Me.tabSportart.Name = "tabSportart"
        Me.tabSportart.SelectedIndex = 0
        Me.tabSportart.Size = New System.Drawing.Size(1225, 326)
        Me.tabSportart.TabIndex = 5
        '
        'tabZielgruppe
        '
        Me.tabZielgruppe.Controls.Add(Me.rtxtZielgruppe)
        Me.tabZielgruppe.Location = New System.Drawing.Point(8, 39)
        Me.tabZielgruppe.Name = "tabZielgruppe"
        Me.tabZielgruppe.Padding = New System.Windows.Forms.Padding(3)
        Me.tabZielgruppe.Size = New System.Drawing.Size(1209, 279)
        Me.tabZielgruppe.TabIndex = 0
        Me.tabZielgruppe.Text = "Zielgruppe"
        Me.tabZielgruppe.UseVisualStyleBackColor = True
        '
        'tabKurs
        '
        Me.tabKurs.Controls.Add(Me.btnBearbeiten)
        Me.tabKurs.Controls.Add(Me.btnNeuerKurs)
        Me.tabKurs.Controls.Add(Me.btnLoeschen)
        Me.tabKurs.Controls.Add(Me.ListView1)
        Me.tabKurs.Location = New System.Drawing.Point(8, 39)
        Me.tabKurs.Name = "tabKurs"
        Me.tabKurs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabKurs.Size = New System.Drawing.Size(1209, 279)
        Me.tabKurs.TabIndex = 1
        Me.tabKurs.Text = "Kurs"
        Me.tabKurs.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(222, 20)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(1012, 42)
        Me.txtName.TabIndex = 6
        '
        'txtHerkunftsland
        '
        Me.txtHerkunftsland.Location = New System.Drawing.Point(222, 84)
        Me.txtHerkunftsland.Multiline = True
        Me.txtHerkunftsland.Name = "txtHerkunftsland"
        Me.txtHerkunftsland.Size = New System.Drawing.Size(1012, 42)
        Me.txtHerkunftsland.TabIndex = 7
        '
        'txtMindestalter
        '
        Me.txtMindestalter.Location = New System.Drawing.Point(222, 151)
        Me.txtMindestalter.Multiline = True
        Me.txtMindestalter.Name = "txtMindestalter"
        Me.txtMindestalter.Size = New System.Drawing.Size(1012, 42)
        Me.txtMindestalter.TabIndex = 8
        '
        'rtxtZielgruppe
        '
        Me.rtxtZielgruppe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtZielgruppe.Location = New System.Drawing.Point(3, 3)
        Me.rtxtZielgruppe.Name = "rtxtZielgruppe"
        Me.rtxtZielgruppe.Size = New System.Drawing.Size(1203, 273)
        Me.rtxtZielgruppe.TabIndex = 0
        Me.rtxtZielgruppe.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colZeitpunkt, Me.colOrt, Me.colTrainer, Me.colVerfuegbarkeit, Me.colSchwierigkeit})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 3)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1209, 228)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 77
        '
        'colZeitpunkt
        '
        Me.colZeitpunkt.Text = "Zeitpunkt"
        Me.colZeitpunkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colZeitpunkt.Width = 359
        '
        'colOrt
        '
        Me.colOrt.Text = "Ort"
        Me.colOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colOrt.Width = 174
        '
        'colTrainer
        '
        Me.colTrainer.Text = "Trainer"
        Me.colTrainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colTrainer.Width = 227
        '
        'colVerfuegbarkeit
        '
        Me.colVerfuegbarkeit.Text = "Verfügbarkeit"
        Me.colVerfuegbarkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVerfuegbarkeit.Width = 175
        '
        'colSchwierigkeit
        '
        Me.colSchwierigkeit.Text = "Schwierigkeitsgrad"
        Me.colSchwierigkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSchwierigkeit.Width = 193
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(1085, 237)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(115, 37)
        Me.btnLoeschen.TabIndex = 1
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnNeuerKurs
        '
        Me.btnNeuerKurs.Location = New System.Drawing.Point(933, 237)
        Me.btnNeuerKurs.Name = "btnNeuerKurs"
        Me.btnNeuerKurs.Size = New System.Drawing.Size(138, 37)
        Me.btnNeuerKurs.TabIndex = 2
        Me.btnNeuerKurs.Text = "Neuer Kurs"
        Me.btnNeuerKurs.UseVisualStyleBackColor = True
        '
        'btnBearbeiten
        '
        Me.btnBearbeiten.Location = New System.Drawing.Point(789, 237)
        Me.btnBearbeiten.Name = "btnBearbeiten"
        Me.btnBearbeiten.Size = New System.Drawing.Size(127, 37)
        Me.btnBearbeiten.TabIndex = 3
        Me.btnBearbeiten.Text = "Bearbeiten"
        Me.btnBearbeiten.UseVisualStyleBackColor = True
        '
        'dlgSportEinzel
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.txtMindestalter)
        Me.Controls.Add(Me.txtHerkunftsland)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.tabSportart)
        Me.Controls.Add(Me.lblMindestalter)
        Me.Controls.Add(Me.lblHerkunftsland)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgSportEinzel"
        Me.Text = "Sportart"
        Me.tabSportart.ResumeLayout(False)
        Me.tabZielgruppe.ResumeLayout(False)
        Me.tabKurs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblHerkunftsland As Label
    Friend WithEvents lblMindestalter As Label
    Friend WithEvents tabSportart As TabControl
    Friend WithEvents tabZielgruppe As TabPage
    Friend WithEvents tabKurs As TabPage
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHerkunftsland As TextBox
    Friend WithEvents txtMindestalter As TextBox
    Friend WithEvents rtxtZielgruppe As RichTextBox
    Friend WithEvents btnBearbeiten As Button
    Friend WithEvents btnNeuerKurs As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colZeitpunkt As ColumnHeader
    Friend WithEvents colOrt As ColumnHeader
    Friend WithEvents colTrainer As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents colSchwierigkeit As ColumnHeader
End Class
