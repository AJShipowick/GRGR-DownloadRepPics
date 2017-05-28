Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text
Imports System.Net

''' <summary>
''' Use Expresso Regex tool for help with regex items below
''' </summary>
Public Class RepresentativeData

    Const currentMembersURL = "https://www.govtrack.us/api/v2/role?state="
    Const lastPartOfMembersURL = "&current=true"

    Public Sub DownloadRepPersonalInfo(androidRootDirectory As String)

        'todo sort data
        Dim knowStates As List(Of String) = KnownStates.BuildKnowStatesList()
        Dim repData = New List(Of String)

        Dim webClient As New System.Net.WebClient
        For Each state In knowStates
            Dim stateAbr As Array = state.Split(CType(",", Char()))
            Dim queryAPIURL As String = currentMembersURL + stateAbr(1) + lastPartOfMembersURL
            Dim result As String = webClient.DownloadString(queryAPIURL)
            Dim totalItemsToMatch = 0

            'Not expecting or accounting for a NULL value here ever
            Dim idList As New List(Of String)
            Dim idRegex = """id"":\s{1}\d{6}"
            Dim idMatch = Regex.Matches(result, idRegex)
            For Each item In idMatch
                item = item.ToString.Substring(6)
                idList.Add(item.ToString)
            Next
            totalItemsToMatch = idList.Count

            'Not expecting or accounting for a NULL value here ever
            Dim stateList As New List(Of String)
            Dim stateRegex = """state"":\s{1}\D{3}"
            Dim stateMatch = Regex.Matches(result, stateRegex)
            For Each item In stateMatch
                item = item.ToString.Substring(10)
                stateList.Add(item.ToString)
            Next
            If stateList.Count <> totalItemsToMatch Then
                MessageBox.Show("state Regex Failed")
            End If

            'Not expecting or accounting for a NULL value here ever
            Dim partyList As New List(Of String)
            Dim partyRegex = """party"":\s{1}""\D{1}" 'Will show R for Republican or D for Democrat
            Dim partyMatch = Regex.Matches(result, partyRegex)
            For Each item In partyMatch
                item = item.ToString.Substring(10)
                If item.ToString = "D" Then
                    item = "Democrat"
                ElseIf item.ToString = "R" Then
                    item = "Republican"
                End If
                partyList.Add(item.ToString)
            Next
            If partyList.Count <> totalItemsToMatch Then
                MessageBox.Show("party Regex Failed")
            End If

            'Not expecting or accounting for a NULL value here ever
            Dim titleList As New List(Of String)
            Dim titleRegex = """title"":\s{1}""\D{3}"
            Dim titleMatch = Regex.Matches(result, titleRegex)
            For Each item In titleMatch
                item = item.ToString.Substring(10)
                titleList.Add(item.ToString)
            Next
            If titleList.Count <> totalItemsToMatch Then
                MessageBox.Show("title Regex Failed")
            End If

            'Not expecting or accounting for a NULL value here ever
            Dim firstNameList As New List(Of String)
            Dim firstNameRegex = """firstname"":\s{1}"".*"
            Dim firstNameMatch = Regex.Matches(result, firstNameRegex)
            For Each item In firstNameMatch
                item = item.ToString.Substring(14).Replace(",", "").Replace("""", "").Trim

                SpecialCharacterTranslation.Translate(item)

                firstNameList.Add(item.ToString)
            Next
            If firstNameList.Count <> totalItemsToMatch Then
                MessageBox.Show("firstname Regex Failed")
            End If

            'Not expecting or accounting for a NULL value here ever
            Dim lastNameList As New List(Of String)
            Dim lastNameRegex = """lastname"":\s{1}"".*"
            Dim lastNameMatch = Regex.Matches(result, lastNameRegex)
            For Each item In lastNameMatch
                item = item.ToString.Substring(13).Replace(",", "").Replace("""", "").Trim

                SpecialCharacterTranslation.Translate(item)

                lastNameList.Add(item.ToString)
            Next
            If lastNameList.Count <> totalItemsToMatch Then
                MessageBox.Show("lastname Regex Failed")
            End If

            'Rep Contact Information:
            'Not expecting or accounting for a NULL value here ever
            Dim addressList As New List(Of String)
            Dim addressRegex = """address"":\s{1}.*"
            Dim addressMatch = Regex.Matches(result, addressRegex)

            For Each item In addressMatch
                Dim x = item.ToString.Substring(12)
                x = x.Substring(0, x.Length - 3)
                item = x
                addressList.Add(item.ToString)
            Next
            If addressList.Count <> totalItemsToMatch Then
                MessageBox.Show("address Regex Failed")
            End If

            'Not expecting or accounting for a NULL value here ever
            Dim phoneList As New List(Of String)
            Dim phoneRegex = """phone"":\s{1}""[0-9]{3}-[0-9]{3}-[0-9]{4}"
            Dim phoneMatch = Regex.Matches(result, phoneRegex)
            For Each item In phoneMatch
                item = item.ToString.Substring(10)
                phoneList.Add(item.ToString)
            Next
            If phoneList.Count <> totalItemsToMatch Then
                MessageBox.Show("phone Regex Failed")
            End If

            Dim websiteList As New List(Of String)
            Dim websiteRegex = """website"":\s{1}""\w*://.*"
            Dim websiteMatch = Regex.Matches(result, websiteRegex)
            For Each item In websiteMatch
                item = item.ToString.Substring(11).Replace(",", "").Replace("""", "").Trim
                If item.ToString = "null" Then
                    item = "null"
                End If

                websiteList.Add(item.ToString)
            Next
            If websiteList.Count <> totalItemsToMatch Then
                MessageBox.Show("website Regex Failed")
            End If

            Dim twitterList As New List(Of String)
            Dim twitterRegex = """twitterid"":\s{1}.*"
            Dim twitterMatch = Regex.Matches(result, twitterRegex)
            For Each item In twitterMatch
                item = item.ToString.Substring(13).Replace(",", "").Replace("""", "").Trim
                If item.ToString = "null" Then
                    twitterList.Add(item)
                Else
                    twitterList.Add("https://twitter.com/" + item.ToString)
                End If

            Next
            If twitterList.Count <> totalItemsToMatch Then
                MessageBox.Show("twitter Regex Failed")
            End If

            Dim youtubeList As New List(Of String)
            Dim youtubeRegex = """youtubeid"":\s{1}.*"
            Dim youtubeMatch = Regex.Matches(result, youtubeRegex)
            For Each item In youtubeMatch
                item = item.ToString.Substring(13).Replace(",", "").Replace("""", "").Trim
                If item.ToString = "null" Then
                    youtubeList.Add(item)
                Else
                    youtubeList.Add("https://www.youtube.com/user/" + item.ToString)
                End If

            Next
            If youtubeList.Count <> totalItemsToMatch Then
                MessageBox.Show("youtube Regex Failed")
            End If

            'todo - currently email is only a link to a form for the representatives....there is no good solution for a direct email address currently....
            Dim contactLinkList As New List(Of String)
            Dim contactLinkRegex = "(?m)(?<=(""address"":.*)\r?\n)^.*$"
            Dim contactLinkMatch = Regex.Matches(result, contactLinkRegex)
            For Each item In contactLinkMatch
                If item.ToString.Contains("contact_form") Then
                    Dim contact = item.ToString.Substring(21)
                    contact = contact.Substring(0, contact.Length - 3)

                    Try
                        Dim request = WebRequest.Create(contact)
                        Dim response = request.GetResponse
                        Dim myResponse = response.GetResponseStream
                    Catch ex As WebException
                        If ex.Status = WebExceptionStatus.ProtocolError Then '404, just putting "null" into this field for now as it is not know.
                            contact = "null"
                        End If
                    End Try

                    contactLinkList.Add(contact)
                Else
                    contactLinkList.Add("null")
                End If
            Next
            If contactLinkList.Count <> totalItemsToMatch Then
                MessageBox.Show("contactform Regex Failed")
            End If

            'todo add facebook page

            For i As Integer = 0 To totalItemsToMatch - 1
                Dim sb As New StringBuilder()

                sb.Append("id=" + idList(i))
                sb.Append(",state=" + stateList(i))
                sb.Append(",party=" + partyList(i))
                sb.Append(",title=" + titleList(i))
                sb.Append(",firstname=" + firstNameList(i))
                sb.Append(",lastname=" + lastNameList(i))
                sb.Append(",address=" + addressList(i))
                sb.Append(",phone=" + phoneList(i))
                sb.Append(",website=" + websiteList(i))
                sb.Append(",twitter=" + twitterList(i))
                sb.Append(",youtube=" + youtubeList(i))
                sb.Append(",contactEmail=" + contactLinkList(i))

                repData.Add(sb.ToString)
            Next
        Next

        Dim directory = androidRootDirectory
        Dim path = directory + " \repData.xml"

        If File.Exists(path) Then
            File.Delete(path)
        End If

        Dim fs As FileStream = File.Create(path)
        Using fs
            AddText(fs, "<?xml version=""1.0"" encoding=""utf-8""?>" + vbCrLf)
            AddText(fs, "<resources>" + vbCrLf)
            AddText(fs, "<string-array name=""RepData"">" + vbCrLf)
            For Each item In repData
                AddText(fs, "<item>" + item + "</item>" + vbCrLf)
            Next
            AddText(fs, "</string-array>" + vbCrLf)
            AddText(fs, "</resources>")
        End Using

    End Sub

    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub

End Class
