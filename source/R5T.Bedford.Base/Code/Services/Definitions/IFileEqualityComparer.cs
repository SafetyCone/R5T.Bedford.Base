using System;

using R5T.T0064;


namespace R5T.Bedford
{
    [ServiceDefinitionMarker]
    public interface IFileEqualityComparer : IServiceDefinition
    {
        bool Equals(string filePath1, string filePath2);
    }
}
