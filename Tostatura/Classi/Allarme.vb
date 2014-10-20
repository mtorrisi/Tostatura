Public Class OutputTostatura

    Private _idTostatura As Integer
    Private _tempPreCarico As Double
    Private _inizioCarico As String
    Private _tempInCarico As Double
    Private _finiSostaForno As String
    Private _scaricoGiostra As String
    Private _sostaGiostra As Integer
    Private _scaricoCarrello As String
    Public Property IdTostatura() As Integer
        Get
            Return _idTostatura
        End Get
        Set(ByVal value As Integer)
            _idTostatura = value
        End Set
    End Property
    Public Property ScaricoCarrello() As String
        Get
            Return _scaricoCarrello
        End Get
        Set(ByVal value As String)
            _scaricoCarrello = value
        End Set
    End Property

    Public Property SostaGiostra() As Integer
        Get
            Return _sostaGiostra
        End Get
        Set(ByVal value As Integer)
            _sostaGiostra = value
        End Set
    End Property

    Public Property ScaricoGiostra() As String
        Get
            Return _scaricoGiostra
        End Get
        Set(ByVal value As String)
            _scaricoGiostra = value
        End Set
    End Property

    Public Property FineSostaForno() As String
        Get
            Return _finiSostaForno
        End Get
        Set(ByVal value As String)
            _finiSostaForno = value
        End Set
    End Property

    Public Property TemperaturaInCarico() As Double
        Get
            Return _tempInCarico
        End Get
        Set(ByVal value As Double)
            _tempInCarico = value
        End Set
    End Property

    Public Property InizioCarico() As String
        Get
            Return _inizioCarico
        End Get
        Set(ByVal value As String)
            _inizioCarico = value
        End Set
    End Property

    Public Property TemperaturaPreCarico() As Integer
        Get
            Return _tempPreCarico
        End Get
        Set(ByVal value As Integer)
            _tempPreCarico = value
        End Set
    End Property

End Class
