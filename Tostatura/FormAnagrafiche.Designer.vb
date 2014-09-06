<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnagrafiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnagrafiche))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CategorieBTN = New System.Windows.Forms.Button
        Me.ProdottiBTN = New System.Windows.Forms.Button
        Me.ProdottiPNL = New System.Windows.Forms.Panel
        Me.idCategoriaTXT = New System.Windows.Forms.TextBox
        Me.AnagraficaProdottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.CalibroTXT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CategoriaCMB = New System.Windows.Forms.ComboBox
        Me.CategoriaProdottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.DescrizioneTXT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodiceTXT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.AnagraficaProdottiDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnagraficaProdottiTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.AnagraficaProdottiTableAdapter
        Me.TableAdapterManager = New Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
        Me.CategoriaProdottiTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.CategoriaProdottiTableAdapter
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AnagraficaProdottiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CategoriePNL = New System.Windows.Forms.Panel
        Me.DescrCategoriaTXT = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.IdTXT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ProdottiPNL.SuspendLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaProdottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaProdottiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        Me.CategoriePNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.CategorieBTN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProdottiBTN)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel2.Controls.Add(Me.CategoriePNL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProdottiPNL)
        Me.SplitContainer1.Size = New System.Drawing.Size(880, 578)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'CategorieBTN
        '
        Me.CategorieBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategorieBTN.Location = New System.Drawing.Point(12, 104)
        Me.CategorieBTN.Name = "CategorieBTN"
        Me.CategorieBTN.Size = New System.Drawing.Size(124, 46)
        Me.CategorieBTN.TabIndex = 1
        Me.CategorieBTN.Text = "Anagrafica Categorie"
        Me.CategorieBTN.UseVisualStyleBackColor = True
        '
        'ProdottiBTN
        '
        Me.ProdottiBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdottiBTN.Location = New System.Drawing.Point(12, 43)
        Me.ProdottiBTN.Name = "ProdottiBTN"
        Me.ProdottiBTN.Size = New System.Drawing.Size(124, 46)
        Me.ProdottiBTN.TabIndex = 0
        Me.ProdottiBTN.Text = "Anagrafica Prodotti"
        Me.ProdottiBTN.UseVisualStyleBackColor = True
        '
        'ProdottiPNL
        '
        Me.ProdottiPNL.Controls.Add(Me.idCategoriaTXT)
        Me.ProdottiPNL.Controls.Add(Me.CalibroTXT)
        Me.ProdottiPNL.Controls.Add(Me.Label4)
        Me.ProdottiPNL.Controls.Add(Me.CategoriaCMB)
        Me.ProdottiPNL.Controls.Add(Me.Label3)
        Me.ProdottiPNL.Controls.Add(Me.DescrizioneTXT)
        Me.ProdottiPNL.Controls.Add(Me.Label2)
        Me.ProdottiPNL.Controls.Add(Me.CodiceTXT)
        Me.ProdottiPNL.Controls.Add(Me.Label1)
        Me.ProdottiPNL.Controls.Add(Me.Label30)
        Me.ProdottiPNL.Controls.Add(Me.AnagraficaProdottiDataGridView)
        Me.ProdottiPNL.Location = New System.Drawing.Point(3, 26)
        Me.ProdottiPNL.Name = "ProdottiPNL"
        Me.ProdottiPNL.Size = New System.Drawing.Size(719, 545)
        Me.ProdottiPNL.TabIndex = 0
        '
        'idCategoriaTXT
        '
        Me.idCategoriaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "categoria", True))
        Me.idCategoriaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCategoriaTXT.Location = New System.Drawing.Point(88, 185)
        Me.idCategoriaTXT.Name = "idCategoriaTXT"
        Me.idCategoriaTXT.Size = New System.Drawing.Size(100, 22)
        Me.idCategoriaTXT.TabIndex = 36
        '
        'AnagraficaProdottiBindingSource
        '
        Me.AnagraficaProdottiBindingSource.DataMember = "AnagraficaProdotti"
        Me.AnagraficaProdottiBindingSource.DataSource = Me.TostaturaDataSet
        '
        'TostaturaDataSet
        '
        Me.TostaturaDataSet.DataSetName = "TostaturaDataSet"
        Me.TostaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalibroTXT
        '
        Me.CalibroTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "calibro", True))
        Me.CalibroTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalibroTXT.Location = New System.Drawing.Point(350, 143)
        Me.CalibroTXT.Name = "CalibroTXT"
        Me.CalibroTXT.Size = New System.Drawing.Size(100, 22)
        Me.CalibroTXT.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Calibro:"
        '
        'CategoriaCMB
        '
        Me.CategoriaCMB.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProdottiBindingSource, "id", True))
        Me.CategoriaCMB.DataSource = Me.CategoriaProdottiBindingSource
        Me.CategoriaCMB.DisplayMember = "descrizione"
        Me.CategoriaCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriaCMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaCMB.FormattingEnabled = True
        Me.CategoriaCMB.Location = New System.Drawing.Point(88, 141)
        Me.CategoriaCMB.Name = "CategoriaCMB"
        Me.CategoriaCMB.Size = New System.Drawing.Size(159, 24)
        Me.CategoriaCMB.TabIndex = 33
        Me.CategoriaCMB.ValueMember = "id"
        '
        'CategoriaProdottiBindingSource
        '
        Me.CategoriaProdottiBindingSource.DataMember = "CategoriaProdotti"
        Me.CategoriaProdottiBindingSource.DataSource = Me.TostaturaDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Categoria:"
        '
        'DescrizioneTXT
        '
        Me.DescrizioneTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "descrizione", True))
        Me.DescrizioneTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneTXT.Location = New System.Drawing.Point(350, 94)
        Me.DescrizioneTXT.Name = "DescrizioneTXT"
        Me.DescrizioneTXT.Size = New System.Drawing.Size(356, 22)
        Me.DescrizioneTXT.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descrizione:"
        '
        'CodiceTXT
        '
        Me.CodiceTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "codice", True))
        Me.CodiceTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceTXT.Location = New System.Drawing.Point(88, 94)
        Me.CodiceTXT.Name = "CodiceTXT"
        Me.CodiceTXT.Size = New System.Drawing.Size(159, 22)
        Me.CodiceTXT.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Codice:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label30.Location = New System.Drawing.Point(227, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(289, 37)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "Anagrafica prodotti"
        '
        'AnagraficaProdottiDataGridView
        '
        Me.AnagraficaProdottiDataGridView.AutoGenerateColumns = False
        Me.AnagraficaProdottiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AnagraficaProdottiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnagraficaProdottiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AnagraficaProdottiDataGridView.DataSource = Me.AnagraficaProdottiBindingSource
        Me.AnagraficaProdottiDataGridView.Location = New System.Drawing.Point(15, 251)
        Me.AnagraficaProdottiDataGridView.Name = "AnagraficaProdottiDataGridView"
        Me.AnagraficaProdottiDataGridView.ReadOnly = True
        Me.AnagraficaProdottiDataGridView.Size = New System.Drawing.Size(691, 287)
        Me.AnagraficaProdottiDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codice"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codice"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "calibro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calibro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'AnagraficaProdottiTableAdapter
        '
        Me.AnagraficaProdottiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaProdottiTableAdapter = Me.AnagraficaProdottiTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaProdottiTableAdapter = Me.CategoriaProdottiTableAdapter
        Me.TableAdapterManager.DistintaBaseTableAdapter = Nothing
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.RuoliTableAdapter = Nothing
        Me.TableAdapterManager.StoricoInputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.StoricoOpzioniTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLavorazioneTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriaProdottiTableAdapter
        '
        Me.CategoriaProdottiTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.AnagraficaProdottiBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficaProdottiBindingNavigatorSaveItem})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(880, 25)
        Me.BindingNavigator.TabIndex = 1
        Me.BindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
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
        'AnagraficaProdottiBindingNavigatorSaveItem
        '
        Me.AnagraficaProdottiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaProdottiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Name = "AnagraficaProdottiBindingNavigatorSaveItem"
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'CategoriePNL
        '
        Me.CategoriePNL.Controls.Add(Me.IdTXT)
        Me.CategoriePNL.Controls.Add(Me.Label5)
        Me.CategoriePNL.Controls.Add(Me.DescrCategoriaTXT)
        Me.CategoriePNL.Controls.Add(Me.Label7)
        Me.CategoriePNL.Controls.Add(Me.Label9)
        Me.CategoriePNL.Location = New System.Drawing.Point(3, 23)
        Me.CategoriePNL.Name = "CategoriePNL"
        Me.CategoriePNL.Size = New System.Drawing.Size(719, 545)
        Me.CategoriePNL.TabIndex = 37
        Me.CategoriePNL.Visible = False
        '
        'DescrCategoriaTXT
        '
        Me.DescrCategoriaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaProdottiBindingSource, "descrizione", True))
        Me.DescrCategoriaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrCategoriaTXT.Location = New System.Drawing.Point(103, 125)
        Me.DescrCategoriaTXT.Name = "DescrCategoriaTXT"
        Me.DescrCategoriaTXT.Size = New System.Drawing.Size(556, 22)
        Me.DescrCategoriaTXT.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Descrizione:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(204, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(312, 37)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Anagrafica categorie"
        '
        'IdTXT
        '
        Me.IdTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaProdottiBindingSource, "id", True))
        Me.IdTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTXT.Location = New System.Drawing.Point(103, 93)
        Me.IdTXT.Name = "IdTXT"
        Me.IdTXT.ReadOnly = True
        Me.IdTXT.Size = New System.Drawing.Size(99, 22)
        Me.IdTXT.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "id:"
        '
        'FormAnagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 578)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormAnagrafiche"
        Me.Text = "Gestione Anagrafiche"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ProdottiPNL.ResumeLayout(False)
        Me.ProdottiPNL.PerformLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaProdottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaProdottiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        Me.CategoriePNL.ResumeLayout(False)
        Me.CategoriePNL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CategorieBTN As System.Windows.Forms.Button
    Friend WithEvents ProdottiBTN As System.Windows.Forms.Button
    Friend WithEvents TostaturaDataSet As Tostatura.TostaturaDataSet
    Friend WithEvents AnagraficaProdottiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficaProdottiTableAdapter As Tostatura.TostaturaDataSetTableAdapters.AnagraficaProdottiTableAdapter
    Friend WithEvents TableAdapterManager As Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AnagraficaProdottiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoriaProdottiTableAdapter As Tostatura.TostaturaDataSetTableAdapters.CategoriaProdottiTableAdapter
    Friend WithEvents CategoriaProdottiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdottiPNL As System.Windows.Forms.Panel
    Friend WithEvents idCategoriaTXT As System.Windows.Forms.TextBox
    Friend WithEvents CalibroTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CategoriaCMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DescrizioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodiceTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents AnagraficaProdottiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriePNL As System.Windows.Forms.Panel
    Friend WithEvents DescrCategoriaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IdTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
