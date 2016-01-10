
Imports System.ComponentModel
Imports System.Net
Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Net.NetworkInformation


Public Class Form1
    Dim filename As String = Application.StartupPath & "\test.log"
    Dim sw As StreamWriter = AppendText(filename)
    Dim logit As Boolean = False
    Dim checkedAmt As Integer = 0
    Dim threadCheck(9) As Integer
    Dim threadcount As Integer
    Dim stopcheck As Boolean = False
    Dim t0 As Thread
    Dim t00 As Thread
    Dim t1 As Thread
    Dim t11 As Thread
    Dim t2 As Thread
    Dim t22 As Thread
    Dim t3 As Thread
    Dim t33 As Thread
    Dim t4 As Thread
    Dim t44 As Thread
    Dim t5 As Thread
    Dim t55 As Thread
    Dim t6 As Thread
    Dim t66 As Thread
    Dim t7 As Thread
    Dim t77 As Thread
    Dim t8 As Thread
    Dim t88 As Thread
    Dim t9 As Thread
    Dim t99 As Thread
    Dim tout00 As Integer = 0
    Dim tout11 As Integer = 0
    Dim tout22 As Integer = 0
    Dim tout33 As Integer = 0
    Dim tout44 As Integer = 0
    Dim tout55 As Integer = 0
    Dim tout66 As Integer = 0
    Dim tout77 As Integer = 0
    Dim tout88 As Integer = 0
    Dim tout99 As Integer = 0
    Dim doPing0 As New Ping
    Dim doPing1 As New Ping
    Dim doPing2 As New Ping
    Dim doPing3 As New Ping
    Dim doPing4 As New Ping
    Dim doPing5 As New Ping
    Dim doPing6 As New Ping
    Dim doPing7 As New Ping
    Dim doPing8 As New Ping
    Dim doPing9 As New Ping
    Dim rp(11) As PingReply
    Dim timeToStop As Boolean = False
    Dim cycAmt As Integer = 0
    Dim initAmt As Integer
    Dim hName(9) As String
    Dim hNameSplit As String()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim h As System.Net.IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
        Dim toolTip1 As New ToolTip()

        LinkLabel1.Text = h.AddressList.GetValue(0).ToString

        toolTip1.AutoPopDelay = 10000
        toolTip1.InitialDelay = 100
        toolTip1.ReshowDelay = 100
        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(Me.checkALL, "Check ALL the boxes")
        toolTip1.SetToolTip(Me.Button3, "Auto populate the host IP addresses sequentially")

        Me.TopMost = True



    End Sub


    Private Sub thread0()

        Do Until stopcheck = True
            Try
                rp(0) = doPing0.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString)
            Catch ex As Exception
                Thread.Sleep(1000)
            End Try

            p0()
        Loop
    End Sub

    Private Sub thread00()

        Try
            hName(0) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString).HostName.ToString
        Catch ex As Exception
        End Try
        p00()

    End Sub


    Private Sub thread1()
        Do Until stopcheck = True
            Try
                rp(1) = doPing1.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct1.Value.ToString)

            Catch
                Thread.Sleep(1000)
            End Try

            p1()
        Loop
    End Sub
    Private Sub thread11()

        Try
            hName(1) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct1.Value.ToString).HostName.ToString
        Catch
        End Try
        p11()

    End Sub

    Private Sub thread2()
        Do Until stopcheck = True
            Try
                rp(2) = doPing2.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct2.Value.ToString)

            Catch ex2 As Exception
                Thread.Sleep(1000)
            End Try

            p2()
        Loop
    End Sub
    Private Sub thread22()

        Try
            hName(2) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct2.Value.ToString).HostName.ToString
        Catch
        End Try
        p22()

    End Sub

    Private Sub thread3()
        Do Until stopcheck = True
            Try
                rp(3) = doPing3.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct3.Value.ToString)

            Catch ex3 As Exception
                Thread.Sleep(1000)
            End Try
            p3()
        Loop
    End Sub

    Private Sub thread33()

        Try
            hName(3) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct3.Value.ToString).HostName.ToString
        Catch
        End Try
        p33()

    End Sub

    Private Sub thread4()
        Do Until stopcheck = True
            Try
                rp(4) = doPing4.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct4.Value.ToString)

            Catch ex4 As Exception
                Thread.Sleep(1000)
            End Try
            p4()
        Loop
    End Sub

    Private Sub thread44()

        Try
            hName(4) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct4.Value.ToString).HostName.ToString
        Catch
        End Try
        p44()

    End Sub


    Private Sub thread5()
        Do Until stopcheck = True
            Try
                rp(5) = doPing5.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct5.Value.ToString)

            Catch ex5 As Exception
                Thread.Sleep(1000)
            End Try
            p5()
        Loop
    End Sub

    Private Sub thread55()


        Try
            hName(5) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct5.Value.ToString).HostName.ToString

        Catch
        End Try
        p55()

    End Sub


    Private Sub thread6()
        Do Until stopcheck = True
            Try
                rp(6) = doPing6.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct6.Value.ToString)

            Catch ex6 As Exception
                Thread.Sleep(1000)
            End Try
            p6()
        Loop
    End Sub

    Private Sub thread66()


        Try
            hName(6) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct6.Value.ToString).HostName.ToString
        Catch
        End Try
        p66()

    End Sub


    Private Sub thread7()
        Do Until stopcheck = True
            Try
                rp(7) = doPing7.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct7.Value.ToString)

            Catch ex7 As Exception
                Thread.Sleep(1000)
            End Try
            p7()
        Loop
    End Sub

    Private Sub thread77()


        Try
            hName(7) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct7.Value.ToString).HostName.ToString
        Catch
        End Try
        p77()

    End Sub


    Private Sub thread8()
        Do Until stopcheck = True
            Try
                rp(8) = doPing8.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct8.Value.ToString)

            Catch ex8 As Exception
                Thread.Sleep(1000)
            End Try
            p8()
        Loop
    End Sub

    Private Sub thread88()


        Try
            hName(8) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct8.Value.ToString).HostName.ToString

        Catch
        End Try
        p88()

    End Sub

    Private Sub thread9()
        Do Until stopcheck = True
            Try
                rp(9) = doPing9.Send(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct9.Value.ToString)

            Catch ex9 As Exception
                Thread.Sleep(1000)
            End Try
            p9()
        Loop
    End Sub

    Private Sub thread99()


        Try
            hName(9) = Dns.GetHostEntry(netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct9.Value.ToString).HostName.ToString

        Catch
        End Try
        p99()

    End Sub

    Private Sub p0()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p0))
        Else

            If rp(0).Status = 0 Then
                ping0.ForeColor = Color.Green
                ping0.Text = "OK!"

            Else
                ping0.ForeColor = Color.Red
                ping0.Text = "*ERROR*"

                tout00 = tout00 + 1
                tout0.Text = tout00
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")
            End If

        End If


    End Sub

    Private Sub p00()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p00))
        Else
            If String.IsNullOrEmpty(hName(0)) Then
                hostNameL0.Text = "????"
            Else
                hNameSplit = hName(0).Split(".")
                hostNameL0.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub p1()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p1))

        Else

            If rp(1).Status = 0 Then
                ping1.ForeColor = Color.Green
                ping1.Text = "OK!"

            Else
                ping1.ForeColor = Color.Red
                ping1.Text = "*Error*"
                tout11 = tout11 + 1
                tout1.Text = tout11
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If


    End Sub
    Private Sub p11()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p11))
        Else
            If String.IsNullOrEmpty(hName(1)) Then
                hostNameL1.Text = "????"
            Else
                hNameSplit = hName(1).Split(".")
                hostNameL1.Text = hNameSplit(0)

            End If
        End If


    End Sub

    Private Sub p2()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p2))
        Else
            If rp(2).Status = 0 Then
                ping2.ForeColor = Color.Green
                ping2.Text = "OK!"
            Else
                ping2.ForeColor = Color.Red
                ping2.Text = "*Error*"
                tout22 = tout22 + 1
                tout2.Text = tout22
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p22()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p22))
        Else
            If String.IsNullOrEmpty(hName(2)) Then
                hostNameL2.Text = "????"
            Else
                hNameSplit = hName(2).Split(".")
                hostNameL2.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub p3()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p3))
        Else


            If rp(3).Status = 0 Then
                ping3.ForeColor = Color.Green
                ping3.Text = "OK!"
            Else
                ping3.ForeColor = Color.Red
                ping3.Text = "*Error*"
                tout33 = tout33 + 1
                tout3.Text = tout33
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p33()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p33))
        Else
            If String.IsNullOrEmpty(hName(3)) Then
                hostNameL3.Text = "????"
            Else
                hNameSplit = hName(3).Split(".")
                hostNameL3.Text = hNameSplit(0)

            End If
        End If


    End Sub

    Private Sub p4()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p4))
        Else

            If rp(4).Status = 0 Then
                ping4.ForeColor = Color.Green
                ping4.Text = "OK!"
            Else
                ping4.ForeColor = Color.Red
                ping4.Text = "*Error*"
                tout44 = tout44 + 1
                tout4.Text = tout44
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p44()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p44))
        Else
            If String.IsNullOrEmpty(hName(4)) Then
                hostNameL4.Text = "????"
            Else
                hNameSplit = hName(4).Split(".")
                hostNameL4.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub p5()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p5))
        Else

            If rp(5).Status = 0 Then
                ping5.ForeColor = Color.Green
                ping5.Text = "OK!"
            Else
                ping5.ForeColor = Color.Red
                ping5.Text = "*Error*"
                tout55 = tout55 + 1
                tout5.Text = tout55
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p55()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p55))
        Else
            If String.IsNullOrEmpty(hName(5)) Then
                hostNameL5.Text = "????"
            Else
                hNameSplit = hName(5).Split(".")
                hostNameL5.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub p6()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p6))
        Else

            If rp(6).Status = 0 Then
                ping6.ForeColor = Color.Green
                ping6.Text = "OK!"
            Else
                ping6.ForeColor = Color.Red
                ping6.Text = "*Error*"
                tout66 = tout66 + 1
                tout6.Text = tout66
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p66()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p66))
        Else
            If String.IsNullOrEmpty(hName(6)) Then
                hostNameL6.Text = "????"
            Else
                hNameSplit = hName(6).Split(".")
                hostNameL6.Text = hNameSplit(0)

            End If
        End If


    End Sub

    Private Sub p7()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p7))
        Else

            If rp(7).Status = 0 Then
                ping7.ForeColor = Color.Green
                ping7.Text = "OK!"
            Else
                ping7.ForeColor = Color.Red
                ping7.Text = "*Error*"
                tout77 = tout77 + 1
                tout7.Text = tout77
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p77()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p77))
        Else
            If String.IsNullOrEmpty(hName(7)) Then
                hostNameL7.Text = "????"
            Else
                hNameSplit = hName(7).Split(".")
                hostNameL7.Text = hNameSplit(0)

            End If
        End If


    End Sub

    Private Sub p8()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p8))
        Else
            If rp(8).Status = 0 Then
                ping8.ForeColor = Color.Green
                ping8.Text = "OK!"
            Else
                ping8.ForeColor = Color.Red
                ping8.Text = "*Error*"
                tout88 = tout88 + 1
                tout8.Text = tout88
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p88()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p88))
        Else
            If String.IsNullOrEmpty(hName(8)) Then
                hostNameL8.Text = "????"
            Else
                hNameSplit = hName(8).Split(".")
                hostNameL8.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub p9()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p9))
        Else


            If rp(9).Status = 0 Then
                ping9.ForeColor = Color.Green
                ping9.Text = "OK!"
            Else
                ping9.ForeColor = Color.Red
                ping9.Text = "*Error*"
                tout99 = tout99 + 1
                tout9.Text = tout99
                If logit = True Then sw.WriteLine(Now() & " " + netOct1.Value.ToString + "." + netOct2.Value.ToString + "." + netOct3.Value.ToString + "." + hostOct0.Value.ToString + " Errored.")

            End If
        End If

    End Sub

    Private Sub p99()


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf p99))
        Else
            If String.IsNullOrEmpty(hName(9)) Then
                hostNameL9.Text = "????"
            Else
                hNameSplit = hName(9).Split(".")
                hostNameL9.Text = hNameSplit(0)

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Reload" Then Application.Restart()


        t0 = New Thread(AddressOf thread0)
        t0.Start()

        t00 = New Thread(AddressOf thread00)
        t00.Start()
        threadCheck(0) = 1

        If check1.Checked = True Then
            t1 = New Thread(AddressOf thread1)
            t1.Start()
            t11 = New Thread(AddressOf thread11)
            t11.Start()
            threadCheck(1) = 1
        End If

        If check2.Checked = True Then
            t2 = New Thread(AddressOf thread2)
            t2.Start()
            t22 = New Thread(AddressOf thread22)
            t22.Start()
            threadCheck(2) = 1
        End If

        If check3.Checked = True Then
            t3 = New Thread(AddressOf thread3)
            t3.Start()
            t33 = New Thread(AddressOf thread33)
            t33.Start()
            threadCheck(3) = 1
        End If

        If check4.Checked = True Then
            t4 = New Thread(AddressOf thread4)
            t4.Start()
            t44 = New Thread(AddressOf thread44)
            t44.Start()
            threadCheck(4) = 1
        End If

        If check5.Checked = True Then
            t5 = New Thread(AddressOf thread5)
            t5.Start()
            t55 = New Thread(AddressOf thread55)
            t55.Start()
            threadCheck(5) = 1
        End If

        If check6.Checked = True Then
            t6 = New Thread(AddressOf thread6)
            t6.Start()
            t66 = New Thread(AddressOf thread66)
            t66.Start()
            threadCheck(6) = 1
        End If

        If check7.Checked = True Then
            t7 = New Thread(AddressOf thread7)
            t7.Start()
            t77 = New Thread(AddressOf thread77)
            t77.Start()
            threadCheck(7) = 1
        End If

        If check8.Checked = True Then
            t8 = New Thread(AddressOf thread8)
            t8.Start()
            t88 = New Thread(AddressOf thread88)
            t88.Start()
            threadCheck(8) = 1
        End If

        If check9.Checked = True Then
            t9 = New Thread(AddressOf thread9)
            t9.Start()
            t99 = New Thread(AddressOf thread99)
            t99.Start()
            threadCheck(9) = 1
        End If

        For i As Integer = 0 To 9
            threadcount = threadcount + threadCheck(i)
        Next

        Button1.Enabled = False
        Button2.Enabled = True

        checkALL.Enabled = False
        check1.Enabled = False
        check2.Enabled = False
        check3.Enabled = False
        check4.Enabled = False
        check5.Enabled = False
        check6.Enabled = False
        check7.Enabled = False
        check8.Enabled = False
        check9.Enabled = False




        cycleAmt.Text = "Pinging " & threadcount & " Host(s)"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        stopcheck = True
        Button1.Enabled = True
        Button2.Enabled = False
        timeToStop = True
        cycleAmt.Text = "Stopped."
        Button1.Text = "Reload"

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles check1.CheckedChanged

        If check1.Checked = True Then
            hostOct1.Enabled = True
            pingRes1.Enabled = True
            ping1.Enabled = True
            totalToutLabel1.Enabled = True
            tout1.Enabled = True
        End If

        If check1.Checked = False Then
            hostOct1.Enabled = False
            pingRes1.Enabled = False
            ping1.Enabled = False
            totalToutLabel1.Enabled = False
            tout1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles check2.CheckedChanged

        If check2.Checked = True Then
            hostOct2.Enabled = True
            pingRes2.Enabled = True
            ping2.Enabled = True
            totalToutLabel2.Enabled = True
            tout2.Enabled = True
        End If

        If check2.Checked = False Then
            hostOct2.Enabled = False
            pingRes2.Enabled = False
            ping2.Enabled = False
            totalToutLabel2.Enabled = False
            tout2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles check3.CheckedChanged

        If check3.Checked = True Then
            hostOct3.Enabled = True
            pingRes3.Enabled = True
            ping3.Enabled = True
            totalToutLabel3.Enabled = True
            tout3.Enabled = True
        End If

        If check3.Checked = False Then
            hostOct3.Enabled = False
            pingRes3.Enabled = False
            ping3.Enabled = False
            totalToutLabel3.Enabled = False
            tout3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles check4.CheckedChanged

        If check4.Checked = True Then
            hostOct4.Enabled = True
            pingRes4.Enabled = True
            ping4.Enabled = True
            totalToutLabel4.Enabled = True
            tout4.Enabled = True
        End If

        If check4.Checked = False Then
            hostOct4.Enabled = False
            pingRes4.Enabled = False
            ping4.Enabled = False
            totalToutLabel4.Enabled = False
            tout4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles check5.CheckedChanged

        If check5.Checked = True Then
            hostOct5.Enabled = True
            pingRes5.Enabled = True
            ping5.Enabled = True
            totalToutLabel5.Enabled = True
            tout5.Enabled = True
        End If

        If check5.Checked = False Then
            hostOct5.Enabled = False
            pingRes5.Enabled = False
            ping5.Enabled = False
            totalToutLabel5.Enabled = False
            tout5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles check6.CheckedChanged

        If check6.Checked = True Then
            hostOct6.Enabled = True
            pingRes6.Enabled = True
            ping6.Enabled = True
            totalToutLabel6.Enabled = True
            tout6.Enabled = True
        End If

        If check6.Checked = False Then
            hostOct6.Enabled = False
            pingRes6.Enabled = False
            ping6.Enabled = False
            totalToutLabel6.Enabled = False
            tout6.Enabled = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles check7.CheckedChanged

        If check7.Checked = True Then
            hostOct7.Enabled = True
            pingRes7.Enabled = True
            ping7.Enabled = True
            totalToutLabel7.Enabled = True
            tout7.Enabled = True
        End If

        If check7.Checked = False Then
            hostOct7.Enabled = False
            pingRes7.Enabled = False
            ping7.Enabled = False
            totalToutLabel7.Enabled = False
            tout7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles check8.CheckedChanged

        If check8.Checked = True Then
            hostOct8.Enabled = True
            pingRes8.Enabled = True
            ping8.Enabled = True
            totalToutLabel8.Enabled = True
            tout8.Enabled = True
        End If

        If check8.Checked = False Then
            hostOct8.Enabled = False
            pingRes8.Enabled = False
            ping8.Enabled = False
            totalToutLabel8.Enabled = False
            tout8.Enabled = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles check9.CheckedChanged

        If check9.Checked = True Then
            hostOct9.Enabled = True
            pingRes9.Enabled = True
            ping9.Enabled = True
            totalToutLabel9.Enabled = True
            tout9.Enabled = True
        End If

        If check9.Checked = False Then
            hostOct9.Enabled = False
            pingRes9.Enabled = False
            ping9.Enabled = False
            totalToutLabel9.Enabled = False
            tout9.Enabled = False
        End If
    End Sub
    Private Sub checkALL_CheckedChanged(sender As Object, e As EventArgs) Handles checkALL.CheckedChanged

        If checkALL.Checked = True Then
            check1.Checked = True
            check2.Checked = True
            check3.Checked = True
            check4.Checked = True
            check5.Checked = True
            check6.Checked = True
            check7.Checked = True
            check8.Checked = True
            check9.Checked = True
        End If

        If checkALL.Checked = False Then
            check1.Checked = False
            check2.Checked = False
            check3.Checked = False
            check4.Checked = False
            check5.Checked = False
            check6.Checked = False
            check7.Checked = False
            check8.Checked = False
            check9.Checked = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then Me.TopMost = True
        If CheckBox1.Checked = False Then Me.TopMost = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        initAmt = hostOct0.Value

        hostOct1.Value = initAmt + 1
        If hostOct1.Value > 255 Then hostOct1.Value = 255

        hostOct2.Value = initAmt + 2
        hostOct3.Value = initAmt + 3
        hostOct4.Value = initAmt + 4
        hostOct5.Value = initAmt + 5
        hostOct6.Value = initAmt + 6
        hostOct7.Value = initAmt + 7
        hostOct8.Value = initAmt + 8
        hostOct9.Value = initAmt + 9

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim h2 As System.Net.IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
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
        hostOct0.Value = octet3 + 1

    End Sub

    Private Sub logginBox_CheckedChanged(sender As Object, e As EventArgs) Handles logginBox.CheckedChanged

        If logginBox.Checked Then
            logit = True
        Else
            logit = False
        End If

    End Sub

    Private Sub alertCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles alertCheckBox.CheckedChanged

        If alertCheckBox.CheckAlign = True Then

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Button2.PerformClick()
        cycleAmt.Text = "Closing..."
        sw.Close()

    End Sub

End Class