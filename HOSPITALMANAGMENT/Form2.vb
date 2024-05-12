Imports System.Data.OleDb

Public Class Form2
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadRecord()
    End Sub
    Function loadRecord()

        da = New OleDbDataAdapter("Select * FROM tblPatients ", konek)
        ds = New DataSet
        da.Fill(ds, ("tblPatients"))
        dgvpatient.DataSource = ds.Tables("tblPatients").DefaultView
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        trans = "ADD"
        Patient.Text = "ADD RECORD"
        Patient.txtfirstName.Clear()
        Patient.txtid.Visible = True
        Patient.lbID.Visible = True
        Patient.ShowDialog()

    End Sub

    Private Sub dgvpatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpatient.CellContentClick

    End Sub
End Class
