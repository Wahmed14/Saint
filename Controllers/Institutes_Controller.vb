
Public Class Institutes_Controller

    Public Shared Function getInstitutesGenerique(institutesList As List(Of Institutes)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Sigle", GetType(String))

        For Each institute As Institutes In institutesList
            table.LoadDataRow(New Object() {institute.Id, institute.Libelle, institute.Sigle}, True)
        Next

        Return table
    End Function


    Public Shared Function getAll() As DataTable
        Return getInstitutesGenerique(Institutes_Manager.getAll())
    End Function

    Public Shared Function searchInstitutes(word As String) As DataTable
        If word <> Nothing Then
            Return getInstitutesGenerique(Institutes_Manager.search(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verify(libelle As String, sigle As String) As Boolean
        If libelle = "" Then
            MessageBox.Show("le libelle n'est pas correct", "Libelle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf sigle = "" Then
            MessageBox.Show("le sigle n'est pas correct", "Sigle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function store(libelle As String, sigle As String) As Boolean
        If (verify(libelle, sigle)) Then
            Dim instituteDB As Institutes = Institutes_Manager.getByLibelle(libelle)
            If instituteDB.Libelle = Nothing Then
                Return Institutes_Manager.store(New Institutes(libelle, sigle))
            Else
                MessageBox.Show("le libelle est déjà pris", "Libelle déjà pris", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function

    Public Shared Function update(libelle As String, sigle As String, idInstitute As Integer) As Boolean
        If (verify(libelle, sigle)) Then
            Dim instituteDB As Institutes = Institutes_Manager.getByLibelle(libelle)
            If instituteDB.Libelle <> Nothing Then
                If instituteDB.Id <> idInstitute Then
                    MessageBox.Show("Le libelle est déjà pris", "Libelle déjà pris", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        Return Institutes_Manager.update(New Institutes(libelle, sigle), idInstitute)
    End Function

    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) insitut(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each id As Integer In idList
                If Institutes_Manager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class

