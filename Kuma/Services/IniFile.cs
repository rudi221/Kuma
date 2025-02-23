using System.Runtime.InteropServices;
using System.Text;

namespace Kuma.Services
{
    public class IniFile
    {
        public string Path;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileSection(string Section, IntPtr KeyValue, int Size, string FilePath);

        public IniFile(string path)
        {
            Path = new FileInfo(path).FullName.ToString();
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        public string Read(string section, string key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public Dictionary<string, string> ReadSection(string section)
        {
            var buffer = new char[65536];
            int len = GetPrivateProfileSection(section, Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0), buffer.Length, Path);
            var sectionData = new Dictionary<string, string>();
            if (len > 0)
            {
                string data = new string(buffer, 0, len).Trim('\0');
                string[] keyValuePairs = data.Split('\0');
                foreach (string kvp in keyValuePairs)
                {
                    var parts = kvp.Split(new char[] { '=' }, 2);
                    if (parts.Length == 2)
                    {
                        sectionData.Add(parts[0], parts[1]);
                    }
                }
            }
            return sectionData;
        }
    }
}
