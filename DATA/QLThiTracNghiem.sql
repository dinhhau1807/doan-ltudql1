/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server 2014
 Source Server Type    : SQL Server
 Source Server Version : 12002000
 Source Host           : HMASTER\MSSQLSERVER2014:1433
 Source Catalog        : QLThiTracNghiem
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 12002000
 File Encoding         : 65001

 Date: 03/12/2019 22:08:37
*/


-- ----------------------------
-- Table structure for Answer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Answer]') AND type IN ('U'))
	DROP TABLE [dbo].[Answer]
GO

CREATE TABLE [dbo].[Answer] (
  [AnswerId] int  NOT NULL,
  [QuestionId] int  NOT NULL,
  [Content] text COLLATE Vietnamese_CI_AS  NULL,
  [IsCorrect] bit  NULL
)
GO

ALTER TABLE [dbo].[Answer] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for AnswerDistribute
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AnswerDistribute]') AND type IN ('U'))
	DROP TABLE [dbo].[AnswerDistribute]
GO

CREATE TABLE [dbo].[AnswerDistribute] (
  [AnswerDistributeId] int  NOT NULL,
  [QuestionDistributeId] int  NOT NULL,
  [Content] text COLLATE Vietnamese_CI_AS  NULL,
  [IsCorrect] varchar(255) COLLATE Vietnamese_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AnswerDistribute] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Classroom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Classroom]') AND type IN ('U'))
	DROP TABLE [dbo].[Classroom]
GO

CREATE TABLE [dbo].[Classroom] (
  [ClassroomId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [GradeId] int  NOT NULL,
  [ClassName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL,
  [Year] int  NULL
)
GO

ALTER TABLE [dbo].[Classroom] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Exam
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type IN ('U'))
	DROP TABLE [dbo].[Exam]
GO

CREATE TABLE [dbo].[Exam] (
  [ExamId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [ExamName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL,
  [IsPacticeExam] bit  NULL
)
GO

ALTER TABLE [dbo].[Exam] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ExamCode
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamCode]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamCode]
GO

CREATE TABLE [dbo].[ExamCode] (
  [ExamCodeId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [NumberOfQuestions] int  NULL,
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [GradeId] int  NULL,
  [IsPracticeExam] bit  NULL
)
GO

ALTER TABLE [dbo].[ExamCode] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'Phân biệt đề thi thử',
'SCHEMA', N'dbo',
'TABLE', N'ExamCode',
'COLUMN', N'IsPracticeExam'
GO


-- ----------------------------
-- Table structure for ExamCode_Question
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamCode_Question]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamCode_Question]
GO

CREATE TABLE [dbo].[ExamCode_Question] (
  [ExamCodeId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [QuestionId] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ExamCode_Question] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ExamDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamDetail]
GO

