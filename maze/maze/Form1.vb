Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        'helado'

        If PictureBox1.Bounds.IntersectsWith(Label8.Bounds) Then

            check1.Visible = True
            Label8.Visible = False


        End If

        'automovil'


        If PictureBox1.Bounds.IntersectsWith(Label7.Bounds) Then

            check2.Visible = True
            Label7.Visible = False

        End If

        'rico'

        If PictureBox1.Bounds.IntersectsWith(Label5.Bounds) Then

            check3.Visible = True
            Label5.Visible = False

        End If

        'bonito'


        If PictureBox1.Bounds.IntersectsWith(Label6.Bounds) Then

            check4.Visible = True
            Label6.Visible = False


        End If

        If PictureBox1.Bounds.IntersectsWith(Label11.Bounds) Then

            noCheck.Visible = True
            Label11.Enabled = False
            Label11.Visible = False
            PictureBox1.Location = New Point(864, 141)
            Label11.Location = New Point(1165, 763)


        End If

        If PictureBox1.Bounds.IntersectsWith(Label10.Bounds) Then

            noCheck2.Visible = True
            Label10.Enabled = False
            Label10.Visible = False
            PictureBox1.Location = New Point(864, 141)
            Label10.Location = New Point(1165, 763)


        End If

        If PictureBox1.Bounds.IntersectsWith(Label12.Bounds) Then

            noCheck3.Visible = True
            Label12.Enabled = False
            Label12.Visible = False
            PictureBox1.Location = New Point(864, 141)
            Label12.Location = New Point(1165, 763)

        End If

        If PictureBox1.Bounds.IntersectsWith(Label9.Bounds) Then

            PictureBox6.Visible = True
            PictureBox7.SendToBack()
            Label9.Visible = False


        End If

        If noCheck.Visible = True AndAlso noCheck2.Visible = True And noCheck3.Visible = True Then

            Label13.Visible = True

        End If



        'move the player with the arrow keys
        Select Case e.KeyCode

            Case Keys.Left ' move your player to left

                PictureBox1.Location = New Point(PictureBox1.Location.X - 5, PictureBox1.Location.Y - 0)

                HitMazeWall()

            Case Keys.Right ' move your player to right

                PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y + 0)

                HitMazeWall()

            Case Keys.Up ' move your player up

                PictureBox1.Location = New Point(PictureBox1.Location.X - 0, PictureBox1.Location.Y - 5)

                HitMazeWall()

            Case Keys.Down ' move your player down

                PictureBox1.Location = New Point(PictureBox1.Location.X + 0, PictureBox1.Location.Y + 5)

                HitMazeWall()

        End Select


    End Sub


    Private Sub HitMazeWall()


        If LabelVer1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer1.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer1.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer1.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer1.Bounds.Left Then
                PictureBox1.Left -= 5

            End If


            If LabelVer2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer2.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer2.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer2.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer2.Bounds.Left Then
                PictureBox1.Left -= 5

            End If


            If LabelVer3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer3.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer3.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer3.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer3.Bounds.Left Then
                PictureBox1.Left -= 5

            End If


            If LabelVer4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer4.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer4.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer4.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer4.Bounds.Left Then
                PictureBox1.Left -= 5

            End If


            If LabelVer5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer5.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer5.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer5.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer5.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer6.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer6.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer6.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer6.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer7.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer7.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer7.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer7.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer8.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer8.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer8.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer8.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer9.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer9.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer3.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer9.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer10.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer10.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer10.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer10.Bounds.Left Then
                PictureBox1.Left -= 5

            End If


            If LabelVer11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer11.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer11.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer11.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer11.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer12.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer12.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer12.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer12.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer14.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer14.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer14.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer14.Bounds.Left Then
                PictureBox1.Left -= 5

            End If

            If LabelVer13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Left < LabelVer13.Bounds.Right And
                PictureBox1.Bounds.Right > LabelVer13.Bounds.Right Then
                PictureBox1.Left += 5

            ElseIf LabelVer13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Right > LabelVer13.Bounds.Left And
                PictureBox1.Bounds.Left < LabelVer13.Bounds.Left Then
                PictureBox1.Left -= 5

            End If




            'prevent player from going through any horizontal walss---------

            'if player hits horizontal walls
            If LabelHor1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor1.Bounds.Bottom And
            PictureBox1.Bounds.Bottom > LabelHor1.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor1.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor1.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor1.Bounds.Top Then

                PictureBox1.Top -= 5

            End If


            If LabelHor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor2.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor2.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor2.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor2.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor2.Bounds.Top Then

                PictureBox1.Top -= 5

            End If


            If LabelHor3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor3.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor3.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor3.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor3.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor3.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor4.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor4.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor4.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor4.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor4.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor5.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor5.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor5.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor5.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor5.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor6.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor6.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor6.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor6.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor7.Bounds.Bottom And
                PictureBox1.Bounds.Bottom > LabelHor7.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor7.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor7.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor7.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor8.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor8.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor8.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor8.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor8.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor9.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor9.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor9.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor9.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor9.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor10.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor10.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor10.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor10.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor10.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor11.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor11.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor11.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor11.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor11.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor12.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor12.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor12.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor12.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor12.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor13.Bounds.Bottom And
   PictureBox1.Bounds.Bottom > LabelHor13.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor13.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor13.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor13.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor14.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor14.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor14.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor14.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor14.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor15.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor15.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor15.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor15.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor15.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor16.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor16.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor16.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor16.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor16.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor17.Bounds.Bottom And
        PictureBox1.Bounds.Bottom > LabelHor17.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor17.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor17.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor17.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

            If LabelHor18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Top < LabelHor18.Bounds.Bottom And
    PictureBox1.Bounds.Bottom > LabelHor18.Bounds.Bottom Then

                PictureBox1.Top += 5

            ElseIf LabelHor18.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Bounds.Bottom > LabelHor18.Bounds.Top And
           PictureBox1.Bounds.Top < LabelHor18.Bounds.Top Then

                PictureBox1.Top -= 5

            End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click




    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class
