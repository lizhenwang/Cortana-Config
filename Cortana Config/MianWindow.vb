Public Class MianWindow
    Private Sub MianWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        If InStr(LCase(My.Computer.Info.OSFullName), LCase("Windows 10")) = 0 Then
            MessageBox.Show("请在Windows 10上运行本程序！", "错误")
            End
        Else
            WriteReg(True)
        End If
    End Sub

    Public Function RestartExplorer()
        ' 在Windows 10上，explorer.exe被结束后会自动运行。
        Dim p As Process()
        p = Process.GetProcessesByName("explorer")
        For Each a In p
            a.Kill()
        Next
    End Function

    Public Function WriteReg(IsEnable As Boolean)
        Dim reg
        reg = My.Computer.Registry.LocalMachine
        If IsEnable = True Then
            reg.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows\Windows Search")
            reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft\Windows\Windows Search", True)
            reg.SetValue("AllowCortana", "1", Microsoft.Win32.RegistryValueKind.DWord)
        Else
            reg.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows\Windows Search")
            reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft\Windows\Windows Search", True)
            reg.SetValue("AllowCortana", "0", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        reg.Close()
    End Function

    Private Sub btn_enable_Click(sender As Object, e As EventArgs) Handles btn_enable.Click
        WriteReg(True)
        RestartExplorer()
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        WriteReg(False)
        RestartExplorer()
    End Sub



    Private Sub lbl_astudio_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_astudio.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim o As New System.Diagnostics.Process
            o.StartInfo.FileName = "http://www.lizhenwang.com/"
            o.Start()
        End If
    End Sub
End Class