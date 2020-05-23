<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_continuar = New System.Windows.Forms.Button()
        Me.tbx_nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su nombre para continuar:"
        '
        'btn_continuar
        '
        Me.btn_continuar.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_continuar.Location = New System.Drawing.Point(150, 167)
        Me.btn_continuar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_continuar.Name = "btn_continuar"
        Me.btn_continuar.Size = New System.Drawing.Size(134, 27)
        Me.btn_continuar.TabIndex = 1
        Me.btn_continuar.Text = "CONTINUAR -->"
        Me.btn_continuar.UseVisualStyleBackColor = True
        '
        'tbx_nombre
        '
        Me.tbx_nombre.Location = New System.Drawing.Point(141, 136)
        Me.tbx_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbx_nombre.Name = "tbx_nombre"
        Me.tbx_nombre.Size = New System.Drawing.Size(155, 20)
        Me.tbx_nombre.TabIndex = 2
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 342)
        Me.Controls.Add(Me.tbx_nombre)
        Me.Controls.Add(Me.btn_continuar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_continuar As Button
    Friend WithEvents tbx_nombre As TextBox
End Class
