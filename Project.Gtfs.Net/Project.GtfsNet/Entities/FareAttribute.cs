﻿// The MIT License (MIT)

// Copyright (c) 2014 Ben Abelshausen

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GtfsNet.Enums;

namespace GtfsNet.Entities
{
	/// <summary>
	/// Represents fare information for a transit organization's routes.
	/// </summary>
	/// <remarks>
	/// Copied from
	/// https://github.com/OsmSharp/GTFS/blob/226a247861cf90badde49655095193ac829cf227/GTFS/Entities/FareAttribute.cs
	/// </remarks>
	public class FareAttribute : Entity, IEqualityComparer<FareAttribute>
	{
		[Required]
		public string FareId { get; set; }

		[Required]
		public string Price { get; set; }

		[Required]
		public string CurrencyType { get; set; }

		[Required]
		public PaymentMethodType PaymentMethod { get; set; }

		[Required]
		public int? Transfers { get; set; }

		public string TransferDuration { get; set; }

		public bool Equals(FareAttribute x, FareAttribute y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(FareAttribute obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
