<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog3 = New OpenFileDialog()
        Button5 = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGrid_FANTOIR = New DataGridView()
        TabPage2 = New TabPage()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        ListBoxRefcad = New ListBox()
        Label8 = New Label()
        ListBoxCertifie = New ListBox()
        Label7 = New Label()
        ListBoxtypeposition = New ListBox()
        Label6 = New Label()
        ListBoxsourcenomvoie = New ListBox()
        Label5 = New Label()
        ListBoxsourceposition = New ListBox()
        Label2 = New Label()
        ListBoxnomvoie = New ListBox()
        ModeAdresse = New CheckBox()
        DataGrid_BAN = New DataGridView()
        TabPage3 = New TabPage()
        CheckBox1 = New CheckBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DataGrid_gf3a = New DataGridView()
        Button1 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGrid_FANTOIR, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGrid_BAN, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGrid_gf3a, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 32)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 3
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 32)
        Label4.TabIndex = 4
        Label4.Text = "Label4"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(1077, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(729, 286)
        DataGridView1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(880, 510)
        Button2.Name = "Button2"
        Button2.Size = New Size(310, 47)
        Button2.TabIndex = 7
        Button2.Text = "Enregistrer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "txt"
        ' 
        ' OpenFileDialog3
        ' 
        OpenFileDialog3.FileName = "OpenFileDialog3"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 222)
        Button5.Name = "Button5"
        Button5.Size = New Size(238, 44)
        Button5.TabIndex = 10
        Button5.Text = "Initialiser Fichiers"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 336)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1858, 831)
        TabControl1.TabIndex = 12
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Cyan
        TabPage1.Controls.Add(DataGrid_FANTOIR)
        TabPage1.Location = New Point(8, 46)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1842, 777)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Fantoir"
        ' 
        ' DataGrid_FANTOIR
        ' 
        DataGrid_FANTOIR.AllowUserToAddRows = False
        DataGrid_FANTOIR.AllowUserToDeleteRows = False
        DataGrid_FANTOIR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid_FANTOIR.Location = New Point(15, 21)
        DataGrid_FANTOIR.Name = "DataGrid_FANTOIR"
        DataGrid_FANTOIR.ReadOnly = True
        DataGrid_FANTOIR.RowHeadersWidth = 82
        DataGrid_FANTOIR.RowTemplate.Height = 41
        DataGrid_FANTOIR.Size = New Size(1809, 505)
        DataGrid_FANTOIR.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        TabPage2.Controls.Add(Button3)
        TabPage2.Controls.Add(GroupBox2)
        TabPage2.Controls.Add(ModeAdresse)
        TabPage2.Controls.Add(DataGrid_BAN)
        TabPage2.Location = New Point(8, 46)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1842, 777)
        TabPage2.TabIndex = 1
        TabPage2.Text = "BAN"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(ListBoxRefcad)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(ListBoxCertifie)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ListBoxtypeposition)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(ListBoxsourcenomvoie)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(ListBoxsourceposition)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(ListBoxnomvoie)
        GroupBox2.Location = New Point(71, 543)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1458, 188)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Filtres"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(1310, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 32)
        Label9.TabIndex = 14
        Label9.Text = "Ref Cad"
        ' 
        ' ListBoxRefcad
        ' 
        ListBoxRefcad.FormattingEnabled = True
        ListBoxRefcad.ItemHeight = 32
        ListBoxRefcad.Items.AddRange(New Object() {"*", "Oui", "Non"})
        ListBoxRefcad.Location = New Point(1310, 54)
        ListBoxRefcad.Name = "ListBoxRefcad"
        ListBoxRefcad.Size = New Size(112, 100)
        ListBoxRefcad.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1167, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 32)
        Label8.TabIndex = 12
        Label8.Text = "Certifiée"
        ' 
        ' ListBoxCertifie
        ' 
        ListBoxCertifie.FormattingEnabled = True
        ListBoxCertifie.ItemHeight = 32
        ListBoxCertifie.Items.AddRange(New Object() {"*", "Oui", "Non"})
        ListBoxCertifie.Location = New Point(1167, 56)
        ListBoxCertifie.Name = "ListBoxCertifie"
        ListBoxCertifie.Size = New Size(118, 100)
        ListBoxCertifie.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(945, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 32)
        Label7.TabIndex = 9
        Label7.Text = "Type Position"
        ' 
        ' ListBoxtypeposition
        ' 
        ListBoxtypeposition.FormattingEnabled = True
        ListBoxtypeposition.ItemHeight = 32
        ListBoxtypeposition.Location = New Point(922, 56)
        ListBoxtypeposition.Name = "ListBoxtypeposition"
        ListBoxtypeposition.Size = New Size(223, 100)
        ListBoxtypeposition.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(716, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 32)
        Label6.TabIndex = 7
        Label6.Text = "Source Nom Voie"
        ' 
        ' ListBoxsourcenomvoie
        ' 
        ListBoxsourcenomvoie.FormattingEnabled = True
        ListBoxsourcenomvoie.ItemHeight = 32
        ListBoxsourcenomvoie.Location = New Point(716, 54)
        ListBoxsourcenomvoie.Name = "ListBoxsourcenomvoie"
        ListBoxsourcenomvoie.Size = New Size(189, 100)
        ListBoxsourcenomvoie.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(513, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 32)
        Label5.TabIndex = 5
        Label5.Text = "Sources Position"
        ' 
        ' ListBoxsourceposition
        ' 
        ListBoxsourceposition.FormattingEnabled = True
        ListBoxsourceposition.ItemHeight = 32
        ListBoxsourceposition.Location = New Point(504, 56)
        ListBoxsourceposition.Name = "ListBoxsourceposition"
        ListBoxsourceposition.Size = New Size(197, 100)
        ListBoxsourceposition.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 32)
        Label2.TabIndex = 3
        Label2.Text = "Noms Voies"
        ' 
        ' ListBoxnomvoie
        ' 
        ListBoxnomvoie.FormattingEnabled = True
        ListBoxnomvoie.ItemHeight = 32
        ListBoxnomvoie.Location = New Point(27, 56)
        ListBoxnomvoie.Name = "ListBoxnomvoie"
        ListBoxnomvoie.Size = New Size(461, 100)
        ListBoxnomvoie.TabIndex = 2
        ' 
        ' ModeAdresse
        ' 
        ModeAdresse.AutoSize = True
        ModeAdresse.Location = New Point(6, 492)
        ModeAdresse.Name = "ModeAdresse"
        ModeAdresse.Size = New Size(217, 36)
        ModeAdresse.TabIndex = 1
        ModeAdresse.Text = "Mode ""Adresse"""
        ModeAdresse.UseVisualStyleBackColor = True
        ' 
        ' DataGrid_BAN
        ' 
        DataGrid_BAN.AllowUserToAddRows = False
        DataGrid_BAN.AllowUserToDeleteRows = False
        DataGrid_BAN.AllowUserToOrderColumns = True
        DataGrid_BAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid_BAN.Location = New Point(13, 17)
        DataGrid_BAN.Name = "DataGrid_BAN"
        DataGrid_BAN.ReadOnly = True
        DataGrid_BAN.RowHeadersWidth = 82
        DataGrid_BAN.RowTemplate.Height = 41
        DataGrid_BAN.Size = New Size(1813, 456)
        DataGrid_BAN.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TabPage3.Controls.Add(CheckBox1)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(DataGrid_gf3a)
        TabPage3.Location = New Point(8, 46)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1842, 777)
        TabPage3.TabIndex = 2
        TabPage3.Text = "BAN TO MAJIC"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(628, 521)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(172, 36)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Type MAJIC"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(357, 484)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(245, 121)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nature Voie"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Checked = True
        RadioButton2.Location = New Point(33, 79)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(137, 36)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Normale"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(33, 37)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(112, 36)
        RadioButton1.TabIndex = 0
        RadioButton1.Text = "Locale"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DataGrid_gf3a
        ' 
        DataGrid_gf3a.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid_gf3a.Location = New Point(11, 6)
        DataGrid_gf3a.Name = "DataGrid_gf3a"
        DataGrid_gf3a.RowHeadersWidth = 82
        DataGrid_gf3a.RowTemplate.Height = 41
        DataGrid_gf3a.Size = New Size(1821, 478)
        DataGrid_gf3a.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1077, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(259, 60)
        Button1.TabIndex = 13
        Button1.Text = "Fichier Communal"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1599, 602)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 51)
        Button3.TabIndex = 16
        Button3.Text = "Enregistrer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1885, 1179)
        Controls.Add(Button1)
        Controls.Add(TabControl1)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "BAN TO MAJIC"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGrid_FANTOIR, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGrid_BAN, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGrid_gf3a, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents Button5 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGrid_FANTOIR As DataGridView
    Friend WithEvents DataGrid_BAN As DataGridView
    Friend WithEvents DataGrid_gf3a As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ModeAdresse As CheckBox
    Friend WithEvents ListBoxnomvoie As ListBox
    Friend WithEvents ListBoxsourcenomvoie As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxsourceposition As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBoxtypeposition As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBoxCertifie As ListBox
    Friend WithEvents ListBoxRefcad As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
