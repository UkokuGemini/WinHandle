Imports System.IO

Public Class Main
    Public Declare Auto Function RegisterHotKey Lib "user32.dll" Alias "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Boolean
    Public Declare Auto Function UnRegisterHotKey Lib "user32.dll" Alias "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean
    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Long) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Declare Function ShowWindow Lib "user32" Alias "ShowWindow" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    Public Declare Function IsWindow Lib "user32" (ByVal hwnd As Long) As Long
    Dim Hwnd As Integer
    Public Const WM_HOTKEY = &H312
    Public Const MOD_ALT = &H1
    Public Const MOD_CONTROL = &H2
    Public Const MOD_SHIFT = &H4
    Public Const WM_KEYDOWN = &H100
    Public Const WM_KEYUP = &H101
    Public Const SW_HIDE = 0
    Public Const SW_SHOWNORMAL = 1
    Dim TrueClose As Boolean = False
    Dim TimeRev As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseConnection.ConnectionString = "Data Source=" & DataBasePath
        RegisterHotKey(Handle, 0, 2, Keys.Home)
        RegisterHotKey(Handle, 1, 2, Keys.Insert)
        MyAutoDataSet = SQLDataBaseQeury("SELECT * FROM Sys_Auto ORDER BY Num", DataBaseConnection)
        GridViewDisplay()
        Timer3.Interval = 1000
        Timer3.Enabled = True
        TimeRev = 15
        Timer2.Interval = TimeRev * 1000
        If MyAutoDataSet.Tables(0).Rows.Count > 0 Then
            Timer2.Enabled = True
        Else
            ToolStripLabel13.Text = "恢复值守"
        End If
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TrueClose = False Then
            e.Cancel = True
            WindowState = FormWindowState.Minimized
        Else
            NotifyIcon1.Dispose()
            UnRegisterHotKey(Handle, 0)
            UnRegisterHotKey(Handle, 1)
        End If
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            If m.WParam = 0 Then
                获取最前窗口信息热键HomeToolStripMenuItem_Click(Nothing, Nothing)
                Me.WindowState = FormWindowState.Normal
            ElseIf m.WParam = 1 Then
                获取鼠标窗口信息热键InsertToolStripMenuItem_Click(Nothing, Nothing)
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub CreateStartup()
        Dim WScript_T As Object = CreateObject("WScript.Shell")
        Dim StartupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim AppName = My.Application.Info.ProductName
        'Dim desk As String = WScript_T.SpecialFolders("Desktop")
        Dim AppInk As Object = WScript_T.CreateShortcut(StartupPath & "\" & AppName & ".exe.lnk")
        'If Not IO.File.Exists(AppInk) Then
        With AppInk
            .Description = "WinHandle.Ink"
            .IconLocation = Application.StartupPath + "\" + My.Application.Info.AssemblyName & ".exe,0"
            .TargetPath = Application.StartupPath + "\" + My.Application.Info.AssemblyName & ".exe "
            .WindowStyle = 7 '打开窗体的风格，最小化
            .WorkingDirectory = Application.StartupPath '工作路径
            .Save() '保存快捷方式
        End With
        'End If
    End Sub
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As Integer
    Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hwnd As Integer, ByVal lpClassName As String, ByVal n2MaxCount As Integer) As Integer
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hWnd As Integer, ByVal lpTextString As String, ByVal n2MaxCount As Integer) As Integer
    Dim WindowLong As String
    Dim TempStringC As String
    Dim TempStringW As String
    Private Structure PointApi
        Dim x As Integer
        Dim y As Integer
    End Structure
    Dim Thwnd, f As Integer
    Private NowPoint As PointApi
    Private Declare Function GetCursorPos Lib "user32" Alias "GetCursorPos" (ByVal lpPoint As PointApi) As Integer
    Private Declare Function WindowFromPoint Lib "user32" Alias "WindowFromPoint" (ByVal XPoint As Integer, ByVal YPoint As Integer) As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            'GetCursorPos(NowPoint)
        Catch ex As Exception
        End Try
        LogText.Text = "坐标点(" & MousePosition.X & "," & MousePosition.Y & ")窗口信息."
        Thwnd = WindowFromPoint(MousePosition.X, MousePosition.Y)
        If Thwnd > 0 Then
            HandleInfoText.Text = Thwnd
            TempStringW = Space(255)
            WindowLong = GetWindowText(Thwnd, TempStringW, 255)
            WinInfoText.Text = Trim(TempStringW)
            TempStringC = Space(255)
            GetClassName(Thwnd, TempStringC, 255)
            ClassInfoText.Text = Trim(TempStringC)
        Else
            LogText.Text = "未捕捉到此窗口!"
        End If
    End Sub

    Private Sub 获取最前窗口信息热键HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 获取最前窗口信息热键HomeToolStripMenuItem.Click
        LogText.Text = ""
        Hwnd = GetForegroundWindow()
        If Hwnd > 0 Then
            HandleInfoText.Text = Hwnd
            TempStringW = Space(255)
            WindowLong = GetWindowText(Hwnd, TempStringW, 255)
            WinInfoText.Text = Trim(TempStringW)
            TempStringC = Space(255)
            GetClassName(Hwnd, TempStringC, 255)
            ClassInfoText.Text = Trim(TempStringC)
            ToolStripLabel1_Click(Nothing, Nothing)
            LogText.Focus()
            LogText.Select(LogText.Text.Length, 0)
        Else
            LogText.Text = "未捕捉到此窗口!"
        End If
    End Sub

    Private Sub 获取鼠标窗口信息热键InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 获取鼠标窗口信息热键InsertToolStripMenuItem.Click
        Timer1.Enabled = Not Timer1.Enabled
        If Timer1.Enabled Then
            SuccessFlag = False
            ToolStripLabel2_Click(Nothing, Nothing)
            获取鼠标窗口信息热键InsertToolStripMenuItem.Text = "请悬停鼠标获取窗口信息(热键Insert)."
        Else
            ToolStripLabel1_Click(Nothing, Nothing)
            获取鼠标窗口信息热键InsertToolStripMenuItem.Text = "获取鼠标窗口信息(热键Insert)"
            LogText.Focus()
            LogText.Select(LogText.Text.Length, 0)
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        If CheckHwnd(WinInfoText.Text, ClassInfoText.Text, HandleInfoText.Text) <> -1 Then
            SuccessFlag = True '这里需要一个专属Flag给手动查询专用
            HandleInfoText.Enabled = False
            ClassInfoText.Enabled = False
            WinInfoText.Enabled = False
        Else
            SuccessFlag = False
        End If
        LogText.Focus()
        LogText.Select(LogText.Text.Length, 0)
    End Sub
    Function CheckHwnd(ByVal Name_T As String, ByVal Class_T As String, ByVal Hwnd_T As Integer, Optional AutoFlag As Boolean = False, Optional AutoIndex As Integer = 0) As Integer
        Dim CheckResult As Integer = -1
        If IsDBNull(Hwnd_T) OrElse Hwnd_T.ToString = "" OrElse Hwnd_T = -1 Then
            If IsDBNull(Name_T) OrElse Name_T = "" Then
                If IsDBNull(Class_T) OrElse Class_T = "" Then
                    LogText.Text = "请至少填写一项!"
                Else
                    Try
                        Hwnd = FindWindow(Class_T, vbNullString)
                    Catch ex As Exception
                    End Try
                    If Hwnd > 0 Then
                        If AutoFlag = False Then
                            HandleInfoText.Text = Hwnd
                            TempStringW = Space(255)
                            WindowLong = GetWindowText(Hwnd, TempStringW, 255)
                            WinInfoText.Text = Trim(TempStringW)
                            LogText.Text = "捕捉到Class:(" & Class_T & ")窗口!    ✔"
                        End If
                        CheckResult = Hwnd
                    Else
                        LogText.Text = "未捕捉到Class:(" & Class_T & ")窗口!"
                    End If
                End If
            Else
                Try
                    Hwnd = FindWindow(vbNullString, Name_T)
                Catch ex As Exception
                End Try
                If Hwnd > 0 Then
                    If AutoFlag = False Then
                        HandleInfoText.Text = Hwnd
                        TempStringC = Space(255)
                        GetClassName(Hwnd, TempStringC, 255)
                        ClassInfoText.Text = Trim(TempStringC)
                        LogText.Text = "捕捉到Name:(" & Name_T & ")窗口!    ✔"
                    End If
                    CheckResult = Hwnd
                Else
                    LogText.Text = "未捕捉到Name:(" & Name_T & ")窗口!"
                End If
            End If
        ElseIf IsNumeric(Hwnd_T) Then
            Hwnd = Math.Abs(Convert.ToInt32(Hwnd_T))
            TempStringW = Space(255)
            WindowLong = GetWindowText(Hwnd, TempStringW, 255)
            If WindowLong > 0 Then
                If AutoFlag = False Then
                    WinInfoText.Text = Trim(TempStringW)
                    TempStringC = Space(255)
                    GetClassName(Hwnd, TempStringC, 255)
                    ClassInfoText.Text = Trim(TempStringC)
                    LogText.Text = "捕捉到Handle:(" & Hwnd_T & ")窗口!   ✔"
                End If
                CheckResult = Hwnd
            Else
                LogText.Text = "未捕捉到Handle:(" & Hwnd_T & ")窗口!"
            End If
        Else
            LogText.Text = "句柄为数字!请更正填写."
        End If
        If AutoFlag Then
            LogText.Text = "正在自动执行第" & AutoIndex & "项操作."
        End If
        Return CheckResult
    End Function
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        HandleInfoText.Text = ""
        ClassInfoText.Text = ""
        WinInfoText.Text = ""
        HandleInfoText.Enabled = True
        ClassInfoText.Enabled = True
        WinInfoText.Enabled = True
        LogText.Text = ""
        WinInfoText.Focus()
        SuccessFlag = False
    End Sub

    Private Sub 测试窗口捕捉闪烁窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 测试窗口捕捉闪烁窗口ToolStripMenuItem.Click
        LogText.Text = ""
        Hwnd = Convert.ToUInt32(HandleInfoText.Text)
        If Hwnd > 0 Then
            ShowWindow(Hwnd, SW_HIDE)
            ShowWindow(Hwnd, SW_SHOWNORMAL)
        Else
            LogText.Text = "无窗口目标!"
        End If
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        PostMessage(Hwnd, &H112, &HF030, 0)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        ShowWindow(Hwnd, SW_HIDE)
    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        ShowWindow(Hwnd, SW_SHOWNORMAL)
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        PostMessage(Hwnd, &H112, &HF020, 0)
    End Sub

    Private Sub ToolStripLabel7_Click(sender As Object, e As EventArgs) Handles ToolStripLabel7.Click
        PostMessage(Hwnd, &H112, &HF120, 0)
    End Sub

    Private Sub ToolStripLabel8_Click(sender As Object, e As EventArgs) Handles ToolStripLabel8.Click
        PostMessage(Hwnd, &H112, &HF060, 0)
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        TrueClose = True
        Me.Close()
    End Sub

    Private Sub 显示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示ToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1000, Me.Text, "转入后台工作..", ToolTipIcon.Info)
        Else
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            RegisterHotKey(Handle, 0, 2, Keys.Home)
            RegisterHotKey(Handle, 1, 2, Keys.Insert)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub 退出软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出软件ToolStripMenuItem.Click
        TrueClose = True
        Me.Close()
    End Sub
    Dim MyAutoDataSet As DataSet
    Dim SuccessFlag As Boolean = False
    Public Function GetDataSetMinNum(ByVal TarGetDataset As DataSet, ByVal ColumnNameStr As String) As Integer
        Dim MinNum As Integer = TarGetDataset.Tables(0).Rows.Count
        For i = 0 To TarGetDataset.Tables(0).Rows.Count - 1
            If TarGetDataset.Tables(0).Rows(i).Item(ColumnNameStr) > i Then
                MinNum = i
                Exit For
            End If
        Next
        Return MinNum
    End Function '获取DataSet中空白序号最小值

    Public Sub GridViewDisplay()
        Do While DataGridView1.Rows.Count > 0
            DataGridView1.Rows.RemoveAt(0)
        Loop
        If MyAutoDataSet.Tables(0).Rows.Count > 0 Then
            DataGridView1.Rows.Add(MyAutoDataSet.Tables(0).Rows.Count) '增加预设
        End If
        Dim DepotIndex As Integer = -1
        For i = 0 To MyAutoDataSet.Tables(0).Rows.Count - 1
            DepotIndex += 1
            DataGridView1.Rows(DepotIndex).Cells("ColumnNum").Value = MyAutoDataSet.Tables(0).Rows(i).Item("Num")
            DataGridView1.Rows(DepotIndex).Cells("ColumnName").Value = MyAutoDataSet.Tables(0).Rows(i).Item("Name")
            DataGridView1.Rows(DepotIndex).Cells("ColumnClass").Value = MyAutoDataSet.Tables(0).Rows(i).Item("Class")
            DataGridView1.Rows(DepotIndex).Cells("ColumnHandle").Value = MyAutoDataSet.Tables(0).Rows(i).Item("Handle")
            Select Case MyAutoDataSet.Tables(0).Rows(i).Item("Type")
                Case 0
                    DataGridView1.Rows(DepotIndex).Cells("ColumnType").Value = "隐藏"
                Case 1
                    DataGridView1.Rows(DepotIndex).Cells("ColumnType").Value = "最小化"
                Case -1
                    DataGridView1.Rows(DepotIndex).Cells("ColumnType").Value = "关闭"
            End Select
        Next
    End Sub '仓库显示
    Friend DataBasePath As String = Directory.GetCurrentDirectory & "\AutoConfig.db"
    Friend DataBaseConnection As New SQLite.SQLiteConnection
    Private ReadOnly DataBaseCommand As New SQLite.SQLiteCommand
    Public Function SQLDataBaseQeury(ByVal SQLCommand As String, ByVal DataBaseConnection As SQLite.SQLiteConnection) As DataSet
        Dim DataSetTemp As New DataSet
        Try
            If DataBaseConnection.State = System.Data.ConnectionState.Closed Then
                DataBaseConnection.Open()
            End If
            DataBaseCommand.Connection = DataBaseConnection
            DataBaseCommand.CommandText = SQLCommand
            Dim DataBaseAdapter As New SQLite.SQLiteDataAdapter(DataBaseCommand)
            DataBaseAdapter.Fill(DataSetTemp)
            If DataBaseConnection.State = System.Data.ConnectionState.Open Then
                DataBaseConnection.Close()
            End If
            Return DataSetTemp
            DataSetTemp.Dispose()
        Catch Ex As Exception
            If DataBaseConnection.State = System.Data.ConnectionState.Open Then
                DataBaseConnection.Close()
            End If
            Return DataSetTemp
        End Try
    End Function '数据库查询

    Public Sub SQLDataBaseExecute(ByVal SQLCommand As String, ByVal DataBaseConnection As SQLite.SQLiteConnection)
        Try
            If DataBaseConnection.State = System.Data.ConnectionState.Closed Then
                DataBaseConnection.Open()
            End If
            DataBaseCommand.Connection = DataBaseConnection
            DataBaseCommand.CommandText = SQLCommand
            DataBaseCommand.ExecuteNonQuery()
        Catch Ex As Exception
        End Try
        If DataBaseConnection.State = System.Data.ConnectionState.Open Then
            DataBaseConnection.Close()
        End If
    End Sub '数据库操作指令
    Private Sub ToolStripLabel9_Click(sender As Object, e As EventArgs) Handles ToolStripLabel9.Click
        AddNewAuto(0)
    End Sub
    Private Sub ToolStripLabel10_Click(sender As Object, e As EventArgs) Handles ToolStripLabel10.Click
        AddNewAuto(-1)
    End Sub

    Private Sub ToolStripLabel11_Click(sender As Object, e As EventArgs) Handles ToolStripLabel11.Click
        AddNewAuto(1)
    End Sub

    Private Sub ToolStripLabel12_Click(sender As Object, e As EventArgs) Handles ToolStripLabel12.Click
        If DataGridView1.CurrentCell.RowIndex <> -1 Then
            SQLDataBaseExecute("DELETE FROM Sys_Auto WHERE Num=" & MyAutoDataSet.Tables(0).Rows(DataGridView1.CurrentCell.RowIndex).Item("Num"), DataBaseConnection)
            MyAutoDataSet = SQLDataBaseQeury("SELECT * FROM Sys_Auto ORDER BY Num", DataBaseConnection)
        End If
        GridViewDisplay()
        If MyAutoDataSet.Tables(0).Rows.Count = 0 Then
            Timer2.Enabled = False
            ToolStripLabel13.Text = "恢复值守"
        End If
    End Sub

    Sub AddNewAuto(ByVal Type As Integer)
        If SuccessFlag Then
            Dim MinID As Integer = GetDataSetMinNum(MyAutoDataSet, "Num") '确定空闲的最小物品代码ID
            SQLDataBaseExecute("INSERT INTO Sys_Auto VALUES(" & MinID & ",'" & WinInfoText.Text & "','" & ClassInfoText.Text & "'," & HandleInfoText.Text & "," & Type & ")", DataBaseConnection)
            MyAutoDataSet = SQLDataBaseQeury("SELECT * FROM Sys_Auto ORDER BY Num", DataBaseConnection)
            GridViewDisplay()
        End If
    End Sub
    Dim Doindex As Integer = -1
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TimeRev = 5
        Timer2.Interval = TimeRev * 1000
        Doindex += 1
        If Doindex > MyAutoDataSet.Tables(0).Rows.Count - 1 Then
            TimeRev = 60 * 10
            Timer2.Interval = 1000 * TimeRev
            Doindex = -1
            LogText.Text = "完成全部值守操作."
        Else
            Try
                DataGridView1.Rows(Doindex).Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = Doindex
            Catch ex As Exception
            End Try
            Dim AutoHwnd As Integer = CheckHwnd(MyAutoDataSet.Tables(0).Rows(Doindex).Item("Name"), MyAutoDataSet.Tables(0).Rows(Doindex).Item("Class"), -1, True, Doindex + 1)
            If AutoHwnd <> -1 Then
                Select Case MyAutoDataSet.Tables(0).Rows(Doindex).Item("Type")
                    Case -1
                        Try
                            PostMessage(AutoHwnd, &H112, &HF020, 0)
                        Catch ex As Exception
                        End Try
                    Case 0
                        Try
                            ShowWindow(AutoHwnd, SW_HIDE)
                        Catch ex As Exception
                        End Try
                    Case 1
                        Try
                            PostMessage(AutoHwnd, &H112, &HF060, 0)
                        Catch ex As Exception
                        End Try
                End Select

            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Timer2.Enabled Then
            TimeRev -= 1
            GroupBox10.Text = "自动化值守操作          (倒计时:" & CulCulateLastTimeText(TimeRev, 0) & ")"
        Else
            GroupBox10.Text = "自动化值守操作          (已停止.)"
        End If
    End Sub
    Public Function CulCulateLastTimeText(ByVal Time As Int64, ByVal IntevalType As Integer) As String
        Dim H, M, S As Int64
        Dim HT As String = ""
        Dim MT As String = ""
        Dim ST As String = ""
        H = Int(Time / 3600)
        Time = Time Mod 3600
        M = Int(Time / 60)
        S = Time Mod 60
        If H > 0 Then
            HT = H & "小时"
        End If
        If M > 0 Then
            MT = M & "分"
        End If
        If S > 0 Then
            ST = S & "秒"
        End If
        Select Case IntevalType
            Case 0
                Return HT & MT & ST
            Case 1
                Return HT & MT
            Case Else
                Return HT
        End Select
    End Function '显示时间

    Private Sub ToolStripLabel13_Click(sender As Object, e As EventArgs) Handles ToolStripLabel13.Click
        Timer2.Enabled = Not Timer2.Enabled
        If MyAutoDataSet.Tables(0).Rows.Count = 0 Then
            Timer2.Enabled = False
        End If
        If Timer2.Enabled Then
            ToolStripLabel13.Text = "停止值守"
            TimeRev = 15
            Timer2.Interval = 1000 * TimeRev
        Else
            ToolStripLabel13.Text = "恢复值守"
        End If
    End Sub

    Private Sub 设置开机启动ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置开机启动ToolStripMenuItem.Click
        CreateStartup()
    End Sub
End Class
