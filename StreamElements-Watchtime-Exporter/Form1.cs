using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace StreamElements_Watchtime_Exporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_output_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txt_output.Text = sfd.FileName;
            }
        }

        private void lnk_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://streamelements.com/dashboard/account/channels";
            try
            {
                Process.Start(url);
            } catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private async void btn_export_Click(object sender, EventArgs e)
        {
            string streamElementsApiUrl = $"https://api.streamelements.com/kappa/v2/points/{txt_acc_id.Text}/watchtime?limit={int.MaxValue}&offset=0";
            using var httpClient = new HttpClient();
            using var requestMessage = new HttpRequestMessage(HttpMethod.Get, streamElementsApiUrl);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", txt_jwt.Text);
            var response = await httpClient.SendAsync(requestMessage);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string csvFileContent = "";
                var watchtime = JsonConvert.DeserializeObject<WatchtimeResponse>(await response.Content.ReadAsStringAsync());
                if (watchtime?.Users != null)
                {
                    StringBuilder csv = new();
                    csv.AppendLine("Username;Minutes");
                    foreach (WatchtimeUser user in watchtime.Users)
                    {
                        csv.AppendLine($"{user.Username};{user.Minutes}");
                    }
                    csvFileContent = csv.ToString();
                }
                File.WriteAllText(txt_output.Text, csvFileContent);
            }
            else
            {
                MessageBox.Show($"Error when talking to StreamElements: {response.StatusCode}", "Error");
            }
        }
    }
}