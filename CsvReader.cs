namespace LibrarySystem
{
    class CsvReader
    {
        string content = "";
        public CsvReader(string file_name) 
        {
            var file = File.OpenRead(file_name);
            byte[] data = new byte[file.Length];
            file.Read(data, 0, (int)file.Length);
            //string result = Encoding.UTF8.GetString(data);

            foreach (var b in data)
            {
                char c = (char)b;
                content += c;
            }

            //Console.WriteLine(c);
        }
        public string getContent()
        {
            return content;
        }
    }
}
