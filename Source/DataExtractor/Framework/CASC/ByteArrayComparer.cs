﻿/*
 * Copyright (C) 2012-2017 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections;
using System.Collections.Generic;

namespace Framework.CASC
{
    public class ByteArrayComparer : IEqualityComparer, IEqualityComparer<object>
    {
        public new bool Equals(object x, object y)
        {
            var eq = x as IStructuralEquatable;

            return eq == null ? object.Equals(x, y) : eq.Equals(y, this);
        }

        public int GetHashCode(object obj)
        {
            var eq = obj as IStructuralEquatable;

            return eq == null ? EqualityComparer<object>.Default.GetHashCode(obj) : eq.GetHashCode(this);
        }
    }
}