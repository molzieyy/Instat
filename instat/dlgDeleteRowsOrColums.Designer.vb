﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteRowsOrColums
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
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.ucrSelectorForDeleteRows = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.nudRowNames = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudRowNames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(10, 91)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 5
        Me.lblNumberofRows.Tag = "Number_of_Rows:"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(13, 10)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 0
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Tag = "Columns"
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(249, 10)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 1
        Me.rdoRows.TabStop = True
        Me.rdoRows.Tag = "Rows"
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(252, 73)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(96, 13)
        Me.lblColumnsToDelete.TabIndex = 3
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete:"
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(249, 88)
        Me.ucrReceiverForColumnsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForColumnsToDelete.TabIndex = 4
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(10, 38)
        Me.ucrSelectorForDeleteColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleteColumns.TabIndex = 2
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.clsDataFrameSelector = Nothing
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(103, 88)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(55, 24)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 6
        '
        'ucrSelectorForDeleteRows
        '
        Me.ucrSelectorForDeleteRows.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteRows.Location = New System.Drawing.Point(10, 38)
        Me.ucrSelectorForDeleteRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteRows.Name = "ucrSelectorForDeleteRows"
        Me.ucrSelectorForDeleteRows.Size = New System.Drawing.Size(127, 41)
        Me.ucrSelectorForDeleteRows.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 231)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(10, 116)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(78, 13)
        Me.lblRowNames.TabIndex = 7
        Me.lblRowNames.Tag = ""
        Me.lblRowNames.Text = "Row to Delete:"
        '
        'nudRowNames
        '
        Me.nudRowNames.Location = New System.Drawing.Point(103, 115)
        Me.nudRowNames.Name = "nudRowNames"
        Me.nudRowNames.Size = New System.Drawing.Size(50, 20)
        Me.nudRowNames.TabIndex = 10
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 287)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.lblRowNames)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.ucrSelectorForDeleteRows)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.nudRowNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Rows/Columns"
        CType(Me.nudRowNames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrSelectorForDeleteRows As ucrDataFrame
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents lblRowNames As Label
    Friend WithEvents nudRowNames As NumericUpDown
End Class
