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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FlatLabel2 = New Updater_Deezloader.FlatLabel()
        Me.FlatLabel1 = New Updater_Deezloader.FlatLabel()
        Me.FlatProgressBar1 = New Updater_Deezloader.FlatProgressBar()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 600
        '
        'ProgressBarTimer
        '
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(12, 30)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(74, 13)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "$text_update"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(12, 14)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(78, 13)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "$text_showed"
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.FlatProgressBar1.Location = New System.Drawing.Point(12, 30)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatProgressBar1.Size = New System.Drawing.Size(261, 42)
        Me.FlatProgressBar1.TabIndex = 0
        Me.FlatProgressBar1.Text = "FlatProgressBar1"
        Me.FlatProgressBar1.Value = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(285, 84)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.FlatProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatProgressBar1 As Updater_Deezloader.FlatProgressBar
    Friend WithEvents FlatLabel1 As Updater_Deezloader.FlatLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBarTimer As System.Windows.Forms.Timer
    Friend WithEvents FlatLabel2 As Updater_Deezloader.FlatLabel

End Class
