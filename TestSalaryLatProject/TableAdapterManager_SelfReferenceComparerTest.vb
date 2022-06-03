Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BaniasEnergy.BaniasEnergyDBDataSetTableAdapters



'''<summary>
'''This is a test class for TableAdapterManager_SelfReferenceComparerTest and is intended
'''to contain all TableAdapterManager_SelfReferenceComparerTest Unit Tests
'''</summary>
<TestClass()> _
Public Class TableAdapterManager_SelfReferenceComparerTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for GetRoot
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub GetRootTest()
        Dim param0 As PrivateObject = Nothing ' TODO: Initialize to an appropriate value
        Dim target As TableAdapterManager_Accessor.SelfReferenceComparer = New TableAdapterManager_Accessor.SelfReferenceComparer(param0) ' TODO: Initialize to an appropriate value
        Dim row As DataRow = Nothing ' TODO: Initialize to an appropriate value
        Dim distance As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim distanceExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As DataRow
        actual = target.GetRoot(row, distance)
        Assert.AreEqual(distanceExpected, distance)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Compare
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub CompareTest()
        'Class inheritance across assemblies is not preserved by private accessors. However, a static method AttachShadow() is provided in each private accessor class to transfer a private object from one private accessor class to another.
        Assert.Inconclusive("Class inheritance across assemblies is not preserved by private accessors. Howeve" & _
                "r, a static method AttachShadow() is provided in each private accessor class to " & _
                "transfer a private object from one private accessor class to another.")
    End Sub

    '''<summary>
    '''A test for SelfReferenceComparer Constructor
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub TableAdapterManager_SelfReferenceComparerConstructorTest()
        Dim relation As DataRelation = Nothing ' TODO: Initialize to an appropriate value
        Dim childFirst As Boolean = False ' TODO: Initialize to an appropriate value
        Dim target As TableAdapterManager_Accessor.SelfReferenceComparer = New TableAdapterManager_Accessor.SelfReferenceComparer(relation, childFirst)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
