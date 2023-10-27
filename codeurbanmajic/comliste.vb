Public Class comliste
    Private m_insee As String
    Public Property Insee() As String
        Get
            Return m_insee
        End Get
        Set(ByVal value As String)
            m_insee = value
        End Set
    End Property
    Private m_nom As String
    Public Property Nom() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
        End Set
    End Property

    Private m_fc As Boolean
    Public ReadOnly Property FC() As Boolean
        Get
            Return m_fc
        End Get

    End Property
    Private m_nomfich As String
    Public ReadOnly Property NomFich() As String
        Get
            Return m_nomfich
        End Get
    End Property
    Public Sub New(l As String)
        m_nom = l.Substring(11, 30)
        m_insee = l.Substring(0, 2) & l.Substring(3, 3)
        m_fc = False
        m_nomfich = ""
    End Sub
    Public Sub Set_FC(NomFich As String)
        m_fc = True
        m_nomfich = NomFich
    End Sub
    Public Sub UnSet_FC()
        m_fc = False
        m_nomfich = ""

    End Sub
End Class
