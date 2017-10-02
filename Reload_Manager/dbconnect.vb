Public Class dbconnect

    Public objcon As New SqlClient.SqlConnection("Integrated Security=True; Data Source=.\SQLEXPRESS; initial catalog=RMDB;")

    Sub Open()
        'objcon.ConnectionString = "Integrated Security=True; Data Source=.\SQLEXPRESS; initial catalog=RMDB;"
        objcon.Open()
    End Sub

    Sub Close()
        objcon.Close()
    End Sub

End Class
