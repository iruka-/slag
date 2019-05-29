#
#  MoonSharp
#
.PHONY: all clean

all:
	./make-mcs.sh
#
clean:
	-rm *~
	-rm Slag.exe
#
# == テキストファイルから実行.
test:
	./Slag.exe test.js

# == コンパイルと実行.
compile:
	./Slag.exe -c test.js
	./Slag.exe test.js.bin

#
test01:
	./Slag.exe test01.js

#
