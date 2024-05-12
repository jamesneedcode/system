Imports System.Data.OleDb

Public Class doctorrecords
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub doctorrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Private Sub doctorrecords_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        trans = "ADD"
        Doctor.Text = "ADD RECORD"
        Doctor.txtfirstName.Clear()
        Doctor.ShowDialog()
    End Sub

End Class
