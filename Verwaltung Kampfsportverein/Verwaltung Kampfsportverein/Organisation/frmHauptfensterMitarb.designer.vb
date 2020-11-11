<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHauptfensterMitarb
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
        Me.btnNeuerTrainer = New System.Windows.Forms.Button()
        Me.btnNeueSportart = New System.Windows.Forms.Button()
        Me.picboxNeuerTrainer = New System.Windows.Forms.PictureBox()
        Me.picboxNeueSportart = New System.Windows.Forms.PictureBox()
        Me.grpboxSportartliste = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstSportart = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSportart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMeinKonto = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlleTrainer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlleSchueler = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlleMitarbeiter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpboxMenu.SuspendLayout()
        CType(Me.picboxNeuerTrainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNeueSportart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSportartliste.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.grpboxMenu.Controls.Add(Me.btnNeuerTrainer)
        Me.grpboxMenu.Controls.Add(Me.btnNeueSportart)
        Me.grpboxMenu.Controls.Add(Me.picboxNeuerTrainer)
        Me.grpboxMenu.Controls.Add(Me.picboxNeueSportart)
        Me.grpboxMenu.Location = New System.Drawing.Point(12, 64)
        Me.grpboxMenu.Name = "grpboxMenu"
        Me.grpboxMenu.Size = New System.Drawing.Size(347, 796)
        Me.grpboxMenu.TabIndex = 1
        Me.grpboxMenu.TabStop = False
        '
        'btnNeuerTrainer
        '
        Me.btnNeuerTrainer.Location = New System.Drawing.Point(83, 621)
        Me.btnNeuerTrainer.Name = "btnNeuerTrainer"
        Me.btnNeuerTrainer.Size = New System.Drawing.Size(182, 43)
        Me.btnNeuerTrainer.TabIndex = 3
        Me.btnNeuerTrainer.Text = "Neuer Trainer"
        Me.btnNeuerTrainer.UseVisualStyleBackColor = True
        '
        'btnNeueSportart
        '
        Me.btnNeueSportart.Location = New System.Drawing.Point(83, 261)
        Me.btnNeueSportart.Name = "btnNeueSportart"
        Me.btnNeueSportart.Size = New System.Drawing.Size(182, 43)
        Me.btnNeueSportart.TabIndex = 2
        Me.btnNeueSportart.Text = "Neue Sportart"
        Me.btnNeueSportart.UseVisualStyleBackColor = True
        '
        'picboxNeuerTrainer
        '
        Me.picboxNeuerTrainer.Location = New System.Drawing.Point(83, 427)
        Me.picboxNeuerTrainer.Name = "picboxNeuerTrainer"
        Me.picboxNeuerTrainer.Size = New System.Drawing.Size(182, 161)
        Me.picboxNeuerTrainer.TabIndex = 1
        Me.picboxNeuerTrainer.TabStop = False
        '
        'picboxNeueSportart
        '
        Me.picboxNeueSportart.Location = New System.Drawing.Point(83, 67)
        Me.picboxNeueSportart.Name = "picboxNeueSportart"
        Me.picboxNeueSportart.Size = New System.Drawing.Size(182, 161)
        Me.picboxNeueSportart.TabIndex = 0
        Me.picboxNeueSportart.TabStop = False
        '
        'grpboxSportartliste
        '
        Me.grpboxSportartliste.Controls.Add(Me.Button3)
        Me.grpboxSportartliste.Controls.Add(Me.lstSportart)
        Me.grpboxSportartliste.Location = New System.Drawing.Point(376, 64)
        Me.grpboxSportartliste.Name = "grpboxSportartliste"
        Me.grpboxSportartliste.Size = New System.Drawing.Size(857, 796)
        Me.grpboxSportartliste.TabIndex = 2
        Me.grpboxSportartliste.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(724, 739)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Bearbeiten"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.lstSportart.Size = New System.Drawing.Size(857, 717)
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
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMeinKonto, Me.menuAlleTrainer, Me.menuAlleSchueler, Me.menuAlleMitarbeiter, Me.menuHilfe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1254, 40)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMeinKonto
        '
        Me.menuMeinKonto.Name = "menuMeinKonto"
        Me.menuMeinKonto.Size = New System.Drawing.Size(160, 36)
        Me.menuMeinKonto.Text = "Mein Konto"
        '
        'menuAlleTrainer
        '
        Me.menuAlleTrainer.Name = "menuAlleTrainer"
        Me.menuAlleTrainer.Size = New System.Drawing.Size(154, 36)
        Me.menuAlleTrainer.Text = "Alle Trainer"
        '
        'menuAlleSchueler
        '
        Me.menuAlleSchueler.Name = "menuAlleSchueler"
        Me.menuAlleSchueler.Size = New System.Drawing.Size(161, 36)
        Me.menuAlleSchueler.Text = "Alle Schüler"
        '
        'menuAlleMitarbeiter
        '
        Me.menuAlleMitarbeiter.Name = "menuAlleMitarbeiter"
        Me.menuAlleMitarbeiter.Size = New System.Drawing.Size(200, 36)
        Me.menuAlleMitarbeiter.Text = "Alle Mitarbeiter"
        '
        'menuHilfe
        '
        Me.menuHilfe.Name = "menuHilfe"
        Me.menuHilfe.Size = New System.Drawing.Size(85, 36)
        Me.menuHilfe.Text = "Hilfe"
        '
        'frmHauptfensterMit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 953)
        Me.Controls.Add(Me.grpboxSportartliste)
        Me.Controls.Add(Me.grpboxMenu)
        Me.Controls.Add(Me.btnBeenden)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHauptfensterMit"
        Me.Text = "Kampfsportverein"
        Me.grpboxMenu.ResumeLayout(False)
        CType(Me.picboxNeuerTrainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNeueSportart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSportartliste.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBeenden As Button
    Friend WithEvents grpboxMenu As GroupBox
    Friend WithEvents btnNeuerTrainer As Button
    Friend WithEvents btnNeueSportart As Button
    Friend WithEvents picboxNeuerTrainer As PictureBox
    Friend WithEvents picboxNeueSportart As PictureBox
    Friend WithEvents grpboxSportartliste As GroupBox
    Friend WithEvents lstSportart As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colSportart As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuMeinKonto As ToolStripMenuItem
    Friend WithEvents menuAlleTrainer As ToolStripMenuItem
    Friend WithEvents menuAlleSchueler As ToolStripMenuItem
    Friend WithEvents menuAlleMitarbeiter As ToolStripMenuItem
    Friend WithEvents menuHilfe As ToolStripMenuItem
    Friend WithEvents Button3 As Button
End Class
