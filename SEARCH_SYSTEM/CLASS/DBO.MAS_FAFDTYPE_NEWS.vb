Namespace DBO.MAS_FAFDTYPE_NEWS

    Public MustInherit Class MAINCONTEXT
        Public db As New THAIDataContext

        Public datas
        Public dt_tb As New DataTable
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class fdtypename
        Inherits MAINCONTEXT


        Public field As New MAS_FAFDTYPE_NEW

        Public Sub insert()
            db.MAS_FAFDTYPE_NEWs.InsertOnSubmit(field)
            db.SubmitChanges()
        End Sub

        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.MAS_FAFDTYPE_NEWs.DeleteOnSubmit(field)
            db.SubmitChanges()
        End Sub


        'Public Sub GetDataby_ida(ByVal ID As Integer)
        '    datas = (From p In db.STATUS_MASTERs Where p.ID = ID Select p)
        '    For Each Me.field In datas

        '    Next
        'End Sub

        Public Sub GetDataby_one()
            datas = (From s In db.MAS_FAFDTYPE_NEWs Select s)
            For Each Me.field In datas

            Next
        End Sub

    End Class


End Namespace