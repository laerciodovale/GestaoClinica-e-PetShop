Module mdVar
    Public Property md_usuario As String
    Public Property md_usuario_aut As Integer
    Public Property md_ID As Integer
    Public Property md_Cpf As String
    Public Property md_Data As Date
    Public Property md_Id_Pet As Integer
    Public Property md_Id_Tutor As Integer
    Public Property md_OS As Integer
    Public Property md_Id_Consulta As Integer
    Function Idade(ByVal nascimento As DateTime) As String
        Try

            ' Return New DateTime((DateTime.Today - nascimento).Ticks).Year - 1
            If nascimento <> "01/01/1900" Then
                Dim date2 As Date = Date.Parse(nascimento)
                Dim date1 As Date = Format(Now, "MMM/dd/yyyy")
                Dim y As Long = DateDiff(DateInterval.Year, date2, Now) - 1
                Dim d As Long = DateDiff(DateInterval.Day, date2, Now)
                Dim m As Long = DateDiff(DateInterval.Month, date2, date1)
                Dim mm As Integer = 12 - date2.Month  ''Now.Month - date2.Month
                If mm < 0 Then
                    mm = mm * -1
                End If

                Return y & " Anos e " & mm & " meses." ' e " & d & " dias "

                'Dim i As Integer, datHoje As Date
                'Dim CalculaIdade As Integer
                'datHoje = Now

                'CalculaIdade = Year(datHoje) - Year(nascimento)

                'If Month(datHoje) < Month(nascimento) Then
                '    CalculaIdade = CalculaIdade - 1
                'ElseIf Month(datHoje) = Month(nascimento) Then
                '    If Day(datHoje) < Day(nascimento) Then
                '        If Month(nascimento) = 2 And Day(nascimento) = 29 Then
                '            i = Year(datHoje)
                '            If Not ((Month(datHoje) = 2 And Day(datHoje) = 28) And Not _
                '            (i Mod 4 = 0 And ((Not i Mod 100 = 0) Or i Mod 400 = 0))) Then
                '                CalculaIdade = CalculaIdade - 1
                '            End If
                '        Else
                '            CalculaIdade = CalculaIdade - 1
                '        End If
                '    End If
                'End If

                ' Return CalculaIdade & " Anos e " & mm & " meses." ' e " & d & " dias "

            Else
                Return " "
            End If
        Catch ex As Exception

        End Try

    End Function

End Module
