Public Class traduction
    Private m_dic_trad As dic_traduction
    Public ReadOnly Property Dic_Trad() As dic_traduction
        Get
            Return m_dic_trad
        End Get
    End Property

    Private m_translated As String
    Public ReadOnly Property Translated() As String
        Get
            Return m_translated
        End Get

    End Property
    Private m_to_translate As String
    Public ReadOnly Property To_Translate() As String
        Get
            Return m_to_translate
        End Get

    End Property

    Public Sub New(totranslate As String, trad As traducteur)
        m_to_translate = totranslate
        m_dic_trad = trad.From_Locale(totranslate)
        If m_dic_trad.Normale <> "" Then
            If totranslate.Length >= m_dic_trad.Normale.Length + 1 Then
                m_translated = totranslate.Substring(m_dic_trad.Normale.Length + 1)
            Else
                m_translated = totranslate
            End If


        Else
                m_translated = totranslate

        End If
    End Sub
End Class
