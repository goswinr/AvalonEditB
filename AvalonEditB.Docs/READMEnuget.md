# AvalonEditB

![logo](https://raw.githubusercontent.com/goswinr/AvalonEditB/main/AvalonEditB.Docs/logo400.png)

AvalonEditB is a fork of a [AvalonEdit](https://github.com/icsharpcode/AvalonEdit)
with some small modifications like:
* **Search-and-Replace** functionality taken and adapted from [PR 99](https://github.com/icsharpcode/AvalonEdit/pull/99).
* **Block Selection** with middle mouse button (like in VS code).
* Some private properties exposed as public.
* Support for cursive fonts via xshd syntax highlighting.
* Less redrawing of folding sections for better performance (controlled via FoldingManger.AutoRedrawFoldingSections).
* Bugfixes in key handling when completion list is not showing.
* styling of current line and its number.

### Documentation
Check out the original [original documentation](http://avalonedit.net/documentation/) and the [samples and articles wiki page](https://github.com/icsharpcode/AvalonEdit/wiki/Samples-and-Articles).

### License
AvalonEditB is also distributed under the  [MIT License](https://github.com/goswinr/AvalonEditB/blob/main/LICENSE.txt).

### Changelog

`2.4.0`
- add CollapsedLinesAreInconsitent to TextView to check Folding bugs

`2.3.0`
- use IHighlightingRule to allow non regex highlighters
- Fix rounding error when getting VisualLine
- merge changes from AvalonEdit
- TargetFrameworks: net472, net6.0-windows

`2.2.0`
- fix key handling when completion list box is invisible.
- FoldingManger.AutoRedrawFoldingSections = true ( by default)
- Disable email links

`2.1.0`
- improve current line highlighting
- improve line number margin
- improve search panel

`2.0.0`
- add FoldingManger.AutoRedrawFoldingSections = false; to not redraw full section

`1.8.0`
- Enable code folding in more than one TextViews.
- Don't build visual lines from collapsed lines

`1.7.1`
- bring in changes from Avalonedit 6.3.0
- support all FontWeights and stylistic set 1 in xshd syntax highlighting

`1.6.0`
- show count in search
- fix typos

`1.5.1`
- net7.0
- bring in changes from Avalonedit repro up till Dec 2022
- fix typos

`1.4.1`
- bring in changes from Avalonedit repro up till July 2022

`1.4.0`
- bring in changes from Avalonedit 6.1.3

`1.3.0`
- target net6.0 and net472

`1.2.0`
- Revert to original sorting in completion list.
- Improve Error messages of TextSegment.
- All relevant commits up to release 6.1.2 of [AvalonEdit](https://github.com/icsharpcode/AvalonEdit) are included.

`1.0.0`
- All relevant commits up to release 6.1.1 of [AvalonEdit](https://github.com/icsharpcode/AvalonEdit) are included.