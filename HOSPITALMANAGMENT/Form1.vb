Public Class Form1
    Private Sub DOCTORRECORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOCTORRECORDToolStripMenuItem.Click
        currentdoctor.Show()
        Me.Hide()
    End Sub

    Private Sub NEWPATIENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWPATIENTToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub PATIENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PATIENTToolStripMenuItem1.Click
        frmpatientsrecords.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NEWDOCTORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWDOCTORToolStripMenuItem.Click
        doctorrecords.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub
End Class
