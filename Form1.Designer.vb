<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblmasa = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblunidades = New System.Windows.Forms.Label()
        Me.cbxunidades = New System.Windows.Forms.ComboBox()
        Me.lblpasar = New System.Windows.Forms.Label()
        Me.cbxpasar = New System.Windows.Forms.ComboBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblmasa
        '
        Me.lblmasa.AutoSize = True
        Me.lblmasa.Location = New System.Drawing.Point(59, 48)
        Me.lblmasa.Name = "lblmasa"
        Me.lblmasa.Size = New System.Drawing.Size(33, 13)
        Me.lblmasa.TabIndex = 0
        Me.lblmasa.Text = "Masa"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(99, 48)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 1
        '
        'lblunidades
        '
        Me.lblunidades.AutoSize = True
        Me.lblunidades.Location = New System.Drawing.Point(40, 93)
        Me.lblunidades.Name = "lblunidades"
        Me.lblunidades.Size = New System.Drawing.Size(52, 13)
        Me.lblunidades.TabIndex = 2
        Me.lblunidades.Text = "Unidades"
        '
        'cbxunidades
        '
        Me.cbxunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxunidades.FormattingEnabled = True
        Me.cbxunidades.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxunidades.Location = New System.Drawing.Point(89, 90)
        Me.cbxunidades.Name = "cbxunidades"
        Me.cbxunidades.Size = New System.Drawing.Size(121, 21)
        Me.cbxunidades.TabIndex = 3
        '
        'lblpasar
        '
        Me.lblpasar.AutoSize = True
        Me.lblpasar.Location = New System.Drawing.Point(40, 132)
        Me.lblpasar.Name = "lblpasar"
        Me.lblpasar.Size = New System.Drawing.Size(43, 13)
        Me.lblpasar.TabIndex = 4
        Me.lblpasar.Text = "Pasar a"
        '
        'cbxpasar
        '
        Me.cbxpasar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpasar.FormattingEnabled = True
        Me.cbxpasar.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxpasar.Location = New System.Drawing.Point(89, 129)
        Me.cbxpasar.Name = "cbxpasar"
        Me.cbxpasar.Size = New System.Drawing.Size(121, 21)
        Me.cbxpasar.TabIndex = 5
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(99, 156)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 6
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(290, 51)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(55, 13)
        Me.lblresultado.TabIndex = 7
        Me.lblresultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.cbxpasar)
        Me.Controls.Add(Me.lblpasar)
        Me.Controls.Add(Me.cbxunidades)
        Me.Controls.Add(Me.lblunidades)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.lblmasa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmasa As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents lblunidades As Label
    Friend WithEvents cbxunidades As ComboBox
    Friend WithEvents lblpasar As Label
    Friend WithEvents cbxpasar As ComboBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents lblresultado As Label
End Class
