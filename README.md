# AvalonEditB 

[![nuget](https://img.shields.io/nuget/v/AvalonEditB.svg)](https://nuget.org/packages/AvalonEditB) 
[![fuget](https://www.fuget.org/packages/AvalonEditB/badge.svg)](https://www.fuget.org/packages/AvalonEditB)
![code size](https://img.shields.io/github/languages/code-size/goswinr/AvalonEditB.svg) 
[![License](https://img.shields.io/badge/license-MIT-green)](./LICENSE)
<!-- [![license](https://img.shields.io/github/license/goswinr/AvalonEditB.svg)](https://github.com/goswinr/AvalonEditB/blob/main/LICENSE.txt) doesnt work -->
<!-- [![release](https://img.shields.io/github/release/goswinr/AvalonEditB.svg)](https://github.com/goswinr/AvalonEditB/releases)  -->

![logo](https://raw.githubusercontent.com/goswinr/AvalonEditB/main/AvalonEditB.Docs/logo400.png)

AvalonEditB is a fork of a [AvalonEdit](https://github.com/icsharpcode/AvalonEdit)
with some small modifications like:
* **Search-and-Replace** functionality taken and adapted from [PR 99](https://github.com/icsharpcode/AvalonEdit/pull/99)
* **Block Selection** with middle mouse button (like in VS code)
* Some private properties exposed as public

### Download

AvalonEditB is available as [NuGet package](https://www.nuget.org/packages/AvalonEditB). 

### How to build

Just run `dotnet build` in `AvalonEditB` directory.

### Documentation
Check out the original [original documentation](http://avalonedit.net/documentation/) and the [samples and articles wiki page](https://github.com/icsharpcode/AvalonEdit/wiki/Samples-and-Articles). 
Building the documentation and running the test currently does not work from this fork.

### License
AvalonEditB also has the  [MIT License](https://github.com/goswinr/AvalonEditB/blob/main/LICENSE.txt).

Logo by [Lovepik](https://lovepik.com/image-401307902/crystal-clownfish-side-cartoon-01.html)

### Projects using AvalonEditB

* https://github.com/goswinr/AvalonLog
* https://github.com/goswinr/Seff 
* https://github.com/goswinr/Seff.Rhino 
* https://github.com/goswinr/Seff.Revit

### Changelog

`1.3.0` 
- target net6.0 and net472

`1.2.0` 
- Revert to original sorting in completion list.
- Improve Error messages of TextSegment.
- All relevant commits up to release 6.1.2 of [AvalonEdit](https://github.com/icsharpcode/AvalonEdit) are included.
            
`1.0.0` 
- All relevant commits up to release 6.1.1 of [AvalonEdit](https://github.com/icsharpcode/AvalonEdit) are included.


