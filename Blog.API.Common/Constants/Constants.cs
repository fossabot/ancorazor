﻿namespace Blog.API.Common.Constants
{
    public static class Constants
    {
        public static class Article
        {
            public const string DefaultCategoryName = "Uncategorized";
            public const string RouteReplaceRegex = @"([^\w\d])+";
        }

        public static class SiteSetting
        {
            public const int Expiration = 60 * 60 * 24;
        }

        public static class ErrorCode
        {
            public const string Default = "0001";
            public const string DuplicateEntity = "0010";
            public const string EntityNotFound = "0011";
        }
    }
}
