<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHauptfensterMit
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
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.grpboxMenu = New System.Windows.Forms.GroupBox()
        Me.btnNeuerMitarbeiter = New System.Windows.Forms.Button()
        Me.btnTrainer = New System.Windows.Forms.Button()
        Me.btnSchueler = New System.Windows.Forms.Button()
        Me.btnKurs = New System.Windows.Forms.Button()
        Me.btnSportarten = New System.Windows.Forms.Button()
        Me.btnMeinKonto = New System.Windows.Forms.Button()
        Me.grpboxSportartliste = New System.Windows.Forms.GroupBox()
        Me.lstSportart = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnOeffnen = New System.Windows.Forms.Button()
        Me.lstTrainer = New System.Windows.Forms.ListView()
        Me.colTrainerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNameTrainer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVornameTrainer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstSchuelerAlle = New System.Windows.Forms.ListView()
        Me.colSchuelerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstKurseAlle = New System.Windows.Forms.ListView()
        Me.colKursId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportartKurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpboxMenu.SuspendLayout()
        Me.grpboxSportartliste.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeenden
        '
        Me.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeenden.Location = New System.Drawing.Point(1091, 889)
        Me.btnBeenden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(127, 44)
        Me.btnBeenden.TabIndex = 0
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'grpboxMenu
        '
        Me.grpboxMenu.Controls.Add(Me.btnNeuerMitarbeiter)
        Me.grpboxMenu.Controls.Add(Me.btnTrainer)
        Me.grpboxMenu.Controls.Add(Me.btnSchueler)
        Me.grpboxMenu.Controls.Add(Me.btnKurs)
        Me.grpboxMenu.Controls.Add(Me.btnSportarten)
        Me.grpboxMenu.Controls.Add(Me.btnMeinKonto)
        Me.grpboxMenu.Location = New System.Drawing.Point(12, 12)
        Me.grpboxMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxMenu.Name = "grpboxMenu"
        Me.grpboxMenu.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxMenu.Size = New System.Drawing.Size(347, 848)
        Me.grpboxMenu.TabIndex = 1
        Me.grpboxMenu.TabStop = False
        '
        'btnNeuerMitarbeiter
        '
        Me.btnNeuerMitarbeiter.Location = New System.Drawing.Point(42, 733)
        Me.btnNeuerMitarbeiter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNeuerMitarbeiter.Name = "btnNeuerMitarbeiter"
        Me.btnNeuerMitarbeiter.Size = New System.Drawing.Size(267, 95)
        Me.btnNeuerMitarbeiter.TabIndex = 10
        Me.btnNeuerMitarbeiter.Text = "Neuer Mitarbeiter"
        Me.btnNeuerMitarbeiter.UseVisualStyleBackColor = True
        '
        'btnTrainer
        '
        Me.btnTrainer.Location = New System.Drawing.Point(42, 450)
        Me.btnTrainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTrainer.Name = "btnTrainer"
        Me.btnTrainer.Size = New System.Drawing.Size(267, 95)
        Me.btnTrainer.TabIndex = 9
        Me.btnTrainer.Text = "Trainer"
        Me.btnTrainer.UseVisualStyleBackColor = True
        '
        'btnSchueler
        '
        Me.btnSchueler.Location = New System.Drawing.Point(42, 312)
        Me.btnSchueler.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSchueler.Name = "btnSchueler"
        Me.btnSchueler.Size = New System.Drawing.Size(267, 95)
        Me.btnSchueler.TabIndex = 8
        Me.btnSchueler.Text = "Schüler"
        Me.btnSchueler.UseVisualStyleBackColor = True
        '
        'btnKurs
        '
        Me.btnKurs.Location = New System.Drawing.Point(42, 169)
        Me.btnKurs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKurs.Name = "btnKurs"
        Me.btnKurs.Size = New System.Drawing.Size(267, 95)
        Me.btnKurs.TabIndex = 5
        Me.btnKurs.Text = "Kurse"
        Me.btnKurs.UseVisualStyleBackColor = True
        '
        'btnSportarten
        '
        Me.btnSportarten.Location = New System.Drawing.Point(42, 28)
        Me.btnSportarten.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSportarten.Name = "btnSportarten"
        Me.btnSportarten.Size = New System.Drawing.Size(267, 95)
        Me.btnSportarten.TabIndex = 3
        Me.btnSportarten.Text = "Sportarten"
        Me.btnSportarten.UseVisualStyleBackColor = True
        '
        'btnMeinKonto
        '
        Me.btnMeinKonto.Location = New System.Drawing.Point(42, 593)
        Me.btnMeinKonto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMeinKonto.Name = "btnMeinKonto"
        Me.btnMeinKonto.Size = New System.Drawing.Size(267, 95)
        Me.btnMeinKonto.TabIndex = 2
        Me.btnMeinKonto.Text = "Mein Konto"
        Me.btnMeinKonto.UseVisualStyleBackColor = True
        '
        'grpboxSportartliste
        '
        Me.grpboxSportartliste.Controls.Add(Me.lstSportart)
        Me.grpboxSportartliste.Controls.Add(Me.btnNeu)
        Me.grpboxSportartliste.Controls.Add(Me.btnLoeschen)
        Me.grpboxSportartliste.Controls.Add(Me.btnOeffnen)
        Me.grpboxSportartliste.Controls.Add(Me.lstTrainer)
        Me.grpboxSportartliste.Controls.Add(Me.lstSchuelerAlle)
        Me.grpboxSportartliste.Controls.Add(Me.lstKurseAlle)
        Me.grpboxSportartliste.Location = New System.Drawing.Point(376, 12)
        Me.grpboxSportartliste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSportartliste.Name = "grpboxSportartliste"
        Me.grpboxSportartliste.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSportartliste.Size = New System.Drawing.Size(857, 848)
        Me.grpboxSportartliste.TabIndex = 2
        Me.grpboxSportartliste.TabStop = False
        '
        'lstSportart
        '
        Me.lstSportart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colSportart})
        Me.lstSportart.FullRowSelect = True
        Me.lstSportart.GridLines = True
        Me.lstSportart.HideSelection = False
        Me.lstSportart.Location = New System.Drawing.Point(6, 9)
        Me.lstSportart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstSportart.MultiSelect = False
        Me.lstSportart.Name = "lstSportart"
        Me.lstSportart.Size = New System.Drawing.Size(852, 754)
        Me.lstSportart.TabIndex = 0
        Me.lstSportart.UseCompatibleStateImageBehavior = False
        Me.lstSportart.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 100
        '
        'colSportart
        '
        Me.colSportart.Text = "Sportart"
        Me.colSportart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSportart.Width = 300
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(375, 784)
        Me.btnNeu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(147, 44)
        Me.btnNeu.TabIndex = 6
        Me.btnNeu.Text = "Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(538, 784)
        Me.btnLoeschen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(147, 44)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnOeffnen
        '
        Me.btnOeffnen.Location = New System.Drawing.Point(700, 784)
        Me.btnOeffnen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOeffnen.Name = "btnOeffnen"
        Me.btnOeffnen.Size = New System.Drawing.Size(147, 44)
        Me.btnOeffnen.TabIndex = 4
        Me.btnOeffnen.Text = "Öffnen"
        Me.btnOeffnen.UseVisualStyleBackColor = True
        '
        'lstTrainer
        '
        Me.lstTrainer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTrainerID, Me.colNameTrainer, Me.colVornameTrainer})
        Me.lstTrainer.FullRowSelect = True
        Me.lstTrainer.GridLines = True
        Me.lstTrainer.HideSelection = False
        Me.lstTrainer.Location = New System.Drawing.Point(5, 9)
        Me.lstTrainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTrainer.MultiSelect = False
        Me.lstTrainer.Name = "lstTrainer"
        Me.lstTrainer.Size = New System.Drawing.Size(852, 754)
        Me.lstTrainer.TabIndex = 9
        Me.lstTrainer.UseCompatibleStateImageBehavior = False
        Me.lstTrainer.View = System.Windows.Forms.View.Details
        '
        'colTrainerID
        '
        Me.colTrainerID.Text = "Trainer ID"
        Me.colTrainerID.Width = 126
        '
        'colNameTrainer
        '
        Me.colNameTrainer.Text = "Name"
        Me.colNameTrainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colNameTrainer.Width = 356
        '
        'colVornameTrainer
        '
        Me.colVornameTrainer.Text = "Vorname"
        Me.colVornameTrainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVornameTrainer.Width = 369
        '
        'lstSchuelerAlle
        '
        Me.lstSchuelerAlle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSchuelerID, Me.colName, Me.colVorname})
        Me.lstSchuelerAlle.FullRowSelect = True
        Me.lstSchuelerAlle.GridLines = True
        Me.lstSchuelerAlle.HideSelection = False
        Me.lstSchuelerAlle.Location = New System.Drawing.Point(5, 9)
        Me.lstSchuelerAlle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstSchuelerAlle.MultiSelect = False
        Me.lstSchuelerAlle.Name = "lstSchuelerAlle"
        Me.lstSchuelerAlle.Size = New System.Drawing.Size(852, 754)
        Me.lstSchuelerAlle.TabIndex = 8
        Me.lstSchuelerAlle.UseCompatibleStateImageBehavior = False
        Me.lstSchuelerAlle.View = System.Windows.Forms.View.Details
        '
        'colSchuelerID
        '
        Me.colSchuelerID.Text = "Schüler ID"
        Me.colSchuelerID.Width = 126
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 356
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 369
        '
        'lstKurseAlle
        '
        Me.lstKurseAlle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursId, Me.colDatum, Me.colSportartKurs, Me.colVerfuegbarkeit})
        Me.lstKurseAlle.FullRowSelect = True
        Me.lstKurseAlle.GridLines = True
        Me.lstKurseAlle.HideSelection = False
        Me.lstKurseAlle.Location = New System.Drawing.Point(5, 9)
        Me.lstKurseAlle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstKurseAlle.MultiSelect = False
        Me.lstKurseAlle.Name = "lstKurseAlle"
        Me.lstKurseAlle.Size = New System.Drawing.Size(853, 754)
        Me.lstKurseAlle.TabIndex = 7
        Me.lstKurseAlle.UseCompatibleStateImageBehavior = False
        Me.lstKurseAlle.View = System.Windows.Forms.View.Details
        '
        'colKursId
        '
        Me.colKursId.Text = "Kurs ID"
        Me.colKursId.Width = 93
        '
        'colDatum
        '
        Me.colDatum.Text = "Datum"
        Me.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDatum.Width = 380
        '
        'colSportartKurs
        '
        Me.colSportartKurs.Text = "Sportart"
        Me.colSportartKurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSportartKurs.Width = 219
        '
        'colVerfuegbarkeit
        '
        Me.colVerfuegbarkeit.Text = "Verfügbarkeit"
        Me.colVerfuegbarkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVerfuegbarkeit.Width = 161
        '
        'frmHauptfensterMit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBeenden
        Me.ClientSize = New System.Drawing.Size(1253, 952)
        Me.Controls.Add(Me.grpboxSportartliste)
        Me.Controls.Add(Me.grpboxMenu)
        Me.Controls.Add(Me.btnBeenden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHauptfensterMit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kampfsportverein"
        Me.grpboxMenu.ResumeLayout(False)
        Me.grpboxSportartliste.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBeenden As Button
    Friend WithEvents grpboxMenu As GroupBox
    Friend WithEvents btnSportarten As Button
    Friend WithEvents btnMeinKonto As Button
    Friend WithEvents grpboxSportartliste As GroupBox
    Friend WithEvents lstSportart As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colSportart As ColumnHeader
    Friend WithEvents btnOeffnen As Button
    Friend WithEvents btnKurs As Button
    Friend WithEvents btnNeu As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents btnTrainer As Button
    Friend WithEvents btnSchueler As Button
    Friend WithEvents lstKurseAlle As ListView
    Friend WithEvents colKursId As ColumnHeader
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colSportartKurs As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents lstSchuelerAlle As ListView
    Friend WithEvents colSchuelerID As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents lstTrainer As ListView
    Friend WithEvents colTrainerID As ColumnHeader
    Friend WithEvents colNameTrainer As ColumnHeader
    Friend WithEvents colVornameTrainer As ColumnHeader
    Friend WithEvents btnNeuerMitarbeiter As Button
End Class
