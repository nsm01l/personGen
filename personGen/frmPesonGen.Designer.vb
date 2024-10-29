<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesonGen
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.givenConfig = New System.Windows.Forms.Button()
        Me.familyConfig = New System.Windows.Forms.Button()
        Me.ageScaleShow = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.birthDate = New System.Windows.Forms.CheckBox()
        Me.ageScale = New System.Windows.Forms.Button()
        Me.genderPtn = New System.Windows.Forms.ComboBox()
        Me.givenRuby = New System.Windows.Forms.CheckBox()
        Me.familyRuby = New System.Windows.Forms.CheckBox()
        Me.gender = New System.Windows.Forms.CheckBox()
        Me.age = New System.Windows.Forms.CheckBox()
        Me.given = New System.Windows.Forms.CheckBox()
        Me.family = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.phoneConfig = New System.Windows.Forms.Button()
        Me.addressConfig = New System.Windows.Forms.Button()
        Me.addressRuby = New System.Windows.Forms.CheckBox()
        Me.phoneScale = New System.Windows.Forms.Button()
        Me.zipSplit = New System.Windows.Forms.CheckBox()
        Me.phone = New System.Windows.Forms.CheckBox()
        Me.address = New System.Windows.Forms.CheckBox()
        Me.zip = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gen = New System.Windows.Forms.Button()
        Me.log = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.noShow = New System.Windows.Forms.CheckBox()
        Me.noFile = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.delim = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.genSize = New System.Windows.Forms.TextBox()
        Me.reloadData = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.post = New System.Windows.Forms.CheckBox()
        Me.job = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.givenConfig)
        Me.GroupBox1.Controls.Add(Me.familyConfig)
        Me.GroupBox1.Controls.Add(Me.ageScaleShow)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.birthDate)
        Me.GroupBox1.Controls.Add(Me.ageScale)
        Me.GroupBox1.Controls.Add(Me.genderPtn)
        Me.GroupBox1.Controls.Add(Me.givenRuby)
        Me.GroupBox1.Controls.Add(Me.familyRuby)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.age)
        Me.GroupBox1.Controls.Add(Me.given)
        Me.GroupBox1.Controls.Add(Me.family)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "人物(1)"
        '
        'givenConfig
        '
        Me.givenConfig.Location = New System.Drawing.Point(161, 35)
        Me.givenConfig.Name = "givenConfig"
        Me.givenConfig.Size = New System.Drawing.Size(75, 18)
        Me.givenConfig.TabIndex = 14
        Me.givenConfig.Text = "c"
        Me.givenConfig.UseVisualStyleBackColor = True
        '
        'familyConfig
        '
        Me.familyConfig.Location = New System.Drawing.Point(161, 13)
        Me.familyConfig.Name = "familyConfig"
        Me.familyConfig.Size = New System.Drawing.Size(75, 18)
        Me.familyConfig.TabIndex = 13
        Me.familyConfig.Text = "c"
        Me.familyConfig.UseVisualStyleBackColor = True
        '
        'ageScaleShow
        '
        Me.ageScaleShow.AutoSize = True
        Me.ageScaleShow.Location = New System.Drawing.Point(154, 60)
        Me.ageScaleShow.Name = "ageScaleShow"
        Me.ageScaleShow.Size = New System.Drawing.Size(43, 12)
        Me.ageScaleShow.TabIndex = 10
        Me.ageScaleShow.Text = "0 - 120"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(84, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 21)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "詳細設定"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'birthDate
        '
        Me.birthDate.AutoSize = True
        Me.birthDate.Location = New System.Drawing.Point(7, 81)
        Me.birthDate.Name = "birthDate"
        Me.birthDate.Size = New System.Drawing.Size(72, 16)
        Me.birthDate.TabIndex = 6
        Me.birthDate.Text = "生年月日"
        Me.birthDate.UseVisualStyleBackColor = True
        '
        'ageScale
        '
        Me.ageScale.Enabled = False
        Me.ageScale.Location = New System.Drawing.Point(84, 57)
        Me.ageScale.Name = "ageScale"
        Me.ageScale.Size = New System.Drawing.Size(57, 19)
        Me.ageScale.TabIndex = 5
        Me.ageScale.Text = "範囲"
        Me.ageScale.UseVisualStyleBackColor = True
        '
        'genderPtn
        '
        Me.genderPtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderPtn.Enabled = False
        Me.genderPtn.FormattingEnabled = True
        Me.genderPtn.Items.AddRange(New Object() {"m/f", "male/female", "m/w", "man/woman", "男/女", "男性/女性"})
        Me.genderPtn.Location = New System.Drawing.Point(84, 102)
        Me.genderPtn.Name = "genderPtn"
        Me.genderPtn.Size = New System.Drawing.Size(108, 20)
        Me.genderPtn.TabIndex = 9
        '
        'givenRuby
        '
        Me.givenRuby.AutoSize = True
        Me.givenRuby.Location = New System.Drawing.Point(76, 37)
        Me.givenRuby.Name = "givenRuby"
        Me.givenRuby.Size = New System.Drawing.Size(74, 16)
        Me.givenRuby.TabIndex = 3
        Me.givenRuby.Text = "名前(ルビ)"
        Me.givenRuby.UseVisualStyleBackColor = True
        '
        'familyRuby
        '
        Me.familyRuby.AutoSize = True
        Me.familyRuby.Location = New System.Drawing.Point(76, 15)
        Me.familyRuby.Name = "familyRuby"
        Me.familyRuby.Size = New System.Drawing.Size(74, 16)
        Me.familyRuby.TabIndex = 1
        Me.familyRuby.Text = "名字(ルビ)"
        Me.familyRuby.UseVisualStyleBackColor = True
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(7, 104)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(48, 16)
        Me.gender.TabIndex = 8
        Me.gender.Text = "性別"
        Me.gender.UseVisualStyleBackColor = True
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Location = New System.Drawing.Point(6, 59)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(48, 16)
        Me.age.TabIndex = 4
        Me.age.Text = "年齢"
        Me.age.UseVisualStyleBackColor = True
        '
        'given
        '
        Me.given.AutoSize = True
        Me.given.Location = New System.Drawing.Point(6, 37)
        Me.given.Name = "given"
        Me.given.Size = New System.Drawing.Size(48, 16)
        Me.given.TabIndex = 2
        Me.given.Text = "名前"
        Me.given.UseVisualStyleBackColor = True
        '
        'family
        '
        Me.family.AutoSize = True
        Me.family.Location = New System.Drawing.Point(6, 15)
        Me.family.Name = "family"
        Me.family.Size = New System.Drawing.Size(48, 16)
        Me.family.TabIndex = 0
        Me.family.Text = "名字"
        Me.family.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.phoneConfig)
        Me.GroupBox2.Controls.Add(Me.addressConfig)
        Me.GroupBox2.Controls.Add(Me.addressRuby)
        Me.GroupBox2.Controls.Add(Me.phoneScale)
        Me.GroupBox2.Controls.Add(Me.zipSplit)
        Me.GroupBox2.Controls.Add(Me.phone)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.zip)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "住所(2)"
        '
        'phoneConfig
        '
        Me.phoneConfig.Enabled = False
        Me.phoneConfig.Location = New System.Drawing.Point(156, 60)
        Me.phoneConfig.Name = "phoneConfig"
        Me.phoneConfig.Size = New System.Drawing.Size(71, 21)
        Me.phoneConfig.TabIndex = 7
        Me.phoneConfig.Text = "番号詳細"
        Me.phoneConfig.UseVisualStyleBackColor = True
        '
        'addressConfig
        '
        Me.addressConfig.Enabled = False
        Me.addressConfig.Location = New System.Drawing.Point(156, 37)
        Me.addressConfig.Name = "addressConfig"
        Me.addressConfig.Size = New System.Drawing.Size(71, 21)
        Me.addressConfig.TabIndex = 4
        Me.addressConfig.Text = "住所詳細"
        Me.addressConfig.UseVisualStyleBackColor = True
        '
        'addressRuby
        '
        Me.addressRuby.AutoSize = True
        Me.addressRuby.Enabled = False
        Me.addressRuby.Location = New System.Drawing.Point(84, 40)
        Me.addressRuby.Name = "addressRuby"
        Me.addressRuby.Size = New System.Drawing.Size(66, 16)
        Me.addressRuby.TabIndex = 3
        Me.addressRuby.Text = "住所ルビ"
        Me.addressRuby.UseVisualStyleBackColor = True
        '
        'phoneScale
        '
        Me.phoneScale.Enabled = False
        Me.phoneScale.Location = New System.Drawing.Point(84, 60)
        Me.phoneScale.Name = "phoneScale"
        Me.phoneScale.Size = New System.Drawing.Size(57, 20)
        Me.phoneScale.TabIndex = 6
        Me.phoneScale.Text = "範囲"
        Me.phoneScale.UseVisualStyleBackColor = True
        '
        'zipSplit
        '
        Me.zipSplit.AutoSize = True
        Me.zipSplit.Enabled = False
        Me.zipSplit.Location = New System.Drawing.Point(84, 18)
        Me.zipSplit.Name = "zipSplit"
        Me.zipSplit.Size = New System.Drawing.Size(80, 16)
        Me.zipSplit.TabIndex = 1
        Me.zipSplit.Text = "郵便区切り"
        Me.zipSplit.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(6, 62)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(72, 16)
        Me.phone.TabIndex = 5
        Me.phone.Text = "電話番号"
        Me.phone.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(6, 40)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(48, 16)
        Me.address.TabIndex = 2
        Me.address.Text = "住所"
        Me.address.UseVisualStyleBackColor = True
        '
        'zip
        '
        Me.zip.AutoSize = True
        Me.zip.Location = New System.Drawing.Point(6, 18)
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(72, 16)
        Me.zip.TabIndex = 0
        Me.zip.Text = "郵便番号"
        Me.zip.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(436, 14)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(304, 351)
        Me.TextBox1.TabIndex = 5
        '
        'gen
        '
        Me.gen.Location = New System.Drawing.Point(55, 154)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(78, 32)
        Me.gen.TabIndex = 3
        Me.gen.Text = "生成"
        Me.gen.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.BackColor = System.Drawing.SystemColors.Info
        Me.log.Location = New System.Drawing.Point(257, 278)
        Me.log.Multiline = True
        Me.log.Name = "log"
        Me.log.ReadOnly = True
        Me.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.log.Size = New System.Drawing.Size(173, 91)
        Me.log.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.noShow)
        Me.GroupBox3.Controls.Add(Me.noFile)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.delim)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.plus)
        Me.GroupBox3.Controls.Add(Me.minus)
        Me.GroupBox3.Controls.Add(Me.genSize)
        Me.GroupBox3.Controls.Add(Me.gen)
        Me.GroupBox3.Location = New System.Drawing.Point(291, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 199)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "生成"
        '
        'noShow
        '
        Me.noShow.AutoSize = True
        Me.noShow.Location = New System.Drawing.Point(10, 132)
        Me.noShow.Name = "noShow"
        Me.noShow.Size = New System.Drawing.Size(77, 16)
        Me.noShow.TabIndex = 11
        Me.noShow.Text = "表示しない"
        Me.noShow.UseVisualStyleBackColor = True
        '
        'noFile
        '
        Me.noFile.AutoSize = True
        Me.noFile.Location = New System.Drawing.Point(10, 110)
        Me.noFile.Name = "noFile"
        Me.noFile.Size = New System.Drawing.Size(77, 16)
        Me.noFile.TabIndex = 10
        Me.noFile.Text = "出力しない"
        Me.noFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "区切り"
        '
        'delim
        '
        Me.delim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.delim.FormattingEnabled = True
        Me.delim.Items.AddRange(New Object() {"タブ (*.tsv)", "半角スペース (*.ssv)", "カンマ (*.csv)"})
        Me.delim.Location = New System.Drawing.Point(12, 78)
        Me.delim.Name = "delim"
        Me.delim.Size = New System.Drawing.Size(85, 20)
        Me.delim.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "生成数"
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(103, 38)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(23, 19)
        Me.plus.TabIndex = 6
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(13, 38)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(21, 18)
        Me.minus.TabIndex = 5
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'genSize
        '
        Me.genSize.Location = New System.Drawing.Point(37, 38)
        Me.genSize.Name = "genSize"
        Me.genSize.Size = New System.Drawing.Size(60, 19)
        Me.genSize.TabIndex = 4
        Me.genSize.Text = "10"
        Me.genSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'reloadData
        '
        Me.reloadData.Location = New System.Drawing.Point(328, 254)
        Me.reloadData.Name = "reloadData"
        Me.reloadData.Size = New System.Drawing.Size(102, 19)
        Me.reloadData.TabIndex = 7
        Me.reloadData.Text = "データ再読み込み"
        Me.reloadData.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.post)
        Me.GroupBox4.Controls.Add(Me.job)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 238)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(72, 70)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "職業(3)"
        '
        'post
        '
        Me.post.AutoSize = True
        Me.post.Location = New System.Drawing.Point(7, 40)
        Me.post.Name = "post"
        Me.post.Size = New System.Drawing.Size(48, 16)
        Me.post.TabIndex = 1
        Me.post.Text = "役職"
        Me.post.UseVisualStyleBackColor = True
        '
        'job
        '
        Me.job.AutoSize = True
        Me.job.Location = New System.Drawing.Point(7, 18)
        Me.job.Name = "job"
        Me.job.Size = New System.Drawing.Size(48, 16)
        Me.job.TabIndex = 0
        Me.job.Text = "職業"
        Me.job.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(85, 238)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(99, 100)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "その他"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmPesonGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 373)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.reloadData)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmPesonGen"
        Me.Text = "personGen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents givenRuby As System.Windows.Forms.CheckBox
    Friend WithEvents familyRuby As System.Windows.Forms.CheckBox
    Friend WithEvents gender As System.Windows.Forms.CheckBox
    Friend WithEvents age As System.Windows.Forms.CheckBox
    Friend WithEvents given As System.Windows.Forms.CheckBox
    Friend WithEvents family As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents phone As System.Windows.Forms.CheckBox
    Friend WithEvents address As System.Windows.Forms.CheckBox
    Friend WithEvents zip As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents gen As System.Windows.Forms.Button
    Friend WithEvents log As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents plus As System.Windows.Forms.Button
    Friend WithEvents minus As System.Windows.Forms.Button
    Friend WithEvents genSize As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents delim As System.Windows.Forms.ComboBox
    Friend WithEvents reloadData As System.Windows.Forms.Button
    Friend WithEvents genderPtn As System.Windows.Forms.ComboBox
    Friend WithEvents noFile As System.Windows.Forms.CheckBox
    Friend WithEvents noShow As System.Windows.Forms.CheckBox
    Friend WithEvents ageScale As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents post As System.Windows.Forms.CheckBox
    Friend WithEvents job As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents zipSplit As System.Windows.Forms.CheckBox
    Friend WithEvents phoneScale As System.Windows.Forms.Button
    Friend WithEvents addressRuby As System.Windows.Forms.CheckBox
    Friend WithEvents addressConfig As System.Windows.Forms.Button
    Friend WithEvents phoneConfig As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents birthDate As System.Windows.Forms.CheckBox
    Friend WithEvents ageScaleShow As System.Windows.Forms.Label
    Friend WithEvents familyConfig As System.Windows.Forms.Button
    Friend WithEvents givenConfig As System.Windows.Forms.Button

End Class
