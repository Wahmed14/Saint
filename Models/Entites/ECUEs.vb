﻿Public Class ECUEs
    Private _id As Integer
    Private _libelle As String
    Private _credit As Integer
    Private _employee_id As Integer

    Public Sub New(id As Integer, libelle As String, credit As Integer, employee_id As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Credit = credit
        Me.Employee_id = employee_id
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Libelle As String
        Get
            Return _libelle
        End Get
        Set(value As String)
            _libelle = value
        End Set
    End Property

    Public Property Credit As Integer
        Get
            Return _credit
        End Get
        Set(value As Integer)
            _credit = value
        End Set
    End Property

    Public Property Employee_id As Integer
        Get
            Return _employee_id
        End Get
        Set(value As Integer)
            _employee_id = value
        End Set
    End Property
End Class