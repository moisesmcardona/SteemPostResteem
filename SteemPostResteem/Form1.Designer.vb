<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.identifier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pk = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Post Identifier:"
        '
        'identifier
        '
        Me.identifier.Location = New System.Drawing.Point(12, 29)
        Me.identifier.Name = "identifier"
        Me.identifier.Size = New System.Drawing.Size(260, 20)
        Me.identifier.TabIndex = 1
        Me.identifier.Text = "@user/link"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Private Posting Key:"
        '
        'pk
        '
        Me.pk.Location = New System.Drawing.Point(11, 114)
        Me.pk.Name = "pk"
        Me.pk.Size = New System.Drawing.Size(261, 20)
        Me.pk.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Resteem!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Account to Resteem the Post:"
        '
        'author
        '
        Me.author.Location = New System.Drawing.Point(11, 75)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(261, 20)
        Me.author.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 202)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.identifier)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "STEEM Post Resteem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents identifier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pk As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents author As TextBox
End Class
