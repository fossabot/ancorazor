#region

using System;

#endregion

namespace Blog.Entity
{
    /// <summary>
    ///     Article
    /// </summary>
    public class Article
    {
        /// <summary>
        ///     Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Cover
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        ///     Author
        /// </summary>
        public int? Author { get; set; }

        /// <summary>
        ///     Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        ///     Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     Digest
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        ///     ViewCount
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        ///     CommentCount
        /// </summary>
        public int CommentCount { get; set; }

        /// <summary>
        ///     UpdatedAt
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///     CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     Remark
        /// </summary>
        public string Remark { get; set; }
    }
}