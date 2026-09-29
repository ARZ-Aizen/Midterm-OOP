
Imports System.IO
Imports System.Linq
Imports ClosedXML.Excel

Module VolunteerDatabase

    Public ReadOnly DatabasePath As String =
        Path.Combine(Application.StartupPath, "VolunteerDatabase.xlsx")

    Public Class Volunteer
        Public Property ID As Integer
        Public Property Name As String
        Public Property City As String
        Public Property Monday As Boolean
        Public Property Tuesday As Boolean
        Public Property Wednesday As Boolean
        Public Property Thursday As Boolean
        Public Property Friday As Boolean
        Public Property Saturday As Boolean
        Public Property Sunday As Boolean
    End Class

    Private DeletedVolunteer As Volunteer = Nothing

    Public Sub InitializeDatabase()

        If Not File.Exists(DatabasePath) Then

            Using workbook As New XLWorkbook()

                Dim sheet = workbook.Worksheets.Add("Volunteers")

                Dim headers() As String = {
                    "ID", "Name", "City",
                    "Monday", "Tuesday", "Wednesday",
                    "Thursday", "Friday", "Saturday", "Sunday"
                }

                For i As Integer = 0 To headers.Length - 1
                    sheet.Cell(1, i + 1).Value = headers(i)
                Next

                sheet.Row(1).Style.Font.Bold = True
                sheet.Columns().AdjustToContents()

                workbook.SaveAs(DatabasePath)

            End Using

        End If

    End Sub

    Public Function GetVolunteers() As List(Of Volunteer)

        InitializeDatabase()

        Dim volunteers As New List(Of Volunteer)

        Using workbook As New XLWorkbook(DatabasePath)

            Dim sheet = workbook.Worksheet("Volunteers")
            Dim lastRow As Integer = sheet.LastRowUsed().RowNumber()

            For row As Integer = 2 To lastRow

                If String.IsNullOrWhiteSpace(
                    sheet.Cell(row, 1).GetString()) Then Continue For

                Dim volunteer As New Volunteer With {
                    .ID = sheet.Cell(row, 1).GetValue(Of Integer)(),
                    .Name = sheet.Cell(row, 2).GetString(),
                    .City = sheet.Cell(row, 3).GetString(),
                    .Monday = sheet.Cell(row, 4).GetString() = "Yes",
                    .Tuesday = sheet.Cell(row, 5).GetString() = "Yes",
                    .Wednesday = sheet.Cell(row, 6).GetString() = "Yes",
                    .Thursday = sheet.Cell(row, 7).GetString() = "Yes",
                    .Friday = sheet.Cell(row, 8).GetString() = "Yes",
                    .Saturday = sheet.Cell(row, 9).GetString() = "Yes",
                    .Sunday = sheet.Cell(row, 10).GetString() = "Yes"
                }

                volunteers.Add(volunteer)

            Next

        End Using

        Return volunteers

    End Function

    Public Sub AddVolunteer(volunteer As Volunteer)

        InitializeDatabase()

        Using workbook As New XLWorkbook(DatabasePath)

            Dim sheet = workbook.Worksheet("Volunteers")
            Dim lastRow As Integer = sheet.LastRowUsed().RowNumber()

            Dim nextID As Integer = 1

            If lastRow > 1 Then

                Dim ids As New List(Of Integer)

                For row As Integer = 2 To lastRow

                    Dim idText As String = sheet.Cell(row, 1).GetString()

                    Dim id As Integer

                    If Integer.TryParse(idText, id) Then
                        ids.Add(id)
                    End If

                Next

                If ids.Count > 0 Then
                    nextID = ids.Max() + 1
                End If

            End If

            Dim newRow As Integer = lastRow + 1

            sheet.Cell(newRow, 1).Value = nextID
            sheet.Cell(newRow, 2).Value = volunteer.Name
            sheet.Cell(newRow, 3).Value = volunteer.City

            sheet.Cell(newRow, 4).Value = If(volunteer.Monday, "Yes", "No")
            sheet.Cell(newRow, 5).Value = If(volunteer.Tuesday, "Yes", "No")
            sheet.Cell(newRow, 6).Value = If(volunteer.Wednesday, "Yes", "No")
            sheet.Cell(newRow, 7).Value = If(volunteer.Thursday, "Yes", "No")
            sheet.Cell(newRow, 8).Value = If(volunteer.Friday, "Yes", "No")
            sheet.Cell(newRow, 9).Value = If(volunteer.Saturday, "Yes", "No")
            sheet.Cell(newRow, 10).Value = If(volunteer.Sunday, "Yes", "No")

            workbook.Save()

        End Using

    End Sub

    Public Sub UpdateVolunteer(volunteer As Volunteer)

        InitializeDatabase()

        Using workbook As New XLWorkbook(DatabasePath)

            Dim sheet = workbook.Worksheet("Volunteers")
            Dim lastRow As Integer = sheet.LastRowUsed().RowNumber()

            For row As Integer = 2 To lastRow

                If sheet.Cell(row, 1).GetValue(Of Integer)() = volunteer.ID Then

                    sheet.Cell(row, 2).Value = volunteer.Name
                    sheet.Cell(row, 3).Value = volunteer.City

                    sheet.Cell(row, 4).Value = If(volunteer.Monday, "Yes", "No")
                    sheet.Cell(row, 5).Value = If(volunteer.Tuesday, "Yes", "No")
                    sheet.Cell(row, 6).Value = If(volunteer.Wednesday, "Yes", "No")
                    sheet.Cell(row, 7).Value = If(volunteer.Thursday, "Yes", "No")
                    sheet.Cell(row, 8).Value = If(volunteer.Friday, "Yes", "No")
                    sheet.Cell(row, 9).Value = If(volunteer.Saturday, "Yes", "No")
                    sheet.Cell(row, 10).Value = If(volunteer.Sunday, "Yes", "No")

                    Exit For

                End If

            Next

            workbook.Save()

        End Using

    End Sub

    Public Sub DeleteVolunteer(id As Integer)

        InitializeDatabase()

        Using workbook As New XLWorkbook(DatabasePath)

            Dim sheet = workbook.Worksheet("Volunteers")
            Dim lastRow As Integer = sheet.LastRowUsed().RowNumber()

            For row As Integer = 2 To lastRow

                If sheet.Cell(row, 1).GetValue(Of Integer)() = id Then

                    DeletedVolunteer = New Volunteer With {
                        .ID = id,
                        .Name = sheet.Cell(row, 2).GetString(),
                        .City = sheet.Cell(row, 3).GetString(),
                        .Monday = sheet.Cell(row, 4).GetString() = "Yes",
                        .Tuesday = sheet.Cell(row, 5).GetString() = "Yes",
                        .Wednesday = sheet.Cell(row, 6).GetString() = "Yes",
                        .Thursday = sheet.Cell(row, 7).GetString() = "Yes",
                        .Friday = sheet.Cell(row, 8).GetString() = "Yes",
                        .Saturday = sheet.Cell(row, 9).GetString() = "Yes",
                        .Sunday = sheet.Cell(row, 10).GetString() = "Yes"
                    }

                    sheet.Row(row).Delete()
                    Exit For

                End If

            Next

            workbook.Save()

        End Using

    End Sub

    Public Function RetrieveDeletedVolunteer() As Boolean

        If DeletedVolunteer Is Nothing Then
            Return False
        End If

        Dim restored As Volunteer = DeletedVolunteer

        AddVolunteer(restored)

        DeletedVolunteer = Nothing

        Return True

    End Function

    Public Sub OpenDatabase()

        InitializeDatabase()

        Process.Start(New ProcessStartInfo With {
            .FileName = DatabasePath,
            .UseShellExecute = True
        })

    End Sub

End Module