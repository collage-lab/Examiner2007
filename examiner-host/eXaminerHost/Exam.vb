Public Class Exam


    Dim Type_OF_Exam As Integer
    Dim Exam_Started As Boolean
    Dim Exam_Over As Boolean
    Public Enum Time_Manage
        Manual
        Automatic
        TimeSlice
    End Enum
    Public Enum Duration
        Limited
        Unlimited
    End Enum
    Dim _Duration As Duration



    Dim Time_man As Time_Manage
    Public Property TimeManage() As Time_Manage
        Get
            Return Time_man
        End Get
        Set(ByVal value As Time_Manage)
            Time_man = value
        End Set
    End Property
    Public Property ExamDuration() As Duration
        Get
            Return _Duration
        End Get
        Set(ByVal value As Duration)
            _Duration = value
        End Set
    End Property
    Public Property ExamType() As Integer
        Get
            Return Type_OF_Exam
        End Get
        Set(ByVal value As Integer)
            Type_OF_Exam = value
        End Set
    End Property
    Public Property ExamStarted() As Boolean
        Get
            Return Exam_Started
        End Get
        Set(ByVal value As Boolean)
            Exam_Started = value
        End Set
    End Property
    Public Property ExamOver() As Boolean
        Get
            Return Exam_Over
        End Get
        Set(ByVal value As Boolean)
            Exam_Over = value
        End Set
    End Property
End Class