CREATE TABLE [dbo].[ExamDetail] (
  [ExamDetailId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [ExamId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [ExamCodeId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [StartTime] datetime  NULL,
  [Duration] int  NULL,
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [GradeId] int  NULL
)
GO

ALTER TABLE [dbo].[ExamDetail] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'minute',
'SCHEMA', N'dbo',
'TABLE', N'ExamDetail',
'COLUMN', N'Duration'
GO


-- ----------------------------
-- Table structure for ExamRegister
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamRegister]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamRegister]
GO

CREATE TABLE [dbo].[ExamRegister] (
  [StudentId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [ExamId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ExamRegister] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ExamResult
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamResult]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamResult]
GO

CREATE TABLE [dbo].[ExamResult] (
  [ExamDetailId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [StudentId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [NumberOfQuestionsAnswered] int  NULL,
  [NumberOfCorrectAnswers] int  NULL,
  [Mark] float(53)  NULL
)
GO

ALTER TABLE [dbo].[ExamResult] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ExamTake
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamTake]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamTake]
GO

CREATE TABLE [dbo].[ExamTake] (
  [ExamDetailId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [StudentId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [StartTime] datetime  NULL,
  [EndTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[ExamTake] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Grade
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Grade]') AND type IN ('U'))
	DROP TABLE [dbo].[Grade]
GO

CREATE TABLE [dbo].[Grade] (
  [GradeId] int  NOT NULL,
  [GradeName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Grade] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Question
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type IN ('U'))
	DROP TABLE [dbo].[Question]
GO

CREATE TABLE [dbo].[Question] (
  [QuestionId] int  IDENTITY(1,1) NOT NULL,
  [Content] text COLLATE Vietnamese_CI_AS  NULL,
  [Hint] text COLLATE Vietnamese_CI_AS  NULL,
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [GradeId] int  NULL,
  [DifficultLevel] int  NULL,
  [IsMultiSelect] bit  NULL
)
GO

ALTER TABLE [dbo].[Question] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'Độ khó',
'SCHEMA', N'dbo',
'TABLE', N'Question',
'COLUMN', N'DifficultLevel'
GO


-- ----------------------------
-- Table structure for QuestionDistribute
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionDistribute]') AND type IN ('U'))
	DROP TABLE [dbo].[QuestionDistribute]
GO

CREATE TABLE [dbo].[QuestionDistribute] (
  [QuestionDistributeId] int  NOT NULL,
  [StudentId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [Content] text COLLATE Vietnamese_CI_AS  NULL,
  [Hint] text COLLATE Vietnamese_CI_AS  NULL,
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NULL,
  [GradeId] int  NULL,
  [DifficultLevel] int  NULL,
  [IsMultiSelect] bit  NULL,
  [IsApproved] bit  NULL
)
GO

ALTER TABLE [dbo].[QuestionDistribute] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'Kiểm tra tình trạng được duyệt',
'SCHEMA', N'dbo',
'TABLE', N'QuestionDistribute',
'COLUMN', N'IsApproved'
GO


-- ----------------------------
-- Table structure for RoleType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleType]') AND type IN ('U'))
	DROP TABLE [dbo].[RoleType]
GO

CREATE TABLE [dbo].[RoleType] (
  [RoleTypeId] int  NOT NULL,
  [RoleName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[RoleType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type IN ('U'))
	DROP TABLE [dbo].[Student]
GO

CREATE TABLE [dbo].[Student] (
  [StudentId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [Username] varchar(50) COLLATE Vietnamese_CI_AS  NOT NULL,
  [ClassroomId] varchar(10) COLLATE Vietnamese_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Student] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Subject
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type IN ('U'))
	DROP TABLE [dbo].[Subject]
GO

CREATE TABLE [dbo].[Subject] (
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [GradeId] int  NOT NULL,
  [SubjectName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Subject] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Teach
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Teach]') AND type IN ('U'))
	DROP TABLE [dbo].[Teach]
GO

CREATE TABLE [dbo].[Teach] (
  [TeacherId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [ClassroomId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [SubjectId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [GradeId] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Teach] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Teacher
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type IN ('U'))
	DROP TABLE [dbo].[Teacher]
GO

CREATE TABLE [dbo].[Teacher] (
  [TeacherId] varchar(10) COLLATE Vietnamese_CI_AS  NOT NULL,
  [Username] varchar(50) COLLATE Vietnamese_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Teacher] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type IN ('U'))
	DROP TABLE [dbo].[User]
GO

CREATE TABLE [dbo].[User] (
  [Username] varchar(50) COLLATE Vietnamese_CI_AS  NOT NULL,
  [Password] nvarchar(50) COLLATE Vietnamese_CI_AS  NOT NULL,
  [FirstName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL,
  [LastName] nvarchar(50) COLLATE Vietnamese_CI_AS  NULL,
  [Dob] datetime  NULL,
  [Phone] varchar(15) COLLATE Vietnamese_CI_AS  NULL,
  [CreatedDate] datetime DEFAULT (getdate()) NULL,
  [Status] bit DEFAULT ((1)) NULL,
  [LastLoginDate] datetime DEFAULT (getdate()) NULL,
  [RoleTypeId] int DEFAULT ((1)) NULL
)
GO

ALTER TABLE [dbo].[User] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'0 = admin, 1 = student, 2 = teacher',
'SCHEMA', N'dbo',
'TABLE', N'User',
'COLUMN', N'RoleTypeId'
GO


-- ----------------------------
-- Primary Key structure for table Answer
-- ----------------------------
ALTER TABLE [dbo].[Answer] ADD CONSTRAINT [PK__Answer__D482500484526F93] PRIMARY KEY CLUSTERED ([AnswerId], [QuestionId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AnswerDistribute
-- ----------------------------
ALTER TABLE [dbo].[AnswerDistribute] ADD CONSTRAINT [PK__AnswerDi__FE8769D9AE0AC57F] PRIMARY KEY CLUSTERED ([AnswerDistributeId], [QuestionDistributeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Classroom
-- ----------------------------
ALTER TABLE [dbo].[Classroom] ADD CONSTRAINT [PK__Classroo__11618EAA905DF4A0] PRIMARY KEY CLUSTERED ([ClassroomId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Exam
-- ----------------------------
ALTER TABLE [dbo].[Exam] ADD CONSTRAINT [PK__Exams__297521C766BCE530] PRIMARY KEY CLUSTERED ([ExamId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamCode
-- ----------------------------
ALTER TABLE [dbo].[ExamCode] ADD CONSTRAINT [PK__ExamCode__C23C701A6F3C9A98] PRIMARY KEY CLUSTERED ([ExamCodeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamCode_Question
-- ----------------------------
ALTER TABLE [dbo].[ExamCode_Question] ADD CONSTRAINT [PK__ExamCode__12E076E02E1E9C4E] PRIMARY KEY CLUSTERED ([ExamCodeId], [QuestionId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamDetail
-- ----------------------------
ALTER TABLE [dbo].[ExamDetail] ADD CONSTRAINT [PK__ExamDeta__D30D63A5D444D2DC] PRIMARY KEY CLUSTERED ([ExamDetailId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamRegister
-- ----------------------------
ALTER TABLE [dbo].[ExamRegister] ADD CONSTRAINT [PK__ExamRegi__50527985F6132A72] PRIMARY KEY CLUSTERED ([StudentId], [ExamId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamResult
-- ----------------------------
ALTER TABLE [dbo].[ExamResult] ADD CONSTRAINT [PK__ExamResu__D30D63A5AD8C1D71] PRIMARY KEY CLUSTERED ([ExamDetailId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamTake
-- ----------------------------
ALTER TABLE [dbo].[ExamTake] ADD CONSTRAINT [PK__ExamJoin__D30D63A598CCAECD] PRIMARY KEY CLUSTERED ([ExamDetailId], [StudentId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Grade
-- ----------------------------
ALTER TABLE [dbo].[Grade] ADD CONSTRAINT [PK__Grades__54F87A57317443B3] PRIMARY KEY CLUSTERED ([GradeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Question
-- ----------------------------
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [PK__Question__0DC06FACC7235C0E] PRIMARY KEY CLUSTERED ([QuestionId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table QuestionDistribute
-- ----------------------------
ALTER TABLE [dbo].[QuestionDistribute] ADD CONSTRAINT [PK__Question__282A3E7A6B8CDAA9] PRIMARY KEY CLUSTERED ([QuestionDistributeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table RoleType
-- ----------------------------
ALTER TABLE [dbo].[RoleType] ADD CONSTRAINT [PK__RoleType__3E697319A82B6833] PRIMARY KEY CLUSTERED ([RoleTypeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [u_Students_Username] UNIQUE NONCLUSTERED ([Username] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [PK__Students__32C52B9985113C14] PRIMARY KEY CLUSTERED ([StudentId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Subject
-- ----------------------------
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [PK__Subjects__AC1BA3A83AC3C4A6] PRIMARY KEY CLUSTERED ([SubjectId], [GradeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Teach
-- ----------------------------
ALTER TABLE [dbo].[Teach] ADD CONSTRAINT [PK__Teaches__F5485A2D7C44CB8F] PRIMARY KEY CLUSTERED ([TeacherId], [ClassroomId], [SubjectId], [GradeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [u_Teachers_Username] UNIQUE NONCLUSTERED ([Username] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [PK__Teachers__EDF259646D4F415D] PRIMARY KEY CLUSTERED ([TeacherId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK__Users__536C85E52E4D282A] PRIMARY KEY CLUSTERED ([Username])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Answer
-- ----------------------------
ALTER TABLE [dbo].[Answer] ADD CONSTRAINT [fk_Answer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([QuestionId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table AnswerDistribute
-- ----------------------------
ALTER TABLE [dbo].[AnswerDistribute] ADD CONSTRAINT [fk_AnswerDistribute_QuestionDistribute] FOREIGN KEY ([QuestionDistributeId]) REFERENCES [dbo].[QuestionDistribute] ([QuestionDistributeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Classroom
-- ----------------------------
ALTER TABLE [dbo].[Classroom] ADD CONSTRAINT [fk_Classes_Grades] FOREIGN KEY ([GradeId]) REFERENCES [dbo].[Grade] ([GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamCode
-- ----------------------------
ALTER TABLE [dbo].[ExamCode] ADD CONSTRAINT [fk_ExamCode_Subject] FOREIGN KEY ([SubjectId], [GradeId]) REFERENCES [dbo].[Subject] ([SubjectId], [GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamCode_Question
-- ----------------------------
ALTER TABLE [dbo].[ExamCode_Question] ADD CONSTRAINT [fk_ExamCodeQuestion_ExamCode] FOREIGN KEY ([ExamCodeId]) REFERENCES [dbo].[ExamCode] ([ExamCodeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamCode_Question] ADD CONSTRAINT [fk_ExamCodeQuestion_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([QuestionId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamDetail
-- ----------------------------
ALTER TABLE [dbo].[ExamDetail] ADD CONSTRAINT [fk_ExamDetails_Exams] FOREIGN KEY ([ExamId]) REFERENCES [dbo].[Exam] ([ExamId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamDetail] ADD CONSTRAINT [fk_ExamDetails_ExamCode] FOREIGN KEY ([ExamCodeId]) REFERENCES [dbo].[ExamCode] ([ExamCodeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamDetail] ADD CONSTRAINT [fk_ExamDetail_Subject] FOREIGN KEY ([SubjectId], [GradeId]) REFERENCES [dbo].[Subject] ([SubjectId], [GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamRegister
-- ----------------------------
ALTER TABLE [dbo].[ExamRegister] ADD CONSTRAINT [fk_ExamRegisters_Students] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamRegister] ADD CONSTRAINT [fk_ExamRegisters_Exams] FOREIGN KEY ([ExamId]) REFERENCES [dbo].[Exam] ([ExamId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamResult
-- ----------------------------
ALTER TABLE [dbo].[ExamResult] ADD CONSTRAINT [fk_ExamResult_ExamDetail] FOREIGN KEY ([ExamDetailId]) REFERENCES [dbo].[ExamDetail] ([ExamDetailId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamResult] ADD CONSTRAINT [fk_ExamResult_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamTake
-- ----------------------------
ALTER TABLE [dbo].[ExamTake] ADD CONSTRAINT [fk_ExamJoins_ExamDetails] FOREIGN KEY ([ExamDetailId]) REFERENCES [dbo].[ExamDetail] ([ExamDetailId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamTake] ADD CONSTRAINT [fk_ExamJoins_Students] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Question
-- ----------------------------
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [fk_Question_Subject] FOREIGN KEY ([SubjectId], [GradeId]) REFERENCES [dbo].[Subject] ([SubjectId], [GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table QuestionDistribute
-- ----------------------------
ALTER TABLE [dbo].[QuestionDistribute] ADD CONSTRAINT [fk_QuestionDistribute_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[QuestionDistribute] ADD CONSTRAINT [fk_QuestionDistribute_Subject] FOREIGN KEY ([SubjectId], [GradeId]) REFERENCES [dbo].[Subject] ([SubjectId], [GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [fk_Students_Users] FOREIGN KEY ([Username]) REFERENCES [dbo].[User] ([Username]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Student] ADD CONSTRAINT [fk_Students_Classrooms] FOREIGN KEY ([ClassroomId]) REFERENCES [dbo].[Classroom] ([ClassroomId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Subject
-- ----------------------------
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [fk_Subject_Grade] FOREIGN KEY ([GradeId]) REFERENCES [dbo].[Grade] ([GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Teach
-- ----------------------------
ALTER TABLE [dbo].[Teach] ADD CONSTRAINT [fk_Teach_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([TeacherId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Teach] ADD CONSTRAINT [fk_Teach_Classroom] FOREIGN KEY ([ClassroomId]) REFERENCES [dbo].[Classroom] ([ClassroomId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Teach] ADD CONSTRAINT [fk_Teach_Subject-Subject] FOREIGN KEY ([SubjectId], [GradeId]) REFERENCES [dbo].[Subject] ([SubjectId], [GradeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [fk_Teachers_Users] FOREIGN KEY ([Username]) REFERENCES [dbo].[User] ([Username]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [fk_User_RoleType] FOREIGN KEY ([RoleTypeId]) REFERENCES [dbo].[RoleType] ([RoleTypeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

