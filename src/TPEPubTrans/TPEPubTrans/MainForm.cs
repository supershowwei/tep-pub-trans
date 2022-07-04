using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TPEPubTrans
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            var browser = new ChromiumWebBrowser { Dock = DockStyle.Fill };

            browser.ExecuteScriptAsyncWhenPageLoaded(@"
(function () {
    var script = document.createElement(""script"");

    script.src = ""https://code.jquery.com/jquery-3.6.0.min.js"";

    script.onload = function () {
        $(""#acI"").val(""username"");
        $(""#psI"").val(""password"");
        $(""input[type='submit']"").submit();
    }

    document.head.appendChild(script);
})();");

            browser.LoadUrl("https://0809080650.gov.taipei/");

            this.Controls.Add(browser);
        }
    }
}