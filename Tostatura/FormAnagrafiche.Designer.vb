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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnagrafiche))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CtlAvanzatiGPB = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.OperatoriBTN = New System.Windows.Forms.Button
        Me.FinitiBTN = New System.Windows.Forms.Button
        Me.ProdottiBTN = New System.Windows.Forms.Button
        Me.ProdottiFinitiPNL = New System.Windows.Forms.Panel
        Me.CodiceGrezzoTXT = New System.Windows.Forms.TextBox
        Me.AnagraficaProdottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.DescrizioneGrezzoCMB = New System.Windows.Forms.ComboBox
        Me.AnagraficaGrezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label18 = New System.Windows.Forms.Label
        Me.CalibroFinitoTXT = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdParametriTXT = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.IdTipoLavorazioneTXT = New System.Windows.Forms.TextBox
        Me.ParametriTostaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoLavorazioneCMB = New System.Windows.Forms.ComboBox
        Me.TipoLavorazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.QuantitaCaricoTXT = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TempoCotturaTXT = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TemperaturaFornoTXT = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.UmiditaEsternaTXT = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.UmiditaProdottoTXT = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CategoriaFinitoTXT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DescrizioneFinitoTXT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CodiceFinitoTXT = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ProdottiGrezziPNL = New System.Windows.Forms.Panel
        Me.AnagraficaGrezziDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoriaTXT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DescrizioneTXT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodiceTXT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.PnlDataMemory = New System.Windows.Forms.Panel
        Me.tipoOperazioneTXT = New System.Windows.Forms.TextBox
        Me.BilanciaCollegataCMB = New System.Windows.Forms.ComboBox
        Me.BilanciaCollegataCHB = New System.Windows.Forms.CheckBox
        Me.DescrDataMemoryTXT = New System.Windows.Forms.TextBox
        Me.indirizzoDataMemoryTXT = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.LetturaRBT = New System.Windows.Forms.RadioButton
        Me.ScritturaRBT = New System.Windows.Forms.RadioButton
        Me.Label79 = New System.Windows.Forms.Label
        Me.CodDataMemoryTXT = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.AnagraficaDataMemoryDataGridView = New System.Windows.Forms.DataGridView
        Me.Label81 = New System.Windows.Forms.Label
        Me.CodBilanciaCollegataTXT = New System.Windows.Forms.TextBox
        Me.PnlOperatori = New System.Windows.Forms.Panel
        Me.PswCHB = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.PaswOperatoreTXT = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.nomeOperatoreTXT = New System.Windows.Forms.TextBox
        Me.codoperatoreTXT = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.RuoliCmb = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.ruoloSelectedTXT = New System.Windows.Forms.TextBox
        Me.IdTXT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DescrCategoriaTXT = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.AnagraficaProdottiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BNUpdateButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.BNCodiceTXT = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.BNDescrizoneTXT = New System.Windows.Forms.ToolStripTextBox
        Me.AnagraficaProdottiTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.AnagraficaProdottiTableAdapter
        Me.TableAdapterManager = New Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
        Me.AnagraficaGrezziTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.AnagraficaGrezziTableAdapter
        Me.ParametriTostaturaTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
        Me.TipoLavorazioneTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.TipoLavorazioneTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.CtlAvanzatiGPB.SuspendLayout()
        Me.ProdottiFinitiPNL.SuspendLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnagraficaGrezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdottiGrezziPNL.SuspendLayout()
        CType(Me.AnagraficaGrezziDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDataMemory.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.AnagraficaDataMemoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOperatori.SuspendLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.CtlAvanzatiGPB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FinitiBTN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProdottiBTN)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProdottiFinitiPNL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProdottiGrezziPNL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PnlDataMemory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PnlOperatori)
        Me.SplitContainer1.Size = New System.Drawing.Size(892, 596)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'CtlAvanzatiGPB
        '
        Me.CtlAvanzatiGPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtlAvanzatiGPB.Controls.Add(Me.Button8)
        Me.CtlAvanzatiGPB.Controls.Add(Me.Button5)
        Me.CtlAvanzatiGPB.Controls.Add(Me.OperatoriBTN)
        Me.CtlAvanzatiGPB.Location = New System.Drawing.Point(3, 298)
        Me.CtlAvanzatiGPB.Name = "CtlAvanzatiGPB"
        Me.CtlAvanzatiGPB.Size = New System.Drawing.Size(138, 279)
        Me.CtlAvanzatiGPB.TabIndex = 20
        Me.CtlAvanzatiGPB.TabStop = False
        Me.CtlAvanzatiGPB.Text = "Controlli Avanzati"
        Me.CtlAvanzatiGPB.Visible = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(0, 101)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(135, 47)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Anagrafica Data Memory"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 31)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Anagrafica PLC:"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OperatoriBTN
        '
        Me.OperatoriBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OperatoriBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatoriBTN.Location = New System.Drawing.Point(0, 18)
        Me.OperatoriBTN.Name = "OperatoriBTN"
        Me.OperatoriBTN.Size = New System.Drawing.Size(135, 40)
        Me.OperatoriBTN.TabIndex = 2
        Me.OperatoriBTN.Text = "Anagrafica Operatori"
        Me.OperatoriBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.OperatoriBTN.UseVisualStyleBackColor = True
        '
        'FinitiBTN
        '
        Me.FinitiBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinitiBTN.Location = New System.Drawing.Point(12, 104)
        Me.FinitiBTN.Name = "FinitiBTN"
        Me.FinitiBTN.Size = New System.Drawing.Size(124, 46)
        Me.FinitiBTN.TabIndex = 1
        Me.FinitiBTN.Text = "Anagrafica Finiti"
        Me.FinitiBTN.UseVisualStyleBackColor = True
        '
        'ProdottiBTN
        '
        Me.ProdottiBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdottiBTN.Location = New System.Drawing.Point(12, 43)
        Me.ProdottiBTN.Name = "ProdottiBTN"
        Me.ProdottiBTN.Size = New System.Drawing.Size(124, 46)
        Me.ProdottiBTN.TabIndex = 0
        Me.ProdottiBTN.Text = "Anagrafica Grezzi"
        Me.ProdottiBTN.UseVisualStyleBackColor = True
        '
        'ProdottiFinitiPNL
        '
        Me.ProdottiFinitiPNL.Controls.Add(Me.CodiceGrezzoTXT)
        Me.ProdottiFinitiPNL.Controls.Add(Me.DescrizioneGrezzoCMB)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label18)
        Me.ProdottiFinitiPNL.Controls.Add(Me.CalibroFinitoTXT)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label17)
        Me.ProdottiFinitiPNL.Controls.Add(Me.GroupBox1)
        Me.ProdottiFinitiPNL.Controls.Add(Me.CategoriaFinitoTXT)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label4)
        Me.ProdottiFinitiPNL.Controls.Add(Me.DescrizioneFinitoTXT)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label6)
        Me.ProdottiFinitiPNL.Controls.Add(Me.CodiceFinitoTXT)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label8)
        Me.ProdottiFinitiPNL.Controls.Add(Me.Label10)
        Me.ProdottiFinitiPNL.Location = New System.Drawing.Point(3, 26)
        Me.ProdottiFinitiPNL.Name = "ProdottiFinitiPNL"
        Me.ProdottiFinitiPNL.Size = New System.Drawing.Size(722, 552)
        Me.ProdottiFinitiPNL.TabIndex = 0
        Me.ProdottiFinitiPNL.Visible = False
        '
        'CodiceGrezzoTXT
        '
        Me.CodiceGrezzoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "codice_grezzo", True))
        Me.CodiceGrezzoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceGrezzoTXT.Location = New System.Drawing.Point(494, 165)
        Me.CodiceGrezzoTXT.Name = "CodiceGrezzoTXT"
        Me.CodiceGrezzoTXT.Size = New System.Drawing.Size(67, 22)
        Me.CodiceGrezzoTXT.TabIndex = 57
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
        'DescrizioneGrezzoCMB
        '
        Me.DescrizioneGrezzoCMB.DataSource = Me.AnagraficaGrezziBindingSource
        Me.DescrizioneGrezzoCMB.DisplayMember = "descrizione"
        Me.DescrizioneGrezzoCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescrizioneGrezzoCMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneGrezzoCMB.FormattingEnabled = True
        Me.DescrizioneGrezzoCMB.Location = New System.Drawing.Point(492, 135)
        Me.DescrizioneGrezzoCMB.Name = "DescrizioneGrezzoCMB"
        Me.DescrizioneGrezzoCMB.Size = New System.Drawing.Size(214, 24)
        Me.DescrizioneGrezzoCMB.TabIndex = 55
        Me.DescrizioneGrezzoCMB.ValueMember = "codice"
        '
        'AnagraficaGrezziBindingSource
        '
        Me.AnagraficaGrezziBindingSource.DataMember = "AnagraficaGrezzi"
        Me.AnagraficaGrezziBindingSource.DataSource = Me.TostaturaDataSet
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(381, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 16)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Prodotto grezzo:"
        '
        'CalibroFinitoTXT
        '
        Me.CalibroFinitoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "calibro", True))
        Me.CalibroFinitoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalibroFinitoTXT.Location = New System.Drawing.Point(291, 135)
        Me.CalibroFinitoTXT.Name = "CalibroFinitoTXT"
        Me.CalibroFinitoTXT.Size = New System.Drawing.Size(79, 22)
        Me.CalibroFinitoTXT.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(203, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Calibro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdParametriTXT)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.IdTipoLavorazioneTXT)
        Me.GroupBox1.Controls.Add(Me.TipoLavorazioneCMB)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.QuantitaCaricoTXT)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TempoCotturaTXT)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TemperaturaFornoTXT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.UmiditaEsternaTXT)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.UmiditaProdottoTXT)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 320)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametri di Tostatura"
        '
        'IdParametriTXT
        '
        Me.IdParametriTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "id_parametri", True))
        Me.IdParametriTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdParametriTXT.Location = New System.Drawing.Point(290, 19)
        Me.IdParametriTXT.Name = "IdParametriTXT"
        Me.IdParametriTXT.Size = New System.Drawing.Size(67, 22)
        Me.IdParametriTXT.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 58)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Seleziona Parametri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdTipoLavorazioneTXT
        '
        Me.IdTipoLavorazioneTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "tipo_lavorazione", True))
        Me.IdTipoLavorazioneTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTipoLavorazioneTXT.Location = New System.Drawing.Point(290, 162)
        Me.IdTipoLavorazioneTXT.Name = "IdTipoLavorazioneTXT"
        Me.IdTipoLavorazioneTXT.Size = New System.Drawing.Size(67, 22)
        Me.IdTipoLavorazioneTXT.TabIndex = 56
        '
        'ParametriTostaturaBindingSource
        '
        Me.ParametriTostaturaBindingSource.DataMember = "ParametriTostatura"
        Me.ParametriTostaturaBindingSource.DataSource = Me.TostaturaDataSet
        '
        'TipoLavorazioneCMB
        '
        Me.TipoLavorazioneCMB.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TipoLavorazioneBindingSource, "id", True))
        Me.TipoLavorazioneCMB.DataSource = Me.TipoLavorazioneBindingSource
        Me.TipoLavorazioneCMB.DisplayMember = "descrizione"
        Me.TipoLavorazioneCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoLavorazioneCMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoLavorazioneCMB.FormattingEnabled = True
        Me.TipoLavorazioneCMB.Location = New System.Drawing.Point(147, 160)
        Me.TipoLavorazioneCMB.Name = "TipoLavorazioneCMB"
        Me.TipoLavorazioneCMB.Size = New System.Drawing.Size(137, 24)
        Me.TipoLavorazioneCMB.TabIndex = 53
        Me.TipoLavorazioneCMB.ValueMember = "id"
        '
        'TipoLavorazioneBindingSource
        '
        Me.TipoLavorazioneBindingSource.DataMember = "TipoLavorazione"
        Me.TipoLavorazioneBindingSource.DataSource = Me.TostaturaDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Tipo lavorazione:"
        '
        'QuantitaCaricoTXT
        '
        Me.QuantitaCaricoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "quantita_carico", True))
        Me.QuantitaCaricoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantitaCaricoTXT.Location = New System.Drawing.Point(147, 132)
        Me.QuantitaCaricoTXT.Name = "QuantitaCaricoTXT"
        Me.QuantitaCaricoTXT.Size = New System.Drawing.Size(137, 22)
        Me.QuantitaCaricoTXT.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 16)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Quantità di carico:"
        '
        'TempoCotturaTXT
        '
        Me.TempoCotturaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "tempo_cottura", True))
        Me.TempoCotturaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempoCotturaTXT.Location = New System.Drawing.Point(147, 104)
        Me.TempoCotturaTXT.Name = "TempoCotturaTXT"
        Me.TempoCotturaTXT.Size = New System.Drawing.Size(137, 22)
        Me.TempoCotturaTXT.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Tempo di cottura:"
        '
        'TemperaturaFornoTXT
        '
        Me.TemperaturaFornoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "temperatura_forno", True))
        Me.TemperaturaFornoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperaturaFornoTXT.Location = New System.Drawing.Point(147, 75)
        Me.TemperaturaFornoTXT.Name = "TemperaturaFornoTXT"
        Me.TemperaturaFornoTXT.Size = New System.Drawing.Size(137, 22)
        Me.TemperaturaFornoTXT.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 16)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Temperatura forno:"
        '
        'UmiditaEsternaTXT
        '
        Me.UmiditaEsternaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "umidita_esterna", True))
        Me.UmiditaEsternaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UmiditaEsternaTXT.Location = New System.Drawing.Point(147, 47)
        Me.UmiditaEsternaTXT.Name = "UmiditaEsternaTXT"
        Me.UmiditaEsternaTXT.Size = New System.Drawing.Size(137, 22)
        Me.UmiditaEsternaTXT.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "% umidità esterno:"
        '
        'UmiditaProdottoTXT
        '
        Me.UmiditaProdottoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "umidita_prodotto", True))
        Me.UmiditaProdottoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UmiditaProdottoTXT.Location = New System.Drawing.Point(147, 19)
        Me.UmiditaProdottoTXT.Name = "UmiditaProdottoTXT"
        Me.UmiditaProdottoTXT.Size = New System.Drawing.Size(137, 22)
        Me.UmiditaProdottoTXT.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "% umidità prodotto:"
        '
        'CategoriaFinitoTXT
        '
        Me.CategoriaFinitoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "categoria", True))
        Me.CategoriaFinitoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaFinitoTXT.Location = New System.Drawing.Point(91, 135)
        Me.CategoriaFinitoTXT.Name = "CategoriaFinitoTXT"
        Me.CategoriaFinitoTXT.Size = New System.Drawing.Size(102, 22)
        Me.CategoriaFinitoTXT.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Categoria:"
        '
        'DescrizioneFinitoTXT
        '
        Me.DescrizioneFinitoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "descrizione", True))
        Me.DescrizioneFinitoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneFinitoTXT.Location = New System.Drawing.Point(291, 88)
        Me.DescrizioneFinitoTXT.MaxLength = 50
        Me.DescrizioneFinitoTXT.Name = "DescrizioneFinitoTXT"
        Me.DescrizioneFinitoTXT.Size = New System.Drawing.Size(417, 22)
        Me.DescrizioneFinitoTXT.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Descrizione:"
        '
        'CodiceFinitoTXT
        '
        Me.CodiceFinitoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "codice", True))
        Me.CodiceFinitoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceFinitoTXT.Location = New System.Drawing.Point(91, 88)
        Me.CodiceFinitoTXT.Name = "CodiceFinitoTXT"
        Me.CodiceFinitoTXT.ReadOnly = True
        Me.CodiceFinitoTXT.Size = New System.Drawing.Size(102, 22)
        Me.CodiceFinitoTXT.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Codice:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(204, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(355, 37)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Anagrafica prodotti finiti"
        '
        'ProdottiGrezziPNL
        '
        Me.ProdottiGrezziPNL.Controls.Add(Me.AnagraficaGrezziDataGridView)
        Me.ProdottiGrezziPNL.Controls.Add(Me.CategoriaTXT)
        Me.ProdottiGrezziPNL.Controls.Add(Me.Label3)
        Me.ProdottiGrezziPNL.Controls.Add(Me.DescrizioneTXT)
        Me.ProdottiGrezziPNL.Controls.Add(Me.Label2)
        Me.ProdottiGrezziPNL.Controls.Add(Me.CodiceTXT)
        Me.ProdottiGrezziPNL.Controls.Add(Me.Label1)
        Me.ProdottiGrezziPNL.Controls.Add(Me.Label30)
        Me.ProdottiGrezziPNL.Location = New System.Drawing.Point(3, 26)
        Me.ProdottiGrezziPNL.Name = "ProdottiGrezziPNL"
        Me.ProdottiGrezziPNL.Size = New System.Drawing.Size(723, 552)
        Me.ProdottiGrezziPNL.TabIndex = 0
        Me.ProdottiGrezziPNL.Visible = False
        '
        'AnagraficaGrezziDataGridView
        '
        Me.AnagraficaGrezziDataGridView.AutoGenerateColumns = False
        Me.AnagraficaGrezziDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AnagraficaGrezziDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AnagraficaGrezziDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnagraficaGrezziDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AnagraficaGrezziDataGridView.DataSource = Me.AnagraficaGrezziBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AnagraficaGrezziDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.AnagraficaGrezziDataGridView.Location = New System.Drawing.Point(16, 194)
        Me.AnagraficaGrezziDataGridView.Name = "AnagraficaGrezziDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AnagraficaGrezziDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.AnagraficaGrezziDataGridView.Size = New System.Drawing.Size(690, 344)
        Me.AnagraficaGrezziDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codice"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codice"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descrizione"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CategoriaTXT
        '
        Me.CategoriaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "categoria", True))
        Me.CategoriaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaTXT.Location = New System.Drawing.Point(89, 141)
        Me.CategoriaTXT.Name = "CategoriaTXT"
        Me.CategoriaTXT.Size = New System.Drawing.Size(158, 22)
        Me.CategoriaTXT.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Categoria:"
        '
        'DescrizioneTXT
        '
        Me.DescrizioneTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "descrizione", True))
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
        Me.CodiceTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "codice", True))
        Me.CodiceTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceTXT.Location = New System.Drawing.Point(89, 94)
        Me.CodiceTXT.Name = "CodiceTXT"
        Me.CodiceTXT.ReadOnly = True
        Me.CodiceTXT.Size = New System.Drawing.Size(158, 22)
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
        Me.Label30.Location = New System.Drawing.Point(154, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(383, 37)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "Anagrafica prodotti grezzi"
        '
        'PnlDataMemory
        '
        Me.PnlDataMemory.Controls.Add(Me.tipoOperazioneTXT)
        Me.PnlDataMemory.Controls.Add(Me.BilanciaCollegataCMB)
        Me.PnlDataMemory.Controls.Add(Me.BilanciaCollegataCHB)
        Me.PnlDataMemory.Controls.Add(Me.DescrDataMemoryTXT)
        Me.PnlDataMemory.Controls.Add(Me.indirizzoDataMemoryTXT)
        Me.PnlDataMemory.Controls.Add(Me.Label78)
        Me.PnlDataMemory.Controls.Add(Me.LetturaRBT)
        Me.PnlDataMemory.Controls.Add(Me.ScritturaRBT)
        Me.PnlDataMemory.Controls.Add(Me.Label79)
        Me.PnlDataMemory.Controls.Add(Me.CodDataMemoryTXT)
        Me.PnlDataMemory.Controls.Add(Me.Label80)
        Me.PnlDataMemory.Controls.Add(Me.GroupBox13)
        Me.PnlDataMemory.Controls.Add(Me.Label81)
        Me.PnlDataMemory.Controls.Add(Me.CodBilanciaCollegataTXT)
        Me.PnlDataMemory.Location = New System.Drawing.Point(3, 22)
        Me.PnlDataMemory.Name = "PnlDataMemory"
        Me.PnlDataMemory.Size = New System.Drawing.Size(719, 549)
        Me.PnlDataMemory.TabIndex = 47
        Me.PnlDataMemory.Visible = False
        '
        'tipoOperazioneTXT
        '
        Me.tipoOperazioneTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoOperazioneTXT.Location = New System.Drawing.Point(668, 81)
        Me.tipoOperazioneTXT.MaxLength = 30
        Me.tipoOperazioneTXT.Name = "tipoOperazioneTXT"
        Me.tipoOperazioneTXT.ReadOnly = True
        Me.tipoOperazioneTXT.Size = New System.Drawing.Size(0, 22)
        Me.tipoOperazioneTXT.TabIndex = 49
        '
        'BilanciaCollegataCMB
        '
        Me.BilanciaCollegataCMB.DisplayMember = "descrizione"
        Me.BilanciaCollegataCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BilanciaCollegataCMB.Enabled = False
        Me.BilanciaCollegataCMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanciaCollegataCMB.FormattingEnabled = True
        Me.BilanciaCollegataCMB.Location = New System.Drawing.Point(427, 118)
        Me.BilanciaCollegataCMB.Name = "BilanciaCollegataCMB"
        Me.BilanciaCollegataCMB.Size = New System.Drawing.Size(163, 24)
        Me.BilanciaCollegataCMB.TabIndex = 47
        Me.BilanciaCollegataCMB.ValueMember = "codice_bilancia"
        Me.BilanciaCollegataCMB.Visible = False
        '
        'BilanciaCollegataCHB
        '
        Me.BilanciaCollegataCHB.AutoSize = True
        Me.BilanciaCollegataCHB.Enabled = False
        Me.BilanciaCollegataCHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanciaCollegataCHB.Location = New System.Drawing.Point(272, 120)
        Me.BilanciaCollegataCHB.Name = "BilanciaCollegataCHB"
        Me.BilanciaCollegataCHB.Size = New System.Drawing.Size(147, 20)
        Me.BilanciaCollegataCHB.TabIndex = 46
        Me.BilanciaCollegataCHB.Text = "Collegato a Bilancia"
        Me.BilanciaCollegataCHB.UseVisualStyleBackColor = True
        '
        'DescrDataMemoryTXT
        '
        Me.DescrDataMemoryTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrDataMemoryTXT.Location = New System.Drawing.Point(425, 78)
        Me.DescrDataMemoryTXT.MaxLength = 30
        Me.DescrDataMemoryTXT.Name = "DescrDataMemoryTXT"
        Me.DescrDataMemoryTXT.Size = New System.Drawing.Size(163, 22)
        Me.DescrDataMemoryTXT.TabIndex = 31
        '
        'indirizzoDataMemoryTXT
        '
        Me.indirizzoDataMemoryTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indirizzoDataMemoryTXT.Location = New System.Drawing.Point(160, 118)
        Me.indirizzoDataMemoryTXT.MaxLength = 16
        Me.indirizzoDataMemoryTXT.Name = "indirizzoDataMemoryTXT"
        Me.indirizzoDataMemoryTXT.ReadOnly = True
        Me.indirizzoDataMemoryTXT.Size = New System.Drawing.Size(93, 22)
        Me.indirizzoDataMemoryTXT.TabIndex = 45
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(96, 121)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(59, 16)
        Me.Label78.TabIndex = 39
        Me.Label78.Text = "Indirizzo:"
        '
        'LetturaRBT
        '
        Me.LetturaRBT.AutoSize = True
        Me.LetturaRBT.Enabled = False
        Me.LetturaRBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetturaRBT.Location = New System.Drawing.Point(596, 81)
        Me.LetturaRBT.Name = "LetturaRBT"
        Me.LetturaRBT.Size = New System.Drawing.Size(66, 20)
        Me.LetturaRBT.TabIndex = 36
        Me.LetturaRBT.TabStop = True
        Me.LetturaRBT.Text = "Lettura"
        Me.LetturaRBT.UseVisualStyleBackColor = True
        '
        'ScritturaRBT
        '
        Me.ScritturaRBT.AutoSize = True
        Me.ScritturaRBT.Enabled = False
        Me.ScritturaRBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScritturaRBT.Location = New System.Drawing.Point(596, 116)
        Me.ScritturaRBT.Name = "ScritturaRBT"
        Me.ScritturaRBT.Size = New System.Drawing.Size(74, 20)
        Me.ScritturaRBT.TabIndex = 37
        Me.ScritturaRBT.TabStop = True
        Me.ScritturaRBT.Text = "Scrittura"
        Me.ScritturaRBT.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(337, 81)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(82, 16)
        Me.Label79.TabIndex = 32
        Me.Label79.Text = "Descrizione:"
        '
        'CodDataMemoryTXT
        '
        Me.CodDataMemoryTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodDataMemoryTXT.Location = New System.Drawing.Point(161, 78)
        Me.CodDataMemoryTXT.MaxLength = 30
        Me.CodDataMemoryTXT.Name = "CodDataMemoryTXT"
        Me.CodDataMemoryTXT.ReadOnly = True
        Me.CodDataMemoryTXT.Size = New System.Drawing.Size(130, 22)
        Me.CodDataMemoryTXT.TabIndex = 29
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(14, 81)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(141, 16)
        Me.Label80.TabIndex = 30
        Me.Label80.Text = "Codice Data Memory :"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.AnagraficaDataMemoryDataGridView)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(16, 200)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(701, 348)
        Me.GroupBox13.TabIndex = 17
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Dettaglio Data Memory"
        '
        'AnagraficaDataMemoryDataGridView
        '
        Me.AnagraficaDataMemoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AnagraficaDataMemoryDataGridView.Location = New System.Drawing.Point(8, 23)
        Me.AnagraficaDataMemoryDataGridView.Name = "AnagraficaDataMemoryDataGridView"
        Me.AnagraficaDataMemoryDataGridView.ReadOnly = True
        Me.AnagraficaDataMemoryDataGridView.Size = New System.Drawing.Size(687, 319)
        Me.AnagraficaDataMemoryDataGridView.TabIndex = 0
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label81.Location = New System.Drawing.Point(187, 12)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(372, 37)
        Me.Label81.TabIndex = 15
        Me.Label81.Text = "Anagrafica Data Memory"
        '
        'CodBilanciaCollegataTXT
        '
        Me.CodBilanciaCollegataTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodBilanciaCollegataTXT.Location = New System.Drawing.Point(441, 120)
        Me.CodBilanciaCollegataTXT.MaxLength = 30
        Me.CodBilanciaCollegataTXT.Name = "CodBilanciaCollegataTXT"
        Me.CodBilanciaCollegataTXT.ReadOnly = True
        Me.CodBilanciaCollegataTXT.Size = New System.Drawing.Size(0, 22)
        Me.CodBilanciaCollegataTXT.TabIndex = 48
        '
        'PnlOperatori
        '
        Me.PnlOperatori.Controls.Add(Me.PswCHB)
        Me.PnlOperatori.Controls.Add(Me.GroupBox4)
        Me.PnlOperatori.Controls.Add(Me.Label19)
        Me.PnlOperatori.Controls.Add(Me.PaswOperatoreTXT)
        Me.PnlOperatori.Controls.Add(Me.Label22)
        Me.PnlOperatori.Controls.Add(Me.nomeOperatoreTXT)
        Me.PnlOperatori.Controls.Add(Me.codoperatoreTXT)
        Me.PnlOperatori.Controls.Add(Me.Label20)
        Me.PnlOperatori.Controls.Add(Me.Label23)
        Me.PnlOperatori.Controls.Add(Me.RuoliCmb)
        Me.PnlOperatori.Controls.Add(Me.Label21)
        Me.PnlOperatori.Controls.Add(Me.ruoloSelectedTXT)
        Me.PnlOperatori.Location = New System.Drawing.Point(-5, -3)
        Me.PnlOperatori.Name = "PnlOperatori"
        Me.PnlOperatori.Size = New System.Drawing.Size(730, 581)
        Me.PnlOperatori.TabIndex = 34
        Me.PnlOperatori.Visible = False
        '
        'PswCHB
        '
        Me.PswCHB.AutoSize = True
        Me.PswCHB.Location = New System.Drawing.Point(299, 137)
        Me.PswCHB.Name = "PswCHB"
        Me.PswCHB.Size = New System.Drawing.Size(107, 17)
        Me.PswCHB.TabIndex = 33
        Me.PswCHB.Text = "Mostra Password"
        Me.PswCHB.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(19, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(682, 285)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operatori presenti"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label19.Location = New System.Drawing.Point(181, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(315, 37)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Anagrafica Operatori"
        '
        'PaswOperatoreTXT
        '
        Me.PaswOperatoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaswOperatoreTXT.Location = New System.Drawing.Point(99, 133)
        Me.PaswOperatoreTXT.MaxLength = 30
        Me.PaswOperatoreTXT.Name = "PaswOperatoreTXT"
        Me.PaswOperatoreTXT.ReadOnly = True
        Me.PaswOperatoreTXT.Size = New System.Drawing.Size(188, 22)
        Me.PaswOperatoreTXT.TabIndex = 32
        Me.PaswOperatoreTXT.UseSystemPasswordChar = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(431, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Ruolo:"
        '
        'nomeOperatoreTXT
        '
        Me.nomeOperatoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeOperatoreTXT.Location = New System.Drawing.Point(415, 89)
        Me.nomeOperatoreTXT.MaxLength = 30
        Me.nomeOperatoreTXT.Name = "nomeOperatoreTXT"
        Me.nomeOperatoreTXT.ReadOnly = True
        Me.nomeOperatoreTXT.Size = New System.Drawing.Size(286, 22)
        Me.nomeOperatoreTXT.TabIndex = 31
        '
        'codoperatoreTXT
        '
        Me.codoperatoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codoperatoreTXT.Location = New System.Drawing.Point(145, 89)
        Me.codoperatoreTXT.MaxLength = 4
        Me.codoperatoreTXT.Name = "codoperatoreTXT"
        Me.codoperatoreTXT.ReadOnly = True
        Me.codoperatoreTXT.Size = New System.Drawing.Size(133, 22)
        Me.codoperatoreTXT.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 92)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 16)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Codice Operatore:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(22, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Password:"
        '
        'RuoliCmb
        '
        Me.RuoliCmb.DisplayMember = "descrizione"
        Me.RuoliCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RuoliCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuoliCmb.FormattingEnabled = True
        Me.RuoliCmb.Location = New System.Drawing.Point(484, 133)
        Me.RuoliCmb.Name = "RuoliCmb"
        Me.RuoliCmb.Size = New System.Drawing.Size(145, 24)
        Me.RuoliCmb.TabIndex = 35
        Me.RuoliCmb.ValueMember = "codice_ruolo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(284, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 16)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Nome e Cognome:"
        '
        'ruoloSelectedTXT
        '
        Me.ruoloSelectedTXT.Location = New System.Drawing.Point(529, 133)
        Me.ruoloSelectedTXT.Name = "ruoloSelectedTXT"
        Me.ruoloSelectedTXT.Size = New System.Drawing.Size(100, 20)
        Me.ruoloSelectedTXT.TabIndex = 37
        '
        'IdTXT
        '
        Me.IdTXT.Location = New System.Drawing.Point(0, 0)
        Me.IdTXT.Name = "IdTXT"
        Me.IdTXT.Size = New System.Drawing.Size(100, 20)
        Me.IdTXT.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 0
        '
        'DescrCategoriaTXT
        '
        Me.DescrCategoriaTXT.Location = New System.Drawing.Point(0, 0)
        Me.DescrCategoriaTXT.Name = "DescrCategoriaTXT"
        Me.DescrCategoriaTXT.Size = New System.Drawing.Size(100, 20)
        Me.DescrCategoriaTXT.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 0
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.AnagraficaProdottiBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Nothing
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnagraficaProdottiBindingNavigatorSaveItem, Me.BNUpdateButton, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.BNCodiceTXT, Me.ToolStripLabel2, Me.BNDescrizoneTXT})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(892, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'AnagraficaProdottiBindingNavigatorSaveItem
        '
        Me.AnagraficaProdottiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnagraficaProdottiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Name = "AnagraficaProdottiBindingNavigatorSaveItem"
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnagraficaProdottiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'BNUpdateButton
        '
        Me.BNUpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNUpdateButton.Image = Global.Tostatura.My.Resources.Resources.aggiorna
        Me.BNUpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BNUpdateButton.Name = "BNUpdateButton"
        Me.BNUpdateButton.Size = New System.Drawing.Size(23, 22)
        Me.BNUpdateButton.Text = "BNUpdateBTN"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "Codice: "
        '
        'BNCodiceTXT
        '
        Me.BNCodiceTXT.Name = "BNCodiceTXT"
        Me.BNCodiceTXT.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel2.Text = "Descrizione:"
        '
        'BNDescrizoneTXT
        '
        Me.BNDescrizoneTXT.Name = "BNDescrizoneTXT"
        Me.BNDescrizoneTXT.Size = New System.Drawing.Size(100, 25)
        '
        'AnagraficaProdottiTableAdapter
        '
        Me.AnagraficaProdottiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaGrezziTableAdapter = Me.AnagraficaGrezziTableAdapter
        Me.TableAdapterManager.AnagraficaProdottiTableAdapter = Me.AnagraficaProdottiTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaTableAdapter = Me.ParametriTostaturaTableAdapter
        Me.TableAdapterManager.RuoliTableAdapter = Nothing
        Me.TableAdapterManager.StoricoAllarmiTableAdapter = Nothing
        Me.TableAdapterManager.StoricoInputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.StoricoOutputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLavorazioneTableAdapter = Me.TipoLavorazioneTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnagraficaGrezziTableAdapter
        '
        Me.AnagraficaGrezziTableAdapter.ClearBeforeFill = True
        '
        'ParametriTostaturaTableAdapter
        '
        Me.ParametriTostaturaTableAdapter.ClearBeforeFill = True
        '
        'TipoLavorazioneTableAdapter
        '
        Me.TipoLavorazioneTableAdapter.ClearBeforeFill = True
        '
        'FormAnagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(892, 596)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormAnagrafiche"
        Me.Text = "Gestione Anagrafiche"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.CtlAvanzatiGPB.ResumeLayout(False)
        Me.ProdottiFinitiPNL.ResumeLayout(False)
        Me.ProdottiFinitiPNL.PerformLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnagraficaGrezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdottiGrezziPNL.ResumeLayout(False)
        Me.ProdottiGrezziPNL.PerformLayout()
        CType(Me.AnagraficaGrezziDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDataMemory.ResumeLayout(False)
        Me.PnlDataMemory.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.AnagraficaDataMemoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOperatori.ResumeLayout(False)
        Me.PnlOperatori.PerformLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents ProdottiGrezziPNL As System.Windows.Forms.Panel
    Friend WithEvents ProdottiFinitiPNL As System.Windows.Forms.Panel
    Friend WithEvents DescrizioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodiceTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DescrCategoriaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IdTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PnlDataMemory As System.Windows.Forms.Panel
    Friend WithEvents tipoOperazioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents BilanciaCollegataCMB As System.Windows.Forms.ComboBox
    Friend WithEvents BilanciaCollegataCHB As System.Windows.Forms.CheckBox
    Friend WithEvents DescrDataMemoryTXT As System.Windows.Forms.TextBox
    Friend WithEvents indirizzoDataMemoryTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents LetturaRBT As System.Windows.Forms.RadioButton
    Friend WithEvents ScritturaRBT As System.Windows.Forms.RadioButton
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents CodDataMemoryTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents AnagraficaDataMemoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents CodBilanciaCollegataTXT As System.Windows.Forms.TextBox
    Friend WithEvents CtlAvanzatiGPB As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OperatoriBTN As System.Windows.Forms.Button
    Friend WithEvents FinitiBTN As System.Windows.Forms.Button
    Friend WithEvents ProdottiBTN As System.Windows.Forms.Button
    Friend WithEvents BNUpdateButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BNCodiceTXT As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BNDescrizoneTXT As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PnlOperatori As System.Windows.Forms.Panel
    Friend WithEvents PswCHB As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PaswOperatoreTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nomeOperatoreTXT As System.Windows.Forms.TextBox
    Friend WithEvents codoperatoreTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RuoliCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ruoloSelectedTXT As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficaGrezziTableAdapter As Tostatura.TostaturaDataSetTableAdapters.AnagraficaGrezziTableAdapter
    Friend WithEvents CategoriaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AnagraficaGrezziDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnagraficaGrezziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaFinitoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescrizioneFinitoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CodiceFinitoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UmiditaProdottoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents QuantitaCaricoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TempoCotturaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TemperaturaFornoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents UmiditaEsternaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CalibroFinitoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TipoLavorazioneCMB As System.Windows.Forms.ComboBox
    Friend WithEvents CodiceGrezzoTXT As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneGrezzoCMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents IdTipoLavorazioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents TipoLavorazioneTableAdapter As Tostatura.TostaturaDataSetTableAdapters.TipoLavorazioneTableAdapter
    Friend WithEvents TipoLavorazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ParametriTostaturaTableAdapter As Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
    Friend WithEvents ParametriTostaturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdParametriTXT As System.Windows.Forms.TextBox
End Class