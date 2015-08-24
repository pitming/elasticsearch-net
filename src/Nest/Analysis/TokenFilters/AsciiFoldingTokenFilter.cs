﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{

	/// <summary>
	/// A token filter of type asciifolding that converts alphabetic, numeric, and symbolic Unicode characters which are 
	/// <para> not in the first 127 ASCII characters (the “Basic Latin” Unicode block) into their ASCII equivalents, if one exists.</para>
	/// </summary>
	public interface IAsciiFoldingTokenFilter : ITokenFilter
	{
		bool? PreserveOriginal { get; set; }
	}

	///<inheritdoc/>
	public class AsciiFoldingTokenFilter : TokenFilterBase, IAsciiFoldingTokenFilter
	{
		public AsciiFoldingTokenFilter() : base("asciifolding") { } 

		public bool? PreserveOriginal { get; set; }
	}
}