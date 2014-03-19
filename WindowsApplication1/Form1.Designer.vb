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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCard1 = New System.Windows.Forms.Label()
        Me.lblCard2 = New System.Windows.Forms.Label()
        Me.lblCard3 = New System.Windows.Forms.Label()
        Me.lblCard4 = New System.Windows.Forms.Label()
        Me.lblCard5 = New System.Windows.Forms.Label()
        Me.lblCard6 = New System.Windows.Forms.Label()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCard1
        '
        Me.lblCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard1.Location = New System.Drawing.Point(23, 59)
        Me.lblCard1.Name = "lblCard1"
        Me.lblCard1.Size = New System.Drawing.Size(87, 75)
        Me.lblCard1.TabIndex = 0
        Me.lblCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard2
        '
        Me.lblCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard2.Location = New System.Drawing.Point(311, 59)
        Me.lblCard2.Name = "lblCard2"
        Me.lblCard2.Size = New System.Drawing.Size(87, 75)
        Me.lblCard2.TabIndex = 1
        Me.lblCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard3
        '
        Me.lblCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard3.Location = New System.Drawing.Point(608, 59)
        Me.lblCard3.Name = "lblCard3"
        Me.lblCard3.Size = New System.Drawing.Size(87, 75)
        Me.lblCard3.TabIndex = 2
        Me.lblCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard4
        '
        Me.lblCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard4.Location = New System.Drawing.Point(23, 199)
        Me.lblCard4.Name = "lblCard4"
        Me.lblCard4.Size = New System.Drawing.Size(87, 75)
        Me.lblCard4.TabIndex = 3
        Me.lblCard4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard5
        '
        Me.lblCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard5.Location = New System.Drawing.Point(311, 199)
        Me.lblCard5.Name = "lblCard5"
        Me.lblCard5.Size = New System.Drawing.Size(87, 75)
        Me.lblCard5.TabIndex = 4
        Me.lblCard5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard6
        '
        Me.lblCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard6.Location = New System.Drawing.Point(608, 199)
        Me.lblCard6.Name = "lblCard6"
        Me.lblCard6.Size = New System.Drawing.Size(87, 75)
        Me.lblCard6.TabIndex = 5
        Me.lblCard6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShuffle
        '
        Me.btnShuffle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShuffle.Location = New System.Drawing.Point(285, 342)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(141, 34)
        Me.btnShuffle.TabIndex = 6
        Me.btnShuffle.Text = "Shuffle"
        Me.btnShuffle.UseVisualStyleBackColor = True
        '
        'txtBox
        '
        Me.txtBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBox.Location = New System.Drawing.Point(23, 3)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(511, 28)
        Me.txtBox.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "lblCard1"
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(311, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "lblCard1"
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(608, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "lblCard1"
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = Nothing
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(23, 199)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "lblCard1"
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.ErrorImage = Nothing
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(311, 199)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "lblCard1"
        Me.PictureBox5.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.ErrorImage = Nothing
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(608, 199)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "lblCard1"
        Me.PictureBox6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(768, 411)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.lblCard6)
        Me.Controls.Add(Me.lblCard5)
        Me.Controls.Add(Me.lblCard4)
        Me.Controls.Add(Me.lblCard3)
        Me.Controls.Add(Me.lblCard2)
        Me.Controls.Add(Me.lblCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCard1 As System.Windows.Forms.Label
    Friend WithEvents lblCard2 As System.Windows.Forms.Label
    Friend WithEvents lblCard3 As System.Windows.Forms.Label
    Friend WithEvents lblCard4 As System.Windows.Forms.Label
    Friend WithEvents lblCard5 As System.Windows.Forms.Label
    Friend WithEvents lblCard6 As System.Windows.Forms.Label
    Friend WithEvents btnShuffle As System.Windows.Forms.Button
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox

End Class
