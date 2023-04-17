<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAnswer14 = New System.Windows.Forms.RadioButton()
        Me.BtnAnswer13 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer12 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer11 = New System.Windows.Forms.RadioButton()
        Me.btnNext15 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What year did Terminator 2 get released?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer14)
        Me.GroupBox1.Controls.Add(Me.BtnAnswer13)
        Me.GroupBox1.Controls.Add(Me.btnAnswer12)
        Me.GroupBox1.Controls.Add(Me.btnAnswer11)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 331)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnAnswer14
        '
        Me.btnAnswer14.AutoSize = True
        Me.btnAnswer14.Location = New System.Drawing.Point(7, 243)
        Me.btnAnswer14.Name = "btnAnswer14"
        Me.btnAnswer14.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer14.TabIndex = 3
        Me.btnAnswer14.TabStop = True
        Me.btnAnswer14.Text = "2004"
        Me.btnAnswer14.UseVisualStyleBackColor = True
        '
        'BtnAnswer13
        '
        Me.BtnAnswer13.AutoSize = True
        Me.BtnAnswer13.Location = New System.Drawing.Point(7, 181)
        Me.BtnAnswer13.Name = "BtnAnswer13"
        Me.BtnAnswer13.Size = New System.Drawing.Size(49, 17)
        Me.BtnAnswer13.TabIndex = 2
        Me.BtnAnswer13.TabStop = True
        Me.BtnAnswer13.Text = "1992"
        Me.BtnAnswer13.UseVisualStyleBackColor = True
        '
        'btnAnswer12
        '
        Me.btnAnswer12.AutoSize = True
        Me.btnAnswer12.Location = New System.Drawing.Point(7, 116)
        Me.btnAnswer12.Name = "btnAnswer12"
        Me.btnAnswer12.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer12.TabIndex = 1
        Me.btnAnswer12.TabStop = True
        Me.btnAnswer12.Text = "1988"
        Me.btnAnswer12.UseVisualStyleBackColor = True
        '
        'btnAnswer11
        '
        Me.btnAnswer11.AutoSize = True
        Me.btnAnswer11.Location = New System.Drawing.Point(7, 65)
        Me.btnAnswer11.Name = "btnAnswer11"
        Me.btnAnswer11.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer11.TabIndex = 0
        Me.btnAnswer11.TabStop = True
        Me.btnAnswer11.Text = "1977"
        Me.btnAnswer11.UseVisualStyleBackColor = True
        '
        'btnNext15
        '
        Me.btnNext15.Location = New System.Drawing.Point(633, 386)
        Me.btnNext15.Name = "btnNext15"
        Me.btnNext15.Size = New System.Drawing.Size(75, 23)
        Me.btnNext15.TabIndex = 3
        Me.btnNext15.Text = "Next"
        Me.btnNext15.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MovieQuizTemplate.My.Resources.Resources.download__4_
        Me.PictureBox2.Location = New System.Drawing.Point(527, 115)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 252)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MovieQuizTemplate.My.Resources.Resources.images__1_
        Me.PictureBox1.Location = New System.Drawing.Point(44, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 302)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmQuestion2"
        Me.Text = "frmQuestion2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnswer14 As RadioButton
    Friend WithEvents BtnAnswer13 As RadioButton
    Friend WithEvents btnAnswer12 As RadioButton
    Friend WithEvents btnAnswer11 As RadioButton
    Friend WithEvents btnNext15 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
