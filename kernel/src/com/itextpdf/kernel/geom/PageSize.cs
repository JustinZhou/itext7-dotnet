/*
$Id: 9ebac8444e8fa37e81ac01b65fdcc8117262c110 $

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
namespace com.itextpdf.kernel.geom
{
	public class PageSize : Rectangle
	{
		private const long serialVersionUID = 485375591249386160L;

		public static com.itextpdf.kernel.geom.PageSize A0 = new com.itextpdf.kernel.geom.PageSize
			(2384, 3370);

		public static com.itextpdf.kernel.geom.PageSize A1 = new com.itextpdf.kernel.geom.PageSize
			(1684, 2384);

		public static com.itextpdf.kernel.geom.PageSize A2 = new com.itextpdf.kernel.geom.PageSize
			(1190, 1684);

		public static com.itextpdf.kernel.geom.PageSize A3 = new com.itextpdf.kernel.geom.PageSize
			(842, 1190);

		public static com.itextpdf.kernel.geom.PageSize A4 = new com.itextpdf.kernel.geom.PageSize
			(595, 842);

		public static com.itextpdf.kernel.geom.PageSize A5 = new com.itextpdf.kernel.geom.PageSize
			(420, 595);

		public static com.itextpdf.kernel.geom.PageSize A6 = new com.itextpdf.kernel.geom.PageSize
			(298, 420);

		public static com.itextpdf.kernel.geom.PageSize A7 = new com.itextpdf.kernel.geom.PageSize
			(210, 298);

		public static com.itextpdf.kernel.geom.PageSize A8 = new com.itextpdf.kernel.geom.PageSize
			(148, 210);

		public static com.itextpdf.kernel.geom.PageSize Default = A4;

		public PageSize(float width, float height)
			: base(0, 0, width, height)
		{
		}

		public PageSize(Rectangle box)
			: base(box.GetX(), box.GetY(), box.GetWidth(), box.GetHeight())
		{
		}

		/// <summary>Rotates PageSize clockwise.</summary>
		public virtual com.itextpdf.kernel.geom.PageSize Rotate()
		{
			return new com.itextpdf.kernel.geom.PageSize(height, width);
		}

		public override Rectangle Clone()
		{
			return new com.itextpdf.kernel.geom.PageSize(this);
		}
	}
}