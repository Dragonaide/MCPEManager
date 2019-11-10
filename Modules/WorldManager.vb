Imports System
Imports System.IO
Module WorldManager
    Function MCPEWorld(root As String) As System.IO.Directory
        If Not System.IO.Directory.Exists(root) Then
            System.IO.Directory.CreateDirectory(root)
            System.IO.Path.Combine(root, "db")
            System.IO.Path.Combine(root, "resource_packs")
            System.IO.Path.Combine(root, "behavior_packs")
            System.IO.Path.Combine(root, "levelname.txt")
            System.IO.File.WriteAllText(root + "/levelname.txt", "My World")
        End If
    End Function
End Module
