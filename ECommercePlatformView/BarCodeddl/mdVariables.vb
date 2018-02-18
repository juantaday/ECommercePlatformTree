Option Strict Off
Option Explicit On
Module mdVariables
	Public Mdl(2) As Object
	Public MdlLeft As Object

    Function iniciarAr() As Boolean
        Mdl(0) = New Object() {"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"}
        Mdl(1) = New Object() {"0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111"}
        Mdl(2) = New Object() {"1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100"}
        MdlLeft = New Object() {"000000", "001011", "001101", "001110", "010011", "011001", "011100", "010101", "010110", "011010"}
        Return True
    End Function
End Module