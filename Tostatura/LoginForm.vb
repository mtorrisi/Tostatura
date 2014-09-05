Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Public Class LoginForm

    Dim Esito_Ok As Boolean = False

    Public changeOp As Boolean = False
    Public operatore As Operatore
    Private connectionString As String
    Private reader As SqlDataReader
    ' TODO: inserire il codice per l'esecuzione dell'autenticazione personalizzata tramite il nome utente e la password forniti 
    ' (Vedere http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'entità personalizzata può essere quindi collegata all'entità del thread corrente nel modo seguente: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' dove CustomPrincipal è l'implementazione di IPrincipal utilizzata per eseguire l'autenticazione. 
    ' My.User restituirà quindi informazioni sull'identità incapsulate nell'oggetto CustomPrincipal,
    ' quali il nome utente, il nome visualizzato e così via.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'If Not fattiv Is Nothing And Not Esito_Ok Then Exit Sub

        Dim cn As New SqlConnection()
        Dim cmd As New SqlCommand()
        Dim nome As String
        Dim idOperatore, codiceRuolo As Int16


        If Not OperatoreTXT.Text.Trim().Equals("") Then

            Try
                connectionString = My.Settings.TostaturaConnectionString

                cn.ConnectionString = connectionString

                cn.Open()

                Dim sql As String = "SELECT id, nome, password, id_ruolo" & _
                " FROM Operatori WHERE (nome = '" & OperatoreTXT.Text.ToString() & "') AND (password = '" & PasswordTXT.Text.ToString().Trim() & "');"
                cmd.CommandText = sql
                cmd.Connection = cn


                reader = cmd.ExecuteReader()
                'reader.FieldCount

                'Do While reader.Read()
                If reader.Read() Then

                    idOperatore = reader.GetInt32(0)
                    nome = reader.GetString(1)
                    codiceRuolo = reader.GetInt32(3)
                    cn.Close()
                    reader.Close()

                    If (operatore Is Nothing) Then
                        'operatore = New Operatore(codiceOperatore, nome, codiceRuolo)
                        'If (Not changeOp) Then 'se non sto cambiando Operatore
                        Dim f As New MainForm(operatore)
                        f.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Operatore e/o password errati. Riprovare.", MsgBoxStyle.Exclamation, "Attenzione")
                End If

            Catch ex As Exception

            cn.Close()
                reader.Close()
            End Try

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.OperatoriTableAdapter.FillByNome(Me.TostaturaDataSet.Operatori)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoginForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()

    End Sub
End Class
