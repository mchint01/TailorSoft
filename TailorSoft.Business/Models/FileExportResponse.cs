namespace TailorSoft.Business.Models
{
    public class FileExportResponse
    {
        /// <summary>
        /// Byte Array contents of file
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// name of file
        /// </summary>
        public string FileName { get; set; }
    }
}