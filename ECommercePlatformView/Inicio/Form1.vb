Imports BrightIdeasSoftware

Public Class Form1
    Dim masterList As List(Of Person)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        masterList = New List(Of Person)
        data()
        initializaComun()

        FastObjectListView1.SetObjects(masterList)
    End Sub

    Private Sub initializaComun()
        FastObjectListView1.CheckBoxes = True
        FastObjectListView1.TriStateCheckBoxes = True

        olvColumn26.AspectGetter = Function(ByVal x As Object) (CType(x, Person)).CulinaryRating
        olvColumn26.Renderer = New MultiImageRenderer(My.Resources.Action_Delete_16x16, 5, 0, 40)

        olvColumn18.AspectGetter = Function(ByVal x As Object) (CType(x, Person)).Name

        olvColumn31.AspectGetter = Function(ByVal row As Object)
                                       If (CType(row, Person)).GetRate() < 100 Then Return "Little"
                                       If (CType(row, Person)).GetRate() > 1000 Then Return "Lots"
                                       Return "Medium"
                                   End Function

        olvColumn31.Renderer = New MappedImageRenderer(New Object() {"Little", My.Resources.Action_Delete_16x16, "Medium", My.Resources.Action_Printing_Print_16x16, "Lots", My.Resources.Action_Delete_12x12})

    End Sub

    Private Sub data()

        masterList.Add(New Person("Wilhelm Frat", "Gymnast", 21, New DateTime(1984, 9, 23), 45.67, False, "ak", "Aggressive, belligerent "))
        masterList.Add(New Person("Alana Roderick", "Gymnast", 21, New DateTime(1974, 9, 23), 245.67, False, "gp", "Beautiful, exquisite"))
        masterList.Add(New Person("Frank Price", "Dancer", 30, New DateTime(1965, 11, 1), 75.5, False, "ns", "Competitive, spirited"))
        masterList.Add(New Person("Eric", "Half-a-bee", 1, New DateTime(1966, 10, 12), 12.25, True, "cp", "Diminutive, vertically challenged"))
        masterList.Add(New Person("Nicola Scotts", "Nurse", 42, New DateTime(1965, 10, 29), 1245.7, False, "np", "Wise, fun, lovely"))
        masterList.Add(New Person("Madalene Alright", "School Teacher", 21, New DateTime(1964, 9, 23), 145.67, False, "jr", "Extensive, dimensionally challenged"))
        masterList.Add(New Person("Ned Peirce", "School Teacher", 21, New DateTime(1960, 1, 23), 145.67, False, "gab", "Fulsome, effusive"))
        masterList.Add(New Person("Felicity Brown", "Economist", 30, New DateTime(1975, 1, 12), 175.5, False, "sp", "Gifted, exceptional"))
        masterList.Add(New Person("Urny Unmin", "Economist", 41, New DateTime(1956, 9, 24), 212.25, True, "cr", "Heinous, aesthetically challenged"))
        masterList.Add(New Person("Terrance Darby", "Singer", 35, New DateTime(1970, 9, 29), 1145, False, "mb", "Introverted, relationally challenged"))
        masterList.Add(New Person("Phillip Nottingham", "Programmer", 27, New DateTime(1974, 8, 28), 245.7, False, "sj", "Jocular, gregarious"))
        masterList.Add(New Person("Mister Null"))

    End Sub

End Class