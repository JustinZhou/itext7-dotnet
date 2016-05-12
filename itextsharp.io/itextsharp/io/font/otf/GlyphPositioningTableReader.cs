/*
$Id: 21903559bf5d99bfbd1579c5bb3d4d710c12eacb $

This file is part of the iText (R) project.
Copyright (c) 1998-2016 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System.Collections.Generic;
using com.itextpdf.io.source;

namespace com.itextpdf.io.font.otf
{
	/// <summary>
	/// <p>
	/// Parses an OpenTypeFont file and reads the Glyph Substitution Table.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Parses an OpenTypeFont file and reads the Glyph Substitution Table. This table governs how two or more Glyphs should be merged
	/// to a single Glyph. This is especially useful for Asian languages like Bangla, Hindi, etc.
	/// </p>
	/// <p>
	/// This has been written according to the OPenTypeFont specifications. This may be found <a href="http://www.microsoft.com/typography/otspec/gsub.htm">here</a>.
	/// </p>
	/// </remarks>
	/// <author><a href="mailto:paawak@gmail.com">Palash Ray</a></author>
	public class GlyphPositioningTableReader : OpenTypeFontTableReader
	{
		/// <exception cref="System.IO.IOException"/>
		public GlyphPositioningTableReader(RandomAccessFileOrArray rf, int gposTableLocation
			, OpenTypeGdefTableReader gdef, IDictionary<int, Glyph> indexGlyphMap, int unitsPerEm
			)
			: base(rf, gposTableLocation, gdef, indexGlyphMap, unitsPerEm)
		{
			StartReadingTable();
		}

		/// <exception cref="System.IO.IOException"/>
		protected internal override OpenTableLookup ReadLookupTable(int lookupType, int lookupFlag
			, int[] subTableLocations)
		{
			switch (lookupType)
			{
				case 2:
				{
					return new GposLookupType2(this, lookupFlag, subTableLocations);
				}

				case 4:
				{
					return new GposLookupType4(this, lookupFlag, subTableLocations);
				}

				case 5:
				{
					return new GposLookupType5(this, lookupFlag, subTableLocations);
				}

				default:
				{
					return null;
				}
			}
		}
	}
}