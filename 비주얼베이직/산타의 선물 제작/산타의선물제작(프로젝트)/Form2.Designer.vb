<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        groupMenu = New GroupBox()
        btnMenuToSale = New Button()
        btnMenuToUp = New Button()
        btnBgm = New Button()
        sta = New StatusStrip()
        stalblBgm = New ToolStripStatusLabel()
        Label1 = New Label()
        Label2 = New Label()
        btnExit = New Button()
        picSanta = New PictureBox()
        picGreen = New PictureBox()
        picBlue = New PictureBox()
        Label3 = New Label()
        lblName = New Label()
        lblGold = New Label()
        Label5 = New Label()
        lblRed = New Label()
        lblBlue = New Label()
        lblGreen = New Label()
        groupUp = New GroupBox()
        btnUpGreen = New Button()
        lblUpGreen = New Label()
        btnUpBlue = New Button()
        lblUpBlue = New Label()
        btnUpRed = New Button()
        btnUpToMenu = New Button()
        lblUpRed = New Label()
        groupSale = New GroupBox()
        Label14 = New Label()
        btnSaleGreen = New Button()
        PictureBox3 = New PictureBox()
        Label13 = New Label()
        btnSaleBlue = New Button()
        PictureBox2 = New PictureBox()
        Label12 = New Label()
        btnSaleToMenu = New Button()
        btnSaleRed = New Button()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        bgmTimer = New Timer(components)
        moneyTimer = New Timer(components)
        groupMenu.SuspendLayout()
        sta.SuspendLayout()
        CType(picSanta, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBlue, ComponentModel.ISupportInitialize).BeginInit()
        groupUp.SuspendLayout()
        groupSale.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' groupMenu
        ' 
        groupMenu.BackColor = SystemColors.ActiveCaptionText
        groupMenu.Controls.Add(btnMenuToSale)
        groupMenu.Controls.Add(btnMenuToUp)
        groupMenu.Font = New Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        groupMenu.ForeColor = SystemColors.ControlLightLight
        groupMenu.Location = New Point(0, 480)
        groupMenu.Name = "groupMenu"
        groupMenu.Size = New Size(944, 96)
        groupMenu.TabIndex = 2
        groupMenu.TabStop = False
        groupMenu.Text = "메뉴"
        ' 
        ' btnMenuToSale
        ' 
        btnMenuToSale.BackColor = Color.LightBlue
        btnMenuToSale.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnMenuToSale.FlatAppearance.BorderSize = 0
        btnMenuToSale.FlatStyle = FlatStyle.Flat
        btnMenuToSale.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnMenuToSale.ForeColor = SystemColors.ActiveCaptionText
        btnMenuToSale.Location = New Point(533, 38)
        btnMenuToSale.Name = "btnMenuToSale"
        btnMenuToSale.Size = New Size(120, 40)
        btnMenuToSale.TabIndex = 1
        btnMenuToSale.Text = "선물배달"
        btnMenuToSale.UseVisualStyleBackColor = False
        ' 
        ' btnMenuToUp
        ' 
        btnMenuToUp.BackColor = Color.LightBlue
        btnMenuToUp.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnMenuToUp.FlatAppearance.BorderSize = 0
        btnMenuToUp.FlatStyle = FlatStyle.Flat
        btnMenuToUp.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnMenuToUp.ForeColor = SystemColors.ActiveCaptionText
        btnMenuToUp.Location = New Point(291, 38)
        btnMenuToUp.Name = "btnMenuToUp"
        btnMenuToUp.Size = New Size(120, 40)
        btnMenuToUp.TabIndex = 0
        btnMenuToUp.Text = "업그레이드"
        btnMenuToUp.UseVisualStyleBackColor = False
        ' 
        ' btnBgm
        ' 
        btnBgm.BackColor = Color.LightBlue
        btnBgm.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnBgm.FlatAppearance.BorderSize = 0
        btnBgm.FlatStyle = FlatStyle.Flat
        btnBgm.Location = New Point(882, 86)
        btnBgm.Name = "btnBgm"
        btnBgm.Size = New Size(50, 50)
        btnBgm.TabIndex = 1
        btnBgm.TabStop = False
        btnBgm.Text = "❚❚"
        btnBgm.UseVisualStyleBackColor = False
        ' 
        ' sta
        ' 
        sta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        sta.AutoSize = False
        sta.Dock = DockStyle.None
        sta.Items.AddRange(New ToolStripItem() {stalblBgm})
        sta.Location = New Point(0, 576)
        sta.Name = "sta"
        sta.Size = New Size(944, 25)
        sta.TabIndex = 2
        sta.Text = "StatusStrip1"
        ' 
        ' stalblBgm
        ' 
        stalblBgm.BackColor = Color.Transparent
        stalblBgm.Font = New Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(129))
        stalblBgm.Name = "stalblBgm"
        stalblBgm.Size = New Size(69, 20)
        stalblBgm.Text = "브금 On"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(800, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 50)
        Label1.TabIndex = 3
        Label1.Text = "브금" & vbCrLf & "On/Off"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label2.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(816, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 25)
        Label2.TabIndex = 5
        Label2.Text = "종료"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Maroon
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnExit.ForeColor = Color.Red
        btnExit.Location = New Point(882, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(50, 50)
        btnExit.TabIndex = 0
        btnExit.TabStop = False
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' picSanta
        ' 
        picSanta.BackColor = Color.Transparent
        picSanta.Image = CType(resources.GetObject("picSanta.Image"), Image)
        picSanta.Location = New Point(299, 162)
        picSanta.Name = "picSanta"
        picSanta.Size = New Size(346, 366)
        picSanta.SizeMode = PictureBoxSizeMode.Zoom
        picSanta.TabIndex = 6
        picSanta.TabStop = False
        ' 
        ' picGreen
        ' 
        picGreen.BackColor = Color.Transparent
        picGreen.Image = CType(resources.GetObject("picGreen.Image"), Image)
        picGreen.Location = New Point(651, 241)
        picGreen.Name = "picGreen"
        picGreen.Size = New Size(94, 80)
        picGreen.SizeMode = PictureBoxSizeMode.Zoom
        picGreen.TabIndex = 7
        picGreen.TabStop = False
        picGreen.Visible = False
        ' 
        ' picBlue
        ' 
        picBlue.BackColor = Color.Transparent
        picBlue.Image = CType(resources.GetObject("picBlue.Image"), Image)
        picBlue.Location = New Point(199, 241)
        picBlue.Name = "picBlue"
        picBlue.Size = New Size(94, 80)
        picBlue.SizeMode = PictureBoxSizeMode.Zoom
        picBlue.TabIndex = 8
        picBlue.TabStop = False
        picBlue.Visible = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label3.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(19, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 999
        Label3.Text = "닉네임 : "
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblName.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblName.ForeColor = SystemColors.ButtonHighlight
        lblName.Location = New Point(99, 12)
        lblName.Name = "lblName"
        lblName.Size = New Size(297, 25)
        lblName.TabIndex = 999
        lblName.Text = "일이삼사오육칠팔구십일이삼사오"
        lblName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblGold
        ' 
        lblGold.AutoSize = True
        lblGold.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblGold.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblGold.ForeColor = SystemColors.ButtonHighlight
        lblGold.Location = New Point(99, 45)
        lblGold.Name = "lblGold"
        lblGold.Size = New Size(105, 25)
        lblGold.TabIndex = 999
        lblGold.Text = "1000,1000"
        lblGold.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label5.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(19, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 999
        Label5.Text = "골드 :"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblRed
        ' 
        lblRed.AutoSize = True
        lblRed.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblRed.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblRed.ForeColor = SystemColors.ButtonHighlight
        lblRed.Location = New Point(99, 78)
        lblRed.Name = "lblRed"
        lblRed.Size = New Size(105, 25)
        lblRed.TabIndex = 999
        lblRed.Text = "1000,1000"
        lblRed.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBlue
        ' 
        lblBlue.AutoSize = True
        lblBlue.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblBlue.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblBlue.ForeColor = SystemColors.ButtonHighlight
        lblBlue.Location = New Point(99, 111)
        lblBlue.Name = "lblBlue"
        lblBlue.Size = New Size(105, 25)
        lblBlue.TabIndex = 999
        lblBlue.Text = "1000,1000"
        lblBlue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblGreen
        ' 
        lblGreen.AutoSize = True
        lblGreen.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblGreen.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblGreen.ForeColor = SystemColors.ButtonHighlight
        lblGreen.Location = New Point(99, 144)
        lblGreen.Name = "lblGreen"
        lblGreen.Size = New Size(105, 25)
        lblGreen.TabIndex = 999
        lblGreen.Text = "1000,1000"
        lblGreen.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' groupUp
        ' 
        groupUp.BackColor = SystemColors.ActiveCaptionText
        groupUp.Controls.Add(btnUpGreen)
        groupUp.Controls.Add(lblUpGreen)
        groupUp.Controls.Add(btnUpBlue)
        groupUp.Controls.Add(lblUpBlue)
        groupUp.Controls.Add(btnUpRed)
        groupUp.Controls.Add(btnUpToMenu)
        groupUp.Controls.Add(lblUpRed)
        groupUp.Font = New Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        groupUp.ForeColor = SystemColors.ControlLightLight
        groupUp.Location = New Point(0, 378)
        groupUp.Name = "groupUp"
        groupUp.Size = New Size(944, 96)
        groupUp.TabIndex = 2
        groupUp.TabStop = False
        groupUp.Text = "업그레이드"
        groupUp.Visible = False
        ' 
        ' btnUpGreen
        ' 
        btnUpGreen.BackColor = Color.PaleGreen
        btnUpGreen.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnUpGreen.FlatAppearance.BorderSize = 0
        btnUpGreen.FlatStyle = FlatStyle.Flat
        btnUpGreen.Font = New Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnUpGreen.ForeColor = SystemColors.ActiveCaptionText
        btnUpGreen.Location = New Point(670, 33)
        btnUpGreen.Name = "btnUpGreen"
        btnUpGreen.Size = New Size(130, 50)
        btnUpGreen.TabIndex = 2
        btnUpGreen.Text = "최고 레벨"
        btnUpGreen.UseVisualStyleBackColor = False
        ' 
        ' lblUpGreen
        ' 
        lblUpGreen.AutoSize = True
        lblUpGreen.Font = New Font("맑은 고딕", 12.75F, FontStyle.Bold)
        lblUpGreen.ForeColor = Color.Lime
        lblUpGreen.Location = New Point(547, 35)
        lblUpGreen.Name = "lblUpGreen"
        lblUpGreen.Size = New Size(126, 46)
        lblUpGreen.TabIndex = 24
        lblUpGreen.Text = "그리니 Lv.100" & vbCrLf & "초록선물 +100"
        lblUpGreen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnUpBlue
        ' 
        btnUpBlue.BackColor = Color.PaleGreen
        btnUpBlue.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnUpBlue.FlatAppearance.BorderSize = 0
        btnUpBlue.FlatStyle = FlatStyle.Flat
        btnUpBlue.Font = New Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnUpBlue.ForeColor = SystemColors.ActiveCaptionText
        btnUpBlue.Location = New Point(400, 33)
        btnUpBlue.Name = "btnUpBlue"
        btnUpBlue.Size = New Size(130, 50)
        btnUpBlue.TabIndex = 1
        btnUpBlue.Text = "1000,1000" & vbCrLf & "골드"
        btnUpBlue.UseVisualStyleBackColor = False
        ' 
        ' lblUpBlue
        ' 
        lblUpBlue.AutoSize = True
        lblUpBlue.Font = New Font("맑은 고딕", 12.75F, FontStyle.Bold)
        lblUpBlue.ForeColor = Color.Cyan
        lblUpBlue.Location = New Point(277, 35)
        lblUpBlue.Name = "lblUpBlue"
        lblUpBlue.Size = New Size(126, 46)
        lblUpBlue.TabIndex = 22
        lblUpBlue.Text = "브리니 Lv.100" & vbCrLf & "파랑선물 +100"
        lblUpBlue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnUpRed
        ' 
        btnUpRed.BackColor = Color.PaleGreen
        btnUpRed.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnUpRed.FlatAppearance.BorderSize = 0
        btnUpRed.FlatStyle = FlatStyle.Flat
        btnUpRed.Font = New Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnUpRed.ForeColor = SystemColors.ActiveCaptionText
        btnUpRed.Location = New Point(130, 33)
        btnUpRed.Name = "btnUpRed"
        btnUpRed.Size = New Size(130, 50)
        btnUpRed.TabIndex = 0
        btnUpRed.Text = "1000,1000" & vbCrLf & "골드"
        btnUpRed.UseVisualStyleBackColor = False
        ' 
        ' btnUpToMenu
        ' 
        btnUpToMenu.BackColor = Color.LightBlue
        btnUpToMenu.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnUpToMenu.FlatAppearance.BorderSize = 0
        btnUpToMenu.FlatStyle = FlatStyle.Flat
        btnUpToMenu.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnUpToMenu.ForeColor = SystemColors.ActiveCaptionText
        btnUpToMenu.Location = New Point(817, 35)
        btnUpToMenu.Name = "btnUpToMenu"
        btnUpToMenu.Size = New Size(120, 40)
        btnUpToMenu.TabIndex = 3
        btnUpToMenu.Text = "메뉴"
        btnUpToMenu.UseVisualStyleBackColor = False
        ' 
        ' lblUpRed
        ' 
        lblUpRed.AutoSize = True
        lblUpRed.Font = New Font("맑은 고딕", 12.75F, FontStyle.Bold)
        lblUpRed.ForeColor = Color.Red
        lblUpRed.Location = New Point(7, 35)
        lblUpRed.Name = "lblUpRed"
        lblUpRed.Size = New Size(126, 46)
        lblUpRed.TabIndex = 20
        lblUpRed.Text = "산타 Lv.100" & vbCrLf & "빨강선물 +100"
        lblUpRed.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' groupSale
        ' 
        groupSale.BackColor = SystemColors.ActiveCaptionText
        groupSale.Controls.Add(Label14)
        groupSale.Controls.Add(btnSaleGreen)
        groupSale.Controls.Add(PictureBox3)
        groupSale.Controls.Add(Label13)
        groupSale.Controls.Add(btnSaleBlue)
        groupSale.Controls.Add(PictureBox2)
        groupSale.Controls.Add(Label12)
        groupSale.Controls.Add(btnSaleToMenu)
        groupSale.Controls.Add(btnSaleRed)
        groupSale.Controls.Add(PictureBox1)
        groupSale.Font = New Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        groupSale.ForeColor = SystemColors.ControlLightLight
        groupSale.Location = New Point(0, 276)
        groupSale.Name = "groupSale"
        groupSale.Size = New Size(944, 96)
        groupSale.TabIndex = 2
        groupSale.TabStop = False
        groupSale.Text = "선물배달"
        groupSale.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label14.ForeColor = Color.Lime
        Label14.Location = New Point(592, 30)
        Label14.Name = "Label14"
        Label14.Size = New Size(88, 50)
        Label14.TabIndex = 24
        Label14.Text = "초록선물" & vbCrLf & "3골드"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSaleGreen
        ' 
        btnSaleGreen.BackColor = Color.PaleGreen
        btnSaleGreen.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSaleGreen.FlatAppearance.BorderSize = 0
        btnSaleGreen.FlatStyle = FlatStyle.Flat
        btnSaleGreen.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnSaleGreen.ForeColor = SystemColors.ActiveCaptionText
        btnSaleGreen.Location = New Point(678, 35)
        btnSaleGreen.Name = "btnSaleGreen"
        btnSaleGreen.Size = New Size(80, 40)
        btnSaleGreen.TabIndex = 2
        btnSaleGreen.Text = "배달"
        btnSaleGreen.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(525, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(70, 70)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label13.ForeColor = Color.Cyan
        Label13.Location = New Point(343, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(88, 50)
        Label13.TabIndex = 21
        Label13.Text = "파랑선물" & vbCrLf & "2골드"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSaleBlue
        ' 
        btnSaleBlue.BackColor = Color.PaleGreen
        btnSaleBlue.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSaleBlue.FlatAppearance.BorderSize = 0
        btnSaleBlue.FlatStyle = FlatStyle.Flat
        btnSaleBlue.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnSaleBlue.ForeColor = SystemColors.ActiveCaptionText
        btnSaleBlue.Location = New Point(429, 35)
        btnSaleBlue.Name = "btnSaleBlue"
        btnSaleBlue.Size = New Size(80, 40)
        btnSaleBlue.TabIndex = 1
        btnSaleBlue.Text = "배달"
        btnSaleBlue.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(276, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 70)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label12.ForeColor = Color.Red
        Label12.Location = New Point(104, 30)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 50)
        Label12.TabIndex = 19
        Label12.Text = "빨강선물" & vbCrLf & "1골드"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSaleToMenu
        ' 
        btnSaleToMenu.BackColor = Color.LightBlue
        btnSaleToMenu.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSaleToMenu.FlatAppearance.BorderSize = 0
        btnSaleToMenu.FlatStyle = FlatStyle.Flat
        btnSaleToMenu.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnSaleToMenu.ForeColor = SystemColors.ActiveCaptionText
        btnSaleToMenu.Location = New Point(787, 35)
        btnSaleToMenu.Name = "btnSaleToMenu"
        btnSaleToMenu.Size = New Size(120, 40)
        btnSaleToMenu.TabIndex = 3
        btnSaleToMenu.Text = "메뉴"
        btnSaleToMenu.UseVisualStyleBackColor = False
        ' 
        ' btnSaleRed
        ' 
        btnSaleRed.BackColor = Color.PaleGreen
        btnSaleRed.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSaleRed.FlatAppearance.BorderSize = 0
        btnSaleRed.FlatStyle = FlatStyle.Flat
        btnSaleRed.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnSaleRed.ForeColor = SystemColors.ActiveCaptionText
        btnSaleRed.Location = New Point(190, 35)
        btnSaleRed.Name = "btnSaleRed"
        btnSaleRed.Size = New Size(80, 40)
        btnSaleRed.TabIndex = 0
        btnSaleRed.Text = "배달"
        btnSaleRed.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(37, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label11.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label11.ForeColor = Color.Lime
        Label11.Location = New Point(-3, 144)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 25)
        Label11.TabIndex = 999
        Label11.Text = "초록선물 :"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label9.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label9.ForeColor = Color.Cyan
        Label9.Location = New Point(-3, 111)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 25)
        Label9.TabIndex = 999
        Label9.Text = "파랑선물 :"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label7.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(-3, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 25)
        Label7.TabIndex = 999
        Label7.Text = "빨강선물 :"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' bgmTimer
        ' 
        bgmTimer.Interval = 51000
        ' 
        ' moneyTimer
        ' 
        moneyTimer.Enabled = True
        moneyTimer.Interval = 1000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(944, 601)
        Controls.Add(groupSale)
        Controls.Add(sta)
        Controls.Add(groupUp)
        Controls.Add(lblGreen)
        Controls.Add(Label11)
        Controls.Add(lblBlue)
        Controls.Add(Label9)
        Controls.Add(lblRed)
        Controls.Add(Label7)
        Controls.Add(lblGold)
        Controls.Add(Label5)
        Controls.Add(lblName)
        Controls.Add(Label3)
        Controls.Add(picBlue)
        Controls.Add(picGreen)
        Controls.Add(Label2)
        Controls.Add(btnExit)
        Controls.Add(Label1)
        Controls.Add(btnBgm)
        Controls.Add(groupMenu)
        Controls.Add(picSanta)
        Font = New Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(129))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "Form2"
        Text = "산타게임"
        groupMenu.ResumeLayout(False)
        sta.ResumeLayout(False)
        sta.PerformLayout()
        CType(picSanta, ComponentModel.ISupportInitialize).EndInit()
        CType(picGreen, ComponentModel.ISupportInitialize).EndInit()
        CType(picBlue, ComponentModel.ISupportInitialize).EndInit()
        groupUp.ResumeLayout(False)
        groupUp.PerformLayout()
        groupSale.ResumeLayout(False)
        groupSale.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents groupMenu As GroupBox
    Friend WithEvents btnBgm As Button
    Friend WithEvents sta As StatusStrip
    Friend WithEvents stalblBgm As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents picSanta As PictureBox
    Friend WithEvents picGreen As PictureBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnMenuToSale As Button
    Friend WithEvents btnMenuToUp As Button
    Friend WithEvents lblGold As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents groupUp As GroupBox
    Friend WithEvents groupSale As GroupBox
    Friend WithEvents btnSaleRed As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSaleToMenu As Button
    Friend WithEvents btnUpToMenu As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSaleGreen As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSaleBlue As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUpRed As Label
    Friend WithEvents btnUpRed As Button
    Friend WithEvents btnUpGreen As Button
    Friend WithEvents lblUpGreen As Label
    Friend WithEvents btnUpBlue As Button
    Friend WithEvents lblUpBlue As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bgmTimer As Timer
    Friend WithEvents moneyTimer As Timer
End Class
