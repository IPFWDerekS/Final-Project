﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolstrpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustrpbtnAddRunner = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemRunnerForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustrpViewInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustrpExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrpMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolstrpMenu
        '
        Me.toolstrpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menustrpbtnAddRunner, Me.menuitemRunnerForm, Me.menustrpViewInventory, Me.menustrpExit})
        Me.toolstrpMenu.Name = "toolstrpMenu"
        Me.toolstrpMenu.Size = New System.Drawing.Size(69, 29)
        Me.toolstrpMenu.Text = "Menu"
        '
        'menustrpbtnAddRunner
        '
        Me.menustrpbtnAddRunner.Name = "menustrpbtnAddRunner"
        Me.menustrpbtnAddRunner.Size = New System.Drawing.Size(214, 30)
        Me.menustrpbtnAddRunner.Text = "Add Runner"
        '
        'menuitemRunnerForm
        '
        Me.menuitemRunnerForm.Name = "menuitemRunnerForm"
        Me.menuitemRunnerForm.Size = New System.Drawing.Size(214, 30)
        Me.menuitemRunnerForm.Text = "Runner Form"
        '
        'menustrpViewInventory
        '
        Me.menustrpViewInventory.Name = "menustrpViewInventory"
        Me.menustrpViewInventory.Size = New System.Drawing.Size(214, 30)
        Me.menustrpViewInventory.Text = "View Inventory"
        '
        'menustrpExit
        '
        Me.menustrpExit.Name = "menustrpExit"
        Me.menustrpExit.Size = New System.Drawing.Size(214, 30)
        Me.menustrpExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = ""
        Me.Label1.Text = "City Run Marathon 2017"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(51, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(608, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Thank you for volunteering! You make all of this possible! "
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 327)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainForm"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolstrpMenu As ToolStripMenuItem
    Friend WithEvents menustrpbtnAddRunner As ToolStripMenuItem
    Friend WithEvents menuitemRunnerForm As ToolStripMenuItem
    Friend WithEvents menustrpViewInventory As ToolStripMenuItem
    Friend WithEvents menustrpExit As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
