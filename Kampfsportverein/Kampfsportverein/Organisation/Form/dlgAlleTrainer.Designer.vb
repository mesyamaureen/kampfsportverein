<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAlleTrainer
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
        Me.btnBearbeiten = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lstAlleTrainer = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBenutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGebDat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1109, 581)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(133, 36)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnBearbeiten
        '
        Me.btnBearbeiten.Location = New System.Drawing.Point(958, 581)
        Me.btnBearbeiten.Name = "btnBearbeiten"
        Me.btnBearbeiten.Size = New System.Drawing.Size(139, 36)
        Me.btnBearbeiten.TabIndex = 1
        Me.btnBearbeiten.Text = "Bearbeiten"
        Me.btnBearbeiten.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(823, 581)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(119, 36)
        Me.btnLoeschen.TabIndex = 2
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lstAlleTrainer
        '
        Me.lstAlleTrainer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colName, Me.colBenutzername, Me.colGebDat})
        Me.lstAlleTrainer.FullRowSelect = True
        Me.lstAlleTrainer.GridLines = True
        Me.lstAlleTrainer.HideSelection = False
        Me.lstAlleTrainer.Location = New System.Drawing.Point(12, 12)
        Me.lstAlleTrainer.MultiSelect = False
        Me.lstAlleTrainer.Name = "lstAlleTrainer"
        Me.lstAlleTrainer.Size = New System.Drawing.Size(1230, 552)
        Me.lstAlleTrainer.TabIndex = 3
        Me.lstAlleTrainer.UseCompatibleStateImageBehavior = False
        Me.lstAlleTrainer.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 93
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 329
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 286
        '
        'colBenutzername
        '
        Me.colBenutzername.Text = "Benutzername"
        Me.colBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colBenutzername.Width = 285
        '
        'colGebDat
        '
        Me.colGebDat.Text = "Geburtsdatum"
        Me.colGebDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colGebDat.Width = 229
        '
        'dlgAlleTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.lstAlleTrainer)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnBearbeiten)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgAlleTrainer"
        Me.Text = "Alle Trainer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnBearbeiten As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents lstAlleTrainer As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colBenutzername As ColumnHeader
    Friend WithEvents colGebDat As ColumnHeader
End Class
