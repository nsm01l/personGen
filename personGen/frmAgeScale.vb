Public Class frmAgeScale

    ''' <summary>
    ''' OKボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
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
    ''' 最大 +
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaxPlus.Click
        With maxAge
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) + 1
            Else
                .Text = "120"
            End If
        End With
    End Sub

    ''' <summary>
    ''' 最大 - 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaxMinus.Click
        With maxAge
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) - 1
            Else
                .Text = "120"
            End If
        End With
    End Sub

    ''' <summary>
    ''' 最小 +
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMinPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinPlus.Click
        With minAge
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) + 1
            Else
                .Text = "0"
            End If
        End With
    End Sub

    ''' <summary>
    ''' 最小 -
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMinMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinMinus.Click
        With minAge
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) - 1
            Else
                .Text = "0"
            End If
        End With
    End Sub

    ''' <summary>
    ''' maxAgeにフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub maxAge_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles maxAge.GotFocus
        maxAge.SelectAll()
    End Sub

    ''' <summary>
    ''' minAgeにフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub minAge_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles minAge.GotFocus
        minAge.SelectAll()
    End Sub

    ''' <summary>
    ''' minAgeがクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub minAge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles minAge.Click
        minAge.SelectAll()
    End Sub

    ''' <summary>
    ''' maxAgeがクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub maxAge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles maxAge.Click
        maxAge.SelectAll()
    End Sub

    ''' <summary>
    ''' デフォルトボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        minAge.Text = "0"
        maxAge.Text = "120"
    End Sub
End Class
