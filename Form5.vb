Public Class Form5

    Private Sub اغلاقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اغلاقToolStripMenuItem.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub فتحToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فتحToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub حفظبأسمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظبأسمToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub قصToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قصToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub نسخToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نسخToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub لصقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لصقToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub تراجعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تراجعToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub تقادمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تقادمToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub تحديدToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تحديدToolStripMenuItem1.Click
        RichTextBox1.Select()
    End Sub

    Private Sub تحديدالكلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تحديدالكلToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub الخطToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الخطToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub اللونToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اللونToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub حولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حولToolStripMenuItem.Click
            MsgBox("دفتر الملاحظات الاصدار الاول من اشرف وسام", MsgBoxStyle.Information, "حول")
    End Sub
End Class
