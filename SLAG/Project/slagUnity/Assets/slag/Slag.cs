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
	    	sl.LoadFile(args[0]);
    		sl.Run();
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

