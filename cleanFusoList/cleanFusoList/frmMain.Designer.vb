<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbCanada = New System.Windows.Forms.RadioButton()
        Me.rbUS = New System.Windows.Forms.RadioButton()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'rbCanada
        '
        Me.rbCanada.AutoSize = true
        Me.rbCanada.Enabled = false
        Me.rbCanada.Location = New System.Drawing.Point(100, 67)
        Me.rbCanada.Name = "rbCanada"
        Me.rbCanada.Size = New System.Drawing.Size(62, 17)
        Me.rbCanada.TabIndex = 0
        Me.rbCanada.TabStop = true
        Me.rbCanada.Text = "Canada"
        Me.rbCanada.UseVisualStyleBackColor = true
        '
        'rbUS
        '
        Me.rbUS.AutoSize = true
        Me.rbUS.Enabled = false
        Me.rbUS.Location = New System.Drawing.Point(100, 91)
        Me.rbUS.Name = "rbUS"
        Me.rbUS.Size = New System.Drawing.Size(89, 17)
        Me.rbUS.TabIndex = 1
        Me.rbUS.TabStop = true
        Me.rbUS.Text = "United States"
        Me.rbUS.UseVisualStyleBackColor = true
        '
        'tbPath
        '
        Me.tbPath.Enabled = false
        Me.tbPath.Location = New System.Drawing.Point(13, 22)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(161, 20)
        Me.tbPath.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(197, 19)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse.."
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'btnRun
        '
        Me.btnRun.Enabled = false
        Me.btnRun.Location = New System.Drawing.Point(45, 131)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = true
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(156, 131)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 180)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.rbUS)
        Me.Controls.Add(Me.rbCanada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clean CSV Files"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents rbCanada As System.Windows.Forms.RadioButton
    Friend WithEvents rbUS As System.Windows.Forms.RadioButton
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
