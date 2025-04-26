Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2_MANLANGIT.Visible = False
        TrackBar1_MANLANGIT.Minimum = 0
        TrackBar1_MANLANGIT.Maximum = 100
        TrackBar1_MANLANGIT.TickFrequency = 5
        TrackBar1_MANLANGIT.Value = 50

        TrackBarSeek_MANLANGIT.Minimum = 0
        TrackBarSeek_MANLANGIT.Maximum = 1000
        TrackBarSeek_MANLANGIT.TickFrequency = 1
        TrackBarSeek_MANLANGIT.Value = 0

        lblStatus_MANLANGIT.Text = "Status"
        lblStatusTitle_MANLANGIT.Text = "Title"

        btnOpenFile_MANLANGIT.Select()

        AxWindowsMediaPlayer1_MANLANGIT.settings.volume = TrackBar1_MANLANGIT.Value
    End Sub

    Private Sub btnOpenFile_MANLANGIT_Click(sender As Object, e As EventArgs) Handles btnOpenFile_MANLANGIT.Click
        OpenFileDialog1_MANLANGIT.Filter = "MP3 Files|*.mp3"
        If OpenFileDialog1_MANLANGIT.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenFileDialog1_MANLANGIT.FileName
            If Path.GetExtension(filePath).ToLower() = ".mp3" Then
                AxWindowsMediaPlayer1_MANLANGIT.URL = filePath
                PictureBox2_MANLANGIT.Visible = True
                lblStatus_MANLANGIT.Text = "Now Playing"
                lblStatusTitle_MANLANGIT.Text = Path.GetFileName(filePath)
                Timer1_MANLANGIT.Start()
            Else
                MessageBox.Show("Invalid file type opened, please open mp3 files only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnPlay_MANLANGIT_Click(sender As Object, e As EventArgs) Handles btnPlay_MANLANGIT.Click
        AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_MANLANGIT_Click(sender As Object, e As EventArgs) Handles btnPause_MANLANGIT.Click
        AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_MANLANGIT_Click(sender As Object, e As EventArgs) Handles btnStop_MANLANGIT.Click
        AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.stop()
        Timer1_MANLANGIT.Stop()
        lblStatus_MANLANGIT.Text = "Status"
        lblStatusTitle_MANLANGIT.Text = "Title"
    End Sub

    Private Sub TrackBar1_MANLANGIT_Scroll(sender As Object, e As EventArgs) Handles TrackBar1_MANLANGIT.Scroll
        AxWindowsMediaPlayer1_MANLANGIT.settings.volume = TrackBar1_MANLANGIT.Value
    End Sub

    Private Sub TrackBarSeek_MANLANGIT_Scroll(sender As Object, e As EventArgs) Handles TrackBarSeek_MANLANGIT.Scroll
        AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.currentPosition = TrackBarSeek_MANLANGIT.Value
    End Sub

    Private Sub Timer1_MANLANGIT_Tick(sender As Object, e As EventArgs) Handles Timer1_MANLANGIT.Tick
        If AxWindowsMediaPlayer1_MANLANGIT.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            TrackBarSeek_MANLANGIT.Maximum = AxWindowsMediaPlayer1_MANLANGIT.currentMedia.duration
            TrackBarSeek_MANLANGIT.Value = AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.currentPosition
            TextBox1_MANLANGIT.Text = AxWindowsMediaPlayer1_MANLANGIT.Ctlcontrols.currentPositionString
        End If
    End Sub
End Class
