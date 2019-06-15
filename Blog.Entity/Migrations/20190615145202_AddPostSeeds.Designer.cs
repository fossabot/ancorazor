﻿// <auto-generated />
using System;
using Blog.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Entity.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20190615145202_AddPostSeeds")]
    partial class AddPostSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Entity.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Author")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("Category")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("CommentCount");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("Cover")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Digest")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDraft");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("Alias")
                        .IsUnique()
                        .HasName("IX_Article_Alias");

                    b.HasIndex("Author");

                    b.HasIndex("Category");

                    b.HasIndex("Cover");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasName("IX_Article_Title");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "welcome-to-ancorazor",
                            Author = 0,
                            Category = 2,
                            CommentCount = 0,
                            Content = @"---
title: Welcome to ancorazor!
description: Learn how to write a post.
draft: no
category: tutorial
tags:
- markdown
- yaml-front-matter
date: 2019/6/8
---

Let's take a look at some simple markdown demonstration.
# Headers
## h2
### h3
#### h4
##### h5

# Code
## code block
```C#
public class SiteSettingService
{
	private readonly BlogContext _context;

	public SiteSettingService(BlogContext context)
	{
		_context = context;
	}
}
```
## Inline code
hello `world`!
## More?
Ancorazor's editor based on [EasyMDE](https://github.com/Ionaru/easy-markdown-editor), so there's nothing special on markdown syntax,  If u are not familiar with markdown, this [guide](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet) would be a good start.
# YAML front matter
> YFM is an section of valid YAML that is placed at the top of a page and is used for maintaining metadata for the page and its contents.

You need to know this is **required** for every post in the ancorazor.

```yaml
---
title: Welcome to ancorazor!
description: Learn how to write a post.
draft: no
category: tutorial
tags:
- markdown
- yaml-front-matter
date: 2019/6/8
---
```

From top to bottom:
1. title：required.
2. alias：optional, using on url.
3. description：optional, will display below the title.
4. draft：optional, means this article only visible for authorized user,  valid inputs are `true\false\yes\no`.
5. category：optional, categorize an article and can be used on part of the url depends on your site setting, ancorazor doesn't support *multiple categories*  so use category instead.
6. tags：optional
7. date：optional

