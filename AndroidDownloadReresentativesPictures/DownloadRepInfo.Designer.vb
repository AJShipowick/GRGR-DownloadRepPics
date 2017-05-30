<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadRepInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRepPhotoDirectory = New System.Windows.Forms.TextBox()
        Me.lblRepPicsRoot = New System.Windows.Forms.Label()
        Me.rdbtnSmallPic = New System.Windows.Forms.RadioButton()
        Me.rdbtnMediumPic = New System.Windows.Forms.RadioButton()
        Me.rdbtnLargePic = New System.Windows.Forms.RadioButton()
        Me.lblAndroidDrawableDirectory = New System.Windows.Forms.Label()
        Me.txtAndroidDirectory = New System.Windows.Forms.TextBox()
        Me.rdbtnAllPics = New System.Windows.Forms.RadioButton()
        Me.btnStartDownload = New System.Windows.Forms.Button()
        Me.lblAndroidStringDirectory = New System.Windows.Forms.Label()
        Me.txtAndroidRootStringDirectory = New System.Windows.Forms.TextBox()
        Me.ckDownloadPics = New System.Windows.Forms.CheckBox()
        Me.ckDownloadFile = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtRepPhotoDirectory
        '
        Me.txtRepPhotoDirectory.Location = New System.Drawing.Point(170, 24)
        Me.txtRepPhotoDirectory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRepPhotoDirectory.Name = "txtRepPhotoDirectory"
        Me.txtRepPhotoDirectory.Size = New System.Drawing.Size(343, 20)
        Me.txtRepPhotoDirectory.TabIndex = 0
        Me.txtRepPhotoDirectory.Text = "https://www.govtrack.us/data/photos/"
        '
        'lblRepPicsRoot
        '
        Me.lblRepPicsRoot.AutoSize = True
        Me.lblRepPicsRoot.Location = New System.Drawing.Point(9, 27)
        Me.lblRepPicsRoot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRepPicsRoot.Name = "lblRepPicsRoot"
        Me.lblRepPicsRoot.Size = New System.Drawing.Size(126, 13)
        Me.lblRepPicsRoot.TabIndex = 1
        Me.lblRepPicsRoot.Text = "Rep Root photo directory"
        '
        'rdbtnSmallPic
        '
        Me.rdbtnSmallPic.AutoSize = True
        Me.rdbtnSmallPic.Location = New System.Drawing.Point(18, 98)
        Me.rdbtnSmallPic.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnSmallPic.Name = "rdbtnSmallPic"
        Me.rdbtnSmallPic.Size = New System.Drawing.Size(68, 17)
        Me.rdbtnSmallPic.TabIndex = 2
        Me.rdbtnSmallPic.TabStop = True
        Me.rdbtnSmallPic.Text = "Small Pic"
        Me.rdbtnSmallPic.UseVisualStyleBackColor = True
        '
        'rdbtnMediumPic
        '
        Me.rdbtnMediumPic.AutoSize = True
        Me.rdbtnMediumPic.Location = New System.Drawing.Point(18, 128)
        Me.rdbtnMediumPic.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnMediumPic.Name = "rdbtnMediumPic"
        Me.rdbtnMediumPic.Size = New System.Drawing.Size(80, 17)
        Me.rdbtnMediumPic.TabIndex = 3
        Me.rdbtnMediumPic.TabStop = True
        Me.rdbtnMediumPic.Text = "Medium Pic"
        Me.rdbtnMediumPic.UseVisualStyleBackColor = True
        '
        'rdbtnLargePic
        '
        Me.rdbtnLargePic.AutoSize = True
        Me.rdbtnLargePic.Location = New System.Drawing.Point(18, 154)
        Me.rdbtnLargePic.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnLargePic.Name = "rdbtnLargePic"
        Me.rdbtnLargePic.Size = New System.Drawing.Size(72, 17)
        Me.rdbtnLargePic.TabIndex = 4
        Me.rdbtnLargePic.TabStop = True
        Me.rdbtnLargePic.Text = "LargePics"
        Me.rdbtnLargePic.UseVisualStyleBackColor = True
        '
        'lblAndroidDrawableDirectory
        '
        Me.lblAndroidDrawableDirectory.AutoSize = True
        Me.lblAndroidDrawableDirectory.Location = New System.Drawing.Point(9, 56)
        Me.lblAndroidDrawableDirectory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAndroidDrawableDirectory.Name = "lblAndroidDrawableDirectory"
        Me.lblAndroidDrawableDirectory.Size = New System.Drawing.Size(157, 13)
        Me.lblAndroidDrawableDirectory.TabIndex = 5
        Me.lblAndroidDrawableDirectory.Text = "Android PIC Resource Directory"
        '
        'txtAndroidDirectory
        '
        Me.txtAndroidDirectory.Location = New System.Drawing.Point(170, 56)
        Me.txtAndroidDirectory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAndroidDirectory.Name = "txtAndroidDirectory"
        Me.txtAndroidDirectory.Size = New System.Drawing.Size(410, 20)
        Me.txtAndroidDirectory.TabIndex = 6
        Me.txtAndroidDirectory.Text = "D:\Source\AndroidStudioProjects\GRGR\app\src\main\assets"
        '
        'rdbtnAllPics
        '
        Me.rdbtnAllPics.AutoSize = True
        Me.rdbtnAllPics.Location = New System.Drawing.Point(18, 184)
        Me.rdbtnAllPics.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnAllPics.Name = "rdbtnAllPics"
        Me.rdbtnAllPics.Size = New System.Drawing.Size(87, 17)
        Me.rdbtnAllPics.TabIndex = 7
        Me.rdbtnAllPics.TabStop = True
        Me.rdbtnAllPics.Text = "**ALL PICS**"
        Me.rdbtnAllPics.UseVisualStyleBackColor = True
        '
        'btnStartDownload
        '
        Me.btnStartDownload.Location = New System.Drawing.Point(539, 111)
        Me.btnStartDownload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartDownload.Name = "btnStartDownload"
        Me.btnStartDownload.Size = New System.Drawing.Size(76, 39)
        Me.btnStartDownload.TabIndex = 8
        Me.btnStartDownload.Text = "Start Download"
        Me.btnStartDownload.UseVisualStyleBackColor = True
        '
        'lblAndroidStringDirectory
        '
        Me.lblAndroidStringDirectory.AutoSize = True
        Me.lblAndroidStringDirectory.Location = New System.Drawing.Point(16, 217)
        Me.lblAndroidStringDirectory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAndroidStringDirectory.Name = "lblAndroidStringDirectory"
        Me.lblAndroidStringDirectory.Size = New System.Drawing.Size(140, 13)
        Me.lblAndroidStringDirectory.TabIndex = 9
        Me.lblAndroidStringDirectory.Text = "Android Root string directory"
        '
        'txtAndroidRootStringDirectory
        '
        Me.txtAndroidRootStringDirectory.Location = New System.Drawing.Point(170, 217)
        Me.txtAndroidRootStringDirectory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAndroidRootStringDirectory.Name = "txtAndroidRootStringDirectory"
        Me.txtAndroidRootStringDirectory.Size = New System.Drawing.Size(343, 20)
        Me.txtAndroidRootStringDirectory.TabIndex = 10
        Me.txtAndroidRootStringDirectory.Text = "D:\Source\AndroidStudioProjects\GRGR4\app\src\main\res\values"
        '
        'ckDownloadPics
        '
        Me.ckDownloadPics.AutoSize = True
        Me.ckDownloadPics.Location = New System.Drawing.Point(437, 111)
        Me.ckDownloadPics.Margin = New System.Windows.Forms.Padding(2)
        Me.ckDownloadPics.Name = "ckDownloadPics"
        Me.ckDownloadPics.Size = New System.Drawing.Size(103, 17)
        Me.ckDownloadPics.TabIndex = 13
        Me.ckDownloadPics.Text = "Download Pics?"
        Me.ckDownloadPics.UseVisualStyleBackColor = True
        '
        'ckDownloadFile
        '
        Me.ckDownloadFile.AutoSize = True
        Me.ckDownloadFile.Location = New System.Drawing.Point(437, 133)
        Me.ckDownloadFile.Margin = New System.Windows.Forms.Padding(2)
        Me.ckDownloadFile.Name = "ckDownloadFile"
        Me.ckDownloadFile.Size = New System.Drawing.Size(99, 17)
        Me.ckDownloadFile.TabIndex = 14
        Me.ckDownloadFile.Text = "Download File?"
        Me.ckDownloadFile.UseVisualStyleBackColor = True
        '
        'DownloadRepInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 284)
        Me.Controls.Add(Me.ckDownloadFile)
        Me.Controls.Add(Me.ckDownloadPics)
        Me.Controls.Add(Me.txtAndroidRootStringDirectory)
        Me.Controls.Add(Me.lblAndroidStringDirectory)
        Me.Controls.Add(Me.btnStartDownload)
        Me.Controls.Add(Me.rdbtnAllPics)
        Me.Controls.Add(Me.txtAndroidDirectory)
        Me.Controls.Add(Me.lblAndroidDrawableDirectory)
        Me.Controls.Add(Me.rdbtnLargePic)
        Me.Controls.Add(Me.rdbtnMediumPic)
        Me.Controls.Add(Me.rdbtnSmallPic)
        Me.Controls.Add(Me.lblRepPicsRoot)
        Me.Controls.Add(Me.txtRepPhotoDirectory)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DownloadRepInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Representative Pics for Android"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRepPhotoDirectory As System.Windows.Forms.TextBox
    Friend WithEvents lblRepPicsRoot As System.Windows.Forms.Label
    Friend WithEvents rdbtnSmallPic As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnMediumPic As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnLargePic As System.Windows.Forms.RadioButton
    Friend WithEvents lblAndroidDrawableDirectory As System.Windows.Forms.Label
    Friend WithEvents txtAndroidDirectory As System.Windows.Forms.TextBox
    Friend WithEvents rdbtnAllPics As System.Windows.Forms.RadioButton
    Friend WithEvents btnStartDownload As System.Windows.Forms.Button
    Friend WithEvents lblAndroidStringDirectory As System.Windows.Forms.Label
    Friend WithEvents txtAndroidRootStringDirectory As System.Windows.Forms.TextBox
    Friend WithEvents ckDownloadPics As System.Windows.Forms.CheckBox
    Friend WithEvents ckDownloadFile As System.Windows.Forms.CheckBox

End Class
