

Public Class Btn_ChangePage

    Public P_TestInt As Integer = 0


    Private p_Thread As Threading.Thread
    Private p_FormIsClose As Boolean = False
    Private p_UserControl1 As New UserControl1
    Private p_UserControl2 As New UserControl2

    Public Sub New()

        ' 此為設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

        'Debug.Print("Hello")
        'Debug.Print("Hello too")

        Dim hex As Integer = &H10

        Debug.Print(hex.ToString)


        p_Thread = New Threading.Thread(AddressOf ThreadClock)
        p_Thread.Name = "ThreadClock"

    End Sub

    Public Sub ThreadClock()

        While Not p_FormIsClose

            CallFunction()

            Me.Invoke(
                Sub()

                    Lab_NowTime.Text = DateTime.Now.ToLocalTime.ToString("yyyy/MM/dd hh:MM:ss")

                End Sub)

            Threading.Thread.Sleep(1000)

        End While

    End Sub


    Public Sub CallFunction()

        P_TestInt += 1

    End Sub

    Public Function CallBackFunction() As Integer

        Return P_TestInt

    End Function


    Private Sub Btn_Cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cal.Click

        TB_Result.Text = P_TestInt.ToString

        Dim StrToInt As Integer = 0

        If Integer.TryParse(TB_Result.Text, StrToInt) Then


        Else



        End If


    End Sub


    Private Sub Btn_ThreadStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ThreadStart.Click

        p_Thread.Start()

    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        p_FormIsClose = True

    End Sub


    Private Sub TB_Result_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_Result.KeyPress

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then

            'TB_Result.Text = e.KeyChar

        Else

            e.Handled = True

        End If

    End Sub


    Private Sub Btn_Nub9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nub9.Click

        TB_Result.Text &= "9"

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel.Controls.Clear()
        Panel.Controls.Add(p_UserControl1)

    End Sub

    Private Sub Btn_ClearPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ClearPage.Click

        Panel.Controls.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Panel.Controls.Clear()
        Panel.Controls.Add(p_UserControl2)

    End Sub
End Class
