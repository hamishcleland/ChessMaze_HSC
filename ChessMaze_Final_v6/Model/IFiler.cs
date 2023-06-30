namespace ChessMaze_Final
{
    public interface IFiler
    {
        void Save(string filename);
        string Load(string filename);
    }
}
