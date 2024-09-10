<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.ButtonCarro = New System.Windows.Forms.Button()
        Me.ButtonSafra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCarro
        '
        Me.ButtonCarro.Location = New System.Drawing.Point(12, 12)
        Me.ButtonCarro.Name = "ButtonCarro"
        Me.ButtonCarro.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCarro.TabIndex = 0
        Me.ButtonCarro.Text = "Carro"
        Me.ButtonCarro.UseVisualStyleBackColor = True
        '
        'ButtonSafra
        '
        Me.ButtonSafra.Location = New System.Drawing.Point(12, 41)
        Me.ButtonSafra.Name = "ButtonSafra"
        Me.ButtonSafra.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSafra.TabIndex = 1
        Me.ButtonSafra.Text = "Safra"
        Me.ButtonSafra.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSafra)
        Me.Controls.Add(Me.ButtonCarro)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCarro As Button
    Friend WithEvents ButtonSafra As Button
End Class
