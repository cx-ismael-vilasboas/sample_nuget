using System.IO;


namespace ExploitablePath
{
    public class EmailMessageAttachment
    {
        public Stream Stream { get; }

        public string FileName { get; }

        public EmailMessageAttachment(Stream stream, string fileName)
        {
            Stream = stream;
            FileName = fileName;
        }
    }
}