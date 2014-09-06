<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    Private operatore As Operatore

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public Sub New(ByVal op As Operatore)
        InitializeComponent()
        Me.operatore = op
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.CodOpLbl = New System.Windows.Forms.Label
        Me.OpLbl = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PoohFinsETN1 = New PoohPlcLink.PoohFinsETN
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BttStatistiche = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodOpLbl
        '
        Me.CodOpLbl.AutoSize = True
        Me.CodOpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodOpLbl.Location = New System.Drawing.Point(661, 548)
        Me.CodOpLbl.Name = "CodOpLbl"
        Me.CodOpLbl.Size = New System.Drawing.Size(56, 16)
        Me.CodOpLbl.TabIndex = 25
        Me.CodOpLbl.Text = "Label20"
        '
        'OpLbl
        '
        Me.OpLbl.AutoSize = True
        Me.OpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpLbl.Location = New System.Drawing.Point(661, 521)
        Me.OpLbl.Name = "OpLbl"
        Me.OpLbl.Size = New System.Drawing.Size(56, 16)
        Me.OpLbl.TabIndex = 23
        Me.OpLbl.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(583, 548)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Codice:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(583, 521)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Operatore:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PoohFinsETN1
        '
        Me.PoohFinsETN1.PC_NetNo = CType(0, Byte)
        Me.PoohFinsETN1.PC_NodeNo = CType(1, Byte)
        Me.PoohFinsETN1.PLC_IPAddress = "192.168.0.16"
        Me.PoohFinsETN1.PLC_NetNo = CType(0, Byte)
        Me.PoohFinsETN1.PLC_NodeNo = CType(0, Byte)
        Me.PoohFinsETN1.PLC_UDPPort = CType(9600US, UShort)
        Me.PoohFinsETN1.TimeOutMSec = 500
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(412, 470)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tostatura.My.Resources.Resources.Logo_its_Blu1
        Me.PictureBox2.Location = New System.Drawing.Point(21, 452)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Tostatura.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(72, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 218)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BttStatistiche
        '
        Me.BttStatistiche.BackgroundImage = Global.Tostatura.My.Resources.Resources.BtnBck
        Me.BttStatistiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BttStatistiche.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BttStatistiche.Location = New System.Drawing.Point(586, 407)
        Me.BttStatistiche.Name = "BttStatistiche"
        Me.BttStatistiche.Size = New System.Drawing.Size(269, 48)
        Me.BttStatistiche.TabIndex = 2
        Me.BttStatistiche.Text = "Statistiche"
        Me.BttStatistiche.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Tostatura.My.Resources.Resources.BtnBck
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(586, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(269, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Gestione Formule"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Tostatura.My.Resources.Resources.BtnBck
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(586, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Gestione Anagrafiche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Tostatura.My.Resources.Resources.BtnBck
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(586, 461)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(269, 48)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Cambia Operatore"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(882, 578)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CodOpLbl)
        Me.Controls.Add(Me.OpLbl)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BttStatistiche)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Scada Management (Licenza Licata + Greutol sede di Canicattì)"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BttStatistiche As System.Windows.Forms.Button
    Friend WithEvents CodOpLbl As System.Windows.Forms.Label
    Friend WithEvents OpLbl As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PoohFinsETN1 As PoohPlcLink.PoohFinsETN
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
