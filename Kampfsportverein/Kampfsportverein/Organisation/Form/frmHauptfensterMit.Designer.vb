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
        Me.btnTrainer = New System.Windows.Forms.Button()
        Me.btnSchueler = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKurs = New System.Windows.Forms.Button()
        Me.picboxNeuerKurs = New System.Windows.Forms.PictureBox()
        Me.btnSportarten = New System.Windows.Forms.Button()
        Me.btnNeueSportart = New System.Windows.Forms.Button()
        Me.picboxNeuerTrainer = New System.Windows.Forms.PictureBox()
        Me.picboxNeueSportart = New System.Windows.Forms.PictureBox()
        Me.grpboxSportartliste = New System.Windows.Forms.GroupBox()
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.btnOeffnen = New System.Windows.Forms.Button()
        Me.lstSportart = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstKurseAlle = New System.Windows.Forms.ListView()
        Me.colKursId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportartKurs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstSchuelerAlle = New System.Windows.Forms.ListView()
        Me.colSchuelerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpboxMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNeuerKurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNeuerTrainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNeueSportart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSportartliste.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeenden
        '
        Me.btnBeenden.Location = New System.Drawing.Point(1106, 897)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(127, 44)
        Me.btnBeenden.TabIndex = 0
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'grpboxMenu
        '
        Me.grpboxMenu.Controls.Add(Me.btnTrainer)
        Me.grpboxMenu.Controls.Add(Me.btnSchueler)
        Me.grpboxMenu.Controls.Add(Me.PictureBox2)
        Me.grpboxMenu.Controls.Add(Me.PictureBox1)
        Me.grpboxMenu.Controls.Add(Me.btnKurs)
        Me.grpboxMenu.Controls.Add(Me.picboxNeuerKurs)
        Me.grpboxMenu.Controls.Add(Me.btnSportarten)
        Me.grpboxMenu.Controls.Add(Me.btnNeueSportart)
        Me.grpboxMenu.Controls.Add(Me.picboxNeuerTrainer)
        Me.grpboxMenu.Controls.Add(Me.picboxNeueSportart)
        Me.grpboxMenu.Location = New System.Drawing.Point(12, 12)
        Me.grpboxMenu.Name = "grpboxMenu"
        Me.grpboxMenu.Size = New System.Drawing.Size(347, 848)
        Me.grpboxMenu.TabIndex = 1
        Me.grpboxMenu.TabStop = False
        '
        'btnTrainer
        '
        Me.btnTrainer.Location = New System.Drawing.Point(164, 730)
        Me.btnTrainer.Name = "btnTrainer"
        Me.btnTrainer.Size = New System.Drawing.Size(145, 65)
        Me.btnTrainer.TabIndex = 9
        Me.btnTrainer.Text = "Trainer"
        Me.btnTrainer.UseVisualStyleBackColor = True
        '
        'btnSchueler
        '
        Me.btnSchueler.Location = New System.Drawing.Point(164, 554)
        Me.btnSchueler.Name = "btnSchueler"
        Me.btnSchueler.Size = New System.Drawing.Size(145, 65)
        Me.btnSchueler.TabIndex = 8
        Me.btnSchueler.Text = "Schüler"
        Me.btnSchueler.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(19, 706)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 110)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(19, 531)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 110)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnKurs
        '
        Me.btnKurs.Location = New System.Drawing.Point(164, 382)
        Me.btnKurs.Name = "btnKurs"
        Me.btnKurs.Size = New System.Drawing.Size(145, 65)
        Me.btnKurs.TabIndex = 5
        Me.btnKurs.Text = "Kurse"
        Me.btnKurs.UseVisualStyleBackColor = True
        '
        'picboxNeuerKurs
        '
        Me.picboxNeuerKurs.Location = New System.Drawing.Point(19, 361)
        Me.picboxNeuerKurs.Name = "picboxNeuerKurs"
        Me.picboxNeuerKurs.Size = New System.Drawing.Size(121, 110)
        Me.picboxNeuerKurs.TabIndex = 4
        Me.picboxNeuerKurs.TabStop = False
        '
        'btnSportarten
        '
        Me.btnSportarten.Location = New System.Drawing.Point(164, 215)
        Me.btnSportarten.Name = "btnSportarten"
        Me.btnSportarten.Size = New System.Drawing.Size(145, 65)
        Me.btnSportarten.TabIndex = 3
        Me.btnSportarten.Text = "Sportarten"
        Me.btnSportarten.UseVisualStyleBackColor = True
        '
        'btnNeueSportart
        '
        Me.btnNeueSportart.Location = New System.Drawing.Point(164, 57)
        Me.btnNeueSportart.Name = "btnNeueSportart"
        Me.btnNeueSportart.Size = New System.Drawing.Size(145, 65)
        Me.btnNeueSportart.TabIndex = 2
        Me.btnNeueSportart.Text = "Mein Konto"
        Me.btnNeueSportart.UseVisualStyleBackColor = True
        '
        'picboxNeuerTrainer
        '
        Me.picboxNeuerTrainer.Location = New System.Drawing.Point(19, 193)
        Me.picboxNeuerTrainer.Name = "picboxNeuerTrainer"
        Me.picboxNeuerTrainer.Size = New System.Drawing.Size(121, 110)
        Me.picboxNeuerTrainer.TabIndex = 1
        Me.picboxNeuerTrainer.TabStop = False
        '
        'picboxNeueSportart
        '
        Me.picboxNeueSportart.Location = New System.Drawing.Point(19, 30)
        Me.picboxNeueSportart.Name = "picboxNeueSportart"
        Me.picboxNeueSportart.Size = New System.Drawing.Size(121, 110)
        Me.picboxNeueSportart.TabIndex = 0
        Me.picboxNeueSportart.TabStop = False
        '
        'grpboxSportartliste
        '
        Me.grpboxSportartliste.Controls.Add(Me.lstSchuelerAlle)
        Me.grpboxSportartliste.Controls.Add(Me.lstKurseAlle)
        Me.grpboxSportartliste.Controls.Add(Me.btnNeu)
        Me.grpboxSportartliste.Controls.Add(Me.btnLoeschen)
        Me.grpboxSportartliste.Controls.Add(Me.btnOeffnen)
        Me.grpboxSportartliste.Controls.Add(Me.lstSportart)
        Me.grpboxSportartliste.Location = New System.Drawing.Point(376, 12)
        Me.grpboxSportartliste.Name = "grpboxSportartliste"
        Me.grpboxSportartliste.Size = New System.Drawing.Size(857, 848)
        Me.grpboxSportartliste.TabIndex = 2
        Me.grpboxSportartliste.TabStop = False
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(436, 784)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(127, 44)
        Me.btnNeu.TabIndex = 6
        Me.btnNeu.Text = "Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(580, 784)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(127, 44)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'btnOeffnen
        '
        Me.btnOeffnen.Location = New System.Drawing.Point(724, 784)
        Me.btnOeffnen.Name = "btnOeffnen"
        Me.btnOeffnen.Size = New System.Drawing.Size(127, 44)
        Me.btnOeffnen.TabIndex = 4
        Me.btnOeffnen.Text = "Öffnen"
        Me.btnOeffnen.UseVisualStyleBackColor = True
        '
        'lstSportart
        '
        Me.lstSportart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colSportart})
        Me.lstSportart.FullRowSelect = True
        Me.lstSportart.GridLines = True
        Me.lstSportart.HideSelection = False
        Me.lstSportart.Location = New System.Drawing.Point(0, 9)
        Me.lstSportart.MultiSelect = False
        Me.lstSportart.Name = "lstSportart"
        Me.lstSportart.Size = New System.Drawing.Size(857, 754)
        Me.lstSportart.TabIndex = 0
        Me.lstSportart.UseCompatibleStateImageBehavior = False
        Me.lstSportart.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 129
        '
        'colSportart
        '
        Me.colSportart.Text = "Sportart"
        Me.colSportart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSportart.Width = 721
        '
        'lstKurseAlle
        '
        Me.lstKurseAlle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursId, Me.colDatum, Me.colSportartKurs, Me.colVerfuegbarkeit})
        Me.lstKurseAlle.FullRowSelect = True
        Me.lstKurseAlle.GridLines = True
        Me.lstKurseAlle.HideSelection = False
        Me.lstKurseAlle.Location = New System.Drawing.Point(0, 9)
        Me.lstKurseAlle.MultiSelect = False
        Me.lstKurseAlle.Name = "lstKurseAlle"
        Me.lstKurseAlle.Size = New System.Drawing.Size(857, 754)
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
        'lstSchuelerAlle
        '
        Me.lstSchuelerAlle.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSchuelerID, Me.colName, Me.colVorname})
        Me.lstSchuelerAlle.FullRowSelect = True
        Me.lstSchuelerAlle.GridLines = True
        Me.lstSchuelerAlle.HideSelection = False
        Me.lstSchuelerAlle.Location = New System.Drawing.Point(0, 9)
        Me.lstSchuelerAlle.MultiSelect = False
        Me.lstSchuelerAlle.Name = "lstSchuelerAlle"
        Me.lstSchuelerAlle.Size = New System.Drawing.Size(857, 754)
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
        'frmHauptfensterMit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 953)
        Me.Controls.Add(Me.grpboxSportartliste)
        Me.Controls.Add(Me.grpboxMenu)
        Me.Controls.Add(Me.btnBeenden)
        Me.Name = "frmHauptfensterMit"
        Me.Text = "Kampfsportverein"
        Me.grpboxMenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNeuerKurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNeuerTrainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNeueSportart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSportartliste.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBeenden As Button
    Friend WithEvents grpboxMenu As GroupBox
    Friend WithEvents btnSportarten As Button
    Friend WithEvents btnNeueSportart As Button
    Friend WithEvents picboxNeuerTrainer As PictureBox
    Friend WithEvents picboxNeueSportart As PictureBox
    Friend WithEvents grpboxSportartliste As GroupBox
    Friend WithEvents lstSportart As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colSportart As ColumnHeader
    Friend WithEvents btnOeffnen As Button
    Friend WithEvents btnKurs As Button
    Friend WithEvents picboxNeuerKurs As PictureBox
    Friend WithEvents btnNeu As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents btnTrainer As Button
    Friend WithEvents btnSchueler As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstKurseAlle As ListView
    Friend WithEvents colKursId As ColumnHeader
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colSportartKurs As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents lstSchuelerAlle As ListView
    Friend WithEvents colSchuelerID As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
End Class
