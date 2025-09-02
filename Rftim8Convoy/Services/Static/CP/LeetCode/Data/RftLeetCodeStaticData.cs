namespace Rftim8Convoy.Services.Static.CP.LeetCode.Data
{
    public class RftLeetCodeStaticData : IRftLeetCodeStaticData<List<string>, List<string>>
    {
        public static List<string>? Input_Test(bool testType = true, bool direction = true, string? problemName = null) => GetFileContentToList(testType, direction, problemName!);

        public static List<string>? Output_Test(bool testType = true, bool direction = false, string? problemName = null) => GetFileContentToList(testType, direction, problemName!);

        private static List<string> GetFileContentToList(bool testType, bool direction, string problemName)
        {
            string? goBack = testType ? string.Concat(Enumerable.Repeat("..\\", 4)) : string.Concat(Enumerable.Repeat("..\\", 8));
            string projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, goBack!));

            string path = direction ?
                $"{projectDir}\\Rftim8Atlas\\CP\\LeetCode\\IO\\{problemName}_Input.txt" :
                $"{projectDir}\\Rftim8Atlas\\CP\\LeetCode\\IO\\{problemName}_Output.txt";

            List<string> list = [];

            using (FileStream fileStream = new(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using StreamReader streamReader = new(fileStream);

                while (!streamReader.EndOfStream)
                {
                    string? buffer = streamReader.ReadLine();

                    if (buffer is not null)
                        list.Add(buffer);
                }
            }

            return list;
        }
    }
}
