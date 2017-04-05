<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRunner
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.dgvRunners = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnEmailConditions = New System.Windows.Forms.Button()
        CType(Me.dgvRunners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(70, 76)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bib Number: "
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(557, 49)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(105, 47)
        Me.btnOkay.TabIndex = 2
        Me.btnOkay.Text = "OK"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'dgvRunners
        '
        Me.dgvRunners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRunners.Location = New System.Drawing.Point(50, 201)
        Me.dgvRunners.Name = "dgvRunners"
        Me.dgvRunners.RowTemplate.Height = 28
        Me.dgvRunners.Size = New System.Drawing.Size(634, 299)
        Me.dgvRunners.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(135, 73)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(267, 26)
        Me.txtName.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(135, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(267, 26)
        Me.TextBox2.TabIndex = 5
        '
        'btnEmailConditions
        '
        Me.btnEmailConditions.Location = New System.Drawing.Point(557, 102)
        Me.btnEmailConditions.Name = "btnEmailConditions"
        Me.btnEmailConditions.Size = New System.Drawing.Size(105, 62)
        Me.btnEmailConditions.TabIndex = 6
        Me.btnEmailConditions.Text = "Email Conditions"
        Me.btnEmailConditions.UseVisualStyleBackColor = True
        '
        'frmViewRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 587)
        Me.Controls.Add(Me.btnEmailConditions)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvRunners)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmViewRunner"
        Me.Text = "View Runner"
        CType(Me.dgvRunners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents dgvRunners As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnEmailConditions As Button
End Class
