Imports System.Web.Script.Serialization
Imports Newtonsoft.Json

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    'Function GETDATA_ALL_SEARCH()
    '    Dim MODEL As New SEARCH_SYSTEM
    '    Dim obj As New Object
    '    Dim DT_ALL As New DataTable
    '    Dim clsds As New ClassDataset


    '    Dim bao_table As New BAO_STORE.StoredProcedures

    '    Dim dt As New DataTable
    '    dt = bao_table.SP_5_REPROCESS()
    '    DT_ALL.Merge(dt)

    '    'Dim dt1 As New DataTable
    '    'dt1 = bao_table.SP_6_REPROCESS()
    '    'DT_ALL.Merge(dt1)

    '    DT_ALL = clsds.DatatableWhere(DT_ALL, "DATA_LIST.RECEIVING_NUM <> 0")


    '    Return DT_ALL
    'End Function
    Function callData(ByVal DATA As String)
        If DATA = "MainDrive" Then
            Return LOAD_SEARCH_FOOD_MAIN_DRIVE()
        ElseIf DATA = "Fregntf2020" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2020)
        ElseIf DATA = "Fregntf2019" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2019)
        ElseIf DATA = "Fregntf2018" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2018)
        ElseIf DATA = "Fregntf2017" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2017)
        ElseIf DATA = "Fregntf2016" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2016)
        ElseIf DATA = "Fregntf2015" Then
            Return LOAD_SEARCH_FOOD_FREGNTF(2015)
        End If
        Return ""
    End Function
    Function LOAD_SEARCH_FOOD_MAIN_DRIVE()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_SEARCH_DATA_MAIN_DRIVE()

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Return JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
    End Function
    Function LOAD_SEARCH_FOOD_FREGNTF(ByVal y As Integer)
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_SEARCH_DATA_FREGNTF(y)

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Return JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
    End Function
    Function LOAD_SB7()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_7_NEW()

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Dim ss2 As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss2
    End Function
    Function LOAD_SB5_REPROCESS()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_5_REPROCESS()

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        obj = MODEL

        Dim ss As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss

    End Function

    Function LOAD_SB5_DS()

    End Function

    Function LOAD_SB8()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_8_8ELO

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Dim ss2 As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss2
    End Function

    Function LOAD_SB6()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_8_8ELO

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Dim ss2 As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss2
    End Function

    Function LOAD_SB6_REPROCESS()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_8_8ELO

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Dim ss2 As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss2
    End Function
    Function LOAD_AOR17()
        Dim MODEL As New SEARCH_SYSTEM
        Dim obj As New Object

        Dim dt As New DataTable

        Dim bao_table As New BAO_STORE.StoredProcedures

        dt = bao_table.SP_8_8ELO

        Dim jsons As New JsonResult
        jsons = Json(DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        jsons.MaxJsonLength = Integer.MaxValue
        MODEL.DATA_LIST = jsons

        Dim ss2 As String = JsonConvert.SerializeObject(MODEL, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
        Return ss2
    End Function
    Function STATUS_NAME()

        Dim datatabledata As New DataTable

        Dim dao_falcn_all As New DBO.STATUS_NAME.STATUS
        dao_falcn_all.GetDataby_all()

        datatabledata.Columns.Add("ID", GetType(Integer))
        datatabledata.Columns.Add("STATUSNAME", GetType(String))

        For Each dao_falcn_all.field In dao_falcn_all.datas
            datatabledata.Rows.Add(dao_falcn_all.field.STATUS_ID, dao_falcn_all.field.STATUS_NAME)
        Next

        Dim allstatusname As String = JsonConvert.SerializeObject(datatabledata)

        Return allstatusname

    End Function

    Function REQUEST_TYPE()

        Dim datatabledata As New DataTable

        Dim dao_falcn_one As New DBO.REQUEST_TYPE.TYPEREQUEST
        dao_falcn_one.GetDataby_one()

        datatabledata.Columns.Add("IDA", GetType(Integer))
        datatabledata.Columns.Add("TYPEREQUEST", GetType(String))

        For Each dao_falcn_one.field In dao_falcn_one.datas
            datatabledata.Rows.Add(dao_falcn_one.field.IDA, dao_falcn_one.field.TYPEREQUEST)
        Next

        Dim requesttype As String = JsonConvert.SerializeObject(datatabledata)

        Return requesttype

    End Function

    Function THACHNGWTNM()

        Dim datatabledata As New DataTable

        Dim dao_falcn_two As New fda.syschngwts.thachngwtnm
        dao_falcn_two.GetDataby_one()

        datatabledata.Columns.Add("chngwtcd", GetType(Integer))
        datatabledata.Columns.Add("thachngwtnm", GetType(String))

        For Each dao_falcn_two.field In dao_falcn_two.datas
            datatabledata.Rows.Add(dao_falcn_two.field.chngwtcd, dao_falcn_two.field.thachngwtnm)
        Next

        Dim thachngwtnms As String = JsonConvert.SerializeObject(datatabledata)

        Return thachngwtnms

    End Function

    Function FDTYPENAME()

        Dim datatabledata As New DataTable

        Dim dao_falcn_three As New DBO.MAS_FAFDTYPE_NEWS.fdtypename
        dao_falcn_three.GetDataby_one()

        datatabledata.Columns.Add("fdtypecd", GetType(Integer))
        datatabledata.Columns.Add("fdtypename", GetType(String))

        For Each dao_falcn_three.field In dao_falcn_three.datas
            datatabledata.Rows.Add(dao_falcn_three.field.fdtypecd, dao_falcn_three.field.fdtypename)
        Next

        Dim fdtypenames As String = JsonConvert.SerializeObject(datatabledata)

        Return fdtypenames

    End Function

    Public Function DataTableToJSON(ByVal table As DataTable) As Object
        Dim list = New List(Of Dictionary(Of String, Object))()

        For Each row As DataRow In table.Rows
            Dim dict = New Dictionary(Of String, Object)()

            For Each col As DataColumn In table.Columns
                dict(col.ColumnName) = (Convert.ToString(row(col)))
            Next

            list.Add(dict)
        Next

        Return list

    End Function

End Class