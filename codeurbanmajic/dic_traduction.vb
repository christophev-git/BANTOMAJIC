Public Class dic_traduction
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

    Private m_code_majic As String
    Public Property CodeMAJIC() As String
        Get
            Return m_code_majic
        End Get
        Set(ByVal value As String)
            m_code_majic = value
        End Set
    End Property


    Public Sub New(nom_local As String, nom_normalise As String, code As String)
        m_locale = nom_local
        m_normale = nom_normalise
        m_code_majic = code
    End Sub
End Class
