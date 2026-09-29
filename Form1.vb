
Imports System.Linq

Public Class Form1

    Private SelectedVolunteerID As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeDatabase()

        btnUpdate.Enabled = False

        ' Connect day filter events
        AddHandler chkFilterMonday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterTuesday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterWednesday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterThursday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterFriday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterSaturday.CheckedChanged, AddressOf DayFilter_CheckedChanged
        AddHandler chkFilterSunday.CheckedChanged, AddressOf DayFilter_CheckedChanged

        LoadCityFilter()
        LoadVolunteers()
        SetupCityAutoComplete()

    End Sub

    Private Sub LoadVolunteers()

        cmbVolunteers.Items.Clear()

        Dim volunteers = GetFilteredVolunteers()

        For Each volunteer In volunteers
            cmbVolunteers.Items.Add(
                volunteer.ID.ToString() & " - " & volunteer.Name)
        Next

        cmbVolunteers.SelectedIndex = -1

    End Sub

    Private Function GetFilteredVolunteers() As List(Of Volunteer)

        Dim volunteers = GetVolunteers()

        ' City filter
        If cmbCityFilter.SelectedIndex > 0 Then

            Dim selectedCity As String = cmbCityFilter.SelectedItem.ToString()

            volunteers = volunteers.Where(
                Function(v) v.City = selectedCity).ToList()

        End If

        ' Day filters
        If chkFilterMonday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Monday).ToList()
        End If

        If chkFilterTuesday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Tuesday).ToList()
        End If

        If chkFilterWednesday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Wednesday).ToList()
        End If

        If chkFilterThursday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Thursday).ToList()
        End If

        If chkFilterFriday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Friday).ToList()
        End If

        If chkFilterSaturday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Saturday).ToList()
        End If

        If chkFilterSunday.Checked Then
            volunteers = volunteers.Where(Function(v) v.Sunday).ToList()
        End If

        Return volunteers

    End Function

    Private Sub LoadCityFilter()

        cmbCityFilter.Items.Clear()
        cmbCityFilter.Items.Add("All Cities")

        Dim cities = GetVolunteers().
            Select(Function(v) v.City).
            Distinct().
            OrderBy(Function(city) city).
            ToList()

        For Each city In cities
            cmbCityFilter.Items.Add(city)
        Next

        cmbCityFilter.SelectedIndex = 0

    End Sub

    Private Sub ClearFields()

        txtName.Clear()
        txtCity.Clear()

        chkMonday.Checked = False
        chkTuesday.Checked = False
        chkWednesday.Checked = False
        chkThursday.Checked = False
        chkFriday.Checked = False
        chkSaturday.Checked = False
        chkSunday.Checked = False

        SelectedVolunteerID = -1
        btnUpdate.Enabled = False
        btnAdd.Enabled = True

    End Sub

    Private Function GetVolunteerFromFields() As Volunteer

        Return New Volunteer With {
            .Name = txtName.Text.Trim(),
            .City = txtCity.Text.Trim(),
            .Monday = chkMonday.Checked,
            .Tuesday = chkTuesday.Checked,
            .Wednesday = chkWednesday.Checked,
            .Thursday = chkThursday.Checked,
            .Friday = chkFriday.Checked,
            .Saturday = chkSaturday.Checked,
            .Sunday = chkSunday.Checked
        }

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCity.Text) Then

            MessageBox.Show("Please enter the name and city.")

            Return

        End If

        AddVolunteer(GetVolunteerFromFields())

        MessageBox.Show("Volunteer added successfully.")

        ClearFields()
        LoadCityFilter()
        LoadVolunteers()
        SetupCityAutoComplete()

    End Sub

    Private Sub SetupCityAutoComplete()

        Dim cities As New AutoCompleteStringCollection()

        Dim volunteers = GetVolunteers()

        For Each city In volunteers.
        Select(Function(v) v.City).
        Where(Function(c) Not String.IsNullOrWhiteSpace(c)).
        Distinct().
        OrderBy(Function(c) c)

            cities.Add(city)

        Next

        txtCity.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCity.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCity.AutoCompleteCustomSource = cities

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If cmbVolunteers.SelectedIndex = -1 Then

            MessageBox.Show("Please select a volunteer.")

            Return

        End If

        Dim selectedText As String = cmbVolunteers.SelectedItem.ToString()
        Dim id As Integer = Integer.Parse(selectedText.Split("-"c)(0).Trim())

        Dim volunteer = GetVolunteers().
            FirstOrDefault(Function(v) v.ID = id)

        If volunteer Is Nothing Then Return

        SelectedVolunteerID = volunteer.ID

        txtName.Text = volunteer.Name
        txtCity.Text = volunteer.City

        chkMonday.Checked = volunteer.Monday
        chkTuesday.Checked = volunteer.Tuesday
        chkWednesday.Checked = volunteer.Wednesday
        chkThursday.Checked = volunteer.Thursday
        chkFriday.Checked = volunteer.Friday
        chkSaturday.Checked = volunteer.Saturday
        chkSunday.Checked = volunteer.Sunday

        btnUpdate.Enabled = True
        btnAdd.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If SelectedVolunteerID = -1 Then

            MessageBox.Show("Please select a volunteer and click Edit first.")

            Return

        End If

        Dim volunteer = GetVolunteerFromFields()
        volunteer.ID = SelectedVolunteerID

        UpdateVolunteer(volunteer)

        MessageBox.Show("Volunteer updated successfully.")

        ClearFields()
        LoadCityFilter()
        LoadVolunteers()
        SetupCityAutoComplete()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If cmbVolunteers.SelectedIndex = -1 Then

            MessageBox.Show("Please select a volunteer.")

            Return

        End If

        Dim selectedText As String = cmbVolunteers.SelectedItem.ToString()
        Dim id As Integer = Integer.Parse(selectedText.Split("-"c)(0).Trim())

        Dim result = MessageBox.Show(
            "Are you sure you want to delete this volunteer?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.No Then Return

        DeleteVolunteer(id)

        MessageBox.Show("Volunteer deleted successfully.")

        ClearFields()
        LoadCityFilter()
        LoadVolunteers()
        SetupCityAutoComplete()

    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click

        If RetrieveDeletedVolunteer() Then

            MessageBox.Show("Recently deleted volunteer restored.")

            LoadCityFilter()
            LoadVolunteers()
            SetupCityAutoComplete()

        Else

            MessageBox.Show("No recently deleted volunteer to retrieve.")

        End If

    End Sub

    Private Sub btnGoToDatabase_Click(
        sender As Object, e As EventArgs) Handles btnGoToDatabase.Click

        OpenDatabase()

    End Sub

    Private Sub cmbCityFilter_SelectedIndexChanged(
        sender As Object, e As EventArgs) Handles cmbCityFilter.SelectedIndexChanged

        LoadVolunteers()

    End Sub

    Private Sub DayFilter_CheckedChanged(sender As Object, e As EventArgs)

        LoadVolunteers()

    End Sub

End Class