namespace ZPF.Infrastructure.Components.Serialize.Protobuf.Compiler
{
    using ZPF.Infrastructure.Components.Serialize.Protobuf.Protobuf;

    using System;
    using System.Runtime.CompilerServices;

    internal delegate object ProtoDeserializer(object value, ProtoReader source);
}

