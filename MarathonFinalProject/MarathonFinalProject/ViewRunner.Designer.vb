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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.dgvRunners = New System.Windows.Forms.DataGridView()
        Me.BibNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShirtSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RunnerDataSet = New MarathonFinalProject.RunnerDataSet()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnEmailConditions = New System.Windows.Forms.Button()
        Me.RunnerTableAdapter = New MarathonFinalProject.RunnerDataSetTableAdapters.RunnerTableAdapter()
        CType(Me.dgvRunners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunnerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvRunners.AutoGenerateColumns = False
        Me.dgvRunners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRunners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BibNumberDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ShirtSizeDataGridViewTextBoxColumn, Me.RaceDataGridViewTextBoxColumn, Me.CorralDataGridViewTextBoxColumn, Me.MedalDataGridViewTextBoxColumn})
        Me.dgvRunners.DataSource = Me.RunnerBindingSource
        Me.dgvRunners.Location = New System.Drawing.Point(56, 197)
        Me.dgvRunners.Name = "dgvRunners"
        Me.dgvRunners.RowTemplate.Height = 28
        Me.dgvRunners.Size = New System.Drawing.Size(892, 299)
        Me.dgvRunners.TabIndex = 3
        '
        'BibNumberDataGridViewTextBoxColumn
        '
        Me.BibNumberDataGridViewTextBoxColumn.DataPropertyName = "Bib Number"
        Me.BibNumberDataGridViewTextBoxColumn.HeaderText = "Bib Number"
        Me.BibNumberDataGridViewTextBoxColumn.Name = "BibNumberDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'ShirtSizeDataGridViewTextBoxColumn
        '
        Me.ShirtSizeDataGridViewTextBoxColumn.DataPropertyName = "Shirt Size"
        Me.ShirtSizeDataGridViewTextBoxColumn.HeaderText = "Shirt Size"
        Me.ShirtSizeDataGridViewTextBoxColumn.Name = "ShirtSizeDataGridViewTextBoxColumn"
        '
        'RaceDataGridViewTextBoxColumn
        '
        Me.RaceDataGridViewTextBoxColumn.DataPropertyName = "Race"
        Me.RaceDataGridViewTextBoxColumn.HeaderText = "Race"
        Me.RaceDataGridViewTextBoxColumn.Name = "RaceDataGridViewTextBoxColumn"
        '
        'CorralDataGridViewTextBoxColumn
        '
        Me.CorralDataGridViewTextBoxColumn.DataPropertyName = "Corral"
        Me.CorralDataGridViewTextBoxColumn.HeaderText = "Corral"
        Me.CorralDataGridViewTextBoxColumn.Name = "CorralDataGridViewTextBoxColumn"
        '
        'MedalDataGridViewTextBoxColumn
        '
        Me.MedalDataGridViewTextBoxColumn.DataPropertyName = "Medal"
        Me.MedalDataGridViewTextBoxColumn.HeaderText = "Medal"
        Me.MedalDataGridViewTextBoxColumn.Name = "MedalDataGridViewTextBoxColumn"
        '
        'RunnerBindingSource
        '
        Me.RunnerBindingSource.DataMember = "Runner"
        Me.RunnerBindingSource.DataSource = Me.RunnerDataSet
        '
        'RunnerDataSet
        '
        Me.RunnerDataSet.DataSetName = "RunnerDataSet"
        Me.RunnerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RunnerTableAdapter
        '
        Me.RunnerTableAdapter.ClearBeforeFill = True
        '
        'frmViewRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 587)
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
        CType(Me.RunnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunnerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RunnerDataSet As RunnerDataSet
    Friend WithEvents RunnerBindingSource As BindingSource
    Friend WithEvents RunnerTableAdapter As RunnerDataSetTableAdapters.RunnerTableAdapter
    Friend WithEvents BibNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShirtSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
