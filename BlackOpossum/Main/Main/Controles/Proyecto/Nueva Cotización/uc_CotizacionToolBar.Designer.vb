<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CotizacionToolBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_CotizacionToolBar))
        Me.CotizacionTool = New System.Windows.Forms.ToolStrip()
        Me.tb_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.tb_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.tb_Siguiente = New System.Windows.Forms.ToolStripButton()
        Me.tb_Anterior = New System.Windows.Forms.ToolStripButton()
        Me.tb_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.CotizacionTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'CotizacionTool
        '
        Me.CotizacionTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tb_Guardar, Me.tb_Cancelar, Me.tb_Siguiente, Me.tb_Anterior, Me.tb_Imprimir})
        Me.CotizacionTool.Location = New System.Drawing.Point(0, 0)
        Me.CotizacionTool.Name = "CotizacionTool"
        Me.CotizacionTool.Size = New System.Drawing.Size(548, 25)
        Me.CotizacionTool.TabIndex = 0
        Me.CotizacionTool.Text = "ToolStrip1"
        '
        'tb_Guardar
        '
        Me.tb_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_Guardar.Image = CType(resources.GetObject("tb_Guardar.Image"), System.Drawing.Image)
        Me.tb_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_Guardar.Name = "tb_Guardar"
        Me.tb_Guardar.Size = New System.Drawing.Size(56, 22)
        Me.tb_Guardar.Text = "Guardar"
        '
        'tb_Cancelar
        '
        Me.tb_Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_Cancelar.Image = CType(resources.GetObject("tb_Cancelar.Image"), System.Drawing.Image)
        Me.tb_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_Cancelar.Name = "tb_Cancelar"
        Me.tb_Cancelar.Size = New System.Drawing.Size(61, 22)
        Me.tb_Cancelar.Text = "Cancelar"
        '
        'tb_Siguiente
        '
        Me.tb_Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_Siguiente.Image = CType(resources.GetObject("tb_Siguiente.Image"), System.Drawing.Image)
        Me.tb_Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_Siguiente.Name = "tb_Siguiente"
        Me.tb_Siguiente.Size = New System.Drawing.Size(63, 22)
        Me.tb_Siguiente.Text = "Siguiente"
        '
        'tb_Anterior
        '
        Me.tb_Anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_Anterior.Image = CType(resources.GetObject("tb_Anterior.Image"), System.Drawing.Image)
        Me.tb_Anterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_Anterior.Name = "tb_Anterior"
        Me.tb_Anterior.Size = New System.Drawing.Size(53, 22)
        Me.tb_Anterior.Text = "Anterior"
        '
        'tb_Imprimir
        '
        Me.tb_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_Imprimir.Image = CType(resources.GetObject("tb_Imprimir.Image"), System.Drawing.Image)
        Me.tb_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_Imprimir.Name = "tb_Imprimir"
        Me.tb_Imprimir.Size = New System.Drawing.Size(57, 22)
        Me.tb_Imprimir.Text = "Imprimir"
        '
        'uc_CotizacionToolBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CotizacionTool)
        Me.Name = "uc_CotizacionToolBar"
        Me.Size = New System.Drawing.Size(548, 29)
        Me.CotizacionTool.ResumeLayout(False)
        Me.CotizacionTool.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CotizacionTool As System.Windows.Forms.ToolStrip
    Friend WithEvents tb_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tb_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tb_Siguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents tb_Anterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents tb_Imprimir As System.Windows.Forms.ToolStripButton

End Class
