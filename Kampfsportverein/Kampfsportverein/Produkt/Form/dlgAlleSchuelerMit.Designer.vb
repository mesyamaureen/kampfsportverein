<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAlleSchuelerMit
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
        Me.lstAlleSchuelerMit = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGebDat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAlleSchuelerMit
        '
        Me.lstAlleSchuelerMit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colName, Me.colGebDat, Me.colEmail})
        Me.lstAlleSchuelerMit.FullRowSelect = True
        Me.lstAlleSchuelerMit.GridLines = True
        Me.lstAlleSchuelerMit.HideSelection = False
        Me.lstAlleSchuelerMit.Location = New System.Drawing.Point(12, 12)
        Me.lstAlleSchuelerMit.Name = "lstAlleSchuelerMit"
        Me.lstAlleSchuelerMit.Size = New System.Drawing.Size(1230, 547)
        Me.lstAlleSchuelerMit.TabIndex = 0
        Me.lstAlleSchuelerMit.UseCompatibleStateImageBehavior = False
        Me.lstAlleSchuelerMit.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 98
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 321
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 302
        '
        'colGebDat
        '
        Me.colGebDat.Text = "Geburtsdatum"
        Me.colGebDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colGebDat.Width = 234
        '
        'colEmail
        '
        Me.colEmail.Text = "E-Mail"
        Me.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colEmail.Width = 265
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(1115, 579)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(127, 38)
        Me.btnAbbrechen.TabIndex = 1
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(982, 579)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(127, 38)
        Me.btnLoeschen.TabIndex = 2
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'dlgAlleSchuelerMit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.lstAlleSchuelerMit)
        Me.Name = "dlgAlleSchuelerMit"
        Me.Text = "Alle Schüler"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAlleSchuelerMit As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colGebDat As ColumnHeader
    Friend WithEvents colEmail As ColumnHeader
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnLoeschen As Button
End Class
