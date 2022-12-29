Imports System.Data.SqlTypes

Public Class Evaluations
    Private _id As Integer
    Private _grade As Double
    Private _student_id As Integer
    Private _ECUE_id As Integer
    Private _date_field As Date
    Private _weight_field As Double
    Private _type_field As String

    Public Sub New(id As Integer, grade As Double, student_id As Integer, eCUE_id As Integer, date_field As Date, weight_field As Double, type_field As String)
        Me.Id = id
        Me.Grade = grade
        Me.Student_id = student_id
        Me.ECUE_id = eCUE_id
        Me.Date_field = date_field
        Me.Weight_field = weight_field
        Me.Type_field = type_field
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Grade As Double
        Get
            Return _grade
        End Get
        Set(value As Double)
            _grade = value
        End Set
    End Property

    Public Property Student_id As Integer
        Get
            Return _student_id
        End Get
        Set(value As Integer)
            _student_id = value
        End Set
    End Property

    Public Property ECUE_id As Integer
        Get
            Return _ECUE_id
        End Get
        Set(value As Integer)
            _ECUE_id = value
        End Set
    End Property

    Public Property Date_field As Date
        Get
            Return _date_field
        End Get
        Set(value As Date)
            _date_field = value
        End Set
    End Property

    Public Property Weight_field As Double
        Get
            Return _weight_field
        End Get
        Set(value As Double)
            _weight_field = value
        End Set
    End Property

    Public Property Type_field As String
        Get
            Return _type_field
        End Get
        Set(value As String)
            _type_field = value
        End Set
    End Property
End Class
