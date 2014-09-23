Public Class FormParametriDefault

    Private Sub ParametriTostaturaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParametriTostaturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ParametriTostaturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TostaturaDataSet)

    End Sub

    Private Sub FormParametriDefault_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ParametriTostatura'. È possibile spostarla o rimuoverla se necessario.
        Me.ParametriTostaturaTableAdapter.Fill(Me.TostaturaDataSet.ParametriTostatura)

    End Sub
End Class