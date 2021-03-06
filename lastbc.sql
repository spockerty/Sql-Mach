USE [dbhsgrading]
GO
/****** Object:  Table [dbo].[tblTeachers]    Script Date: 03/24/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[tblTeachers](
	[Teacher_id] [int] NOT NULL,
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Teacher_Name] [varchar](50) NULL,
	[Subject] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170021, N'Cecille', N'Mandayo', N'Mrs. Cecille Mandayo', N'Filipino I')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170021, N'Cecille', N'Mandayo', N'Mrs. Cecille Mandayo', N'Filipino II')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170021, N'Cecille', N'Mandayo', N'Mrs. Cecille Mandayo', N'Filipino III')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170021, N'Cecille', N'Mandayo', N'Mrs. Cecille Mandayo', N'Filipino IV')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170024, N'Marian', N'Javier', N'Mrs. Marian Javier', N'Basic Algebra')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170024, N'Marian', N'Javier', N'Mrs. Marian Javier', N'Advance Algebra')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170024, N'Marian', N'Javier', N'Mrs. Marian Javier', N'Geometry')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170024, N'Marian', N'Javier', N'Mrs. Marian Javier', N'Trigonometry')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170055, N'Aryan', N'Magnaye', N'Mrs. Aryan Magnaye', N'Basic Science')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170055, N'Aryan', N'Magnaye', N'Mrs. Aryan Magnaye', N'Biology')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170055, N'Aryan', N'Magnaye', N'Mrs. Aryan Magnaye', N'Chemistry')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170055, N'Aryan', N'Magnaye', N'Mrs. Aryan Magnaye', N'Physics')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170035, N'Emma', N'Masajo', N'Mrs. Emma Masajo', N'MAPEH I')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170035, N'Emma', N'Masajo', N'Mrs. Emma Masajo', N'MAPEH II')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170035, N'Emma', N'Masajo', N'Mrs. Emma Masajo', N'MAPEH III')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170035, N'Emma', N'Masajo', N'Mrs. Emma Masajo', N'MAPEH IV')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170074, N'Irma', N'Dimaculangan', N'Mrs. Irma Dimaculangan', N'English I')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170074, N'Irma', N'Dimaculangan', N'Mrs. Irma Dimaculangan', N'English II')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170074, N'Irma', N'Dimaculangan', N'Mrs. Irma Dimaculangan', N'English III')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170074, N'Irma', N'Dimaculangan', N'Mrs. Irma Dimaculangan', N'English IV')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170010, N'Maryjane', N'Miranda', N'Mrs. Maryjane Miranda', N'Computer Tech. I')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170010, N'Maryjane', N'Miranda', N'Mrs. Maryjane Miranda', N'Computer Tech. II')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170010, N'Maryjane', N'Miranda', N'Mrs. Maryjane Miranda', N'Computer Tech. III')
INSERT [dbo].[tblTeachers] ([Teacher_id], [User_Name], [Password], [Teacher_Name], [Subject]) VALUES (20170010, N'Maryjane', N'Miranda', N'Mrs. Maryjane Miranda', N'Computer Tech. IV')
/****** Object:  Table [dbo].[tblSubjects]    Script Date: 03/24/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[tblSubjects](
	[Subject_id] [int] NULL,
	[Subject_Tittle] [varchar](50) NULL,
	[Year] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170008, N'Economics', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170027, N'MAPEH IV', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170008, N'Basic Algebra', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170006, N'MAPEH I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170025, N'Basic Science', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170000, N'English I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170029, N'Filipino I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170097, N'Computer Tech. I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170065, N'Social Studies I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170083, N'T.L.E I', N'Grade 7')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170090, N'Advance Algebra', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170088, N'Biology', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170018, N'Filipino II', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170005, N'English II', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170046, N'MAPEH II', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170092, N'T.L.E II', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170065, N'Computer Tech. II', N'Grade 8')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170004, N'Geometry', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170093, N'Chemistry', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170063, N'Computer Tech III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170014, N'English III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170086, N'Filipino III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170005, N'Social Studies III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170023, N'MAPEH III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170005, N'Physics', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170013, N'Trigonometry', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170027, N'Filipino IV', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170035, N'English IV', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170089, N'Computer Tech. IV', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170056, N'Social Studies IV', N'Grade 10')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170038, N'T.L.E III', N'Grade 9')
INSERT [dbo].[tblSubjects] ([Subject_id], [Subject_Tittle], [Year]) VALUES (20170017, N'Social Studies II', N'Grade 8')
/****** Object:  Table [dbo].[tblStudent_Detail]    Script Date: 03/24/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStudent_Detail](
	[Student_id] [varchar](50) NULL,
	[Student_LastName] [varchar](50) NULL,
	[Student_FirstName] [varchar](50) NULL,
	[Student_MiddleName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Adress] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Section] [varchar](50) NULL,
	[Parent_Name] [varchar](50) NULL,
	[Parent_ContactNo] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblStudent_Detail] ([Student_id], [Student_LastName], [Student_FirstName], [Student_MiddleName], [Gender], [Adress], [Year], [Section], [Parent_Name], [Parent_ContactNo]) VALUES (N'2017-C007', N'Von', N'kak', N'mmm', N'M', N'as', N'Grade 7', N'St. Pedro Calungsod', N'gagagagg', N'0967')
INSERT [dbo].[tblStudent_Detail] ([Student_id], [Student_LastName], [Student_FirstName], [Student_MiddleName], [Gender], [Adress], [Year], [Section], [Parent_Name], [Parent_ContactNo]) VALUES (N'2017-C090', N'vb', N'vb', N'vb', N'F', N'vb', N'Grade 7', N'St. Pedro Calungsod', N'vb', N'34')
/****** Object:  Table [dbo].[tblLoading]    Script Date: 03/24/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoading](
	[teacher_id] [int] NULL,
	[Subject_id] [int] NULL,
	[Student_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGrade]    Script Date: 03/24/2017 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGrade](
	[Student_Id] [varchar](50) NULL,
	[Teacher_Id] [varchar](50) NULL,
	[FirstGrading] [varchar](50) NULL,
	[SecondGrading] [varchar](50) NULL,
	[ThirdGrading] [varchar](50) NULL,
	[FourthGrading] [varchar](50) NULL,
	[FinalGrade] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAdmin]    Script Date: 03/24/2017 00:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAdmin](
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblAdmin] ([user_name], [password]) VALUES (N'admin', N'admin')
/****** Object:  View [dbo].[Student_Subject]    Script Date: 03/24/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[Student_Subject] as
select tblStudent_Detail.Student_id,tblStudent_Detail.Student_LastName,tblStudent_Detail.Student_FirstName,tblStudent_Detail.Student_MiddleName,tblSubjects.Year,tblStudent_Detail.Section,tblSubjects.Subject_Tittle
from tblSubjects
inner join tblStudent_Detail on tblSubjects.Year = tblStudent_Detail.Year
GO
/****** Object:  View [dbo].[StudSub_Grade]    Script Date: 03/24/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[StudSub_Grade] as
select a.Student_Id,(b.Student_FirstName +' '+ b.Student_LastName+' '+b.Student_MiddleName) as 'StudentName'
,b.Subject_Tittle as 'Subject' ,b.Year,b.section,a.First_Grading as 'FirstGrading',a.second_Grading as 'SecondGrading',a.Third_Grading as 'ThirdGrading'
,a.Fourth_Grading as 'FourthGrading'
from tblGrade as a
inner join Student_Subject as b
on a.Student_Id = b.Student_id
GO
/****** Object:  View [dbo].[gradesubgrad_tech]    Script Date: 03/24/2017 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[gradesubgrad_tech] as 
select b.Student_Id,b.StudentName,b.Subject,b.year,b.section,a.Teacher_Name as 'TeacherName',b.FirstGrading,b.SecondGrading,
b.ThirdGrading,b.FourthGrading
from tblTeachers as a
inner join StudSub_Grade as b
on a.Subject = b.Subject
GO
