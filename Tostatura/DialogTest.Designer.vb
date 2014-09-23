<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogTest))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.ParametriDeaultLavorazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParametriDeaultLavorazioneTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.ParametriDeaultLavorazioneTableAdapter
        Me.TableAdapterManager = New Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
        Me.ParametriDeaultLavorazioneDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ParametriDeaultLavorazioneBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametriDeaultLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametriDeaultLavorazioneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametriDeaultLavorazioneBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParametriDeaultLavorazioneBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(544, 458)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'TostaturaDataSet
        '
        Me.TostaturaDataSet.DataSetName = "TostaturaDataSet"
        Me.TostaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParametriDeaultLavorazioneBindingSource
        '
        Me.ParametriDeaultLavorazioneBindingSource.DataMember = "ParametriDeaultLavorazione"
        Me.ParametriDeaultLavorazioneBindingSource.DataSource = Me.TostaturaDataSet
        '
        'ParametriDeaultLavorazioneTableAdapter
        '
        Me.ParametriDeaultLavorazioneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaGrezziTableAdapter = Nothing
        Me.TableAdapterManager.AnagraficaProdottiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaDefaultTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.RuoliTableAdapter = Nothing
        Me.TableAdapterManager.StoricoAllarmiTableAdapter = Nothing
        Me.TableAdapterManager.StoricoInputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.StoricoOutputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLavorazioneTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParametriDeaultLavorazioneDataGridView
        '
        Me.ParametriDeaultLavorazioneDataGridView.AutoGenerateColumns = False
        Me.ParametriDeaultLavorazioneDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ParametriDeaultLavorazioneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParametriDeaultLavorazioneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ParametriDeaultLavorazioneDataGridView.DataSource = Me.ParametriDeaultLavorazioneBindingSource
        Me.ParametriDeaultLavorazioneDataGridView.Location = New System.Drawing.Point(12, 52)
        Me.ParametriDeaultLavorazioneDataGridView.Name = "ParametriDeaultLavorazioneDataGridView"
        Me.ParametriDeaultLavorazioneDataGridView.Size = New System.Drawing.Size(675, 387)
        Me.ParametriDeaultLavorazioneDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "umidita_prodotto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "% umidità prodotto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "umidita_esterna"
        Me.DataGridViewTextBoxColumn3.HeaderText = "% umidità esterna"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "temperatura_forno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Temperatura forno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tempo_cottura"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tempo di cottura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "quantita_carico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantità di carico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo lavorazione"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ParametriDeaultLavorazioneBindingNavigator
        '
        Me.ParametriDeaultLavorazioneBindingNavigator.AddNewItem = Nothing
        Me.ParametriDeaultLavorazioneBindingNavigator.BindingSource = Me.ParametriDeaultLavorazioneBindingSource
        Me.ParametriDeaultLavorazioneBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParametriDeaultLavorazioneBindingNavigator.DeleteItem = Nothing
        Me.ParametriDeaultLavorazioneBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ParametriDeaultLavorazioneBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParametriDeaultLavorazioneBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParametriDeaultLavorazioneBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParametriDeaultLavorazioneBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParametriDeaultLavorazioneBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParametriDeaultLavorazioneBindingNavigator.Name = "ParametriDeaultLavorazioneBindingNavigator"
        Me.ParametriDeaultLavorazioneBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParametriDeaultLavorazioneBindingNavigator.Size = New System.Drawing.Size(702, 25)
        Me.ParametriDeaultLavorazioneBindingNavigator.TabIndex = 1
        Me.ParametriDeaultLavorazioneBindingNavigator.Text = "BindingNavigator1"
        '
        'DialogTest
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(702, 499)
        Me.Controls.Add(Me.ParametriDeaultLavorazioneDataGridView)
        Me.Controls.Add(Me.ParametriDeaultLavorazioneBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogTest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogTest"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametriDeaultLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametriDeaultLavorazioneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametriDeaultLavorazioneBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParametriDeaultLavorazioneBindingNavigator.ResumeLayout(False)
        Me.ParametriDeaultLavorazioneBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TostaturaDataSet As Tostatura.TostaturaDataSet
    Friend WithEvents ParametriDeaultLavorazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametriDeaultLavorazioneTableAdapter As Tostatura.TostaturaDataSetTableAdapters.ParametriDeaultLavorazioneTableAdapter
    Friend WithEvents TableAdapterManager As Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParametriDeaultLavorazioneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ParametriDeaultLavorazioneBindingNavigator As System.Windows.Forms.BindingNavigator

End Class
