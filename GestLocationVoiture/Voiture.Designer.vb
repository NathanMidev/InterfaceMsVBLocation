<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voiture
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
        Me.components = New System.ComponentModel.Container()
        Dim ImmatriculationLabel As System.Windows.Forms.Label
        Dim Id_marqueLabel As System.Windows.Forms.Label
        Dim Prix_jourLabel As System.Windows.Forms.Label
        Dim StatutLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Voiture))
        Dim ModeleLabel1 As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdvoitureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImmatriculationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmarqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixjourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoitureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bdd_voitureDataSet = New GestLocationVoiture.bdd_voitureDataSet()
        Me.VoitureTableAdapter = New GestLocationVoiture.bdd_voitureDataSetTableAdapters.voitureTableAdapter()
        Me.TableAdapterManager = New GestLocationVoiture.bdd_voitureDataSetTableAdapters.TableAdapterManager()
        Me.ImmatriculationTextBox = New System.Windows.Forms.TextBox()
        Me.Prix_jourTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ModeleTextBox = New System.Windows.Forms.TextBox()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTableAdapter = New GestLocationVoiture.bdd_voitureDataSetTableAdapters.locationTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MarqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarqueTableAdapter = New GestLocationVoiture.bdd_voitureDataSetTableAdapters.marqueTableAdapter()
        ImmatriculationLabel = New System.Windows.Forms.Label()
        Id_marqueLabel = New System.Windows.Forms.Label()
        Prix_jourLabel = New System.Windows.Forms.Label()
        StatutLabel = New System.Windows.Forms.Label()
        ModeleLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoitureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bdd_voitureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImmatriculationLabel
        '
        ImmatriculationLabel.AutoSize = True
        ImmatriculationLabel.Location = New System.Drawing.Point(23, 61)
        ImmatriculationLabel.Name = "ImmatriculationLabel"
        ImmatriculationLabel.Size = New System.Drawing.Size(79, 13)
        ImmatriculationLabel.TabIndex = 3
        ImmatriculationLabel.Text = "immatriculation:"
        '
        'Id_marqueLabel
        '
        Id_marqueLabel.AutoSize = True
        Id_marqueLabel.Location = New System.Drawing.Point(23, 91)
        Id_marqueLabel.Name = "Id_marqueLabel"
        Id_marqueLabel.Size = New System.Drawing.Size(56, 13)
        Id_marqueLabel.TabIndex = 5
        Id_marqueLabel.Text = "id marque:"
        '
        'Prix_jourLabel
        '
        Prix_jourLabel.AutoSize = True
        Prix_jourLabel.Location = New System.Drawing.Point(23, 126)
        Prix_jourLabel.Name = "Prix_jourLabel"
        Prix_jourLabel.Size = New System.Drawing.Size(46, 13)
        Prix_jourLabel.TabIndex = 7
        Prix_jourLabel.Text = "prix jour:"
        '
        'StatutLabel
        '
        StatutLabel.AutoSize = True
        StatutLabel.Location = New System.Drawing.Point(264, 36)
        StatutLabel.Name = "StatutLabel"
        StatutLabel.Size = New System.Drawing.Size(36, 13)
        StatutLabel.TabIndex = 9
        StatutLabel.Text = "statut:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdvoitureDataGridViewTextBoxColumn, Me.ModeleDataGridViewTextBoxColumn, Me.ImmatriculationDataGridViewTextBoxColumn, Me.IdmarqueDataGridViewTextBoxColumn, Me.PrixjourDataGridViewTextBoxColumn, Me.StatutDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VoitureBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 145)
        Me.DataGridView1.TabIndex = 0
        '
        'IdvoitureDataGridViewTextBoxColumn
        '
        Me.IdvoitureDataGridViewTextBoxColumn.DataPropertyName = "id_voiture"
        Me.IdvoitureDataGridViewTextBoxColumn.HeaderText = "id_voiture"
        Me.IdvoitureDataGridViewTextBoxColumn.Name = "IdvoitureDataGridViewTextBoxColumn"
        Me.IdvoitureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeleDataGridViewTextBoxColumn
        '
        Me.ModeleDataGridViewTextBoxColumn.DataPropertyName = "modele"
        Me.ModeleDataGridViewTextBoxColumn.HeaderText = "modele"
        Me.ModeleDataGridViewTextBoxColumn.Name = "ModeleDataGridViewTextBoxColumn"
        '
        'ImmatriculationDataGridViewTextBoxColumn
        '
        Me.ImmatriculationDataGridViewTextBoxColumn.DataPropertyName = "immatriculation"
        Me.ImmatriculationDataGridViewTextBoxColumn.HeaderText = "immatriculation"
        Me.ImmatriculationDataGridViewTextBoxColumn.Name = "ImmatriculationDataGridViewTextBoxColumn"
        '
        'IdmarqueDataGridViewTextBoxColumn
        '
        Me.IdmarqueDataGridViewTextBoxColumn.DataPropertyName = "id_marque"
        Me.IdmarqueDataGridViewTextBoxColumn.HeaderText = "id_marque"
        Me.IdmarqueDataGridViewTextBoxColumn.Name = "IdmarqueDataGridViewTextBoxColumn"
        '
        'PrixjourDataGridViewTextBoxColumn
        '
        Me.PrixjourDataGridViewTextBoxColumn.DataPropertyName = "prix_jour"
        Me.PrixjourDataGridViewTextBoxColumn.HeaderText = "prix_jour"
        Me.PrixjourDataGridViewTextBoxColumn.Name = "PrixjourDataGridViewTextBoxColumn"
        '
        'StatutDataGridViewTextBoxColumn
        '
        Me.StatutDataGridViewTextBoxColumn.DataPropertyName = "statut"
        Me.StatutDataGridViewTextBoxColumn.HeaderText = "statut"
        Me.StatutDataGridViewTextBoxColumn.Name = "StatutDataGridViewTextBoxColumn"
        '
        'VoitureBindingSource
        '
        Me.VoitureBindingSource.DataMember = "voiture"
        Me.VoitureBindingSource.DataSource = Me.Bdd_voitureDataSet
        '
        'Bdd_voitureDataSet
        '
        Me.Bdd_voitureDataSet.DataSetName = "bdd_voitureDataSet"
        Me.Bdd_voitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VoitureTableAdapter
        '
        Me.VoitureTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.locationTableAdapter = Nothing
        Me.TableAdapterManager.marqueTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestLocationVoiture.bdd_voitureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.voitureTableAdapter = Me.VoitureTableAdapter
        '
        'ImmatriculationTextBox
        '
        Me.ImmatriculationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoitureBindingSource, "immatriculation", True))
        Me.ImmatriculationTextBox.Location = New System.Drawing.Point(117, 58)
        Me.ImmatriculationTextBox.Name = "ImmatriculationTextBox"
        Me.ImmatriculationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImmatriculationTextBox.TabIndex = 4
        '
        'Prix_jourTextBox
        '
        Me.Prix_jourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoitureBindingSource, "prix_jour", True))
        Me.Prix_jourTextBox.Location = New System.Drawing.Point(117, 123)
        Me.Prix_jourTextBox.Name = "Prix_jourTextBox"
        Me.Prix_jourTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Prix_jourTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "AJOUTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "SUPPRIMER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "MODIFIER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(ModeleLabel1)
        Me.Panel1.Controls.Add(Me.ModeleTextBox)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(StatutLabel)
        Me.Panel1.Controls.Add(Prix_jourLabel)
        Me.Panel1.Controls.Add(Me.ImmatriculationTextBox)
        Me.Panel1.Controls.Add(ImmatriculationLabel)
        Me.Panel1.Controls.Add(Id_marqueLabel)
        Me.Panel1.Controls.Add(Me.Prix_jourTextBox)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 362)
        Me.Panel1.TabIndex = 14
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(748, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VoitureBindingSource, "statut", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Très bon état", "Bon état", "Moyen", "Usée"})
        Me.ComboBox1.Location = New System.Drawing.Point(324, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ModeleLabel1
        '
        ModeleLabel1.AutoSize = True
        ModeleLabel1.Location = New System.Drawing.Point(23, 36)
        ModeleLabel1.Name = "ModeleLabel1"
        ModeleLabel1.Size = New System.Drawing.Size(44, 13)
        ModeleLabel1.TabIndex = 11
        ModeleLabel1.Text = "modele:"
        '
        'ModeleTextBox
        '
        Me.ModeleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoitureBindingSource, "modele", True))
        Me.ModeleTextBox.Location = New System.Drawing.Point(117, 33)
        Me.ModeleTextBox.Name = "ModeleTextBox"
        Me.ModeleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeleTextBox.TabIndex = 12
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "FK_location_voiture"
        Me.LocationBindingSource.DataSource = Me.VoitureBindingSource
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MarqueBindingSource, "id_marque", True))
        Me.ComboBox2.DataSource = Me.MarqueBindingSource
        Me.ComboBox2.DisplayMember = "id_marque"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(117, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        Me.ComboBox2.ValueMember = "id_marque"
        '
        'MarqueBindingSource
        '
        Me.MarqueBindingSource.DataMember = "marque"
        Me.MarqueBindingSource.DataSource = Me.Bdd_voitureDataSet
        '
        'MarqueTableAdapter
        '
        Me.MarqueTableAdapter.ClearBeforeFill = True
        '
        'Voiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 361)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Voiture"
        Me.Text = "GestVoiture"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoitureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bdd_voitureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bdd_voitureDataSet As GestLocationVoiture.bdd_voitureDataSet
    Friend WithEvents VoitureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VoitureTableAdapter As GestLocationVoiture.bdd_voitureDataSetTableAdapters.voitureTableAdapter
    Friend WithEvents TableAdapterManager As GestLocationVoiture.bdd_voitureDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdvoitureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImmatriculationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdmarqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixjourDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImmatriculationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prix_jourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModeleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As GestLocationVoiture.bdd_voitureDataSetTableAdapters.locationTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MarqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarqueTableAdapter As GestLocationVoiture.bdd_voitureDataSetTableAdapters.marqueTableAdapter
End Class
