Imports System.IO
Imports System.Management
Imports System.Reflection
Imports Bunifu
Imports Microsoft.VisualBasic.ApplicationServices
Public Module Cor
    Private _initialized As Boolean
    Public Sub EnsureInitialized()
        If Not _initialized Then
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf AssemblyResolve
            _initialized = True
        End If
    End Sub
    Private Function AssemblyResolve(ByVal sender As Object, ByVal e As ResolveEventArgs) As Assembly
        Dim resourceFullName As String = String.Format("Bunifu_UI_v1.5.3.dll", e.Name.Split(","c)(0))
        Dim thisAssembly As Assembly = Assembly.GetExecutingAssembly()
        Using resource As Stream = thisAssembly.GetManifestResourceStream(resourceFullName)
            If resource IsNot Nothing Then Return Assembly.Load(ToBytes(resource))
            Return Nothing
        End Using
    End Function
    Private Function ToBytes(ByVal instance As Stream) As Byte()
        Dim capacity As Integer = If(instance.CanSeek, Convert.ToInt32(instance.Length), 0)
        Using result As New MemoryStream(capacity)
            Dim readLength As Integer
            Dim buffer(4096) As Byte
            Do
                readLength = instance.Read(buffer, 0, buffer.Length)
                result.Write(buffer, 0, readLength)
            Loop While readLength > 0
            Return result.ToArray()
        End Using
    End Function
End Module

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogBox2.Text = ""
    End Sub

    Private Sub activateWindows_Click(sender As Object, e As EventArgs) Handles activateWindows.Click
        LogBox2.Text = ""
        activateWindows.Enabled = False
        LogBox2.ScrollBars = ScrollBars.Vertical
        Dim Proc As Process
        Proc = Process.Start(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/AutoPico.exe"))
        Dim read As IO.StreamReader
        read = IO.File.OpenText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/logs/AutoPico.log"))
        LogBox2.Text = read.ReadToEnd()
        read.Close()
        Dim b As String() = Split(LogBox2.Text, vbNewLine)
        LogBox2.Text = String.Join(vbNewLine, b, 0, b.Length - 1)
        LogBox2.SelectionStart = LogBox2.Text.Length
        LogBox2.ScrollToCaret()
        activateWindows.Text = "Done"
    End Sub

    Private Sub checkActivation_Click(sender As Object, e As EventArgs) Handles checkActivation.Click
        checkActivation.Enabled = False
        checkActivation.Text = "Working..."
        Try
            Dim searcher As New ManagementObjectSearcher(
                  "root\CIMV2",
                  "SELECT * FROM SoftwareLicensingProduct WHERE LicenseStatus = 1")
            Dim myCollection As ManagementObjectCollection
            Dim myObject As ManagementObject
            myCollection = searcher.Get()
            If myCollection.Count = 0 Then
                checkActivation.Textcolor = Color.Red
                checkActivation.Text = "Windows is not activated"
                searcher.Dispose()
            Else
                For Each myObject In myCollection
                    checkActivation.Textcolor = Color.LightGreen
                    checkActivation.Text = "Windows is activated"
                    searcher.Dispose()
                Next
            End If
            searcher.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
        End
    End Sub

    Private Sub enableSmartscreen_Click(sender As Object, e As EventArgs) Handles enableSmartscreen.Click
        LogBox2.Text = ""
        enableSmartscreen.Enabled = False
        Dim regeditProcess As Process = Process.Start("regedit.exe", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/s Resources/registery/EnableSmartScreen.reg"))
        Dim read As IO.StreamReader
        read = IO.File.OpenText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/registery/EnableSmartScreen.reg"))
        LogBox2.Text = read.ReadToEnd()
        read.Close()
        regeditProcess.WaitForExit()
        enableSmartscreen.Text = "Done!"
    End Sub

    Private Sub disableSmartscreen_Click(sender As Object, e As EventArgs) Handles disableSmartscreen.Click
        LogBox2.Text = ""
        disableSmartscreen.Enabled = False
        Dim regeditProcess As Process = Process.Start("regedit.exe", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/s Resources/registery/DisableSmartScreen.reg"))
        Dim read As IO.StreamReader
        read = IO.File.OpenText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/registery/DisableSmartScreen.reg"))
        LogBox2.Text = read.ReadToEnd()
        read.Close()
        regeditProcess.WaitForExit()
        disableSmartscreen.Text = "Done!"
    End Sub

    Private Sub madeBy_Click(sender As Object, e As EventArgs) Handles madeBy.Click
        madeBy.Text = "(ง ͠° ͟ل͜ ͡°)ง"
    End Sub
End Class
