<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patron
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
        Me.addPatronMenubtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addPatronMenubtn
        '
        Me.addPatronMenubtn.Location = New System.Drawing.Point(50, 94)
        Me.addPatronMenubtn.Name = "addPatronMenubtn"
        Me.addPatronMenubtn.Size = New System.Drawing.Size(161, 57)
        Me.addPatronMenubtn.TabIndex = 0
        Me.addPatronMenubtn.Text = "Add Patron"
        Me.addPatronMenubtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 57)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "List of Patron"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Patron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addPatronMenubtn)
        Me.Name = "Patron"
        Me.Text = "Patron"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addPatronMenubtn As Button
    Friend WithEvents Button2 As Button
End Class
