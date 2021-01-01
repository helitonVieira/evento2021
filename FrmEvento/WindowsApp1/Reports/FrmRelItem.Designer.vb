<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRelItem
    Inherits Controles.FrmPadrao

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tab_itemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New WindowsApp1.DataSet3()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tab_itemTableAdapter = New WindowsApp1.DataSet3TableAdapters.tab_itemTableAdapter()
        CType(Me.tab_itemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_itemBindingSource
        '
        Me.tab_itemBindingSource.DataMember = "tab_item"
        Me.tab_itemBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSItem"
        ReportDataSource1.Value = Me.tab_itemBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.RelItem.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(661, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'tab_itemTableAdapter
        '
        Me.tab_itemTableAdapter.ClearBeforeFill = True
        '
        'FrmRelItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(661, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmRelItem"
        Me.Text = "FrmRelItem"
        CType(Me.tab_itemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tab_itemBindingSource As BindingSource
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents tab_itemTableAdapter As DataSet3TableAdapters.tab_itemTableAdapter
End Class
