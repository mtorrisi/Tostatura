Imports PoohPlcLink
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Reflection


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

    Private dataWrote(9) As Object

    Private DM_NewTostatura, DM_TostaturaDone, DM_TitoloFormula, DM_State, DM_NewAllarme, DM_AllarmeLetto, DM_ParametriAllarme
    Dim connectioString = My.Settings.TostaturaConnectionString()
    Dim cn As New SqlConnection(connectioString)
    Dim reader As SqlDataReader
    Dim countRipetizioni As Int16 = 0
    Friend WithEvents bgw As BackgroundWorker
    Friend WithEvents t, stateTimer As System.Windows.Forms.Timer

    Sub WriteData(ByVal inputTostatura As InputTostatura)
        ptrFormula = WriteOffset
        inputTostatura.CodiceFinito += Space(16 - inputTostatura.CodiceFinito.Trim().Length)
        inputTostatura.CodiceGrezzo += Space(16 - inputTostatura.CodiceGrezzo.Trim().Length)

        Dim uProdotto As Integer = inputTostatura.PercentualeUmiditaProdotto * 10
        Dim uEsterna As Integer = inputTostatura.PercentualeUmiditaEsterna * 10
        Dim tempForno As Integer = inputTostatura.TemperaturaForno * 10
        Dim qCarico As Integer = inputTostatura.QuatitaCarico * 10
        Try
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.IdTostatura)
            dataWrote(0) = inputTostatura.IdTostatura
            ptrFormula += 1
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.CodiceFinito)
            dataWrote(1) = inputTostatura.CodiceFinito
            ptrFormula += inputTostatura.CodiceFinito.Length / 2
            PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.CodiceGrezzo)
            dataWrote(2) = inputTostatura.CodiceGrezzo
            ptrFormula += inputTostatura.CodiceGrezzo.Length / 2
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, uProdotto)
            dataWrote(3) = uProdotto
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, uEsterna)
            dataWrote(4) = uEsterna
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, tempForno)
            dataWrote(5) = tempForno
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.TempoCottura)
            dataWrote(6) = inputTostatura.TempoCottura
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, qCarico)
            dataWrote(7) = qCarico
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.TipoLavorazione)
            dataWrote(8) = inputTostatura.TipoLavorazione
            ptrFormula += 1
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, ptrFormula, inputTostatura.CodiceOperatore)
            dataWrote(9) = inputTostatura.CodiceOperatore
            'ptrFormula += 1
            'PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, "**")
        Catch ex As Exception

        End Try

    End Sub

    Function CheckDatiTostatura(ByVal inputTostatura As InputTostatura) As Boolean
        ptrFormula = WriteOffset
        inputTostatura.CodiceFinito += Space(16 - inputTostatura.CodiceFinito.Trim().Length)
        inputTostatura.CodiceGrezzo += Space(16 - inputTostatura.CodiceGrezzo.Trim().Length)

        Dim fromPLC As String = ""

        Dim uProdotto As Integer = inputTostatura.PercentualeUmiditaProdotto * 10
        Dim uEsterna As Integer = inputTostatura.PercentualeUmiditaEsterna * 10
        Dim tempForno As Integer = inputTostatura.TemperaturaForno * 10
        Dim qCarico As Integer = inputTostatura.QuatitaCarico * 10
        Try
            fromPLC = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, 3000, 24)
        Catch ex As Exception

        End Try
        Dim tmp() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        If Not fromPLC.Length = 0 Then

            Dim j As Int16 = 0
            For i As Int16 = 0 To fromPLC.Length - 1 Step 4
                tmp(i / 4) = fromPLC.Substring(i, 4)
            Next
            Dim dataRead() As String = {"", "", "", "", "", "", "", "", "", ""}
            dataRead(j) = tmp(0)
            j += 1
            For i As Int16 = 1 To 8
                dataRead(j) += tmp(i)
            Next
            j += 1
            For i As Int16 = 9 To 16
                dataRead(j) += tmp(i)
            Next
            j += 1
            For i As Int16 = 17 To tmp.Length - 1
                dataRead(j) += tmp(i)
                j += 1
            Next
            j = 0
            For Each obj As Object In dataWrote
                If obj.GetType().Name.Equals("String") Then
                    Dim str As String = HexToStr(dataRead(j))
                    If Not obj.ToString().Equals(str) Then
                        MsgBox("CHECK ERROR STRING " & obj.ToString() & dataRead(j))
                        Return False
                    End If
                Else
                    If Not obj = dataRead(j) Then
                        MsgBox("CHECK ERROR UINT32 " & obj & " " & dataRead(0))
                        Return False
                    End If
                End If
                j += 1
            Next

        End If
        
        Return True
    End Function

    Public Sub FineFormula()
        Try
            'PLCLink.WriteMemoryString(PoohFinsETN.MemoryTypes.DM, ptrFormula, "**")
            
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewTostatura, "0001")
            PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_TostaturaDone, "0000")
            
            bgw = New BackgroundWorker()
            bgw.WorkerSupportsCancellation = True
            bgw.RunWorkerAsync()
           
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
                Dim tostaturaDone As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_TostaturaDone, 1)
                Dim newAllarme As String = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_NewAllarme, 1)
                If tostaturaDone.Equals("0001") Then
                    SalvaDatiTostatura()

                    Exit While
                ElseIf newAllarme.Equals("0001") Then
                    SalvaDatiAllarme()
                    PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewAllarme, "0000")
                End If
                
                System.Threading.Thread.Sleep(1000) 'aspetto 1 sec prima di riciclare 
            Catch ex As Exception
                System.Threading.Thread.Sleep(1000) 'aspetto 1 sec prima di riciclare
            End Try

        End While
    End Sub

    Private Sub bgwScan_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        PLCLink.WriteMemory(PoohFinsETN.MemoryTypes.DM, DM_NewTostatura, "0000") '
        If e.Cancelled Then
            'l'utente ha fermato la pesata
            OnTostaturaDone(New EventArgs, "La tostatura è stata fermata.")
        ElseIf e.Error IsNot Nothing Then
            'si è verificata una eccezione
            OnTostaturaDone(New EventArgs, "Si è verificato un problema durante la pesata.")
        Else
            OnTostaturaDone(New EventArgs, "") 'scateno l'evenento di tostatura completata senza errori
        End If

    End Sub
    Public Function WriteDataEnabled() As Boolean
        Dim newFormula As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_NewTostatura, 1)
        Dim pesataDone As Int16 = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_TostaturaDone, 1)
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
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE codice_dm = 'NEWTOSTATURA        '"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_NewTostatura = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE codice_dm = 'TOSTATURADONE       '"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                Me.DM_TostaturaDone = reader(0)
            End If
            reader.Close()
            'sql = "SELECT offset FROM AnagraficaDataMemory WHERE codice_dm = 'LOTTO               '"
            'Command = New SqlCommand(sql, cn)
            'reader = Command.ExecuteReader()
            'If reader.Read() Then
            '    Me.DM_Lotto = reader(0)
            'End If
            'reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'START               ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                WriteOffset = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'READOUTPUT          ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                ReadOffset = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'NEWALLARME          ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                DM_NewAllarme = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'ALLARMELETTO        ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                DM_AllarmeLetto = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'PARAMETRIALLARME    ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                DM_ParametriAllarme = reader(0)
            End If
            reader.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Event TostaturaDone(ByVal msg As String)

    Protected Overridable Sub OnTostaturaDone(ByVal e As EventArgs, ByVal msg As String)
        RaiseEvent TostaturaDone(msg)
    End Sub
    'Public Event RipetizioneDone(ByVal rip As Int16)

    'Protected Overridable Sub OnRepeatDone(ByVal e As EventArgs, ByVal rip As Int16)
    '    RaiseEvent RipetizioneDone(rip)
    'End Sub


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

            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'START               ')" 'AND (id_formula= " & nFormula & ")"
            Command = New SqlCommand(sql, cn)
            reader = Command.ExecuteReader()
            If reader.Read() Then
                WriteOffset = reader(0)
            End If
            reader.Close()
            sql = "SELECT offset FROM AnagraficaDataMemory WHERE (codice_dm = 'READOUTPUT          ')" 'AND (id_formula= " & nFormula & ")"
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
    Public Function HexToStr(ByVal Data As String) As String
        Dim com As String = ""
        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW(CInt("&H" & Data.Substring(x, 2)))
        Next
        Return com
    End Function

    Private Sub SalvaDatiTostatura()
        Dim fromPLC As String = ""
        Dim idTostatura As String = ""
        Try
            idTostatura = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset, 1)
            fromPLC = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, ReadOffset + 1, 43)
        Catch ex As Exception

        End Try

        Dim outputTostura = New OutputTostatura()
        outputTostura.IdTostatura = Integer.Parse(idTostatura)
        outputTostura.TemperaturaPreCarico = CDbl(Integer.Parse(fromPLC.Substring(0, 4)) / 10)
        outputTostura.InizioCarico = HexToStr(fromPLC.Substring(4, 40))
        outputTostura.TemperaturaInCarico = CDbl(Integer.Parse(fromPLC.Substring(44, 4)) / 10)
        outputTostura.FineSostaForno = HexToStr(fromPLC.Substring(48, 40))
        outputTostura.ScaricoGiostra = HexToStr(fromPLC.Substring(88, 40))
        outputTostura.SostaGiostra = Integer.Parse(fromPLC.Substring(128, 4))
        outputTostura.ScaricoCarrello = HexToStr(fromPLC.Substring(132, 40))

        Try
            Dim sql As String
            cn = New SqlConnection(connectioString)
            cn.Open()
            Dim cmd As SqlCommand
            'sql = "INSERT INTO StoricoOutputTostatura (id_tostatura, temp_pre_carico, inizio_carico, temp_in_carico, data_fine_sosta_forno, avvio_scarico_giostra, tempo_sosta_giostra, avvio_scarico_carrello) " & _
            '                            "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)"
            sql = "INSERT INTO StoricoOutputTostatura (id_tostatura, temp_pre_carico, temp_in_carico, tempo_sosta_giostra) " & _
                                        "VALUES (@p1,@p2,@p3,@p4)"
            cmd = New SqlCommand(sql, cn)
            With cmd.Parameters
                .Add("@p1", SqlDbType.Int).Value = outputTostura.IdTostatura
                .Add("@p2", SqlDbType.Float).Value = outputTostura.TemperaturaPreCarico
                '.Add("@p3", SqlDbType.DateTime).Value = outputTostura.InizioCarico
                .Add("@p3", SqlDbType.Float).Value = outputTostura.TemperaturaInCarico
                '.Add("@p5", SqlDbType.DateTime).Value = outputTostura.FineSostaForno
                '.Add("@p6", SqlDbType.DateTime).Value = outputTostura.ScaricoGiostra
                .Add("@p4", SqlDbType.Int).Value = outputTostura.SostaGiostra
                '.Add("@p8", SqlDbType.DateTime).Value = outputTostura.ScaricoCarrello
            End With

            cmd.ExecuteNonQuery()

            'objTransaction.Commit()
            cn.Close()
        Catch ex As Exception
            'objTransaction.Rollback()
            cn.Close()
            MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")

        End Try
    End Sub
    Private Sub SalvaDatiAllarme()
        Dim fromPLC As String = ""
        Dim idTostatura As String = ""
        Try
            idTostatura = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, WriteOffset, 1)
            fromPLC = PLCLink.ReadMemory(PoohFinsETN.MemoryTypes.DM, DM_ParametriAllarme + 1, 12)
        Catch ex As Exception
            MsgBox("ErrorEventArgs nella lettura dell'allarme")
        End Try

        Dim allarme As Allarme = New Allarme()
        allarme.IdTostatura = Integer.Parse(idTostatura)
        allarme.DataAllarme = HexToStr(fromPLC.Substring(0, 40))
        allarme.Valvola = CDbl(Integer.Parse(fromPLC.Substring(40, 4)) / 10)
        allarme.AperturaValvola = CDbl(Integer.Parse(fromPLC.Substring(44, 4)) / 10)

        Try
            Dim sql As String
            cn = New SqlConnection(connectioString)
            cn.Open()
            Dim cmd As SqlCommand
            'sql = "INSERT INTO StoricoOutputTostatura (id_tostatura, temp_pre_carico, inizio_carico, temp_in_carico, data_fine_sosta_forno, avvio_scarico_giostra, tempo_sosta_giostra, avvio_scarico_carrello) " & _
            '                            "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)"
            sql = "INSERT INTO StoricoAllarmi (id_tostatura, data_allarme, valvola, apertura_valvola) " & _
                                        "VALUES (@p1,@p2,@p3,@p4)"
            cmd = New SqlCommand(sql, cn)
            With cmd.Parameters
                .Add("@p1", SqlDbType.Int).Value = allarme.IdTostatura
                .Add("@p2", SqlDbType.DateTime).Value = Date.Now  'allarme.DataAllarme
                '.Add("@p3", SqlDbType.DateTime).Value = outputTostura.InizioCarico
                .Add("@p3", SqlDbType.Float).Value = allarme.Valvola
                '.Add("@p5", SqlDbType.DateTime).Value = outputTostura.FineSostaForno
                '.Add("@p6", SqlDbType.DateTime).Value = outputTostura.ScaricoGiostra
                .Add("@p4", SqlDbType.Int).Value = allarme.AperturaValvola
                '.Add("@p8", SqlDbType.DateTime).Value = outputTostura.ScaricoCarrello
            End With

            cmd.ExecuteNonQuery()

            'objTransaction.Commit()
            cn.Close()
        Catch ex As Exception
            'objTransaction.Rollback()
            cn.Close()
            MsgBox("Attenzione si è verificato un problema." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Errore")

        End Try
    End Sub
End Class
