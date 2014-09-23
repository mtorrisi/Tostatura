<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParametriDefault
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametriDefault))
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.ParametriTostaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParametriTostaturaTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
        Me.TableAdapterManager = New Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
        Me.ParametriTostaturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ParametriTostaturaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ParametriTostaturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametriTostaturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParametriTostaturaBindingNavigator.SuspendLayout()
        CType(Me.ParametriTostaturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TostaturaDataSet
        '
        Me.TostaturaDataSet.DataSetName = "TostaturaDataSet"
        Me.TostaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParametriTostaturaBindingSource
        '
        Me.ParametriTostaturaBindingSource.DataMember = "ParametriTostatura"
        Me.ParametriTostaturaBindingSource.DataSource = Me.TostaturaDataSet
        '
        'ParametriTostaturaTableAdapter
        '
        Me.ParametriTostaturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaGrezziTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficaProdottiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaTableAdapter = Me.ParametriTostaturaTableAdapter
        Me.TableAdapterManager.RuoliTableAdapter = Nothing
        Me.TableAdapterManager.StoricoAllarmiTableAdapter = Nothing
        Me.TableAdapterManager.StoricoInputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.StoricoOutputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLavorazioneTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParametriTostaturaBindingNavigator
        '
        Me.ParametriTostaturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ParametriTostaturaBindingNavigator.BindingSource = Me.ParametriTostaturaBindingSource
        Me.ParametriTostaturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParametriTostaturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParametriTostaturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ParametriTostaturaBindingNavigatorSaveItem})
        Me.ParametriTostaturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParametriTostaturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParametriTostaturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParametriTostaturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParametriTostaturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParametriTostaturaBindingNavigator.Name = "ParametriTostaturaBindingNavigator"
        Me.ParametriTostaturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParametriTostaturaBindingNavigator.Size = New System.Drawing.Size(782, 25)
        Me.ParametriTostaturaBindingNavigator.TabIndex = 0
        Me.ParametriTostaturaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ParametriTostaturaDataGridView
        '
        Me.ParametriTostaturaDataGridView.AutoGenerateColumns = False
        Me.ParametriTostaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParametriTostaturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ParametriTostaturaDataGridView.DataSource = Me.ParametriTostaturaBindingSource
        Me.ParametriTostaturaDataGridView.Location = New System.Drawing.Point(12, 80)
        Me.ParametriTostaturaDataGridView.Name = "ParametriTostaturaDataGridView"
        Me.ParametriTostaturaDataGridView.Size = New System.Drawing.Size(758, 308)
        Me.ParametriTostaturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "umidita_prodotto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "umidita_prodotto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "umidita_esterna"
        Me.DataGridViewTextBoxColumn3.HeaderText = "umidita_esterna"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "temperatura_forno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "temperatura_forno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tempo_cottura"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tempo_cottura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "quantita_carico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "quantita_carico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tipo_lavorazione"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tipo_lavorazione"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'ParametriTostaturaBindingNavigatorSaveItem
        '
        Me.ParametriTostaturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ParametriTostaturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParametriTostaturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParametriTostaturaBindingNavigatorSaveItem.Name = "ParametriTostaturaBindingNavigatorSaveItem"
        Me.ParametriTostaturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ParametriTostaturaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'FormParametriDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 480)
        Me.Controls.Add(Me.ParametriTostaturaDataGridView)
        Me.Controls.Add(Me.ParametriTostaturaBindingNavigator)
        Me.Name = "FormParametriDefault"
        Me.Text = "FormParametriDefault"
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametriTostaturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParametriTostaturaBindingNavigator.ResumeLayout(False)
        Me.ParametriTostaturaBindingNavigator.PerformLayout()
        CType(Me.ParametriTostaturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TostaturaDataSet As Tostatura.TostaturaDataSet
    Friend WithEvents ParametriTostaturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametriTostaturaTableAdapter As Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
    Friend WithEvents TableAdapterManager As Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParametriTostaturaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ParametriTostaturaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ParametriTostaturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
