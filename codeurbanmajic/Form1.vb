Public Class Form1
    Public source_ban As System.IO.StreamReader
    Public ligneres(6) As String
    Public tabres() As Array
    Public insee As String


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

        TabControl1.SelectedTab = TabPage1

        Select Case DataGridView1.SelectedRows.Count
            Case 0
                Exit Sub
            Case > 1
                MsgBox("Séléctionnez une commune seulement", MsgBoxStyle.Exclamation)
                DataGridView1.ClearSelection()
                Exit Sub
            Case 1
                Dim lcom As comliste = TryCast(DataGridView1.SelectedRows(0).DataBoundItem, comliste)
                InstancieCommune(lcom)

        End Select




    End Sub
    Private Sub InstancieCommune(coml As comliste)
        W_Commune = New commune(coml)
        W_Commune.Liste_Adresse_BAN.Set_DataGrid(DataGrid_BAN)
        W_Commune.Liste_Voie_FANTOIR.Set_DataGrid(DataGrid_FANTOIR)
        ListBoxnomvoie.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Nom_Voie
        ListBoxsourcenomvoie.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Source_Nom
        ListBoxsourceposition.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Source_Position
        ListBoxtypeposition.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Type_Position

        ListBoxnomvoie.SelectedIndex = 0
        ListBoxsourcenomvoie.SelectedIndex = 0
        ListBoxsourceposition.SelectedIndex = 0
        ListBoxtypeposition.SelectedIndex = 0

        Label3.Text = W_Commune.Liste_Adresse_BAN.Count & " au total"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.FileName = "BANTOMAJIC_" & W_Commune.Insee
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Using wr As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                wr.WriteLine("CODE INSEE;NOMCOMM;REFCADPARC;NUMVOIE;INDREP;NATURE;LIBELLE")
                For Each p As GF3A_ligne In W_Commune.Liste_Adresse_BAN.To_GF3A(False, True)
                    Dim s As String = p.CodeInsee & ";" & p.Nom_Commune & ";" _
