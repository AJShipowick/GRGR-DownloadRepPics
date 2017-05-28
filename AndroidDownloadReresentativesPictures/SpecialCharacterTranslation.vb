Module SpecialCharacterTranslation

    'https://forums.alliedmods.net/showthread.php?t=114798

    Public Sub Translate(ByRef item As String)
        Select Case True
            'á = Ã¡
            Case item.Contains("Ã¡")
                item = item.Replace("Ã¡", "á")
            'é = Ã©
            Case item.Contains("Ã©")
                item = item.Replace("Ã©", "é")
            'í = Ã *
            Case item.Contains("Ã *")
                item = item.Replace("Ã *", "í")
            'ó = Ã³
            Case item.Contains("Ã³")
                item = item.Replace("Ã³", "ó")
            'ú = Ãº
            Case item.Contains("Ãº")
                item = item.Replace("Ãº", "ú")
            'Á = Ã
            Case item.Contains("Ã")
                item = item.Replace("Ã", "Á")
            'É = Ã‰
            Case item.Contains("Ã‰")
                item = item.Replace("Ã‰", "É")
            'Í = Ã
            Case item.Contains("Ã")
                item = item.Replace("Ã", "Í")
            'Ó = Ã“
            Case item.Contains("Ã“"")
                item = item.Replace("Ã“"", "Ó")
            'Ú = Ãš
            Case item.Contains("Ãš")
                item = item.Replace("Ãš", "Ú")
            'ñ = Ã±
            Case item.Contains("Ã±")
                item = item.Replace("Ã±", "ñ")
            'ç = Ã§
            Case item.Contains("Ã§")
                item = item.Replace("Ã§", "ç")
            'Ñ = Ã‘
            Case item.Contains("Ã‘")
                item = item.Replace("Ã‘", "Ñ")
            'Ç = Ã‡
            Case item.Contains("Ã‡")
                item = item.Replace("Ã‡", "Ç")
        End Select
    End Sub

End Module
