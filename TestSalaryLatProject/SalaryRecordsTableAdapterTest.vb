Imports BaniasEnergy

Imports System.Data

Imports System

Imports System.Data.SqlClient

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BaniasEnergy.BaniasEnergyDBDataSetTableAdapters



'''<summary>
'''This is a test class for SalaryRecordsTableAdapterTest and is intended
'''to contain all SalaryRecordsTableAdapterTest Unit Tests
'''</summary>
<TestClass()> _
Public Class SalaryRecordsTableAdapterTest


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
    '''A test for _adapter
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub _adapterTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        Dim expected As SqlDataAdapter = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As SqlDataAdapter
        target._adapter = expected
        actual = target._adapter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Transaction
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub TransactionTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        Dim expected As SqlTransaction = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As SqlTransaction
        target.Transaction = expected
        actual = target.Transaction
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Connection
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub ConnectionTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        Dim expected As SqlConnection = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As SqlConnection
        target.Connection = expected
        actual = target.Connection
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for CommandCollection
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub CommandCollectionTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        Dim actual() As SqlCommand
        actual = target.CommandCollection
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ClearBeforeFill
    '''</summary>
    <TestMethod()> _
    Public Sub ClearBeforeFillTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        target.ClearBeforeFill = expected
        actual = target.ClearBeforeFill
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Adapter
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub AdapterTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        Dim actual As SqlDataAdapter
        actual = target.Adapter
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for __ENCAddToList
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub __ENCAddToListTest()
        Dim value As Object = Nothing ' TODO: Initialize to an appropriate value
        SalaryRecordsTableAdapter_Accessor.__ENCAddToList(value)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for UpdateMarNo
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateMarNoTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim mak As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim MarkImg() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.UpdateMarNo(mak, MarkImg, EmpID)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim dataRows() As DataRow = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(dataRows)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest1()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim dataRow As DataRow = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(dataRow)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest2()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim dataTable As BaniasEnergyDBDataSet.SalaryRecordsDataTable = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(dataTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest3()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim MarkRecord() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Notes As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Original_FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(EmpID, FinanceID, DirectorateID, OfficeID, Fname, Mname, Lname, agentEmp, SlitSalary, Allowance, RepaymentFamily, RF_HaveWife, RF_child1, RF_child2, RF_child3, RF_OtherChild, IsEngeneer, DangerWork, BacklogReturn, Impulse, Gift, TotalTax, SalaryTax, BacklogRecover, TotalTakeOuts, IsSocialInsurance, SocialInsurance, IsCooperateBox, CooperateBox, ISCooperationWorkers, CooperationWorkers, IsEngCooperation, EngCooperation, IShabitation, IsAssistBox, AssistBox, IsEndService, EndService, AbsenceNumber, absence, IntegratorSolidarity, IsSolidaritySocial, SolidaritySocial, SportClup, Incubation, Typo, IsDeathAssist, DeathAssist, HoldServiceDate, HS_Total, HS_Mounths, HS_Discount, Datepenalty, P_Total, P_Mounths, P_Discount, DiscountTaskDate, DT_Total, DT_Mounts, DT_Discount, RodDate, R_Total, R_Mounths, R_Discount, CooperationLoanDate, CL_Total, CL_Mounths, CL_Discount, WorkersLoanDate, WL_Total, WL_Mounts, WL_Discount, EngCooperationTaxDate, ECT_Total, ECT_Mounts, ECT_Discount, AkariBankDate, AB_Total, AB_Mounts, AB_Discount, TasleefBankDate, TB_Total, TB_Mounts, TB_Discount, TawfeerBankDate, TWB_Total, TWB_Mounts, TWB_Discount, TajzahLoanDate, TL_Total, TL_Mounts, TL_Discount, RecoveryDate, RC_Total, RC_Mounts, RC_Discount, FullSalary, SumDiscounts, TotalSalary, SalaryYear, SalaryMount, UserID, CreateDate, LastModify, MarkNo, MarkRecord, FullName, ControlID, TSpecialize, TaxationID, SalaryConstants, habitationPerc, habitation, CardNo, Notes, IsEngFarm, TaxFarmEng, IsstipendInsurance, EmpCompany, EmpHelth, stipendInsurance, WorkableEmp, CleanerTax, OldSlitSalary, STindex, Tindex, IsManager, ManagerTax, NoTax, Slave_DeathAssist, Slave_AssistBox, Slave_SolidaritySocial, EmpClass, IsSoldur, NoSalaryCost, NoSalaryDays, salarysame, mutableCost, mutableDays, mutableClass, mutable, HealthVacationDays, Night, drive, IsContract, CenterID, HealthVacationCost, TypeSpecializeID, SpecializeID, Qhelp, retirefarmeng, Spcar, Amanager, Nmanager, Pmanager, SpHouse, OverWorkValue, OverWorkOhr, OverWorkDay, OverWorkNight, IsOverWorkOhr, ForecTopWvalue, Specialize, TypeSpecialize, Authority, ReturnSpecialize, Original_EmpID, Original_FinanceID, Original_DirectorateID, Original_OfficeID, Original_Fname, Original_Mname, Original_Lname, Original_agentEmp, Original_SlitSalary, Original_Allowance, Original_RepaymentFamily, Original_RF_HaveWife, Original_RF_child1, Original_RF_child2, Original_RF_child3, Original_RF_OtherChild, Original_IsEngeneer, Original_DangerWork, Original_BacklogReturn, Original_Impulse, Original_Gift, Original_TotalTax, Original_SalaryTax, Original_BacklogRecover, Original_TotalTakeOuts, Original_IsSocialInsurance, Original_SocialInsurance, Original_IsCooperateBox, Original_CooperateBox, Original_ISCooperationWorkers, Original_CooperationWorkers, Original_IsEngCooperation, Original_EngCooperation, Original_IShabitation, Original_IsAssistBox, Original_AssistBox, Original_IsEndService, Original_EndService, Original_AbsenceNumber, Original_absence, Original_IntegratorSolidarity, Original_IsSolidaritySocial, Original_SolidaritySocial, Original_SportClup, Original_Incubation, Original_Typo, Original_IsDeathAssist, Original_DeathAssist, Original_HoldServiceDate, Original_HS_Total, Original_HS_Mounths, Original_HS_Discount, Original_Datepenalty, Original_P_Total, Original_P_Mounths, Original_P_Discount, Original_DiscountTaskDate, Original_DT_Total, Original_DT_Mounts, Original_DT_Discount, Original_RodDate, Original_R_Total, Original_R_Mounths, Original_R_Discount, Original_CooperationLoanDate, Original_CL_Total, Original_CL_Mounths, Original_CL_Discount, Original_WorkersLoanDate, Original_WL_Total, Original_WL_Mounts, Original_WL_Discount, Original_EngCooperationTaxDate, Original_ECT_Total, Original_ECT_Mounts, Original_ECT_Discount, Original_AkariBankDate, Original_AB_Total, Original_AB_Mounts, Original_AB_Discount, Original_TasleefBankDate, Original_TB_Total, Original_TB_Mounts, Original_TB_Discount, Original_TawfeerBankDate, Original_TWB_Total, Original_TWB_Mounts, Original_TWB_Discount, Original_TajzahLoanDate, Original_TL_Total, Original_TL_Mounts, Original_TL_Discount, Original_RecoveryDate, Original_RC_Total, Original_RC_Mounts, Original_RC_Discount, Original_FullSalary, Original_SumDiscounts, Original_TotalSalary, Original_SalaryYear, Original_SalaryMount, Original_UserID, Original_CreateDate, Original_LastModify, Original_MarkNo, Original_FullName, Original_ControlID, Original_TSpecialize, Original_TaxationID, Original_SalaryConstants, Original_habitationPerc, Original_habitation, Original_CardNo, Original_IsEngFarm, Original_TaxFarmEng, Original_IsstipendInsurance, Original_EmpCompany, Original_EmpHelth, Original_stipendInsurance, Original_WorkableEmp, Original_CleanerTax, Original_OldSlitSalary, Original_STindex, Original_Tindex, Original_IsManager, Original_ManagerTax, Original_NoTax, Original_Slave_DeathAssist, Original_Slave_AssistBox, Original_Slave_SolidaritySocial, Original_EmpClass, Original_IsSoldur, Original_NoSalaryCost, Original_NoSalaryDays, Original_salarysame, Original_mutableCost, Original_mutableDays, Original_mutableClass, Original_mutable, Original_HealthVacationDays, Original_Night, Original_drive, Original_IsContract, Original_CenterID, Original_HealthVacationCost, Original_TypeSpecializeID, Original_SpecializeID, Original_Qhelp, Original_retirefarmeng, Original_Spcar, Original_Amanager, Original_Nmanager, Original_Pmanager, Original_SpHouse, Original_OverWorkValue, Original_OverWorkOhr, Original_OverWorkDay, Original_OverWorkNight, Original_IsOverWorkOhr, Original_ForecTopWvalue, Original_Specialize, Original_TypeSpecialize, Original_Authority, Original_ReturnSpecialize)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest4()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim dataSet As BaniasEnergyDBDataSet = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(dataSet)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Update
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateTest5()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim MarkRecord() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Notes As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Original_FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Update(FinanceID, DirectorateID, OfficeID, Fname, Mname, Lname, agentEmp, SlitSalary, Allowance, RepaymentFamily, RF_HaveWife, RF_child1, RF_child2, RF_child3, RF_OtherChild, IsEngeneer, DangerWork, BacklogReturn, Impulse, Gift, TotalTax, SalaryTax, BacklogRecover, TotalTakeOuts, IsSocialInsurance, SocialInsurance, IsCooperateBox, CooperateBox, ISCooperationWorkers, CooperationWorkers, IsEngCooperation, EngCooperation, IShabitation, IsAssistBox, AssistBox, IsEndService, EndService, AbsenceNumber, absence, IntegratorSolidarity, IsSolidaritySocial, SolidaritySocial, SportClup, Incubation, Typo, IsDeathAssist, DeathAssist, HoldServiceDate, HS_Total, HS_Mounths, HS_Discount, Datepenalty, P_Total, P_Mounths, P_Discount, DiscountTaskDate, DT_Total, DT_Mounts, DT_Discount, RodDate, R_Total, R_Mounths, R_Discount, CooperationLoanDate, CL_Total, CL_Mounths, CL_Discount, WorkersLoanDate, WL_Total, WL_Mounts, WL_Discount, EngCooperationTaxDate, ECT_Total, ECT_Mounts, ECT_Discount, AkariBankDate, AB_Total, AB_Mounts, AB_Discount, TasleefBankDate, TB_Total, TB_Mounts, TB_Discount, TawfeerBankDate, TWB_Total, TWB_Mounts, TWB_Discount, TajzahLoanDate, TL_Total, TL_Mounts, TL_Discount, RecoveryDate, RC_Total, RC_Mounts, RC_Discount, FullSalary, SumDiscounts, TotalSalary, SalaryYear, SalaryMount, UserID, CreateDate, LastModify, MarkNo, MarkRecord, FullName, ControlID, TSpecialize, TaxationID, SalaryConstants, habitationPerc, habitation, CardNo, Notes, IsEngFarm, TaxFarmEng, IsstipendInsurance, EmpCompany, EmpHelth, stipendInsurance, WorkableEmp, CleanerTax, OldSlitSalary, STindex, Tindex, IsManager, ManagerTax, NoTax, Slave_DeathAssist, Slave_AssistBox, Slave_SolidaritySocial, EmpClass, IsSoldur, NoSalaryCost, NoSalaryDays, salarysame, mutableCost, mutableDays, mutableClass, mutable, HealthVacationDays, Night, drive, IsContract, CenterID, HealthVacationCost, TypeSpecializeID, SpecializeID, Qhelp, retirefarmeng, Spcar, Amanager, Nmanager, Pmanager, SpHouse, OverWorkValue, OverWorkOhr, OverWorkDay, OverWorkNight, IsOverWorkOhr, ForecTopWvalue, Specialize, TypeSpecialize, Authority, ReturnSpecialize, Original_EmpID, Original_FinanceID, Original_DirectorateID, Original_OfficeID, Original_Fname, Original_Mname, Original_Lname, Original_agentEmp, Original_SlitSalary, Original_Allowance, Original_RepaymentFamily, Original_RF_HaveWife, Original_RF_child1, Original_RF_child2, Original_RF_child3, Original_RF_OtherChild, Original_IsEngeneer, Original_DangerWork, Original_BacklogReturn, Original_Impulse, Original_Gift, Original_TotalTax, Original_SalaryTax, Original_BacklogRecover, Original_TotalTakeOuts, Original_IsSocialInsurance, Original_SocialInsurance, Original_IsCooperateBox, Original_CooperateBox, Original_ISCooperationWorkers, Original_CooperationWorkers, Original_IsEngCooperation, Original_EngCooperation, Original_IShabitation, Original_IsAssistBox, Original_AssistBox, Original_IsEndService, Original_EndService, Original_AbsenceNumber, Original_absence, Original_IntegratorSolidarity, Original_IsSolidaritySocial, Original_SolidaritySocial, Original_SportClup, Original_Incubation, Original_Typo, Original_IsDeathAssist, Original_DeathAssist, Original_HoldServiceDate, Original_HS_Total, Original_HS_Mounths, Original_HS_Discount, Original_Datepenalty, Original_P_Total, Original_P_Mounths, Original_P_Discount, Original_DiscountTaskDate, Original_DT_Total, Original_DT_Mounts, Original_DT_Discount, Original_RodDate, Original_R_Total, Original_R_Mounths, Original_R_Discount, Original_CooperationLoanDate, Original_CL_Total, Original_CL_Mounths, Original_CL_Discount, Original_WorkersLoanDate, Original_WL_Total, Original_WL_Mounts, Original_WL_Discount, Original_EngCooperationTaxDate, Original_ECT_Total, Original_ECT_Mounts, Original_ECT_Discount, Original_AkariBankDate, Original_AB_Total, Original_AB_Mounts, Original_AB_Discount, Original_TasleefBankDate, Original_TB_Total, Original_TB_Mounts, Original_TB_Discount, Original_TawfeerBankDate, Original_TWB_Total, Original_TWB_Mounts, Original_TWB_Discount, Original_TajzahLoanDate, Original_TL_Total, Original_TL_Mounts, Original_TL_Discount, Original_RecoveryDate, Original_RC_Total, Original_RC_Mounts, Original_RC_Discount, Original_FullSalary, Original_SumDiscounts, Original_TotalSalary, Original_SalaryYear, Original_SalaryMount, Original_UserID, Original_CreateDate, Original_LastModify, Original_MarkNo, Original_FullName, Original_ControlID, Original_TSpecialize, Original_TaxationID, Original_SalaryConstants, Original_habitationPerc, Original_habitation, Original_CardNo, Original_IsEngFarm, Original_TaxFarmEng, Original_IsstipendInsurance, Original_EmpCompany, Original_EmpHelth, Original_stipendInsurance, Original_WorkableEmp, Original_CleanerTax, Original_OldSlitSalary, Original_STindex, Original_Tindex, Original_IsManager, Original_ManagerTax, Original_NoTax, Original_Slave_DeathAssist, Original_Slave_AssistBox, Original_Slave_SolidaritySocial, Original_EmpClass, Original_IsSoldur, Original_NoSalaryCost, Original_NoSalaryDays, Original_salarysame, Original_mutableCost, Original_mutableDays, Original_mutableClass, Original_mutable, Original_HealthVacationDays, Original_Night, Original_drive, Original_IsContract, Original_CenterID, Original_HealthVacationCost, Original_TypeSpecializeID, Original_SpecializeID, Original_Qhelp, Original_retirefarmeng, Original_Spcar, Original_Amanager, Original_Nmanager, Original_Pmanager, Original_SpHouse, Original_OverWorkValue, Original_OverWorkOhr, Original_OverWorkDay, Original_OverWorkNight, Original_IsOverWorkOhr, Original_ForecTopWvalue, Original_Specialize, Original_TypeSpecialize, Original_Authority, Original_ReturnSpecialize)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for IsEmpIdFree
    '''</summary>
    <TestMethod()> _
    Public Sub IsEmpIdFreeTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim empid As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim actual As Nullable(Of Integer)
        actual = target.IsEmpIdFree(empid)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Insert
    '''</summary>
    <TestMethod()> _
    Public Sub InsertTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim MarkRecord() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Notes As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Insert(EmpID, FinanceID, DirectorateID, OfficeID, Fname, Mname, Lname, agentEmp, SlitSalary, Allowance, RepaymentFamily, RF_HaveWife, RF_child1, RF_child2, RF_child3, RF_OtherChild, IsEngeneer, DangerWork, BacklogReturn, Impulse, Gift, TotalTax, SalaryTax, BacklogRecover, TotalTakeOuts, IsSocialInsurance, SocialInsurance, IsCooperateBox, CooperateBox, ISCooperationWorkers, CooperationWorkers, IsEngCooperation, EngCooperation, IShabitation, IsAssistBox, AssistBox, IsEndService, EndService, AbsenceNumber, absence, IntegratorSolidarity, IsSolidaritySocial, SolidaritySocial, SportClup, Incubation, Typo, IsDeathAssist, DeathAssist, HoldServiceDate, HS_Total, HS_Mounths, HS_Discount, Datepenalty, P_Total, P_Mounths, P_Discount, DiscountTaskDate, DT_Total, DT_Mounts, DT_Discount, RodDate, R_Total, R_Mounths, R_Discount, CooperationLoanDate, CL_Total, CL_Mounths, CL_Discount, WorkersLoanDate, WL_Total, WL_Mounts, WL_Discount, EngCooperationTaxDate, ECT_Total, ECT_Mounts, ECT_Discount, AkariBankDate, AB_Total, AB_Mounts, AB_Discount, TasleefBankDate, TB_Total, TB_Mounts, TB_Discount, TawfeerBankDate, TWB_Total, TWB_Mounts, TWB_Discount, TajzahLoanDate, TL_Total, TL_Mounts, TL_Discount, RecoveryDate, RC_Total, RC_Mounts, RC_Discount, FullSalary, SumDiscounts, TotalSalary, SalaryYear, SalaryMount, UserID, CreateDate, LastModify, MarkNo, MarkRecord, FullName, ControlID, TSpecialize, TaxationID, SalaryConstants, habitationPerc, habitation, CardNo, Notes, IsEngFarm, TaxFarmEng, IsstipendInsurance, EmpCompany, EmpHelth, stipendInsurance, WorkableEmp, CleanerTax, OldSlitSalary, STindex, Tindex, IsManager, ManagerTax, NoTax, Slave_DeathAssist, Slave_AssistBox, Slave_SolidaritySocial, EmpClass, IsSoldur, NoSalaryCost, NoSalaryDays, salarysame, mutableCost, mutableDays, mutableClass, mutable, HealthVacationDays, Night, drive, IsContract, CenterID, HealthVacationCost, TypeSpecializeID, SpecializeID, Qhelp, retirefarmeng, Spcar, Amanager, Nmanager, Pmanager, SpHouse, OverWorkValue, OverWorkOhr, OverWorkDay, OverWorkNight, IsOverWorkOhr, ForecTopWvalue, Specialize, TypeSpecialize, Authority, ReturnSpecialize)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for InitConnection
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub InitConnectionTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        target.InitConnection()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitCommandCollection
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub InitCommandCollectionTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        target.InitCommandCollection()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitAdapter
    '''</summary>
    <TestMethod(), _
     DeploymentItem("SalaryLatPort.exe")> _
    Public Sub InitAdapterTest()
        Dim target As SalaryRecordsTableAdapter_Accessor = New SalaryRecordsTableAdapter_Accessor() ' TODO: Initialize to an appropriate value
        target.InitAdapter()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GetNewEmpID
    '''</summary>
    <TestMethod()> _
    Public Sub GetNewEmpIDTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim expected As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim actual As Nullable(Of Integer)
        actual = target.GetNewEmpID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetData
    '''</summary>
    <TestMethod()> _
    Public Sub GetDataTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim expected As BaniasEnergyDBDataSet.SalaryRecordsDataTable = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As BaniasEnergyDBDataSet.SalaryRecordsDataTable
        actual = target.GetData
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Fill
    '''</summary>
    <TestMethod()> _
    Public Sub FillTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim dataTable As BaniasEnergyDBDataSet.SalaryRecordsDataTable = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Fill(dataTable)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Delete
    '''</summary>
    <TestMethod()> _
    Public Sub DeleteTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter() ' TODO: Initialize to an appropriate value
        Dim Original_EmpID As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Original_FinanceID As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DirectorateID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OfficeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Fname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Mname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_Lname As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_agentEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_Allowance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RepaymentFamily As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_RF_HaveWife As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child1 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child2 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_child3 As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_RF_OtherChild As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngeneer As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DangerWork As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogReturn As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Impulse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Gift As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_BacklogRecover As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalTakeOuts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSocialInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SocialInsurance As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsCooperateBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperateBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_ISCooperationWorkers As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationWorkers As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsEngCooperation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperation As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IShabitation As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_IsAssistBox As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_AssistBox As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsEndService As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EndService As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AbsenceNumber As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_absence As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IntegratorSolidarity As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSolidaritySocial As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SolidaritySocial As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_SportClup As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Incubation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Typo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsDeathAssist As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_DeathAssist As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_HoldServiceDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_HS_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HS_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Datepenalty As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_P_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_P_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DiscountTaskDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_DT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_DT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RodDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_R_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_R_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CooperationLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_CL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Mounths As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkersLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_WL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EngCooperationTaxDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ECT_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AkariBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_AB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_AB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TasleefBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TawfeerBankDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TWB_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TajzahLoanDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_TL_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TL_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RecoveryDate As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_RC_Total As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Mounts As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_RC_Discount As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SumDiscounts As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_TotalSalary As Nullable(Of Long) = New Nullable(Of Long)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryYear As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_SalaryMount As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_UserID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CreateDate As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_LastModify As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim Original_MarkNo As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_FullName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_ControlID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxationID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SalaryConstants As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_habitationPerc As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_habitation As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_CardNo As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_IsEngFarm As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_TaxFarmEng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsstipendInsurance As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpCompany As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_EmpHelth As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_stipendInsurance As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_WorkableEmp As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CleanerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OldSlitSalary As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_STindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Tindex As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsManager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ManagerTax As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoTax As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_DeathAssist As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_AssistBox As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Slave_SolidaritySocial As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_EmpClass As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsSoldur As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_NoSalaryDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_salarysame As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_mutableClass As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Original_mutable As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationDays As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Night As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_drive As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_IsContract As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_CenterID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_HealthVacationCost As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_SpecializeID As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Qhelp As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_retirefarmeng As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Spcar As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Amanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Nmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_Pmanager As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_SpHouse As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkValue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkOhr As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkDay As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_OverWorkNight As Nullable(Of [Decimal]) = New Nullable(Of [Decimal])() ' TODO: Initialize to an appropriate value
        Dim Original_IsOverWorkOhr As Nullable(Of Boolean) = New Nullable(Of Boolean)() ' TODO: Initialize to an appropriate value
        Dim Original_ForecTopWvalue As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Specialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_TypeSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_Authority As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim Original_ReturnSpecialize As Nullable(Of Integer) = New Nullable(Of Integer)() ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.Delete(Original_EmpID, Original_FinanceID, Original_DirectorateID, Original_OfficeID, Original_Fname, Original_Mname, Original_Lname, Original_agentEmp, Original_SlitSalary, Original_Allowance, Original_RepaymentFamily, Original_RF_HaveWife, Original_RF_child1, Original_RF_child2, Original_RF_child3, Original_RF_OtherChild, Original_IsEngeneer, Original_DangerWork, Original_BacklogReturn, Original_Impulse, Original_Gift, Original_TotalTax, Original_SalaryTax, Original_BacklogRecover, Original_TotalTakeOuts, Original_IsSocialInsurance, Original_SocialInsurance, Original_IsCooperateBox, Original_CooperateBox, Original_ISCooperationWorkers, Original_CooperationWorkers, Original_IsEngCooperation, Original_EngCooperation, Original_IShabitation, Original_IsAssistBox, Original_AssistBox, Original_IsEndService, Original_EndService, Original_AbsenceNumber, Original_absence, Original_IntegratorSolidarity, Original_IsSolidaritySocial, Original_SolidaritySocial, Original_SportClup, Original_Incubation, Original_Typo, Original_IsDeathAssist, Original_DeathAssist, Original_HoldServiceDate, Original_HS_Total, Original_HS_Mounths, Original_HS_Discount, Original_Datepenalty, Original_P_Total, Original_P_Mounths, Original_P_Discount, Original_DiscountTaskDate, Original_DT_Total, Original_DT_Mounts, Original_DT_Discount, Original_RodDate, Original_R_Total, Original_R_Mounths, Original_R_Discount, Original_CooperationLoanDate, Original_CL_Total, Original_CL_Mounths, Original_CL_Discount, Original_WorkersLoanDate, Original_WL_Total, Original_WL_Mounts, Original_WL_Discount, Original_EngCooperationTaxDate, Original_ECT_Total, Original_ECT_Mounts, Original_ECT_Discount, Original_AkariBankDate, Original_AB_Total, Original_AB_Mounts, Original_AB_Discount, Original_TasleefBankDate, Original_TB_Total, Original_TB_Mounts, Original_TB_Discount, Original_TawfeerBankDate, Original_TWB_Total, Original_TWB_Mounts, Original_TWB_Discount, Original_TajzahLoanDate, Original_TL_Total, Original_TL_Mounts, Original_TL_Discount, Original_RecoveryDate, Original_RC_Total, Original_RC_Mounts, Original_RC_Discount, Original_FullSalary, Original_SumDiscounts, Original_TotalSalary, Original_SalaryYear, Original_SalaryMount, Original_UserID, Original_CreateDate, Original_LastModify, Original_MarkNo, Original_FullName, Original_ControlID, Original_TSpecialize, Original_TaxationID, Original_SalaryConstants, Original_habitationPerc, Original_habitation, Original_CardNo, Original_IsEngFarm, Original_TaxFarmEng, Original_IsstipendInsurance, Original_EmpCompany, Original_EmpHelth, Original_stipendInsurance, Original_WorkableEmp, Original_CleanerTax, Original_OldSlitSalary, Original_STindex, Original_Tindex, Original_IsManager, Original_ManagerTax, Original_NoTax, Original_Slave_DeathAssist, Original_Slave_AssistBox, Original_Slave_SolidaritySocial, Original_EmpClass, Original_IsSoldur, Original_NoSalaryCost, Original_NoSalaryDays, Original_salarysame, Original_mutableCost, Original_mutableDays, Original_mutableClass, Original_mutable, Original_HealthVacationDays, Original_Night, Original_drive, Original_IsContract, Original_CenterID, Original_HealthVacationCost, Original_TypeSpecializeID, Original_SpecializeID, Original_Qhelp, Original_retirefarmeng, Original_Spcar, Original_Amanager, Original_Nmanager, Original_Pmanager, Original_SpHouse, Original_OverWorkValue, Original_OverWorkOhr, Original_OverWorkDay, Original_OverWorkNight, Original_IsOverWorkOhr, Original_ForecTopWvalue, Original_Specialize, Original_TypeSpecialize, Original_Authority, Original_ReturnSpecialize)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for SalaryRecordsTableAdapter Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub SalaryRecordsTableAdapterConstructorTest()
        Dim target As SalaryRecordsTableAdapter = New SalaryRecordsTableAdapter()
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
