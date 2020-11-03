Namespace DBO.STATUS_NAME

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

    Public Class STATUS
        Inherits MAINCONTEXT


        Public field As New STATUS_MASTER

        Public Sub insert()
            db.STATUS_MASTERs.InsertOnSubmit(field)
            db.SubmitChanges()
        End Sub

        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.STATUS_MASTERs.DeleteOnSubmit(field)
            db.SubmitChanges()
        End Sub


        'Public Sub GetDataby_ida(ByVal ID As Integer)
        '    datas = (From p In db.STATUS_MASTERs Where p.ID = ID Select p)
        '    For Each Me.field In datas

        '    Next
        'End Sub

        Public Sub GetDataby_all()
            datas = (From p In db.STATUS_MASTERs Select p)
            For Each Me.field In datas

            Next
        End Sub



    End Class
End Namespace