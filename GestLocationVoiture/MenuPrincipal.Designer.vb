<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOITUREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCATIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOITUREToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECONNECTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEDECONNECTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUITTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LouerUneVoitureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MARQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.LouerUneVoitureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VOITUREToolStripMenuItem, Me.CLIENTToolStripMenuItem, Me.QUITTERToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GestionToolStripMenuItem.Text = "Menu"
        '
        'VOITUREToolStripMenuItem
        '
        Me.VOITUREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTToolStripMenuItem1, Me.LOCATIONToolStripMenuItem1, Me.VOITUREToolStripMenuItem1, Me.MARQUEToolStripMenuItem})
        Me.VOITUREToolStripMenuItem.Name = "VOITUREToolStripMenuItem"
        Me.VOITUREToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VOITUREToolStripMenuItem.Text = "GESTION"
        '
        'CLIENTToolStripMenuItem1
        '
        Me.CLIENTToolStripMenuItem1.Name = "CLIENTToolStripMenuItem1"
        Me.CLIENTToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CLIENTToolStripMenuItem1.Text = "CLIENT"
        '
        'LOCATIONToolStripMenuItem1
        '
        Me.LOCATIONToolStripMenuItem1.Name = "LOCATIONToolStripMenuItem1"
        Me.LOCATIONToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LOCATIONToolStripMenuItem1.Text = "LOCATION"
        '
        'VOITUREToolStripMenuItem1
        '
        Me.VOITUREToolStripMenuItem1.Name = "VOITUREToolStripMenuItem1"
        Me.VOITUREToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VOITUREToolStripMenuItem1.Text = "VOITURE"
        '
        'CLIENTToolStripMenuItem
        '
        Me.CLIENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SECONNECTERToolStripMenuItem, Me.SEDECONNECTERToolStripMenuItem})
        Me.CLIENTToolStripMenuItem.Name = "CLIENTToolStripMenuItem"
        Me.CLIENTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CLIENTToolStripMenuItem.Text = "AUTH ADMIN"
        '
        'SECONNECTERToolStripMenuItem
        '
        Me.SECONNECTERToolStripMenuItem.Name = "SECONNECTERToolStripMenuItem"
        Me.SECONNECTERToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SECONNECTERToolStripMenuItem.Text = "SE CONNECTER"
        '
        'SEDECONNECTERToolStripMenuItem
        '
        Me.SEDECONNECTERToolStripMenuItem.Name = "SEDECONNECTERToolStripMenuItem"
        Me.SEDECONNECTERToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SEDECONNECTERToolStripMenuItem.Text = "SE DECONNECTER"
        '
        'QUITTERToolStripMenuItem
        '
        Me.QUITTERToolStripMenuItem.Name = "QUITTERToolStripMenuItem"
        Me.QUITTERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QUITTERToolStripMenuItem.Text = "QUITTER"
        '
        'LouerUneVoitureToolStripMenuItem
        '
        Me.LouerUneVoitureToolStripMenuItem.Name = "LouerUneVoitureToolStripMenuItem"
        Me.LouerUneVoitureToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.LouerUneVoitureToolStripMenuItem.Text = "Louer une voiture"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 319)
        Me.Panel1.TabIndex = 1
        '
        'MARQUEToolStripMenuItem
        '
        Me.MARQUEToolStripMenuItem.Name = "MARQUEToolStripMenuItem"
        Me.MARQUEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MARQUEToolStripMenuItem.Text = "MARQUE"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 313)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOITUREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LouerUneVoitureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CLIENTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOCATIONToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOITUREToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SECONNECTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEDECONNECTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUITTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MARQUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
