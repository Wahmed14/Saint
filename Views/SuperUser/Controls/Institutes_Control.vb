Public Class Institutes_Control
    Private Sub InstitutesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GV_INSTITUTES.DataSource = Institutes_Controller.getAll()
    End Sub

    Private Sub ClearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If Institutes_Controller.store(TB_LIBELLE.Text, TB_SIGLE.Text) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs)
        GV_INSTITUTES.DataSource = Institutes_Controller.getAll()
    End Sub

    Private Sub GV_INSITUTES_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        TB_LIBELLE.Text = GV_INSTITUTES.SelectedRows(0).Cells(1).Value
        TB_SIGLE.Text = GV_INSTITUTES.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs)
        GV_INSTITUTES.DataSource = Institutes_Controller.searchInstitutes(TB_SEARCH.Text)
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs)
        Dim nbRowSelected = GV_INSTITUTES.SelectedRows.Count
        If (nbRowSelected > 0) Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = GV_INSTITUTES.SelectedRows(0)
                Dim institutId As Integer = selectedRow.Cells(0).Value
                If Institutes_Controller.update(TB_LIBELLE.Text, TB_SIGLE.Text, institutId) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez mettre à jour qu'un seul élément à la fois", "Mise à jour multiple", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne sélectionnée", "Aucune ligne sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim institutesIdList As New List(Of Integer)()
        If GV_INSTITUTES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In GV_INSTITUTES.SelectedRows
                institutesIdList.Add(selectedRow.Cells(0).Value)
            Next
            If Institutes_Controller.delete(institutesIdList) Then
                ClearForm()
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne sélectionnée", "Aucune ligne sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class


