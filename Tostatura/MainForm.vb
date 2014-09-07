Public Class MainForm

    '    Public formGestioneFormule As GestioneFormule1
    Dim operatore As Operatore

    Public Sub New(ByVal op As Operatore)
        InitializeComponent()
        Me.operatore = op
    End Sub


    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpLbl.Text = operatore.NomeOperatore
        CodOpLbl.Text = operatore.CodiceOperatore
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If operatore.CodiceRuolo = 1 Then
            MsgBox("Selezione non permessa!", MsgBoxStyle.Exclamation, "ATTENZIONE!")
            Exit Sub
        End If

        Dim flag As Boolean = False
        For Each form As Form In Application.OpenForms
            If form.Name = "Anagrafiche" Then
                flag = True
                Exit For
            End If
        Next
        If Not flag Then
            Dim f As New FormAnagrafiche(operatore)
            f.Show()
        Else
            Application.OpenForms("Anagrafiche").Focus()
        End If

    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    'Dim f As New GestioneFormule1(operatore)
    'Control.CheckForIllegalCrossThreadCalls = False
    'f.Show()
    'formGestioneFormule = New GestioneFormule1(operatore)
    'formGestioneFormule.callingForm = Me 'assegno un riferimento alla form corrente alla form GestioneFormule1 per poter richiamare i suoi controlli
    'Control.CheckForIllegalCrossThreadCalls = False
    'formGestioneFormule.Show()
    'End Sub

    Private Sub Anagrafiche_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'MsgBox("CIAO")
        Try
            Dim s As String = Me.PoohFinsETN1.ReadMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 1000, 1)
            If s.Equals("0000") Then

                Me.PoohFinsETN1.WriteMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 1000, "0001")
                TextBox1.Text = Me.PoohFinsETN1.ReadMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 1000, 1)
                'MessageBox.Show(Me.PoohFinsETN1.ReadMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 100, 1))
            Else
                Me.PoohFinsETN1.WriteMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 1000, "0000")
                TextBox1.Text = Me.PoohFinsETN1.ReadMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 1000, 1)
                'MessageBox.Show(Me.PoohFinsETN1.ReadMemory(PoohPlcLink.PoohFinsETN.MemoryTypes.DM, 100, 1))
            End If

        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    'Private Sub BttStatistiche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttStatistiche.Click
    'Dim f As New FrmStatistiche
    'f.Show()
    'End Sub

    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If VerificaGestionePesate() Then
            MessageBox.Show("Attendere il completamento della pesata in corso prima di chiudere l'applicazione.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Public Function VerificaGestionePesate() As Boolean
        Dim f As Form
        For Each f In Application.OpenForms
            If f.Name = "GestioneFormule1" Then
                'If formGestioneFormule.statusLBL.Visible Then
                'Return True
                'ElseIf f.WindowState Then
                'Return True
                'End If
                Return False
            End If
        Next
        Return False
    End Function

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    'If Not VerificaGestionePesate() Then
    'Dim f As New LoginForm()
    '   f.operatore = Me.operatore
    '  f.Show()
    'Else
    'MessageBox.Show("QUALCOSA")
    'End If
    'End Sub

    Public Sub reload() 'aggiorna le labels dell'operatore
        OpLbl.Text = operatore.NomeOperatore
        CodOpLbl.Text = operatore.CodiceOperatore
    End Sub
End Class
