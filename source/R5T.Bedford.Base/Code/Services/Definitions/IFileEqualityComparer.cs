using System;


namespace R5T.Bedford
{
    public interface IFileEqualityComparer
    {
        bool Equals(string filePath1, string filePath2);
    }
}
