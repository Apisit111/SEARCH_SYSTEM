Namespace DBO.REQUEST_TYPE

    Public MustInherit Class MAINCONTEXT
        Public db As New SEARCH_SYSTEMDataContext

        Public datas
        Public dt_tb As New DataTable
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TYPEREQUEST
        Inherits MAINCONTEXT


        Public field As New REQUESTTYPE

        Public Sub insert()
            db.REQUESTTYPEs.InsertOnSubmit(field)
            db.SubmitChanges()
        End Sub

        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.REQUESTTYPEs.DeleteOnSubmit(field)
            db.SubmitChanges()
        End Sub


        'Public Sub GetDataby_ida(ByVal ID As Integer)
        '    datas = (From p In db.STATUS_MASTERs Where p.ID = ID Select p)
        '    For Each Me.field In datas

        '    Next
        'End Sub

        Public Sub GetDataby_one()
            datas = (From s In db.REQUESTTYPEs Select s)
            For Each Me.field In datas

            Next
        End Sub

    End Class


End Namespace