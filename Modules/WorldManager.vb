Imports System
Imports System.IO
Module WorldManager
    Function MCPEWorld(root As String) As System.IO.Directory
        If Not System.IO.Directory.Exists(root) Then
            System.IO.Directory.CreateDirectory(root)
        End If
    End Function
End Module
