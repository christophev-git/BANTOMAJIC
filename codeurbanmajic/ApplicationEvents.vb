Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication
        Private Sub MyApplication_StartUp(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If My.Settings.basedep = "" Then
                MsgBox("désignez le fichier ban du département", MsgBoxStyle.Information
                   )
                Dim f As New OpenFileDialog()
                If f.ShowDialog = DialogResult.OK Then
                    fichier_ban_dep = f.FileName

                    My.Settings.basedep = fichier_ban_dep
                Else
                    MsgBox("impossible de travailler", MsgBoxStyle.Critical)

                End If
            Else
                fichier_ban_dep = My.Settings.basedep
            End If


            If My.Settings.traducteur = "" Then
                MsgBox("désignez le fichier des types de voies", MsgBoxStyle.Information
                   )
                Dim f As New OpenFileDialog()
                If f.ShowDialog = DialogResult.OK Then
                    fichier_traduction = f.FileName

                    My.Settings.traducteur = fichier_traduction
                Else
                    MsgBox("impossible de travailler", MsgBoxStyle.Critical)

                End If
            Else
                fichier_traduction = My.Settings.traducteur
                W_traducteur = New traducteur(fichier_traduction)

            End If

            Dim fich_fant_nat As String = ""
            If My.Settings.fantoir = "" Then
                MsgBox("désignez le fichier FANTOIR NATIONAL", MsgBoxStyle.Information
                   )

                Dim f As New OpenFileDialog()
                If f.ShowDialog = DialogResult.OK Then
                    fich_fant_nat = f.FileName


                Else
                    MsgBox("impossible de travailler", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else

                fich_fant_nat = My.Settings.fantoir
            End If
            My.Settings.Save()


            Dim codedep As String = InputBox("departement ?")
            Dim sr As New System.IO.StreamReader(fich_fant_nat)
            Dim sw As New System.IO.StreamWriter(fich_fant_nat & "_" & codedep)

            Dim l As String

            Do While Not sr.EndOfStream
                l = sr.ReadLine
                If l.Length = 88 And l.Substring(0, 2) = codedep Then
                    sw.WriteLine(l)

                End If
            Loop
            sr.Close()
            sw.Close()
            fichier_fantoir = fich_fant_nat & "_" & codedep
            If codedep <> "" And codedep.Length = 2 Then

                My.Settings.Save()
                listeCommune = New Liste_ComList(fichier_fantoir, Form1.DataGridView1, codedep
                                                 )
            Else
                Exit Sub
            End If


        End Sub
    End Class
End Namespace
