﻿namespace PakReaderExe;
using System;

class PakEntryFile
{
	public enum CompressionType
    {
        None,
        Zlib = 0x106
    }

    public string name;
    public int offset, size, originalSize;
    public CompressionType compression;
    private readonly byte[] unknown;
    
    public PakEntryFile( string entryName, PakReader pr)
	{
        name = entryName;
        offset = pr.ReadInt32();
        size = pr.ReadInt32();
        originalSize = pr.ReadInt32();
        pr.Skip(4);
        compression = (CompressionType)pr.ReadInt32BE();
        unknown = pr.ReadBytes(4);
    }
}
