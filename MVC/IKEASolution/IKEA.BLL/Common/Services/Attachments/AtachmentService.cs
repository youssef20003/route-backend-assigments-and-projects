using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace IKEA.BLL.Common.Services.Attachments
{
    public class AtachmentService : IAttachmentService
    {
        private readonly List<string> AllowedExtentions = new List<string>() {".jpg" , ".png"};
        private const int FileMaxSize = 2_097_152;
        public string UploadImage(IFormFile File, string FolderName)
        {
            var fileExtention = Path.GetExtension(File.FileName);
            if (!AllowedExtentions.Contains(fileExtention))
            {
                throw new Exception("invalid File Extention");

            }

            if (File.Length > FileMaxSize)
            {
                throw new Exception("invalid file size");

            }

            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", FolderName);

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            var FileName = $"{Guid.NewGuid()}_{File.FileName}";

            var FilePath = Path.Combine(FolderPath, FileName);

            using var fs = new FileStream(FilePath, FileMode.Create);

            File.CopyTo(fs);

            return FileName;
        }

        public bool DeleteImage(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);

                return true;
            }
            return false;
        }
    }
}
