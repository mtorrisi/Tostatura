Public Class FormAnagrafiche

    Dim operatore As Operatore
    Dim addNewItem As Boolean = False

    Public Sub New(ByVal operatore As Operatore)
        InitializeComponent()
        Me.operatore = operatore

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.addNewItem = True
        If Me.ProdottiGrezziPNL.Visible Then
            Me.CodiceTXT.ReadOnly = False
        ElseIf Me.ProdottiFinitiPNL.Visible Then
            Me.CodiceFinitoTXT.ReadOnly = False
        End If

    End Sub

    Private Sub AnagraficaProdottiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagraficaProdottiBindingNavigatorSaveItem.Click
        Dim oldCodice As String =""
        If ProdottiGrezziPNL.Visible Then

            Me.Validate()
            Me.AnagraficaGrezziBindingSource.EndEdit()
            If addNewItem Then
                Me.AnagraficaGrezziTableAdapter.Insert(CodiceTXT.Text, DescrizioneTXT.Text, CategoriaTXT.Text)
                Me.addNewItem = False
                Me.CodiceTXT.ReadOnly = True
            Else
                Me.AnagraficaGrezziTableAdapter.UpdateGrezzo(DescrizioneTXT.Text, CategoriaTXT.Text, CodiceTXT.Text)
            End If
            oldCodice = Me.CodiceTXT.Text
            Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)
            'Dim index As Integer = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)
            'If index <> -1 Then
            'Me.BindingNavigator.BindingSource.Position = index
            'End If
        ElseIf Me.ProdottiFinitiPNL.Visible Then

        Me.Validate()
        Me.AnagraficaProdottiBindingSource.EndEdit()
            If addNewItem Then
                Dim UmiditaProdotto As Double
                Dim UmiditaEsterna As Double
                Dim TemperaturaForno As Double
                Dim TempoCottura As Double
                Dim QuantitaCarico As Double
                Double.TryParse(Me.UmiditaProdottoTXT.Text, UmiditaProdotto)
                Double.TryParse(Me.UmiditaEsternaTXT.Text, UmiditaEsterna)
                Double.TryParse(Me.TemperaturaFornoTXT.Text, TemperaturaForno)
                Double.TryParse(Me.TempoCotturaTXT.Text, TempoCottura)
                Double.TryParse(Me.QuantitaCaricoTXT.Text, QuantitaCarico)
                Me.AnagraficaProdottiTableAdapter.Insert(CodiceFinitoTXT.Text, DescrizioneFinitoTXT.Text, CategoriaFinitoTXT.Text, CalibroFinitoTXT.Text, CodiceGrezzoTXT.Text, 0)
                Me.addNewItem = False
                Me.CodiceFinitoTXT.ReadOnly = True
            Else
                Me.AnagraficaProdottiTableAdapter.UpdateFinito(DescrizioneFinitoTXT.Text, CategoriaFinitoTXT.Text, CalibroFinitoTXT.Text, CodiceGrezzoTXT.Text, 0, CodiceFinitoTXT.Text)
            End If
            oldCodice = Me.CodiceFinitoTXT.Text
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
            'Dim index As Integer = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)
            'If index <> -1 Then
            'Me.BindingNavigator.BindingSource.Position = index
            'End If

        End If

        Dim index As Integer = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)
        If index <> -1 Then
            Me.BindingNavigator.BindingSource.Position = index
        End If

    End Sub

    Private Sub FormAnagrafiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ParametriTostatura'. È possibile spostarla o rimuoverla se necessario.
        Me.ParametriTostaturaTableAdapter.Fill(Me.TostaturaDataSet.ParametriTostatura)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.TipoLavorazione'. È possibile spostarla o rimuoverla se necessario.
        Me.TipoLavorazioneTableAdapter.Fill(Me.TostaturaDataSet.TipoLavorazione)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.AnagraficaGrezzi'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        Me.ProdottiGrezziPNL.Visible = True

        If Me.operatore.CodiceRuolo = 3 Then
            Me.CtlAvanzatiGPB.Visible = True
        Else
            Me.CtlAvanzatiGPB.Visible = False
        End If

        Me.BindingNavigator.BindingSource = Me.AnagraficaGrezziBindingSource
    End Sub


    Private Sub ProdottiBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdottiBTN.Click
        Me.ProdottiGrezziPNL.Visible = True
        Me.ProdottiFinitiPNL.Visible = False
        Me.PnlOperatori.Visible = False

        Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)
        Me.BindingNavigator.BindingSource = Me.AnagraficaGrezziBindingSource

    End Sub

    Private Sub FinitiBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinitiBTN.Click
        Me.ProdottiGrezziPNL.Visible = False
        Me.ProdottiFinitiPNL.Visible = True
        Me.PnlOperatori.Visible = False

        Me.BindingNavigator.BindingSource = Me.AnagraficaProdottiBindingSource
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        'Me.GrezziFinitiParametriViewTableAdapter.Fill(Me.TostaturaDataSet.GrezziFinitiParametriView)
        'Me.BindingNavigator.BindingSource = Me.GrezziFinitiParametriViewBindingSource

    End Sub

    Private Sub OperatoriBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatoriBTN.Click
        Me.ProdottiGrezziPNL.Visible = False
        Me.ProdottiFinitiPNL.Visible = False
        Me.PnlOperatori.Visible = True

        'Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)

        'Me.BindingNavigator.BindingSource = Me.CategoriaProdottiBindingSource

    End Sub
    Private Sub CodiceTXT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodiceTXT.Leave
        If Not CodiceTXT.ReadOnly Then
            If Not (CodiceTXT.Text.Equals("") And CodiceTXT.Text Is Nothing) Then
                If Not Me.AnagraficaGrezziTableAdapter.CountElementByCodice(CodiceTXT.Text) = 0 Then
                    Me.CodiceTXT.ReadOnly = True
                    Me.addNewItem = False

                    Me.AnagraficaGrezziTableAdapter.FillByCodice(Me.TostaturaDataSet.AnagraficaGrezzi, Me.CodiceTXT.Text)
                End If
            End If
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim message As String = ""
        Dim item As String = ""
        Dim oldCodice As String = ""
        Dim index As Integer = -1
        If ProdottiGrezziPNL.Visible Then
            message = "il prodotto"
            item = "Codice: " & CodiceTXT.Text & vbNewLine & "Descrizione: " & DescrizioneTXT.Text
            oldCodice = Me.CodiceTXT.Text
        End If

        If MessageBox.Show("Stai per rimuovere" & message & ": " & vbNewLine & item & vbNewLine & "Confermi l'eliminazione?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            index = Me.BindingNavigator.BindingSource.Position - 1
            Me.AnagraficaGrezziTableAdapter.DeleteByCodice(Me.CodiceTXT.Text)
            Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)

        Else
            MessageBox.Show("Eliminazione annullata.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            index = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)

        End If
        If index <> -1 Then
            Me.BindingNavigator.BindingSource.Position = index
        End If
    End Sub

    Private Sub BNCodiceTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNCodiceTXT.TextChanged
        If Not (Me.BNCodiceTXT.Text Is Nothing And Me.BNCodiceTXT.Text.Equals("")) Then
            If Me.ProdottiGrezziPNL.Visible Then
                Me.AnagraficaGrezziTableAdapter.SearchByCodice(Me.TostaturaDataSet.AnagraficaGrezzi, Me.BNCodiceTXT.Text)
            ElseIf Me.ProdottiFinitiPNL.Visible Then
                'Me.GrezziFinitiParametriViewTableAdapter.SearchByCodiceFinito(Me.TostaturaDataSet.GrezziFinitiParametriView, BNCodiceTXT.Text)
                Me.AnagraficaProdottiTableAdapter.SearchByCodiceFinito(Me.TostaturaDataSet.AnagraficaProdotti, BNCodiceTXT.Text)
                
            End If
        End If
    End Sub

    Private Sub BNCodiceTXT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNCodiceTXT.Leave
        If Not (Me.BNCodiceTXT.Text Is Nothing And Me.BNCodiceTXT.Text.Equals("")) Then
            If Me.ProdottiGrezziPNL.Visible Then
                Me.AnagraficaGrezziTableAdapter.SearchByCodice(Me.TostaturaDataSet.AnagraficaGrezzi, Me.BNCodiceTXT.Text)
            ElseIf Me.ProdottiFinitiPNL.Visible Then
                Me.AnagraficaProdottiTableAdapter.SearchByCodiceFinito(Me.TostaturaDataSet.AnagraficaProdotti, BNCodiceTXT.Text)
                'Else
                '   MessageBox.Show("Specifica un valore numerico per il codice Categoria.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BNCodiceTXT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BNCodiceTXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub BNDescrizoneTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNDescrizoneTXT.TextChanged
        If Not (Me.BNDescrizoneTXT.Text Is Nothing And Me.BNDescrizoneTXT.Text.Equals("")) Then
            If Me.ProdottiGrezziPNL.Visible Then
                Me.AnagraficaGrezziTableAdapter.SearchByDescrizione(Me.TostaturaDataSet.AnagraficaGrezzi, Me.BNDescrizoneTXT.Text)
            ElseIf Me.ProdottiFinitiPNL.Visible Then
                Me.AnagraficaProdottiTableAdapter.SearchByDescrizione(Me.TostaturaDataSet.AnagraficaProdotti, Me.BNDescrizoneTXT.Text)
            End If
        End If
    End Sub

    Private Sub BNUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNUpdateButton.Click

        If Me.ProdottiGrezziPNL.Visible Then
            Me.AnagraficaGrezziTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaGrezzi)
        ElseIf Me.ProdottiFinitiPNL.Visible Then
            Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        End If

    End Sub

    Private Sub CodiceGrezzoTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodiceGrezzoTXT.TextChanged
        If Not (Me.CodiceGrezzoTXT.Text.Equals("") And CodiceGrezzoTXT.Text = Nothing) Then
            Me.DescrizioneGrezzoCMB.SelectedValue = Me.CodiceGrezzoTXT.Text
        End If
    End Sub

    Private Sub IdTipoLavorazioneTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdTipoLavorazioneTXT.TextChanged
        If Not (Me.IdTipoLavorazioneTXT.Text.Equals("") And IdTipoLavorazioneTXT.Text = Nothing) Then
            Me.TipoLavorazioneCMB.SelectedValue = Me.IdTipoLavorazioneTXT.Text
        End If
    End Sub

    Private Sub CodiceFinitoTXT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodiceFinitoTXT.Leave
        If Not CodiceFinitoTXT.ReadOnly Then
            If Not (CodiceFinitoTXT.Text.Equals("") And CodiceFinitoTXT.Text Is Nothing) Then
                If Not Me.AnagraficaProdottiTableAdapter.CountElementByCodice(CodiceFinitoTXT.Text) = 0 Then
                    Me.CodiceFinitoTXT.ReadOnly = True
                    Me.addNewItem = False

                    Me.AnagraficaProdottiTableAdapter.FillByCodice(Me.TostaturaDataSet.AnagraficaProdotti, Me.CodiceFinitoTXT.Text)
                End If
            End If
        End If
    End Sub

    Private Sub DescrizioneGrezzoCMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescrizioneGrezzoCMB.SelectedIndexChanged
        'If CodiceGrezzoTXT.Text.Equals("") Then
        'MsgBox("Prova2", MsgBoxStyle.Information, My.Application.Info.Title)
        Me.CodiceGrezzoTXT.Text = Me.DescrizioneGrezzoCMB.SelectedValue.ToString()
        'End If
    End Sub

    Private Sub IdParametriTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdParametriTXT.TextChanged
        If Not (Me.IdParametriTXT.Text.Equals("") And Me.IdParametriTXT.Text = Nothing) Then
            Dim index As Integer

            If Integer.TryParse(IdParametriTXT.Text, index) Then
                Me.ParametriTostaturaBindingSource.Position = index
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d As New DialogTest
        If d.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Me.IdParametriTXT.Text = d.ParametriDeaultLavorazioneDataGridView.SelectedRows(0).Cells(0).Value
        End If
    End Sub
End Class