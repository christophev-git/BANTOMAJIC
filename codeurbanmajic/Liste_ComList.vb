Imports System.Collections.Generic
Public Class Liste_ComList
    Private m_liste_com As List(Of comliste)
    Private m_datagrid As DataGridView
    Public Sub New(fich_fantoir As String, datagrid As DataGridView, codedep As String)
        m_liste_com = New List(Of comliste)
        Using sr As New System.IO.StreamReader(fich_fantoir)

            Dim l As String
            Do While Not sr.EndOfStream
                l = sr.ReadLine
                If l.Length = 88 And l.Substring(0, 2) = codedep Then
                    Dim c As New comliste(l)
                    m_liste_com.Add(c)

                End If


            Loop


        End Using
        m_datagrid = datagrid
        m_datagrid.DataSource = m_liste_com
        m_datagrid.Columns("NomFich").Visible = False
    End Sub

    Private m_cherch_insee As String

    Private Function Find_Comm(p As comliste) As Boolean
        If p.Insee = m_cherch_insee Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Get_Com(insee_to_find As String) As comliste
        m_cherch_insee = insee_to_find
        Return m_liste_com.Find(AddressOf Find_Comm)
    End Function
End Class
