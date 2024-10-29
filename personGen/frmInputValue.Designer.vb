<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputValue
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.all = New System.Windows.Forms.Button()
        Me.useSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maxSize = New System.Windows.Forms.Label()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnInc = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.all, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 90)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(210, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(139, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(68, 21)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "キャンセル"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(67, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(65, 21)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "OK"
        '
        'all
        '
        Me.all.Location = New System.Drawing.Point(3, 3)
        Me.all.Name = "all"
        Me.all.Size = New System.Drawing.Size(57, 21)
        Me.all.TabIndex = 0
        Me.all.Text = "すべて"
        Me.all.UseVisualStyleBackColor = True
        '
        'useSize
        '
        Me.useSize.Location = New System.Drawing.Point(37, 33)
        Me.useSize.Name = "useSize"
        Me.useSize.Size = New System.Drawing.Size(100, 19)
        Me.useSize.TabIndex = 1
        Me.useSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "利用データ数"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "/"
        '
        'maxSize
        '
        Me.maxSize.AutoSize = True
        Me.maxSize.Location = New System.Drawing.Point(160, 36)
        Me.maxSize.Name = "maxSize"
        Me.maxSize.Size = New System.Drawing.Size(47, 12)
        Me.maxSize.TabIndex = 3
        Me.maxSize.Text = "maxSize"
        '
        'btnDec
        '
        Me.btnDec.Location = New System.Drawing.Point(37, 58)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(21, 20)
        Me.btnDec.TabIndex = 4
        Me.btnDec.Text = "-"
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btnInc
        '
        Me.btnInc.Location = New System.Drawing.Point(116, 58)
        Me.btnInc.Name = "btnInc"
        Me.btnInc.Size = New System.Drawing.Size(21, 20)
        Me.btnInc.TabIndex = 5
        Me.btnInc.Text = "+"
        Me.btnInc.UseVisualStyleBackColor = True
        '
        'frmInputValue
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(230, 129)
        Me.Controls.Add(Me.btnInc)
        Me.Controls.Add(Me.btnDec)
        Me.Controls.Add(Me.maxSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.useSize)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputValue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "利用データ数"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents useSize As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maxSize As System.Windows.Forms.Label
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents btnInc As System.Windows.Forms.Button
    Friend WithEvents all As System.Windows.Forms.Button

End Class
