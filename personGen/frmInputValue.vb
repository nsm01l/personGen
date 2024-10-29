Public Class frmInputValue
    Public max As Long

    ''' <summary>
    ''' OKボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim value As Long
        With useSize
            If (IsNumeric(.Text)) Then
                value = Int(.Text)
                If (value < 1) Or (value > max) Then
                    MsgBox("入力した数値が不正です", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            Else
                MsgBox("数値を入力してください", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        End With

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

    Private Sub inputValue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' 全てのボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles all.Click
        useSize.Text = CStr(max)
    End Sub

    ''' <summary>
    ''' - が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click
        Dim value As Long
        If (IsNumeric(useSize.Text)) Then
            value = Int(useSize.Text)
            If (value > 2) Then
                useSize.Text = value - 1
            End If
        Else
            useSize.Text = "2"
        End If
    End Sub

    ''' <summary>
    ''' + が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInc.Click
        Dim value As Long
        If (IsNumeric(useSize.Text)) Then
            value = Int(useSize.Text)
            If (value < max) Then
                useSize.Text = value + 1
            End If
        Else
            useSize.Text = max
        End If
    End Sub

    ''' <summary>
    ''' useSize にフォーカスが移った
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub useSize_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles useSize.GotFocus
        useSize.SelectAll()
    End Sub

    ''' <summary>
    ''' useSize がクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub useSize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles useSize.Click
        useSize.SelectAll()
    End Sub
End Class
