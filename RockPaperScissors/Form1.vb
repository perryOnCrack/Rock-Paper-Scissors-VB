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

Imports System.IO

Public Class Form1
    ' Custom datatype to store game stats
    Public Structure GameStat
        Dim winner As Byte ' 0 = Player, 1 = Computer, 2 = Draw
        Dim diff As Byte 'Easy = 0, Normal = 1, Hard = 2
        Dim round As UInteger
        Dim com As Byte
        Dim player As Byte
    End Structure

    Dim diff As Byte = 1 'Easy = 0, Normal = 1, Hard = 2
    Dim diffStr() As String = {"easy", "normal", "hard"}
    Dim winnerStr() As String = {"player", "com", "draw"}
    Dim rpsStr() As String = {"rock", "paper", "scissors"}
    Dim rnd As New Random()
    Dim pic_com(2) As Image
    Dim stats As New Queue(Of GameStat)
    Dim winTable(,) As Byte = {{2, 0, 1}, {1, 2, 0}, {0, 1, 2}}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the 3 buttons' Click action to the same subroutine.
        AddHandler btn_Rock.Click, AddressOf PlayerAct
        AddHandler btn_Paper.Click, AddressOf PlayerAct
        AddHandler btn_Scissors.Click, AddressOf PlayerAct
        ' Add picture resource to memory
        pic_com = {My.Resources.rock_large, My.Resources.paper_large, My.Resources.scissors_large}

        ' Reset all status
        Restart()
    End Sub

    Private Sub Restart() Handles NewGameToolStripMenuItem.Click
        lbox_Sats.Items.Clear()
        With lb_Result
            .Text = "按任意按鈕開始"
            .ForeColor = SystemColors.ControlText
        End With
        stats = New Queue(Of GameStat)
        pb_Com.Image = Nothing
        btn_Paper.BackColor = Nothing
        btn_Rock.BackColor = Nothing
        btn_Scissors.BackColor = Nothing
    End Sub

    Private Sub PlayerAct(sender As Object, e As EventArgs)
        ' Get player's pick & set pressed button's background
        Dim player As Byte
        If sender Is btn_Rock Then
            player = 0
            btn_Rock.BackColor = Color.Aqua
            btn_Paper.BackColor = Nothing
            btn_Scissors.BackColor = Nothing
        ElseIf sender Is btn_Paper Then
            player = 1
            btn_Rock.BackColor = Nothing
            btn_Paper.BackColor = Color.Aqua
            btn_Scissors.BackColor = Nothing
        Else
            player = 2
            btn_Rock.BackColor = Nothing
            btn_Paper.BackColor = Nothing
            btn_Scissors.BackColor = Color.Aqua
        End If

        ' Respond according to difficulty
        Dim com As Byte
        Select Case diff
            Case 0
                ' Make player win every time.
                If player = 0 Then
                    com = 2
                ElseIf player = 1 Then
                    com = 0
                Else
                    com = 1
                End If
            Case 1
                ' Random.
                com = rnd.Next() Mod 3
            Case Else
                ' Player can never win.
                If player = 0 Then
                    com = 1
                ElseIf player = 1 Then
                    com = 2
                Else
                    com = 0
                End If
        End Select

        ' Change com's picture.
        pb_Com.Image = pic_com(com)

        ' Determine round result using winTable
        Dim thisRnd As GameStat
        With thisRnd
            .round = stats.Count + 1
            .diff = diff
            .winner = winTable(com, player)
            .com = com
            .player = player
        End With

        ' Add this rnd's stat to stats and update status
        stats.Enqueue(thisRnd)
        Dim status_str As String = "回合" & CStr(thisRnd.round) & ", "
        If thisRnd.diff = 0 Then
            status_str = status_str & "簡單, "
        ElseIf thisRnd.diff = 1 Then
            status_str = status_str & "普通, "
        ElseIf thisRnd.diff = 2 Then
            status_str = status_str & "困難, "
        End If

        If thisRnd.winner = 0 Then
            status_str = status_str & "玩家贏"
            With lb_Result
                .Text = "玩家贏"
                .ForeColor = Color.Green
            End With
        ElseIf thisRnd.winner = 1 Then
            status_str = status_str & "電腦贏"
            With lb_Result
                .Text = "電腦贏"
                .ForeColor = Color.Red
            End With
        ElseIf thisRnd.winner = 2 Then
            status_str = status_str & "平手"
            With lb_Result
                .Text = "平手"
                .ForeColor = SystemColors.ControlText
            End With
        End If

        lbox_Sats.Items.Insert(0, status_str)

    End Sub

    Private Sub CredictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CredictToolStripMenuItem.Click
        MsgBox("Wave Hand by Tom Fricker from the Noun Project" & vbCrLf &
            "peace sign hand by Tom Fricker from the Noun Project" & vbCrLf &
            "fist hand by Tom Fricker from the Noun Project" & vbCrLf &
            "Rock Paper Scissors VB is released under GNU GPLv3 or later." & vbCrLf &
            "Source code is available on github.com/perryOnCrack/Rock-Paper-Scissors-VB", MsgBoxStyle.Information, "銘謝")
        '
    End Sub

    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        diff = 0
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        diff = 1
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        diff = 2
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If stats.Count <> 0 Then
            sfd.Filter = "CSV File|*.csv"
            sfd.FilterIndex = 1
            sfd.DefaultExt = ".csv"
            sfd.AddExtension = True
            sfd.FileName = "RPS_result"
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Save(sfd.FileName)
                Catch ex As Exception
                    MsgBox("Error writing file")
                    Return
                End Try
            End If
        Else
            MsgBox("沒資料可以儲存!!", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub Save(ByVal strFpath As String)
        Dim sw As StreamWriter
        Dim statsCopy As New Queue(Of GameStat)(stats)
        sw = New StreamWriter(strFpath)
        sw.WriteLine("round,diff,winner,player,com")
        Dim rnd As GameStat
        While statsCopy.Count <> 0
            rnd = statsCopy.Dequeue()
            sw.WriteLine(CStr(rnd.round) & "," & diffStr(rnd.diff) & "," & winnerStr(rnd.winner) & "," & rpsStr(rnd.player) & "," & rpsStr(rnd.com))
        End While
        sw.Close()
    End Sub
End Class
