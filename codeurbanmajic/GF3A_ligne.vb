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

    Public Sub New(tab() As String)
        m_codeinsee = W_Commune.Insee
        m_nom_commune = W_Commune.Nom
        If tab.GetUpperBound(0) <> 22 Then
            If tab.GetUpperBound(0) = 4 Then
                m_refcad = tab(0)
                m_numvoie = tab(1)
                m_indrep = tab(2)
                m_nature = tab(3)
                m_libelle = tab(4)
            End If

        Else
            m_refcad = tab(22)
            m_numvoie = tab(2)
            m_indrep = tab(3)
            m_nature = ""
            m_libelle = tab(18)
        End If
    End Sub

    Public Function SplitRefCad() As System.Collections.Generic.List(Of GF3A_ligne)
        Dim mliste As New System.Collections.Generic.List(Of GF3A_ligne)
        Dim res() As String = m_refcad.Split("|")

        For i = 0 To res.GetUpperBound(0)

            Dim t(4) As String
            t(0) = res(i)
            t(1) = m_numvoie
            t(2) = m_indrep
            t(3) = m_nature
            t(4) = m_libelle

            Dim f As New GF3A_ligne(t)
            mliste.Add(f)

        Next

        Return mliste
    End Function


End Class
