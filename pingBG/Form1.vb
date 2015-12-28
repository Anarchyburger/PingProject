
Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading

Public Class Form1


    Dim tout11 As Integer = 0
    Dim tout22 As Integer = 0
    Dim tout33 As Integer = 0
    Dim tout44 As Integer = 0
    Dim tout55 As Integer = 0
    Dim tout66 As Integer = 0
    Dim tout77 As Integer = 0
    Dim tout88 As Integer = 0
    Dim ping As New Ping
    Dim rp(9) As PingReply
    Dim timeToStop As Boolean = False
    Dim cycAmt As Integer = 0
    Dim initAmt As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        Dim toolTip1 As New ToolTip()

        LinkLabel1.Text = h.AddressList.GetValue(0).ToString

        ping2.Visible = False
        ping3.Visible = False
        ping4.Visible = False
        ping5.Visible = False
        ping6.Visible = False
        ping7.Visible = False
        ping8.Visible = False

        toolTip1.AutoPopDelay = 10000
        toolTip1.InitialDelay = 100
        toolTip1.ReshowDelay = 100
        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(Me.checkALL, "Check ALL the boxes")
        toolTip1.SetToolTip(Me.Button3, "Auto populate the host IP addresses sequentially")

        Me.TopMost = True

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.WorkerSupportsCancellation = True

        rp(0) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct1.Value.ToString)
        rp(1) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct2.Value.ToString)
        rp(2) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct3.Value.ToString)
        rp(3) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct4.Value.ToString)
        rp(4) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct5.Value.ToString)
        rp(5) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct6.Value.ToString)
        rp(6) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct7.Value.ToString)
        rp(7) = ping.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct8.Value.ToString)
        'rp(8) = ping.Send("99.99.99.99")

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted



        If rp(0).Status = 0 Then
            ping1.ForeColor = Color.Green
            ping1.Text = "OK!"

        Else
            ping1.ForeColor = Color.Red
            ping1.Text = "*ERROR*"
            tout11 = tout11 + 1

        End If

        If rp(1).Status = 0 Then
            ping2.ForeColor = Color.Green
            ping2.Text = "OK!"
        Else
            ping2.ForeColor = Color.Red
            ping2.Text = "*ERROR*"
            tout22 = tout22 + 1
        End If

        If rp(2).Status = 0 Then
            ping3.ForeColor = Color.Green
            ping3.Text = "OK!"
        Else
            ping3.ForeColor = Color.Red
            ping3.Text = "*ERROR*"
            tout33 = tout33 + 1
        End If

        If rp(3).Status = 0 Then
            ping4.ForeColor = Color.Green
            ping4.Text = "OK!"
        Else
            ping4.ForeColor = Color.Red
            ping4.Text = "*ERROR*"
            tout44 = tout44 + 1
        End If

        If rp(4).Status = 0 Then
            ping5.ForeColor = Color.Green
            ping5.Text = "OK!"
        Else
            ping5.ForeColor = Color.Red
            ping5.Text = "*ERROR*"
            tout55 = tout55 + 1
        End If

        If rp(5).Status = 0 Then
            ping6.ForeColor = Color.Green
            ping6.Text = "OK!"
        Else
            ping6.ForeColor = Color.Red
            ping6.Text = "*ERROR*"
            tout66 = tout66 + 1
        End If

        If rp(6).Status = 0 Then
            ping7.ForeColor = Color.Green
            ping7.Text = "OK!"
        Else
            ping7.ForeColor = Color.Red
            ping7.Text = "*ERROR*"
            tout77 = tout77 + 1
        End If

        If rp(7).Status = 0 Then
            ping8.ForeColor = Color.Green
            ping8.Text = "OK!"
        Else
            ping8.ForeColor = Color.Red
            ping8.Text = "*ERROR*"
            tout88 = tout88 + 1

        End If

        If CheckBox3.Checked = True Then ping2.Visible = True
        If CheckBox4.Checked = True Then ping3.Visible = True
        If CheckBox5.Checked = True Then ping4.Visible = True
        If CheckBox6.Checked = True Then ping5.Visible = True
        If CheckBox7.Checked = True Then ping6.Visible = True
        If CheckBox8.Checked = True Then ping7.Visible = True
        If CheckBox9.Checked = True Then ping8.Visible = True

        tout1.Text = tout11.ToString
        If CheckBox3.Checked = True Then tout2.Text = tout22.ToString
        If CheckBox4.Checked = True Then tout3.Text = tout33.ToString
        If CheckBox5.Checked = True Then tout4.Text = tout44.ToString
        If CheckBox6.Checked = True Then tout5.Text = tout55.ToString
        If CheckBox7.Checked = True Then tout6.Text = tout66.ToString
        If CheckBox8.Checked = True Then tout7.Text = tout77.ToString
        If CheckBox9.Checked = True Then tout8.Text = tout88.ToString

        If timeToStop = True Then

            BackgroundWorker1.CancelAsync()
            cycleAmt.Text = "Done."
            Button1.Text = "Reload"
            Button1.Enabled = True

            Return
        End If
        BackgroundWorker1.RunWorkerAsync()

        cycAmt = cycAmt + 1
        cycleAmt.Text = cycAmt.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Reload" Then Application.Restart()

        Button1.Enabled = False
        Button2.Enabled = True

        cycleAmt.Text = "Starting Threads.."

        checkALL.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button1.Enabled = False
        Button2.Enabled = False

        timeToStop = True
        cycleAmt.Text = "Stopping.."

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            hostOct2.Enabled = True
            Label12.Enabled = True
            ping2.Enabled = True
            Label10.Enabled = True
            tout2.Enabled = True
        End If

        If CheckBox3.Checked = False Then
            hostOct2.Enabled = False
            Label12.Enabled = False
            ping2.Enabled = False
            Label10.Enabled = False
            tout2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            hostOct3.Enabled = True
            Label16.Enabled = True
            ping3.Enabled = True
            Label14.Enabled = True
            tout3.Enabled = True
        End If

        If CheckBox4.Checked = False Then
            hostOct3.Enabled = False
            Label16.Enabled = False
            ping3.Enabled = False
            Label14.Enabled = False
            tout3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then
            hostOct4.Enabled = True
            Label20.Enabled = True
            ping4.Enabled = True
            Label18.Enabled = True
            tout4.Enabled = True
        End If

        If CheckBox5.Checked = False Then
            hostOct4.Enabled = False
            Label20.Enabled = False
            ping4.Enabled = False
            Label18.Enabled = False
            tout4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then
            hostOct5.Enabled = True
            Label24.Enabled = True
            ping5.Enabled = True
            Label22.Enabled = True
            tout5.Enabled = True
        End If

        If CheckBox6.Checked = False Then
            hostOct5.Enabled = False
            Label24.Enabled = False
            ping5.Enabled = False
            Label22.Enabled = False
            tout5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

        If CheckBox7.Checked = True Then
            hostOct6.Enabled = True
            Label28.Enabled = True
            ping6.Enabled = True
            Label26.Enabled = True
            tout6.Enabled = True
        End If

        If CheckBox7.Checked = False Then
            hostOct6.Enabled = False
            Label28.Enabled = False
            ping6.Enabled = False
            Label26.Enabled = False
            tout6.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

        If CheckBox8.Checked = True Then
            hostOct7.Enabled = True
            Label32.Enabled = True
            ping7.Enabled = True
            Label30.Enabled = True
            tout7.Enabled = True
        End If

        If CheckBox8.Checked = False Then
            hostOct7.Enabled = False
            Label32.Enabled = False
            ping7.Enabled = False
            Label30.Enabled = False
            tout7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged

        If CheckBox9.Checked = True Then
            hostOct8.Enabled = True
            Label36.Enabled = True
            ping8.Enabled = True
            Label34.Enabled = True
            tout8.Enabled = True
        End If

        If CheckBox9.Checked = False Then
            hostOct8.Enabled = False
            Label36.Enabled = False
            ping8.Enabled = False
            Label34.Enabled = False
            tout8.Enabled = False
        End If
    End Sub

    Private Sub checkALL_CheckedChanged(sender As Object, e As EventArgs) Handles checkALL.CheckedChanged

        If checkALL.Checked = True Then
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
        End If

        If checkALL.Checked = False Then
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then Me.TopMost = True
        If CheckBox1.Checked = False Then Me.TopMost = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        initAmt = hostOct1.Value

        hostOct2.Value = initAmt + 1
        If hostOct2.Value > 255 Then hostOct2.Value = 255

        hostOct3.Value = initAmt + 2
        hostOct4.Value = initAmt + 3
        hostOct5.Value = initAmt + 4
        hostOct6.Value = initAmt + 5
        hostOct7.Value = initAmt + 6
        hostOct8.Value = initAmt + 7

    End Sub

    Public Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim h2 As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        Dim h3 As String
        h3 = h2.AddressList.GetValue(0).ToString

        Dim octet As String() = h3.Split(".")
        Dim octet0 As String = octet(0)
        Dim octet1 As String = octet(1)
        Dim octet2 As String = octet(2)
        Dim octet3 As String = octet(3)

        netOct1.Value = octet0
        netOct2.Value = octet1
        netOct3.Value = octet2
        hostOct1.Value = octet3



    End Sub
End Class
