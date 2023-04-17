<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion3
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAnswer21 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer22 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer23 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer24 = New System.Windows.Forms.RadioButton()
        Me.btnNext22 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which scene in the fim did Anorld become pregnant?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MovieQuizTemplate.My.Resources.Resources.download__6_
        Me.PictureBox2.Location = New System.Drawing.Point(555, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(243, 254)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MovieQuizTemplate.My.Resources.Resources.download__7_
        Me.PictureBox1.Location = New System.Drawing.Point(64, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 227)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer24)
        Me.GroupBox1.Controls.Add(Me.btnAnswer23)
        Me.GroupBox1.Controls.Add(Me.btnAnswer22)
        Me.GroupBox1.Controls.Add(Me.BtnAnswer21)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 247)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnAnswer21
        '
        Me.BtnAnswer21.AutoSize = True
        Me.BtnAnswer21.Location = New System.Drawing.Point(7, 57)
        Me.BtnAnswer21.Name = "BtnAnswer21"
        Me.BtnAnswer21.Size = New System.Drawing.Size(195, 17)
        Me.BtnAnswer21.TabIndex = 0
        Me.BtnAnswer21.TabStop = True
        Me.BtnAnswer21.Text = "scene 1 intro anord driving in his car"
        Me.BtnAnswer21.UseVisualStyleBackColor = True
        '
        'btnAnswer22
        '
        Me.btnAnswer22.AutoSize = True
        Me.btnAnswer22.Location = New System.Drawing.Point(0, 109)
        Me.btnAnswer22.Name = "btnAnswer22"
        Me.btnAnswer22.Size = New System.Drawing.Size(255, 17)
        Me.btnAnswer22.TabIndex = 1
        Me.btnAnswer22.TabStop = True
        Me.btnAnswer22.Text = "scene 11 IVF hopsital results meeting with doctor"
        Me.btnAnswer22.UseVisualStyleBackColor = True
        '
        'btnAnswer23
        '
        Me.btnAnswer23.AutoSize = True
        Me.btnAnswer23.Location = New System.Drawing.Point(7, 163)
        Me.btnAnswer23.Name = "btnAnswer23"
        Me.btnAnswer23.Size = New System.Drawing.Size(189, 17)
        Me.btnAnswer23.TabIndex = 2
        Me.btnAnswer23.TabStop = True
        Me.btnAnswer23.Text = "scene 6 Funny hopsital enviroment"
        Me.btnAnswer23.UseVisualStyleBackColor = True
        '
        'btnAnswer24
        '
        Me.btnAnswer24.AutoSize = True
        Me.btnAnswer24.Location = New System.Drawing.Point(7, 209)
        Me.btnAnswer24.Name = "btnAnswer24"
        Me.btnAnswer24.Size = New System.Drawing.Size(51, 17)
        Me.btnAnswer24.TabIndex = 3
        Me.btnAnswer24.TabStop = True
        Me.btnAnswer24.Text = "Other"
        Me.btnAnswer24.UseVisualStyleBackColor = True
        '
        'btnNext22
        '
        Me.btnNext22.Location = New System.Drawing.Point(654, 415)
        Me.btnNext22.Name = "btnNext22"
        Me.btnNext22.Size = New System.Drawing.Size(75, 23)
        Me.btnNext22.TabIndex = 4
        Me.btnNext22.Text = "Next"
        Me.btnNext22.UseVisualStyleBackColor = True
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext22)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuestion3"
        Me.Text = "frmQuestion3"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnswer24 As RadioButton
    Friend WithEvents btnAnswer23 As RadioButton
    Friend WithEvents btnAnswer22 As RadioButton
    Friend WithEvents BtnAnswer21 As RadioButton
    Friend WithEvents btnNext22 As Button
End Class
