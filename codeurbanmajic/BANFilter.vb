Public Class BANFilter

    Private m_nomvoie As String
        Public Property Nomvoie() As String
            Get
                Return m_nomvoie
            End Get
            Set(ByVal value As String)
                m_nomvoie = value
            End Set
        End Property

    Private m_sourcepos As String
    Public Property SourcePos() As String
        Get
            Return m_sourcepos
        End Get
        Set(ByVal value As String)
            m_sourcepos = value
        End Set
    End Property

    Private m_source_nom As String
    Public Property SourceNom() As String
        Get
            Return m_source_nom
        End Get
        Set(ByVal value As String)
            m_source_nom = value
        End Set
    End Property
    Private m_typepos As String
    Public Property TypePos() As String
        Get
            Return m_typepos
        End Get
        Set(ByVal value As String)
            m_typepos = value
        End Set
    End Property
    Private m_certif As String
    Public Property Certif() As String
        Get
            Return m_certif
        End Get
        Set(ByVal value As String)
            m_certif = value
        End Set
    End Property
    Private m_refcad As String
    Public Property RefCad() As String
        Get
            Return m_refcad
        End Get
        Set(ByVal value As String)
            m_refcad = value
        End Set
    End Property

    Public Sub New(Optional nomvoie As String = "*",
                   Optional sourcepos As String = "*",
                   Optional sourcenom As String = "*",
                   Optional typepos As String = "*",
                   Optional certif As String = "*",
                   Optional refacd As String = "*")
        m_nomvoie = nomvoie
        m_source_nom = sourcenom
        m_sourcepos = sourcepos
        m_typepos = typepos
        m_certif = certif
        m_refcad = refacd
    End Sub
End Class

