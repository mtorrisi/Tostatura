Public Class Operatore

    Private codOperatore, nome, password As String
    Private ruolo As Int32

    Public Sub New()
        Me.NomeOperatore = ""
        Me.CodiceOperatore = ""
        Me.ruolo = 0
        Me.password = ""
    End Sub
    Public Sub New(ByVal codOperatore As String, ByVal Nome As String, ByVal codRuolo As Int32)
        Me.NomeOperatore = Nome
        Me.CodiceOperatore = codOperatore
        Me.ruolo = codRuolo
    End Sub

    Public Sub New(ByVal codOperatore As String, ByVal Nome As String, ByVal codRuolo As Int32, ByVal passw As String)
        Me.NomeOperatore = Nome
        Me.CodiceOperatore = codOperatore
        Me.ruolo = codRuolo
        Me.password = passw
    End Sub

    Public Property NomeOperatore() As String
        Get
            Return Me.nome
        End Get

        Set(ByVal Value As String)
            nome = Value
        End Set
    End Property

    Public Property CodiceOperatore() As String
        Get
            Return Me.codOperatore
        End Get

        Set(ByVal Value As String)
            Me.codOperatore = Value
        End Set
    End Property

    Public Property PasswordOperatore() As String
        Get
            Return Me.password
        End Get

        Set(ByVal Value As String)
            Me.password = Value
        End Set
    End Property

    Public Property CodiceRuolo() As Int32
        Get
            Return Me.ruolo
        End Get

        Set(ByVal Value As Int32)
            Me.ruolo = Value
        End Set
    End Property

    Public Sub changeOperatore(ByVal codOp As String, ByVal name As String, ByVal role As Int32)
        Me.codOperatore = codOp
        Me.nome = name
        Me.ruolo = role
    End Sub
End Class
