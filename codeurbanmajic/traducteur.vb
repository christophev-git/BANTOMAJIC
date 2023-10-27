Public Class traducteur
    Private m_liste_traduction As System.Collections.Generic.List(Of dic_traduction)
    Public ReadOnly Property Liste_Traduction() As System.Collections.Generic.List(Of dic_traduction)
        Get
            Return m_liste_traduction
        End Get
    End Property
    Private m_nom_fichier As String
    Public ReadOnly Property Nom_Fichier() As String
        Get
            Return m_nom_fichier
        End Get

    End Property
    Public Sub New(nom As String)
        m_liste_traduction = New System.Collections.Generic.List(Of dic_traduction)
        m_nom_fichier = nom

        Using sr As New System.IO.StreamReader(m_nom_fichier)

            Do While Not sr.EndOfStream
                Dim l() As String = sr.ReadLine.Split(";")
                Dim foo As New dic_traduction(l(0), l(1), l(2))
                m_liste_traduction.Add(foo)
            Loop
        End Using

    End Sub

    Public Function From_Locale(ToBeSearch As String) As dic_traduction
        Dim t() As String = ToBeSearch.Split(" ")
        m_sc = t(0)
        Dim dc As dic_traduction = m_liste_traduction.Find(AddressOf Locale_existe)
        If dc Is Nothing Then
            dc = New dic_traduction("", "", "")
        End If
        Return dc
    End Function

    Private m_sc As String
    Private Function Locale_existe(s As dic_traduction) As Boolean

        If s.Locale = m_sc Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
