//
// TEST 01
//

"using System";
"using System.IO";
"using $nameless";

function main()
{
	var a=1;
	PrintLn("hello\n123");
	PrintLn("world\taaa");
	PrintLn(1+2+3.14);
	Console.Write("Usage:\n Slag.exe script.js\t:");
	PrintLn(a+2);
	PrintLn(256 | 1);
}

function main2()
{
	var t1 = new $nameless.myTest100();
	t1.x = 1000;
	var a = t1.getx();
	PrintLn(a);
	a = t1.getx();
	PrintLn(a);
}


main();
