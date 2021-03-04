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
        Me.rtxtZielgruppe = New System.Windows.Forms.RichTextBox()
        Me.tabKurs = New System.Windows.Forms.TabPage()
        Me.lstKurse = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colZeitpunkt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTrainer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchwierigkeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHerkunftsland = New System.Windows.Forms.TextBox()
        Me.txtMindestalter = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabSportart.SuspendLayout()
        Me.tabZielgruppe.SuspendLayout()
        Me.tabKurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1109, 571)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(132, 46)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(963, 571)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.lblHerkunftsland.Location = New System.Drawing.Point(12, 80)
        Me.lblHerkunftsland.Name = "lblHerkunftsland"
        Me.lblHerkunftsland.Size = New System.Drawing.Size(145, 25)
        Me.lblHerkunftsland.TabIndex = 3
        Me.lblHerkunftsland.Text = "Herkunftsland"
        '
        'lblMindestalter
        '
        Me.lblMindestalter.AutoSize = True
        Me.lblMindestalter.Location = New System.Drawing.Point(13, 121)
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
        Me.tabSportart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabSportart.Name = "tabSportart"
        Me.tabSportart.SelectedIndex = 0
        Me.tabSportart.Size = New System.Drawing.Size(1225, 326)
        Me.tabSportart.TabIndex = 5
        '
        'tabZielgruppe
        '
        Me.tabZielgruppe.Controls.Add(Me.rtxtZielgruppe)
        Me.tabZielgruppe.Location = New System.Drawing.Point(8, 39)
        Me.tabZielgruppe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabZielgruppe.Name = "tabZielgruppe"
        Me.tabZielgruppe.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabZielgruppe.Size = New System.Drawing.Size(1209, 279)
        Me.tabZielgruppe.TabIndex = 0
        Me.tabZielgruppe.Text = "Zielgruppe"
        Me.tabZielgruppe.UseVisualStyleBackColor = True
        '
        'rtxtZielgruppe
        '
        Me.rtxtZielgruppe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtZielgruppe.Location = New System.Drawing.Point(3, 2)
        Me.rtxtZielgruppe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtZielgruppe.Name = "rtxtZielgruppe"
        Me.rtxtZielgruppe.Size = New System.Drawing.Size(1203, 275)
        Me.rtxtZielgruppe.TabIndex = 0
        Me.rtxtZielgruppe.Text = ""
        '
        'tabKurs
        '
        Me.tabKurs.Controls.Add(Me.lstKurse)
        Me.tabKurs.Location = New System.Drawing.Point(8, 39)
        Me.tabKurs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabKurs.Name = "tabKurs"
        Me.tabKurs.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabKurs.Size = New System.Drawing.Size(1209, 279)
        Me.tabKurs.TabIndex = 1
        Me.tabKurs.Text = "Kurs"
        Me.tabKurs.UseVisualStyleBackColor = True
        '
        'lstKurse
        '
        Me.lstKurse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colZeitpunkt, Me.colOrt, Me.colTrainer, Me.colSchwierigkeit})
        Me.lstKurse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstKurse.FullRowSelect = True
        Me.lstKurse.GridLines = True
        Me.lstKurse.HideSelection = False
        Me.lstKurse.Location = New System.Drawing.Point(3, 2)
        Me.lstKurse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstKurse.MultiSelect = False
        Me.lstKurse.Name = "lstKurse"
        Me.lstKurse.Size = New System.Drawing.Size(1203, 275)
        Me.lstKurse.TabIndex = 0
        Me.lstKurse.UseCompatibleStateImageBehavior = False
        Me.lstKurse.View = System.Windows.Forms.View.Details
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
        Me.colOrt.Width = 236
        '
        'colTrainer
        '
        Me.colTrainer.Text = "Trainer"
        Me.colTrainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colTrainer.Width = 269
        '
        'colSchwierigkeit
        '
        Me.colSchwierigkeit.Text = "Schwierigkeitsgrad"
        Me.colSchwierigkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colSchwierigkeit.Width = 252
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(221, 20)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(1012, 42)
        Me.txtName.TabIndex = 6
        '
        'txtHerkunftsland
        '
        Me.txtHerkunftsland.Location = New System.Drawing.Point(221, 68)
        Me.txtHerkunftsland.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHerkunftsland.Multiline = True
        Me.txtHerkunftsland.Name = "txtHerkunftsland"
        Me.txtHerkunftsland.Size = New System.Drawing.Size(1012, 42)
        Me.txtHerkunftsland.TabIndex = 7
        '
        'txtMindestalter
        '
        Me.txtMindestalter.Location = New System.Drawing.Point(221, 115)
        Me.txtMindestalter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMindestalter.Multiline = True
        Me.txtMindestalter.Name = "txtMindestalter"
        Me.txtMindestalter.Size = New System.Drawing.Size(1012, 42)
        Me.txtMindestalter.TabIndex = 8
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(221, 162)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVersion.Multiline = True
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(1012, 42)
        Me.txtVersion.TabIndex = 10
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(13, 166)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(85, 25)
        Me.lblVersion.TabIndex = 11
        Me.lblVersion.Text = "Version"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(804, 569)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(132, 46)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dlgSportEinzel
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1253, 629)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtMindestalter)
        Me.Controls.Add(Me.txtHerkunftsland)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.tabSportart)
        Me.Controls.Add(Me.lblMindestalter)
        Me.Controls.Add(Me.lblHerkunftsland)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents lstKurse As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colZeitpunkt As ColumnHeader
    Friend WithEvents colOrt As ColumnHeader
    Friend WithEvents colTrainer As ColumnHeader
    Friend WithEvents colSchwierigkeit As ColumnHeader
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnClose As Button
End Class
