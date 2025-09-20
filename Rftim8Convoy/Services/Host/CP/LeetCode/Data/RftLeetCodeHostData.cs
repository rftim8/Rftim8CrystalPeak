namespace Rftim8Convoy.Services.Host.CP.LeetCode.Data
{
    public class RftLeetCodeHostData : IRftLeetCodeHostData
    {
        public List<string>? Input_Test(bool testType = true, bool direction = true, string? problemName = null) => GetFileContentToList(testType, direction, problemName!);

        public List<string>? Output_Test(bool testType = true, bool direction = false, string? problemName = null) => GetFileContentToList(testType, direction, problemName!);

        private static List<string> GetFileContentToList(bool testType, bool direction, string problemName)
        {
            string dataDir = GenericURLs.data_base_folder;

            string path = direction ?
                $"{dataDir}CP\\LeetCode\\IO\\{problemName}_Input.txt" :
                $"{dataDir}CP\\LeetCode\\IO\\{problemName}_Output.txt";

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
