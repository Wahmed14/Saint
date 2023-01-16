Public Class Admin_View
    Dim employees_Control As Employees_Control
    Dim institutes_Control As Institutes_Control
    Dim faculties_Control As Faculties_Control
    Dim ues_Control As UEs_Control
    Dim ecues_Control As ECUEs_Control
    Dim users_Control As Users_Control
    Private Sub Admin_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
        employees_Control = New Employees_Control
        institutes_Control = New Institutes_Control
        faculties_Control = New Faculties_Control
        ues_Control = New UEs_Control
        ecues_Control = New ECUEs_Control
        users_Control = New Users_Control

        employees_Control.Dock = DockStyle.Fill
        institutes_Control.Dock = DockStyle.Fill
        faculties_Control.Dock = DockStyle.Fill
        ues_Control.Dock = DockStyle.Fill
        ecues_Control.Dock = DockStyle.Fill
        users_Control.Dock = DockStyle.Fill

        P_ADMIN.Controls.Add(employees_Control)
        P_ADMIN.Controls.Add(institutes_Control)
        P_ADMIN.Controls.Add(faculties_Control)
        P_ADMIN.Controls.Add(ues_Control)
        P_ADMIN.Controls.Add(ecues_Control)
        P_ADMIN.Controls.Add(users_Control)

    End Sub

    Private Sub HideControls()
        employees_Control.Hide()
        institutes_Control.Hide()
        faculties_Control.Hide()
        ues_Control.Hide()
        ecues_Control.Hide()
        users_Control.Hide()

    End Sub

    Private Sub BT_EMPLOYEES_Click(sender As Object, e As EventArgs) Handles BT_EMPLOYEES.Click
        HideControls()
        employees_Control.Show()
    End Sub

    Private Sub BT_INSTITUTES_Click(sender As Object, e As EventArgs) Handles BT_INSTITUTES.Click
        HideControls()
        institutes_Control.Show()
    End Sub

    Private Sub BT_FACULTIES_Click(sender As Object, e As EventArgs) Handles BT_FACULTIES.Click
        HideControls()
        faculties_Control.Show()
    End Sub

    Private Sub BT_UES_Click(sender As Object, e As EventArgs) Handles BT_UES.Click
        HideControls()
        ues_Control.Show()
    End Sub

    Private Sub BT_ECUES_Click(sender As Object, e As EventArgs) Handles BT_ECUES.Click
        HideControls()
        ecues_Control.Show()
    End Sub

    Private Sub BT_USERS_Click(sender As Object, e As EventArgs) Handles BT_USERS.Click
        HideControls()
        users_Control.Show()
    End Sub


End Class