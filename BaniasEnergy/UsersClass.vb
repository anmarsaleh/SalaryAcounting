Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class UsersClass
    Dim _UserID As Integer
    Dim _UserName As String
    Dim _UserPW As String
    Dim _IsAdmin As Boolean
    Dim _IsActive As Boolean
    Dim _AllowOpen As Boolean
    Dim _AllowDelete As Boolean
    Dim _AllowModify As Boolean
    Dim _AllowPrint As Boolean
    Dim _IsExpire As Boolean
    Dim _ExpireDate As String
    Dim _Expired As Boolean
    Dim _AllowSalary As Boolean
    Dim _AllowWorkers As Boolean
    Dim _AllowAgents As Boolean
    Dim _AllowManagers As Boolean
    Dim _AllowEngeneers As Boolean
    Dim _AllowContracts As Boolean
    Dim _AllRecords As Boolean

    Public Sub New(ByVal uid As Integer, ByVal uname As String, ByVal Aexpirdate As String, ByVal admin As Boolean, ByVal activ As Boolean, ByVal PW As String, _
                    ByVal Aopen As Boolean, ByVal Adelete As Boolean, ByVal Amodify As Boolean, ByVal Aprint As Boolean, ByVal AIsexpir As Boolean, _
                    ByVal ASalary As Boolean, ByVal AWorkers As Boolean, ByVal Aagents As Boolean, ByVal Amanagers As Boolean, ByVal Aengeneers As Boolean, ByVal AContracts As Boolean, ByVal AllRecords As Boolean)
        _UserID = uid
        _UserName = uname
        _ExpireDate = Aexpirdate
        _IsAdmin = admin
        _IsActive = activ
        _UserPW = PW
        _AllowOpen = Aopen
        _AllowDelete = Adelete
        _AllowModify = Amodify
        _AllowPrint = Aprint
        _IsExpire = AIsexpir
        _AllowSalary = ASalary
        _AllowWorkers = AWorkers
        _AllowAgents = Aagents
        _AllowManagers = Amanagers
        _AllowEngeneers = Aengeneers
        _AllowContracts = AContracts
        _AllRecords = AllRecords
    End Sub
    Property AllRecords As Integer
        Get
            Return _AllRecords
        End Get
        Set(ByVal value As Integer)
            _AllRecords = value
        End Set
    End Property
    Property UserID As Integer
        Get
            Return _UserID
        End Get
        Set(ByVal value As Integer)
            _UserID = value
        End Set
    End Property
    Property UserName As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property
    Property UserPW As String
        Get
            Return _UserPW
        End Get
        Set(ByVal value As String)
            _UserPW = value
        End Set
    End Property
    Property IsAdmin As Boolean
        Get
            Return _IsAdmin
        End Get
        Set(ByVal value As Boolean)
            _IsAdmin = value
        End Set
    End Property
    Property IsActive As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property
    Property AllowOpen As Boolean
        Get
            Return _AllowOpen
        End Get
        Set(ByVal value As Boolean)
            _AllowOpen = value
        End Set
    End Property
    Property AllowDelete As Boolean
        Get
            Return _AllowDelete
        End Get
        Set(ByVal value As Boolean)
            _AllowDelete = value
        End Set
    End Property
    Property AllowModify As Boolean
        Get
            Return _AllowModify
        End Get
        Set(ByVal value As Boolean)
            _AllowModify = value
        End Set
    End Property
    Property AllowPrint As Boolean
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value As Boolean)
            _AllowPrint = value
        End Set
    End Property
    Property IsExpire As Boolean
        Get
            Return _IsExpire
        End Get
        Set(ByVal value As Boolean)
            _IsExpire = value
        End Set
    End Property
    Property ExpireDate As Date
        Get
            Return _ExpireDate
        End Get
        Set(ByVal value As Date)
            _ExpireDate = value
        End Set
    End Property
    Property AllowSalary As Boolean
        Get
            Return _AllowSalary
        End Get
        Set(ByVal value As Boolean)
            _AllowSalary = value
        End Set
    End Property
    Property AllowWorkers As Boolean
        Get
            Return _AllowWorkers
        End Get
        Set(ByVal value As Boolean)
            _AllowWorkers = value
        End Set
    End Property
    Property AllowAgents As Boolean
        Get
            Return _AllowAgents
        End Get
        Set(ByVal value As Boolean)
            _AllowAgents = value
        End Set
    End Property
    Property AllowManagers As Boolean
        Get
            Return _AllowManagers
        End Get
        Set(ByVal value As Boolean)
            _AllowManagers = value
        End Set
    End Property
    Property AllowEngeneers As Boolean
        Get
            Return _AllowEngeneers
        End Get
        Set(ByVal value As Boolean)
            _AllowEngeneers = value
        End Set
    End Property
    Property AllowContracts As Boolean
        Get
            Return _AllowContracts
        End Get
        Set(ByVal value As Boolean)
            _AllowContracts = value
        End Set
    End Property
    Public Function ExpiredUser() As Boolean
        Dim r As Boolean = False
        If Me.IsExpire Then
            If CDate(Me.ExpireDate) < Now.Date Then
                r = True
            Else
                r = False
            End If
        Else
            r = False
        End If
        Return r
    End Function

    Public Function LastEditUser(ByVal eUserID As Integer) As String
        Dim r As String
        Dim uCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim uCmd As New SqlCommand("select UserName from users where (UserID=" & eUserID & ")", uCnn)
        uCnn.Open()
        r = uCmd.ExecuteScalar
        uCmd.Dispose()
        uCnn.Close()
        uCnn.Dispose()
        Return r
    End Function
End Class
