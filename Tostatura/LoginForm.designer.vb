<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTXT As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.PasswordTXT = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.OperatoreTXT = New System.Windows.Forms.ComboBox
        Me.OperatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TostaturaDataSet = New Tostatura.TostaturaDataSet
        Me.OperatoriTableAdapter = New Tostatura.TostaturaDataSetTableAdapters.OperatoriTableAdapter
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UsernameLabel.Location = New System.Drawing.Point(208, 19)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 28)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Operatore"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PasswordLabel.Location = New System.Drawing.Point(208, 90)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 28)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTXT
        '
        Me.PasswordTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTXT.Location = New System.Drawing.Point(207, 121)
        Me.PasswordTXT.Name = "PasswordTXT"
        Me.PasswordTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTXT.Size = New System.Drawing.Size(220, 26)
        Me.PasswordTXT.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackgroundImage = CType(resources.GetObject("OK.BackgroundImage"), System.Drawing.Image)
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OK.Location = New System.Drawing.Point(187, 191)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(131, 41)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Cancel.Location = New System.Drawing.Point(337, 191)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(123, 41)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Annulla"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'OperatoreTXT
        '
        Me.OperatoreTXT.DataSource = Me.OperatoriBindingSource
        Me.OperatoreTXT.DisplayMember = "nome"
        Me.OperatoreTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OperatoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatoreTXT.FormattingEnabled = True
        Me.OperatoreTXT.Location = New System.Drawing.Point(207, 50)
        Me.OperatoreTXT.Name = "OperatoreTXT"
        Me.OperatoreTXT.Size = New System.Drawing.Size(218, 28)
        Me.OperatoreTXT.TabIndex = 6
        Me.OperatoreTXT.ValueMember = "nome"
        '
        'OperatoriBindingSource
        '
        Me.OperatoriBindingSource.DataMember = "Operatori"
        Me.OperatoriBindingSource.DataSource = Me.TostaturaDataSet
        '
        'TostaturaDataSet
        '
        Me.TostaturaDataSet.DataSetName = "TostaturaDataSet"
        Me.TostaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperatoriTableAdapter
        '
        Me.OperatoriTableAdapter.ClearBeforeFill = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(472, 248)
        Me.Controls.Add(Me.OperatoreTXT)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTXT)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TostaturaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OperatoreTXT As System.Windows.Forms.ComboBox
    Friend WithEvents OperatoriTableAdapter As Tostatura.TostaturaDataSetTableAdapters.OperatoriTableAdapter
    Friend WithEvents TostaturaDataSet As Tostatura.TostaturaDataSet
    Friend WithEvents OperatoriBindingSource As System.Windows.Forms.BindingSource

End Class
