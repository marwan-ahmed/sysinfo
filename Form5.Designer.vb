<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.جديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فتحToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حفظToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حفظبأسمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اغلاقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.قصToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نسخToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.لصقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تراجعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تقادمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تحديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تحديدToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.تحديدالكلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خصائصToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الخطToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اللونToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.تعديلToolStripMenuItem, Me.تحديدToolStripMenuItem, Me.خصائصToolStripMenuItem, Me.حولToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جديدToolStripMenuItem, Me.فتحToolStripMenuItem, Me.حفظToolStripMenuItem, Me.حفظبأسمToolStripMenuItem, Me.اغلاقToolStripMenuItem})
        Me.ملفToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'جديدToolStripMenuItem
        '
        Me.جديدToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem"
        Me.جديدToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.جديدToolStripMenuItem.Text = "جديد"
        '
        'فتحToolStripMenuItem
        '
        Me.فتحToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.فتحToolStripMenuItem.Name = "فتحToolStripMenuItem"
        Me.فتحToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.فتحToolStripMenuItem.Text = "فتح"
        '
        'حفظToolStripMenuItem
        '
        Me.حفظToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem"
        Me.حفظToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.حفظToolStripMenuItem.Text = "حفظ"
        '
        'حفظبأسمToolStripMenuItem
        '
        Me.حفظبأسمToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.حفظبأسمToolStripMenuItem.Name = "حفظبأسمToolStripMenuItem"
        Me.حفظبأسمToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.حفظبأسمToolStripMenuItem.Text = "حفظ بأسم"
        '
        'اغلاقToolStripMenuItem
        '
        Me.اغلاقToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem"
        Me.اغلاقToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.اغلاقToolStripMenuItem.Text = "اغلاق"
        '
        'تعديلToolStripMenuItem
        '
        Me.تعديلToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.قصToolStripMenuItem, Me.نسخToolStripMenuItem, Me.لصقToolStripMenuItem, Me.تراجعToolStripMenuItem, Me.تقادمToolStripMenuItem})
        Me.تعديلToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem"
        Me.تعديلToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.تعديلToolStripMenuItem.Text = "تعديل"
        '
        'قصToolStripMenuItem
        '
        Me.قصToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.قصToolStripMenuItem.Name = "قصToolStripMenuItem"
        Me.قصToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.قصToolStripMenuItem.Text = "قص"
        '
        'نسخToolStripMenuItem
        '
        Me.نسخToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.نسخToolStripMenuItem.Name = "نسخToolStripMenuItem"
        Me.نسخToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.نسخToolStripMenuItem.Text = "نسخ"
        '
        'لصقToolStripMenuItem
        '
        Me.لصقToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.لصقToolStripMenuItem.Name = "لصقToolStripMenuItem"
        Me.لصقToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.لصقToolStripMenuItem.Text = "لصق"
        '
        'تراجعToolStripMenuItem
        '
        Me.تراجعToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تراجعToolStripMenuItem.Name = "تراجعToolStripMenuItem"
        Me.تراجعToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.تراجعToolStripMenuItem.Text = "تراجع"
        '
        'تقادمToolStripMenuItem
        '
        Me.تقادمToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تقادمToolStripMenuItem.Name = "تقادمToolStripMenuItem"
        Me.تقادمToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.تقادمToolStripMenuItem.Text = "تقادم"
        '
        'تحديدToolStripMenuItem
        '
        Me.تحديدToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تحديدToolStripMenuItem1, Me.تحديدالكلToolStripMenuItem})
        Me.تحديدToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تحديدToolStripMenuItem.Name = "تحديدToolStripMenuItem"
        Me.تحديدToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.تحديدToolStripMenuItem.Text = "تحديد"
        '
        'تحديدToolStripMenuItem1
        '
        Me.تحديدToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تحديدToolStripMenuItem1.Name = "تحديدToolStripMenuItem1"
        Me.تحديدToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.تحديدToolStripMenuItem1.Text = "تحديد"
        '
        'تحديدالكلToolStripMenuItem
        '
        Me.تحديدالكلToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.تحديدالكلToolStripMenuItem.Name = "تحديدالكلToolStripMenuItem"
        Me.تحديدالكلToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.تحديدالكلToolStripMenuItem.Text = "تحديد الكل"
        '
        'خصائصToolStripMenuItem
        '
        Me.خصائصToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.الخطToolStripMenuItem, Me.اللونToolStripMenuItem})
        Me.خصائصToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.خصائصToolStripMenuItem.Name = "خصائصToolStripMenuItem"
        Me.خصائصToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.خصائصToolStripMenuItem.Text = "خصائص"
        '
        'الخطToolStripMenuItem
        '
        Me.الخطToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.الخطToolStripMenuItem.Name = "الخطToolStripMenuItem"
        Me.الخطToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.الخطToolStripMenuItem.Text = "الخط"
        '
        'اللونToolStripMenuItem
        '
        Me.اللونToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.اللونToolStripMenuItem.Name = "اللونToolStripMenuItem"
        Me.اللونToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.اللونToolStripMenuItem.Text = "اللون"
        '
        'حولToolStripMenuItem
        '
        Me.حولToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.حولToolStripMenuItem.Name = "حولToolStripMenuItem"
        Me.حولToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.حولToolStripMenuItem.Text = "حول"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Location = New System.Drawing.Point(694, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "الرئيسية"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(5, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(996, 660)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 681)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "دفتر الملاحظات"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ملفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents جديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents فتحToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حفظToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حفظبأسمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اغلاقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents قصToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents نسخToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents لصقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تراجعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تقادمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تحديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تحديدToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تحديدالكلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents خصائصToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الخطToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اللونToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents حولToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
