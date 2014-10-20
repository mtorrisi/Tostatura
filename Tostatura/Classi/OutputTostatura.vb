Public Class Allarme

    Private _idTostatura As Integer
    Private _data As String
    Private _valvola As Double
    Private _aperturaValvola As Double

    Public Property IdTostatura() As Integer
        Get
            Return _idTostatura
        End Get
        Set(ByVal value As Integer)
            _idTostatura = value
        End Set
    End Property
    
    Public Property DataAllarme() As String
        Get
            Return _data
        End Get
        Set(ByVal value As String)
            _data = value
        End Set
    End Property

    Public Property Valvola() As Double
        Get
            Return _valvola
        End Get
        Set(ByVal value As Double)
            _valvola = value
        End Set
    End Property

    Public Property AperturaValvola() As Double
        Get
            Return _aperturaValvola
        End Get
        Set(ByVal value As Double)
            _aperturaValvola = value
        End Set
    End Property
End Class
