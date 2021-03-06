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

	Partial Public Class Order
		Public Sub New()
			Me.Order_Details = New HashSet(Of Order_Detail)()
		End Sub

		Private privateOrderID As Integer
		Public Property OrderID() As Integer
			Get
				Return privateOrderID
			End Get
			Set(ByVal value As Integer)
				privateOrderID = value
			End Set
		End Property
		Private privateCustomerID As String
		Public Property CustomerID() As String
			Get
				Return privateCustomerID
			End Get
			Set(ByVal value As String)
				privateCustomerID = value
			End Set
		End Property
		Private privateEmployeeID As Nullable(Of Integer)
		Public Property EmployeeID() As Nullable(Of Integer)
			Get
				Return privateEmployeeID
			End Get
			Set(ByVal value As Nullable(Of Integer))
				privateEmployeeID = value
			End Set
		End Property
		Private privateOrderDate As Nullable(Of System.DateTime)
		Public Property OrderDate() As Nullable(Of System.DateTime)
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				privateOrderDate = value
			End Set
		End Property
		Private privateRequiredDate As Nullable(Of System.DateTime)
		Public Property RequiredDate() As Nullable(Of System.DateTime)
			Get
				Return privateRequiredDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				privateRequiredDate = value
			End Set
		End Property
		Private privateShippedDate As Nullable(Of System.DateTime)
		Public Property ShippedDate() As Nullable(Of System.DateTime)
			Get
				Return privateShippedDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				privateShippedDate = value
			End Set
		End Property
		Private privateShipVia As Nullable(Of Integer)
		Public Property ShipVia() As Nullable(Of Integer)
			Get
				Return privateShipVia
			End Get
			Set(ByVal value As Nullable(Of Integer))
				privateShipVia = value
			End Set
		End Property
		Private privateFreight As Nullable(Of Decimal)
		Public Property Freight() As Nullable(Of Decimal)
			Get
				Return privateFreight
			End Get
			Set(ByVal value As Nullable(Of Decimal))
				privateFreight = value
			End Set
		End Property
		Private privateShipName As String
		Public Property ShipName() As String
			Get
				Return privateShipName
			End Get
			Set(ByVal value As String)
				privateShipName = value
			End Set
		End Property
		Private privateShipAddress As String
		Public Property ShipAddress() As String
			Get
				Return privateShipAddress
			End Get
			Set(ByVal value As String)
				privateShipAddress = value
			End Set
		End Property
		Private privateShipCity As String
		Public Property ShipCity() As String
			Get
				Return privateShipCity
			End Get
			Set(ByVal value As String)
				privateShipCity = value
			End Set
		End Property
		Private privateShipRegion As String
		Public Property ShipRegion() As String
			Get
				Return privateShipRegion
			End Get
			Set(ByVal value As String)
				privateShipRegion = value
			End Set
		End Property
		Private privateShipPostalCode As String
		Public Property ShipPostalCode() As String
			Get
				Return privateShipPostalCode
			End Get
			Set(ByVal value As String)
				privateShipPostalCode = value
			End Set
		End Property
		Private privateShipCountry As String
		Public Property ShipCountry() As String
			Get
				Return privateShipCountry
			End Get
			Set(ByVal value As String)
				privateShipCountry = value
			End Set
		End Property

		Private privateCustomer As Customer
		Public Overridable Property Customer() As Customer
			Get
				Return privateCustomer
			End Get
			Set(ByVal value As Customer)
				privateCustomer = value
			End Set
		End Property
		Private privateEmployee As Employee
		Public Overridable Property Employee() As Employee
			Get
				Return privateEmployee
			End Get
			Set(ByVal value As Employee)
				privateEmployee = value
			End Set
		End Property
		Private privateOrder_Details As ICollection(Of Order_Detail)
		Public Overridable Property Order_Details() As ICollection(Of Order_Detail)
			Get
				Return privateOrder_Details
			End Get
			Set(ByVal value As ICollection(Of Order_Detail))
				privateOrder_Details = value
			End Set
		End Property
		Private privateShipper As Shipper
		Public Overridable Property Shipper() As Shipper
			Get
				Return privateShipper
			End Get
			Set(ByVal value As Shipper)
				privateShipper = value
			End Set
		End Property
	End Class
End Namespace
