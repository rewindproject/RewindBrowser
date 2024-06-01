# RewindBrowser
C# Chromium Tabanlı Web Tarayıcı

## Sekmelere Göre Bellek Kullanımı
<table>
    <thead>
        <tr>
            <th></th>
            <th>Rewind Browser</th>
            <th>Chrome</th>
            <th>Firefox</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>5 Sekme</td>
            <td>242mb</td>
            <td>470mb</td>
            <td>229mb</td>
        </tr>
        <tr>
            <td>10 Sekme</td>
            <td>512mb</td>
            <td>487mb</td>
            <td>244mb</td>
        </tr>
        <tr>
            <td>30 Sekme</td>
            <td>1.504mb(1.5GB)</td>
            <td>895mb</td>
            <td>348mb</td>
        </tr>
        <tr>
            <td>100 Sekme</td>
            <td>3.575mb(3.5GB)</td>
            <td>1.958mb(2GB)</td>
            <td>634mb</td>
        </tr>
    </tbody>
</table>
Rewind Browser'in Yüksek Bellek Kullanım Nedeni; Chrome ve Firefox'un Yeni Sekmede Herhangi Bir Website'ye Yönlendirmemesidir.<br>
Rewind Browser'in Yeni Sekmesi Google.com'dur! İlerde Bu Çözülecektir Fakat Şu Anlık Firefox Kullanmanızı Öneririz.

## Nuget Paketleri
CefSharp.Common<br>
CefSharp.WinForms<br>
chromiumembeddedframework.runtime.win-x64<br>
chromiumembeddedframework.runtime.win-x86<br>
EasyTabs<br>
HtmlAgilityPack<br>
Svg<br>
Win32Interop.Dwmapi<br>
Win32Interop.Gdi32<br>
Win32Interop.Kernel32<br>
Win32Interop.User32<br>
Win32Interop.Uxtheme<br>
