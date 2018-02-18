
Imports System.ComponentModel
Imports BrightIdeasSoftware

Class Person
    Implements INotifyPropertyChanged

    Public IsActive As Boolean = True

    Public Sub New(ByVal name As String)
        Me.Name = name
    End Sub

    Public Sub New(ByVal name As String, ByVal occupation As String, ByVal culinaryRating As Integer, ByVal birthDate As DateTime, ByVal hourlyRate As Double, ByVal canTellJokes As Boolean, ByVal photo As String, ByVal comments As String)
        Me._name = name
        Me._occupation = occupation
        Me.CulinaryRating = culinaryRating
        Me.BirthDate = birthDate
        Me.hourlyRate = hourlyRate
        Me.CanTellJokes = canTellJokes
        Me.Comments = comments
        Me.Photo = photo
    End Sub

    Public Sub New(ByVal other As Person)
        Me.Name = other.Name
        Me.Occupation = other.Occupation
        Me.CulinaryRating = other.CulinaryRating
        Me.BirthDate = other.BirthDate
        Me.hourlyRate = other.GetRate()
        Me.CanTellJokes = other.CanTellJokes
        Me.Photo = other.Photo
        Me.Comments = other.Comments
        Me.MaritalStatus = other.MaritalStatus
    End Sub

    <OLVIgnore>
    Public Property ImageAspect As Image
        Get
            Return Global.ECommercePlatformView.My.Resources.Acceso_ok_48
        End Get
        Set(value As Image)
        End Set
    End Property

    <OLVIgnore>
    Public Property ImageName As String
        Get
            Return "user"
        End Get
        Set(value As String)
        End Set
    End Property

    <OLVColumn(ImageAspectName:="ImageName")>
    Public Property Name As String
        Get
            Return _name
        End Get

        Set(ByVal value As String)
            If Name = value Then Return
            _name = value
            Me.OnPropertyChanged("Name")
        End Set
    End Property

    Private _name As String

    <OLVColumn(ImageAspectName:="ImageName")>
    Public Property Occupation As String
        Get
            Return _occupation
        End Get

        Set(ByVal value As String)
            If Occupation = value Then Return
            _occupation = value
            Me.OnPropertyChanged("Occupation")
        End Set
    End Property

    Private _occupation As String

    Public Property CulinaryRating As Integer
        Get
            Return _culinaryRating
        End Get

        Set(ByVal value As Integer)
            _culinaryRating = value
        End Set
    End Property

    Private _culinaryRating As Integer

    Public Property BirthDate As DateTime
        Get
            Return _birthDate
        End Get

        Set(ByVal value As DateTime)
            _birthDate = value
        End Set
    End Property

    Private _birthDate As DateTime

    Public Property YearOfBirth As Integer
        Get
            Return Me.BirthDate.Year
        End Get

        Set(ByVal value As Integer)
            Me.BirthDate = New DateTime(value, BirthDate.Month, BirthDate.Day)
        End Set
    End Property

    Public Function GetRate() As Double
        Return hourlyRate
    End Function

    Private hourlyRate As Double

    Public Sub SetRate(ByVal value As Double)
        hourlyRate = value
    End Sub

    Public Photo As String

    Public Comments As String

    Public serialNumber As Integer

    Public CanTellJokes As Boolean?

    Public MaritalStatus As MaritalStatus = MaritalStatus.Single

    Private Event INotifyPropertyChanged_PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent INotifyPropertyChanged_PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class

Enum MaritalStatus
    [Single]
    Married
    Divorced
    Partnered
End Enum
'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
