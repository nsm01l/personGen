﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhoneScale
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minPhone = New System.Windows.Forms.TextBox()
        Me.maxPhone = New System.Windows.Forms.TextBox()
        Me.btnMinMinus = New System.Windows.Forms.Button()
        Me.btnMinPlus = New System.Windows.Forms.Button()
        Me.btnMaxPlus = New System.Windows.Forms.Button()
        Me.btnMaxMinus = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 81)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "最小"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "最大"
        '
        'minPhone
        '
        Me.minPhone.Location = New System.Drawing.Point(94, 6)
        Me.minPhone.Name = "minPhone"
        Me.minPhone.Size = New System.Drawing.Size(45, 19)
        Me.minPhone.TabIndex = 2
        Me.minPhone.Text = "6"
        Me.minPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'maxPhone
        '
        Me.maxPhone.Location = New System.Drawing.Point(94, 42)
        Me.maxPhone.Name = "maxPhone"
        Me.maxPhone.Size = New System.Drawing.Size(45, 19)
        Me.maxPhone.TabIndex = 6
        Me.maxPhone.Text = "11"
        Me.maxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMinMinus
        '
        Me.btnMinMinus.Location = New System.Drawing.Point(62, 5)
        Me.btnMinMinus.Name = "btnMinMinus"
        Me.btnMinMinus.Size = New System.Drawing.Size(26, 20)
        Me.btnMinMinus.TabIndex = 1
        Me.btnMinMinus.Text = "-"
        Me.btnMinMinus.UseVisualStyleBackColor = True
        '
        'btnMinPlus
        '
        Me.btnMinPlus.Location = New System.Drawing.Point(145, 5)
        Me.btnMinPlus.Name = "btnMinPlus"
        Me.btnMinPlus.Size = New System.Drawing.Size(26, 20)
        Me.btnMinPlus.TabIndex = 3
        Me.btnMinPlus.Text = "+"
        Me.btnMinPlus.UseVisualStyleBackColor = True
        '
        'btnMaxPlus
        '
        Me.btnMaxPlus.Location = New System.Drawing.Point(145, 41)
        Me.btnMaxPlus.Name = "btnMaxPlus"
        Me.btnMaxPlus.Size = New System.Drawing.Size(26, 20)
        Me.btnMaxPlus.TabIndex = 7
        Me.btnMaxPlus.Text = "+"
        Me.btnMaxPlus.UseVisualStyleBackColor = True
        '
        'btnMaxMinus
        '
        Me.btnMaxMinus.Location = New System.Drawing.Point(62, 41)
        Me.btnMaxMinus.Name = "btnMaxMinus"
        Me.btnMaxMinus.Size = New System.Drawing.Size(26, 20)
        Me.btnMaxMinus.TabIndex = 5
        Me.btnMaxMinus.Text = "-"
        Me.btnMaxMinus.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(189, 21)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(62, 26)
        Me.btnDefault.TabIndex = 8
        Me.btnDefault.Text = "デフォルト"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'frmPhoneScale
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(263, 120)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnMaxPlus)
        Me.Controls.Add(Me.btnMaxMinus)
        Me.Controls.Add(Me.btnMinPlus)
        Me.Controls.Add(Me.btnMinMinus)
        Me.Controls.Add(Me.maxPhone)
        Me.Controls.Add(Me.minPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhoneScale"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "電話番号の桁数"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents minPhone As System.Windows.Forms.TextBox
    Friend WithEvents maxPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnMinMinus As System.Windows.Forms.Button
    Friend WithEvents btnMinPlus As System.Windows.Forms.Button
    Friend WithEvents btnMaxPlus As System.Windows.Forms.Button
    Friend WithEvents btnMaxMinus As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button

End Class