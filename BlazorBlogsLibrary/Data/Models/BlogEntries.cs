// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DotNetNukeBlogs.Data.Models
{
    public partial class BlogEntries
    {
        public BlogEntries()
        {
            BlogComments = new HashSet<BlogComments>();
            BlogEntryCategories = new HashSet<BlogEntryCategories>();
            BlogEntryTags = new HashSet<BlogEntryTags>();
        }

        public int BlogId { get; set; }
        public int EntryId { get; set; }
        public string Title { get; set; }
        public string Entry { get; set; }
        public DateTime AddedDate { get; set; }
        public bool Published { get; set; }
        public string Description { get; set; }
        public bool? AllowComments { get; set; }
        public bool DisplayCopyright { get; set; }
        public string Copyright { get; set; }
        public string PermaLink { get; set; }

        public virtual ICollection<BlogComments> BlogComments { get; set; }
        public virtual ICollection<BlogEntryCategories> BlogEntryCategories { get; set; }
        public virtual ICollection<BlogEntryTags> BlogEntryTags { get; set; }
    }
}