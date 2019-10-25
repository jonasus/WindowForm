<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tag
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
        Me.btnAddTag = New System.Windows.Forms.Button()
        Me.btnViewTag = New System.Windows.Forms.Button()
        Me.AssignTag = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddTag
        '
        Me.btnAddTag.Location = New System.Drawing.Point(42, 171)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(180, 49)
        Me.btnAddTag.TabIndex = 0
        Me.btnAddTag.Text = "Add Tag"
        Me.btnAddTag.UseVisualStyleBackColor = True
        '
        'btnViewTag
        '
        Me.btnViewTag.Location = New System.Drawing.Point(291, 171)
        Me.btnViewTag.Name = "btnViewTag"
        Me.btnViewTag.Size = New System.Drawing.Size(180, 49)
        Me.btnViewTag.TabIndex = 1
        Me.btnViewTag.Text = "View Tags"
        Me.btnViewTag.UseVisualStyleBackColor = True
        '
        'AssignTag
        '
        Me.AssignTag.Location = New System.Drawing.Point(532, 171)
        Me.AssignTag.Name = "AssignTag"
        Me.AssignTag.Size = New System.Drawing.Size(180, 49)
        Me.AssignTag.TabIndex = 2
        Me.AssignTag.Text = "Assign Tags"
        Me.AssignTag.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(42, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 29)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Tag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.AssignTag)
        Me.Controls.Add(Me.btnViewTag)
        Me.Controls.Add(Me.btnAddTag)
        Me.Name = "Tag"
        Me.Text = "Tag"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddTag As Button
    Friend WithEvents btnViewTag As Button
    Friend WithEvents AssignTag As Button
    Friend WithEvents btnBack As Button
End Class
