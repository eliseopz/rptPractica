Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHRDataSet.jobs' Puede moverla o quitarla según sea necesario.
        Me.JobsTableAdapter.Fill(Me.BdHRDataSet.jobs)
        'TODO: esta línea de código carga datos en la tabla 'BdHRDataSet.employees' Puede moverla o quitarla según sea necesario.
        Me.EmployeesTableAdapter.Fill(Me.BdHRDataSet.employees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
