<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grdTut = New UJGrid.UJGrid()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 99)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grdTut
        '
        Me.grdTut.FixedCols = 1
        Me.grdTut.FixedRows = 1
        Me.grdTut.Location = New System.Drawing.Point(221, 76)
        Me.grdTut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdTut.Name = "grdTut"
        Me.grdTut.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdTut.Size = New System.Drawing.Size(566, 231)
        Me.grdTut.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(67, 135)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(132, 66)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(67, 224)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(132, 30)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "Display Totals"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grdTut)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents grdTut As UJGrid.UJGrid
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents Button2 As Button
End Class
