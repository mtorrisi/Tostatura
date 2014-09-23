Public Class TostaturaForm

    Friend WithEvents u As New Utils()
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
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.TipoLavorazione'. È possibile spostarla o rimuoverla se necessario.
        Me.TipoLavorazioneTableAdapter.Fill(Me.TostaturaDataSet.TipoLavorazione)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ParametriTostatura'. È possibile spostarla o rimuoverla se necessario.
        Me.ParametriTostaturaTableAdapter.Fill(Me.TostaturaDataSet.ParametriTostatura)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ParametriTostatura'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.AnagraficaGrezzi'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)


        Me.OpLbl.Text = operatore.NomeOperatore
        Me.CodOpLbl.Text = operatore.CodiceOperatore


    End Sub

    Private Sub IdParametriTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdParametriTXT.TextChanged
        If Not (IdParametriTXT.Text.Equals("") And IdParametriTXT.Text = Nothing) Then
            Me.ParametriTostaturaTableAdapter.FillById(Me.TostaturaDataSet.ParametriTostatura, Me.IdParametriTXT.Text)

        End If
    End Sub

    Private Sub idLavorazioneTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idLavorazioneTXT.TextChanged
        If Not (idLavorazioneTXT.Text.Equals("") And idLavorazioneTXT.Text = Nothing) Then
            Me.TipoLavorazioneTableAdapter.FillById(Me.TostaturaDataSet.TipoLavorazione, Me.idLavorazioneTXT.Text)

        End If
    End Sub

    Private Sub codiceGrezzoTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codiceGrezzoTXT.TextChanged
        If Not (Me.codiceGrezzoTXT.Text.Equals("") And Me.codiceGrezzoTXT.Text = Nothing) Then
            Me.AnagraficaGrezziTableAdapter.FillByCodice(Me.TostaturaDataSet.AnagraficaGrezzi, Me.codiceGrezzoTXT.Text)
        End If


    End Sub
End Class