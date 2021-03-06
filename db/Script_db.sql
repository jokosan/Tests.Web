USE [UserTests]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnswerOptions]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswerOptions](
	[IdAnswerOptions] [int] IDENTITY(1,1) NOT NULL,
	[Possiblenswer] [nvarchar](250) NULL,
	[CorrectAnswer] [bit] NULL,
	[QuestionsId] [int] NOT NULL,
 CONSTRAINT [PK_AnswerOptions] PRIMARY KEY CLUSTERED 
(
	[IdAnswerOptions] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTests]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTests](
	[IdListTest] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](1000) NULL,
	[Img] [nvarchar](250) NULL,
	[StatusPublic] [bit] NOT NULL,
 CONSTRAINT [PK_ListTests] PRIMARY KEY CLUSTERED 
(
	[IdListTest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[IdQuestions] [int] IDENTITY(1,1) NOT NULL,
	[TestsId] [int] NULL,
	[QuestionText] [nvarchar](350) NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[IdQuestions] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTests]    Script Date: 16.06.2022 19:09:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTests](
	[UserId] [nvarchar](100) NULL,
	[TestId] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220615092907_StartApplicationIdentityDbContext', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220615093132_StartUserTestingDbContext', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220615130858_EditUserTestingDbContext', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220615164420_RenameTableTest', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220616141930_EditUserTest', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[AnswerOptions] ON 

INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (2, N'for, while, do while', 0, 1)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (3, N'for, while, foreach', 0, 1)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (4, N'for', 0, 1)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (5, N'for, while', 0, 1)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (6, N'for, while, do while, foreach', 1, 1)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (7, N'Работает с файлами', 0, 2)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (8, N'Работает с исключениями', 1, 2)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (9, N'Работает с базой данных', 0, 2)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (10, N'Работает с классами', 0, 2)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (11, N'Console.write("Hi");', 0, 3)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (12, N'print("Hi");', 0, 3)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (13, N'Console.WriteLine("Hi");', 1, 3)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (14, N'сonsole.log("Hi");', 0, 3)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (15, N'"Знакове 8-біт ціле"', 0, 4)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (16, N'"Знаковое 64-бит целое"', 0, 4)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (17, N'"1 байт*"', 0, 4)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (18, N'"Знаковое 32-бит целое"', 1, 4)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (19, N'"++"', 1, 5)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (20, N'"--"', 0, 5)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (21, N'"%%"', 0, 5)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (22, N'"!="', 0, 5)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (23, N'"Or"', 0, 6)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (24, N'"!="', 0, 6)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (25, N'"!"', 0, 6)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (27, N'"||"', 1, 6)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (28, N'Length', 0, 7)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (29, N'IsStatic', 0, 7)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (31, N'IsFixedSize', 1, 7)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (32, N'Нічого з перерахованого вище', 0, 7)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (33, N'"*"', 0, 8)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (34, N'"
&"', 0, 8)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (35, N'typeof', 1, 8)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (36, N'sizeof', 0, 8)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (37, N'short < int < sbyte < long', 0, 9)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (38, N'
short < sbyte < int < long', 0, 9)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (39, N'sbyte < short < int < long', 1, 9)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (40, N'long < short < int < sbyte', 0, 9)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (41, N'ConCat()', 0, 10)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (42, N'
Copy()', 0, 10)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (43, N'Compare()', 1, 10)
INSERT [dbo].[AnswerOptions] ([IdAnswerOptions], [Possiblenswer], [CorrectAnswer], [QuestionsId]) VALUES (44, N'Compare To()', 0, 10)
SET IDENTITY_INSERT [dbo].[AnswerOptions] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'30c8c75e-2947-49c3-a3a3-469576482a66', N'Admin', N'ADMIN', N'85ab7f3a-4053-436e-a5b6-02ee1f114986')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6c88c5f3-1aaa-42de-947a-986abeb32887', N'UserLvl1', N'USERLVL1', N'a0b78d42-e4dc-4694-bfcd-85f4def76c26')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'80c40521-5497-4dc8-a475-f5e37e337a10', N'UserLvl3', N'USERLVL3', N'8b2d2e99-488d-4b78-9188-793194ded18d')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd47fa534-969a-4fc8-b7b5-2acc1df215b9', N'UserLvl2', N'USERLVL2', N'db770d46-51d9-4453-80db-2a4e72203ebc')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26f79a64-b97b-4546-8212-cd510ad83d3a', N'30c8c75e-2947-49c3-a3a3-469576482a66')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'874f8a4c-0cee-402e-80f2-48cc4446fc5b', N'30c8c75e-2947-49c3-a3a3-469576482a66')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'198a8c87-c57a-484c-b61f-040341b033eb', N'6c88c5f3-1aaa-42de-947a-986abeb32887')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'34ce6146-961a-4b09-9a7e-64c2b83cc65c', N'80c40521-5497-4dc8-a475-f5e37e337a10')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab3231aa-7098-42ba-b2d0-58ceb726fc80', N'd47fa534-969a-4fc8-b7b5-2acc1df215b9')
GO
INSERT [dbo].[AspNetUsers] ([Id], [PasswordHash], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'198a8c87-c57a-484c-b61f-040341b033eb', N'AQAAAAEAACcQAAAAEFFKFOkIbAZtreFGAvJlXJK3i+lVIZs2rL791go6Jl+uMiE759TKe+41dJxapRxa+w==', N'demoUserLvl1@gmail.com', N'DEMOUSERLVL1@GMAIL.COM', N'demoUserLvl1@gmail.com', N'DEMOUSERLVL1@GMAIL.COM', 0, N'ACZ3R5UZBJR77B5MJ25KCV5FGEZD7L66', N'cccbccee-59cb-476e-91b9-fdaf422b0dc2', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [PasswordHash], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'26f79a64-b97b-4546-8212-cd510ad83d3a', N'AQAAAAEAACcQAAAAECSx6R8H+Eva2bY81Gkddj2lGKcHE2HDs9hrbpTWrLBNptQFKrmx6NpbesiTbwj10A==', N'vetalvasilenko@gmail.com', N'VETALVASILENKO@GMAIL.COM', N'vetalvasilenko@gmail.com', N'VETALVASILENKO@GMAIL.COM', 0, N'OR725MTLSIUEPATMJD3WHTYXHNSKAXK7', N'0f8c9554-cd31-463b-bf20-9efed8248223', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [PasswordHash], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'34ce6146-961a-4b09-9a7e-64c2b83cc65c', N'AQAAAAEAACcQAAAAEKYdqSK1UWTnnFfMofi1j2W+ElN/SMhCltl+uye6WnSfjaU2PZQWxRojuNc9H3gEIw==', N'demoUserLvl3@gmail.com', N'DEMOUSERLVL3@GMAIL.COM', N'demoUserLvl3@gmail.com', N'DEMOUSERLVL3@GMAIL.COM', 0, N'4DZGOBAIWYXX5FF323TAZ4MKVWOQP6FT', N'4bfad79a-36dc-4a7c-8d22-1850379e6e81', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [PasswordHash], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'874f8a4c-0cee-402e-80f2-48cc4446fc5b', N'AQAAAAEAACcQAAAAEDGy+S2NvMvGp6qS18v5+yVeRHrv28SLJtzCV2NiSGjHRhbAq4+GUmz/wNvgpN2UIQ==', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'EM2JT5W77ZFC7BOANYBWDRPOJJJTX53P', N'447ddf90-d8f5-44a4-bed7-00fb708628a1', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [PasswordHash], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ab3231aa-7098-42ba-b2d0-58ceb726fc80', N'AQAAAAEAACcQAAAAEE3EkT7uaMHWptL+KoV8t8w7Ya6SiBnSZY/Z8K7GioPodwDiHGw493HdYkCGWLTLwg==', N'demoUserLvl2@gmail.com', N'DEMOUSERLVL2@GMAIL.COM', N'demoUserLvl2@gmail.com', N'DEMOUSERLVL2@GMAIL.COM', 0, N'EIT4YDZAYB7GZM6WRKV2PAJPHAXCTO2P', N'c8c906d3-5ab0-403b-b699-47b4513a19ea', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[ListTests] ON 

INSERT [dbo].[ListTests] ([IdListTest], [Name], [Note], [Img], [StatusPublic]) VALUES (1, N'Початковий рівень C#', N'Тут ви можете пройти тест із рівнем «Початковий» на тему C#. На тест виділяється невеликий проміжок часу, а також після закінчення тесту ви зможете переглянути результати та ознайомитись з вірними та невірними відповідями.', N'/img/test-img/lvl1.png', 1)
INSERT [dbo].[ListTests] ([IdListTest], [Name], [Note], [Img], [StatusPublic]) VALUES (2, N'Середній рівень С#', N'Тут ви можете пройти тест із рівнем «Середній» на тему C#. На тест виділяється невеликий проміжок часу, а також після закінчення тесту ви зможете переглянути результати та ознайомитись з вірними та невірними відповідями.', N'/img/test-img/lvl2.png', 1)
INSERT [dbo].[ListTests] ([IdListTest], [Name], [Note], [Img], [StatusPublic]) VALUES (3, N'Високий рівень C#', N'Тут ви можете пройти тест із рівнем «Складний» на тему C#. На тест виділяється невеликий проміжок часу, а також після закінчення тесту ви зможете переглянути результати та ознайомитись з вірними та невірними відповідями.', N'/img/test-img/lvl3.png', 1)
SET IDENTITY_INSERT [dbo].[ListTests] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (1, 1, N'Які цикли існують у мові C#?')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (2, 1, N'Що робить try-catch?')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (3, 1, N'Де вірно відбувається виведення даних в консоль?')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (4, 2, N'Який тип змінної використовується у коді: int a = 5')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (5, 2, N'Як зробити інкрементацію числа')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (6, 2, N'Позначення оператора «АБО»')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (7, 3, N'Яка з наступних властивостей класу Array C# перевіряє, чи має масив фіксований розмір?')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (8, 3, N'Який з наступних операторів повертає тип класу C#?')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (9, 3, N'Розташуйте такі типи даних у порядку зростання sbyte, short, long, int.')
INSERT [dbo].[Questions] ([IdQuestions], [TestsId], [QuestionText]) VALUES (10, 3, N'Який метод String використовується для порівняння двох рядків?')
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'874f8a4c-0cee-402e-80f2-48cc4446fc5b', 1)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'874f8a4c-0cee-402e-80f2-48cc4446fc5b', 2)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'874f8a4c-0cee-402e-80f2-48cc4446fc5b', 3)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'198a8c87-c57a-484c-b61f-040341b033eb', 1)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'ab3231aa-7098-42ba-b2d0-58ceb726fc80', 1)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'ab3231aa-7098-42ba-b2d0-58ceb726fc80', 2)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'34ce6146-961a-4b09-9a7e-64c2b83cc65c', 1)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'34ce6146-961a-4b09-9a7e-64c2b83cc65c', 2)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'34ce6146-961a-4b09-9a7e-64c2b83cc65c', 3)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'26f79a64-b97b-4546-8212-cd510ad83d3a', 1)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'26f79a64-b97b-4546-8212-cd510ad83d3a', 2)
INSERT [dbo].[UserTests] ([UserId], [TestId]) VALUES (N'26f79a64-b97b-4546-8212-cd510ad83d3a', 3)
GO
ALTER TABLE [dbo].[AnswerOptions] ADD  DEFAULT ((0)) FOR [QuestionsId]
GO
ALTER TABLE [dbo].[AnswerOptions]  WITH CHECK ADD  CONSTRAINT [FK_AnswerOptions_Questions_QuestionsId] FOREIGN KEY([QuestionsId])
REFERENCES [dbo].[Questions] ([IdQuestions])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnswerOptions] CHECK CONSTRAINT [FK_AnswerOptions_Questions_QuestionsId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_ListTests_TestsId] FOREIGN KEY([TestsId])
REFERENCES [dbo].[ListTests] ([IdListTest])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_ListTests_TestsId]
GO
