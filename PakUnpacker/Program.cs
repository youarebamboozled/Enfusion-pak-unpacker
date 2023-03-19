using PakReaderExe;
using System.Net;
using System.Net.NetworkInformation;

Console.WriteLine("Path: ");
string pakPath = Console.ReadLine() ?? throw new Exception();

if (pakPath.StartsWith("\"")) pakPath = pakPath.Replace("\"", "");

if (Path.GetExtension(pakPath) != ".pak") throw new Exception();

Pak pak = new(pakPath);
pak.ExtractDataBlock(Path.ChangeExtension(pakPath, null));
