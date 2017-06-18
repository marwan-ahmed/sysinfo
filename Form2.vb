Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub الكومبيوترToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الكومبيوترToolStripMenuItem.Click
        Process.Start("explorer")
    End Sub

    Private Sub المفكرةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles المفكرةToolStripMenuItem.Click
        Process.Start("notepad")
    End Sub

    Private Sub الحاسبةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الحاسبةToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub ازالةالبرامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("appwiz.cpl")
    End Sub

    Private Sub ادارةالشاشةوالدقةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالشاشةوالدقةToolStripMenuItem.Click
        Process.Start("desk.cpl")
    End Sub

    Private Sub ادارةالاجهزةوالتعاريفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالاجهزةوالتعاريفToolStripMenuItem.Click
        Process.Start("hdwwiz.cpl")
    End Sub

    Private Sub ادارةالطاقةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالطاقةToolStripMenuItem.Click
        Process.Start("powercfg.cpl")
    End Sub

    Private Sub ازالةالبرامجToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ازالةالبرامجToolStripMenuItem.Click
        Process.Start("appwiz.cpl")
    End Sub

    Private Sub الامنوالصيانةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الامنوالصيانةToolStripMenuItem.Click
        Process.Start("wscui.cpl")
    End Sub

    Private Sub جدولالمهامToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جدولالمهامToolStripMenuItem.Click
        Process.Start("taskschd.msc")
    End Sub

    Private Sub خدماتويندوزToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles خدماتويندوزToolStripMenuItem.Click
        Process.Start("services.msc")
    End Sub

    Private Sub الملفاتالتيتتممشاركتهاToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("fsmgmt.msc")
    End Sub

    Private Sub ادارةالقرصالصلبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("diskmgmt.msc")
    End Sub

    Private Sub ادارةالكوبيوترالخاصبكToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("compmgmt.msc")
    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub ToolStripComboBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub دفترالملاحظاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles دفترالملاحظاتToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub ادارةالتصريحاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالتصريحاتToolStripMenuItem.Click
        Process.Start("azman.msc")
    End Sub

    Private Sub شهاداتالكومبيوترToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles شهاداتالكومبيوترToolStripMenuItem.Click
        Process.Start("certlm.msc", arguments:="123")
    End Sub

    Private Sub كابينةالخدماتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كابينةالخدماتToolStripMenuItem.Click
        Process.Start("comexp.msc")
    End Sub

    Private Sub ادارةالكومبيوترادواتالنظامالسعةوالتخزينالخدماتوالنطبيقاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالكومبيوترادواتالنظامالسعةوالتخزينالخدماتوالنطبيقاتToolStripMenuItem.Click
        Process.Start("compmgmt.msc")
    End Sub

    Private Sub ادارةالاجهزةالملحقةوالتعريفاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالاجهزةالملحقةوالتعريفاتToolStripMenuItem.Click
        Process.Start("devmgmt.msc")
    End Sub

    Private Sub ادارةالقرصالصلبToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالقرصالصلبToolStripMenuItem1.Click
        Process.Start("diskmgmt.msc")
    End Sub

    Private Sub مشاهدةالاحداثToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشاهدةالاحداثToolStripMenuItem.Click
        Process.Start("eventvwr.msc")
    End Sub

    Private Sub لوحةالكتابةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لوحةالكتابةToolStripMenuItem.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub ملفاتالمشاركةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ملفاتالمشاركةToolStripMenuItem.Click
        Process.Start("fsmgmt.msc")
    End Sub

    Private Sub تعديلالمجموعاتالمحليةللنظامToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلالمجموعاتالمحليةللنظامToolStripMenuItem.Click
        Process.Start("gpedit.msc")
    End Sub

    Private Sub المستخدموينوالمجموعاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles المستخدموينوالمجموعاتToolStripMenuItem.Click
        Process.Start("lusrmgr.msc")
    End Sub

    Private Sub SQLاعدادتعميلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQLاعدادتعميلToolStripMenuItem.Click
        Process.Start("cliconfg.exe")
    End Sub

    Private Sub موجةاوامردوزToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles موجةاوامردوزToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub لوحةتحكمالالوانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لوحةتحكمالالوانToolStripMenuItem.Click
        Process.Start("colorcpl.exe")
    End Sub

    Private Sub ادارةالكومبيوترToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالكومبيوترToolStripMenuItem.Click
        Process.Start("CompMgmtLauncher.exe")
    End Sub

    Private Sub اعدادالبرامجالافتراضيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اعدادالبرامجالافتراضيةToolStripMenuItem.Click
        Process.Start("ComputerDefaults.exe")
    End Sub

    Private Sub اخراجامنللاجهزةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخراجامنللاجهزةToolStripMenuItem.Click
        Process.Start("DeviceEject.exe")
    End Sub

    Private Sub اضافةالاجهزةوالاقترانبهاToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةالاجهزةوالاقترانبهاToolStripMenuItem.Click
        Process.Start("DevicePairingWizard.exe")
    End Sub

    Private Sub تبديلطرقالعرضToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تبديلطرقالعرضToolStripMenuItem.Click
        Process.Start("DisplaySwitch.exe")
    End Sub

    Private Sub مشغلالصوتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشغلالصوتToolStripMenuItem.Click
        Process.Start("dvdplay.exe")
    End Sub

    Private Sub البلوتوثToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("fsquirt.exe")
    End Sub

    Private Sub اضافةعتادللحاسبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةعتادللحاسبToolStripMenuItem.Click
        Process.Start("hdwwiz.exe")
    End Sub

    Private Sub لوحةالمساعدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لوحةالمساعدةToolStripMenuItem.Click
        Process.Start("HelpPane.exe")
    End Sub

    Private Sub الساحرلعململفتنصيبللبرامجوالملفاتوالصورومقاطعالصوتوالفيديوToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الساحرلعململفتنصيبللبرامجوالملفاتوالصورومقاطعالصوتوالفيديوToolStripMenuItem.Click
        Process.Start("iexpress.exe")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("lpksetup.exe")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start("Magnify.exe")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("MdSched.exe")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start("MRT.exe")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("mspaint.exe")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Process.Start("psr.exe")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start("StikyNot.exe")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start("osk.exe")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start("write.exe")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Process.Start("Taskmgr.exe")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Process.Start("SnippingTool.exe")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start("nslookup.exe")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Process.Start("Netplwiz.exe")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Process.Start("OptionalFeatures.exe")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Process.Start("perfmon.exe")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Process.Start("regedit.exe")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Process.Start("resmon.exe")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Process.Start("WF.msc")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Process.Start("fsquirt.exe")
    End Sub
End Class