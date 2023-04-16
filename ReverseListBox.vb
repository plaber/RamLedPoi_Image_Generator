Imports System.Drawing
Imports System.Windows.Forms

Friend Class ReverseListBox
    Inherits ListBox

    Public Sub New()
        Me.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        e.DrawBackground()

        If e.Index >= 0 AndAlso e.Index < Me.Items.Count Then
            Dim selected = (e.State And DrawItemState.Selected) = DrawItemState.Selected
            Dim back = If(selected, SystemColors.Highlight, Me.BackColor)
            Dim fore = If(selected, SystemColors.HighlightText, Me.ForeColor)
            Dim txt = Me.Items(e.Index).ToString()
            TextRenderer.DrawText(e.Graphics, txt, Me.Font, e.Bounds, fore, back, TextFormatFlags.Right Or TextFormatFlags.SingleLine)
        End If

        e.DrawFocusRectangle()
    End Sub
End Class