Basically same as this [documentation](http://assemble.io/docs/YAML-front-matter.html).

# Image upload
## Post cover
Upload your cover to this place, below the editor.
![](http://ww1.sinaimg.cn/large/006bSnAKgy1g3tkwozvfnj30ml031dfn.jpg)
## Insert images to markdown
I would recommend using a chrome extension like [this](https://chrome.google.com/webstore/detail/%E6%96%B0%E6%B5%AA%E5%BE%AE%E5%8D%9A%E5%9B%BE%E5%BA%8A/fdfdnfpdplfbbnemmmoklbfjbhecpnhf?hl=zh-CN).
![](http://ww1.sinaimg.cn/large/006bSnAKgy1g3tkypqgbuj30lu0f2my7.jpg)

Then just paste that markdown to here, pretty simple.

# Tips
Ancorazor has no autosave or something like that, so you'd be better finishing your writing in a .md file first or post this as a draft.

Thanks for reading this guide, hope you can enjoy your writing.",
                            Cover = 0,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Digest = "Learn how to write a post.",
                            IsDraft = false,
                            Title = "Welcome to ancorazor!",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            ViewCount = 0
                        },
                        new
                        {
                            Id = 2,
                            Alias = "getting-start-with-ancorazor",
                            Author = 0,
                            Category = 2,
                            CommentCount = 0,
                            Content = @"---
title: 欢迎使用ancorazor!
alias: Getting start with ancorazor
description: 本文将向你演示如何写一篇文章.
draft: no
category: tutorial
tags:
- markdown
- yaml-front-matter
date: 2019/6/8
---

先来看一些简单的markdown演示。
# Headers
## h2
### h3
#### h4
##### h5

# Code
## code block
```C#
public class SiteSettingService
{
	private readonly BlogContext _context;

	public SiteSettingService(BlogContext context)
	{
		_context = context;
	}
}
```
## Inline code
hello `world`!
## 还有呢？
Ancorazor使用的编辑器基于[EasyMDE](https://github.com/Ionaru/easy-markdown-editor)，所以基本的markdown语法都是支持的，如果你对markdown还不是很熟悉，建议你可以看下这个[教程](https://www.runoob.com/markdown/md-tutorial.html)。
# YAML front matter
> YFM 用于维护 markdown 页面的元数据的 yaml 格式的内容，所谓的元数据就是指标题、日期、分类和标签等内容，位于 markdown 文件的顶部。

在 ancorazor 中，**每篇**文章都需要`yaml-front-matter`提供必须的内容。

```yaml
---
title: Welcome to ancorazor!
alias: Getting start with ancorazor
description: Learn how to write a post.
draft: no
category: tutorial
tags:
- markdown
- yaml-front-matter
date: 2019/6/8
---
```

从上到下依次为：
1. title 标题：必填
2. alias 别名：可选，用于 Url 的显示，中文会自动转换为拼音，不填写的话会从 title 上取
3. description 描述：可选，会显示在列表和文章的标题下方
4. draft 草稿：可选，草稿只有你自己能看见，有效值为`true\false\yes\no`
5. category 分类：可选，为文章分类，且可在站点配置中将其作为 Url 的一部分，注意 ancorazor 只支持单分类不支持多分类，所以不要写 categories
6. tags 标签：可选
7. date 文章日期：可选

基本跟该[文档](http://assemble.io/docs/YAML-front-matter.html)是一样的。
# 图片上传
## 文章封面
将你的封面拖、上传到位于编辑器下方的这个位置即可。
![](http://ww1.sinaimg.cn/large/006bSnAKgy1g3tkwozvfnj30ml031dfn.jpg)
## 在文章中插入图片
推荐你使用类似于这样的[图床插件](https://chrome.google.com/webstore/detail/%E6%96%B0%E6%B5%AA%E5%BE%AE%E5%8D%9A%E5%9B%BE%E5%BA%8A/fdfdnfpdplfbbnemmmoklbfjbhecpnhf?hl=zh-CN).
![](http://ww1.sinaimg.cn/large/006bSnAKgy1g3tkypqgbuj30lu0f2my7.jpg)

然后直接把 markdown 粘贴进来即可。

# 提示
Ancorazor **没有提供类似于自动保存的功能**，所以建议在 .md 文件里或者其他 markdown 编辑器中写好后再粘贴进来发布。

感谢阅读本篇教程，祝您写作愉快~",
                            Cover = 0,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Digest = "本文将向你演示如何写一篇文章.",
                            IsDraft = false,
                            Title = "欢迎使用ancorazor!",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("Blog.Entity.ArticleTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Article");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<int>("Tag");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Tag");

                    b.HasIndex("Article", "Tag");

                    b.ToTable("ArticleTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Article = 1,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Tag = 1,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        },
                        new
                        {
                            Id = 2,
                            Article = 1,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Tag = 2,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        },
                        new
                        {
                            Id = 3,
                            Article = 2,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Tag = 1,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        },
                        new
                        {
                            Id = 4,
                            Article = 2,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Tag = 2,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Alias")
                        .IsUnique()
                        .HasName("IX_Category_Alias");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("IX_Category_Name");

                    b.HasIndex("Name", "Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "uncategorized",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Name = "Uncategorized",
                            Remark = "default category",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        },
                        new
                        {
                            Id = 2,
                            Alias = "tutorial",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Name = "tutorial",
                            Remark = "category for demostration",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.ImageStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<long>("Size");

                    b.Property<string>("ThumbPath")
                        .HasMaxLength(500);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Uploader");

                    b.HasKey("Id");

                    b.HasIndex("Path")
                        .IsUnique()
                        .HasName("IX_ImageStorage_Path");

                    b.HasIndex("ThumbPath")
                        .IsUnique()
                        .HasName("IX_ImageStorage_ThumbPath")
                        .HasFilter("[ThumbPath] IS NOT NULL");

                    b.HasIndex("Uploader");

                    b.ToTable("ImageStorage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "cover",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Path = "upload/default/post-bg.jpg",
                            Remark = "default post cover",
                            Size = 0L,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Uploader = 1
                        });
                });

            modelBuilder.Entity("Blog.Entity.OperationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasMaxLength(200);

                    b.Property<string>("Area")
                        .HasMaxLength(200);

                    b.Property<string>("Controller")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LoginName")
                        .HasMaxLength(200);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("OperationLog");
                });

            modelBuilder.Entity("Blog.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("Role_Name_uindex")
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            IsDeleted = false,
                            IsEnabled = true,
                            Name = "Admin",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.SiteSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleTemplate");

                    b.Property<string>("Copyright")
                        .IsRequired();

                    b.Property<string>("CoverUrl")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Gitment")
                        .HasMaxLength(500);

                    b.Property<string>("Keywords");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<string>("RouteMapping")
                        .IsRequired();

                    b.Property<string>("SiteName")
                        .IsRequired();

                    b.Property<string>("SubTitle");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("SiteSetting");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleTemplate = @"---
title: Enter your title here.
category: development
tags:
- dotnet
- dotnet core
---

**Hello world!**",
                            Copyright = "ancorazor",
                            CoverUrl = "upload/default/home-bg.jpg",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            RouteMapping = "date/alias",
                            SiteName = "ancorazor",
                            Title = "Ancorazor",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "markdown",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Name = "markdown",
                            Remark = "tag for demostration",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        },
                        new
                        {
                            Id = 2,
                            Alias = "yaml-front-matter",
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            Name = "yaml-front-matter",
                            Remark = "tag for demostration",
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<int>("RoleId");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            IsDeleted = false,
                            RoleId = 1,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Blog.Entity.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthUpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("RealName")
                        .HasMaxLength(60);

                    b.Property<string>("Remark")
                        .HasMaxLength(256);

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthUpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            CreatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849),
                            IsDeleted = false,
                            LoginName = "admin",
                            Password = "$SGHASH$V1$10000$RA3Eaw5yszeel1ARIe7iFp2AGWWLd80dAMwr+V4mRcAimv8u",
                            RealName = "Admin",
                            Status = 1,
                            UpdatedAt = new DateTime(2019, 6, 15, 22, 52, 1, 500, DateTimeKind.Local).AddTicks(6849)
                        });
                });

            modelBuilder.Entity("Blog.Entity.Article", b =>
                {
                    b.HasOne("Blog.Entity.Users", "AuthorNavigation")
                        .WithMany("Article")
                        .HasForeignKey("Author")
                        .HasConstraintName("FK_Article_Users")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entity.Category", "CategoryNavigation")
                        .WithMany("Article")
                        .HasForeignKey("Category")
                        .HasConstraintName("FK_Article_Category")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entity.ImageStorage", "ImageStorageNavigation")
                        .WithMany("Article")
                        .HasForeignKey("Cover")
                        .HasConstraintName("FK_Article_ImageStorage")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Blog.Entity.ArticleTags", b =>
                {
                    b.HasOne("Blog.Entity.Article", "ArticleNavigation")
                        .WithMany("ArticleTags")
                        .HasForeignKey("Article")
                        .HasConstraintName("FK_ArticleTags_Article")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Blog.Entity.Tag", "TagNavigation")
                        .WithMany("ArticleTags")
                        .HasForeignKey("Tag")
                        .HasConstraintName("FK_ArticleTags_Tag")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Blog.Entity.ImageStorage", b =>
                {
                    b.HasOne("Blog.Entity.Users", "UploaderNavigation")
                        .WithMany("ImageStorage")
                        .HasForeignKey("Uploader")
                        .HasConstraintName("FK_ImageStorage_Users")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entity.UserRole", b =>
                {
                    b.HasOne("Blog.Entity.Role", "Role")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.UserRole_dbo.Role_RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entity.Users", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.UserRole_dbo.sysUserInfo_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
