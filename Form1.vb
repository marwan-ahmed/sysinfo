Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub اصدارنظامالتشغيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اصدارنظامالتشغيلToolStripMenuItem.Click
        Process.Start("winver.exe")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub وقتاخرتشغيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles وقتاخرتشغيلToolStripMenuItem.Click
        MsgBox(My.Computer.Clock.GmtTime)
    End Sub

    Private Sub إسمالجهازToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إسمالجهازToolStripMenuItem.Click
        MsgBox(My.Computer.Name)
    End Sub

    Private Sub حجمالذاكرةالطبيعيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حجمالذاكرةالطبيعيةToolStripMenuItem.Click
        MsgBox(" Available Physical Memory: " & _
My.Computer.Info.AvailablePhysicalMemory.ToString & " bytes ")
    End Sub

    Private Sub حجمالذاكرةالافتراضيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حجمالذاكرةالافتراضيةToolStripMenuItem.Click
        MsgBox(" Available Virtual Memory: " & _
My.Computer.Info.AvailableVirtualMemory.ToString & " bytes ")
    End Sub

    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ازالهالبرامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ازالهالبرامجToolStripMenuItem.Click
        Process.Start("sysdm.cpl")
    End Sub

    Private Sub إعداداتالوقتوالتاريخToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إعداداتالوقتوالتاريخToolStripMenuItem.Click
        Process.Start("timedate.cpl")
    End Sub

    Private Sub إعداداتالماوسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إعداداتالماوسToolStripMenuItem.Click
        Process.Start("main.cpl")
    End Sub

    Private Sub جدارالحمايةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدارالحمايةToolStripMenuItem.Click
        Process.Start("firewall.cpl")
    End Sub

    Private Sub مسارإبدأToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مسارإبدأToolStripMenuItem.Click
        MsgBox(System.Environment.GetFolderPath _
(Environment.SpecialFolder.StartMenu))
    End Sub

    Private Sub مسارStartUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مسارStartUpToolStripMenuItem.Click
        MsgBox(System.Environment.GetFolderPath _
(Environment.SpecialFolder.Startup))
    End Sub

    Private Sub مسارسطحالمكتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مسارسطحالمكتبToolStripMenuItem.Click
        MsgBox(System.Environment.GetFolderPath _
(Environment.SpecialFolder.Desktop))
    End Sub

    Private Sub مسارالمفضلةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مسارالمفضلةToolStripMenuItem.Click
        MsgBox(System.Environment.GetFolderPath _
(Environment.SpecialFolder.Favorites))
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form6.Show()

    End Sub
End Class
