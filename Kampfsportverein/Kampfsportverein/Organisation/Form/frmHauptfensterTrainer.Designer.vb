<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHauptfensterTrainer
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
        Me.btnBeenden = New System.Windows.Forms.Button()
        Me.grpboxMenu = New System.Windows.Forms.GroupBox()
        Me.btnSchueler = New System.Windows.Forms.Button()
        Me.btnKurse = New System.Windows.Forms.Button()
        Me.btnMeinKonto = New System.Windows.Forms.Button()
        Me.picboxNeueSchueler = New System.Windows.Forms.PictureBox()
        Me.picboxAlleSchueler = New System.Windows.Forms.PictureBox()
        Me.picboxMeinKonto = New System.Windows.Forms.PictureBox()
        Me.grpboxKurs = New System.Windows.Forms.GroupBox()
        Me.btnOeffnen = New System.Windows.Forms.Button()
        Me.lstKurse = New System.Windows.Forms.ListView()
        Me.colKursID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerfuegbarkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.grpboxMenu.SuspendLayout()
        CType(Me.picboxNeueSchueler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxAlleSchueler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxMeinKonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxKurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeenden
        '
        Me.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBeenden.Location = New System.Drawing.Point(1107, 901)
        Me.btnBeenden.Name = "btnBeenden"
        Me.btnBeenden.Size = New System.Drawing.Size(135, 40)
        Me.btnBeenden.TabIndex = 0
        Me.btnBeenden.Text = "Beenden"
        Me.btnBeenden.UseVisualStyleBackColor = True
        '
        'grpboxMenu
        '
        Me.grpboxMenu.Controls.Add(Me.btnSchueler)
        Me.grpboxMenu.Controls.Add(Me.btnKurse)
        Me.grpboxMenu.Controls.Add(Me.btnMeinKonto)
        Me.grpboxMenu.Controls.Add(Me.picboxNeueSchueler)
        Me.grpboxMenu.Controls.Add(Me.picboxAlleSchueler)
        Me.grpboxMenu.Controls.Add(Me.picboxMeinKonto)
        Me.grpboxMenu.Location = New System.Drawing.Point(12, 12)
        Me.grpboxMenu.Name = "grpboxMenu"
        Me.grpboxMenu.Size = New System.Drawing.Size(343, 856)
        Me.grpboxMenu.TabIndex = 1
        Me.grpboxMenu.TabStop = False
        '
        'btnSchueler
        '
        Me.btnSchueler.Location = New System.Drawing.Point(164, 692)
        Me.btnSchueler.Name = "btnSchueler"
        Me.btnSchueler.Size = New System.Drawing.Size(162, 50)
        Me.btnSchueler.TabIndex = 5
        Me.btnSchueler.Text = "Schüler"
        Me.btnSchueler.UseVisualStyleBackColor = True
        '
        'btnKurse
        '
        Me.btnKurse.Location = New System.Drawing.Point(164, 395)
        Me.btnKurse.Name = "btnKurse"
        Me.btnKurse.Size = New System.Drawing.Size(162, 50)
        Me.btnKurse.TabIndex = 4
        Me.btnKurse.Text = "Kurse"
        Me.btnKurse.UseVisualStyleBackColor = True
        '
        'btnMeinKonto
        '
        Me.btnMeinKonto.Location = New System.Drawing.Point(164, 123)
        Me.btnMeinKonto.Name = "btnMeinKonto"
        Me.btnMeinKonto.Size = New System.Drawing.Size(162, 50)
        Me.btnMeinKonto.TabIndex = 3
        Me.btnMeinKonto.Text = "Mein Konto"
        Me.btnMeinKonto.UseVisualStyleBackColor = True
        '
        'picboxNeueSchueler
        '
        Me.picboxNeueSchueler.Location = New System.Drawing.Point(27, 660)
        Me.picboxNeueSchueler.Name = "picboxNeueSchueler"
        Me.picboxNeueSchueler.Size = New System.Drawing.Size(112, 113)
        Me.picboxNeueSchueler.TabIndex = 2
        Me.picboxNeueSchueler.TabStop = False
        '
        'picboxAlleSchueler
        '
        Me.picboxAlleSchueler.Location = New System.Drawing.Point(27, 366)
        Me.picboxAlleSchueler.Name = "picboxAlleSchueler"
        Me.picboxAlleSchueler.Size = New System.Drawing.Size(112, 113)
        Me.picboxAlleSchueler.TabIndex = 1
        Me.picboxAlleSchueler.TabStop = False
        '
        'picboxMeinKonto
        '
        Me.picboxMeinKonto.Location = New System.Drawing.Point(27, 92)
        Me.picboxMeinKonto.Name = "picboxMeinKonto"
        Me.picboxMeinKonto.Size = New System.Drawing.Size(112, 113)
        Me.picboxMeinKonto.TabIndex = 0
        Me.picboxMeinKonto.TabStop = False
        '
        'grpboxKurs
        '
        Me.grpboxKurs.Controls.Add(Me.btnLoeschen)
        Me.grpboxKurs.Controls.Add(Me.btnNeu)
        Me.grpboxKurs.Controls.Add(Me.btnOeffnen)
        Me.grpboxKurs.Controls.Add(Me.lstKurse)
        Me.grpboxKurs.Location = New System.Drawing.Point(378, 12)
        Me.grpboxKurs.Name = "grpboxKurs"
        Me.grpboxKurs.Size = New System.Drawing.Size(864, 856)
        Me.grpboxKurs.TabIndex = 2
        Me.grpboxKurs.TabStop = False
        '
        'btnOeffnen
        '
        Me.btnOeffnen.Location = New System.Drawing.Point(723, 802)
        Me.btnOeffnen.Name = "btnOeffnen"
        Me.btnOeffnen.Size = New System.Drawing.Size(135, 40)
        Me.btnOeffnen.TabIndex = 3
        Me.btnOeffnen.Text = "Öffnen"
        Me.btnOeffnen.UseVisualStyleBackColor = True
        '
        'lstKurse
        '
        Me.lstKurse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKursID, Me.colDatum, Me.colSportart, Me.colVerfuegbarkeit})
        Me.lstKurse.FullRowSelect = True
        Me.lstKurse.GridLines = True
        Me.lstKurse.HideSelection = False
        Me.lstKurse.Location = New System.Drawing.Point(0, 15)
        Me.lstKurse.MultiSelect = False
        Me.lstKurse.Name = "lstKurse"
        Me.lstKurse.Size = New System.Drawing.Size(864, 779)
        Me.lstKurse.TabIndex = 0
        Me.lstKurse.UseCompatibleStateImageBehavior = False
        Me.lstKurse.View = System.Windows.Forms.View.Details
        '
        'colKursID
        '
        Me.colKursID.Text = "Kurs ID"
        Me.colKursID.Width = 105
        '
        'colDatum
        '
        Me.colDatum.Text = "Datum"
        Me.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDatum.Width = 371
        '
        'colSportart
        '
        Me.colSportart.Text = "Sportart"
        Me.colSportart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSportart.Width = 237
        '
        'colVerfuegbarkeit
        '
        Me.colVerfuegbarkeit.Text = "Verfügbarkeit"
        Me.colVerfuegbarkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVerfuegbarkeit.Width = 147
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(419, 802)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(135, 40)
        Me.btnNeu.TabIndex = 4
        Me.btnNeu.Text = "Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(571, 802)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(135, 40)
        Me.btnLoeschen.TabIndex = 5
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'frmHauptfensterTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBeenden
        Me.ClientSize = New System.Drawing.Size(1254, 953)
        Me.Controls.Add(Me.grpboxKurs)
        Me.Controls.Add(Me.grpboxMenu)
        Me.Controls.Add(Me.btnBeenden)
        Me.Name = "frmHauptfensterTrainer"
        Me.Text = "Kampfsportverein"
        Me.grpboxMenu.ResumeLayout(False)
        CType(Me.picboxNeueSchueler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxAlleSchueler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxMeinKonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxKurs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBeenden As Button
    Friend WithEvents grpboxMenu As GroupBox
    Friend WithEvents btnSchueler As Button
    Friend WithEvents btnKurse As Button
    Friend WithEvents btnMeinKonto As Button
    Friend WithEvents picboxNeueSchueler As PictureBox
    Friend WithEvents picboxAlleSchueler As PictureBox
    Friend WithEvents picboxMeinKonto As PictureBox
    Friend WithEvents grpboxKurs As GroupBox
    Friend WithEvents btnOeffnen As Button
    Friend WithEvents lstKurse As ListView
    Friend WithEvents colKursID As ColumnHeader
    Friend WithEvents colDatum As ColumnHeader
    Friend WithEvents colSportart As ColumnHeader
    Friend WithEvents colVerfuegbarkeit As ColumnHeader
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents btnNeu As Button
End Class
