﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="LGT_FOOD_NEW")>  _
Partial Public Class THAIDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertMAS_FAFDTYPE_NEW(instance As MAS_FAFDTYPE_NEW)
    End Sub
  Partial Private Sub UpdateMAS_FAFDTYPE_NEW(instance As MAS_FAFDTYPE_NEW)
    End Sub
  Partial Private Sub DeleteMAS_FAFDTYPE_NEW(instance As MAS_FAFDTYPE_NEW)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("LGT_FOOD_NEWConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property syschngwts() As System.Data.Linq.Table(Of syschngwt)
		Get
			Return Me.GetTable(Of syschngwt)
		End Get
	End Property
	
	Public ReadOnly Property MAS_FAFDTYPE_NEWs() As System.Data.Linq.Table(Of MAS_FAFDTYPE_NEW)
		Get
			Return Me.GetTable(Of MAS_FAFDTYPE_NEW)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="fda.syschngwt")>  _
Partial Public Class syschngwt
	
	Private _chngwtcd As Short
	
	Private _thachngwtnm As String
	
	Private _engchngwtnm As String
	
	Private _thacwabbr As String
	
	Private _engcwabbr As String
	
	Private _mapgis As System.Nullable(Of Short)
	
	Private _chngwtgrpcd As System.Nullable(Of Short)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_chngwtcd", DbType:="SmallInt NOT NULL")>  _
	Public Property chngwtcd() As Short
		Get
			Return Me._chngwtcd
		End Get
		Set
			If ((Me._chngwtcd = value)  _
						= false) Then
				Me._chngwtcd = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_thachngwtnm", DbType:="VarChar(120) NOT NULL", CanBeNull:=false)>  _
	Public Property thachngwtnm() As String
		Get
			Return Me._thachngwtnm
		End Get
		Set
			If (String.Equals(Me._thachngwtnm, value) = false) Then
				Me._thachngwtnm = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_engchngwtnm", DbType:="VarChar(120)")>  _
	Public Property engchngwtnm() As String
		Get
			Return Me._engchngwtnm
		End Get
		Set
			If (String.Equals(Me._engchngwtnm, value) = false) Then
				Me._engchngwtnm = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_thacwabbr", DbType:="VarChar(5)")>  _
	Public Property thacwabbr() As String
		Get
			Return Me._thacwabbr
		End Get
		Set
			If (String.Equals(Me._thacwabbr, value) = false) Then
				Me._thacwabbr = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_engcwabbr", DbType:="VarChar(5)")>  _
	Public Property engcwabbr() As String
		Get
			Return Me._engcwabbr
		End Get
		Set
			If (String.Equals(Me._engcwabbr, value) = false) Then
				Me._engcwabbr = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_mapgis", DbType:="SmallInt")>  _
	Public Property mapgis() As System.Nullable(Of Short)
		Get
			Return Me._mapgis
		End Get
		Set
			If (Me._mapgis.Equals(value) = false) Then
				Me._mapgis = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_chngwtgrpcd", DbType:="SmallInt")>  _
	Public Property chngwtgrpcd() As System.Nullable(Of Short)
		Get
			Return Me._chngwtgrpcd
		End Get
		Set
			If (Me._chngwtgrpcd.Equals(value) = false) Then
				Me._chngwtgrpcd = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.MAS_FAFDTYPE_NEW")>  _
