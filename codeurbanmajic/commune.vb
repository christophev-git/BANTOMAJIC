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
    Private m_voie_fantoir As Liste_FANTOIR
    Public ReadOnly Property Liste_Voie_FANTOIR() As Liste_FANTOIR
        Get
            Return m_voie_fantoir
        End Get

    End Property

    Private m_liste_adresse_ban As Liste_BAN
    Public ReadOnly Property Liste_Adresse_BAN() As Liste_BAN
        Get
            Return m_liste_adresse_ban
        End Get

    End Property



    'Public Sub New(nom As String, insee As String, Optional fich_BAN_com As String = "")
    '    m_nom = nom
    '    m_insee = insee
    '    If fich_BAN_com = "" Then
    '        m_liste_adresse_ban = New Liste_BAN(fichier_ban_dep, m_insee, m_nom)

    '    Else

    '        m_liste_adresse_ban = New Liste_BAN(fich_BAN_com, m_insee, m_nom)

    '    End If

    '    m_voie_fantoir = New Liste_FANTOIR(fichier_fantoir, m_insee)

    'End Sub

    Public Sub New(coml As comliste)
        m_nom = coml.Nom
        m_insee = coml.Insee
        If Not coml.FC Then
            m_liste_adresse_ban = New Liste_BAN(fichier_ban_dep, m_insee, m_nom)
        Else
            m_liste_adresse_ban = New Liste_BAN(coml.NomFich, m_insee, m_nom)
        End If
        m_voie_fantoir = New Liste_FANTOIR(fichier_fantoir, m_insee)
    End Sub

End Class
