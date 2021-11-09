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
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubResultado = New System.Windows.Forms.TextBox()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.txtSub2 = New System.Windows.Forms.TextBox()
        Me.txtSub1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMultResultado = New System.Windows.Forms.TextBox()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.txtMult2 = New System.Windows.Forms.TextBox()
        Me.txtMult1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDivResultado = New System.Windows.Forms.TextBox()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.txtDiv2 = New System.Windows.Forms.TextBox()
        Me.txtDiv1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRaizResultado = New System.Windows.Forms.TextBox()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.txtRaizQuadrada = New System.Windows.Forms.TextBox()
        Me.grpbCalculadora.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbCalculadora
        '
        Me.grpbCalculadora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpbCalculadora.Controls.Add(Me.lblSomar)
        Me.grpbCalculadora.Controls.Add(Me.txtResultado)
        Me.grpbCalculadora.Controls.Add(Me.btnSomar)
        Me.grpbCalculadora.Controls.Add(Me.txtValor2)
        Me.grpbCalculadora.Controls.Add(Me.txtValor1)
        Me.grpbCalculadora.Location = New System.Drawing.Point(13, 12)
        Me.grpbCalculadora.Name = "grpbCalculadora"
        Me.grpbCalculadora.Size = New System.Drawing.Size(511, 63)
        Me.grpbCalculadora.TabIndex = 0
        Me.grpbCalculadora.TabStop = False
        Me.grpbCalculadora.Text = "Soma"
        '
        'lblSomar
        '
        Me.lblSomar.AutoSize = True
        Me.lblSomar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSomar.Location = New System.Drawing.Point(132, 15)
        Me.lblSomar.Name = "lblSomar"
        Me.lblSomar.Size = New System.Drawing.Size(28, 30)
        Me.lblSomar.TabIndex = 7
        Me.lblSomar.Text = "+"
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(386, 22)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtResultado.TabIndex = 5
        '
        'btnSomar
        '
        Me.btnSomar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSomar.Location = New System.Drawing.Point(288, 22)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(75, 23)
        Me.btnSomar.TabIndex = 4
        Me.btnSomar.Text = "="
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(166, 22)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 23)
        Me.txtValor2.TabIndex = 3
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(26, 22)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 23)
        Me.txtValor1.TabIndex = 1
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Location = New System.Drawing.Point(13, 376)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(41, 15)
        Me.lblAviso.TabIndex = 1
        Me.lblAviso.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSubResultado)
        Me.GroupBox1.Controls.Add(Me.btnSubtrair)
        Me.GroupBox1.Controls.Add(Me.txtSub2)
        Me.GroupBox1.Controls.Add(Me.txtSub1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subtração"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(138, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "-"
        '
        'txtSubResultado
        '
        Me.txtSubResultado.Enabled = False
        Me.txtSubResultado.Location = New System.Drawing.Point(386, 22)
        Me.txtSubResultado.Name = "txtSubResultado"
        Me.txtSubResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtSubResultado.TabIndex = 5
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtrair.Location = New System.Drawing.Point(288, 22)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtrair.TabIndex = 4
        Me.btnSubtrair.Text = "="
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'txtSub2
        '
        Me.txtSub2.Location = New System.Drawing.Point(166, 22)
        Me.txtSub2.Name = "txtSub2"
        Me.txtSub2.Size = New System.Drawing.Size(100, 23)
        Me.txtSub2.TabIndex = 3
        '
        'txtSub1
        '
        Me.txtSub1.Location = New System.Drawing.Point(26, 22)
        Me.txtSub1.Name = "txtSub1"
        Me.txtSub1.Size = New System.Drawing.Size(100, 23)
        Me.txtSub1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMultResultado)
        Me.GroupBox2.Controls.Add(Me.btnMultiplicar)
        Me.GroupBox2.Controls.Add(Me.txtMult2)
        Me.GroupBox2.Controls.Add(Me.txtMult1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 63)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multiplicação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(138, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*"
        '
        'txtMultResultado
        '
        Me.txtMultResultado.Enabled = False
        Me.txtMultResultado.Location = New System.Drawing.Point(386, 22)
        Me.txtMultResultado.Name = "txtMultResultado"
        Me.txtMultResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtMultResultado.TabIndex = 5
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiplicar.Location = New System.Drawing.Point(288, 22)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 4
        Me.btnMultiplicar.Text = "="
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'txtMult2
        '
        Me.txtMult2.Location = New System.Drawing.Point(166, 22)
        Me.txtMult2.Name = "txtMult2"
        Me.txtMult2.Size = New System.Drawing.Size(100, 23)
        Me.txtMult2.TabIndex = 3
        '
        'txtMult1
        '
        Me.txtMult1.Location = New System.Drawing.Point(26, 22)
        Me.txtMult1.Name = "txtMult1"
        Me.txtMult1.Size = New System.Drawing.Size(100, 23)
        Me.txtMult1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDivResultado)
        Me.GroupBox3.Controls.Add(Me.btnDividir)
        Me.GroupBox3.Controls.Add(Me.txtDiv2)
        Me.GroupBox3.Controls.Add(Me.txtDiv1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(511, 63)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Divisão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(138, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "/"
        '
        'txtDivResultado
        '
        Me.txtDivResultado.Enabled = False
        Me.txtDivResultado.Location = New System.Drawing.Point(386, 22)
        Me.txtDivResultado.Name = "txtDivResultado"
        Me.txtDivResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtDivResultado.TabIndex = 5
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDividir.Location = New System.Drawing.Point(288, 22)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 4
        Me.btnDividir.Text = "="
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'txtDiv2
        '
        Me.txtDiv2.Location = New System.Drawing.Point(166, 22)
        Me.txtDiv2.Name = "txtDiv2"
        Me.txtDiv2.Size = New System.Drawing.Size(100, 23)
        Me.txtDiv2.TabIndex = 3
        '
        'txtDiv1
        '
        Me.txtDiv1.Location = New System.Drawing.Point(26, 22)
        Me.txtDiv1.Name = "txtDiv1"
        Me.txtDiv1.Size = New System.Drawing.Size(100, 23)
        Me.txtDiv1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtRaizResultado)
        Me.GroupBox4.Controls.Add(Me.btnRaiz)
        Me.GroupBox4.Controls.Add(Me.txtRaizQuadrada)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 288)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(511, 63)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Raiz Quadrada"
        '
        'txtRaizResultado
        '
        Me.txtRaizResultado.Enabled = False
        Me.txtRaizResultado.Location = New System.Drawing.Point(386, 22)
        Me.txtRaizResultado.Name = "txtRaizResultado"
        Me.txtRaizResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtRaizResultado.TabIndex = 5
        '
        'btnRaiz
        '
        Me.btnRaiz.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRaiz.Location = New System.Drawing.Point(288, 22)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(75, 23)
        Me.btnRaiz.TabIndex = 4
        Me.btnRaiz.Text = "="
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'txtRaizQuadrada
        '
        Me.txtRaizQuadrada.Location = New System.Drawing.Point(166, 22)
        Me.txtRaizQuadrada.Name = "txtRaizQuadrada"
        Me.txtRaizQuadrada.Size = New System.Drawing.Size(100, 23)
        Me.txtRaizQuadrada.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(541, 400)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbCalculadora)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Natural"
        Me.grpbCalculadora.ResumeLayout(False)
        Me.grpbCalculadora.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpbCalculadora As GroupBox
    Friend WithEvents lblSomar As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSomar As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents lblAviso As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubResultado As TextBox
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents txtSub2 As TextBox
    Friend WithEvents txtSub1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMultResultado As TextBox
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents txtMult2 As TextBox
    Friend WithEvents txtMult1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDivResultado As TextBox
    Friend WithEvents btnDividir As Button
    Friend WithEvents txtDiv2 As TextBox
    Friend WithEvents txtDiv1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtRaizResultado As TextBox
    Friend WithEvents btnRaiz As Button
    Friend WithEvents txtRaizQuadrada As TextBox
End Class
