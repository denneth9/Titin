# Titin Generator

### What is Titin

[Titin](https://en.wikipedia.org/wiki/Titin) (Pronounced as 'Titan') is the largest known protein.

The chemical formula is also, technically, the longest word in the English language.

Its 189,819 characters long, but only consists of 21 unique words, strung together.

I saw all this and thought: "I can make a program, smaller than this word, that generates this word"

And so I did.

## How it was made

There is a great page on [Wikitionary](https://en.wiktionary.org/wiki/Appendix:Protologisms/Long_words/Titin), which not only includes the entire word, but also lists, in order of appearance, what component words its made of.

What I then did, is I pasted the word into [Notepad++](https://notepad-plus-plus.org/), and replaced the words with alphabetical characters, in order of appearance:

```
a = methionyl
b = threonyl
c = glutaminyl
d = alanyl
e = prolyl
f = phenylalanyl
g = leucyl
h = seryl
i = valyl
j = glutamyl
k = glycyl
l = histidyl
m = isoleucyl
n = tryptophyl
o = arginyl
p = aspartyl
q = lysyl
r = asparaginyl
s = tyrosyl
t = cysteinyl
u = isoleucine
```

This compressed the string from 189,819 characters, down to only 26,927.

But it still retains all the information to reconstruct the original string.

Which is exactly what this program does.

## Usage

Simply run the program, and it will print the entire 189,819 character word, using only the 26,927 compressed string and some code.

So, if you need access to the entire word, but don't want to download the 185 kb .txt file, you can simply run this program, and it will print it to the console.

The entire program is 30 kilobytes uncompiled, and 173 kb as a .exe, which is technically less and thus successful at compressing this specific word! (I'm working on decreasing this further, cause most of that is compiler overhead from C#, since the compressed string only is about 27 kb)


