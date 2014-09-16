Public Class TostaturaForm

    Dim operatore As Operatore
    Public callingForm As MainForm

    Public Sub New(ByVal op As Operatore)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.operatore = op
        Me.GroupBox2.Enabled = (operatore.CodiceRuolo = 3)
    End Sub

    Private Sub Tstatura_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ProdottiCategorieView'. È possibile spostarla o rimuoverla se necessario.
        'Me.ProdottiCategorieViewTableAdapter.Fill(Me.TostaturaDataSet.ProdottiCategorieView)


        Me.OpLbl.Text = operatore.NomeOperatore
        Me.CodOpLbl.Text = operatore.CodiceOperatore


    End Sub
End Class