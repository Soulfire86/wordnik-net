using System;
using System.Collections.Generic;

namespace wordnik_net.Models
{
    public class WordSearchResults
    {
        public List<WordSearchResult> SearchResults { get; set; }
        public int TotalResults { get; set; }
    }

    public class WordSearchResult
    {
        public long Count { get; set; }
        public double Lexicality { get; set; }
        public string Word { get; set; }
    }

    public class WordOfTheDay
    {
        public long Id { get; set; }
        public string ParentId { get; set; }
        public string Category { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public ContentProvider ContentProvider { get; set; }
        public string HtmlExtra { get; set; }
        public string Word { get; set; }
        public List<SimpleDefinition> Definitions { get; set; }
        public List<SimpleExample> Examples { get; set; }
        public string Note { get; set; }
        public DateTime PublishDate { get; set; }
    }

    public class SimpleDefinition
    {
        public string Text { get; set; }
        public string Source { get; set; }
        public string Note { get; set; }
        public string PartOfSpeech { get; set; }
    }

    public class SimpleExample
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }

    public class WordObject
    {
        public long Id { get; set; }
        public string Word { get; set; }
        public string OriginalWord { get; set; }
        public List<string> Suggestions { get; set; }
        public string CanonicalForm { get; set; }
        public string Vulgar { get; set; }
    }

    public class DefinitionSearchResults
    {
        public List<Definition> Results { get; set; }
        public int TotalResults { get; set; }
    }

    public class Definition
    {
        public string ExtendedText { get; set; }
        public string Text { get; set; }
        public string SourceDictionary { get; set; }
        public List<Citation> Citations { get; set; }
        public List<Label> Labels { get; set; }
        public float Score { get; set; }
        public List<ExampleUsage> ExampleUses { get; set; }
        public string AttributionUrl { get; set; }
        public string SeqString { get; set; }
        public string AttributionText { get; set; }
        public List<Related> RelatedWords { get; set; }
        public string Sequence { get; set; }
        public string Word { get; set; }
        public List<Note> Notes { get; set; }
        public List<TextPron> TextProns { get; set; }
        public string PartOfSpeech { get; set; }
    }

    public class Citation
    {
        public string Cite { get; set; }
        public string Source { get; set; }
    }

    public class Label
    {
        public string Text { get; set; }
        public string Type { get; set; }
    }

    public class ExampleUsage
    {
        public string Text { get; set; }
    }

    public class Related
    {
        public string Label1 { get; set; }
        public string RelationshipType { get; set; }
        public string Label2 { get; set; }
        public string Label3 { get; set; }
        public List<string> Words { get; set; }
        public string Gram { get; set; }
        public string Label4 { get; set; }
    }

    public class Note
    {
        public string NoteType { get; set; }
        public List<string> AppliesTo { get; set; }
        public string Value { get; set; }
        public int Pos { get; set; }
    }

    public class TextPron
    {
        public string Raw { get; set; }
        public int Seq { get; set; }
        public string RawType { get; set; }
    }

    public class Syllable
    {
        public string Text { get; set; }
        public int Seq { get; set; }
        public string Type { get; set; }
    }
}
