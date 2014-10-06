Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class TostaturaForm

    Dim connectioString = My.Settings.TostaturaConnectionString()
    Dim cn As New SqlConnection(connectioString)
    Dim reader As SqlDataReader
    Dim objTransaction As System.Data.SqlClient.SqlTransaction

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

    Private Sub tostaturaBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tostaturaBTN.Click
        'Me.tostaturaBTN.Text = "Attendere Invio Dati"
        Me.tostaturaBTN.Enabled = False
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        statusLBL.Visible = True

        Dim InputTostatura As InputTostatura = LeggiValori()
        If Not InputTostatura.CodiceFinito.Equals("") Then
            'TODO Invio Input al PLC             
            'If u.WriteDataEnabled() Then
            '************* INVIO Dati Tostatua al PLC ****************
            u.WriteData(InputTostatura)
            '*********************************************************
            'TODO Check Dati Inviati
            If u.CheckDatiTostatura(InputTostatura) Then
                
                'TODO Salvataggio Tabella InpuTostatura
                Try
                    Dim sql As String
                    cn = New SqlConnection(connectioString)
                    cn.Open()
                    Dim cmd As SqlCommand
                    objTransaction = cn.BeginTransaction
                    'sql = "INSERT INTO StoricoInputTostatura (id_operatore, data_inizio, codice_prodotto_finito, codice_prodotto_grezzo, umidita_prodotto, umidita_esterna, temperatura_forno, tempo_cottura, quantita_carico, id_tipo_lavorazione) " & _
                    '                            "VALUES (" & InputTostatura.CodiceOperatore & ", @data, '" & InputTostatura.CodiceFinito.Trim() & "', '" & InputTostatura.CodiceGrezzo.Trim() & "', " & CDbl(InputTostatura.PercentualeUmiditaProdotto) & ", " & CDbl(InputTostatura.PercentualeUmiditaEsterna) & ", " & _
                    '                            "" & CDbl(InputTostatura.TemperaturaForno) & ", " & CDbl(InputTostatura.TempoCottura) & ", " & CDbl(InputTostatura.QuatitaCarico) & " , " & InputTostatura.TipoLavorazione & " )"
                    sql = "INSERT INTO StoricoInputTostatura (id_operatore, data_inizio, codice_prodotto_finito, codice_prodotto_grezzo, umidita_prodotto, umidita_esterna, temperatura_forno, tempo_cottura, quantita_carico, id_tipo_lavorazione) " & _
                                                "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)"
                    cmd = New SqlCommand(sql, cn, objTransaction)
                    With cmd.Parameters
                        .Add("@p1", SqlDbType.Int).Value = InputTostatura.CodiceOperatore
                        .Add("@p2", SqlDbType.DateTime).Value = Date.Now
                        .Add("@p3", SqlDbType.VarChar).Value = InputTostatura.CodiceFinito
                        .Add("@p4", SqlDbType.VarChar).Value = InputTostatura.CodiceGrezzo
                        .Add("@p5", SqlDbType.Float).Value = InputTostatura.PercentualeUmiditaProdotto
                        .Add("@p6", SqlDbType.Float).Value = InputTostatura.PercentualeUmiditaEsterna
                        .Add("@p7", SqlDbType.Float).Value = InputTostatura.TemperaturaForno
                        .Add("@p8", SqlDbType.Float).Value = InputTostatura.TempoCottura
                        .Add("@p9", SqlDbType.Float).Value = InputTostatura.QuatitaCarico
                        .Add("@p10", SqlDbType.Int).Value = InputTostatura.TipoLavorazione
                    End With

                    cmd.ExecuteNonQuery()

                    objTransaction.Commit()
                    cn.Close()
                Catch ex As Exception
                    objTransaction.Rollback()
                    cn.Close()
                    MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")

                End Try
                u.FineFormula()
                Me.statusLBL.ForeColor = System.Drawing.Color.IndianRed
                statusLBL.Text = "Tostatura in corso..."
                'TODO Start Timer tostatura completa
                
            End If

            'End If

        Else
            MsgBox("Errore nella lettura dei campi")
        End If
        Me.tostaturaBTN.ForeColor = System.Drawing.SystemColors.HotTrack
        MessageBox.Show("La formula è stata inviata correttamente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.tostaturaBTN.Text = "Avvia Tostatura"
    End Sub

    Private Sub Utils_PesataDone(ByVal msg As String) Handles u.TostaturaDone
        '... 
        Me.statusLBL.Visible = False
        Me.statusLBL.ForeColor = System.Drawing.Color.ForestGreen
        Me.statusLBL.Text = "Invio formula in corso..."
        Windows.Forms.Cursor.Current = Cursors.Default
        'Me.AnagraficaFormuleTableAdapter.Fill(Me.PLCDBDataSet.AnagraficaFormule)
        CodOpLbl.Text = operatore.CodiceOperatore
        OpLbl.Text = operatore.NomeOperatore
        If msg.Equals("") Then
            MessageBox.Show("Tostatura Eseguita", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Else
            
            MessageBox.Show("Tostatura non eseguita" & vbNewLine & vbNewLine & msg, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            
        End If

        
    End Sub

    Function LeggiValori() As InputTostatura
        Dim idTostatura As Integer = GetIdTostatura()
        Dim uEsterna As Double = 0.0
        Dim uProdotto As Double = 0.0
        Dim qCarico As Integer = 0
        Dim tempForno As Double = 0.0
        Dim tCottura As Integer = 0
        Dim tipoLavorazione As Integer = 0

        Dim result As New InputTostatura
        If Not idTostatura = 0 Then
            With result
                .IdTostatura = idTostatura
                .CodiceFinito = Me.CodiceFinitoTXT.Text
                .CodiceGrezzo = Me.codiceGrezzoTXT.Text
                .Datainizio = CDate(Date.Now)
                .Operatore = Me.operatore.CodiceOperatore
                .PercentualeUmiditaEsterna = Double.Parse(Me.umidEsternaTXT.Text)
                .PercentualeUmiditaProdotto = Double.Parse(Me.umidProdottoTXT.Text)
                .QuatitaCarico = Integer.Parse(Me.qCaricoTXT.Text)
                .TemperaturaForno = Double.Parse(Me.tempFornoTXT.Text)
                .TempoCottura = Integer.Parse(Me.tCotturaTXT.Text)
                .TipoLavorazione = Integer.Parse(Me.idLavorazioneTXT.Text)
                .CodiceOperatore = Integer.Parse(Me.CodOpLbl.Text)
            End With
        End If

        Return result
    End Function
    Private Function GetIdTostatura() As Integer
        Dim id As Integer = 0
        cn = New SqlConnection(connectioString)
        Try
            cn.Open()

            Dim sql As String
            Dim Command As SqlCommand

            sql = "SELECT IDENT_CURRENT('StoricoInputTostatura');"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                id = reader(0)
            End If
            reader.Close()
        Catch ex As Exception

        End Try

        Return id
    End Function

End Class