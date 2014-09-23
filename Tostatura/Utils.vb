Imports PoohPlcLink
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel


Public Class Utils

    Private PLCLink As New PoohPlcLink.PoohFinsETN()
    Private Shared _instance As Utils
    Private WriteOffset, ReadOffset, ptrFormula As Int16
    Private idFormula As Int16 = 0
    Private nPesataGiornaliera As Int16 = 0
    Private codOp As String = ""
    Private codArtFiglio As String = ""
    Private descrArtFiglio As String = ""
    Private countRigheFormula = 0
    Private ripetizione As Int16
    Private StateInterval As Int32 = 0
    Private PLCDefaultAddress As String = ""
    Private dataInvioFormula As DateTime

    Private dataWrote As Dictionary(Of Int16, Object()) '*******Modifica 25/07/2012************

    Private DM_NewFormula, DM_PesataDone, DM_TitoloFormula, DM_State, DM_Lotto
    Dim connectioString = My.Settings.TostaturaConnectionString()
    Dim cn As New SqlConnection(connectioString)
    Dim reader As SqlDataReader
    Dim countRipetizioni As Int16 = 0
    Friend WithEvents bgw As BackgroundWorker
    Friend WithEvents t, stateTimer As System.Windows.Forms.Timer

    Public Sub writeTitoloFormula(ByVal nFormula As Int16, ByVal nPesata As Int16, ByVal codProdFinito As String, ByVal descrProdFinito As String, ByVal tMix As Int16, _
                                    ByVal qProdotta As Double, ByVal codOperatore As String, ByVal nRipetizioni As Int16, ByVal l() As Object)
        dataWrote = New Dictionary(Of Int16, Object())
        Dim valuesWrote = New Object(23) {}
        countRigheFormula = 0
        ripetizione = 0
        GetOffset(nFormula) 'DM_TitoloFormula
        ptrFormula = WriteOffset

        codProdFinito = Trim(codProdFinito)
        codProdFinito += Space(10 - codProdFinito.Length)
        descrProdFinito += Space(20 - descrProdFinito.Trim().Length)

        Dim TMiXString As String = tMix.ToString().Trim()

        Dim qString As String = qProdotta.ToString().Trim
        If qString.Contains(",") Then ' Se la quantità è double allora xxxxxx|yy
            Dim qStringTmp() As String = qString.Split(",")
            If qStringTmp.Length > 1 Then
                If qStringTmp(0).Length <> 6 Then
                    Dim pad() As Char = {CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0))}
                    For i As Int16 = 6 To 0 Step -1
                        If i - qStringTmp(0).Length > 0 Then
                            pad(i - 1) = qStringTmp(0).Chars(i - qStringTmp(0).Length - 1)
                        Else
                            Exit For
                        End If
                    Next
                    qString = CStr(pad)
                End If
                If qStringTmp(1).Length <> 2 Then
                    qString = qString & qStringTmp(1) & CChar(CStr(0))
                Else
                    qString = qString & qStringTmp(1)
                End If
            End If
        Else
            If qString.Length <> 8 Then
                Dim pad() As Char = {CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0)), CChar(CStr(0))}

                For i As Int16 = 8 To 0 Step -1
                    If i - (8 - qString.Length) > 0 Then
                        pad(i - 1) = qString.Chars(i - (8 - qString.Length) - 1)
                    Else
                        Exit For
                    End If
                Next
                qString = CStr(pad)
            End If
        End If
        Try
            valuesWrote(0) = Convert.ToUInt32(nFormula, 16)
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, nFormula)
            ptrFormula += 1
            idFormula = nFormula
            valuesWrote(1) = Convert.ToUInt32(nPesata, 16)                  '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, nPesata)
            ptrFormula += 1
            nPesataGiornaliera = nPesata
            Dim tmp As UInt32 = 0
            UInt32.TryParse(codProdFinito, tmp)
            valuesWrote(2) = Convert.ToUInt32(tmp, 16)                                  '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, tmp)
            ptrFormula += 1
            valuesWrote(3) = Convert.ToUInt32("0000", 16)
            valuesWrote(4) = Convert.ToUInt32("0000", 16)
            valuesWrote(5) = Convert.ToUInt32("0000", 16)
            valuesWrote(6) = Convert.ToUInt32("0000", 16)
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "0000000000000000")
            ptrFormula += 4
            codArtFiglio = codProdFinito
            valuesWrote(7) = descrProdFinito                                '*******Modifica 25/07/2012************
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, descrProdFinito)
            ptrFormula += 10
            descrArtFiglio = descrProdFinito
            valuesWrote(8) = Convert.ToUInt32(TMiXString, 16)               '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, TMiXString)
            ptrFormula += 1
            valuesWrote(9) = Convert.ToUInt32(qString.Substring(0, 4), 16)  '*******Modifica 25/07/2012************
            valuesWrote(10) = Convert.ToUInt32(qString.Substring(4, 4), 16)
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, qString)
            ptrFormula += 2
            valuesWrote(11) = Convert.ToUInt32(codOperatore, 16)             '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, codOperatore)
            ptrFormula += 1
            codOp = codOperatore
            valuesWrote(12) = Convert.ToUInt32(nRipetizioni, 16)             '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, nRipetizioni)
            ptrFormula += 1
            For i As Int16 = 0 To l.Length - 1
                If i < 5 Then
                    If l(i) Then
                        valuesWrote(13 + i) = Convert.ToUInt32("0001", 16)   '*******Modifica 25/07/2012************
                        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "0001")
                        ptrFormula += 1

                        'sOfBit &= "1"
                    Else
                        valuesWrote(13 + i) = Convert.ToUInt32("0000", 16)   '*******Modifica 25/07/2012************
                        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "0000")
                        ptrFormula += 1
                        'sOfBit &= "0"
                    End If
                ElseIf i < 10 Then
                    valuesWrote(13 + i) = Convert.ToUInt32(l(i), 16)         '*******Modifica 25/07/2012************
                    PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, l(i))
                    ptrFormula += 1
                Else
                    Dim s As String = Trim(l(i))
                    s += Space(20 - s.Length)
                    valuesWrote(13 + i) = s                                  '*******Modifica 25/07/2012************
                    PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, s)
                    ptrFormula += 10
                End If
            Next
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "00000000000000000000000000000000")
            ptrFormula += 8
            dataWrote.Add(WriteOffset, valuesWrote)                         '*******Modifica 25/07/2012************

        Catch ex As Exception
            Throw New Exception(ex.Message)
            MessageBox.Show("ERRORE: " & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub writeRigoFormula(ByVal ordineDosaggio As Int16, ByVal articolo As String, ByVal variante As String, ByVal codiceBilancia As String, ByVal dblx() As String, ByVal intx() As String, ByVal bitx() As Boolean, ByVal puntoDecimale As Int16, ByVal n_silos As Int16)
        'ptrFormula = 7200
        Dim key = ptrFormula
        Dim valuesWrote = New Object(20) {}
        Try
            valuesWrote(0) = Convert.ToUInt32(ordineDosaggio, 16)           '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, ordineDosaggio)
            ptrFormula += 1

            articolo += Space(20 - articolo.Length)
            variante += Space(20 - variante.Length)
            codiceBilancia += Space(20 - codiceBilancia.Length)
            valuesWrote(1) = articolo                                       '*******Modifica 25/07/2012************
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, articolo)
            ptrFormula += 10
            valuesWrote(2) = variante                                       '*******Modifica 25/07/2012************
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, variante)
            ptrFormula += 10
            valuesWrote(3) = codiceBilancia                                 '*******Modifica 25/07/2012************
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, codiceBilancia)
            ptrFormula += 10

            For i As Int16 = 0 To dblx.Length - 1 'scrivo tutti i dbl
                valuesWrote(4 + i) = Convert.ToUInt32(dblx(i), 16)          '*******Modifica 25/07/2012************
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, dblx(i))
                ptrFormula += 1
                'If i = 0 Then 'da eliminare nel definitivo
                'PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ReadOffset + countRigheFormula, dblx(i))  'SIMULO LA SCRITTURA DA PARTE DEL PLC NEI DM DI LETTURA
                'End If
            Next
            For i As Int16 = 0 To intx.Length - 1 'scrivo tutti gli int
                valuesWrote(9 + i) = Convert.ToUInt32(intx(i), 16)          '*******Modifica 25/07/2012************
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, intx(i))
                ptrFormula += 1
            Next

            Dim sOfBit As String = ""
            Dim x As Int16 = 0
            For Each bit As Boolean In bitx
                If bit Then
                    valuesWrote(14 + x) = Convert.ToUInt32("0001", 16)      '*******Modifica 25/07/2012************
                    PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "0001")
                    ptrFormula += 1

                    'sOfBit &= "1"
                Else
                    valuesWrote(14 + x) = Convert.ToUInt32("0000", 16)      '*******Modifica 25/07/2012************
                    PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "0000")
                    ptrFormula += 1
                    'sOfBit &= "0"
                End If
                x += 1
            Next bit
            valuesWrote(19) = Convert.ToUInt32(puntoDecimale, 16)           '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, puntoDecimale)
            ptrFormula += 1
            valuesWrote(20) = Convert.ToUInt32(n_silos, 16)                 '*******Modifica 25/07/2012************
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, n_silos)
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, "00000000")
            ptrFormula += 2
            dataWrote.Add(key, valuesWrote)                                 '*******Modifica 25/07/2012************

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        countRigheFormula += 1
    End Sub
    Public Sub FineFormula(ByVal dataFormula As String)
        Try
            dataInvioFormula = dataFormula
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, "**")
            '*******Modifica 25/07/2012************
            If CheckFormula() Then 'verifica che i dati scritti sono gli stessi che sono stati spediti
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewFormula, "0001")
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_PesataDone, "0000")
                'ptrFormula = 7200
                'simulazione(pesata)
                't = New Timer()
                't.Enabled = True
                't.Interval = 5000

                bgw = New BackgroundWorker()
                bgw.WorkerSupportsCancellation = True
                bgw.RunWorkerAsync()
            Else
                Throw New Exception("Il controllo sui dati inviati non è andato a buon fine." & vbNewLine & "Ripetere nuovamente la pesata.")
            End If
            '**************************************

            'While True
            'Dim s As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_PesataDone, 1)
            'If s.Equals("0001") Then
            ' Dim countRipetizioni As Int16 = Int16.Parse(PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, 1))
            'UpdateStoricoPesate()
            'countRipetizioni -= 1
            'If countRipetizioni > 0 Then
            'Dim tmp As String = countRipetizioni.ToString()
            'While tmp.Length = 4
            ' tmp = "0" & tmp
            'End While
            'PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, tmp) 'riscrivo il numero di rièetizioni
            'PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_PesataDone, "0000")

            'Else            'se non devo fare altre ripetizioni finisco la pesata e scateno l'evento
            'PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewFormula, "0000") '
            'OnStart(New EventArgs)
            'Exit While
            'End If
            'End If
            'System.Threading.Thread.Sleep(1000) 'aspetto 1 sec prima di riciclare 
            'End While

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub bgwScan_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgw.DoWork
        While True
            If bgw.CancellationPending Then
                e.Cancel = True
                Exit Sub
            End If
            Try
                Dim s As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_PesataDone, 1)
                If s.Equals("0001") Then
                    countRipetizioni = Int16.Parse(PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, 1))
                    UpdateStoricoPesate()
                    countRipetizioni -= 1
                    If countRipetizioni > 0 Then
                        Dim tmp As String = countRipetizioni.ToString()
                        While tmp.Length = 4
                            tmp = "0" & tmp
                        End While
                        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, tmp) 'riscrivo il numero di ripetizioni
                        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_PesataDone, "0000")
                        OnRepeatDone(New EventArgs, countRipetizioni)
                    Else            'se non devo fare altre ripetizioni finisco la pesata 
                        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, "0000") '
                        'OnStart(New EventArgs)
                        Exit While
                    End If
                End If
                System.Threading.Thread.Sleep(1000) 'aspetto 1 sec prima di riciclare 
            Catch ex As Exception
                System.Threading.Thread.Sleep(1000) 'aspetto 1 sec prima di riciclare
            End Try

        End While
    End Sub

    Private Sub bgwScan_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewFormula, "0000") '
        If e.Cancelled Then
            'l'utente ha fermato la pesata
            OnPesataDone(New EventArgs, "La pesata è stata fermata alla ripetizione: ", countRipetizioni)
        ElseIf e.Error IsNot Nothing Then
            'si è verificata una eccezione
            OnPesataDone(New EventArgs, "Si è verificato un problema durante la pesata.", countRipetizioni)
        Else
            OnPesataDone(New EventArgs, "", 0) 'rilancio l'evenento di pesata completata senza errori
        End If

    End Sub
    Public Function WriteNewFormulaEnable() As Boolean
        Dim newFormula As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_NewFormula, 1)
        Dim pesataDone As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_PesataDone, 1)
        If newFormula = 0 And pesataDone = 1 Then
            Return True
        ElseIf newFormula = 1 And pesataDone = 0 Then
            Return False
        ElseIf newFormula = 1 And pesataDone = 1 Then
            Return False
        End If
    End Function
    Public Sub New()
        readConfFile()
        CommSettings()
        InitDataMemory()
        stateTimer = New Timer()
        stateTimer.Enabled = True
        stateTimer.Interval = Me.StateInterval
    End Sub

    Private Sub CommSettings()
        Try
            With Me.PLCLink
                .PC_NetNo = 0 'Val(cboLocalNetNo.Text)
                .PC_NodeNo = 1 ' Val(cboLocalNodeNo.Text)
                .PLC_IPAddress = Me.PLCDefaultAddress  '  txtPLCIPAddress.Text
                .PLC_UDPPort = 9600 ' Val(txtPLCUDPPort.Text)
                .PLC_NetNo = 0 ' Val(cboNetNo.Text)
                .PLC_NodeNo = 0 'Val(cboFinsNodeNo.Text)
            End With
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub SetIpAddress(ByVal ip As String)
        Try
            Me.PLCLink.PLC_IPAddress = ip.Trim()
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub InitDataMemory()
        Try
            cn = New SqlConnection(connectioString)
            cn.Open()

            Dim sql As String
            Dim Command As SqlCommand

            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'STATE               ')"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_State = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'NEWFORMULA          ')"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_NewFormula = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE codice_dm = 'PESATADONE          '"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_PesataDone = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE codice_dm = 'LOTTO               '"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_Lotto = reader(0)
            End If
            reader.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t.Tick

        Dim countRipetizioni As Int16 = Int16.Parse(PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, 1))
        ripetizione += 1

        Dim ptr As Int16 = ReadOffset
        Dim quantita(countRigheFormula - 1) As Double
        Dim articoli(countRigheFormula - 1), varianti(countRigheFormula - 1), bilancie(countRigheFormula - 1) As String
        Dim dosaggi(countRigheFormula - 1) As Int16
        For i As Int16 = 0 To countRigheFormula - 1
            Dim tmp As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptr + i, 1)
            quantita(i) = Double.Parse(tmp)
        Next

        Try
            cn = New SqlConnection(connectioString)
            cn.Open()

            Dim sql As String
            Dim Command As SqlCommand

            sql = "SELECT p_decimale, codice_articolo, codice_variante, " & _
            "codice_bilancia, ordine_dosaggio FROM CorpoFormuleView " & _
                  "WHERE (id_formula= " & idFormula & ") AND (codice_prodotto_finito= '" & codArtFiglio & "' AND (data_formula= '" & DateTime.Today & "'))" & _
                  "ORDER BY ordine_dosaggio"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            Dim i As Int16 = 0
            While reader.Read()
                Dim puntoDecimale As Int16 = reader.GetValue(0)
                quantita(i) = quantita(i) / 10 ^ puntoDecimale
                articoli(i) = reader.GetValue(1)
                varianti(i) = reader.GetValue(2)
                bilancie(i) = reader.GetValue(3)
                dosaggi(i) = reader.GetValue(4)
                i += 1
            End While
            reader.Close()
            cn.Close()
            cn.Open()
            For x As Int16 = 0 To countRigheFormula - 1  ' non inserisce verificare
                Dim sql1 As String = "INSERT INTO StoricoPesate" & _
                                            "(codice_lotto, id_formula, n_pesata_giornaliera, codice_prodotto_finito, data_pesata, codice_articolo, codice_variante, codice_bilancia, dbl1, ordine_dosaggio, codice_operatore) " & _
                                            "VALUES ('" & GetGiorno() & GetIdFormula() & GetNPesata(nPesataGiornaliera + ripetizione) & codOp.Substring(2, 2) & "'," & _
                                            " " & idFormula & "," & nPesataGiornaliera + ripetizione & ",'" & codArtFiglio.Trim() & "', '" & DateTime.Now & "', '" & articoli(x) & "'," & _
                                            " '" & varianti(x) & "','" & bilancie(x) & "'," & Str(quantita(x)) & " , " & dosaggi(x) & " , '" & codOp & "')"
                Command = New SqlCommand(sql1, cn)
                Dim c As Int16 = Command.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
        countRipetizioni -= 1
        If countRipetizioni > 0 Then
            Dim tmp As String = countRipetizioni.ToString()
            While tmp.Length = 4
                tmp = "0" & tmp
            End While
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, tmp)
            OnRepeatDone(New EventArgs, countRipetizioni)

        Else            'se non devo fare altre ripetizioni finisco la pesata e scateno l'evento
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_PesataDone, "0001")
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewFormula, "0000") '
            t.Enabled = False
            OnPesataDone(New EventArgs, "", countRipetizioni)
        End If


        '        Try
        ''
        'ptrFormula = ReadOffset
        'Dim nRipetizioni = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula + 21, 1)

        ''-----------Leggo la pesata realmente eseguita dal PLC e la memorizzo sul DB---------------------------------
        'ptrFormula += 22

        'cn = New SqlConnection(connectioString)
        'cn.Open()
        'For x As Int16 = 0 To nRipetizioni - 1
        'While PLCLink.ReadMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, 1) <> "##"'

        'Dim tmp As String = ""
        'Dim puntoDecimale As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula + 46, 1)
        ''Dim ordineDosaggio As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, 1)
        ''ptrFormula += 1
        'Dim articolo As String = PLCLink.ReadMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, 10)
        ''ptrFormula += 10
        ''Dim variante As String = PLCLink.ReadMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, 10)
        ''ptrFormula += 10
        ''Dim bilancia As String = PLCLink.ReadMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, 10)
        ''ptrFormula += 10
        ''Dim dblx() As Double = {0.0, 0.0, 0.0, 0.0, 0.0}
        ''Dim intx() As Int16 = {0, 0, 0, 0, 0}
        ''Dim bitx() As Boolean = {False, False, False, False, False}
        ''Dim nSilos As Int16 = 0


        ''For i As Int16 = 0 To 14
        ''tmp = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, 1)
        ''If i <= 4 Then
        '' dblx(i) = Double.Parse(tmp) / 10 ^ puntoDecimale
        ''ElseIf i <= 9 Then
        ''intx(i - 5) = Int16.Parse(tmp)
        ''ElseIf i <= 14 Then
        ''If tmp = "0000" Then
        '' bitx(i - 10) = False
        ''Else
        ''bitx(i - 10) = True
        ''End If
        ''End If
        ''ptrFormula += 1
        ''Next
        ''puntoDecimale = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, 1)
        ''ptrFormula += 1
        ''nSilos = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula + 1, 1) 'metto +1 perchè il dm del puntoDecimale è stato già letto
        ''ptrFormula += 1

        'Try
        'Dim sql As String
        'Dim Command As SqlCommand'

        'sql = "INSERT INTO StoricoPesate" & _
        '     "(codice_lotto, id_formula, n_pesata_giornaliera, codice_prodotto_finito, data_pesata, codice_articolo, codice_variante, codice_bilancia, dbl1, dbl2, dbl3, " & _
        '     "dbl4, dbl5, int1, int2, int3, int4, int5, bit1, bit2, bit3, bit4, bit5, ordine_dosaggio, codice_operatore) " & _
        '     "VALUES ('" & GetGiorno() & GetIdFormula() & nPesataGiornaliera + GetNPesata(x + 1) & codOp.Substring(2, 2) & "'," & _
        '     " " & idFormula & "," & nPesataGiornaliera + x + 1 & ",'" & codArtFiglio.Trim() & "', '" & DateTime.Now & "', '" & articolo.Trim() & "'," & _
        '     " '" & variante.Trim() & "','" & bilancia.Trim() & "'," & Str(quantita) & "" '," & Str(dblx(1)) & "," & Str(dblx(2)) & "," & Str(dblx(3)) & "," & Str(dblx(4)) & "," & _
        ''" " & Str(intx(0)) & ", " & Str(intx(1)) & ", " & Str(intx(2)) & "," & Str(intx(3)) & ", " & Str(intx(4)) & ", '" & Str(bitx(0)) & "', '" & Str(bitx(1)) & "'," & _
        ''" '" & Str(bitx(2)) & "', '" & Str(bitx(3)) & "','" & Str(bitx(4)) & "', " & ordineDosaggio & ", '" & codOp & "')"
        'Command = New SqlCommand(sql, cn)
        'Command.ExecuteNonQuery()
        'Catch ex As Exception
        ' cn.Close()
        ' MessageBox.Show("Errore durante il salvataggio della pesata sul DB: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ' End Try
        'End While
        ''ptrFormula = 7200
        'Next

        'Catch ex As Exception
        ' MessageBox.Show("Errore in lettura da PLC: " & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Try

        '        cn.Close()

    End Sub

    Private Sub UpdateStoricoPesate()
        ripetizione += 1

        Dim ptr As Int16 = ReadOffset
        Dim quantita(countRigheFormula - 1) As Double
        Dim articoli(countRigheFormula - 1), varianti(countRigheFormula - 1), bilancie(countRigheFormula - 1) As String
        Dim dosaggi(countRigheFormula - 1) As Int16

        For i As Int16 = 0 To countRigheFormula - 1
            Dim tmp As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptr + i, 1)
            'quantita(i) = Double.Parse(tmp)
            Dim q As Double
            Dim akhfguw As Boolean = Double.TryParse(tmp, q)
            quantita(i) = q
        Next

        Try
            Dim cn1 As New SqlConnection(connectioString)
            Dim codBilanciaOld As String = ""
            cn = New SqlConnection(connectioString)
            cn.Open()

            Dim sql As String
            Dim Command As SqlCommand

            sql = "SELECT p_decimale, codice_articolo, codice_variante, " & _
            "codice_bilancia, ordine_dosaggio FROM CorpoFormuleView " & _
                  "WHERE (id_formula= " & idFormula & ") AND " & _
                  "(codice_prodotto_finito= '" & codArtFiglio & "' AND " & _
                  "(data_formula = '" & Mid(dataInvioFormula, 1, 10) & "'))" & _
                  "ORDER BY codice_bilancia, ordine_dosaggio"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            Dim i As Int16 = 0
            Dim puntatoreLettura As Int32 = 0

            While reader.Read()
                Dim puntoDecimale As Int16 = reader.GetValue(0)

                articoli(i) = reader.GetValue(1)
                varianti(i) = reader.GetValue(2)
                bilancie(i) = reader.GetValue(3)
                dosaggi(i) = reader.GetValue(4)

                Dim tmp As String = ""
                Dim q As Double = 0.0
                If (Not codBilanciaOld.Equals(bilancie(i))) Then
                    cn1.Open()

                    Dim sql1 As String
                    Dim Command1 As SqlCommand
                    Dim reader1 As SqlDataReader

                    sql1 = "SELECT offset FROM AnagraficaDataMemory " & _
                            "WHERE (codice_bilancia= " & bilancie(i) & ") AND (tipo_operazione = 'R')"
                    Command1 = New SqlCommand(sql1, cn1)
                    reader1 = Command1.ExecuteReader()
                    If reader1.Read() Then
                        puntatoreLettura = reader1.GetInt32(0)

                        Try
                            tmp = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, puntatoreLettura, 1)
                        Catch ex As Exception
                            If ex.Message.Contains("Buzy") Then
                                System.Threading.Thread.Sleep(500)
                                tmp = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, puntatoreLettura, 1)
                            End If
                        End Try

                        Dim akhfguw As Boolean = Double.TryParse(tmp, q)

                        quantita(i) = q / 10 ^ puntoDecimale
                    End If
                    codBilanciaOld = bilancie(i)
                    reader1.Close()
                    cn1.Close()
                Else
                    puntatoreLettura += 1
                    Try
                        tmp = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, puntatoreLettura, 1)
                    Catch ex As Exception
                        If ex.Message.Contains("Buzy") Then
                            System.Threading.Thread.Sleep(500)
                            tmp = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, puntatoreLettura, 1)
                        End If
                    End Try

                    Dim akhfguw As Boolean = Double.TryParse(tmp, q)

                    quantita(i) = q / 10 ^ puntoDecimale
                End If

                i += 1
            End While
            reader.Close()
            'cn.Close()
            'cn.Open()
            For x As Int16 = 0 To countRigheFormula - 1
                Dim sql1 As String = "INSERT INTO StoricoPesate" & _
                                           "(codice_lotto, id_formula, n_pesata_giornaliera, codice_prodotto_finito, data_pesata, codice_articolo, codice_variante, codice_bilancia, dbl1, ordine_dosaggio, codice_operatore, fine_pesata) " & _
                                           "VALUES ('" & GetGiorno() & GetIdFormula() & GetNPesata(nPesataGiornaliera + ripetizione) & codOp.Substring(2, 2) & "'," & _
                                           " " & idFormula & "," & nPesataGiornaliera + ripetizione & ",'" & codArtFiglio.Trim() & "', @data, '" & articoli(x) & "'," & _
                                           " '" & varianti(x) & "','" & bilancie(x) & "'," & Str(quantita(x)) & " , " & dosaggi(x) & " , '" & codOp & "', @data_fine_pesata)"
                Command = New SqlCommand(sql1, cn)
                Dim ParData As New SqlParameter("@data", SqlDbType.DateTime)
                Dim ParDataFinePesata As New SqlParameter("@data_fine_pesata", SqlDbType.DateTime)
                ParData.Value = dataInvioFormula 'DateTime.Now 'Mario:Ho messo dataInvioFormula per le pesate che cominciano oggi finiscono domani
                ParDataFinePesata.Value = DateTime.Now()
                Command.Parameters.Add(ParData)
                Command.Parameters.Add(ParDataFinePesata)
                Command.ExecuteNonQuery()
            Next
            'Ho finito una pesata --> Setto l'istante di inizio pesata per la ripetizione sucessiva e salvo il codice lotto sul relativo dm 
            sql = "UPDATE CopiaGestionePesate SET inizio_pesata = @data WHERE (id_formula = " & idFormula & ") AND (n_pesata_giornaliera = " & nPesataGiornaliera + ripetizione + 1 & ") " & _
                    "AND (codice_prodotto_finito = '" & codArtFiglio.Trim() & "')"
            Command = New SqlCommand(sql, cn)
            Dim ParDataInizio As New SqlParameter("@data", SqlDbType.DateTime)
            ParDataInizio.Value = DateTime.Now
            Command.Parameters.Add(ParDataInizio)
            Dim c As Int16 = Command.ExecuteNonQuery()
            cn.Close()
            Dim lotto As String = GetGiorno() & GetIdFormula() & GetNPesata(nPesataGiornaliera + ripetizione) & codOp.Substring(2, 2)
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_Lotto, lotto & "00")
        Catch ex As Exception
            If ex.Message.Contains("Buzy") Then
                System.Threading.Thread.Sleep(200)
                Dim lotto As String = GetGiorno() & GetIdFormula() & GetNPesata(nPesataGiornaliera + ripetizione) & codOp.Substring(2, 2)
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_Lotto, lotto & "00")
            Else
                MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")
            End If
        End Try
    End Sub
    'MARIO: Vecchio UpdateStoricoPesate che leggeva i valori di ritorno dlle bilanci in sequenza
    'Private Sub UpdateStoricoPesate()
    'ripetizione += 1

    'Dim ptr As Int16 = ReadOffset
    'Dim quantita(countRigheFormula - 1) As Double
    'Dim articoli(countRigheFormula - 1), varianti(countRigheFormula - 1), bilancie(countRigheFormula - 1) As String
    'Dim dosaggi(countRigheFormula - 1) As Int16

    'For i As Int16 = 0 To countRigheFormula - 1
    'Dim tmp As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ptr + i, 1)
    ''quantita(i) = Double.Parse(tmp)
    ' Dim q As Double
    '  Dim akhfguw As Boolean = Double.TryParse(tmp, q)
    '   quantita(i) = q
    'Next

    'Try
    'cn = New SqlConnection(connectioString)
    'cn.Open()

    'Dim sql As String
    'Dim Command As SqlCommand

    'sql = "SELECT p_decimale, codice_articolo, codice_variante, codice_bilancia, ordine_dosaggio FROM CorpoFormuleView " & _
    '      "WHERE (id_formula= " & idFormula & ") AND (codice_prodotto_finito= '" & codArtFiglio & "' AND (data_formula = '" & Mid(dataInvioFormula, 1, 10) & "'))" & _
    '      "ORDER BY codice_bilancia, ordine_dosaggio"
    'Command = New SqlCommand(sql, cn)
    'reader = Command.ExecuteReader()
    'Dim i As Int16 = 0
    'While reader.Read()
    'Dim puntoDecimale As Int16 = reader.GetValue(0)
    'quantita(i) = quantita(i) / 10 ^ puntoDecimale
    'articoli(i) = reader.GetValue(1)
    'varianti(i) = reader.GetValue(2)
    'bilancie(i) = reader.GetValue(3)
    'dosaggi(i) = reader.GetValue(4)
    'i += 1
    'End While
    'reader.Close()
    ''cn.Close()
    ''cn.Open()
    'For x As Int16 = 0 To countRigheFormula - 1
    'Dim sql1 As String = "INSERT INTO StoricoPesate" & _
    '                        "(codice_lotto, id_formula, n_pesata_giornaliera, codice_prodotto_finito, data_pesata, codice_articolo, codice_variante, codice_bilancia, dbl1, ordine_dosaggio, codice_operatore) " & _
    '                         "VALUES ('" & GetGiorno() & GetIdFormula() & GetNPesata(nPesataGiornaliera + ripetizione) & codOp.Substring(2, 2) & "'," & _
    '                          " " & idFormula & "," & nPesataGiornaliera + ripetizione & ",'" & codArtFiglio.Trim() & "', @data, '" & articoli(x) & "'," & _
    '                           " '" & varianti(x) & "','" & bilancie(x) & "'," & Str(quantita(x)) & " , " & dosaggi(x) & " , '" & codOp & "')"
    'Command = New SqlCommand(sql1, cn)
    'Dim ParData As New SqlParameter("@data", SqlDbType.DateTime)
    ' ParData.Value = dataInvioFormula 'DateTime.Now 'Mario:Ho messo dataInvioFormula per le pesate che cominciano oggi finiscono domani
    '  Command.Parameters.Add(ParData)
    '   Command.ExecuteNonQuery()
    'Next
    ''Ho finito una pesata --> Setto l'istante di inizio pesata per la ripetizione sucessiva 
    'sql = "UPDATE CopiaGestionePesate SET inizio_pesata = @data WHERE (id_formula = " & idFormula & ") AND (n_pesata_giornaliera = " & nPesataGiornaliera + ripetizione + 1 & ") " & _
    '                "AND (codice_prodotto_finito = '" & codArtFiglio.Trim() & "')"
    'Command = New SqlCommand(sql, cn)
    'Dim ParDataInizio As New SqlParameter("@data", SqlDbType.DateTime)
    ' ParDataInizio.Value = DateTime.Now
    '  Command.Parameters.Add(ParDataInizio)
    '   Dim c As Int16 = Command.ExecuteNonQuery()
    '    cn.Close()
    ' Catch ex As Exception
    '      MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")
    '   End Try
    'End Sub
    Public Event PesataDone(ByVal msg As String, ByVal rip As Int16)

    Protected Overridable Sub OnPesataDone(ByVal e As EventArgs, ByVal msg As String, ByVal rip As Int16)
        RaiseEvent PesataDone(msg, rip)
    End Sub
    Public Event RipetizioneDone(ByVal rip As Int16)

    Protected Overridable Sub OnRepeatDone(ByVal e As EventArgs, ByVal rip As Int16)
        RaiseEvent RipetizioneDone(rip)
    End Sub


    Public Function GetGiorno() As String
        Dim InizioAnno As Date
        InizioAnno = "01/01/" & Now.Year
        Dim Giorno As String = CStr(DateDiff(DateInterval.DayOfYear, InizioAnno, dataInvioFormula) + 1)
        While Giorno.Length < 3
            Giorno = "0" & Giorno
        End While
        Dim x As DateTime = DateTime.Now
        Giorno = Giorno & x.ToString("yy")
        Return Giorno
    End Function
    Public Function GetIdFormula() As String
        Dim idF As String
        'idF = idFormula  'MARIO cambiare con codArtFiglio.trim()
        idF = codArtFiglio.Trim()
        While idF.Length < 4
            idF = "0" & idF
        End While
        Return idF
    End Function

    Public Function GetNPesata(ByVal rip) As String
        Dim nFormula As String
        nFormula = rip
        While nFormula.Length < 3
            nFormula = "0" & nFormula
        End While
        Return nFormula
    End Function

    Private Sub GetOffset(ByVal nFormula As Int16)
        ' Dim offset As Int16 = 0
        Try
            cn = New SqlConnection(connectioString)
            cn.Open()

            Dim sql As String
            Dim Command As SqlCommand

            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'STARTFORMULA        ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                WriteOffset = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'READFORMULA         ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                ReadOffset = reader(0)
            End If
            reader.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            reader.Close()
            Throw ex
        End Try
        '        Return offset

    End Sub

    Private Sub stateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stateTimer.Tick
        Try
            Dim s As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_State, 1)
            If s.Equals("0001") Then
                PLCLink.WriteMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, Me.DM_State, "0000")
            End If
        Catch ex As Exception
            If Not ex.Message.Contains("Buzy") Then
                MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End Try
    End Sub

    Private Sub readConfFile()

        Dim path As String = "C:\its\PlcConfig.TXT"

        ' se non trova il file lo crea con un valore di INTERVAL = 60 s, PLC IP ADDRESS = 192.168.0.16
        If Not File.Exists(path) Then
            Dim fs As New FileStream("C:\its\PlcConfig.TXT", FileMode.Create, FileAccess.Write)
            Dim s As New StreamWriter(fs)
            s.BaseStream.Seek(0, SeekOrigin.End)

            s.WriteLine("INTERVAL = 60000")
            s.WriteLine("PLC IP ADDRESS = 192.168.0.16")

            s.Close()
        End If  ' File trovato

        ' Legge il file sorgente in un array di stringhe 
        ' ogni riga del file è una stringa dell'array
        Dim lines() As String = File.ReadAllLines(path)
        Dim count As Int16 = 0 ' lunghezza dell'array

        ' Elimina le righe vuote, spostando le righe non vuote
        ' verso indici più bassi
        Try
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Trim.Length > 0 Then
                    lines(count) = lines(i)
                    count += 1
                End If
            Next
        Catch
        End Try
        For Each l As String In lines
            Try
                If l.Contains("INTERVAL") Then
                    Me.StateInterval = Integer.Parse(l.Substring(l.IndexOf("=") + 1).Trim())
                ElseIf l.Contains("PLC IP ADDRESS") Then
                    Me.PLCDefaultAddress = l.Substring(l.IndexOf("=") + 1).Trim()
                End If
            Catch
                Me.StateInterval = 60
            End Try

        Next l
    End Sub
    Public Sub StopPesata()
        bgw.CancelAsync()
        Try
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, "0000")
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, Me.DM_PesataDone, "0001")
        Catch ex As Exception
            MessageBox.Show("Errore nello stop della pesaata." & vbNewLine, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SendRipToPLC(ByVal diffRip As Int16)
        Dim rip As Int16 = 0
        Try
            rip = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, Me.WriteOffset + 21, 1)
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, rip + diffRip)
        Catch ex As Exception
            If ex.Message.Contains("Buzy") Then
                System.Threading.Thread.Sleep(500)
                rip = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, Me.WriteOffset + 21, 1)
                PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset + 21, rip + diffRip)
            Else
                MessageBox.Show("Errore nell'aggiornamento delle ripetizioni della pesata." & vbNewLine, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    'chiamata al cambio opperatore serve se c'è una pesasta in corso per modificare l'operatore con quello nuovo
    Public Sub changeOperatore(ByVal codOperatore As String)
        Try
            Dim pesataDone As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_PesataDone, 1)
            If pesataDone = 0 Then
                Me.codOp = codOperatore
            End If
        Catch ex As Exception
            If ex.Message.Contains("Buzy") Then
                System.Threading.Thread.Sleep(500)
                Dim pesataDone As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_PesataDone, 1)
                If pesataDone = 0 Then
                    Me.codOp = codOperatore
                End If
            Else
                MessageBox.Show("Errore nell'aggiornamento delle ripetizioni della pesata." & vbNewLine, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

    End Sub

    Public Sub UpdateOffset(ByVal newoffset As Int32, ByVal fineBilancia As Boolean)
        If fineBilancia Then
            Try
                PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, "##")
            Catch ex As Exception
                If ex.Message.Contains("Buzy") Then
                    System.Threading.Thread.Sleep(500)
                    PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, "##")
                End If
            End Try
        End If

        ptrFormula = newoffset
    End Sub

    Private Function CheckFormula() As Boolean
        Dim result As Boolean = True
        For Each kvp As KeyValuePair(Of Short, Object()) In dataWrote
            Dim offset As Int16 = kvp.Key
            'For i As Int16 = 0 To tmp.Length - 1
            For Each obj As Object In kvp.Value
                Select Case obj.GetType().Name
                    Case "String"
                        Try
                            Dim fromPLC As String = PLCLink.ReadMemoryString(PoohFinsETN.MemoryTypes.DM, offset, obj.ToString().Length / 2)
                            'MsgBox("String")
                            If (Not obj.ToString().Equals(fromPLC)) Then
                                result = False
                                MsgBox("CHECK ERROR STRING " & obj.ToString() & fromPLC)
                            End If
                            offset += obj.ToString().Length / 2
                        Catch ex As Exception
                            MsgBox("Exception A")
                        End Try
                    Case "UInt32"
                        Try
                            Dim fromPLC As Integer() = PLCLink.ReadMemoryWord(PoohFinsETN.MemoryTypes.DM, offset, 1, PoohFinsETN.DataTypes.UnSignBIN)
                            'If (Not obj.Equals(fromPLC)) Then
                            If Not obj = fromPLC(0) Then
                                MsgBox("CHECK ERROR UINT32 " & obj & " " & fromPLC(0) & " " & offset)
                                result = False
                            End If
                            offset += 1
                        Catch ex As Exception
                            MsgBox("Exception B")
                        End Try
                    Case Else
                        MsgBox("Other")
                End Select
            Next obj
            'Exit For
        Next kvp
        If (result) Then
            'MsgBox("Controllo ok")
            Return result
        Else
            'MsgBox("Controllo KOOOOOO")
            Return result
        End If
    End Function
End Class
