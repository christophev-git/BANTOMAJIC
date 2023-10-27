Public Class Liste_FANTOIR
    Private m_liste_voie As System.Collections.Generic.List(Of Voie_Fantoir)
    Private m_datagrid As DataGridView

    Public Sub New(fichier_fantoir As String, code_insee As String, Optional notfill As Boolean = False)

        m_liste_voie = New System.Collections.Generic.List(Of Voie_Fantoir)

        If notfill Then Exit Sub

        Using sr As New System.IO.StreamReader(fichier_fantoir)

            sr.ReadLine()

            Do While Not sr.EndOfStream
                Dim l As String = sr.ReadLine

                If l.Length >= 112 And l.Substring(0, 2) = My.Settings.departement Then

                    If l.Substring(0, 2) & l.Substring(3, 3) = code_insee Then
                        Dim v As New Voie_Fantoir(l)
                        m_liste_voie.Add(v)
                    End If

                End If

            Loop

        End Using
    End Sub

    Public Function Get_Liste() As System.Collections.Generic.List(Of Voie_Fantoir)
        Dim r As New System.Collections.Generic.List(Of Voie_Fantoir)

        For Each p As Voie_Fantoir In m_liste_voie
            Dim q As New Voie_Fantoir(p)
            r.Add(q)
        Next

        Return r
    End Function

    Public Sub Add(v As Voie_Fantoir)
        m_liste_voie.Add(v)
    End Sub
    Public Sub Set_DataGrid(d As DataGridView)
        m_datagrid = d
        With m_datagrid
            .DataSource = m_liste_voie
            .Columns("Insee").DisplayIndex = 0
            .Columns("Id_Voie").DisplayIndex = 1
            .Columns("Clef_RIVOLI").DisplayIndex = 2
            .Columns("Code_Nature").DisplayIndex = 3
            .Columns("Libelle").DisplayIndex = 4
            .Columns("Publique").DisplayIndex = 5
            .Columns("Identifiant_MAJIC").DisplayIndex = 6
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With
    End Sub
End Class
