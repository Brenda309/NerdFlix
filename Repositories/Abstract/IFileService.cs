namespace NerdFlix.Repositories.Abstract
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile videoFile);
        public bool DeleteImage(string videoFileName);
    }
}
