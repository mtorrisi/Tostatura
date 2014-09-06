Public Class FormAnagrafiche

    Public Sub New(ByVal operatore As Operatore)
        InitializeComponent()

    End Sub

    Private Sub AnagraficaProdottiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnagraficaProdottiBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.AnagraficaProdottiBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.TostaturaDataSet)
        MsgBox("PROVA: " & Me.CategoriaCMB.SelectedValue)
    End Sub

    Private Sub FormAnagrafiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.CategoriaProdotti'. È possibile spostarla o rimuoverla se necessario.
        'Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.AnagraficaProdotti'. È possibile spostarla o rimuoverla se necessario.
        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)
        Me.ProdottiPNL.Visible = True
    End Sub

    Private Sub idCategoriaTXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idCategoriaTXT.TextChanged
        If (Not idCategoriaTXT.Text.Equals("")) And (Not idCategoriaTXT.Text Is Nothing) Then
            Dim idCategoria As Integer
            idCategoria = Integer.Parse(idCategoriaTXT.Text)
            Me.CategoriaProdottiTableAdapter.FillByid(Me.TostaturaDataSet.CategoriaProdotti, idCategoria)
        Else
            Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)
        End If
    End Sub

    Private Sub ProdottiBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdottiBTN.Click
        Me.ProdottiPNL.Visible = True
        Me.CategoriePNL.Visible = False

        Me.AnagraficaProdottiTableAdapter.Fill(Me.TostaturaDataSet.AnagraficaProdotti)

        Me.BindingNavigator.BindingSource = Me.AnagraficaProdottiBindingSource

    End Sub

    Private Sub CategorieBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategorieBTN.Click
        Me.CategoriePNL.Visible = True
        Me.ProdottiPNL.Visible = False

        Me.CategoriaProdottiTableAdapter.Fill(Me.TostaturaDataSet.CategoriaProdotti)

        Me.BindingNavigator.BindingSource = Me.CategoriaProdottiBindingSource

    End Sub

End Class