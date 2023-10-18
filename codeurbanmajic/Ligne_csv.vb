Public Class Ligne_csv
    Private m_contenu() As String
    Public Property Contenu() As String()
        Get
            Return m_contenu
        End Get
        Set(ByVal value() As String)
            m_contenu = value
        End Set
    End Property

    Private m_separateur As String
    Public Property Separateur() As String
        Get
            Return m_separateur
        End Get
        Set(ByVal value As String)
            m_separateur = value
        End Set
    End Property

    Public Sub New(s As String, Optional csvseparateur As String = ";")
        m_contenu = s.Split(csvseparateur)

    End Sub

End Class
