Imports System.Data.SqlClient

Public Class MSDataSQLServer

    Public Shared Function DatabaseCheck(ByRef ConnectionString As String)
        Try
            Using connection As New SqlConnection(ConnectionString)
                If ConnectionState.Open Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As DataException
            Return ex.ToString
        End Try
    End Function

    Public Shared Function SUID_Check(ByRef SID As String, ByRef ConnectionString As String)
        Dim test As String

        Try
            Dim Connection As New SqlConnection(ConnectionString)
            Connection.Open()
            Dim TSQL As String = "SELECT * FROM tblSystemUser WHERE SUID = '" + SID + "';"
            Dim ConnectionCommand As New SqlCommand(TSQL, Connection)
            Dim SQLReader As SqlDataReader = ConnectionCommand.ExecuteReader()
            While SQLReader.Read()
                Return SQLReader("SUID").ToString()
            End While
            Connection.Close()
            Connection.Dispose()
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

End Class
