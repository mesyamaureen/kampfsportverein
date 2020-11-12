<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAlleSchueler
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
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.lstAlleSchueler = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGebDat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnSchliessen
        '
        Me.btnSchliessen.Location = New System.Drawing.Point(1118, 577)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(124, 40)
        Me.btnSchliessen.TabIndex = 0
        Me.btnSchliessen.Text = "Schließen"
        Me.btnSchliessen.UseVisualStyleBackColor = True
        '
        'lstAlleSchueler
        '
        Me.lstAlleSchueler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colName, Me.colGebDat, Me.colEmail})
        Me.lstAlleSchueler.FullRowSelect = True
        Me.lstAlleSchueler.GridLines = True
        Me.lstAlleSchueler.HideSelection = False
        Me.lstAlleSchueler.Location = New System.Drawing.Point(12, 23)
        Me.lstAlleSchueler.MultiSelect = False
        Me.lstAlleSchueler.Name = "lstAlleSchueler"
        Me.lstAlleSchueler.Size = New System.Drawing.Size(1230, 538)
        Me.lstAlleSchueler.TabIndex = 1
        Me.lstAlleSchueler.UseCompatibleStateImageBehavior = False
        Me.lstAlleSchueler.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 89
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVorname.Width = 294
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colName.Width = 345
        '
        'colGebDat
        '
        Me.colGebDat.Text = "Geburtsdatum"
        Me.colGebDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colGebDat.Width = 209
        '
        'colEmail
        '
        Me.colEmail.Text = "E-Mail"
        Me.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colEmail.Width = 289
        '
        'dlgAlleSchueler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSchliessen
        Me.ClientSize = New System.Drawing.Size(1254, 629)
        Me.Controls.Add(Me.lstAlleSchueler)
        Me.Controls.Add(Me.btnSchliessen)
        Me.Name = "dlgAlleSchueler"
        Me.Text = "Alle Schüler"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSchliessen As Button
    Friend WithEvents lstAlleSchueler As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colVorname As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colGebDat As ColumnHeader
    Friend WithEvents colEmail As ColumnHeader
End Class
