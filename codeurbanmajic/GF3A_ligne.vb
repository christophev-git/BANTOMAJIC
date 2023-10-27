Public Class GF3A_ligne
    Private m_codeinsee As String
    Public Property CodeInsee() As String
        Get
            Return m_codeinsee
        End Get
        Set(ByVal value As String)
            m_codeinsee = value
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

    Private m_refcad As String
    Public Property RefCad() As String
        Get
            Return m_refcad
        End Get
        Set(ByVal value As String)
            m_refcad = value
        End Set
    End Property

    Private m_numvoie As String
    Public Property NumVoie() As String
        Get
            Return m_numvoie
        End Get
        Set(ByVal value As String)
            m_numvoie = value
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

    Private m_nature As String
    Public Property Nature() As String
        Get
            Return m_nature
        End Get
        Set(ByVal value As String)
            m_nature = value
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
    Public Sub New(ad As Adresse_BAN, insee As String, nom As String)
        m_codeinsee = insee
        m_nom_commune = nom
        m_refcad = ad.RefCad
        m_numvoie = ad.Numero
        m_indrep = ad.IndRep
        m_nature = ""
        m_libelle = ad.Nom_AFNOR
    End Sub

    Public Sub New(e As GF3A_ligne, refcad As String)

        With e

            m_codeinsee = .CodeInsee
            m_nom_commune = .Nom_Commune
            m_refcad = refcad
            m_numvoie = .NumVoie
            m_indrep = .IndRep
            m_nature = .Nature
            m_libelle = .Libelle

        End With
    End Sub

    Public Function SplitRefCad() As System.Collections.Generic.List(Of GF3A_ligne)
        Dim mliste As New System.Collections.Generic.List(Of GF3A_ligne)
        Dim res() As String = m_refcad.Split("|")

        For i = 0 To res.GetUpperBound(0)

            Dim f As New GF3A_ligne(Me, res(i))
            mliste.Add(f)

        Next

        Return mliste
    End Function
    Public Sub Affecte_Nature_libelle(Optional splitlocal As Boolean = False, Optional codemajic As Boolean = False)

        Dim tr As New traduction(m_libelle, W_traducteur)

        If splitlocal Then
            m_libelle = tr.Translated
        Else
            If tr.Dic_Trad.Locale = tr.Dic_Trad.Normale Then
                m_libelle = tr.Translated
            Else
                m_libelle = tr.To_Translate
            End If
        End If

        If codemajic Then
            m_nature = tr.Dic_Trad.CodeMAJIC
        Else
            If splitlocal Then
                m_nature = tr.Dic_Trad.Locale
            Else
                m_nature = tr.Dic_Trad.Normale
            End If
        End If

    End Sub
    Public Function Datagrid_view(d As DataGridView) As Boolean
        With d
            .Columns("CodeInsee").DisplayIndex = 0
            .Columns("Nom_Commune").DisplayIndex = 1
            .Columns("RefCad").DisplayIndex = 2
            .Columns("NumVoie").DisplayIndex = 3
            .Columns("IndRep").DisplayIndex = 4
            .Columns("Nature").DisplayIndex = 5
            .Columns("Libelle").DisplayIndex = 6
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With
        Return True

    End Function
End Class
