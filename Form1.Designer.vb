<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Btn_ChangePage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Cal = New System.Windows.Forms.Button()
        Me.TB_Result = New System.Windows.Forms.TextBox()
        Me.Btn_ThreadStart = New System.Windows.Forms.Button()
        Me.Lab_NowTime = New System.Windows.Forms.Label()
        Me.Btn_Nub9 = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_ClearPage = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Cal
        '
        Me.Btn_Cal.Location = New System.Drawing.Point(27, 309)
        Me.Btn_Cal.Name = "Btn_Cal"
        Me.Btn_Cal.Size = New System.Drawing.Size(97, 43)
        Me.Btn_Cal.TabIndex = 0
        Me.Btn_Cal.Text = "Cal"
        Me.Btn_Cal.UseVisualStyleBackColor = True
        '
        'TB_Result
        '
        Me.TB_Result.Location = New System.Drawing.Point(27, 34)
        Me.TB_Result.Name = "TB_Result"
        Me.TB_Result.Size = New System.Drawing.Size(195, 22)
        Me.TB_Result.TabIndex = 1
        '
        'Btn_ThreadStart
        '
        Me.Btn_ThreadStart.Location = New System.Drawing.Point(146, 309)
        Me.Btn_ThreadStart.Name = "Btn_ThreadStart"
        Me.Btn_ThreadStart.Size = New System.Drawing.Size(97, 43)
        Me.Btn_ThreadStart.TabIndex = 2
        Me.Btn_ThreadStart.Text = "Start"
        Me.Btn_ThreadStart.UseVisualStyleBackColor = True
        '
        'Lab_NowTime
        '
        Me.Lab_NowTime.AutoSize = True
        Me.Lab_NowTime.Location = New System.Drawing.Point(25, 9)
        Me.Lab_NowTime.Name = "Lab_NowTime"
        Me.Lab_NowTime.Size = New System.Drawing.Size(37, 12)
        Me.Lab_NowTime.TabIndex = 3
        Me.Lab_NowTime.Text = "Label1"
        '
        'Btn_Nub9
        '
        Me.Btn_Nub9.Location = New System.Drawing.Point(27, 214)
        Me.Btn_Nub9.Name = "Btn_Nub9"
        Me.Btn_Nub9.Size = New System.Drawing.Size(72, 43)
        Me.Btn_Nub9.TabIndex = 4
        Me.Btn_Nub9.Text = "9"
        Me.Btn_Nub9.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(265, 22)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(972, 606)
        Me.Panel.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ChangePage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_ClearPage
        '
        Me.Btn_ClearPage.Location = New System.Drawing.Point(146, 560)
        Me.Btn_ClearPage.Name = "Btn_ClearPage"
        Me.Btn_ClearPage.Size = New System.Drawing.Size(97, 43)
        Me.Btn_ClearPage.TabIndex = 7
        Me.Btn_ClearPage.Text = "ClearPage"
        Me.Btn_ClearPage.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ChangePage"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_ChangePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 643)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_ClearPage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Btn_Nub9)
        Me.Controls.Add(Me.Lab_NowTime)
        Me.Controls.Add(Me.Btn_ThreadStart)
        Me.Controls.Add(Me.TB_Result)
        Me.Controls.Add(Me.Btn_Cal)
        Me.Name = "Btn_ChangePage"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Cal As System.Windows.Forms.Button
    Friend WithEvents TB_Result As System.Windows.Forms.TextBox
    Friend WithEvents Btn_ThreadStart As System.Windows.Forms.Button
    Friend WithEvents Lab_NowTime As System.Windows.Forms.Label
    Friend WithEvents Btn_Nub9 As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_ClearPage As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
