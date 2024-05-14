<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sorting
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
        Me.btnsort = New System.Windows.Forms.Button()
        Me.ListBoxsort = New System.Windows.Forms.ListBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsort
        '
        Me.btnsort.Location = New System.Drawing.Point(67, 83)
        Me.btnsort.Name = "btnsort"
        Me.btnsort.Size = New System.Drawing.Size(110, 23)
        Me.btnsort.TabIndex = 0
        Me.btnsort.Text = "Bubblesorting"
        Me.btnsort.UseVisualStyleBackColor = True
        '
        'ListBoxsort
        '
        Me.ListBoxsort.FormattingEnabled = True
        Me.ListBoxsort.ItemHeight = 16
        Me.ListBoxsort.Location = New System.Drawing.Point(448, 111)
        Me.ListBoxsort.Name = "ListBoxsort"
        Me.ListBoxsort.Size = New System.Drawing.Size(120, 84)
        Me.ListBoxsort.TabIndex = 1
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(67, 156)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(110, 23)
        Me.btninsert.TabIndex = 2
        Me.btninsert.Text = "insertion sort"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(67, 244)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(120, 23)
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.Text = "main menu"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'sorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.ListBoxsort)
        Me.Controls.Add(Me.btnsort)
        Me.Name = "sorting"
        Me.Text = "sorting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnsort As Button
    Friend WithEvents ListBoxsort As ListBox
    Friend WithEvents btninsert As Button
    Friend WithEvents btnmenu As Button
End Class
