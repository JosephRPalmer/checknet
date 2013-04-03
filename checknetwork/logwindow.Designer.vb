<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logwindow
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
        Me.logwindo = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Clearlog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logwindo
        '
        Me.logwindo.Location = New System.Drawing.Point(12, 12)
        Me.logwindo.Name = "logwindo"
        Me.logwindo.Size = New System.Drawing.Size(260, 237)
        Me.logwindo.TabIndex = 0
        Me.logwindo.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Clearlog
        '
        Me.Clearlog.Location = New System.Drawing.Point(13, 256)
        Me.Clearlog.Name = "Clearlog"
        Me.Clearlog.Size = New System.Drawing.Size(259, 23)
        Me.Clearlog.TabIndex = 2
        Me.Clearlog.Text = "Clear Log"
        Me.Clearlog.UseVisualStyleBackColor = True
        '
        'logwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 321)
        Me.Controls.Add(Me.Clearlog)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logwindo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "logwindow"
        Me.Text = "Log"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logwindo As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Clearlog As System.Windows.Forms.Button
End Class
