Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text

Public Class DownloadRepInfo

    'todo, add to calendar or somewhere a remider to donwload new data every 2 years.
    'House of reps = November 8, 2016 (2 year cycle)
    'Senate Elections = November 8, 2016 (6 year cycle)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnStartDownload_Click(sender As Object, e As EventArgs) Handles btnStartDownload.Click

        If Not ckDownloadFile.Checked AndAlso Not ckDownloadPics.Checked Then
            MessageBox.Show("You must select to download pics or files?  Are you feeling well?")
            Return
        End If

        Dim msgBoxQuestion As DialogResult = MessageBox.Show("Download all these items?  there are a lot out there :)", "Deep thoughts", MessageBoxButtons.YesNo)
        If msgBoxQuestion = Windows.Forms.DialogResult.No Then Return

        DownloadUserOptions()

    End Sub

    Private Sub DownloadUserOptions()

        If ckDownloadPics.Checked Then

            Dim repPics = New RepresentativePictures()
            repPics.DownloadRepPics(txtRepPhotoDirectory.Text, txtAndroidDirectory.Text, rdbtnSmallPic.Checked, rdbtnMediumPic.Checked, rdbtnLargePic.Checked)

        ElseIf ckDownloadFile.Checked Then

            Dim repInfo = New RepresentativeData
            repInfo.DownloadRepPersonalInfo(txtAndroidRootStringDirectory.Text)

        End If
    End Sub

End Class
