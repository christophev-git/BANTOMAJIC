Public Class traducteur
    Private m_locale As String
    Public Property Locale() As String
        Get
            Return m_locale
        End Get
        Set(ByVal value As String)
            m_locale = value
        End Set
    End Property

    Private m_normale As String
    Public Property Normale() As String
        Get
            Return m_normale
        End Get
        Set(ByVal value As String)
            m_normale = value
        End Set
    End Property

    Public Sub New(nom_local As String, nom_normalise As String)
        m_locale = nom_local
        m_normale = nom_normalise
    End Sub
End Class
