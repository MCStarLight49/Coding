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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        btnStart = New Button()
        txtName = New TextBox()
        lblMainOut = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("휴먼편지체", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(326, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 43)
        Label1.TabIndex = 0
        Label1.Text = "산타의 선물 제작!"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.LightCyan
        btnStart.Font = New Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnStart.Location = New Point(411, 424)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(122, 55)
        btnStart.TabIndex = 1
        btnStart.Text = "시작"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(373, 328)
        txtName.Name = "txtName"
        txtName.Size = New Size(199, 33)
        txtName.TabIndex = 0
        ' 
        ' lblMainOut
        ' 
        lblMainOut.BackColor = Color.Transparent
        lblMainOut.Font = New Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblMainOut.Location = New Point(12, 272)
        lblMainOut.Name = "lblMainOut"
        lblMainOut.Size = New Size(920, 30)
        lblMainOut.TabIndex = 3
        lblMainOut.Text = "닉네임을 입력해주세요"
        lblMainOut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(944, 601)
        Controls.Add(lblMainOut)
        Controls.Add(txtName)
        Controls.Add(btnStart)
        Controls.Add(Label1)
        Font = New Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(129))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "Form1"
        Text = "산타게임"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMainOut As Label

End Class
