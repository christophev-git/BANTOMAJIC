Public Class Adresse_BAN
    Private m_idban As String
    Public Property Id() As String
        Get
            Return m_idban
        End Get
        Set(ByVal value As String)
            m_idban = value
        End Set
    End Property
    Private m_idfantoir As String
    Public Property Id_Fantoir() As String
        Get
            Return m_idfantoir
        End Get
        Set(ByVal value As String)
            m_idfantoir = value
        End Set
    End Property

    Private m_numero As String
    Public Property Numero() As String
        Get
            Return m_numero
        End Get
        Set(ByVal value As String)
            m_numero = value
        End Set
    End Property

    Private m_indrep As String
    Public Property IndRep() As String
        Get
            Return m_indrep
        End Get
        Set(ByVal value As String)
            m_indrep = value
        End Set
    End Property
    Private m_nom_voie As String
    Public Property Nom_Voie() As String
        Get
            Return m_nom_voie
        End Get
        Set(ByVal value As String)
            m_nom_voie = value
        End Set
    End Property
    Private m_code_postal As String
    Public Property Code_Postal() As String
        Get
            Return m_code_postal
        End Get
        Set(ByVal value As String)
            m_code_postal = value
        End Set
    End Property
    Private m_code_insee As String
    Public Property Code_Insee() As String
        Get
            Return m_code_insee
        End Get
        Set(ByVal value As String)
            m_code_insee = value
        End Set
    End Property
    Private m_nom_commune As String
    Public Property Nom_Commune() As String
        Get
            Return m_nom_commune
        End Get
        Set(ByVal value As String)
            m_nom_commune = value
        End Set
    End Property

    Private m_x As Double
    Public Property X() As Double
        Get
            Return m_x
        End Get
        Set(ByVal value As Double)
            m_x = value
        End Set
    End Property

    Private m_Y As Double
    Public Property Y() As Double
        Get
            Return m_Y
        End Get
        Set(ByVal value As Double)
            m_Y = value
        End Set
    End Property

    Private m_type_position As String
    Public Property Type_Position() As String
        Get
            Return m_type_position
        End Get
        Set(ByVal value As String)
            m_type_position = value
        End Set
    End Property
    Private m_libelle_acheminement As String
    Public Property Libelle_Acheminement() As String
        Get
            Return m_libelle_acheminement
        End Get
        Set(ByVal value As String)
            m_libelle_acheminement = value
        End Set
    End Property
    Private m_nom_afnor As String
    Public Property Nom_AFNOR() As String
        Get
            Return m_nom_afnor
        End Get
        Set(ByVal value As String)
            m_nom_afnor = value
        End Set
    End Property
    Private m_source_position As String
    Public Property Source_Position() As String
        Get
            Return m_source_position
        End Get
        Set(ByVal value As String)
            m_source_position = value
        End Set
    End Property
    Private m_source_nom_voie As String
    Public Property Source_Nom_Voie() As String
        Get
            Return m_source_nom_voie
        End Get
        Set(ByVal value As String)
            m_source_nom_voie = value
        End Set
    End Property
    Private m_certification_commune As String
    Public Property Certification_Commune() As String
        Get
            Return m_certification_commune
        End Get
        Set(ByVal value As String)
            m_certification_commune = value
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
    Public Sub New(p As Adresse_BAN)
        With p
            m_idban = .Id
            m_idfantoir = .Id_Fantoir
            m_numero = .Numero
            m_indrep = .IndRep
            m_nom_voie = .Nom_Voie
            m_code_postal = .Code_Postal
            m_code_insee = .Code_Insee
            m_nom_commune = .Nom_Commune
            m_x = .X
            m_Y = .Y
            m_type_position = .Type_Position
            m_libelle_acheminement = .Libelle_Acheminement
            m_nom_afnor = .Nom_AFNOR
            m_source_position = .Source_Position
            m_source_nom_voie = .Nom_Voie
            m_certification_commune = .Certification_Commune
            m_refcad = .RefCad
        End With
    End Sub
    Public Sub New(l() As String)
        m_idban = l(0)
        m_idfantoir = l(1)
        m_numero = l(2)
        m_indrep = l(3)
        m_nom_voie = l(4)
        m_code_postal = l(5)
        m_code_insee = l(6)
        m_nom_commune = l(7)
        m_x = Val(l(10))
        m_Y = Val(l(11))
        m_type_position = l(14)
        m_libelle_acheminement = l(17)
        m_nom_afnor = l(18)
        m_source_position = l(19)
        m_source_nom_voie = l(20)
        m_certification_commune = l(21)
        m_refcad = l(22)
    End Sub

    Public Function Csv_line() As String
        Dim s As String = ""
        Dim t As String = ";"
        s = m_idban & t & m_idfantoir & t & m_numero & t & m_indrep _
            & t & m_nom_voie & t & m_code_postal & t & m_code_insee & t & m_nom_commune _
            & t & m_x & t & m_Y & t & m_type_position & t & m_libelle_acheminement _
            & t & m_nom_afnor & t & m_source_position & t & m_source_nom_voie _
            & t & m_certification_commune & t & m_refcad

        Return s
    End Function

End Class
