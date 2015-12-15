
Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading





Public Class Form1

    Dim ping As New Ping
    Dim rp(9) As PingReply
    Dim timeToStop As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.WorkerSupportsCancellation = True

        rp(0) = ping.Send("192.168.23.100")
        rp(1) = ping.Send("www.windows.com")
        rp(2) = ping.Send("www.google.com")

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Label1.Text = rp(0).Status
        Label2.Text = rp(1).RoundtripTime
        Label3.Text = rp(2).RoundtripTime
        If timeToStop = True Then
            BackgroundWorker1.CancelAsync()
            Label4.Text = "Done."
            Return
        End If
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Enabled = False
        Button2.Enabled = True

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        timeToStop = True
        Label4.Text = "Stopping.."

    End Sub
End Class
