using System;
using System.IO;
using slagtool;
//
//  Linuxで動かす場合の Main
//
class SlagCUI
{
	public static void Main(string[] args)
    {
		var t  = new SlagCUI();
		var sl = new slag(t);

		int argc = args.Length;
		if( argc < 1 ) {
			Console.Write("Usage:\n$ Slag.exe script.js\n");
		}else{
			string option = args[0];
			string file = args[0];
			if(argc >= 2) {
				file   = args[1];
			}

			if( option == "-c" ) {	//コンパイル
	    		sl.LoadFile(file);
	    		sl.SaveBin(file + ".bin");
				return;
			}

			// スクリプト実行.
			{
	    		sl.LoadFile(file);
	    		sl.Run();
				return;
			}
		}
	}
}


//
//  UnityEngineのダミー.
//
namespace UnityEngine {
	class Time
	{	
		public static float realtimeSinceStartup = 1.0f;
	}
}

namespace mySpace1 {
class myTest1
{
	int x=10;

	public int getx()
	{
		x++;
		return x;
	}
}
}


class myTest100
{
	public int x=100;

	public int getx()
	{
		x++;
		return x;
	}
}
