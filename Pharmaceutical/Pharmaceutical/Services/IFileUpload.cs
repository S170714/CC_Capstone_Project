using BlazorInputFile;
namespace Pharmaceutical.Services
{
	public interface IFileUpload
	{
		Task UploadFile(IFileListEntry file);
	}
}
