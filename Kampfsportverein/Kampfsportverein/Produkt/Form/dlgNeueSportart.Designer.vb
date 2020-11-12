<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNeueSportart
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
        Me.btnErstellen = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHerkunftsland = New System.Windows.Forms.Label()
        Me.lblZielgruppe = New System.Windows.Forms.Label()
        Me.lblMindestalter = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(634, 476)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(128, 41)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnErstellen
        '
        Me.btnErstellen.Location = New System.Drawing.Point(492, 476)
        Me.btnErstellen.Name = "btnErstellen"
        Me.btnErstellen.Size = New System.Drawing.Size(128, 41)
        Me.btnErstellen.TabIndex = 1
        Me.btnErstellen.Text = "Erstellen"
        Me.btnErstellen.UseVisualStyleBackColor = True
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
        Me.lblHerkunftsland.Location = New System.Drawing.Point(12, 112)
        Me.lblHerkunftsland.Name = "lblHerkunftsland"
        Me.lblHerkunftsland.Size = New System.Drawing.Size(145, 25)
        Me.lblHerkunftsland.TabIndex = 3
        Me.lblHerkunftsland.Text = "Herkunftsland"
        '
        'lblZielgruppe
        '
        Me.lblZielgruppe.AutoSize = True
        Me.lblZielgruppe.Location = New System.Drawing.Point(12, 193)
        Me.lblZielgruppe.Name = "lblZielgruppe"
        Me.lblZielgruppe.Size = New System.Drawing.Size(114, 25)
        Me.lblZielgruppe.TabIndex = 4
        Me.lblZielgruppe.Text = "Zielgruppe"
        '
        'lblMindestalter
        '
        Me.lblMindestalter.AutoSize = True
        Me.lblMindestalter.Location = New System.Drawing.Point(12, 403)
        Me.lblMindestalter.Name = "lblMindestalter"
        Me.lblMindestalter.Size = New System.Drawing.Size(130, 25)
        Me.lblMindestalter.TabIndex = 5
        Me.lblMindestalter.Text = "Mindestalter"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(562, 49)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 103)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(562, 49)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(200, 191)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(562, 175)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(200, 390)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(562, 49)
        Me.TextBox4.TabIndex = 9
        '
        'dlgNeueSportart
        '
        Me.AcceptButton = Me.btnErstellen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(774, 529)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblMindestalter)
        Me.Controls.Add(Me.lblZielgruppe)
        Me.Controls.Add(Me.lblHerkunftsland)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnErstellen)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "dlgNeueSportart"
        Me.Text = "Neue Sportart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents btnErstellen As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblHerkunftsland As Label
    Friend WithEvents lblZielgruppe As Label
    Friend WithEvents lblMindestalter As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
