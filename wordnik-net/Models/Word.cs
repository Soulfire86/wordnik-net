using System;
using System.Collections.Generic;

namespace wordnik_net.Models
{
    public class ExampleSearchResults
    {
        public List<Facet> Facets { get; set; }
        public List<Example> Examples { get; set; }
    }

    public class Facet
    {
        public List<FacetValue> FacetValues { get; set; }
        public string Name { get; set; }
    }

    public class FacetValue
    {
        public long Count { get; set; }
        public string Value { get; set; }
    }

    public class Example
    {
        public long Id { get; set; }
        public long ExampleId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public ScoredWord Score { get; set; }
        public Sentence Sentence { get; set; }
        public string Word { get; set; }
        public ContentProvider Provider { get; set; }
        public int Year { get; set; }
        public float Rating { get; set; }
        public long DocumentId { get; set; }
        public string Url { get; set; }
    }

    public class ScoredWord
    {
        public int Position { get; set; }
        public long Id { get; set; }
        public int DocTermCount { get; set; }
        public string Lemma { get; set; }
        public string WordType { get; set; }
        public float Score { get; set; }
        public long SentenceId { get; set; }
        public string Word { get; set; }
        public bool Stopword { get; set; }
        public double BaseWordScore { get; set; }
        public string PartOfSpeech { get; set; }
    }

    public class Sentence
    {
        public bool HasScoredWords { get; set; }
        public long Id { get; set; }
        public List<ScoredWord> ScoredWords { get; set; }
        public string Display { get; set; }
        public int Rating { get; set; }
        public long DocumentMetadataId { get; set; }
    }

    public class ContentProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class FrequencySummary
    {
        public int UnknownYearCount { get; set; }
        public long TotalCount { get; set; }
        public string FrequencyString { get; set; }
        public string Word { get; set; }
        public List<Frequency> Frequency { get; set; }
    }

    public class Frequency
    {
        public long Count { get; set; }
        public int Year { get; set; }
    }

    public class Bigram
    {
        public long Count { get; set; }
        public string Gram1 { get; set; }
        public string Gram2 { get; set; }
        public double Wlmi { get; set; }
        public double Mi { get; set; }

    }

    public class AudioFile
    {
        public string AttributionUrl { get; set; }
        public int CommentCount { get; set; }
        public int VoteCount { get; set; }
        public string FileUrl { get; set; }
        public string AudioType { get; set; }
        public long Id { get; set; }
        public double Duration { get; set; }
        public string AttributionText { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public float VoteWeightedAverage { get; set; }
        public float VoteAverage { get; set; }
        public string Word { get; set; }

    }
}
