Imports System.Net
Imports System.Text.RegularExpressions

Public Class RepresentativePictures

    Public picWebsiteStartingURL As String = "https://www.govtrack.us/data/photos/"
    Const regexIDOnlyQuery = """id"":\s{1}\d{6}"

    Public Sub New()
    End Sub

    Public Sub DownloadRepPics(picWebsiteURL As String, androidOutputDirectory As String, smallPic As Boolean, mediumPic As Boolean, largePic As Boolean)
        picWebsiteStartingURL = picWebsiteURL 'First part of url
        Dim picSizeURL = GetPicSizeURL(smallPic, mediumPic, largePic) 'Last part of url
        If String.IsNullOrEmpty(picSizeURL) Then Return

        Dim androidDirectory = androidOutputDirectory + "\"
        Dim Client As New WebClient
        Dim badUrlsCount As Integer

        Dim listOfCurrentMemberOfCongress As List(Of String) = QueryGovAPIForCurrentMembers(regexIDOnlyQuery)

        For i As Integer = 0 To listOfCurrentMemberOfCongress.Count - 1
            Try

                Dim downloadURI As String = picWebsiteStartingURL + listOfCurrentMemberOfCongress(i) + picSizeURL
                Client.DownloadFile(downloadURI, androidDirectory + "repid" + listOfCurrentMemberOfCongress(i) + ".jpg")

            Catch ex As Exception
                'badUrls.Add(downloadURI)
                badUrlsCount += 1
            End Try
        Next

        MessageBox.Show("The number of bad urls = " + badUrlsCount.ToString)
    End Sub

    Const smallPicEndingURL = "-50px.jpg"
    Const mediumPicEndingURL = "-100px.jpg"
    Const largePicEndingURL = "-200px.jpg"
    Private Function GetPicSizeURL(smallPic As Boolean, mediumPic As Boolean, largePic As Boolean) As String
        Dim url = ""

        If smallPic Then
            url = smallPicEndingURL
        ElseIf mediumPic Then
            url = mediumPicEndingURL
        ElseIf largePic Then
            url = largePicEndingURL
        Else
            MessageBox.Show("You must select a picture size")
            Return ""
        End If

        Return url
    End Function

    Const currentMembersURL = "https://www.govtrack.us/api/v2/role?state="
    Const lastPartOfMembersURL = "&current=true"

    'look at each state's reps and get their id and add it to the list to lookup their picture with.
    Private Function QueryGovAPIForCurrentMembers(regexExpression As String) As List(Of String)

        Dim knowStates As List(Of String) = BuildKnowStatesList()
        Dim currentReps = New List(Of String)

        Dim webClient As New System.Net.WebClient
        For Each state In knowStates
            Dim stateAbr As Array = state.Split(CType(",", Char()))
            Dim queryAPIURL As String = currentMembersURL + stateAbr(1) + lastPartOfMembersURL
            Dim result As String = webClient.DownloadString(queryAPIURL)

            Dim match As MatchCollection = Regex.Matches(result, regexExpression)

            For Each m In match
                Dim currentMatch = m.ToString
                Dim repsToAdd = currentMatch.Substring(6)
                currentReps.Add(repsToAdd)
            Next

        Next

        Return currentReps
    End Function

End Class
