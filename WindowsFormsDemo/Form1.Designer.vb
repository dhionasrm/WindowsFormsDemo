<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpbCalculadora = New System.Windows.Forms.GroupBox()
        Me.lblSomar = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.grpbCalculadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbCalculadora
        '
        Me.grpbCalculadora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpbCalculadora.Controls.Add(Me.lblSomar)
        Me.grpbCalculadora.Controls.Add(Me.lblResultado)
        Me.grpbCalculadora.Controls.Add(Me.txtResultado)
        Me.grpbCalculadora.Controls.Add(Me.btnSomar)
        Me.grpbCalculadora.Controls.Add(Me.txtValor2)
        Me.grpbCalculadora.Controls.Add(Me.lblValor2)
        Me.grpbCalculadora.Controls.Add(Me.txtValor1)
        Me.grpbCalculadora.Controls.Add(Me.lblValor1)
        Me.grpbCalculadora.Location = New System.Drawing.Point(13, 12)
        Me.grpbCalculadora.Name = "grpbCalculadora"
        Me.grpbCalculadora.Size = New System.Drawing.Size(576, 116)
        Me.grpbCalculadora.TabIndex = 0
        Me.grpbCalculadora.TabStop = False
        Me.grpbCalculadora.Text = "Soma"
        '
        'lblSomar
        '
        Me.lblSomar.AutoSize = True
        Me.lblSomar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSomar.Location = New System.Drawing.Point(177, 41)
        Me.lblSomar.Name = "lblSomar"
        Me.lblSomar.Size = New System.Drawing.Size(28, 30)
        Me.lblSomar.TabIndex = 7
        Me.lblSomar.Text = "+"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(431, 27)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(59, 15)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(431, 48)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtResultado.TabIndex = 5
        '
        'btnSomar
        '
        Me.btnSomar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSomar.Location = New System.Drawing.Point(339, 48)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(75, 23)
        Me.btnSomar.TabIndex = 4
        Me.btnSomar.Text = "="
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(220, 48)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 23)
        Me.txtValor2.TabIndex = 3
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.Location = New System.Drawing.Point(220, 30)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(39, 15)
        Me.lblValor2.TabIndex = 2
        Me.lblValor2.Text = "Valor2"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(55, 48)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 23)
        Me.txtValor1.TabIndex = 1
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Location = New System.Drawing.Point(55, 30)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(39, 15)
        Me.lblValor1.TabIndex = 0
        Me.lblValor1.Text = "Valor1"
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Location = New System.Drawing.Point(13, 135)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(41, 15)
        Me.lblAviso.TabIndex = 1
        Me.lblAviso.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 304)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.grpbCalculadora)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Natural"
        Me.grpbCalculadora.ResumeLayout(False)
        Me.grpbCalculadora.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpbCalculadora As GroupBox
    Friend WithEvents lblSomar As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSomar As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents lblValor2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents lblValor1 As Label
    Friend WithEvents lblAviso As Label
End Class
