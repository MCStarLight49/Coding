Imports System.Data.SQLite

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' [ Form1 로드 ] ---------------------------
        dataLoad() 'DB 로드
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' [ 닉넴 검사 ] ---------------------------
        Dim sameName As Boolean = False

        nName = txtName.Text
        If (nName = "") Then
            lblMainOut.Text = "닉네임을 입력해주세요"
            lblMainOut.ForeColor = Color.Red
        ElseIf (nName.Contains(" ")) Then
            lblMainOut.Text = "닉네임에 공백을 포함할 수 없습니다"
            lblMainOut.ForeColor = Color.Red
        ElseIf (nName.Length > 15) Then
            lblMainOut.Text = "15글자이하로 입력해주세요"
            lblMainOut.ForeColor = Color.Red
        Else
            ' 기존닉넴 검사
            For i = 0 To santaData.Rows.Count - 1
                If (nName = (santaData.Rows(i))("name").ToString()) Then
                    sameName = True
                    Exit For
                End If
            Next
            ' 신규유저
            If (sameName = False) Then
                Using conn As New SQLiteConnection(connectionStr)
                    conn.Open()
                    Dim query As String = "INSERT INTO santa_user (name, gold, red_box, blue_box, green_box, red_lv, blue_lv, green_lv) VALUES (@name, 0, 0, 0, 0, 1, 0, 0)"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", nName)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            ' Form2 이동
            dbSaving = True
            Form2.Show()
            Hide()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' [ 종료 ] ---------------------------
        e.Cancel = santaExit()
    End Sub
End Class