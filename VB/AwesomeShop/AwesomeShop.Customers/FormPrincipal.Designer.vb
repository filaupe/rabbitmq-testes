<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMsgs = New System.Windows.Forms.TextBox()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.DataGridViewMsgs = New System.Windows.Forms.DataGridView()
        Me.ColumnMsgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewMsgs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escreva a mensagem:"
        '
        'TextBoxMsgs
        '
        Me.TextBoxMsgs.Location = New System.Drawing.Point(16, 30)
        Me.TextBoxMsgs.Name = "TextBoxMsgs"
        Me.TextBoxMsgs.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxMsgs.TabIndex = 1
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(230, 30)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(79, 26)
        Me.ButtonEnviar.TabIndex = 2
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'DataGridViewMsgs
        '
        Me.DataGridViewMsgs.AllowUserToAddRows = False
        Me.DataGridViewMsgs.AllowUserToDeleteRows = False
        Me.DataGridViewMsgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMsgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMsgs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnMsgs})
        Me.DataGridViewMsgs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewMsgs.Location = New System.Drawing.Point(0, 72)
        Me.DataGridViewMsgs.Name = "DataGridViewMsgs"
        Me.DataGridViewMsgs.ReadOnly = True
        Me.DataGridViewMsgs.RowHeadersVisible = False
        Me.DataGridViewMsgs.Size = New System.Drawing.Size(321, 142)
        Me.DataGridViewMsgs.TabIndex = 3
        '
        'ColumnMsgs
        '
        Me.ColumnMsgs.HeaderText = "Mensagens Enviadas"
        Me.ColumnMsgs.Name = "ColumnMsgs"
        Me.ColumnMsgs.ReadOnly = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 214)
        Me.Controls.Add(Me.DataGridViewMsgs)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.TextBoxMsgs)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        CType(Me.DataGridViewMsgs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMsgs As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents DataGridViewMsgs As DataGridView
    Friend WithEvents ColumnMsgs As DataGridViewTextBoxColumn
End Class
