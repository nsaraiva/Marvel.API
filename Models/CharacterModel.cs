using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract]
    public class Rootobject
    {
        [DataMember(Name = "code")]
        public int code { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "copyright")]
        public string copyright { get; set; }
        [DataMember(Name = "attributionText")]
        public string attributionText { get; set; }
        [DataMember(Name = "attributionHTML")]
        public string attributionHTML { get; set; }
        [DataMember(Name = "etag")]
        public string etag { get; set; }
        [DataMember(Name = "data")]
        public Data data { get; set; }
    }
    [DataContract]
    public class Data
    {
        [DataMember(Name = "offset")]
        public int offset { get; set; }
        [DataMember(Name = "limit")]
        public int limit { get; set; }
        [DataMember(Name = "total")]
        public int total { get; set; }
        [DataMember(Name = "count")]
        public int count { get; set; }
        [DataMember(Name = "results")]
        public Result[] results { get; set; }
    }
    [DataContract]
    public class Result
    {
        [DataMember(Name ="id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "description")]
        public string description { get; set; }
        [DataMember(Name = "modified")]
        public DateTime modified { get; set; }
        [DataMember(Name = "thumbnail")]
        public Thumbnail thumbnail { get; set; }
        [DataMember(Name = "resourceURI")]
        public string resourceURI { get; set; }
        [DataMember(Name = "comics")]
        public Comics comics { get; set; }
        [DataMember(Name = "series")]
        public Series series { get; set; }
        [DataMember(Name = "stories")]
        public Stories stories { get; set; }
        [DataMember(Name = "events")]
        public Events events { get; set; }
        [DataMember(Name = "urls")]
        public Url[] urls { get; set; }
    }
    [DataContract]
    public class Thumbnail
    {
        [DataMember(Name = "path")]
        public string path { get; set; }
        [DataMember(Name = "extension")]
        public string extension { get; set; }
    }

    [DataContract]
    public class Comics
    {
        [DataMember(Name = "available")]
        public int available { get; set; }
        [DataMember(Name = "collectionURI")]
        public string collectionURI { get; set; }
        [DataMember(Name = "items")]
        public Item[] items { get; set; }
        [DataMember(Name = "returned")]
        public int returned { get; set; }
    }

    [DataContract]
    public class Item
    {
        [DataMember(Name = "resourceURI")]
        public string resourceURI { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
    }

    [DataContract]
    public class Series
    {
        [DataMember(Name = "available")]
        public int available { get; set; }
        [DataMember(Name = "collectionURI")]
        public string collectionURI { get; set; }
        [DataMember(Name = "items")]
        public Item1[] items { get; set; }
        [DataMember(Name = "returned")]
        public int returned { get; set; }
    }

    [DataContract]
    public class Item1
    {
        [DataMember(Name = "resourceURI")]
        public string resourceURI { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
    }

    [DataContract]
    public class Stories
    {
        [DataMember(Name = "available")]
        public int available { get; set; }
        [DataMember(Name = "collectionURI")]
        public string collectionURI { get; set; }
        [DataMember(Name = "items")]
        public Item2[] items { get; set; }
        [DataMember(Name = "returned")]
        public int returned { get; set; }
    }

    [DataContract]
    public class Item2
    {
        [DataMember(Name = "resourceURI")]
        public string resourceURI { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "type")]
        public string type { get; set; }
    }

    [DataContract]
    public class Events
    {
        [DataMember(Name = "available")]
        public int available { get; set; }
        [DataMember(Name = "collectionURI")]
        public string collectionURI { get; set; }
        [DataMember(Name = "items")]
        public Item3[] items { get; set; }
        [DataMember(Name = "returned")]
        public int returned { get; set; }
    }

    [DataContract]
    public class Item3
    {
        [DataMember(Name = "resourceURI")]
        public string resourceURI { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
    }

    [DataContract]
    public class Url
    {
        [DataMember(Name = "type")]
        public string type { get; set; }
        [DataMember(Name = "url")]
        public string url { get; set; }
    }

}
