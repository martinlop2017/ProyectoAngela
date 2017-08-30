#region Copyright � 2005 Noogen Technologies Inc.
// Author:
//	Tommy Noogen (tom@noogen.net)
//
// (C) 2005 Noogen Technologies Inc. (http://www.noogen.net)
// 
// MIT X.11 LICENSE
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
#endregion

using System;
using System.Collections;

namespace AdministracionAngela.CustomControls.ValidationProvider.Design
{
	/// <summary>
	/// RegExItemCollection allow RegExPattern to be bindable.
	/// </summary>
	public class RegExPatternCollection : CollectionBase
	{
		/// <summary>
		/// Get or set RegExPattern.
		/// </summary>
		public RegExPattern this[int index] 
		{
			get { return (RegExPattern) this.List[index]; } 
			set { 	this.List[index] = value; }
		}

		/// <summary>
		/// Add new RegExPattern to collection.
		/// </summary>
		/// <param name="rePattern"></param>
		public void Add(RegExPattern rePattern)
		{ 
			this.List.Add(rePattern);
		}	
	}
}
