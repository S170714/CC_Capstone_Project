using Pharmaceutical.Services;
using BlazorInputFile;
namespace Pharmaceutical.Data
{

		public class FileUpload : IFileUpload
		{
			private readonly IWebHostEnvironment _webHostEnvironment;


			public FileUpload(IWebHostEnvironment webHost)
			{
				_webHostEnvironment = webHost;
			}

			public async Task UploadFile(IFileListEntry file)
			{
				var path = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "images", file.Name);
				var MemStream = new MemoryStream();
				await file.Data.CopyToAsync(MemStream);
				using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
				{
					MemStream.WriteTo(fs);
				}
			}
		}

}

