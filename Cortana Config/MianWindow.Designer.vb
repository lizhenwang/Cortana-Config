<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MianWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MianWindow))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_enable = New System.Windows.Forms.Button()
        Me.btn_disable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_astudio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_title.Size = New System.Drawing.Size(306, 19)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Cortana 可以提供建议、想法、提醒、通知等。"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_enable
        '
        Me.btn_enable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_enable.Location = New System.Drawing.Point(32, 35)
        Me.btn_enable.Name = "btn_enable"
        Me.btn_enable.Size = New System.Drawing.Size(116, 30)
        Me.btn_enable.TabIndex = 1
        Me.btn_enable.Text = "启用Cortana"
        Me.btn_enable.UseVisualStyleBackColor = True
        '
        'btn_disable
        '
        Me.btn_disable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_disable.Location = New System.Drawing.Point(154, 35)
        Me.btn_disable.Name = "btn_disable"
        Me.btn_disable.Size = New System.Drawing.Size(116, 30)
        Me.btn_disable.TabIndex = 2
        Me.btn_disable.Text = "关闭Cortana"
        Me.btn_disable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 85)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "关闭 Cortana 会清除 Cortana 知道的此设备上的内容，但不会删除笔记本的任何内容。关闭 Cortana 以后，你就可以决定如何处理仍储存在云中的内容" &
    "了。"
        '
        'lbl_astudio
        '
        Me.lbl_astudio.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_astudio.Location = New System.Drawing.Point(7, 163)
        Me.lbl_astudio.Name = "lbl_astudio"
        Me.lbl_astudio.Size = New System.Drawing.Size(302, 30)
        Me.lbl_astudio.TabIndex = 4
        Me.lbl_astudio.Text = "lizhenwang.com Production"
        Me.lbl_astudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MianWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 196)
        Me.Controls.Add(Me.lbl_astudio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_disable)
        Me.Controls.Add(Me.btn_enable)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "MianWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MianWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents btn_enable As Windows.Forms.Button
    Friend WithEvents btn_disable As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbl_astudio As Label
End Class
