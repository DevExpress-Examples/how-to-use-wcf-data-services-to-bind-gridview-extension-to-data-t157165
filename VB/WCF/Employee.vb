'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
Namespace WCF

	Partial Public Class Employee
		Public Sub New()
			Me.Employees1 = New HashSet(Of Employee)()
			Me.Orders = New HashSet(Of Order)()
			Me.Territories = New HashSet(Of Territory)()
		End Sub

		Private privateEmployeeID As Integer
		Public Property EmployeeID() As Integer
			Get
				Return privateEmployeeID
			End Get
			Set(ByVal value As Integer)
				privateEmployeeID = value
			End Set
		End Property
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateTitleOfCourtesy As String
		Public Property TitleOfCourtesy() As String
			Get
				Return privateTitleOfCourtesy
			End Get
			Set(ByVal value As String)
				privateTitleOfCourtesy = value
			End Set
		End Property
		Private privateBirthDate As Nullable(Of System.DateTime)
		Public Property BirthDate() As Nullable(Of System.DateTime)
			Get
				Return privateBirthDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				privateBirthDate = value
			End Set
		End Property
		Private privateHireDate As Nullable(Of System.DateTime)
		Public Property HireDate() As Nullable(Of System.DateTime)
			Get
				Return privateHireDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				privateHireDate = value
			End Set
		End Property
		Private privateAddress As String
		Public Property Address() As String
			Get
				Return privateAddress
			End Get
			Set(ByVal value As String)
				privateAddress = value
			End Set
		End Property
		Private privateCity As String
		Public Property City() As String
			Get
				Return privateCity
			End Get
			Set(ByVal value As String)
				privateCity = value
			End Set
		End Property
		Private privateRegion As String
		Public Property Region() As String
			Get
				Return privateRegion
			End Get
			Set(ByVal value As String)
				privateRegion = value
			End Set
		End Property
		Private privatePostalCode As String
		Public Property PostalCode() As String
			Get
				Return privatePostalCode
			End Get
			Set(ByVal value As String)
				privatePostalCode = value
			End Set
		End Property
		Private privateCountry As String
		Public Property Country() As String
			Get
				Return privateCountry
			End Get
			Set(ByVal value As String)
				privateCountry = value
			End Set
		End Property
		Private privateHomePhone As String
		Public Property HomePhone() As String
			Get
				Return privateHomePhone
			End Get
			Set(ByVal value As String)
				privateHomePhone = value
			End Set
		End Property
		Private privateExtension As String
		Public Property Extension() As String
			Get
				Return privateExtension
			End Get
			Set(ByVal value As String)
				privateExtension = value
			End Set
		End Property
		Private privatePhoto As Byte()
		Public Property Photo() As Byte()
			Get
				Return privatePhoto
			End Get
			Set(ByVal value As Byte())
				privatePhoto = value
			End Set
		End Property
		Private privateNotes As String
		Public Property Notes() As String
			Get
				Return privateNotes
			End Get
			Set(ByVal value As String)
				privateNotes = value
			End Set
		End Property
		Private privateReportsTo As Nullable(Of Integer)
		Public Property ReportsTo() As Nullable(Of Integer)
			Get
				Return privateReportsTo
			End Get
			Set(ByVal value As Nullable(Of Integer))
				privateReportsTo = value
			End Set
		End Property
		Private privatePhotoPath As String
		Public Property PhotoPath() As String
			Get
				Return privatePhotoPath
			End Get
			Set(ByVal value As String)
				privatePhotoPath = value
			End Set
		End Property

		Private privateEmployees1 As ICollection(Of Employee)
		Public Overridable Property Employees1() As ICollection(Of Employee)
			Get
				Return privateEmployees1
			End Get
			Set(ByVal value As ICollection(Of Employee))
				privateEmployees1 = value
			End Set
		End Property
		Private privateEmployee1 As Employee
		Public Overridable Property Employee1() As Employee
			Get
				Return privateEmployee1
			End Get
			Set(ByVal value As Employee)
				privateEmployee1 = value
			End Set
		End Property
		Private privateOrders As ICollection(Of Order)
		Public Overridable Property Orders() As ICollection(Of Order)
			Get
				Return privateOrders
			End Get
			Set(ByVal value As ICollection(Of Order))
				privateOrders = value
			End Set
		End Property
		Private privateTerritories As ICollection(Of Territory)
		Public Overridable Property Territories() As ICollection(Of Territory)
			Get
				Return privateTerritories
			End Get
			Set(ByVal value As ICollection(Of Territory))
				privateTerritories = value
			End Set
		End Property
	End Class
End Namespace