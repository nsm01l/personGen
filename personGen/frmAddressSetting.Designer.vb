<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddressSetting
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
        Me.chkCity = New System.Windows.Forms.CheckBox()
        Me.chkCityAza = New System.Windows.Forms.CheckBox()
        Me.chkCityAzaBuilding = New System.Windows.Forms.CheckBox()
        Me.chkCityAzaBuildingFloor = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAddress3 = New System.Windows.Forms.CheckBox()
        Me.chkAddress2 = New System.Windows.Forms.CheckBox()
        Me.chkAddress1 = New System.Windows.Forms.CheckBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(178, 125)
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
        'chkCity
        '
        Me.chkCity.AutoSize = True
        Me.chkCity.Checked = True
        Me.chkCity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCity.Location = New System.Drawing.Point(6, 18)
        Me.chkCity.Name = "chkCity"
        Me.chkCity.Size = New System.Drawing.Size(104, 16)
        Me.chkCity.TabIndex = 1
        Me.chkCity.Text = "県 市町村 番地"
        Me.chkCity.UseVisualStyleBackColor = True
        '
        'chkCityAza
        '
        Me.chkCityAza.AutoSize = True
        Me.chkCityAza.Checked = True
        Me.chkCityAza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCityAza.Location = New System.Drawing.Point(6, 40)
        Me.chkCityAza.Name = "chkCityAza"
        Me.chkCityAza.Size = New System.Drawing.Size(132, 16)
        Me.chkCityAza.TabIndex = 2
        Me.chkCityAza.Text = "県 市町村 地区 番地"
        Me.chkCityAza.UseVisualStyleBackColor = True
        '
        'chkCityAzaBuilding
        '
        Me.chkCityAzaBuilding.AutoSize = True
        Me.chkCityAzaBuilding.Checked = True
        Me.chkCityAzaBuilding.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCityAzaBuilding.Location = New System.Drawing.Point(6, 62)
        Me.chkCityAzaBuilding.Name = "chkCityAzaBuilding"
        Me.chkCityAzaBuilding.Size = New System.Drawing.Size(160, 16)
        Me.chkCityAzaBuilding.TabIndex = 3
        Me.chkCityAzaBuilding.Text = "県 市町村 地区 番地 建物"
        Me.chkCityAzaBuilding.UseVisualStyleBackColor = True
        '
        'chkCityAzaBuildingFloor
        '
        Me.chkCityAzaBuildingFloor.AutoSize = True
        Me.chkCityAzaBuildingFloor.Checked = True
        Me.chkCityAzaBuildingFloor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCityAzaBuildingFloor.Location = New System.Drawing.Point(6, 84)
        Me.chkCityAzaBuildingFloor.Name = "chkCityAzaBuildingFloor"
        Me.chkCityAzaBuildingFloor.Size = New System.Drawing.Size(176, 16)
        Me.chkCityAzaBuildingFloor.TabIndex = 4
        Me.chkCityAzaBuildingFloor.Text = "県 市町村 地区 番地 建物 階"
        Me.chkCityAzaBuildingFloor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCityAzaBuildingFloor)
        Me.GroupBox1.Controls.Add(Me.chkCityAzaBuilding)
        Me.GroupBox1.Controls.Add(Me.chkCityAza)
        Me.GroupBox1.Controls.Add(Me.chkCity)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "住所"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAddress3)
        Me.GroupBox2.Controls.Add(Me.chkAddress2)
        Me.GroupBox2.Controls.Add(Me.chkAddress1)
        Me.GroupBox2.Location = New System.Drawing.Point(219, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 84)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "番地"
        '
        'chkAddress3
        '
        Me.chkAddress3.AutoSize = True
        Me.chkAddress3.Checked = True
        Me.chkAddress3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAddress3.Location = New System.Drawing.Point(6, 62)
        Me.chkAddress3.Name = "chkAddress3"
        Me.chkAddress3.Size = New System.Drawing.Size(85, 16)
        Me.chkAddress3.TabIndex = 2
        Me.chkAddress3.Text = "XXX-XX-XX"
        Me.chkAddress3.UseVisualStyleBackColor = True
        '
        'chkAddress2
        '
        Me.chkAddress2.AutoSize = True
        Me.chkAddress2.Checked = True
        Me.chkAddress2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAddress2.Location = New System.Drawing.Point(6, 40)
        Me.chkAddress2.Name = "chkAddress2"
        Me.chkAddress2.Size = New System.Drawing.Size(65, 16)
        Me.chkAddress2.TabIndex = 1
        Me.chkAddress2.Text = "XXX-XX"
        Me.chkAddress2.UseVisualStyleBackColor = True
        '
        'chkAddress1
        '
        Me.chkAddress1.AutoSize = True
        Me.chkAddress1.Checked = True
        Me.chkAddress1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAddress1.Location = New System.Drawing.Point(6, 18)
        Me.chkAddress1.Name = "chkAddress1"
        Me.chkAddress1.Size = New System.Drawing.Size(52, 16)
        Me.chkAddress1.TabIndex = 0
        Me.chkAddress1.Text = "XXXX"
        Me.chkAddress1.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(24, 125)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(58, 24)
        Me.btnAll.TabIndex = 7
        Me.btnAll.Text = "全選択"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmAddressSetting
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(336, 163)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddressSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "住所生成パターンの設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents chkCity As System.Windows.Forms.CheckBox
    Friend WithEvents chkCityAza As System.Windows.Forms.CheckBox
    Friend WithEvents chkCityAzaBuilding As System.Windows.Forms.CheckBox
    Friend WithEvents chkCityAzaBuildingFloor As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAddress3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddress2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddress1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAll As System.Windows.Forms.Button

End Class
