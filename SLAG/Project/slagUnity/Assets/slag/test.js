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
	PrintLn(0x10000);
	PrintLn(256 | 16 | 1);
	PrintLn(0xffff ^ 0xaa55);
	PrintLn(0x10000 | 0xaa55);

	Console.Write("0x{0:X}",256 | 16 | 1);PrintLn();
	Console.Write("0x{0:X}",0xffff ^ 0xaa55);PrintLn();
	Console.Write("0x{0:X}",0x1000 | 0xa55);PrintLn();

	var x = 0x1800;
	var x1 = 0;
	if(x & 0x1000) {x1=1;}

	var y = 0x1800;
	var y1 = 0;
	if(x & 0x400) {y1=1;}

	PrintLn("x1=" + x1);
	PrintLn("y1=" + y1);
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
