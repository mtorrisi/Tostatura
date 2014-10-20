Public Class InputTostatura

    Private _op As Integer

    Private _idTostatura As Integer
    Private _inizio As DateTime
    Private _finito As String
    Private _grezzo As String
    Private _umiditaProdotto As Double
    Private _umiditaEsterna As Double
    Private _teperaturaForno As Double
    Private _tempoCottura As Integer
    Private _quatitaCarico As Double
    Private _idTipoLavorazione As Integer
    Private _codiceOperatore As Integer
    Public Property CodiceOperatore() As Integer
        Get
            Return _codiceOperatore
        End Get
        Set(ByVal value As Integer)
            _codiceOperatore = value
        End Set
    End Property

    Public Property TipoLavorazione() As Integer
        Get
            Return _idTipoLavorazione
        End Get
        Set(ByVal value As Integer)
            _idTipoLavorazione = value
        End Set
    End Property

    Public Property QuatitaCarico() As Double
        Get
            Return _quatitaCarico
        End Get
        Set(ByVal value As Double)
            _quatitaCarico = value
        End Set
    End Property

    Public Property TempoCottura() As Integer
        Get
            Return _tempoCottura
        End Get
        Set(ByVal value As Integer)
            _tempoCottura = value
        End Set
    End Property

    Public Property TemperaturaForno() As Double
        Get
            Return _teperaturaForno
        End Get
        Set(ByVal value As Double)
            _teperaturaForno = value
        End Set
    End Property

    Public Property PercentualeUmiditaEsterna() As Double
        Get
            Return _umiditaEsterna
        End Get
        Set(ByVal value As Double)
            _umiditaEsterna = value
        End Set
    End Property

    Public Property PercentualeUmiditaProdotto() As Double
        Get
            Return _umiditaProdotto
        End Get
        Set(ByVal value As Double)
            _umiditaProdotto = value
        End Set
    End Property

    Public Property CodiceGrezzo() As String
        Get
            Return _grezzo
        End Get
        Set(ByVal value As String)
            _grezzo = value
        End Set
    End Property
    Public Property CodiceFinito() As String
        Get
            Return _finito
        End Get
        Set(ByVal value As String)
            _finito = value
        End Set
    End Property
    Public Property Datainizio() As DateTime
        Get
            Return _inizio
        End Get
        Set(ByVal value As DateTime)
            _inizio = value
        End Set
    End Property

    Public Property Operatore() As Integer
        Get
            Return _op
        End Get
        Set(ByVal value As Integer)
            _op = value
        End Set
    End Property

    Public Property IdTostatura() As Integer
        Get
            Return _idTostatura
        End Get
        Set(ByVal value As Integer)
            _idTostatura = value
        End Set
    End Property
End Class
