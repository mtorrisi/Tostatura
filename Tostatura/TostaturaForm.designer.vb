<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TostaturaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TostaturaForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.codiceGrezzoTXT = New System.Windows.Forms.TextBox
        Me.AnagraficaProdottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.idCategoriaTXT = New System.Windows.Forms.TextBox
        Me.CalibroTXT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DescrizioneTXT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodiceFinitoTXT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CategoriaGrzTXT = New System.Windows.Forms.TextBox
        Me.AnagraficaGrezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label
        Me.DescrizioneGrzTXT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CodiceGrzTXT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.idLavorazioneTXT = New System.Windows.Forms.TextBox
        Me.ParametriTostaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdParametriTXT = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TipoLavorazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tCotturaTXT = New System.Windows.Forms.TextBox
        Me.tempFornoTXT = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.qCaricoTXT = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.umidEsternaTXT = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.umidProdottoTXT = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tostaturaBTN = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CodOpLbl = New System.Windows.Forms.Label
        Me.OpLbl = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnagraficaGrezziTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.AnagraficaGrezziTableAdapter
        Me.TableAdapterManager = New Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
        Me.AnagraficaProdottiTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.AnagraficaProdottiTableAdapter
        Me.ParametriTostaturaTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
        Me.TipoLavorazioneTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.TipoLavorazioneTableAdapter
        Me.statusLBL = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox3.SuspendLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AnagraficaGrezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.codiceGrezzoTXT)
        Me.GroupBox3.Controls.Add(Me.idCategoriaTXT)
        Me.GroupBox3.Controls.Add(Me.CalibroTXT)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DescrizioneTXT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CodiceFinitoTXT)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 95)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(425, 141)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prodotto Finito:"
        '
        'codiceGrezzoTXT
        '
        Me.codiceGrezzoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "codice_grezzo", True))
        Me.codiceGrezzoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codiceGrezzoTXT.Location = New System.Drawing.Point(381, 28)
        Me.codiceGrezzoTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.codiceGrezzoTXT.Name = "codiceGrezzoTXT"
        Me.codiceGrezzoTXT.ReadOnly = True
        Me.codiceGrezzoTXT.Size = New System.Drawing.Size(36, 22)
        Me.codiceGrezzoTXT.TabIndex = 41
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
        'idCategoriaTXT
        '
        Me.idCategoriaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "categoria", True))
        Me.idCategoriaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCategoriaTXT.Location = New System.Drawing.Point(106, 96)
        Me.idCategoriaTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.idCategoriaTXT.Name = "idCategoriaTXT"
        Me.idCategoriaTXT.ReadOnly = True
        Me.idCategoriaTXT.Size = New System.Drawing.Size(205, 22)
        Me.idCategoriaTXT.TabIndex = 41
        '
        'CalibroTXT
        '
        Me.CalibroTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "calibro", True))
        Me.CalibroTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalibroTXT.Location = New System.Drawing.Point(381, 96)
        Me.CalibroTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.CalibroTXT.Name = "CalibroTXT"
        Me.CalibroTXT.ReadOnly = True
        Me.CalibroTXT.Size = New System.Drawing.Size(36, 22)
        Me.CalibroTXT.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Calibro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Categoria:"
        '
        'DescrizioneTXT
        '
        Me.DescrizioneTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "descrizione", True))
        Me.DescrizioneTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneTXT.Location = New System.Drawing.Point(106, 60)
        Me.DescrizioneTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.DescrizioneTXT.Name = "DescrizioneTXT"
        Me.DescrizioneTXT.ReadOnly = True
        Me.DescrizioneTXT.Size = New System.Drawing.Size(311, 22)
        Me.DescrizioneTXT.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descrizione: "
        '
        'CodiceFinitoTXT
        '
        Me.CodiceFinitoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "codice", True))
        Me.CodiceFinitoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceFinitoTXT.Location = New System.Drawing.Point(106, 28)
        Me.CodiceFinitoTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.CodiceFinitoTXT.Name = "CodiceFinitoTXT"
        Me.CodiceFinitoTXT.ReadOnly = True
        Me.CodiceFinitoTXT.Size = New System.Drawing.Size(113, 22)
        Me.CodiceFinitoTXT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Articolo: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CategoriaGrzTXT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DescrizioneGrzTXT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CodiceGrzTXT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(425, 141)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prodotto Grezzo:"
        '
        'CategoriaGrzTXT
        '
        Me.CategoriaGrzTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "categoria", True))
        Me.CategoriaGrzTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaGrzTXT.Location = New System.Drawing.Point(128, 98)
        Me.CategoriaGrzTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoriaGrzTXT.Name = "CategoriaGrzTXT"
        Me.CategoriaGrzTXT.ReadOnly = True
        Me.CategoriaGrzTXT.Size = New System.Drawing.Size(289, 22)
        Me.CategoriaGrzTXT.TabIndex = 43
        '
        'AnagraficaGrezziBindingSource
        '
        Me.AnagraficaGrezziBindingSource.DataMember = "AnagraficaGrezzi"
        Me.AnagraficaGrezziBindingSource.DataSource = Me.TostaturaDataSet
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 102)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Categoria:"
        '
        'DescrizioneGrzTXT
        '
        Me.DescrizioneGrzTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "descrizione", True))
        Me.DescrizioneGrzTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneGrzTXT.Location = New System.Drawing.Point(128, 60)
        Me.DescrizioneGrzTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.DescrizioneGrzTXT.Name = "DescrizioneGrzTXT"
        Me.DescrizioneGrzTXT.ReadOnly = True
        Me.DescrizioneGrzTXT.Size = New System.Drawing.Size(289, 22)
        Me.DescrizioneGrzTXT.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descrizione: "
        '
        'CodiceGrzTXT
        '
        Me.CodiceGrzTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaGrezziBindingSource, "codice", True))
        Me.CodiceGrzTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceGrzTXT.Location = New System.Drawing.Point(128, 25)
        Me.CodiceGrzTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.CodiceGrzTXT.Name = "CodiceGrzTXT"
        Me.CodiceGrzTXT.ReadOnly = True
        Me.CodiceGrzTXT.Size = New System.Drawing.Size(132, 22)
        Me.CodiceGrzTXT.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Articolo: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.idLavorazioneTXT)
        Me.GroupBox2.Controls.Add(Me.IdParametriTXT)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.tCotturaTXT)
        Me.GroupBox2.Controls.Add(Me.tempFornoTXT)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.qCaricoTXT)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.umidEsternaTXT)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.umidProdottoTXT)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(16, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(855, 241)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametri tostatura"
        '
        'idLavorazioneTXT
        '
        Me.idLavorazioneTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "tipo_lavorazione", True))
        Me.idLavorazioneTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLavorazioneTXT.Location = New System.Drawing.Point(371, 187)
        Me.idLavorazioneTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.idLavorazioneTXT.Name = "idLavorazioneTXT"
        Me.idLavorazioneTXT.ReadOnly = True
        Me.idLavorazioneTXT.Size = New System.Drawing.Size(36, 22)
        Me.idLavorazioneTXT.TabIndex = 43
        '
        'ParametriTostaturaBindingSource
        '
        Me.ParametriTostaturaBindingSource.DataMember = "ParametriTostatura"
        Me.ParametriTostaturaBindingSource.DataSource = Me.TostaturaDataSet
        '
        'IdParametriTXT
        '
        Me.IdParametriTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnagraficaProdottiBindingSource, "id_parametri", True))
        Me.IdParametriTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdParametriTXT.Location = New System.Drawing.Point(371, 27)
        Me.IdParametriTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.IdParametriTXT.Name = "IdParametriTXT"
        Me.IdParametriTXT.ReadOnly = True
        Me.IdParametriTXT.Size = New System.Drawing.Size(36, 22)
        Me.IdParametriTXT.TabIndex = 42
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TipoLavorazioneBindingSource, "id", True))
        Me.ComboBox2.DataSource = Me.TipoLavorazioneBindingSource
        Me.ComboBox2.DisplayMember = "descrizione"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(203, 187)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 25
        Me.ComboBox2.ValueMember = "id"
        '
        'TipoLavorazioneBindingSource
        '
        Me.TipoLavorazioneBindingSource.DataMember = "TipoLavorazione"
        Me.TipoLavorazioneBindingSource.DataSource = Me.TostaturaDataSet
        '
        'tCotturaTXT
        '
        Me.tCotturaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "tempo_cottura", True))
        Me.tCotturaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCotturaTXT.Location = New System.Drawing.Point(203, 123)
        Me.tCotturaTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.tCotturaTXT.Name = "tCotturaTXT"
        Me.tCotturaTXT.Size = New System.Drawing.Size(160, 22)
        Me.tCotturaTXT.TabIndex = 22
        '
        'tempFornoTXT
        '
        Me.tempFornoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "temperatura_forno", True))
        Me.tempFornoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempFornoTXT.Location = New System.Drawing.Point(203, 91)
        Me.tempFornoTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.tempFornoTXT.Name = "tempFornoTXT"
        Me.tempFornoTXT.Size = New System.Drawing.Size(160, 22)
        Me.tempFornoTXT.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 190)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Tipo Lavorazione:"
        '
        'qCaricoTXT
        '
        Me.qCaricoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "quantita_carico", True))
        Me.qCaricoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qCaricoTXT.Location = New System.Drawing.Point(203, 155)
        Me.qCaricoTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.qCaricoTXT.Name = "qCaricoTXT"
        Me.qCaricoTXT.Size = New System.Drawing.Size(160, 22)
        Me.qCaricoTXT.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 158)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Quantità di carico: "
        '
        'umidEsternaTXT
        '
        Me.umidEsternaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "umidita_esterna", True))
        Me.umidEsternaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.umidEsternaTXT.Location = New System.Drawing.Point(203, 59)
        Me.umidEsternaTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.umidEsternaTXT.Name = "umidEsternaTXT"
        Me.umidEsternaTXT.Size = New System.Drawing.Size(160, 22)
        Me.umidEsternaTXT.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 126)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tempo di cottura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Percentuanle di umità esterna:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Percentuale umidità prodotto: "
        '
        'umidProdottoTXT
        '
        Me.umidProdottoTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametriTostaturaBindingSource, "umidita_prodotto", True))
        Me.umidProdottoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.umidProdottoTXT.Location = New System.Drawing.Point(203, 27)
        Me.umidProdottoTXT.Margin = New System.Windows.Forms.Padding(4)
        Me.umidProdottoTXT.Name = "umidProdottoTXT"
        Me.umidProdottoTXT.Size = New System.Drawing.Size(160, 22)
        Me.umidProdottoTXT.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Temperatura forno:"
        '
        'tostaturaBTN
        '
        Me.tostaturaBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tostaturaBTN.Location = New System.Drawing.Point(12, 501)
        Me.tostaturaBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.tostaturaBTN.Name = "tostaturaBTN"
        Me.tostaturaBTN.Size = New System.Drawing.Size(120, 58)
        Me.tostaturaBTN.TabIndex = 19
        Me.tostaturaBTN.Text = "Avvia Tostatura"
        Me.tostaturaBTN.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(153, 501)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 58)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Stampo Etichetta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CodOpLbl
        '
        Me.CodOpLbl.AutoSize = True
        Me.CodOpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodOpLbl.Location = New System.Drawing.Point(811, 68)
        Me.CodOpLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CodOpLbl.Name = "CodOpLbl"
        Me.CodOpLbl.Size = New System.Drawing.Size(56, 16)
        Me.CodOpLbl.TabIndex = 36
        Me.CodOpLbl.Text = "Label20"
        '
        'OpLbl
        '
        Me.OpLbl.AutoSize = True
        Me.OpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpLbl.Location = New System.Drawing.Point(811, 37)
        Me.OpLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OpLbl.Name = "OpLbl"
        Me.OpLbl.Size = New System.Drawing.Size(56, 16)
        Me.OpLbl.TabIndex = 34
        Me.OpLbl.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(731, 68)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Codice:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(731, 37)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Operatore:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.AnagraficaProdottiBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.statusLBL})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(888, 25)
        Me.BindingNavigator1.TabIndex = 37
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'AnagraficaGrezziTableAdapter
        '
        Me.AnagraficaGrezziTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnagraficaGrezziTableAdapter = Me.AnagraficaGrezziTableAdapter
        Me.TableAdapterManager.AnagraficaProdottiTableAdapter = Me.AnagraficaProdottiTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OperatoriTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaDefaultTableAdapter = Nothing
        Me.TableAdapterManager.ParametriTostaturaTableAdapter = Me.ParametriTostaturaTableAdapter
        Me.TableAdapterManager.RuoliTableAdapter = Nothing
        Me.TableAdapterManager.StoricoAllarmiTableAdapter = Nothing
        Me.TableAdapterManager.StoricoInputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.StoricoOutputTostaturaTableAdapter = Nothing
        Me.TableAdapterManager.TipoLavorazioneTableAdapter = Me.TipoLavorazioneTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnagraficaProdottiTableAdapter
        '
        Me.AnagraficaProdottiTableAdapter.ClearBeforeFill = True
        '
        'ParametriTostaturaTableAdapter
        '
        Me.ParametriTostaturaTableAdapter.ClearBeforeFill = True
        '
        'TipoLavorazioneTableAdapter
        '
        Me.TipoLavorazioneTableAdapter.ClearBeforeFill = True
        '
        'statusLBL
        '
        Me.statusLBL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusLBL.ForeColor = System.Drawing.Color.ForestGreen
        Me.statusLBL.Name = "statusLBL"
        Me.statusLBL.Size = New System.Drawing.Size(152, 22)
        Me.statusLBL.Text = "Invio dati tostatura in corso..."
        Me.statusLBL.Visible = False
        '
        'TostaturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(888, 585)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.CodOpLbl)
        Me.Controls.Add(Me.OpLbl)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tostaturaBTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TostaturaForm"
        Me.Text = "Tostatura"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AnagraficaProdottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AnagraficaGrezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ParametriTostaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLavorazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DescrizioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodiceFinitoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DescrizioneGrzTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CodiceGrzTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents tCotturaTXT As System.Windows.Forms.TextBox
    Friend WithEvents tempFornoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents qCaricoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents umidEsternaTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents umidProdottoTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tostaturaBTN As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CodOpLbl As System.Windows.Forms.Label
    Friend WithEvents OpLbl As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents idCategoriaTXT As System.Windows.Forms.TextBox
    Friend WithEvents CalibroTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CategoriaGrzTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TostaturaDataSet As Tostatura.TostaturaDataSet
    Friend WithEvents AnagraficaGrezziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnagraficaGrezziTableAdapter As Tostatura.TostaturaDataSetTableAdapters.AnagraficaGrezziTableAdapter
    Friend WithEvents TableAdapterManager As Tostatura.TostaturaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnagraficaProdottiTableAdapter As Tostatura.TostaturaDataSetTableAdapters.AnagraficaProdottiTableAdapter
    Friend WithEvents AnagraficaProdottiBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents codiceGrezzoTXT As System.Windows.Forms.TextBox
    Friend WithEvents IdParametriTXT As System.Windows.Forms.TextBox
    Friend WithEvents ParametriTostaturaTableAdapter As Tostatura.TostaturaDataSetTableAdapters.ParametriTostaturaTableAdapter
    Friend WithEvents ParametriTostaturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents idLavorazioneTXT As System.Windows.Forms.TextBox
    Friend WithEvents TipoLavorazioneTableAdapter As Tostatura.TostaturaDataSetTableAdapters.TipoLavorazioneTableAdapter
    Friend WithEvents TipoLavorazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents statusLBL As System.Windows.Forms.ToolStripLabel
End Class
