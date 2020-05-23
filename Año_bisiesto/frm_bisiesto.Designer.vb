<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bisiesto
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
        Me.lbl_bienvenida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbx_año = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
        Me.lbl_agradecer = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_alumno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_bienvenida
        '
        Me.lbl_bienvenida.AutoSize = True
        Me.lbl_bienvenida.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenida.Location = New System.Drawing.Point(131, 31)
        Me.lbl_bienvenida.Name = "lbl_bienvenida"
        Me.lbl_bienvenida.Size = New System.Drawing.Size(128, 16)
        Me.lbl_bienvenida.TabIndex = 0
        Me.lbl_bienvenida.Text = "¡Bienvenido!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Quieres saber que año es bisiesto?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese el año aquí:"
        '
        'tbx_año
        '
        Me.tbx_año.Location = New System.Drawing.Point(178, 121)
        Me.tbx_año.Name = "tbx_año"
        Me.tbx_año.Size = New System.Drawing.Size(89, 20)
        Me.tbx_año.TabIndex = 3
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Location = New System.Drawing.Point(184, 147)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.Font = New System.Drawing.Font("Prime", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resultado.ForeColor = System.Drawing.Color.Green
        Me.lbl_Resultado.Location = New System.Drawing.Point(109, 190)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(0, 23)
        Me.lbl_Resultado.TabIndex = 5
        '
        'lbl_agradecer
        '
        Me.lbl_agradecer.AutoSize = True
        Me.lbl_agradecer.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agradecer.ForeColor = System.Drawing.Color.Black
        Me.lbl_agradecer.Location = New System.Drawing.Point(112, 234)
        Me.lbl_agradecer.Name = "lbl_agradecer"
        Me.lbl_agradecer.Size = New System.Drawing.Size(243, 13)
        Me.lbl_agradecer.TabIndex = 6
        Me.lbl_agradecer.Text = "¡Gracias por usar mi programa!"
        Me.lbl_agradecer.Visible = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(153, 262)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(135, 16)
        Me.lbl_nombre.TabIndex = 7
        Me.lbl_nombre.Text = "Mi nombre es Manuel Diu"
        Me.lbl_nombre.Visible = False
        '
        'lbl_alumno
        '
        Me.lbl_alumno.AutoSize = True
        Me.lbl_alumno.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumno.ForeColor = System.Drawing.Color.Black
        Me.lbl_alumno.Location = New System.Drawing.Point(54, 296)
        Me.lbl_alumno.Name = "lbl_alumno"
        Me.lbl_alumno.Size = New System.Drawing.Size(344, 14)
        Me.lbl_alumno.TabIndex = 8
        Me.lbl_alumno.Text = "Soy alumno de 3ro. EMT de la Escuela Técnica María Espínola Espínola"
        Me.lbl_alumno.Visible = False
        '
        'frm_bisiesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 342)
        Me.Controls.Add(Me.lbl_alumno)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_agradecer)
        Me.Controls.Add(Me.lbl_Resultado)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.tbx_año)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_bienvenida)
        Me.Name = "frm_bisiesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Año Bisiesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_bienvenida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbx_año As TextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_Resultado As Label
    Friend WithEvents lbl_agradecer As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_alumno As Label
End Class
