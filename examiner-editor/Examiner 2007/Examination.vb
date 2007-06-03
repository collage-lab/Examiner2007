Public Class Examination

    Dim TotalQuestions As Integer
    Dim Duration As Integer
    Dim TypeOFExam As Integer
    Dim Server As Boolean
    Dim Uname As String
    Dim RegNo As Integer
    Dim Exam_Started As Boolean
    Dim Current_question As Integer
    Dim Current_Question_Type As Integer
    Dim OPtion_Index As Integer



    Public Property NoOfQuestions() As Integer
        Get
            Return TotalQuestions
        End Get
        Set(ByVal value As Integer)
            TotalQuestions = value
        End Set
    End Property

    Public Property ExamDuration() As Integer
        Get
            Return Duration
        End Get
        Set(ByVal value As Integer)
            Duration = value
        End Set
    End Property

    Public Property ExamType() As Integer
        Get
            Return TypeOFExam
        End Get
        Set(ByVal value As Integer)
            TypeOFExam = value
        End Set
    End Property

    Public Property FromServer() As Boolean
        Get
            Return Server
        End Get
        Set(ByVal value As Boolean)
            Server = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return Uname
        End Get
        Set(ByVal value As String)
            Uname = value
        End Set
    End Property

    Public Property RegisterNo() As Integer
        Get
            Return RegNo
        End Get
        Set(ByVal value As Integer)
            RegNo = value
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

    Public Property CurrentQuestion() As Integer
        Get
            Return Current_question
        End Get
        Set(ByVal value As Integer)
            Current_question = value
        End Set
    End Property

    Public Property CurrentQuestType() As Integer
        Get
            Return Current_Question_Type
        End Get
        Set(ByVal value As Integer)
            Current_Question_Type = value
        End Set
    End Property

    Public Property OptionIndex() As Integer
        Get
            Return OPtion_Index
        End Get
        Set(ByVal value As Integer)
            OPtion_Index = value
        End Set
    End Property

End Class
