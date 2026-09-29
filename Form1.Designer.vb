<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.chkMonday = New System.Windows.Forms.CheckBox()
        Me.chkTuesday = New System.Windows.Forms.CheckBox()
        Me.chkWednesday = New System.Windows.Forms.CheckBox()
        Me.chkThursday = New System.Windows.Forms.CheckBox()
        Me.chkFriday = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkSunday = New System.Windows.Forms.CheckBox()
        Me.cmbVolunteers = New System.Windows.Forms.ComboBox()
        Me.cmbCityFilter = New System.Windows.Forms.ComboBox()
        Me.chkFilterSunday = New System.Windows.Forms.CheckBox()
        Me.chkFilterSaturday = New System.Windows.Forms.CheckBox()
        Me.chkFilterFriday = New System.Windows.Forms.CheckBox()
        Me.chkFilterThursday = New System.Windows.Forms.CheckBox()
        Me.chkFilterWednesday = New System.Windows.Forms.CheckBox()
        Me.chkFilterTuesday = New System.Windows.Forms.CheckBox()
        Me.chkFilterMonday = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnGoToDatabase = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(156, 20)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(70, 63)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(156, 20)
        Me.txtCity.TabIndex = 3
        '
        'chkMonday
        '
        Me.chkMonday.AutoSize = True
        Me.chkMonday.Location = New System.Drawing.Point(11, 119)
        Me.chkMonday.Name = "chkMonday"
        Me.chkMonday.Size = New System.Drawing.Size(64, 17)
        Me.chkMonday.TabIndex = 4
        Me.chkMonday.Text = "Monday"
        Me.chkMonday.UseVisualStyleBackColor = True
        '
        'chkTuesday
        '
        Me.chkTuesday.AutoSize = True
        Me.chkTuesday.Location = New System.Drawing.Point(11, 142)
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Size = New System.Drawing.Size(67, 17)
        Me.chkTuesday.TabIndex = 5
        Me.chkTuesday.Text = "Tuesday"
        Me.chkTuesday.UseVisualStyleBackColor = True
        '
        'chkWednesday
        '
        Me.chkWednesday.AutoSize = True
        Me.chkWednesday.Location = New System.Drawing.Point(11, 165)
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Size = New System.Drawing.Size(83, 17)
        Me.chkWednesday.TabIndex = 6
        Me.chkWednesday.Text = "Wednesday"
        Me.chkWednesday.UseVisualStyleBackColor = True
        '
        'chkThursday
        '
        Me.chkThursday.AutoSize = True
        Me.chkThursday.Location = New System.Drawing.Point(11, 188)
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Size = New System.Drawing.Size(70, 17)
        Me.chkThursday.TabIndex = 7
        Me.chkThursday.Text = "Thursday"
        Me.chkThursday.UseVisualStyleBackColor = True
        '
        'chkFriday
        '
        Me.chkFriday.AutoSize = True
        Me.chkFriday.Location = New System.Drawing.Point(11, 211)
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Size = New System.Drawing.Size(54, 17)
        Me.chkFriday.TabIndex = 8
        Me.chkFriday.Text = "Friday"
        Me.chkFriday.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(12, 234)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(68, 17)
        Me.chkSaturday.TabIndex = 9
        Me.chkSaturday.Text = "Saturday"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkSunday
        '
        Me.chkSunday.AutoSize = True
        Me.chkSunday.Location = New System.Drawing.Point(11, 257)
        Me.chkSunday.Name = "chkSunday"
        Me.chkSunday.Size = New System.Drawing.Size(62, 17)
        Me.chkSunday.TabIndex = 10
        Me.chkSunday.Text = "Sunday"
        Me.chkSunday.UseVisualStyleBackColor = True
        '
        'cmbVolunteers
        '
        Me.cmbVolunteers.FormattingEnabled = True
        Me.cmbVolunteers.Location = New System.Drawing.Point(267, 29)
        Me.cmbVolunteers.Name = "cmbVolunteers"
        Me.cmbVolunteers.Size = New System.Drawing.Size(119, 21)
        Me.cmbVolunteers.TabIndex = 11
        '
        'cmbCityFilter
        '
        Me.cmbCityFilter.FormattingEnabled = True
        Me.cmbCityFilter.Location = New System.Drawing.Point(407, 27)
        Me.cmbCityFilter.Name = "cmbCityFilter"
        Me.cmbCityFilter.Size = New System.Drawing.Size(119, 21)
        Me.cmbCityFilter.TabIndex = 12
        '
        'chkFilterSunday
        '
        Me.chkFilterSunday.AutoSize = True
        Me.chkFilterSunday.Location = New System.Drawing.Point(555, 165)
        Me.chkFilterSunday.Name = "chkFilterSunday"
        Me.chkFilterSunday.Size = New System.Drawing.Size(62, 17)
        Me.chkFilterSunday.TabIndex = 19
        Me.chkFilterSunday.Text = "Sunday"
        Me.chkFilterSunday.UseVisualStyleBackColor = True
        '
        'chkFilterSaturday
        '
        Me.chkFilterSaturday.AutoSize = True
        Me.chkFilterSaturday.Location = New System.Drawing.Point(556, 142)
        Me.chkFilterSaturday.Name = "chkFilterSaturday"
        Me.chkFilterSaturday.Size = New System.Drawing.Size(68, 17)
        Me.chkFilterSaturday.TabIndex = 18
        Me.chkFilterSaturday.Text = "Saturday"
        Me.chkFilterSaturday.UseVisualStyleBackColor = True
        '
        'chkFilterFriday
        '
        Me.chkFilterFriday.AutoSize = True
        Me.chkFilterFriday.Location = New System.Drawing.Point(555, 119)
        Me.chkFilterFriday.Name = "chkFilterFriday"
        Me.chkFilterFriday.Size = New System.Drawing.Size(54, 17)
        Me.chkFilterFriday.TabIndex = 17
        Me.chkFilterFriday.Text = "Friday"
        Me.chkFilterFriday.UseVisualStyleBackColor = True
        '
        'chkFilterThursday
        '
        Me.chkFilterThursday.AutoSize = True
        Me.chkFilterThursday.Location = New System.Drawing.Point(555, 96)
        Me.chkFilterThursday.Name = "chkFilterThursday"
        Me.chkFilterThursday.Size = New System.Drawing.Size(70, 17)
        Me.chkFilterThursday.TabIndex = 16
        Me.chkFilterThursday.Text = "Thursday"
        Me.chkFilterThursday.UseVisualStyleBackColor = True
        '
        'chkFilterWednesday
        '
        Me.chkFilterWednesday.AutoSize = True
        Me.chkFilterWednesday.Location = New System.Drawing.Point(555, 73)
        Me.chkFilterWednesday.Name = "chkFilterWednesday"
        Me.chkFilterWednesday.Size = New System.Drawing.Size(83, 17)
        Me.chkFilterWednesday.TabIndex = 15
        Me.chkFilterWednesday.Text = "Wednesday"
        Me.chkFilterWednesday.UseVisualStyleBackColor = True
        '
        'chkFilterTuesday
        '
        Me.chkFilterTuesday.AutoSize = True
        Me.chkFilterTuesday.Location = New System.Drawing.Point(555, 50)
        Me.chkFilterTuesday.Name = "chkFilterTuesday"
        Me.chkFilterTuesday.Size = New System.Drawing.Size(67, 17)
        Me.chkFilterTuesday.TabIndex = 14
        Me.chkFilterTuesday.Text = "Tuesday"
        Me.chkFilterTuesday.UseVisualStyleBackColor = True
        '
        'chkFilterMonday
        '
        Me.chkFilterMonday.AutoSize = True
        Me.chkFilterMonday.Location = New System.Drawing.Point(555, 27)
        Me.chkFilterMonday.Name = "chkFilterMonday"
        Me.chkFilterMonday.Size = New System.Drawing.Size(64, 17)
        Me.chkFilterMonday.TabIndex = 13
        Me.chkFilterMonday.Text = "Monday"
        Me.chkFilterMonday.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 327)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnGoToDatabase
        '
        Me.btnGoToDatabase.Location = New System.Drawing.Point(102, 327)
        Me.btnGoToDatabase.Name = "btnGoToDatabase"
        Me.btnGoToDatabase.Size = New System.Drawing.Size(105, 23)
        Me.btnGoToDatabase.TabIndex = 21
        Me.btnGoToDatabase.Text = "Go To Database"
        Me.btnGoToDatabase.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(678, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(678, 44)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 23)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(678, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 23)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(678, 102)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(60, 23)
        Me.btnRetrieve.TabIndex = 25
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnGoToDatabase)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkFilterSunday)
        Me.Controls.Add(Me.chkFilterSaturday)
        Me.Controls.Add(Me.chkFilterFriday)
        Me.Controls.Add(Me.chkFilterThursday)
        Me.Controls.Add(Me.chkFilterWednesday)
        Me.Controls.Add(Me.chkFilterTuesday)
        Me.Controls.Add(Me.chkFilterMonday)
        Me.Controls.Add(Me.cmbCityFilter)
        Me.Controls.Add(Me.cmbVolunteers)
        Me.Controls.Add(Me.chkSunday)
        Me.Controls.Add(Me.chkSaturday)
        Me.Controls.Add(Me.chkFriday)
        Me.Controls.Add(Me.chkThursday)
        Me.Controls.Add(Me.chkWednesday)
        Me.Controls.Add(Me.chkTuesday)
        Me.Controls.Add(Me.chkMonday)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents chkMonday As CheckBox
    Friend WithEvents chkTuesday As CheckBox
    Friend WithEvents chkWednesday As CheckBox
    Friend WithEvents chkThursday As CheckBox
    Friend WithEvents chkFriday As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkSunday As CheckBox
    Friend WithEvents cmbVolunteers As ComboBox
    Friend WithEvents cmbCityFilter As ComboBox
    Friend WithEvents chkFilterSunday As CheckBox
    Friend WithEvents chkFilterSaturday As CheckBox
    Friend WithEvents chkFilterFriday As CheckBox
    Friend WithEvents chkFilterThursday As CheckBox
    Friend WithEvents chkFilterWednesday As CheckBox
    Friend WithEvents chkFilterTuesday As CheckBox
    Friend WithEvents chkFilterMonday As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnGoToDatabase As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRetrieve As Button
End Class
