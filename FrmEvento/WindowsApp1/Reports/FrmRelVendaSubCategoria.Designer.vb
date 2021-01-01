<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRelVendaSubCategoria
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
        Me.ClSubCategoriaItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClRelSubCategoriaItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ClSubCategoriaItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClRelSubCategoriaItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.RelVendaSubCategoria.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(661, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClRelSubCategoriaItemBindingSource
        '
        Me.ClRelSubCategoriaItemBindingSource.DataSource = GetType(WindowsApp1.ClRelEntradaSaidaEstoque)
        '
        'FrmRelSubCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(661, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmRelSubCategoria"
        Me.Text = "FrmRelVendasSubcategoria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClSubCategoriaItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClRelSubCategoriaItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClSubCategoriaItemBindingSource As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClRelSubCategoriaItemBindingSource As BindingSource
End Class
