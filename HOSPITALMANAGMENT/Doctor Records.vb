Imports System.Data.OleDb

Public Class currentdoctor
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub currentdoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub currentdoctor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadRecord()
    End Sub
    Function loadRecord()

        da = New OleDbDataAdapter("Select * FROM tblDoctor ", konek)
        ds = New DataSet
        da.Fill(ds, ("tblDoctor"))
        dgvdoctor.DataSource = ds.Tables("tblDoctor").DefaultView
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub txtidshow_TextChanged(sender As Object, e As EventArgs) Handles txtidshow.TextChanged

    End Sub

    Private Sub dgvdoctor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdoctor.CellContentClick

    End Sub

    Private Sub dgvdoctor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdoctor.CellClick
        If e.RowIndex <> -1 Then
            txtidshow.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(0).ToString
            Doctor.txtid.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(0).ToString

            Doctor.txtlastname.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(1).ToString
            Doctor.txtfirstName.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(2).ToString
            Doctor.txtmiddlename.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(3).ToString
            Doctor.dateselect.Value = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(4).ToString
            Doctor.gender.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(5).ToString
            Doctor.txtaddress.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(6).ToString
            Doctor.txtphonenumber.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(7).ToString
            Doctor.txtnationality.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(8).ToString
            Doctor.cbSpecialty.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(9).ToString
            Doctor.cbquali.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(10).ToString
            Doctor.txtexp.Text = ds.Tables("tblDoctor").Rows(e.RowIndex).Item(11).ToString

        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
       Doctor.txtid.Visible = False
        Doctor.lbID.Visible = False
        If txtidshow.Text <> "" Then

            Doctor.ShowDialog()
        Else
            MessageBox.Show("Please Select Record to Edit!")
        End If
    End Sub
End Class
