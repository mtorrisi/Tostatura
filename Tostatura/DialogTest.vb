Imports System.Windows.Forms

Public Class DialogTest

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'TostaturaDataSet.ParametriDeaultLavorazione'. È possibile spostarla o rimuoverla se necessario.
        Me.ParametriDeaultLavorazioneTableAdapter.Fill(Me.TostaturaDataSet.ParametriDeaultLavorazione)
    End Sub
End Class
