namespace WzorceKonstrukcyjne.Budowniczy.AbstractFactory
{
    interface IFileEditor
    {
        void Add(string text);
        void ClearAllText();
        void Remove(string text);
    }
}