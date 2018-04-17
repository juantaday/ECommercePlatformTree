Imports System.Runtime.InteropServices
Imports System
Imports System.Text
Public Class TrialClass
    <DllImport("Trial.dll", EntryPoint:="ReadSettingsStr", CharSet:=CharSet.Ansi)>
    Private Shared Function InitTrial(ByVal akeyCode As String, ByVal aHWnd As IntPtr) As UInteger
    End Function

    <DllImport("Trial.dll", EntryPoint:="DisplayRegistrationStr", CharSet:=CharSet.Ansi)>
    Private Shared Function DisplayRegistration(ByVal akeyCode As String, ByVal aHWnd As IntPtr) As UInteger
    End Function

    <DllImport("Trial.dll", EntryPoint:="DisplayRegistrationStr", CharSet:=CharSet.Ansi)>
    Private Shared Function GetPropertyValue(ByVal aPropName As String, ByVal aResult As StringBuilder,
      ByRef aResultLen As UInt32) As UInteger

    End Function

    Private Shared klibraryKey As String = "CBC1BE2B5A6F9A925C71A548C3918E671D5386C906D5EC0773731E25FC8F1892F110940BC30D"
    Private registered As Boolean
    Public Function OnInit() As Boolean
        Try
            Dim Process As Process = Process.GetCurrentProcess()
            InitTrial(klibraryKey, Process.MainWindowHandle)
            Return True
        Catch ex As DllNotFoundException
            MessageBox.Show(ex.ToString())
            Process.GetCurrentProcess().Kill()
            Return False
        Catch ex1 As Exception
            MessageBox.Show(ex1.ToString())
            Return False
        End Try
    End Function
End Class
