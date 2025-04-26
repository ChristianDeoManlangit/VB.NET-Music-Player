<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1_MANLANGIT = New PictureBox()
        PictureBox2_MANLANGIT = New PictureBox()
        lblStatus_MANLANGIT = New Label()
        btnPause_MANLANGIT = New PictureBox()
        btnPlay_MANLANGIT = New PictureBox()
        btnStop_MANLANGIT = New PictureBox()
        TrackBar1_MANLANGIT = New TrackBar()
        lblStatusTitle_MANLANGIT = New Label()
        btnOpenFile_MANLANGIT = New PictureBox()
        AxWindowsMediaPlayer1_MANLANGIT = New AxWMPLib.AxWindowsMediaPlayer()
        TrackBarSeek_MANLANGIT = New TrackBar()
        Label1 = New Label()
        OpenFileDialog1_MANLANGIT = New OpenFileDialog()
        StatusStrip1_MANLANGIT = New StatusStrip()
        Timer1_MANLANGIT = New Timer(components)
        TextBox1_MANLANGIT = New TextBox()
        CType(PictureBox1_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnPause_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnPlay_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnStop_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnOpenFile_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(AxWindowsMediaPlayer1_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBarSeek_MANLANGIT, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1_MANLANGIT
        ' 
        PictureBox1_MANLANGIT.Image = My.Resources.Resources.Track_View__3_
        PictureBox1_MANLANGIT.Location = New Point(-166, -67)
        PictureBox1_MANLANGIT.Name = "PictureBox1_MANLANGIT"
        PictureBox1_MANLANGIT.Size = New Size(749, 901)
        PictureBox1_MANLANGIT.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1_MANLANGIT.TabIndex = 0
        PictureBox1_MANLANGIT.TabStop = False
        ' 
        ' PictureBox2_MANLANGIT
        ' 
        PictureBox2_MANLANGIT.Image = My.Resources.Resources.cat
        PictureBox2_MANLANGIT.Location = New Point(22, 111)
        PictureBox2_MANLANGIT.Name = "PictureBox2_MANLANGIT"
        PictureBox2_MANLANGIT.Size = New Size(372, 370)
        PictureBox2_MANLANGIT.TabIndex = 1
        PictureBox2_MANLANGIT.TabStop = False
        ' 
        ' lblStatus_MANLANGIT
        ' 
        lblStatus_MANLANGIT.AutoSize = True
        lblStatus_MANLANGIT.BackColor = Color.FromArgb(CByte(88), CByte(19), CByte(13))
        lblStatus_MANLANGIT.Font = New Font("Poppins", 13F)
        lblStatus_MANLANGIT.ForeColor = SystemColors.ControlLightLight
        lblStatus_MANLANGIT.Location = New Point(22, 530)
        lblStatus_MANLANGIT.Name = "lblStatus_MANLANGIT"
        lblStatus_MANLANGIT.Size = New Size(248, 31)
        lblStatus_MANLANGIT.TabIndex = 2
        lblStatus_MANLANGIT.Text = "Currently No File Selected:"
        ' 
        ' btnPause_MANLANGIT
        ' 
        btnPause_MANLANGIT.Image = My.Resources.Resources.Frame_3741
        btnPause_MANLANGIT.Location = New Point(88, 636)
        btnPause_MANLANGIT.Name = "btnPause_MANLANGIT"
        btnPause_MANLANGIT.Size = New Size(70, 70)
        btnPause_MANLANGIT.SizeMode = PictureBoxSizeMode.Zoom
        btnPause_MANLANGIT.TabIndex = 3
        btnPause_MANLANGIT.TabStop = False
        ' 
        ' btnPlay_MANLANGIT
        ' 
        btnPlay_MANLANGIT.Image = My.Resources.Resources.Frame_375
        btnPlay_MANLANGIT.Location = New Point(173, 636)
        btnPlay_MANLANGIT.Name = "btnPlay_MANLANGIT"
        btnPlay_MANLANGIT.Size = New Size(70, 70)
        btnPlay_MANLANGIT.SizeMode = PictureBoxSizeMode.Zoom
        btnPlay_MANLANGIT.TabIndex = 4
        btnPlay_MANLANGIT.TabStop = False
        ' 
        ' btnStop_MANLANGIT
        ' 
        btnStop_MANLANGIT.Image = My.Resources.Resources.Frame_376
        btnStop_MANLANGIT.Location = New Point(258, 635)
        btnStop_MANLANGIT.Name = "btnStop_MANLANGIT"
        btnStop_MANLANGIT.Size = New Size(70, 70)
        btnStop_MANLANGIT.SizeMode = PictureBoxSizeMode.Zoom
        btnStop_MANLANGIT.TabIndex = 5
        btnStop_MANLANGIT.TabStop = False
        ' 
        ' TrackBar1_MANLANGIT
        ' 
        TrackBar1_MANLANGIT.BackColor = Color.FromArgb(CByte(136), CByte(32), CByte(22))
        TrackBar1_MANLANGIT.Location = New Point(22, 57)
        TrackBar1_MANLANGIT.Name = "TrackBar1_MANLANGIT"
        TrackBar1_MANLANGIT.Size = New Size(372, 45)
        TrackBar1_MANLANGIT.TabIndex = 5
        ' 
        ' lblStatusTitle_MANLANGIT
        ' 
        lblStatusTitle_MANLANGIT.BackColor = Color.FromArgb(CByte(88), CByte(19), CByte(13))
        lblStatusTitle_MANLANGIT.Font = New Font("Poppins", 15F, FontStyle.Bold)
        lblStatusTitle_MANLANGIT.ForeColor = SystemColors.ControlLightLight
        lblStatusTitle_MANLANGIT.Location = New Point(22, 494)
        lblStatusTitle_MANLANGIT.Name = "lblStatusTitle_MANLANGIT"
        lblStatusTitle_MANLANGIT.Size = New Size(372, 36)
        lblStatusTitle_MANLANGIT.TabIndex = 6
        lblStatusTitle_MANLANGIT.Text = "Song Title"
        ' 
        ' btnOpenFile_MANLANGIT
        ' 
        btnOpenFile_MANLANGIT.Image = My.Resources.Resources.Frame_377__1_
        btnOpenFile_MANLANGIT.Location = New Point(364, 655)
        btnOpenFile_MANLANGIT.Name = "btnOpenFile_MANLANGIT"
        btnOpenFile_MANLANGIT.Size = New Size(30, 30)
        btnOpenFile_MANLANGIT.SizeMode = PictureBoxSizeMode.Zoom
        btnOpenFile_MANLANGIT.TabIndex = 7
        btnOpenFile_MANLANGIT.TabStop = False
        ' 
        ' AxWindowsMediaPlayer1_MANLANGIT
        ' 
        AxWindowsMediaPlayer1_MANLANGIT.Enabled = True
        AxWindowsMediaPlayer1_MANLANGIT.Location = New Point(155, 148)
        AxWindowsMediaPlayer1_MANLANGIT.Name = "AxWindowsMediaPlayer1_MANLANGIT"
        AxWindowsMediaPlayer1_MANLANGIT.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1_MANLANGIT.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1_MANLANGIT.Size = New Size(75, 54)
        AxWindowsMediaPlayer1_MANLANGIT.TabIndex = 8
        ' 
        ' TrackBarSeek_MANLANGIT
        ' 
        TrackBarSeek_MANLANGIT.BackColor = Color.FromArgb(CByte(88), CByte(19), CByte(13))
        TrackBarSeek_MANLANGIT.Location = New Point(22, 570)
        TrackBarSeek_MANLANGIT.Name = "TrackBarSeek_MANLANGIT"
        TrackBarSeek_MANLANGIT.Size = New Size(372, 45)
        TrackBarSeek_MANLANGIT.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(135), CByte(32), CByte(22))
        Label1.Font = New Font("Poppins", 15F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(22, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 36)
        Label1.TabIndex = 10
        Label1.Text = "Volume:"
        ' 
        ' OpenFileDialog1_MANLANGIT
        ' 
        OpenFileDialog1_MANLANGIT.FileName = "OpenFileDialog1"
        ' 
        ' StatusStrip1_MANLANGIT
        ' 
        StatusStrip1_MANLANGIT.Location = New Point(0, 707)
        StatusStrip1_MANLANGIT.Name = "StatusStrip1_MANLANGIT"
        StatusStrip1_MANLANGIT.Size = New Size(416, 22)
        StatusStrip1_MANLANGIT.TabIndex = 11
        StatusStrip1_MANLANGIT.Text = "StatusStrip1"
        ' 
        ' Timer1_MANLANGIT
        ' 
        ' 
        ' TextBox1_MANLANGIT
        ' 
        TextBox1_MANLANGIT.BackColor = Color.FromArgb(CByte(88), CByte(19), CByte(13))
        TextBox1_MANLANGIT.BorderStyle = BorderStyle.None
        TextBox1_MANLANGIT.Font = New Font("Poppins", 13F)
        TextBox1_MANLANGIT.ForeColor = SystemColors.WindowFrame
        TextBox1_MANLANGIT.Location = New Point(294, 530)
        TextBox1_MANLANGIT.Name = "TextBox1_MANLANGIT"
        TextBox1_MANLANGIT.Size = New Size(100, 26)
        TextBox1_MANLANGIT.TabIndex = 12
        TextBox1_MANLANGIT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(416, 729)
        Controls.Add(TextBox1_MANLANGIT)
        Controls.Add(Label1)
        Controls.Add(TrackBarSeek_MANLANGIT)
        Controls.Add(btnOpenFile_MANLANGIT)
        Controls.Add(lblStatusTitle_MANLANGIT)
        Controls.Add(TrackBar1_MANLANGIT)
        Controls.Add(btnStop_MANLANGIT)
        Controls.Add(btnPlay_MANLANGIT)
        Controls.Add(btnPause_MANLANGIT)
        Controls.Add(lblStatus_MANLANGIT)
        Controls.Add(PictureBox2_MANLANGIT)
        Controls.Add(PictureBox1_MANLANGIT)
        Controls.Add(AxWindowsMediaPlayer1_MANLANGIT)
        Controls.Add(StatusStrip1_MANLANGIT)
        DoubleBuffered = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(btnPause_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(btnPlay_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(btnStop_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(btnOpenFile_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(AxWindowsMediaPlayer1_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBarSeek_MANLANGIT, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1_MANLANGIT As PictureBox
    Friend WithEvents PictureBox2_MANLANGIT As PictureBox
    Friend WithEvents lblStatus_MANLANGIT As Label
    Friend WithEvents btnPause_MANLANGIT As PictureBox
    Friend WithEvents btnPlay_MANLANGIT As PictureBox
    Friend WithEvents btnStop_MANLANGIT As PictureBox
    Friend WithEvents TrackBar1_MANLANGIT As TrackBar
    Friend WithEvents lblStatusTitle_MANLANGIT As Label
    Friend WithEvents btnOpenFile_MANLANGIT As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1_MANLANGIT As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TrackBarSeek_MANLANGIT As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1_MANLANGIT As OpenFileDialog
    Friend WithEvents StatusStrip1_MANLANGIT As StatusStrip
    Friend WithEvents Timer1_MANLANGIT As Timer
    Friend WithEvents TextBox1_MANLANGIT As TextBox

End Class
