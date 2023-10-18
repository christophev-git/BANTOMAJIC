Public Class commune
    Private m_nom As String
    Public Property Nom() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
        End Set
    End Property

    Private m_insee As String
    Public Property Insee() As String
        Get
            Return m_insee
        End Get
        Set(ByVal value As String)
            m_insee = value
        End Set
    End Property

    Public Sub New(nom As String, insee As String)
        m_nom = nom
        m_insee = insee

    End Sub
End Class
