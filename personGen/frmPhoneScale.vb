Public Class frmPhoneScale

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
    ''' minの-が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMinMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinMinus.Click
        Dim v As Integer
        With minPhone
            If (IsNumeric(.Text)) Then
                v = Int(.Text)
                If (v > 1) Then
                    .Text = (v - 1)
                End If
            Else
                .Text = "6"
            End If
        End With
    End Sub

    ''' <summary>
    ''' minの+が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMinPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinPlus.Click
        With minPhone
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) + 1
            End If
        End With
    End Sub

    ''' <summary>
    ''' maxの-が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaxMinus.Click
        Dim v As Integer
        With maxPhone
            If (IsNumeric(.Text)) Then
                v = Int(.Text)
                If (v > 1) Then
                    .Text = (v - 1)
                End If
            Else
                .Text = "11"
            End If
        End With
    End Sub

    ''' <summary>
    ''' maxの+が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaxPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaxPlus.Click
        With maxPhone
            If (IsNumeric(.Text)) Then
                .Text = Int(.Text) + 1
            End If
        End With
    End Sub

    ''' <summary>
    ''' minPhoneにフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub minPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles minPhone.GotFocus
        minPhone.SelectAll()
    End Sub

    ''' <summary>
    ''' minPhoneがクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub minPhone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles minPhone.Click
        minPhone.SelectAll()
    End Sub

    ''' <summary>
    ''' maxPhoneにフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub maxPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles maxPhone.GotFocus
        maxPhone.SelectAll()
    End Sub

    ''' <summary>
    ''' maxPhoneにクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub maxPhone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles maxPhone.Click
        maxPhone.SelectAll()
    End Sub

    ''' <summary>
    ''' デフォルトボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        minPhone.Text = "6"
        maxPhone.Text = "11"
    End Sub
End Class
