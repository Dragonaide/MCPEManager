Imports System
Imports System.IO
Module WorldManager
    Function MCPEWorld(root As String) As Directory
        If Not Directory.Exists(root) Then
            Directory.CreateDirectory(root)
            Directory.CreateDirectory(root + "db")
            Directory.CreateDirectory(root + "resource_packs")
            Directory.CreateDirectory(root + "behavior_packs")
        End If
    End Function
End Module
