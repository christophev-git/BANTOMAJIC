Imports System.Collections.Generic
Public Class Liste_BAN
    Private m_liste_ban As System.Collections.Generic.List(Of Adresse_BAN)
    Private m_filtered As System.Collections.Generic.List(Of Adresse_BAN)
    Private m_liste_nom_voie As List(Of String)
    Private m_liste_source_position As List(Of String)
    Private m_liste_source_nomvoie As List(Of String)
    Private m_liste_type_position As List(Of String)
    Private m_datagrid As DataGridView
    Private m_insee As String
    Private m_nom As String
    Private m_w_filter As BANFilter

    Public Sub New(fichier_b As String, code_insee As String, nomcommune As String, Optional notfill As Boolean = False)

        m_liste_ban = New System.Collections.Generic.List(Of Adresse_BAN)
        m_filtered = New System.Collections.Generic.List(Of Adresse_BAN)
        m_w_filter = New BANFilter
        m_insee = code_insee
        m_nom = nomcommune
        If notfill Then Exit Sub

        Using sr As New System.IO.StreamReader(fichier_ban_dep)

            sr.ReadLine()

            Do While Not sr.EndOfStream
                Dim l As New Ligne_csv(sr.ReadLine)

                If l.Contenu.GetUpperBound(0) = 22 Then

                    If l.Contenu(6) = code_insee Then
                        Dim v As New Adresse_BAN(l.Contenu)
                        m_liste_ban.Add(v)
                        m_filtered.Add(v)
                    End If

                End If

            Loop

        End Using
        m_liste_nom_voie = New List(Of String)
        m_liste_source_nomvoie = New List(Of String)
        m_liste_source_position = New List(Of String)
        m_liste_type_position = New List(Of String)

        m_liste_nom_voie.Add("*")
        m_liste_source_nomvoie.Add("*")
        m_liste_source_position.Add("*")
        m_liste_type_position.Add("*")

        For Each p As Adresse_BAN In m_liste_ban

            Dim i As Integer = m_liste_nom_voie.BinarySearch(p.Nom_Voie)
            If i < 0 Then
                i = i Xor -1
                m_liste_nom_voie.Insert(i, p.Nom_Voie)
            End If

            i = m_liste_source_nomvoie.BinarySearch(p.Source_Nom_Voie)
            If i < 0 Then
                i = i Xor -1
                m_liste_source_nomvoie.Insert(i, p.Source_Nom_Voie)
            End If

            i = m_liste_source_position.BinarySearch(p.Source_Position)
            If i < 0 Then
                i = i Xor -1
                m_liste_source_position.Insert(i, p.Source_Position)
            End If

            i = m_liste_type_position.BinarySearch(p.Type_Position)
            If i < 0 Then
                i = i Xor -1
                m_liste_type_position.Insert(i, p.Type_Position)
            End If

        Next
    End Sub
    Public Sub Apply_Filter(Optional nomvoie As String = "*",
                            Optional sourcepos As String = "*",
                            Optional sourcenom As String = "*",
                            Optional typepos As String = "*",
                            Optional certification As String = "*",
                            Optional refcad As String = "*")
        m_filtered = New List(Of Adresse_BAN)

        For Each p In m_liste_ban
            Dim trac As Boolean = True
            If nomvoie <> "*" Then

                If p.Nom_Voie <> nomvoie Then
                    trac = False
                Else

                End If

            End If

            If trac And sourcepos <> "*" Then
                If p.Source_Position <> sourcepos Then
                    trac = False
                End If
            End If

            If trac And sourcenom <> "*" Then
                If p.Source_Nom_Voie <> sourcenom Then
                    trac = False
                End If

            End If

            If trac And typepos <> "*" Then
                If p.Type_Position <> typepos Then
                    trac = False
                End If
            End If

            If trac And certification <> "*" Then
                If p.Certification_Commune <> certification Then
                    trac = False
                End If
            End If

            If trac And refcad <> "*" Then
                If p.RefCad = "" And refcad = "Oui" Then
                    trac = False
                End If
                If p.RefCad <> "" And refcad = "Non" Then
                    trac = False
                End If

            End If

            If trac Then
                m_filtered.Add(p)
            End If
        Next

        m_datagrid.DataSource = m_filtered
    End Sub
    Public Function Get_Liste_Nom_Voie() As List(Of String)
        Dim r As New List(Of String)

        For Each p In m_liste_nom_voie
            r.Add(p)
        Next

        Return r
    End Function
    Public Function Get_Liste_Source_Position() As List(Of String)
        Dim r As New List(Of String)

        For Each p In m_liste_source_position
            r.Add(p)
        Next

        Return r
    End Function

    Public Function Get_Liste_Source_Nom() As List(Of String)
        Dim r As New List(Of String)

        For Each p In m_liste_source_nomvoie
            r.Add(p)
        Next

        Return r
    End Function
    Public Function Get_Liste_Type_Position() As List(Of String)
        Dim r As New List(Of String)

        For Each p In m_liste_type_position
            r.Add(p)
        Next

        Return r
    End Function
    Public Function Get_Liste(Optional filtered As Boolean = True) As System.Collections.Generic.List(Of Adresse_BAN)
        Dim r As New System.Collections.Generic.List(Of Adresse_BAN)

        If filtered Then
            For Each p As Adresse_BAN In m_filtered
                Dim q = New Adresse_BAN(p)
                r.Add(q)
            Next
        Else
            For Each p As Adresse_BAN In m_liste_ban
                Dim q = New Adresse_BAN(p)
                r.Add(q)
            Next
        End If


        Return r
    End Function
    Public Sub add(v As Adresse_BAN)
        m_liste_ban.Add(v)
    End Sub
    Public Function Count() As Integer

        Return m_liste_ban.Count
    End Function
    Public Function Count_Filtered() As Integer
        Return m_filtered.Count
    End Function
    Public Function To_GF3A(Optional splitlocal As Boolean = False,
                            Optional codemajic As Boolean = False) As System.Collections.Generic.List(Of GF3A_ligne)

        Dim res As New System.Collections.Generic.List(Of GF3A_ligne)


        For Each p As Adresse_BAN In m_filtered
            Dim c As New GF3A_ligne(p, m_insee, m_nom)

            For Each q As GF3A_ligne In c.SplitRefCad
                q.Affecte_Nature_libelle(splitlocal, codemajic)
                res.Add(q)
            Next
        Next




        Return res
    End Function
    Public Sub Set_DataGrid(d As DataGridView)
        m_datagrid = d
        With m_datagrid
            .DataSource = m_liste_ban
            .Columns("Id").DisplayIndex = 0
            .Columns("Id_Fantoir").DisplayIndex = 1
            .Columns("Numero").DisplayIndex = 2
            .Columns("IndRep").DisplayIndex = 3
            .Columns("Nom_Voie").DisplayIndex = 4
            .Columns("Code_Postal").DisplayIndex = 5
            .Columns("Code_Insee").DisplayIndex = 6
            .Columns("Nom_Commune").DisplayIndex = 7
            .Columns("X").DisplayIndex = 8
            .Columns("Y").DisplayIndex = 9
            .Columns("Type_Position").DisplayIndex = 10
            .Columns("Libelle_Acheminement").DisplayIndex = 11
            .Columns("Nom_AFNOR").DisplayIndex = 12
            .Columns("Source_Position").DisplayIndex = 13
            .Columns("Source_Nom_Voie").DisplayIndex = 14
            .Columns("Certification_Commune").DisplayIndex = 15
            .Columns("RefCad").DisplayIndex = 16
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With
    End Sub

    Public Sub DataGrid_adresse(mode_on As Boolean)
        With m_datagrid
            If mode_on Then
                .Columns("Id").Visible = False
                .Columns("Id_Fantoir").Visible = False
                .Columns("Numero").DisplayIndex = 0
                .Columns("IndRep").DisplayIndex = 1
                .Columns("Nom_Voie").DisplayIndex = 2
                .Columns("Code_Postal").DisplayIndex = 3
                .Columns("Code_Insee").Visible = False
                .Columns("Nom_Commune").Visible = False
                .Columns("X").Visible = False
                .Columns("Y").Visible = False
                .Columns("Type_Position").DisplayIndex = 9
                .Columns("Libelle_Acheminement").DisplayIndex = 4
                .Columns("Nom_AFNOR").Visible = False
                .Columns("Source_Position").DisplayIndex = 5
                .Columns("Source_Nom_Voie").DisplayIndex = 6
                .Columns("Certification_Commune").DisplayIndex = 7
                .Columns("RefCad").DisplayIndex = 8
                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
            Else
                .Columns("Id").Visible = False
                .Columns("Id_Fantoir").Visible = False
                .Columns("Code_Insee").Visible = False
                .Columns("Nom_Commune").Visible = False
                .Columns("X").Visible = False
                .Columns("Y").Visible = False
                .Columns("Nom_AFNOR").Visible = False

                .Columns("Id").DisplayIndex = 0
                .Columns("Id_Fantoir").DisplayIndex = 1
                .Columns("Numero").DisplayIndex = 2
                .Columns("IndRep").DisplayIndex = 3
                .Columns("Nom_Voie").DisplayIndex = 4
                .Columns("Code_Postal").DisplayIndex = 5
                .Columns("Code_Insee").DisplayIndex = 6
                .Columns("Nom_Commune").DisplayIndex = 7
                .Columns("X").DisplayIndex = 8
                .Columns("Y").DisplayIndex = 9
                .Columns("Type_Position").DisplayIndex = 10
                .Columns("Libelle_Acheminement").DisplayIndex = 11
                .Columns("Nom_AFNOR").DisplayIndex = 12
                .Columns("Source_Position").DisplayIndex = 13
                .Columns("Source_Nom_Voie").DisplayIndex = 14
                .Columns("Certification_Commune").DisplayIndex = 15
                .Columns("RefCad").DisplayIndex = 16
                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End If



            '.Refresh()
        End With

    End Sub
End Class

