Public Class frmAddressSetting

    ''' <summary>
    ''' OKボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ((Not chkCity.Checked) And (Not chkCityAza.Checked) And (Not chkCityAzaBuilding.Checked) And (Not chkCityAzaBuildingFloor.Checked)) Then
            MsgBox("住所のパターンが 1 つも選択されていません", MsgBoxStyle.OkOnly)
            Exit Sub
        ElseIf ((Not chkAddress1.Checked) And (Not chkAddress2.Checked) And (Not chkAddress3.Checked)) Then
            MsgBox("番地のパターンが 1 つも選択されていません", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' キャンセルボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' 全選択が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        chkCity.Checked = True
        chkCityAza.Checked = True
        chkCityAzaBuilding.Checked = True
        chkCityAzaBuildingFloor.Checked = True
        chkAddress1.Checked = True
        chkAddress2.Checked = True
        chkAddress3.Checked = True
    End Sub
End Class
