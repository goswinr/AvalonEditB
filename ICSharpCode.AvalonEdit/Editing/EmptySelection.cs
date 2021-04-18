// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using AvalonEditB.Document;
using AvalonEditB.Utils;

namespace AvalonEditB.Editing
{
	/// <summary>
	/// Dummy value for no selction present.
	/// Exposed publicly to allow type checking on TextArea.Selection
	/// </summary>
	public sealed class EmptySelection : Selection
	{

		/// <summary>
		/// Returns EmptySelection
		/// </summary>
		public EmptySelection(TextArea textArea) : base(textArea)
		{
		}

		/// <summary>
		/// Returns this instance
		/// </summary>
		public override Selection UpdateOnDocumentChange(DocumentChangeEventArgs e)
		{
			return this;
		}

		/// <summary>
		/// Returns TextViewPosition(TextLocation.Empty)
		/// </summary>
		public override TextViewPosition StartPosition {
			get { return new TextViewPosition(TextLocation.Empty); }
		}

		/// <summary>
		/// Returns TextViewPosition(TextLocation.Empty)
		/// </summary>
		public override TextViewPosition EndPosition {
			get { return new TextViewPosition(TextLocation.Empty); }
		}

		/// <summary>
		/// Returns null
		/// </summary>
		public override ISegment SurroundingSegment {
			get { return null; }
		}

		/// <summary>
		/// Raises NotSupportedException()
		/// </summary>
		public override Selection SetEndpoint(TextViewPosition endPosition)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		/// Returns a new valil seelction if possible
		/// </summary>
		public override Selection StartSelectionOrSetEndpoint(TextViewPosition startPosition, TextViewPosition endPosition)
		{
			var document = textArea.Document;
			if (document == null)
				throw ThrowUtil.NoDocumentAssigned();
			return Create(textArea, startPosition, endPosition);
		}

		/// <summary>
		/// Returns empty list
		/// </summary>
		public override IEnumerable<SelectionSegment> Segments {
			get { return Empty<SelectionSegment>.Array; }
		}

		/// <summary>
		/// Returns empty string
		/// </summary>
		public override string GetText()
		{
			return string.Empty;
		}

		/// <summary>
		/// Inserts text at caret
		/// </summary>
		public override void ReplaceSelectionWithText(string newText)
		{
			if (newText == null)
				throw new ArgumentNullException("newText");
			newText = AddSpacesIfRequired(newText, textArea.Caret.Position, textArea.Caret.Position);
			if (newText.Length > 0) {
				if (textArea.ReadOnlySectionProvider.CanInsert(textArea.Caret.Offset)) {
					textArea.Document.Insert(textArea.Caret.Offset, newText);
				}
			}
			textArea.Caret.VisualColumn = -1;
		}

		/// <summary>
		/// returns 0
		/// </summary>
		public override int Length {
			get { return 0; }
		}

		/// <summary>
		/// Uses reference equality because there's only one EmptySelection per text area.
		/// </summary>		
		public override int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(this);
		}
		
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this == obj;
		}
	}
}
