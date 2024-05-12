Imports System.Data.OleDb

Public Class frmpatientsrecords
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmpatientsrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub frmpatientsrecords_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadRecord()

    End Sub
    Function loadRecord()

        da = New OleDbDataAdapter("Select * FROM tblPatients ", konek)
        ds = New DataSet
        da.Fill(ds, ("tblPatients"))
        dgvpatientrec.DataSource = ds.Tables("tblPatients").DefaultView
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub dgvpatientrec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpatientrec.CellContentClick

    End Sub

    Private Sub dgvpatientrec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpatientrec.CellClick
        If e.RowIndex <> -1 Then
            txtidshow.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(0).ToString

            Patient.txtid.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(0).ToString
            Patient.txtlastname.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(1).ToString
            Patient.txtfirstName.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(2).ToString
            Patient.txtmiddlename.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(3).ToString
            Patient.gender.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(4).ToString
            Patient.txtaddress.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(5).ToString
            Patient.dateselect.Value = ds.Tables("tblPatients").Rows(e.RowIndex).Item(6).ToString
            Patient.txtweight.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(7).ToString
            Patient.txtheight.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(8).ToString
            Patient.txtbloodpresure.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(9).ToString
            Patient.cbbloodtype.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(10).ToString
            Patient.txtsymptoms.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(11).ToString
            Patient.txtphonenumber.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(12).ToString
            Patient.txtnationality.Text = ds.Tables("tblPatients").Rows(e.RowIndex).Item(13).ToString


        End If
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Patient.txtid.Visible = False
        Patient.lbID.Visible = False
        If txtidshow.Text <> "" Then

            Patient.ShowDialog()

        Else
            MessageBox.Show("Please Select Record to Edit!")
        End If
    End Sub


End Class