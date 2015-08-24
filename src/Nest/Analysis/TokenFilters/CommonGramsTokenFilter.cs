﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{
	/// <summary>
	/// Token filter that generates bigrams for frequently occuring terms. Single terms are still indexed.
	///<para>Note, common_words or common_words_path field is required.</para>
	/// </summary>
	public interface ICommonGramsTokenFilter : ITokenFilter
	{
		/// <summary>
		/// A list of common words to use.
		/// </summary>
		[JsonProperty("common_words")]
		IEnumerable<string> CommonWords { get; set; }

		/// <summary>
		/// A path (either relative to config location, or absolute) to a list of common words.
		/// </summary>
		[JsonProperty("common_words_path")]
		string CommonWordsPath { get; set; }

		/// <summary>
		/// If true, common words matching will be case insensitive.
		/// </summary>
		[JsonProperty("ignore_case")]
		bool? IgnoreCase { get; set; }

		/// <summary>
		/// Generates bigrams then removes common words and single terms followed by a common word.
		/// </summary>
		[JsonProperty("query_mode")]
		bool? QueryMode { get; set; }

	}

	/// <inheritdoc/>
	public class CommonGramsTokenFilter : TokenFilterBase, ICommonGramsTokenFilter
	{
		public CommonGramsTokenFilter() : base("common_grams") { }

		/// <inheritdoc/>
		public IEnumerable<string> CommonWords { get; set; }

		/// <inheritdoc/>
		public string CommonWordsPath { get; set; }

		/// <inheritdoc/>
		public bool? IgnoreCase { get; set; }

		/// <inheritdoc/>
		public bool? QueryMode { get; set; }

	}

}