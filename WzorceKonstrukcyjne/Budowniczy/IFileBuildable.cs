namespace WzorceKonstrukcyjne.Budowniczy
{
    public interface IFileBuildable
    {
        string Path { get; set; }

        void CreateFile();
        void SetText(string text);
    }
}