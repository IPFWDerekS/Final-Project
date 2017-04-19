<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRunner
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBibnumber = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxAge = New System.Windows.Forms.TextBox()
        Me.cboShirts = New System.Windows.Forms.ComboBox()
        Me.grpboxRaceType = New System.Windows.Forms.GroupBox()
        Me.radbtn10KRace = New System.Windows.Forms.RadioButton()
        Me.radbtn5K = New System.Windows.Forms.RadioButton()
        Me.grpboxCorralNumber = New System.Windows.Forms.GroupBox()
        Me.radbtnCorralC = New System.Windows.Forms.RadioButton()
        Me.radbtnCorralB = New System.Windows.Forms.RadioButton()
        Me.radbtnCorralA = New System.Windows.Forms.RadioButton()
        Me.grpboxMedals = New System.Windows.Forms.GroupBox()
        Me.radbtn10KMedal = New System.Windows.Forms.RadioButton()
        Me.radbtn5KMedal = New System.Windows.Forms.RadioButton()
        Me.txtdisplayWater = New System.Windows.Forms.TextBox()
        Me.txtDisplaySnack = New System.Windows.Forms.TextBox()
        Me.txtdisplay5K = New System.Windows.Forms.TextBox()
        Me.txtdisplay10K = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtdisplayShirts = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpboxRaceType.SuspendLayout()
        Me.grpboxCorralNumber.SuspendLayout()
        Me.grpboxMedals.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bib Number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Shirt Size:  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Water Bottle: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Snack: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(419, 499)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "5K Medal: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(576, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "10K Medal: "
        '
        'txtBibnumber
        '
        Me.txtBibnumber.Location = New System.Drawing.Point(118, 42)
        Me.txtBibnumber.Name = "txtBibnumber"
        Me.txtBibnumber.Size = New System.Drawing.Size(147, 26)
        Me.txtBibnumber.TabIndex = 13
        Me.txtBibnumber.Tag = "Bib Number"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(572, 39)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(253, 26)
        Me.txtFirst.TabIndex = 14
        Me.txtFirst.Tag = "First Name"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(572, 94)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(253, 26)
        Me.txtLast.TabIndex = 15
        Me.txtLast.Tag = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Age:"
        '
        'txtboxAge
        '
        Me.txtboxAge.Location = New System.Drawing.Point(118, 97)
        Me.txtboxAge.Name = "txtboxAge"
        Me.txtboxAge.Size = New System.Drawing.Size(76, 26)
        Me.txtboxAge.TabIndex = 17
        Me.txtboxAge.Tag = "Age"
        '
        'cboShirts
        '
        Me.cboShirts.FormattingEnabled = True
        Me.cboShirts.Items.AddRange(New Object() {"Small", "Medium", "Large", "X-Large"})
        Me.cboShirts.Location = New System.Drawing.Point(118, 152)
        Me.cboShirts.Name = "cboShirts"
        Me.cboShirts.Size = New System.Drawing.Size(121, 28)
        Me.cboShirts.TabIndex = 18
        Me.cboShirts.Tag = "Shirt Size"
        '
        'grpboxRaceType
        '
        Me.grpboxRaceType.Controls.Add(Me.radbtn10KRace)
        Me.grpboxRaceType.Controls.Add(Me.radbtn5K)
        Me.grpboxRaceType.Location = New System.Drawing.Point(18, 249)
        Me.grpboxRaceType.Name = "grpboxRaceType"
        Me.grpboxRaceType.Size = New System.Drawing.Size(247, 124)
        Me.grpboxRaceType.TabIndex = 19
        Me.grpboxRaceType.TabStop = False
        Me.grpboxRaceType.Tag = "Race Type"
        Me.grpboxRaceType.Text = "Race Type:"
        '
        'radbtn10KRace
        '
        Me.radbtn10KRace.AutoSize = True
        Me.radbtn10KRace.Location = New System.Drawing.Point(47, 82)
        Me.radbtn10KRace.Name = "radbtn10KRace"
        Me.radbtn10KRace.Size = New System.Drawing.Size(104, 24)
        Me.radbtn10KRace.TabIndex = 1
        Me.radbtn10KRace.TabStop = True
        Me.radbtn10KRace.Tag = "10 K Race"
        Me.radbtn10KRace.Text = "10K Race"
        Me.radbtn10KRace.UseVisualStyleBackColor = True
        '
        'radbtn5K
        '
        Me.radbtn5K.AutoSize = True
        Me.radbtn5K.Location = New System.Drawing.Point(47, 36)
        Me.radbtn5K.Name = "radbtn5K"
        Me.radbtn5K.Size = New System.Drawing.Size(95, 24)
        Me.radbtn5K.TabIndex = 0
        Me.radbtn5K.TabStop = True
        Me.radbtn5K.Tag = "5K Race"
        Me.radbtn5K.Text = "5K Race"
        Me.radbtn5K.UseVisualStyleBackColor = True
        '
        'grpboxCorralNumber
        '
        Me.grpboxCorralNumber.Controls.Add(Me.radbtnCorralC)
        Me.grpboxCorralNumber.Controls.Add(Me.radbtnCorralB)
        Me.grpboxCorralNumber.Controls.Add(Me.radbtnCorralA)
        Me.grpboxCorralNumber.Location = New System.Drawing.Point(348, 249)
        Me.grpboxCorralNumber.Name = "grpboxCorralNumber"
        Me.grpboxCorralNumber.Size = New System.Drawing.Size(184, 124)
        Me.grpboxCorralNumber.TabIndex = 20
        Me.grpboxCorralNumber.TabStop = False
        Me.grpboxCorralNumber.Tag = "Corral Number"
        Me.grpboxCorralNumber.Text = "Corral Number:"
        '
        'radbtnCorralC
        '
        Me.radbtnCorralC.AutoSize = True
        Me.radbtnCorralC.Location = New System.Drawing.Point(23, 94)
        Me.radbtnCorralC.Name = "radbtnCorralC"
        Me.radbtnCorralC.Size = New System.Drawing.Size(91, 24)
        Me.radbtnCorralC.TabIndex = 2
        Me.radbtnCorralC.TabStop = True
        Me.radbtnCorralC.Text = "Corral C"
        Me.radbtnCorralC.UseVisualStyleBackColor = True
        '
        'radbtnCorralB
        '
        Me.radbtnCorralB.AutoSize = True
        Me.radbtnCorralB.Location = New System.Drawing.Point(23, 56)
        Me.radbtnCorralB.Name = "radbtnCorralB"
        Me.radbtnCorralB.Size = New System.Drawing.Size(91, 24)
        Me.radbtnCorralB.TabIndex = 1
        Me.radbtnCorralB.TabStop = True
        Me.radbtnCorralB.Text = "Corral B"
        Me.radbtnCorralB.UseVisualStyleBackColor = True
        '
        'radbtnCorralA
        '
        Me.radbtnCorralA.AutoSize = True
        Me.radbtnCorralA.Location = New System.Drawing.Point(23, 25)
        Me.radbtnCorralA.Name = "radbtnCorralA"
        Me.radbtnCorralA.Size = New System.Drawing.Size(91, 24)
        Me.radbtnCorralA.TabIndex = 0
        Me.radbtnCorralA.TabStop = True
        Me.radbtnCorralA.Text = "Corral A"
        Me.radbtnCorralA.UseVisualStyleBackColor = True
        '
        'grpboxMedals
        '
        Me.grpboxMedals.Controls.Add(Me.radbtn10KMedal)
        Me.grpboxMedals.Controls.Add(Me.radbtn5KMedal)
        Me.grpboxMedals.Location = New System.Drawing.Point(625, 249)
        Me.grpboxMedals.Name = "grpboxMedals"
        Me.grpboxMedals.Size = New System.Drawing.Size(200, 118)
        Me.grpboxMedals.TabIndex = 21
        Me.grpboxMedals.TabStop = False
        Me.grpboxMedals.Tag = "Medal"
        Me.grpboxMedals.Text = "Medal:"
        '
        'radbtn10KMedal
        '
        Me.radbtn10KMedal.AutoSize = True
        Me.radbtn10KMedal.Location = New System.Drawing.Point(28, 76)
        Me.radbtn10KMedal.Name = "radbtn10KMedal"
        Me.radbtn10KMedal.Size = New System.Drawing.Size(109, 24)
        Me.radbtn10KMedal.TabIndex = 1
        Me.radbtn10KMedal.TabStop = True
        Me.radbtn10KMedal.Text = "10K Medal"
        Me.radbtn10KMedal.UseVisualStyleBackColor = True
        '
        'radbtn5KMedal
        '
        Me.radbtn5KMedal.AutoSize = True
        Me.radbtn5KMedal.Location = New System.Drawing.Point(27, 26)
        Me.radbtn5KMedal.Name = "radbtn5KMedal"
        Me.radbtn5KMedal.Size = New System.Drawing.Size(100, 24)
        Me.radbtn5KMedal.TabIndex = 0
        Me.radbtn5KMedal.TabStop = True
        Me.radbtn5KMedal.Text = "5K Medal"
        Me.radbtn5KMedal.UseVisualStyleBackColor = True
        '
        'txtdisplayWater
        '
        Me.txtdisplayWater.Enabled = False
        Me.txtdisplayWater.Location = New System.Drawing.Point(146, 496)
        Me.txtdisplayWater.Name = "txtdisplayWater"
        Me.txtdisplayWater.Size = New System.Drawing.Size(48, 26)
        Me.txtdisplayWater.TabIndex = 22
        Me.txtdisplayWater.Tag = "Water Bottle"
        Me.txtdisplayWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDisplaySnack
        '
        Me.txtDisplaySnack.Enabled = False
        Me.txtDisplaySnack.Location = New System.Drawing.Point(317, 496)
        Me.txtDisplaySnack.Name = "txtDisplaySnack"
        Me.txtDisplaySnack.Size = New System.Drawing.Size(48, 26)
        Me.txtDisplaySnack.TabIndex = 23
        Me.txtDisplaySnack.Tag = "Snack"
        Me.txtDisplaySnack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdisplay5K
        '
        Me.txtdisplay5K.Enabled = False
        Me.txtdisplay5K.Location = New System.Drawing.Point(508, 496)
        Me.txtdisplay5K.Name = "txtdisplay5K"
        Me.txtdisplay5K.Size = New System.Drawing.Size(48, 26)
        Me.txtdisplay5K.TabIndex = 24
        Me.txtdisplay5K.Tag = "5 K Medal"
        Me.txtdisplay5K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdisplay10K
        '
        Me.txtdisplay10K.Enabled = False
        Me.txtdisplay10K.Location = New System.Drawing.Point(674, 496)
        Me.txtdisplay10K.Name = "txtdisplay10K"
        Me.txtdisplay10K.Size = New System.Drawing.Size(48, 26)
        Me.txtdisplay10K.TabIndex = 25
        Me.txtdisplay10K.Tag = "10 K Medal"
        Me.txtdisplay10K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(119, 585)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 33)
        Me.btnSubmit.TabIndex = 26
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(290, 585)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 33)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(517, 585)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 33)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtdisplayShirts
        '
        Me.txtdisplayShirts.Enabled = False
        Me.txtdisplayShirts.Location = New System.Drawing.Point(38, 190)
        Me.txtdisplayShirts.Name = "txtdisplayShirts"
        Me.txtdisplayShirts.Size = New System.Drawing.Size(65, 26)
        Me.txtdisplayShirts.TabIndex = 29
        Me.txtdisplayShirts.Text = "Shirt"
        Me.txtdisplayShirts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStrip, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(963, 30)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(0, 25)
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'frmAddRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 684)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtdisplayShirts)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtdisplay10K)
        Me.Controls.Add(Me.txtdisplay5K)
        Me.Controls.Add(Me.txtDisplaySnack)
        Me.Controls.Add(Me.txtdisplayWater)
        Me.Controls.Add(Me.grpboxMedals)
        Me.Controls.Add(Me.grpboxCorralNumber)
        Me.Controls.Add(Me.grpboxRaceType)
        Me.Controls.Add(Me.cboShirts)
        Me.Controls.Add(Me.txtboxAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtBibnumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddRunner"
        Me.Text = "Add Runner"
        Me.grpboxRaceType.ResumeLayout(False)
        Me.grpboxRaceType.PerformLayout()
        Me.grpboxCorralNumber.ResumeLayout(False)
        Me.grpboxCorralNumber.PerformLayout()
        Me.grpboxMedals.ResumeLayout(False)
        Me.grpboxMedals.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBibnumber As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxAge As TextBox
    Friend WithEvents cboShirts As ComboBox
    Friend WithEvents grpboxRaceType As GroupBox
    Friend WithEvents radbtn10KRace As RadioButton
    Friend WithEvents radbtn5K As RadioButton
    Friend WithEvents grpboxCorralNumber As GroupBox
    Friend WithEvents radbtnCorralC As RadioButton
    Friend WithEvents radbtnCorralB As RadioButton
    Friend WithEvents radbtnCorralA As RadioButton
    Friend WithEvents grpboxMedals As GroupBox
    Friend WithEvents radbtn10KMedal As RadioButton
    Friend WithEvents radbtn5KMedal As RadioButton
    Friend WithEvents txtdisplayWater As TextBox
    Friend WithEvents txtDisplaySnack As TextBox
    Friend WithEvents txtdisplay5K As TextBox
    Friend WithEvents txtdisplay10K As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtdisplayShirts As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusStrip As ToolStripStatusLabel
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