Partial Public Class MAS_FAFDTYPE_NEW
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _fdtypecd As System.Nullable(Of Integer)
	
	Private _fdtypename As String
	
	Private _engnm As String
	
	Private _fdtype_name_display As String
	
	Private _process_id As String
	
	Private _active As System.Nullable(Of Integer)
	
	Private _edit As System.Nullable(Of Integer)
	
	Private _fdtypecd_main As String
	
	Private _fdtypecd_show As String
	
	Private _ida As Integer
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnfdtypecdChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnfdtypecdChanged()
    End Sub
    Partial Private Sub OnfdtypenameChanging(value As String)
    End Sub
    Partial Private Sub OnfdtypenameChanged()
    End Sub
    Partial Private Sub OnengnmChanging(value As String)
    End Sub
    Partial Private Sub OnengnmChanged()
    End Sub
    Partial Private Sub Onfdtype_name_displayChanging(value As String)
    End Sub
    Partial Private Sub Onfdtype_name_displayChanged()
    End Sub
    Partial Private Sub Onprocess_idChanging(value As String)
    End Sub
    Partial Private Sub Onprocess_idChanged()
    End Sub
    Partial Private Sub OnactiveChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnactiveChanged()
    End Sub
    Partial Private Sub OneditChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OneditChanged()
    End Sub
    Partial Private Sub Onfdtypecd_mainChanging(value As String)
    End Sub
    Partial Private Sub Onfdtypecd_mainChanged()
    End Sub
    Partial Private Sub Onfdtypecd_showChanging(value As String)
    End Sub
    Partial Private Sub Onfdtypecd_showChanged()
    End Sub
    Partial Private Sub OnidaChanging(value As Integer)
    End Sub
    Partial Private Sub OnidaChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fdtypecd", DbType:="Int")>  _
	Public Property fdtypecd() As System.Nullable(Of Integer)
		Get
			Return Me._fdtypecd
		End Get
		Set
			If (Me._fdtypecd.Equals(value) = false) Then
				Me.OnfdtypecdChanging(value)
				Me.SendPropertyChanging
				Me._fdtypecd = value
				Me.SendPropertyChanged("fdtypecd")
				Me.OnfdtypecdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fdtypename", DbType:="NVarChar(MAX)")>  _
	Public Property fdtypename() As String
		Get
			Return Me._fdtypename
		End Get
		Set
			If (String.Equals(Me._fdtypename, value) = false) Then
				Me.OnfdtypenameChanging(value)
				Me.SendPropertyChanging
				Me._fdtypename = value
				Me.SendPropertyChanged("fdtypename")
				Me.OnfdtypenameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_engnm", DbType:="NVarChar(MAX)")>  _
	Public Property engnm() As String
		Get
			Return Me._engnm
		End Get
		Set
			If (String.Equals(Me._engnm, value) = false) Then
				Me.OnengnmChanging(value)
				Me.SendPropertyChanging
				Me._engnm = value
				Me.SendPropertyChanged("engnm")
				Me.OnengnmChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fdtype_name_display", DbType:="NVarChar(MAX)")>  _
	Public Property fdtype_name_display() As String
		Get
			Return Me._fdtype_name_display
		End Get
		Set
			If (String.Equals(Me._fdtype_name_display, value) = false) Then
				Me.Onfdtype_name_displayChanging(value)
				Me.SendPropertyChanging
				Me._fdtype_name_display = value
				Me.SendPropertyChanged("fdtype_name_display")
				Me.Onfdtype_name_displayChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_process_id", DbType:="NVarChar(10)")>  _
	Public Property process_id() As String
		Get
			Return Me._process_id
		End Get
		Set
			If (String.Equals(Me._process_id, value) = false) Then
				Me.Onprocess_idChanging(value)
				Me.SendPropertyChanging
				Me._process_id = value
				Me.SendPropertyChanged("process_id")
				Me.Onprocess_idChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_active", DbType:="Int")>  _
	Public Property active() As System.Nullable(Of Integer)
		Get
			Return Me._active
		End Get
		Set
			If (Me._active.Equals(value) = false) Then
				Me.OnactiveChanging(value)
				Me.SendPropertyChanging
				Me._active = value
				Me.SendPropertyChanged("active")
				Me.OnactiveChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_edit", DbType:="Int")>  _
	Public Property edit() As System.Nullable(Of Integer)
		Get
			Return Me._edit
		End Get
		Set
			If (Me._edit.Equals(value) = false) Then
				Me.OneditChanging(value)
				Me.SendPropertyChanging
				Me._edit = value
				Me.SendPropertyChanged("edit")
				Me.OneditChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fdtypecd_main", DbType:="NVarChar(10)")>  _
	Public Property fdtypecd_main() As String
		Get
			Return Me._fdtypecd_main
		End Get
		Set
			If (String.Equals(Me._fdtypecd_main, value) = false) Then
				Me.Onfdtypecd_mainChanging(value)
				Me.SendPropertyChanging
				Me._fdtypecd_main = value
				Me.SendPropertyChanged("fdtypecd_main")
				Me.Onfdtypecd_mainChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fdtypecd_show", DbType:="NVarChar(MAX)")>  _
	Public Property fdtypecd_show() As String
		Get
			Return Me._fdtypecd_show
		End Get
		Set
			If (String.Equals(Me._fdtypecd_show, value) = false) Then
				Me.Onfdtypecd_showChanging(value)
				Me.SendPropertyChanging
				Me._fdtypecd_show = value
				Me.SendPropertyChanged("fdtypecd_show")
				Me.Onfdtypecd_showChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ida", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ida() As Integer
		Get
			Return Me._ida
		End Get
		Set
			If ((Me._ida = value)  _
						= false) Then
				Me.OnidaChanging(value)
				Me.SendPropertyChanging
				Me._ida = value
				Me.SendPropertyChanged("ida")
				Me.OnidaChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
