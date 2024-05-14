<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchingfrm
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
        Me.listbox = New System.Windows.Forms.ListBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnlinear = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lblenter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listbox
        '
        Me.listbox.FormattingEnabled = True
        Me.listbox.ItemHeight = 16
        Me.listbox.Location = New System.Drawing.Point(99, 37)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(120, 164)
        Me.listbox.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(507, 37)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(177, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Data from external file"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnlinear
        '
        Me.btnlinear.Location = New System.Drawing.Point(316, 199)
        Me.btnlinear.Name = "btnlinear"
        Me.btnlinear.Size = New System.Drawing.Size(123, 42)
        Me.btnlinear.TabIndex = 3
        Me.btnlinear.Text = "Linear search from used data"
        Me.btnlinear.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(316, 263)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(123, 43)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "Binary search from user data"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(96, 225)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 16)
        Me.lbl1.TabIndex = 5
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(632, 263)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(124, 22)
        Me.txt1.TabIndex = 6
        Me.txt1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblenter
        '
        Me.lblenter.AutoSize = True
        Me.lblenter.Location = New System.Drawing.Point(504, 266)
        Me.lblenter.Name = "lblenter"
        Me.lblenter.Size = New System.Drawing.Size(114, 16)
        Me.lblenter.TabIndex = 7
        Me.lblenter.Text = "Enter no to search"
        '
        'searchingfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblenter)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnlinear)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.listbox)
        Me.Name = "searchingfrm"
        Me.Text = "Form_searching"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listbox As ListBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btnlinear As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lblenter As Label
End Class
