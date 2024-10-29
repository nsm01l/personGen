Public Class frmPesonGen
    'TODO   表示順の指定
    'TODO   外部データの読み込み
    'TODO   複数列乱数を生成
    'TODO   生年月日(できるだけ詳細なやつ)
    'TODO   生成パターンの上限指定

    Enum addressPattern As Integer
        prefMunic = 0
        prefMunicArea
        prefMunicAreaBuil
        prefMunicAreaBuilFloor
    End Enum

    Dim familyTable()() As String   ' 名字テーブル
    Dim familySize As Long = -1     ' 名字サイズ
    Dim givenTable()() As String    ' 名前テーブル
    Dim givenSize As Long = -1      ' 名前サイズ
    Dim prefTable()() As String     ' 県テーブル
    Dim prefSize As Long = -1       ' 県テーブルサイズ
    Dim municTable()() As String    ' 市町村テーブル
    Dim municSize As Long = -1      ' 市町村サイズ
    Dim areaTable()() As String     ' 地域テーブル
    Dim areaSize As Long = -1       ' 地域サイズ
    Dim buildingTable()() As String ' ビルテーブル
    Dim buildingSize As Long = -1   ' ビルサイズ
    Dim jobTable()() As String       ' 職業テーブル
    Dim jobSize As Long = -1        ' 職業サイズ
    Dim postTable()() As String     ' 役職テーブル
    Dim postSize As Long = -1       ' 役職サイズ

    Dim familyUse As Long = -1  ' 利用する名字
    Dim givenUse As Long = -1   ' 利用する名前
    Dim municUse As Long = -1   ' 利用する市町村
    Dim areaUse As Long = -1    ' 利用する地域
    Dim buildingUse As Long = -1   ' 利用するビル

    Dim frmAgeScale As New frmAgeScale '年齢範囲
    Dim frmPhoneScale As New frmPhoneScale '電話番号桁数
    Dim frmAddressSetting As New frmAddressSetting '住所生成パターン
    Dim frmInputValue As New frmInputValue '数値入力

    '######################################################################
    '######################################################################
    '   起動時設定
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' 起動時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ファイルダイアログ
        SaveFileDialog1.Filter = "テキストファイル(*.txt)|*.txt"

        '項目設定
        delim.SelectedIndex = 0
        genderPtn.SelectedIndex = 0

        'ダイアログフォーム
        frmAgeScale.Owner = Me
        frmPhoneScale.Owner = Me
        frmAddressSetting.Owner = Me
        frmInputValue.Owner = Me

        '乱数初期化
        Randomize()

        'データ読み込み
        readDate()
    End Sub

    ''' <summary>
    ''' 名字を読み込む
    ''' </summary>
    ''' <returns></returns>
    Private Function readFamily() As Boolean
        Return readXColumnFile("family.txt", familyTable, familySize, 2)
    End Function

    ''' <summary>
    ''' 氏名読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readName() As Boolean
        Return readXColumnFile("given.txt", givenTable, givenSize, 3)
    End Function

    ''' <summary>
    ''' 県の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readPref() As Boolean
        Return readXColumnFile("prefecture.txt", prefTable, prefSize, 2)
    End Function

    ''' <summary>
    ''' 市町村の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readMunic() As Boolean
        Return readXColumnFile("municipality.txt", municTable, municSize, 2)
    End Function

    ''' <summary>
    ''' 地区の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readArea() As Boolean
        Return readXColumnFile("area.txt", areaTable, areaSize, 2)
    End Function

    ''' <summary>
    ''' 建物の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readBuilding() As Boolean
        Return readXColumnFile("building.txt", buildingTable, buildingSize, 2)
    End Function

    ''' <summary>
    ''' 職業の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readJob() As Boolean
        Return readXColumnFile("job.txt", jobTable, jobSize, 1)
    End Function

    ''' <summary>
    ''' 役職の読み込み
    ''' </summary>
    ''' <returns></returns>
    Private Function readPost() As Boolean
        Return readXColumnFile("post.txt", postTable, postSize, 1)
    End Function

    ''' <summary>
    ''' データファイルの読み込み処理
    ''' </summary>
    Private Sub readDate()
        'ロック
        gen.Enabled = False

        addLog("読み込み開始!")
        addLog("名字読み込み開始")
        If (readFamily()) Then
            addLog("名字読み込み完了 " & familySize)
            familyUse = familySize
            familyConfig.Text = familyUse & "/" & familySize
        Else
            addLog("名字読み込み失敗")
            Exit Sub
        End If

        addLog("名前読み込み開始")
        If (readName()) Then
            addLog("名前読み込み完了" & givenSize)
            givenUse = givenSize
            givenConfig.Text = givenUse & "/" & givenSize
        Else
            addLog("名前読み込み失敗")
            Exit Sub
        End If

        addLog("県読み込み開始")
        If (readPref()) Then
            addLog("県読み込み完了 " & prefSize)
        Else
            addLog("県読み込み失敗")
            Exit Sub
        End If

        addLog("市町村読み込み開始")
        If (readMunic()) Then
            addLog("市町村読み込み完了 " & municSize)
            municUse = municSize
        Else
            addLog("市町村読み込み失敗")
            Exit Sub
        End If

        addLog("地区読み込み開始")
        If (readArea()) Then
            addLog("地区読み込み完了 " & areaSize)
            areaUse = areaSize
        Else
            addLog("地区読み込み失敗")
            Exit Sub
        End If

        addLog("建物読み込み開始")
        If (readBuilding()) Then
            addLog("建物読み込み完了 " & buildingSize)
            buildingUse = buildingSize
        Else
            addLog("建物読み込み失敗")
            Exit Sub
        End If

        addLog("職業読み込み開始")
        If (readJob()) Then
            addLog("職業読み込み完了 " & jobSize)
        Else
            addLog("職業読み込み失敗")
            Exit Sub
        End If

        addLog("役職読み込み開始")
        If (readPost()) Then
            addLog("役職読み込み完了 " & postSize)
        Else
            addLog("役職読み込み失敗")
            Exit Sub
        End If

        'ロック解除
        gen.Enabled = True
    End Sub

    ''' <summary>
    ''' X つの情報のみの列を読み込む
    ''' </summary>
    ''' <param name="f"></param>
    ''' <param name="a"></param>
    ''' <param name="s"></param>
    ''' <param name="column"></param>
    ''' <returns></returns>
    Private Function readXColumnFile(ByVal f As String, ByRef a()() As String, ByRef s As Long, Optional ByVal column As Integer = 2) As Boolean
        Dim fileFile As String
        Dim fileAry() As String

        '引数定義
        If (column < 1) Then
            Return False
        End If

        'データの読み込み
        fileFile = My.Computer.FileSystem.ReadAllText("data\" & f, System.Text.Encoding.Default)
        fileAry = Split(fileFile, vbCrLf)

        '定義＆読み込み
        Dim size As Long = fileAry.Length
        Dim cnt As Long = 0&
        a = New String(size)() {}
        For i As Long = 0& To size - 1&
            Dim temp() As String
            temp = Split(fileAry(i), vbTab)

            '行を無視するか判定
            If (temp.Length < column) Then
                Continue For
            ElseIf (temp(0).Length = 0) Then
                Continue For
            ElseIf (temp(0).Chars(0) = "#") Then
                Continue For
            ElseIf (temp(0).StartsWith("//")) Then
                Continue For
            End If

            a(cnt) = New String(column) {}
            For j As Integer = 0 To column - 1
                a(cnt)(j) = temp(j)
            Next j
            cnt = cnt + 1&
        Next i

        s = cnt
        If (cnt = 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    '######################################################################
    '######################################################################
    '   終了時設定
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' 終了時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pesonGen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'ダイアログ無効化
        frmAgeScale = Nothing
        frmPhoneScale = Nothing
        frmAddressSetting = Nothing
        frmInputValue = Nothing

        'テーブル解放
        freeDataTables()
    End Sub

    ''' <summary>
    ''' データ配列の解放処理
    ''' </summary>
    Private Sub freeDataTables()
        '配列解放
        freeTable(familyTable)
        freeTable(givenTable)
        freeTable(prefTable)
        freeTable(municTable)
        freeTable(areaTable)
        freeTable(buildingTable)
        freeTable(jobTable)
        freeTable(postTable)
    End Sub

    ''' <summary>
    ''' String()() 型の解放
    ''' </summary>
    ''' <param name="t"></param>
    Private Sub freeTable(ByRef t()() As String)
        '何もなければ何もしない
        If (t Is Nothing) Then
            Exit Sub
        End If

        Dim s As Long = t.Length

        For i As Long = 0& To s - 1&
            t(i) = Nothing
        Next i
        t = Nothing
    End Sub

    '######################################################################
    '######################################################################
    '   リサイズ
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' リサイズが行われた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pesonGen_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim ww, wh As Integer
        With Me
            If .Width < 754 Then
                .Width = 754
            End If
            If .Height < 400 Then
                .Height = 400
            End If
            ww = .Width
            wh = .Height
        End With

        With TextBox1
            .Width = ww - .Left - 8
            .Height = wh - .Top - 28
        End With
    End Sub

    '######################################################################
    '######################################################################
    '   コントロール挙動
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' 生成数増加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click
        Dim num As Long
        If (IsNumeric(genSize.Text)) Then
            num = CLng(genSize.Text)
            If (num > 1) Then
                genSize.Text = CStr(num + 1&)
            Else
                genSize.Text = "1"
            End If
        Else
            genSize.Text = "1"
        End If
    End Sub

    ''' <summary>
    ''' 生成数減少
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        Dim num As Long
        If (IsNumeric(genSize.Text)) Then
            num = CLng(genSize.Text)
            If (num > 1) Then
                genSize.Text = CStr(num - 1&)
            Else
                genSize.Text = "1"
            End If
        Else
            genSize.Text = "1"
        End If
    End Sub

    ''' <summary>
    ''' ログに追加
    ''' </summary>
    ''' <param name="s"></param>
    Private Sub addLog(ByVal s As String)
        With log
            If (.Lines.Length = 0) Then
                .Text = s
            Else
                .Text &= vbCrLf & s
            End If
        End With
    End Sub

    ''' <summary>
    ''' ログ画面制御
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub log_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.TextChanged
        With log
            .SelectionStart = .Text.Length
            .SelectionLength = 0
            .ScrollToCaret()
        End With
    End Sub

    ''' <summary>
    ''' TextBox1 がダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        With TextBox1
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub

    ''' <summary>
    ''' zipのチェックが変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub zip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zip.CheckedChanged
        zipSplit.Enabled = zip.Checked
    End Sub

    ''' <summary>
    ''' addressのチェックが変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub address_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address.CheckedChanged
        addressRuby.Enabled = address.Checked
        addressConfig.Enabled = address.Checked
    End Sub

    ''' <summary>
    ''' ageのチェックが変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub age_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age.CheckedChanged
        ageScale.Enabled = age.Checked
    End Sub

    ''' <summary>
    ''' birthDateのチェックが変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub birthDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles birthDate.CheckedChanged

    End Sub

    ''' <summary>
    ''' genderのチェックが変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub gender_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gender.CheckedChanged
        genderPtn.Enabled = gender.Checked
    End Sub

    ''' <summary>
    ''' 電話番号が変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub phone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phone.CheckedChanged
        phoneScale.Enabled = phone.Checked
    End Sub

    ''' <summary>
    ''' データの再読み込みボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub reloadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reloadData.Click
        '配列解放
        freeDataTables()

        '再読み込み
        readDate()
    End Sub

    ''' <summary>
    ''' 生成数がクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub genSize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles genSize.Click
        genSize.SelectAll()
    End Sub

    ''' <summary>
    ''' 生成数にフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub genSize_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles genSize.GotFocus
        genSize.SelectAll()
    End Sub

    '######################################################################
    '######################################################################
    '   生成処理
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' 生成処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub gen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gen.Click
        If (Not noFile.Checked) Then
            '出力ファイル指定
            SaveFileDialog1.FileName = ""
            If (SaveFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
                Exit Sub
            End If
        End If

        'サイズチェック
        Dim num As Long
        If (IsNumeric(genSize.Text)) Then
            num = CLng(genSize.Text)

            If (num < 1&) Then
                addLog("生成数が負数")
                Exit Sub
            End If
        Else
            addLog("生成数がおかしい")
            Exit Sub
        End If
        If (num > 30000) Then
            If (MsgBox("生成数が多く、とっても時間がかかりそうです。" & vbCrLf & "続けますか?", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then
                Exit Sub
            End If
        End If

        '区切りチェック
        Dim delimiter As String
        If (StrComp(delim.Text, "タブ (*.tsv)") = 0) Then
            delimiter = vbTab
        ElseIf (StrComp(delim.Text, "半角スペース (*.ssv)") = 0) Then
            delimiter = " "
        ElseIf (StrComp(delim.Text, "カンマ (*.csv)") = 0) Then
            delimiter = ","
        Else
            addLog("区切りがおかしい")
            Exit Sub
        End If

        '男女表示チェック
        Dim genderHash As New Hashtable
        If (genderPtn.SelectedIndex = 0) Then
            genderHash.Add("m", "m")
            genderHash.Add("f", "f")
        ElseIf (genderPtn.SelectedIndex = 1) Then
            genderHash.Add("m", "male")
            genderHash.Add("f", "female")
        ElseIf (genderPtn.SelectedIndex = 2) Then
            genderHash.Add("m", "m")
            genderHash.Add("f", "w")
        ElseIf (genderPtn.SelectedIndex = 3) Then
            genderHash.Add("m", "man")
            genderHash.Add("f", "woman")
        ElseIf (genderPtn.SelectedIndex = 4) Then
            genderHash.Add("m", "男")
            genderHash.Add("f", "女")
        ElseIf (genderPtn.SelectedIndex = 5) Then
            genderHash.Add("m", "男性")
            genderHash.Add("f", "女性")
        End If

        '出力内容チェック
        Dim genCtrl As New Hashtable
        genCtrl.Add("family", family.Checked)
        genCtrl.Add("familyRuby", familyRuby.Checked)
        genCtrl.Add("given", given.Checked)
        genCtrl.Add("givenRuby", givenRuby.Checked)
        genCtrl.Add("age", age.Checked)
        genCtrl.Add("birthDate", birthDate.Checked)
        genCtrl.Add("gender", gender.Checked)
        genCtrl.Add("zip", zip.Checked)
        genCtrl.Add("address", address.Checked)
        genCtrl.Add("addressRuby", addressRuby.Checked)
        genCtrl.Add("phone", phone.Checked)
        genCtrl.Add("job", job.Checked)
        genCtrl.Add("post", post.Checked)

        'チェック内容チェック
        Dim cnt As Integer = 0
        For Each key As String In genCtrl.Keys
            If genCtrl(key) Then
                cnt += 1
            End If
        Next
        If (cnt = 0) Then
            addLog("出力内容がないよ")
            Exit Sub
        End If

        '年齢範囲
        Dim minAge As Integer   '年齢最小
        Dim maxAge As Integer   '年齢最大
        Dim ageScale As Integer '年齢範囲
        If (genCtrl("age")) Then
            If (Not IsNumeric(frmAgeScale.minAge.Text)) Or (Not IsNumeric(frmAgeScale.maxAge.Text)) Then
                addLog("年齢の範囲がおかしい")
                Exit Sub
            Else
                minAge = Int(frmAgeScale.minAge.Text)
                maxAge = Int(frmAgeScale.maxAge.Text)
            End If
            If (minAge > maxAge) Then
                Dim t As Integer = minAge
                minAge = maxAge
                maxAge = t
            End If
            ageScale = maxAge - minAge + 1
        End If

        '電話番号範囲
        Dim minPhone As Integer
        Dim maxPhone As Integer
        Dim phoneScale As Integer
        If (genCtrl("phone")) Then
            If (Not IsNumeric(frmPhoneScale.minPhone.Text)) Or (Not IsNumeric(frmPhoneScale.maxPhone.Text)) Then
                addLog("電話番号の範囲がおかしい")
                Exit Sub
            Else
                minPhone = Int(frmPhoneScale.minPhone.Text)
                maxPhone = Int(frmPhoneScale.maxPhone.Text)
            End If
            If (minPhone > maxPhone) Then
                Dim t As Integer = minPhone
                minPhone = maxPhone
                maxPhone = t
            End If
            phoneScale = maxPhone - minPhone + 1
        End If

        '住所チェック
        If (genCtrl("address") Or genCtrl("addressRuby")) Then
            With frmAddressSetting
                If ((Not .chkCity.Checked) And (Not .chkCityAza.Checked) And (Not .chkCityAzaBuilding.Checked) And (Not .chkCityAzaBuildingFloor.Checked)) Then
                    addLog("生成できる住所パターンがないよ")
                    Exit Sub
                ElseIf (Not .chkAddress1.Checked) And (Not .chkAddress2.Checked) And (Not .chkAddress3.Checked) Then
                    addLog("生成できる番地パターンがないよ")
                    Exit Sub
                End If
            End With
        End If

        'ロック開始
        gen.Enabled = False

        '出力開始
        Dim outString As String = ""
        Dim place As Long
        For i As Long = 0& To num - 1&
            Dim tempString As String = ""

            place = Int(Rnd() * familyUse)
            '名字
            If (genCtrl("family")) Then
                tempString &= familyTable(place)(0) & delimiter
            End If
            '名字(ルビ)
            If (genCtrl("familyRuby")) Then
                tempString &= familyTable(place)(1) & delimiter
            End If

            place = Int(Rnd() * givenUse)
            '名前
            If (genCtrl("given")) Then
                tempString &= givenTable(place)(0) & delimiter
            End If
            '名前(ルビ)
            If (genCtrl("givenRuby")) Then
                tempString &= givenTable(place)(1) & delimiter
            End If
            '性別
            If (genCtrl("gender")) Then
                tempString &= genderHash(givenTable(place)(2)) & delimiter
            End If

            '年齢
            If (genCtrl("age")) Then
                tempString &= Int(Rnd() * ageScale + minAge) & delimiter
            End If

            '誕生日
            If (genCtrl("birthDate")) Then
                Dim year As Integer
                Dim month As Integer
                Dim day As Integer
                year = Int(Rnd() * 200 + 1900)
                month = Int(Rnd() * 12 + 1)
                If (month = 2) Then
                    day = Int(Rnd() * 28 + 1)
                ElseIf (month = 4 Or month = 6 Or month = 9 Or month = 11) Then
                    day = Int(Rnd() * 30 + 1)
                Else
                    day = Int(Rnd() * 31 + 1)
                End If
                tempString &= year & "/" & month & "/" & day & delimiter
            End If

            '郵便番号
            If (genCtrl("zip")) Then
                Dim tempZip As String = ""
                For j As Integer = 0 To 7
                    tempZip &= Int(Rnd() * 10)
                Next j
                If (zipSplit.Checked) Then
                    tempZip = tempZip.Substring(0, 3) & "-" & tempZip.Substring(3, 4)
                End If
                tempString &= tempZip & delimiter
            End If

            '住所
            If (genCtrl("address") Or genCtrl("addressRuby")) Then
                Dim tempAddress() As String = genAddres()
                If (genCtrl("address")) Then
                    tempString &= tempAddress(0) & delimiter
                End If
                If (genCtrl("addressRuby")) Then
                    tempString &= tempAddress(1) & delimiter
                End If
            End If

            '電話番号
            If (genCtrl("phone")) Then
                Dim tempPhone As String = ""
                Dim phoneSize As Integer
                phoneSize = Int(Rnd() * phoneScale + minPhone)
                For j As Integer = 0 To phoneSize - 1
                    tempPhone &= Int(Rnd() * 10)
                Next j
                tempString &= tempPhone & delimiter
            End If

            '職業
            If (genCtrl("job")) Then
                tempString &= jobTable(Int(Rnd() * jobSize))(0) & delimiter
            End If

            '役職
            If (genCtrl("post")) Then
                tempString &= postTable(Int(Rnd() * postSize))(0) & delimiter
            End If

            outString &= tempString.TrimEnd(delimiter) & vbCrLf
        Next i

        '出力と表示
        If (Not noFile.Checked) Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, outString, False, System.Text.Encoding.Default)
        End If
        If (Not noShow.Checked) Then
            TextBox1.Text = outString
        End If
        addLog("出力しました")

        'ロック解除
        gen.Enabled = True
    End Sub

    ''' <summary>
    ''' 住所を生成する
    ''' </summary>
    ''' <returns></returns>
    Private Function genAddres() As String()
        Dim retString(2) As String
        Dim pattern As Integer = Int(Rnd() * 4) '生成する住所のパターン
        Dim i, j, k, l, m As Long  '住所生成用Index
        Dim blockNumber As String = genBlockNumber()    '番地

        '綺麗な方法ではないが、こうしてみる
        With frmAddressSetting
            Do
                If (pattern = 0 And .chkCity.Checked) Then
                    Exit Do
                ElseIf (pattern = 1 And .chkCityAza.Checked) Then
                    Exit Do
                ElseIf (pattern = 2 And .chkCityAzaBuilding.Checked) Then
                    Exit Do
                ElseIf (pattern = 3 And .chkCityAzaBuildingFloor.Checked) Then
                    Exit Do
                End If
                pattern = Int(Rnd() * 4)
            Loop
        End With

        'patternに応じて住所を生成
        If (pattern = addressPattern.prefMunic) Then
            i = Int(Rnd() * prefSize)
            j = Int(Rnd() * municSize)

            retString(0) = prefTable(i)(0) & municTable(j)(0) & " " & blockNumber
            retString(1) = prefTable(i)(1) & municTable(j)(1) & " " & blockNumber
        ElseIf (pattern = addressPattern.prefMunicArea) Then
            i = Int(Rnd() * prefSize)
            j = Int(Rnd() * municSize)
            k = Int(Rnd() * areaSize)

            retString(0) = prefTable(i)(0) & municTable(j)(0) & areaTable(k)(0) & " " & blockNumber
            retString(1) = prefTable(i)(1) & municTable(j)(1) & areaTable(k)(1) & " " & blockNumber
        ElseIf (pattern = addressPattern.prefMunicAreaBuil) Then
            i = Int(Rnd() * prefSize)
            j = Int(Rnd() * municSize)
            k = Int(Rnd() * areaSize)
            l = Int(Rnd() * buildingSize)

            retString(0) = prefTable(i)(0) & municTable(j)(0) & areaTable(k)(0) & " " & blockNumber & " " & buildingTable(l)(0)
            retString(1) = prefTable(i)(1) & municTable(j)(1) & areaTable(k)(1) & " " & blockNumber & " " & buildingTable(l)(1)
        ElseIf (pattern = addressPattern.prefMunicAreaBuilFloor) Then
            i = Int(Rnd() * prefSize)
            j = Int(Rnd() * municSize)
            k = Int(Rnd() * areaSize)
            l = Int(Rnd() * buildingSize)
            m = Int(Rnd() * 999 + 1)

            retString(0) = prefTable(i)(0) & municTable(j)(0) & areaTable(k)(0) & " " & blockNumber & " " & buildingTable(l)(0) & m & "号室"
            retString(1) = prefTable(i)(1) & municTable(j)(1) & areaTable(k)(1) & " " & blockNumber & " " & buildingTable(l)(1) & m & "ごうしつ"
        End If

        Return retString
    End Function

    ''' <summary>
    ''' 番地を生成する
    ''' </summary>
    ''' <returns></returns>
    Private Function genBlockNumber() As String
        '区切りの数
        Dim size As Integer = Int(Rnd() * 3 + 1)

        '綺麗な方法ではないが、これしか思いつかない
        With frmAddressSetting
            Do
                If (size = 1 And .chkAddress1.Checked) Then
                    Exit Do
                ElseIf (size = 2 And .chkAddress2.Checked) Then
                    Exit Do
                ElseIf (size = 3 And .chkAddress3.Checked) Then
                    Exit Do
                End If
                size = Int(Rnd() * 3 + 1)
            Loop
        End With

        If (size = 1) Then
            Return CStr(Int(Rnd() * 9999 + 1))
        ElseIf (size = 2) Then
            Return CStr(Int(Rnd() * 9999 + 1) & "-" & Int(Rnd() * 99 + 1))
        Else
            Return CStr(Int(Rnd() * 999 + 1) & "-" & Int(Rnd() * 99 + 1) & "-" & Int(Rnd() * 99 + 1))
        End If

    End Function

    '######################################################################
    '######################################################################
    '   ダイアログ処理
    '######################################################################
    '######################################################################

    ''' <summary>
    ''' 年齢の範囲を指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ageScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ageScale.Click
        Dim max As Integer
        Dim min As Integer

        If (IsNumeric(frmAgeScale.minAge.Text)) Then
            min = Int(frmAgeScale.minAge.Text)
        Else
            min = 0
            frmAgeScale.minAge.Text = "0"
        End If
        If (IsNumeric(frmAgeScale.maxAge.Text)) Then
            max = Int(frmAgeScale.maxAge.Text)
        Else
            max = 120
            frmAgeScale.maxAge.Text = "120"
        End If

        If (frmAgeScale.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
            frmAgeScale.minAge.Text = min
            frmAgeScale.maxAge.Text = max
        End If
        ageScaleShow.Text = frmAgeScale.minAge.Text & " - " & frmAgeScale.maxAge.Text
    End Sub

    ''' <summary>
    ''' 電話番号の桁数を指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub phoneScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phoneScale.Click
        Dim max, min As Integer

        If (IsNumeric(frmPhoneScale.minPhone.Text)) Then
            min = Int(frmPhoneScale.minPhone.Text)
        Else
            min = 6
            frmPhoneScale.minPhone.Text = "6"
        End If
        If (IsNumeric(frmPhoneScale.maxPhone.Text)) Then
            max = Int(frmPhoneScale.maxPhone.Text)
        Else
            max = 11
            frmPhoneScale.maxPhone.Text = "11"
        End If

        If (frmPhoneScale.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
            frmPhoneScale.minPhone.Text = min
            frmPhoneScale.maxPhone.Text = max
        End If
    End Sub

    ''' <summary>
    ''' 住所生成パターンを指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub addressConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addressConfig.Click
        Dim state(4) As Boolean
        Dim blockState(3) As Boolean
        '住所生成パターン
        state(0) = frmAddressSetting.chkCity.Checked
        state(1) = frmAddressSetting.chkCityAza.Checked
        state(2) = frmAddressSetting.chkCityAzaBuilding.Checked
        state(3) = frmAddressSetting.chkCityAzaBuildingFloor.Checked

        '番地生成パターン
        blockState(0) = frmAddressSetting.chkAddress1.Checked
        blockState(1) = frmAddressSetting.chkAddress2.Checked
        blockState(2) = frmAddressSetting.chkAddress3.Checked

        If (frmAddressSetting.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
            frmAddressSetting.chkCity.Checked = state(0)
            frmAddressSetting.chkCityAza.Checked = state(1)
            frmAddressSetting.chkCityAzaBuilding.Checked = state(2)
            frmAddressSetting.chkCityAzaBuildingFloor.Checked = state(3)

            frmAddressSetting.chkAddress1.Checked = blockState(0)
            frmAddressSetting.chkAddress2.Checked = blockState(1)
            frmAddressSetting.chkAddress3.Checked = blockState(2)
        End If
    End Sub

    ''' <summary>
    ''' 名字の利用データを指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub familyConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles familyConfig.Click
        With frmInputValue
            .maxSize.Text = familySize
            .useSize.Text = familyUse
            .max = familySize
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If (IsNumeric(.useSize.Text)) Then
                    familyUse = Int(.useSize.Text)
                    familyConfig.Text = familyUse & "/" & familySize
                End If
            End If
        End With
    End Sub

    ''' <summary>
    ''' 名前の利用データを指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub givenConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles givenConfig.Click
        With frmInputValue
            .maxSize.Text = givenSize
            .useSize.Text = givenUse
            .max = givenSize
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If (IsNumeric(.useSize.Text)) Then
                    givenUse = Int(.useSize.Text)
                    givenConfig.Text = givenUse & "/" & givenSize
                End If
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
