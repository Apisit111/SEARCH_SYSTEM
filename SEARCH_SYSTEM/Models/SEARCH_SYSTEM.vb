Public Class SEARCH_SYSTEM

    Private _AUTHEN_INFORMATION As New AUTHEN_INFORMATION
    Public Property AUTHEN_INFORMATION() As AUTHEN_INFORMATION
        Get
            Return _AUTHEN_INFORMATION
        End Get
        Set(ByVal value As AUTHEN_INFORMATION)
            _AUTHEN_INFORMATION = value
        End Set
    End Property

    Private _DATA_LIST As New JsonResult
    Public Property DATA_LIST() As JsonResult
        Get
            Return _DATA_LIST
        End Get
        Set(ByVal value As JsonResult)
            _DATA_LIST = value
        End Set
    End Property

    Private _DATA_LIST1 As New JsonResult
    Public Property DATA_LIST1() As JsonResult
        Get
            Return _DATA_LIST1
        End Get
        Set(ByVal value As JsonResult)
            _DATA_LIST1 = value
        End Set
    End Property

    Private _DATA_LIST2 As New JsonResult
    Public Property DATA_LIST2() As JsonResult
        Get
            Return _DATA_LIST2
        End Get
        Set(ByVal value As JsonResult)
            _DATA_LIST2 = value
        End Set
    End Property

    Private _DATA_LIST3 As New JsonResult
    Public Property DATA_LIST3() As JsonResult
        Get
            Return _DATA_LIST3
        End Get
        Set(ByVal value As JsonResult)
            _DATA_LIST3 = value
        End Set
    End Property

End Class
