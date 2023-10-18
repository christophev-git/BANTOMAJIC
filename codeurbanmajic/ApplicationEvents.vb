﻿Imports Microsoft.VisualBasic.ApplicationServices

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

            If My.Settings.commdep = "" Then
                MsgBox("désignez le fichier communes du département", MsgBoxStyle.Information
                   )
                Dim f As New OpenFileDialog()
                If f.ShowDialog = DialogResult.OK Then
                    fichier_commune_dep = f.FileName

                    My.Settings.commdep = fichier_commune_dep
                Else
                    MsgBox("impossible de travailler", MsgBoxStyle.Critical)

                End If
            Else
                fichier_commune_dep = My.Settings.commdep
            End If
            If My.Settings.traducteur = "" Then
                MsgBox("désignez le fichier des typesde voies", MsgBoxStyle.Information
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
            End If
            My.Settings.Save()
        End Sub
    End Class
End Namespace