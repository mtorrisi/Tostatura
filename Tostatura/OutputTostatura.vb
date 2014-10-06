Public Class OutputTostatura
    Private _tempPreCarico As Double
    Private _inizioCarico As Date
    Private _tempInCarico As Double
    Private _finiSostaForno As Date
    Private _scaricoGiostra As Date
    Private _sostaGiostra As Integer
    Private _scaricoCarrello As Date

    Public Property ScaricoCarrello() As Date
        Get
            Return _scaricoCarrello
        End Get
        Set(ByVal value As Date)
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

    Public Property ScaricoGiostra() As Date
        Get
            Return _scaricoGiostra
        End Get
        Set(ByVal value As Date)
            _scaricoGiostra = value
        End Set
    End Property

    Public Property FineSostaForno() As Date
        Get
            Return _finiSostaForno
        End Get
        Set(ByVal value As Date)
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

    Public Property InizioCarico() As Date
        Get
            Return _inizioCarico
        End Get
        Set(ByVal value As Date)
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
