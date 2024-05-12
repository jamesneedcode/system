Imports System.Data.OleDb
Imports System.Deployment.Application

Public Class Patient
    Dim utos As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim duplicateRec As String

    Private Sub brnCancel_Click(sender As Object, e As EventArgs) Handles brnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtlastname.Text <> "" And txtfirstName.Text <> "" And txtmiddlename.Text <> "" And gender.Text <> "" And txtaddress.Text <> "" And txtweight.Text <> "" And txtheight.Text <> "" And txtbloodpresure.Text <> "" And cbbloodtype.Text <> "" And txtsymptoms.Text <> "" And txtphonenumber.Text <> "" And txtnationality.Text <> "" Then


            checkDuplicate()
            If duplicateRec <> "yes" Then
                If trans = "ADD" Then
                    'put your add code here

                    utos = New OleDbCommand("INSERT INTO tblPatients VALUES(" & txtid.Text & ",'" & txtlastname.Text & "','" & txtfirstName.Text & "','" & txtmiddlename.Text & "','" & gender.Text & "','" & txtaddress.Text & "','" & dateselect.Value & "','" & txtage.Text & "','" & txtweight.Text & "','" & txtheight.Text & "','" & txtbloodpresure.Text & "','" & cbbloodtype.Text & "','" & txtsymptoms.Text & "','" & txtphonenumber.Text & "','" & txtnationality.Text & "','" & cbCIVIL.Text & "')", konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("New Record Saved!")
                Else
                    'put your edit code here

                    utos = New OleDbCommand("Update tblPatients SET Last_Name='" & txtlastname.Text & "',First_Name='" & txtfirstName.Text & "',Middle_Name='" & txtmiddlename.Text & "',Gender='" & gender.Text & "',Address='" & txtaddress.Text & "',Date_of_Birth='" & dateselect.Value & "',weight='" & txtweight.Text & "',Height='" & txtheight.Text & "',Blood_Presure='" & txtbloodpresure.Text & "',Blood_type='" & cbbloodtype.Text & "',Current_symptoms='" & txtsymptoms.Text & "',Phone_Number='" & txtphonenumber.Text & "',Nationality= '" & txtnationality.Text & "',Age= '" & txtage.Text & "',Civil_Status= '" & cbCIVIL.Text & "'Where Patient_ID=" & txtid.Text, konek)
                    utos.ExecuteNonQuery()
                    MessageBox.Show("New Record Saved!")



                End If
                Me.Close()
            Else
                MessageBox.Show("Cannot save duplicate record!")
            End If
        Else
            MessageBox.Show("Cannot save empty fields!")
        End If
    End Sub

    Function checkDuplicate()
        da = New OleDbDataAdapter("SELECT * FROM tblPatients WHERE Last_Name = '" & txtlastname.Text & "'", konek)
        ds = New DataSet
        da.Fill(ds, "tblPatients")
        If ds.Tables("tblPatients").Rows.Count >= 1 Then
            duplicateRec = "yes"
        Else
            duplicateRec = "no"
        End If
        Return True
    End Function
    Private Sub Patient_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        konnecksyon()
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class