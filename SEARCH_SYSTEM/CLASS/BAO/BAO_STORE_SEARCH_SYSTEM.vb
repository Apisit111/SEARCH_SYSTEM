Imports System.Data.SqlClient

Namespace BAO_STORE
    Public Class connection_db
        Public Function Queryds(ByVal Commands As String) As DataTable

            Dim dt As New DataTable
            Try
                Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_FOOD_ANGULARConnectionString").ConnectionString)
                Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
                mySqlDataAdapter.Fill(dt)
                MyConnection.Close()
            Catch ex As Exception

            End Try

            Return dt
        End Function
    End Class

    Public Class StoredProcedures
        Inherits connection_db
        Public Function SP_SEARCH_DATA_MAIN_DRIVE() As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_SEARCH_DATA_MAIN_DRIVE"

            dt = Queryds(sql)
            dt.TableName = "SP_SEARCH_DATA_MAIN_DRIVE"

            Return dt
        End Function

        Public Function SP_SEARCH_DATA_FREGNTF(ByVal Y As String) As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_SEARCH_DATA_FREGNTF @y=" & Y

            dt = Queryds(sql)
            dt.TableName = "SP_SEARCH_DATA_FREGNTF"
            Return dt
        End Function

        Public Function SP_SEARCH_DATA_FREG_PRODUCT(ByVal Y As String) As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_SEARCH_DATA_FREG_PRODUCT @y=" & Y

            dt = Queryds(sql)
            dt.TableName = "SP_SEARCH_DATA_FREG_PRODUCT"
            Return dt
        End Function
        Public Function SP_5_REPROCESS() As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_5_REPROCESS"

            dt = Queryds(sql)
            dt.TableName = "SP_5_REPROCESS"

            Return dt
        End Function

        Public Function SP_6_REPROCESS() As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_6_REPROCESS"

            dt = Queryds(sql)
            dt.TableName = "SP_6_REPROCESS"

            Return dt
        End Function
        Public Function SP_7_NEW() As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_7_NEW"

            dt = Queryds(sql)
            dt.TableName = "SP_7_NEW"

            Return dt
        End Function
        Public Function SP_8_8ELO() As DataTable
            Dim dt As New DataTable
            Dim sql As String = ""
            Dim clsds As New ClassDataset
            sql = "exec SP_8_8ELO"

            dt = Queryds(sql)
            dt.TableName = "SP_8_8ELO"

            Return dt
        End Function

    End Class

End Namespace
