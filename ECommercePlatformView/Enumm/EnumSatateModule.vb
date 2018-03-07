Public Module EnumSatateModule
    Public Enum stateOperation
        Insert = 0
        Update = 1
        Delete = 2
        View = 3
    End Enum
    Public Enum stateLoad
        Dialogo = 0
        List = 1
        View = 2
    End Enum
    Public Enum stateClient
        Admin = 0
        User = 1
        Cliente = 2
    End Enum
    Public Enum stateReturn
        _nothing = 0
        _response = 1
    End Enum
    Public Enum viewLoadReport
        Select_ = 0
        All = 1
        Latest = 2
        Select_Id = 3
    End Enum
    Public StateOpenShow As stateOperation

    Public Enum TypeData
        Commeerce = 0
        Owner = 1
        All = 2
    End Enum
End Module
