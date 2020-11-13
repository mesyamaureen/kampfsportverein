<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAlleMitarbeiter
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
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnLoeschen = New System.Windows.Forms.Button()
        Me.lstAlleMitarbeiter = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBenutzername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(1113, 580)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(129, 37)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnLoeschen
        '
        Me.btnLoeschen.Location = New System.Drawing.Point(986, 580)
        Me.btnLoeschen.Name = "btnLoeschen"
        Me.btnLoeschen.Size = New System.Drawing.Size(119, 37)
        Me.btnLoeschen.TabIndex = 1
        Me.btnLoeschen.Text = "Löschen"
        Me.btnLoeschen.UseVisualStyleBackColor = True
        '
        'lstAlleMitarbeiter
        '
        Me.lstAlleMitarbeiter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colName, Me.colBenutzername})
        Me.lstAlleMitarbeiter.FullRowSelect = True
        Me.lstAlleMitarbeiter.GridLines = True
        Me.lstAlleMitarbeiter.HideSelection = False
        Me.lstAlleMitarbeiter.Location = New System.Drawing.Point(12, 12)
        Me.lstAlleMitarbeiter.MultiSelect = False
        Me.lstAlleMitarbeiter.Name = "lstAlleMitarbeiter"
        Me.lstAlleMitarbeiter.Size = New System.Drawing.Size(1230, 553)
        Me.lstAlleMitarbeiter.TabIndex = 2
        Me.lstAlleMitarbeiter.UseCompatibleStateImageBehavior = False
        Me.lstAlleMitarbeiter.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 163
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 377
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 319
        '
        'colBenutzername
        '
        Me.colBenutzername.Text = "Benutzername"
        Me.colBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colBenutzername.Width = 367
        '
        'dlgAlleMitarbeiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.lstAlleMitarbeiter)
        Me.Controls.Add(Me.btnLoeschen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgAlleMitarbeiter"
        Me.Text = "Alle Mitarbeiter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnLoeschen As Button
    Friend WithEvents lstAlleMitarbeiter As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colBenutzername As ColumnHeader
End Class
