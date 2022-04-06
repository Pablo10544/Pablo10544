 public static void AddToStartup() {
            using (RegistryKey keyr = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                keyr.SetValue("YOUR_PROGRAM_NAME", System.IO.Path.GetDirectoryName(
System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\EXE_NAME" + ".exe");
            }
        }
