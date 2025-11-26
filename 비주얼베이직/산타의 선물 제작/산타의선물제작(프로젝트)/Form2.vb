Imports System.Data.SQLite
Imports System.Media
Imports NAudio.Wave

Public Class Form2
    ' ({[ 변수선언 ]}) ----------------------------------------------------------------------------
    ' [ 브금/효과음 ]
    Dim bgmXmas As WaveOutEvent = New WaveOutEvent()
    Dim sfxSale As New SoundPlayer(".\sfxSale.wav")
    ' [ 업글비용 ]
    Dim redUpMoney As Integer
    Dim blueUpMoney As Integer
    Dim greenUpMoney As Integer



    ' ({[ 브금관련 ]}) ----------------------------------------------------------------------------
    Private Sub bgmStart()
        ' [ 브금재생 ]
        Dim bgmFile As New AudioFileReader(".\bgmXmasBox.wav")
        bgmXmas.Init(bgmFile)
        bgmXmas.Play()
        bgmTimer.Enabled = True
        btnBgm.Text = "❚❚"
        stalblBgm.Text = "브금 On"
    End Sub
    Private Sub bgmStop()
        ' [ 브금정지 ]
        If bgmXmas IsNot Nothing Then
            bgmXmas.Stop()
            bgmXmas.Dispose()
            bgmTimer.Enabled = False
            btnBgm.Text = " ▶"
            stalblBgm.Text = "브금 Off"
        End If
    End Sub
    Private Sub btnBgm_Click(sender As Object, e As EventArgs) Handles btnBgm.Click
        ' [ 브금 On/Off ]
        If bgmTimer.Enabled = True Then
            bgmStop()
        Else
            bgmStart()
        End If
    End Sub
    Private Sub bgmTimer_Tick(sender As Object, e As EventArgs) Handles bgmTimer.Tick
        ' [ 브금 반복재생 ]
        bgmStop()
        bgmStart()
    End Sub



    ' ({[ 화면출력 ]}) ----------------------------------------------------------------------------
    Private Sub numPrint(arrStr As String(), Optional triG As Boolean = False)
        ' [ 숫자출력변환 ]
        For i = 0 To UBound(arrStr)
            Dim len As Integer = arrStr(i).Length
            If (len > 3) Then
                arrStr(i) = arrStr(i).Insert(len - 3, ",")
                If (len > 6) Then
                    arrStr(i) = arrStr(i).Insert(len - 6, ",")
                    If (len > 9) Then
                        arrStr(i) = arrStr(i).Insert(len - 9, ",")
                    End If
                End If
            End If
            If (triG) Then arrStr(i) += vbCrLf & "골드"
        Next
    End Sub
    Private Sub displayShowMoney()
        ' [ 화면출력 (재화) ]
        Dim lblStr() As String = {gold.ToString(), redBox.ToString(), blueBox.ToString(), GreenBox.ToString()}
        numPrint(lblStr) '숫자변환
        lblGold.Text = lblStr(0)
        lblRed.Text = lblStr(1)
        lblBlue.Text = lblStr(2)
        lblGreen.Text = lblStr(3)
    End Sub
    Private Sub displayShowLv()
        ' [ 화면출력 (레벨/비용/이미지) ]
        ' 레벨
        lblUpRed.Text = $"산타 Lv.{redLv}{vbCrLf}빨강선물 +{redLv}"
        lblUpBlue.Text = $"브리니 Lv.{blueLv}{vbCrLf}파랑선물 +{blueLv}"
        lblUpGreen.Text = $"그리니 Lv.{greenLv}{vbCrLf}초록선물 +{greenLv}"

        UpMoney() ' 업글비용업뎃
        Dim btnUpStr() As String = {redUpMoney.ToString(), blueUpMoney.ToString(), greenUpMoney.ToString()}
        numPrint(btnUpStr, True) '숫자변환

        ' 비용
        If (redLv < 100) Then
            btnUpRed.Text = btnUpStr(0)
        Else
            btnUpRed.BackColor = Color.Silver
            btnUpRed.Text = "최고 레벨"
        End If

        If (blueLv < 100) Then
            btnUpBlue.Text = btnUpStr(1)
        Else
            btnUpBlue.BackColor = Color.Silver
            btnUpBlue.Text = "최고 레벨"
        End If

        If (greenLv < 100) Then
            btnUpGreen.Text = btnUpStr(2)
        Else
            btnUpGreen.BackColor = Color.Silver
            btnUpGreen.Text = "최고 레벨"
        End If

        ' 이미지
        If (blueLv > 0) Then picBlue.Show()
        If (greenLv > 0) Then picGreen.Show()
    End Sub



    ' ({[ 재화획득 ]}) ----------------------------------------------------------------------------
    Private Sub picSanta_MouseClick(sender As Object, e As MouseEventArgs) Handles picSanta.MouseClick
        '[ 산타클릭 ]
        redBox += redLv
        Dim redStr() As String = {redBox.ToString()}
        numPrint(redStr)
        lblRed.Text = redStr(0)
    End Sub
    Private Sub moneyTimer_Tick(sender As Object, e As EventArgs) Handles moneyTimer.Tick
        '[ 초당선물 ]
        blueBox += blueLv
        GreenBox += greenLv
        displayShowMoney()
    End Sub



    ' ({[ 선물판매 ]}) ----------------------------------------------------------------------------
    Private Sub btnSaleRed_Click(sender As Object, e As EventArgs) Handles btnSaleRed.Click
        '[ 빨강판매 ]
        If (redBox > 0) Then
            gold += redBox
            redBox = 0
            sfxSale.Play()
            displayShowMoney()
        End If
    End Sub
    Private Sub btnSaleBlue_Click(sender As Object, e As EventArgs) Handles btnSaleBlue.Click
        '[ 파랑판매 ]
        If (blueBox > 0) Then
            gold += blueBox * 2
            blueBox = 0
            sfxSale.Play()
            displayShowMoney()
        End If
    End Sub
    Private Sub btnSaleGreen_Click(sender As Object, e As EventArgs) Handles btnSaleGreen.Click
        '[ 초록판매 ]
        If (GreenBox > 0) Then
            gold += GreenBox * 3
            GreenBox = 0
            sfxSale.Play()
            displayShowMoney()
        End If
    End Sub



    ' ({[ 업그레이드 ]}) ----------------------------------------------------------------------------
    Private Sub btnUpRed_Click(sender As Object, e As EventArgs) Handles btnUpRed.Click
        '[ 빨강업글 ]
        If (redLv < 100 And gold >= redUpMoney) Then
            redLv += 1
            gold -= redUpMoney
            sfxSale.Play()
            displayShowMoney()
            displayShowLv()
        End If
    End Sub

    Private Sub btnUpBlue_Click(sender As Object, e As EventArgs) Handles btnUpBlue.Click
        '[ 파랑업글 ]
        If (blueLv < 100 And gold >= blueUpMoney) Then
            blueLv += 1
            gold -= blueUpMoney
            sfxSale.Play()
            displayShowMoney()
            displayShowLv()
        End If
    End Sub

    Private Sub btnUpGreen_Click(sender As Object, e As EventArgs) Handles btnUpGreen.Click
        '[ 초록업글 ]
        If (greenLv < 100 And gold >= greenUpMoney) Then
            greenLv += 1
            gold -= greenUpMoney
            sfxSale.Play()
            displayShowMoney()
            displayShowLv()
        End If
    End Sub



    ' ({[ 종료 ]}) ----------------------------------------------------------------------------
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' [ 종료(버튼) ]
        Form1.Close()
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' [ 종료(창) ]
        If (santaExit()) Then
            e.Cancel = True
        Else
            Form1.Close()
        End If
    End Sub



    ' ({[ 메뉴이동 ]}) ----------------------------------------------------------------------------
    Private Sub btnMenuToUp_Click(sender As Object, e As EventArgs) Handles btnMenuToUp.Click
        '[ 메뉴 -> 업글 ]
        groupMenu.Hide()
        groupUp.Show()
    End Sub

    Private Sub btnMenuToSale_Click(sender As Object, e As EventArgs) Handles btnMenuToSale.Click
        '[ 메뉴 -> 판매 ]
        groupMenu.Hide()
        groupSale.Show()
    End Sub

    Private Sub btnSaleToMenu_Click(sender As Object, e As EventArgs) Handles btnSaleToMenu.Click
        '[ 판매 -> 메뉴 ]
        groupSale.Hide()
        groupMenu.Show()
    End Sub

    Private Sub btnUpToMenu_Click(sender As Object, e As EventArgs) Handles btnUpToMenu.Click
        '[ 업글 -> 메뉴 ]
        groupUp.Hide()
        groupMenu.Show()
    End Sub



    ' ({[ 기타 ]}) ----------------------------------------------------------------------------
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' [ Form2 로드 ]
        ' 브금 재생
        bgmStart()
        ' 그룹박스 위치 설정
        groupUp.Location = groupMenu.Location
        groupSale.Location = groupMenu.Location

        ' 유저데이터 로드
        Using conn As New SQLiteConnection(connectionStr)
            conn.Open()
            Dim query As String = "SELECT * FROM santa_user WHERE name LIKE @name"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", nName)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader()
                reader.Read()
                '데이터 로드 및 변수에 저장
                nName = reader("name").ToString()
                gold = reader("gold")
                redBox = reader("red_box")
                blueBox = reader("blue_box")
                GreenBox = reader("green_box")
                redLv = reader("red_lv")
                blueLv = reader("blue_lv")
                greenLv = reader("green_lv")
                reader.Close()
            End Using
        End Using
        ' 화면출력
        lblName.Text = nName
        displayShowMoney()
        displayShowLv()
    End Sub
    Private Sub UpMoney()
        ' [ 업글비용 계산식 ]
        redUpMoney = redLv + 9 + (0.5 * (redLv ^ 4))
        blueUpMoney = ((blueLv + 1) * 100) + (10 * ((blueLv + 1) ^ 3))
        greenUpMoney = ((greenLv + 1) * 300) + (20 * ((greenLv + 1) ^ 3))
    End Sub
End Class