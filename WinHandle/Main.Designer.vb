<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.LogText = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.HandleInfoText = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ClassInfoText = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.WinInfoText = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHandle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel11 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.退出软件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.获取最前窗口信息热键HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.获取鼠标窗口信息热键InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.测试窗口捕捉闪烁窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.GroupBox9)
        Me.GroupBox5.Controls.Add(Me.ToolStrip1)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(459, 300)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "窗口信息"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 49)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "窗口操作"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.ToolStripLabel3, Me.ToolStripLabel5, Me.ToolStripLabel4, Me.ToolStripLabel6, Me.ToolStripLabel8})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 21)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(445, 25)
        Me.ToolStrip2.TabIndex = 16
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.IsLink = True
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel7.Text = "正常窗口"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.IsLink = True
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel3.Text = "最大化"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.IsLink = True
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel5.Text = "最小化"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.IsLink = True
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel4.Text = "隐藏"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.IsLink = True
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel6.Text = "显示"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.IsLink = True
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel8.Text = "关闭"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.LogText)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(4, 197)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(451, 50)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "LogInfo"
        '
        'LogText
        '
        Me.LogText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogText.Location = New System.Drawing.Point(4, 22)
        Me.LogText.Margin = New System.Windows.Forms.Padding(4)
        Me.LogText.Name = "LogText"
        Me.LogText.ReadOnly = True
        Me.LogText.Size = New System.Drawing.Size(443, 25)
        Me.LogText.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 172)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 4, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(451, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(99, 18)
        Me.ToolStripLabel1.Text = "查询窗口信息"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 18)
        Me.ToolStripLabel2.Text = "清空信息栏"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.HandleInfoText)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(4, 122)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(451, 50)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Handle"
        '
        'HandleInfoText
        '
        Me.HandleInfoText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HandleInfoText.Location = New System.Drawing.Point(4, 22)
        Me.HandleInfoText.Margin = New System.Windows.Forms.Padding(4)
        Me.HandleInfoText.Name = "HandleInfoText"
        Me.HandleInfoText.Size = New System.Drawing.Size(443, 25)
        Me.HandleInfoText.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ClassInfoText)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(4, 72)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(451, 50)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ClassName"
        '
        'ClassInfoText
        '
        Me.ClassInfoText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassInfoText.Location = New System.Drawing.Point(4, 22)
        Me.ClassInfoText.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassInfoText.Name = "ClassInfoText"
        Me.ClassInfoText.Size = New System.Drawing.Size(443, 25)
        Me.ClassInfoText.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.WinInfoText)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(4, 22)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(451, 50)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "WindowName"
        '
        'WinInfoText
        '
        Me.WinInfoText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinInfoText.Location = New System.Drawing.Point(4, 22)
        Me.WinInfoText.Margin = New System.Windows.Forms.Padding(4)
        Me.WinInfoText.Name = "WinInfoText"
        Me.WinInfoText.Size = New System.Drawing.Size(443, 25)
        Me.WinInfoText.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(19, 0, 1, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1006, 25)
        Me.StatusStrip1.TabIndex = 9
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(173, 19)
        Me.ToolStripStatusLabel1.Text = "By夜鸦一支舞NighCrow"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNum, Me.ColumnName, Me.ColumnClass, Me.ColumnHandle, Me.ColumnType})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(541, 201)
        Me.DataGridView1.TabIndex = 10
        '
        'ColumnNum
        '
        Me.ColumnNum.HeaderText = "序号"
        Me.ColumnNum.MinimumWidth = 6
        Me.ColumnNum.Name = "ColumnNum"
        Me.ColumnNum.Visible = False
        Me.ColumnNum.Width = 125
        '
        'ColumnName
        '
        Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnName.HeaderText = "窗口名称"
        Me.ColumnName.MinimumWidth = 6
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        Me.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnClass
        '
        Me.ColumnClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnClass.HeaderText = "窗口类"
        Me.ColumnClass.MinimumWidth = 6
        Me.ColumnClass.Name = "ColumnClass"
        Me.ColumnClass.ReadOnly = True
        Me.ColumnClass.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnHandle
        '
        Me.ColumnHandle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnHandle.HeaderText = "窗口句柄"
        Me.ColumnHandle.MinimumWidth = 6
        Me.ColumnHandle.Name = "ColumnHandle"
        Me.ColumnHandle.ReadOnly = True
        Me.ColumnHandle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnHandle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnHandle.Width = 73
        '
        'ColumnType
        '
        Me.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnType.HeaderText = "窗口操作"
        Me.ColumnType.MinimumWidth = 6
        Me.ColumnType.Name = "ColumnType"
        Me.ColumnType.ReadOnly = True
        Me.ColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnType.Width = 73
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DataGridView1)
        Me.GroupBox10.Controls.Add(Me.ToolStrip4)
        Me.GroupBox10.Controls.Add(Me.GroupBox2)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(459, 28)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(547, 300)
        Me.GroupBox10.TabIndex = 11
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "自动化值守操作"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel13})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 21)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(541, 25)
        Me.ToolStrip4.TabIndex = 18
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel13.IsLink = True
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel13.Text = "停止值守"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 50)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "窗口操作"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel9, Me.ToolStripLabel11, Me.ToolStripLabel10, Me.ToolStripLabel12})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 21)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip3.TabIndex = 16
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.IsLink = True
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripLabel9.Text = "添加自动隐藏"
        '
        'ToolStripLabel11
        '
        Me.ToolStripLabel11.IsLink = True
        Me.ToolStripLabel11.Name = "ToolStripLabel11"
        Me.ToolStripLabel11.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel11.Text = "添加自动最小化"
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.IsLink = True
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripLabel10.Text = "添加自动关闭"
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel12.IsLink = True
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel12.Text = "删除值守"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出软件ToolStripMenuItem, Me.获取最前窗口信息热键HomeToolStripMenuItem, Me.获取鼠标窗口信息热键InsertToolStripMenuItem, Me.测试窗口捕捉闪烁窗口ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '退出软件ToolStripMenuItem
        '
        Me.退出软件ToolStripMenuItem.Name = "退出软件ToolStripMenuItem"
        Me.退出软件ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.退出软件ToolStripMenuItem.Text = "退出软件"
        '
        '获取最前窗口信息热键HomeToolStripMenuItem
        '
        Me.获取最前窗口信息热键HomeToolStripMenuItem.Name = "获取最前窗口信息热键HomeToolStripMenuItem"
        Me.获取最前窗口信息热键HomeToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.获取最前窗口信息热键HomeToolStripMenuItem.Text = "获取最前窗口信息(热键Home)"
        '
        '获取鼠标窗口信息热键InsertToolStripMenuItem
        '
        Me.获取鼠标窗口信息热键InsertToolStripMenuItem.Name = "获取鼠标窗口信息热键InsertToolStripMenuItem"
        Me.获取鼠标窗口信息热键InsertToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.获取鼠标窗口信息热键InsertToolStripMenuItem.Text = "获取鼠标窗口信息(热键Insert)"
        '
        '测试窗口捕捉闪烁窗口ToolStripMenuItem
        '
        Me.测试窗口捕捉闪烁窗口ToolStripMenuItem.Name = "测试窗口捕捉闪烁窗口ToolStripMenuItem"
        Me.测试窗口捕捉闪烁窗口ToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.测试窗口捕捉闪烁窗口ToolStripMenuItem.Text = "测试窗口捕捉(闪烁窗口)"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WinHandle"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 52)
        '
        '显示ToolStripMenuItem
        '
        Me.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem"
        Me.显示ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.显示ToolStripMenuItem.Text = "显示"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 353)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 400)
        Me.MinimumSize = New System.Drawing.Size(1024, 400)
        Me.Name = "Main"
        Me.Text = "WinHandle窗口信息获取"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents HandleInfoText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ClassInfoText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents WinInfoText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents LogText As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 获取最前窗口信息热键HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 获取鼠标窗口信息热键InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 测试窗口捕捉闪烁窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 显示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出软件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ColumnNum As DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnClass As DataGridViewTextBoxColumn
    Friend WithEvents ColumnHandle As DataGridViewTextBoxColumn
    Friend WithEvents ColumnType As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents ToolStripLabel10 As ToolStripLabel
    Friend WithEvents ToolStripLabel11 As ToolStripLabel
    Friend WithEvents ToolStripLabel12 As ToolStripLabel
    Friend WithEvents Timer3 As Timer
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStripLabel13 As ToolStripLabel
End Class
