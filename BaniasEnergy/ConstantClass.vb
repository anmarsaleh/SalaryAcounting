Public Class ConstantClass
    Dim _SalaryConstID As Integer
    Dim _Wife As String
    Dim _Child1 As String
    Dim _Child2 As String
    Dim _Child3 As String
    Dim _OtherChild As String
    Dim _warm As String
    Dim _Specialize As String
    Dim _TypeSpecialize As String
    Dim _SocialInsurance As String
    Dim _CooperateBox As String
    Dim _CooperationWorkers As String
    Dim _EngCooperation As String
    Dim _habitation As String
    Dim _AssistBox As String
    Dim _AssistBox1 As String
    Dim _Typo As String
    Dim _DeathAssist As String
    Dim _EndService As String
    Dim _TaxImmunity As String
    Public Sub New(ByVal SalConstID As Integer)
        _SalaryConstID = SalConstID
    End Sub
    Property ConstID As Integer
        Get
            Return _SalaryConstID
        End Get
        Set(ByVal value As Integer)
            _SalaryConstID = value
        End Set
    End Property
    Property Wife As String
        Get
            Return _Wife
        End Get
        Set(ByVal value As String)
            _Wife = value
        End Set
    End Property
    Property Child1 As String
        Get
            Return _Child1
        End Get
        Set(ByVal value As String)
            _Child1 = value
        End Set
    End Property
    Property Child2 As String
        Get
            Return _Child2
        End Get
        Set(ByVal value As String)
            _Child2 = value
        End Set
    End Property
    Property Child3 As String
        Get
            Return _Child3
        End Get
        Set(ByVal value As String)
            _Child3 = value
        End Set
    End Property
    Property OtherChild As String
        Get
            Return _OtherChild
        End Get
        Set(ByVal value As String)
            _OtherChild = value
        End Set
    End Property
    Property warm As String
        Get
            Return _warm
        End Get
        Set(ByVal value As String)
            _warm = value
        End Set
    End Property
    Property Specialize As String
        Get
            Return _Specialize
        End Get
        Set(ByVal value As String)
            _Specialize = value
        End Set
    End Property
    Property TypeSpecialize As String
        Get
            Return _TypeSpecialize
        End Get
        Set(ByVal value As String)
            _TypeSpecialize = value
        End Set
    End Property
    Property SocialInsurance As String
        Get
            Return _SocialInsurance
        End Get
        Set(ByVal value As String)
            _SocialInsurance = value
        End Set
    End Property
    Property CooperateBox As String
        Get
            Return _CooperateBox
        End Get
        Set(ByVal value As String)
            _CooperateBox = value
        End Set
    End Property
    Property CooperationWorkers As String
        Get
            Return _CooperationWorkers
        End Get
        Set(ByVal value As String)
            _CooperationWorkers = value
        End Set
    End Property
    Property EngCooperation As String
        Get
            Return _EngCooperation
        End Get
        Set(ByVal value As String)
            _EngCooperation = value
        End Set
    End Property
    Property habitation As String
        Get
            Return _habitation
        End Get
        Set(ByVal value As String)
            _habitation = value
        End Set
    End Property
    Property AssistBox As String
        Get
            Return _AssistBox
        End Get
        Set(ByVal value As String)
            _AssistBox = value
        End Set
    End Property
    Property AssistBox1 As String
        Get
            Return _AssistBox1
        End Get
        Set(ByVal value As String)
            _AssistBox1 = value
        End Set
    End Property
    Property Typo As String
        Get
            Return _Typo
        End Get
        Set(ByVal value As String)
            _Typo = value
        End Set
    End Property
    Property DeathAssist As String
        Get
            Return _DeathAssist
        End Get
        Set(ByVal value As String)
            _DeathAssist = value
        End Set
    End Property
    Property EndService As String
        Get
            Return _EndService
        End Get
        Set(ByVal value As String)
            _EndService = value
        End Set
    End Property
    Property TaxImmunity As String
        Get
            Return _TaxImmunity
        End Get
        Set(ByVal value As String)
            _TaxImmunity = value
        End Set
    End Property
End Class
