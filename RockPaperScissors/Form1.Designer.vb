'Copyright 2021 Bo-Yu Lu (perryOnCrack)
'
'This file Is part Of Rock Paper Scissors VB.
'
'Rock Paper Scissors VB Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.
'
'Rock Paper Scissors VB Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.
'
'You should have received a copy Of the GNU General Public License
'along with Rock Paper Scissors VB.  If Not, see < https: //www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbox_Sats = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CredictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lb_Result = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.pb_Com = New System.Windows.Forms.PictureBox()
        Me.btn_Scissors = New System.Windows.Forms.Button()
        Me.btn_Paper = New System.Windows.Forms.Button()
        Me.btn_Rock = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pb_Com, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbox_Sats
        '
        Me.lbox_Sats.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbox_Sats.FormattingEnabled = True
        Me.lbox_Sats.ItemHeight = 30
        Me.lbox_Sats.Location = New System.Drawing.Point(465, 96)
        Me.lbox_Sats.Name = "lbox_Sats"
        Me.lbox_Sats.Size = New System.Drawing.Size(308, 334)
        Me.lbox_Sats.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.DifficultyToolStripMenuItem, Me.CredictToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.GameToolStripMenuItem.Text = "遊戲"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NewGameToolStripMenuItem.Text = "新遊戲"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SaveToolStripMenuItem.Text = "儲存成 CSV"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "離開"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.NormalToolStripMenuItem, Me.HardToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DifficultyToolStripMenuItem.Text = "難度"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EasyToolStripMenuItem.Text = "簡單"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NormalToolStripMenuItem.Text = "普通"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.HardToolStripMenuItem.Text = "困難"
        '
        'CredictToolStripMenuItem
        '
        Me.CredictToolStripMenuItem.Name = "CredictToolStripMenuItem"
        Me.CredictToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.CredictToolStripMenuItem.Text = "銘謝"
        '
        'lb_Result
        '
        Me.lb_Result.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lb_Result.Font = New System.Drawing.Font("微軟正黑體", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_Result.Location = New System.Drawing.Point(472, 34)
        Me.lb_Result.Name = "lb_Result"
        Me.lb_Result.Size = New System.Drawing.Size(295, 49)
        Me.lb_Result.TabIndex = 7
        Me.lb_Result.Text = "按任意按鈕開始"
        Me.lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "電腦"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "玩家"
        '
        'pb_Com
        '
        Me.pb_Com.Location = New System.Drawing.Point(140, 54)
        Me.pb_Com.Name = "pb_Com"
        Me.pb_Com.Size = New System.Drawing.Size(259, 240)
        Me.pb_Com.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Com.TabIndex = 5
        Me.pb_Com.TabStop = False
        '
        'btn_Scissors
        '
        Me.btn_Scissors.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_Scissors.FlatAppearance.BorderSize = 2
        Me.btn_Scissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Scissors.Image = Global.RockPaperScissors.My.Resources.Resources.scissors
        Me.btn_Scissors.Location = New System.Drawing.Point(316, 348)
        Me.btn_Scissors.Name = "btn_Scissors"
        Me.btn_Scissors.Size = New System.Drawing.Size(82, 82)
        Me.btn_Scissors.TabIndex = 3
        Me.btn_Scissors.UseVisualStyleBackColor = True
        '
        'btn_Paper
        '
        Me.btn_Paper.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_Paper.FlatAppearance.BorderSize = 2
        Me.btn_Paper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Paper.Image = Global.RockPaperScissors.My.Resources.Resources.paper
        Me.btn_Paper.Location = New System.Drawing.Point(228, 348)
        Me.btn_Paper.Name = "btn_Paper"
        Me.btn_Paper.Size = New System.Drawing.Size(82, 82)
        Me.btn_Paper.TabIndex = 2
        Me.btn_Paper.UseVisualStyleBackColor = True
        '
        'btn_Rock
        '
        Me.btn_Rock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_Rock.FlatAppearance.BorderSize = 2
        Me.btn_Rock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Rock.Image = Global.RockPaperScissors.My.Resources.Resources.rock
        Me.btn_Rock.Location = New System.Drawing.Point(140, 348)
        Me.btn_Rock.Name = "btn_Rock"
        Me.btn_Rock.Size = New System.Drawing.Size(82, 82)
        Me.btn_Rock.TabIndex = 1
        Me.btn_Rock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_Result)
        Me.Controls.Add(Me.pb_Com)
        Me.Controls.Add(Me.lbox_Sats)
        Me.Controls.Add(Me.btn_Scissors)
        Me.Controls.Add(Me.btn_Paper)
        Me.Controls.Add(Me.btn_Rock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "剪刀、石頭、布"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pb_Com, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Rock As Button
    Friend WithEvents btn_Paper As Button
    Friend WithEvents btn_Scissors As Button
    Friend WithEvents lbox_Sats As ListBox
    Friend WithEvents pb_Com As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CredictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb_Result As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sfd As SaveFileDialog
End Class
