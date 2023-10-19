Public Class Voie_Fantoir
    Private m_idvoie As String
    Public Property Id_Voie() As String
        Get
            Return m_idvoie
        End Get
        Set(ByVal value As String)
            m_idvoie = value
        End Set
    End Property
    Private m_clef_rivoli As String
    Public Property Clef_RIVOLI() As String
        Get
            Return m_clef_rivoli
        End Get
        Set(ByVal value As String)
            m_clef_rivoli = value
        End Set
    End Property

    Private m_code_nature As String
    Public Property Code_Nature() As String
        Get
            Return m_code_nature
        End Get
        Set(ByVal value As String)
            m_code_nature = value
        End Set
    End Property

    Private m_libelle As String
    Public Property Libelle() As String
        Get
            Return m_libelle
        End Get
        Set(ByVal value As String)
            m_libelle = value
        End Set
    End Property

    Private m_public As Boolean
    Public Property Publique() As Boolean
        Get
            Return m_public
        End Get
        Set(ByVal value As Boolean)
            m_public = value
        End Set
    End Property

    Private m_identifiant_majic As String
    Public Property Identifiant_Majic() As String
        Get
            Return m_identifiant_majic
        End Get
        Set(ByVal value As String)
            m_identifiant_majic = value
        End Set
    End Property

    Private m_type_voie As Integer
    Public Property Type_Voie() As Integer
        Get
            Return m_type_voie
        End Get
        Set(ByVal value As Integer)
            m_type_voie = value
        End Set
    End Property

    Public Sub New(l As String)
        m_idvoie = l.Substring(6, 4)
        m_clef_rivoli = l.Substring(10, 1)
        m_code_nature = l.Substring(11, 4)
        m_libelle = l.Substring(15, 26)
        If l.Substring(48, 1) = "0" Then
            m_public = True
        Else
            m_public = False
        End If
        m_identifiant_majic = l.Substring(103, 5)
        m_type_voie = l.Substring(108, 1)
    End Sub
End Class
