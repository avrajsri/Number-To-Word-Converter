Public Class Main
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Box2.Text = "Null"
        Try
            Box3.Text = Int(Box1.Text)
            If (0 > Int(Box1.Text)) Then
                Box3.Text = "Only +Ve Number"

            ElseIf (100 < Int(Box1.Text)) Then
                Box3.Text = "Only Number(0-100)"

            Else
                Box2.Text = Int(Box1.Text)
                Box3.Text = "Wait..."
                Dim x As String
                Dim l As Integer
                x = Box2.Text
                l = Len(x)

                If (l = 1) Then
                    Select Case Int(Box1.Text)
                        Case "0" : Box3.Text = "ZERO"
                        Case "1" : Box3.Text = "ONE"
                        Case "2" : Box3.Text = "TWO"
                        Case "3" : Box3.Text = "THREE"
                        Case "4" : Box3.Text = "FOUR"
                        Case "5" : Box3.Text = "FIVE"
                        Case "6" : Box3.Text = "SIX"
                        Case "7" : Box3.Text = "SEVEN"
                        Case "8" : Box3.Text = "EIGHT"
                        Case "9" : Box3.Text = "NINE"
                    End Select

                ElseIf (l = 3) Then
                    Box3.Text = "ONE HUNDRED"

                Else
                    If (Int(Box1.Text) < "21" Or Int(Box1.Text) = "30" Or Int(Box1.Text) = "40" Or Int(Box1.Text) = "50" Or Int(Box1.Text) = "60" Or Int(Box1.Text) = "70" Or Int(Box1.Text) = "80" Or Int(Box1.Text) = "90") Then

                        Select Case Int(Box1.Text)
                            Case "10" : Box3.Text = "TEN"
                            Case "11" : Box3.Text = "ELEVEN"
                            Case "12" : Box3.Text = "TWELVE"
                            Case "13" : Box3.Text = "THIRTEEN"
                            Case "14" : Box3.Text = "FOURTEEN"
                            Case "15" : Box3.Text = "FIFTEEN"
                            Case "16" : Box3.Text = "SIXTEEN"
                            Case "17" : Box3.Text = "SEVENTEEN"
                            Case "18" : Box3.Text = "EIGHTEEN"
                            Case "19" : Box3.Text = "NINETEEN"

                            Case "20" : Box3.Text = "TWENTY"
                            Case "30" : Box3.Text = "THIRTY"
                            Case "40" : Box3.Text = "FORTY"
                            Case "50" : Box3.Text = "FIFTY"
                            Case "60" : Box3.Text = "SIXTY"
                            Case "70" : Box3.Text = "SEVENTY"
                            Case "80" : Box3.Text = "EIGHTY"
                            Case "90" : Box3.Text = "NINETY"
                        End Select

                    Else Box3.Text = "Working..."

                        Dim m, n, f1, f2 As Integer
                        m = 10
                        n = Int(Box2.Text)
                        f1 = Int(n / m)
                        f2 = n - (m * f1)

                        Dim p1, p2 As String
                        p1 = ""
                        p2 = ""

                        Select Case Int(f1)
                            Case "2" : p1 = "TWENTY"
                            Case "3" : p1 = "THIRTY"
                            Case "4" : p1 = "FORTY"
                            Case "5" : p1 = "FIFTY"
                            Case "6" : p1 = "SIXTY"
                            Case "7" : p1 = "SEVENTY"
                            Case "8" : p1 = "EIGHTY"
                            Case "9" : p1 = "NINETY"
                        End Select

                        Select Case Int(f2)
                            Case "1" : p2 = " ONE"
                            Case "2" : p2 = " TWO"
                            Case "3" : p2 = " THREE"
                            Case "4" : p2 = " FOUR"
                            Case "5" : p2 = " FIVE"
                            Case "6" : p2 = " SIX"
                            Case "7" : p2 = " SEVEN"
                            Case "8" : p2 = " EIGHT"
                            Case "9" : p2 = " NINE"
                        End Select

                        Box3.Text = p1 + p2

                    End If

                End If

            End If

        Catch ex As Exception
            Box3.Text = "Only INT Number"

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.google.co.in/search?q=anand+vijay+rajsri")
    End Sub
End Class