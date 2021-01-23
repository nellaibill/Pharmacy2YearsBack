<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleHDrug
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpfromDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdShow = New Glass.GlassButton
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.SheduleHDrug = New Pharmacy.SheduleHDrug
        Me.DrugSlipDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugSlipDetailsTableAdapter = New Pharmacy.SheduleHDrugTableAdapters.DrugSlipDetailsTableAdapter
        Me.FromToDateTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FromToDateTableTableAdapter = New Pharmacy.SheduleHDrugTableAdapters.FromToDateTableTableAdapter
        CType(Me.SheduleHDrug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugSlipDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromToDateTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(436, 18)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(112, 20)
        Me.dtpToDate.TabIndex = 33
        '
        'dtpfromDate
        '
        Me.dtpfromDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpfromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfromDate.Location = New System.Drawing.Point(254, 18)
        Me.dtpfromDate.Name = "dtpfromDate"
        Me.dtpfromDate.Size = New System.Drawing.Size(117, 20)
        Me.dtpfromDate.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "From Date"
        '
        'cmdShow
        '
        Me.cmdShow.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShow.ForeColor = System.Drawing.Color.Black
        Me.cmdShow.GlowColor = System.Drawing.Color.Yellow
        Me.cmdShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdShow.Location = New System.Drawing.Point(554, 12)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(104, 29)
        Me.cmdShow.TabIndex = 34
        Me.cmdShow.Text = "&Show"
        '
        'ReportViewer1
        '
        ReportDataSource7.Name = "SheduleHDrug_DrugSlipDetails"
        ReportDataSource7.Value = Me.DrugSlipDetailsBindingSource
        ReportDataSource8.Name = "SheduleHDrug_FromToDateTable"
        ReportDataSource8.Value = Me.FromToDateTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pharmacy.ScheduleHDrug.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(840, 499)
        Me.ReportViewer1.TabIndex = 35
        '
        'SheduleHDrug
        '
        Me.SheduleHDrug.DataSetName = "SheduleHDrug"
        Me.SheduleHDrug.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrugSlipDetailsBindingSource
        '
        Me.DrugSlipDetailsBindingSource.DataMember = "DrugSlipDetails"
        Me.DrugSlipDetailsBindingSource.DataSource = Me.SheduleHDrug
        '
        'DrugSlipDetailsTableAdapter
        '
        Me.DrugSlipDetailsTableAdapter.ClearBeforeFill = True
        '
        'FromToDateTableBindingSource
        '
        Me.FromToDateTableBindingSource.DataMember = "FromToDateTable"
        Me.FromToDateTableBindingSource.DataSource = Me.SheduleHDrug
        '
        'FromToDateTableTableAdapter
        '
        Me.FromToDateTableTableAdapter.ClearBeforeFill = True
        '
        'ScheduleHDrug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 572)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpfromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ScheduleHDrug"
        Me.Text = "Schedule H Drug"
        CType(Me.SheduleHDrug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugSlipDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromToDateTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdShow As Glass.GlassButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DrugSlipDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SheduleHDrug As Pharmacy.SheduleHDrug
    Friend WithEvents FromToDateTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DrugSlipDetailsTableAdapter As Pharmacy.SheduleHDrugTableAdapters.DrugSlipDetailsTableAdapter
    Friend WithEvents FromToDateTableTableAdapter As Pharmacy.SheduleHDrugTableAdapters.FromToDateTableTableAdapter
End Class
