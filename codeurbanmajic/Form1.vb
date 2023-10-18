Public Class Form1
    Public source_ban As System.IO.StreamReader
    Public ligneres(6) As String
    Public tabres() As Array
    Public insee As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case DataGridView1.SelectedRows.Count
            Case 0
                MsgBox("Sélectionnez une commune", MsgBoxStyle.Information)
                DataGridView1.ClearSelection()
                Exit Sub
            Case > 1
                MsgBox("Une commune seulement", MsgBoxStyle.Exclamation)
                DataGridView1.ClearSelection()
                Exit Sub
            Case 1


                W_Commune = New commune(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value, DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value)
        End Select




        source_ban = New IO.StreamReader(fichier_ban_dep)
        ListeLignes = New System.Collections.Generic.List(Of Ligne_csv)

        Dim s As String = ""


        Using source_ban
            source_ban.ReadLine()

            Do While Not source_ban.EndOfStream

                Dim ll As New Ligne_csv(source_ban.ReadLine)
                If ll.Contenu(6) <> W_Commune.Insee Then

                Else
                    ListeLignes.Add(ll)
                End If
            Loop
        End Using
        Res_prelm = New System.Collections.Generic.List(Of GF3A_ligne)
        For Each p As Ligne_csv In ListeLignes

            Select Case p.Contenu.GetUpperBound(0)
                Case 22
                    If p.Contenu(22) <> "" Then

                        Dim g As New GF3A_ligne(p.Contenu)
                        Res_prelm.Add(g)
                    End If
            End Select
        Next
        Res_def = New System.Collections.Generic.List(Of GF3A_ligne)

        For Each l As GF3A_ligne In Res_prelm
            For Each n As GF3A_ligne In l.SplitRefCad
                Res_def.Add(n)
            Next
        Next

        Dim st(0) As String
        Dim i As Integer = 0
        Dim tradlst As New System.Collections.Generic.List(Of traducteur)
        Using sr As New System.IO.StreamReader(fichier_traduction)

            Do While Not sr.EndOfStream
                Dim l() As String = sr.ReadLine.Split(";")
                Dim foo As New traducteur(l(0), l(1))
                tradlst.Add(foo)
                ReDim Preserve st(i)
                st(i) = l(0)
                i = i + 1
            Loop
        End Using
        Array.Sort(st)
        For Each p As GF3A_ligne In Res_def
            Dim tt() As String = p.Libelle.Split(" ")
            Dim f As Integer = Array.BinarySearch(st, tt(0))
            If f < 0 Then

            Else
                stringtofind = tt(0)
                Dim tp As traducteur = tradlst.Find(AddressOf findtrad)
                p.Nature = tp.Normale
                If tp.Normale = tp.Locale Then
                    p.Libelle = p.Libelle.Substring(tp.Normale.Length + 1)
                End If
            End If
        Next
        DataGridView2.DataSource = Res_def
    End Sub
    Private Function findtrad(s As traducteur) As Boolean
        If s.Locale = stringtofind Then
            Return True

        Else
            Return False

        End If
    End Function
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Label1.Text = "BAN Départementale : " & fichier_ban_dep
        Label2.Text = "NOMS communes du département : " & fichier_commune_dep
        Label3.Text = "Fichier de traduction : " & fichier_traduction

        listeCommune = New System.Collections.Generic.List(Of commune)
        Dim l As String
        Using sr As New System.IO.StreamReader(fichier_commune_dep)
            Do While Not sr.EndOfStream
                l = sr.ReadLine
                Dim ll() As String = l.Split(";")
                Dim c As New commune(ll(1), ll(0))
                listeCommune.Add(c)
            Loop
        End Using

        With DataGridView1
            .DataSource = listeCommune
            .AutoResizeColumn(0)
            .AutoResizeColumn(1)
            .ClearSelection()
        End With

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count <> 1 Then
            Exit Sub
        Else
            Res_def = New System.Collections.Generic.List(Of GF3A_ligne)
            DataGridView2.DataSource = Res_def
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.FileName = "BANTOMAJIC_" & W_Commune.Insee
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Using wr As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                wr.WriteLine("CODE INSEE;NOMCOMM;REFCADPARC;NUMVOIE;INDREP;NATURE;LIBELLE")
                For Each p As GF3A_ligne In Res_def
                    Dim s As String = p.CodeInsee & ";" & p.Nom_Commune & ";" _
& p.RefCad & ";" & p.NumVoie & ";" & ";" _
& p.IndRep & ";" & p.Nature & ";" & p.Libelle
                    wr.WriteLine(s)
                Next
            End Using
        End If
    End Sub
End Class
