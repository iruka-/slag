> [English - Translated by Google](https://translate.googleusercontent.com/translate_c?act=url&depth=1&hl=ja&ie=UTF8&prev=_t&rurl=translate.google.co.jp&sl=ja&sp=nmt1&tl=en&u=https://github.com/iruka-/slag)

[オリジナル版README](https://github.com/iruka-/slag/blob/master/README-orig.md)

# slag (Something Like A Gei-es[JS])

(Unity用)組込スクリプトシステム

## 概要

このリポジトリは、C#の自己学習のための Fork です。

Unity用組込スクリプトシステム slag を、C#全くの初心者が、Linux CUI上の mono で動かしてみました。

## C# 実行環境をLinuxに導入

Ubuntu 18.04 LTS

 $ sudo apt install mono-devel

## 実行.

 $ cd slag/SLAG/Project/slagUnity/Assets/slag

 $ make

 $ make test

## プリコンパイルしたbinを出力し、それを読み込んで実行するテスト

 $ make compile

## 改造.

* 16進数を記述できるようにした

予定

* 大文字小文字を同一視しないようにしたい
* 文字列中の \n と \t はプリコンパイルの時点で制御文字に変換したい
* #include があったらいいなぁ・
* #define を作ってもいいかなぁ・


## ToDo. 【緩募】

* mono上でC#デバッグする方法
* slagのデバッグ環境をmono上で整える方法
* スクリプトベンチマーク

## Why slag?

* C# や C++ を使用していて、なんらかのスクリプト言語のようなGlue(糊)あるいは(言語拡張)が欲しい場合があります。
* Lua や MoonSharpを試してみたのですが、Pascal風味な文法が体質に合いません。（個人の感想です）
* コンパイルが不要で、気軽にテキストを書き換えて実行できる言語としての slagに着目しました。


