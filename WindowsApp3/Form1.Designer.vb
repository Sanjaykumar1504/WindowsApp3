<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.sortbtn1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.searchbtn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sortbtn1
        '
        Me.sortbtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortbtn1.Location = New System.Drawing.Point(306, 214)
        Me.sortbtn1.Name = "sortbtn1"
        Me.sortbtn1.Size = New System.Drawing.Size(132, 34)
        Me.sortbtn1.TabIndex = 1
        Me.sortbtn1.Text = "Sorting "
        Me.sortbtn1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(253, 90)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(258, 28)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Welocme to my first page"
        '
        'searchbtn1
        '
        Me.searchbtn1.Location = New System.Drawing.Point(306, 283)
        Me.searchbtn1.Name = "searchbtn1"
        Me.searchbtn1.Size = New System.Drawing.Size(132, 33)
        Me.searchbtn1.TabIndex = 6
        Me.searchbtn1.Text = "Searching"
        Me.searchbtn1.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.searchbtn1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.sortbtn1)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sortbtn1 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents searchbtn1 As Button
End Class
