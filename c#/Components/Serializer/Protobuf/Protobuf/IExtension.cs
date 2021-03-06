namespace ZPF.Infrastructure.Components.Serialize.Protobuf.Protobuf 
{
    using System;
    using System.IO;

    public interface IExtension
    {
        Stream BeginAppend();
        Stream BeginQuery();
        void EndAppend(Stream stream, bool commit);
        void EndQuery(Stream stream);
        int GetLength();
    }
}

