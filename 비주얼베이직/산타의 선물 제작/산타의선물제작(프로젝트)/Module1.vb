Imports System.Data.SQLite

Module Module1
    ' 상대경로
    Public connectionStr As String = "Data Source=.\santaData.db;Version=3"
    Public santaData As New DataTable()
    Public sExit As Boolean = True
    Public dbSaving As Boolean = False
    ' 유저데이터 변수
    Public nName As String '닉넴
    Public gold As Integer '골드
    Public redBox As Integer '빨강상자
    Public blueBox As Integer '파랑상자
    Public GreenBox As Integer '초록상자
    Public redLv As Integer '산타 Lv
    Public blueLv As Integer '브리니 Lv
    Public greenLv As Integer '그리니 Lv

    Public Sub dataLoad()
        ' [ DB 불러오기 ] ---------------------------
        Using conn As New SQLiteConnection(connectionStr)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM santa_user", conn)
            Dim adapter As New SQLiteDataAdapter(cmd)
            adapter.Fill(santaData)
        End Using
    End Sub
    Private Sub dataSave()
        ' [ DB 저장 ] ---------------------------
        Using conn As New SQLiteConnection(connectionStr)
            conn.Open()
            Dim query As String = "UPDATE santa_user SET gold = @gold, red_box = @red_box, blue_box = @blue_box, green_box = @green_box, red_lv = @red_lv, blue_lv = @blue_lv, green_lv = @green_lv
                                   WHERE name = @name"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", nName)
                cmd.Parameters.AddWithValue("@gold", gold)
                cmd.Parameters.AddWithValue("@red_box", redBox)
                cmd.Parameters.AddWithValue("@blue_box", blueBox)
                cmd.Parameters.AddWithValue("@green_box", GreenBox)
                cmd.Parameters.AddWithValue("@red_lv", redLv)
                cmd.Parameters.AddWithValue("@blue_lv", blueLv)
                cmd.Parameters.AddWithValue("@green_lv", greenLv)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function santaExit()
        ' [ 종료함수 ] ---------------------------
        If (sExit) Then
            Dim dlgRe As DialogResult = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.OKCancel)
            If (dlgRe = DialogResult.Cancel) Then
                Return True '종료 X
            Else
                sExit = False
                If (dbSaving = True) Then dataSave() ' 저장
                Return False '종료 O
            End If
        Else
            Return 0
        End If
    End Function
End Module
