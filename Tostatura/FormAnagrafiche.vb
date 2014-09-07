Public Class FormAnagrafiche

    Dim operatore As Operatore
    Dim addNewItem As Boolean = False

    Public Sub New(ByVal operatore As Operatore)
        InitializeComponent()
        Me.operatore = operatore

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.addNewItem = True
        Me.CodiceTXT.ReadOnly = False
    End Sub

    Private Sub AnagraficaProdottiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagraficaProdottiBindingNavigatorSaveItem.Click

        If ProdottiPNL.Visible Then
            Dim oldCodice As String
            Me.Validate()
            'Me.AnagraficaProdottiBindingSource.EndEdit()
            If addNewItem Then
                Me.AnagraficaProdottiTableAdapter.Insert(CodiceTXT.Text, DescrizioneTXT.Text, CategoriaCMB.SelectedValue, CalibroTXT.Text)
                Me.addNewItem = False
                Me.CodiceTXT.ReadOnly = True
            Else
                Me.AnagraficaProdottiTableAdapter.UpdateProdotto(DescrizioneTXT.Text, CategoriaCMB.SelectedValue, CalibroTXT.Text, CodiceTXT.Text)
            End If
            oldCodice = Me.CodiceTXT.Text
            Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
            Dim index As Integer = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)
            If index <> -1 Then
                Me.BindingNavigator.BindingSource.Position = index
            End If
        End If

        
    End Sub

    Private Sub FormAnagrafiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.CategoriaProdotti'. È possibile spostarla o rimuoverla se necessario.
        Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.AnagraficaProdotti'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        Me.ProdottiPNL.Visible = True

        If Me.operatore.CodiceRuolo = 3 Then
            Me.CtlAvanzatiGPB.Visible = True
        Else
            Me.CtlAvanzatiGPB.Visible = False
        End If

    End Sub

    Private Sub idCategoriaTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idCategoriaTXT.TextChanged
        'If (Not idCategoriaTXT.Text.Equals("")) And (Not idCategoriaTXT.Text Is Nothing) Then
        'Dim idCategoria As Integer
        'idCategoria = Integer.Parse(idCategoriaTXT.Text)
        'Me.CategoriaProdottiTableAdapter.FillByid(Me.TostaturaDataSet.CategoriaProdotti, idCategoria)
        'Else
        'Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)
        'End If
        If (Not idCategoriaTXT.Text.Equals("")) And (Not idCategoriaTXT.Text Is Nothing) Then
            Me.CategoriaCMB.SelectedValue = Integer.Parse(Me.idCategoriaTXT.Text)

        End If

    End Sub

    Private Sub ProdottiBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdottiBTN.Click
        Me.ProdottiPNL.Visible = True
        Me.CategoriePNL.Visible = False

        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        Me.BindingNavigator.BindingSource = Me.AnagraficaProdottiBindingSource

        Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)

    End Sub

    Private Sub CategorieBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategorieBTN.Click
        Me.CategoriePNL.Visible = True
        Me.ProdottiPNL.Visible = False

        Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)

        Me.BindingNavigator.BindingSource = Me.CategoriaProdottiBindingSource

    End Sub
    Private Sub CodiceTXT_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodiceTXT.Leave
        If Not CodiceTXT.ReadOnly Then
            If Not (CodiceTXT.Text.Equals("") And CodiceTXT.Text Is Nothing) Then
                If Not Me.AnagraficaProdottiTableAdapter.CountElemenByCodice(CodiceTXT.Text) = 0 Then
                    Me.CodiceTXT.ReadOnly = True
                    Me.addNewItem = False

                    Me.AnagraficaProdottiTableAdapter.FillByCodice(Me.TostaturaDataSet.AnagraficaProdotti, Me.CodiceTXT.Text)
                End If
            End If
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim message As String = ""
        Dim item As String = ""
        Dim oldCodice As String = ""
        Dim index As Integer = -1
        If ProdottiPNL.Visible Then
            message = "il prodotto"
            item = "Codice: " & CodiceTXT.Text & vbNewLine & "Descrizione: " & DescrizioneTXT.Text
            oldCodice = Me.CodiceTXT.Text
        End If

        If MessageBox.Show("Stai per rimuovere" & message & ": " & vbNewLine & item & vbNewLine & "Confermi l'eliminazione?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            index = Me.BindingNavigator.BindingSource.Position - 1
            Me.AnagraficaProdottiTableAdapter.DeleteByCodice(Me.CodiceTXT.Text)
            Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)

        Else
            MessageBox.Show("Eliminazione annullata.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            index = Me.BindingNavigator.BindingSource.Find("codice", oldCodice)

        End If
        If index <> -1 Then
            Me.BindingNavigator.BindingSource.Position = index
        End If
    End Sub
End Class