& p.RefCad & ";" & p.NumVoie & ";" _
& p.IndRep & ";" & p.Nature & ";" & p.Libelle
                    wr.WriteLine(s)
                Next
            End Using
            MsgBox("enregistrement effectué", MsgBoxStyle.Information)
        End If
    End Sub








    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Select Case e.TabPage.Name
            Case TabPage2.Name

            Case TabPage3.Name
                DataGrid_gf3a.DataSource = W_Commune.Liste_Adresse_BAN.To_GF3A
        End Select


    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GF3A_checked_changed()
    End Sub
    Private Sub GF3A_checked_changed()
        If RadioButton1.Checked Then
            If CheckBox1.Checked Then
                DataGrid_gf3a.DataSource = W_Commune.Liste_Adresse_BAN.To_GF3A(True, True)
            Else
                DataGrid_gf3a.DataSource = W_Commune.Liste_Adresse_BAN.To_GF3A(True, False)
            End If
        Else
            If CheckBox1.Checked Then
                DataGrid_gf3a.DataSource = W_Commune.Liste_Adresse_BAN.To_GF3A(False, True)
            Else
                DataGrid_gf3a.DataSource = W_Commune.Liste_Adresse_BAN.To_GF3A(False, False)
            End If
        End If
    End Sub
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GF3A_checked_changed()
    End Sub

    Private Sub ModeAdresse_CheckedChanged(sender As Object, e As EventArgs) Handles ModeAdresse.CheckedChanged

        W_Commune.Liste_Adresse_BAN.DataGrid_adresse(ModeAdresse.Checked)

    End Sub
    Public Sub BAN_apply_filter()
        If ListBoxnomvoie.SelectedIndex < 0 Then
            ListBoxnomvoie.SelectedIndex = 0
        End If

        If ListBoxsourcenomvoie.SelectedIndex < 0 Then
            ListBoxsourcenomvoie.SelectedIndex = 0
        End If

        If ListBoxsourceposition.SelectedIndex < 0 Then
            ListBoxsourceposition.SelectedIndex = 0
        End If

        If ListBoxtypeposition.SelectedIndex < 0 Then
            ListBoxtypeposition.SelectedIndex = 0
        End If

        Dim cert As String = "*"
        If ListBoxCertifie.SelectedItem = "Oui" Then
            cert = "1"
        ElseIf ListBoxCertifie.SelectedItem = "Non" Then
            cert = "0"
        End If



        W_Commune.Liste_Adresse_BAN.Apply_Filter(ListBoxnomvoie.SelectedItem,
                                                 ListBoxsourcenomvoie.SelectedItem,
                                                 ListBoxsourceposition.SelectedItem,
                                                 ListBoxtypeposition.SelectedItem,
                                                 cert, ListBoxRefcad.SelectedItem)
        Label3.Text = W_Commune.Liste_Adresse_BAN.Count_Filtered & " adresses sur " &
        W_Commune.Liste_Adresse_BAN.Count & " adresses au total"

    End Sub

    Private Sub ListBoxnomvoie_Click(sender As Object, e As EventArgs) Handles ListBoxnomvoie.Click

        BAN_apply_filter()

    End Sub

    Private Sub ListBoxRefcad_Click(sender As Object, e As EventArgs) Handles ListBoxRefcad.Click
        BAN_apply_filter()
    End Sub

    Private Sub ListBoxsourcenomvoie_Click(sender As Object, e As EventArgs) Handles ListBoxsourcenomvoie.Click
        BAN_apply_filter()
    End Sub

    Private Sub ListBoxsourceposition_Click(sender As Object, e As EventArgs) Handles ListBoxsourceposition.Click
        BAN_apply_filter()
    End Sub

    Private Sub ListBoxtypeposition_Click(sender As Object, e As EventArgs) Handles ListBoxtypeposition.Click
        BAN_apply_filter()
    End Sub

    Private Sub ListBoxCertifie_Click(sender As Object, e As EventArgs) Handles ListBoxCertifie.Click
        BAN_apply_filter()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim lcom As comliste = TryCast(DataGridView1.SelectedRows(0).DataBoundItem, comliste)
        If lcom Is Nothing Then

            Exit Sub
        End If
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            lcom.Set_FC(OpenFileDialog1.FileName)
            W_Commune = New commune(lcom)
            W_Commune.Liste_Adresse_BAN.Set_DataGrid(DataGrid_BAN)
            W_Commune.Liste_Voie_FANTOIR.Set_DataGrid(DataGrid_FANTOIR)
            ListBoxnomvoie.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Nom_Voie
            ListBoxsourcenomvoie.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Source_Nom
            ListBoxsourceposition.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Source_Position
            ListBoxtypeposition.DataSource = W_Commune.Liste_Adresse_BAN.Get_Liste_Type_Position

            ListBoxnomvoie.SelectedIndex = -1
            ListBoxsourcenomvoie.SelectedIndex = 0
            ListBoxsourceposition.SelectedIndex = 0
            ListBoxtypeposition.SelectedIndex = 0
            Label3.Text = W_Commune.Liste_Adresse_BAN.Count & " au total"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then

            Using sw As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                For Each p As Adresse_BAN In W_Commune.Liste_Adresse_BAN.Get_Liste
                    sw.WriteLine(p.Csv_line)
                Next
            End Using
            MsgBox("enregistrement effectué", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub DépartementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DépartementToolStripMenuItem.Click
        Dim fich_fant_nat As String = My.Settings.fantoir
        Dim codedep As String = InputBox("departement ?").ToUpper
        Dim sr As New System.IO.StreamReader(fich_fant_nat)
        Dim sw As New System.IO.StreamWriter(fich_fant_nat & "_" & codedep)

        Dim l As String

        Do While Not sr.EndOfStream
            l = sr.ReadLine
            If l.Length = 88 And l.Substring(0, 2) = codedep Then

                sw.WriteLine(l)

            End If
            If l.Length = 120 And l.Substring(0, 2) = codedep Then
                sw.WriteLine(l)

            End If
        Loop
        sr.Close()
        sw.Close()
        fichier_fantoir = fich_fant_nat & "_" & codedep
        If codedep <> "" And codedep.Length = 2 Then
            My.Settings.departement = codedep
            My.Settings.Save()
            listeCommune = New Liste_ComList(fichier_fantoir, DataGridView1, codedep
                                             )
        Else
            Exit Sub
        End If
        MsgBox("désignez le fichier ban du département", MsgBoxStyle.Information
                   )
        Dim f As New OpenFileDialog()
        If f.ShowDialog = DialogResult.OK Then
            fichier_ban_dep = f.FileName

            My.Settings.basedep = fichier_ban_dep
        Else
            MsgBox("impossible de travailler", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub RéinitialiserFANTOIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéinitialiserFANTOIRToolStripMenuItem.Click
        MsgBox("L'application se terminera vous devrez redémarrer", MsgBoxStyle.Critical)
        My.Settings.fantoir = ""
        My.Settings.basedep = ""
        My.Settings.traducteur = ""

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
