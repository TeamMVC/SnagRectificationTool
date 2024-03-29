USE [SnagRactificationTool]
GO
/****** Object:  Table [dbo].[Snag_InitialDataCapture]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_InitialDataCapture](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RefId] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[AC_No] [varchar](50) NULL,
	[StartDate] [datetime] NULL,
	[AFHrs] [varchar](50) NULL,
	[AFVal] [int] NULL,
	[ENGHrs] [varchar](50) NULL,
	[ENGVal] [int] NULL,
	[BriefOfSnag] [varchar](200) NULL,
	[ENGOilLife] [varchar](200) NULL,
	[SpareOnEXTN] [varchar](100) NULL,
	[Date] [datetime] NULL,
	[DateOfCompletion] [datetime] NULL,
	[TimeForRepairHrs] [varchar](50) NULL,
	[MANPOWER_UTILISED] [int] NULL,
	[AIR_FRAME] [varchar](50) NULL,
	[ELECT] [varchar](50) NULL,
	[AEROENGINE] [varchar](50) NULL,
	[Status] [varchar](1) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_InitialDataCapture] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Rectification_Items]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Rectification_Items](
	[RectID] [int] IDENTITY(1,1) NOT NULL,
	[SubSytemID] [int] NULL,
	[RectificationItems] [varchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_Rectification_Items] PRIMARY KEY CLUSTERED 
(
	[RectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Rectification_Procedure]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Rectification_Procedure](
	[RectificationProcedureId] [int] IDENTITY(1,1) NOT NULL,
	[RectificationStepId] [int] NULL,
	[ProcedureTitle] [varchar](200) NULL,
	[ProcedureContent] [varchar](max) NULL,
	[ProcedureLinkPath] [varchar](200) NULL,
	[ProcedureLinkType] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_Rectification_Procedure] PRIMARY KEY CLUSTERED 
(
	[RectificationProcedureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_RectificationStepReferences]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_RectificationStepReferences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RectificationStepId] [int] NULL,
	[LinkPath] [varchar](200) NULL,
	[LinkType] [varchar](50) NULL,
	[RefMaterialTitle] [varchar](100) NULL,
	[RefMaterialContent] [varchar](max) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_RectificationStepReferences] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_RectificationSteps]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_RectificationSteps](
	[RectificationStepId] [int] IDENTITY(1,1) NOT NULL,
	[RectificationId] [int] NULL,
	[StepName] [varchar](50) NULL,
	[StepDetails] [varchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_RectificationSteps] PRIMARY KEY CLUSTERED 
(
	[RectificationStepId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Rectify_Subsystem]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Rectify_Subsystem](
	[SubsystemId] [int] IDENTITY(1,1) NOT NULL,
	[SystemID] [int] NULL,
	[SubsystemName] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_Ractify_Subsystem] PRIMARY KEY CLUSTERED 
(
	[SubsystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Rectify_System]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Rectify_System](
	[SystemID] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Snag_Ractify_System] PRIMARY KEY CLUSTERED 
(
	[SystemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Reference_Procedure]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Reference_Procedure](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RefId] [varchar](50) NULL,
	[RecId] [int] NULL,
	[SubSystemID] [int] NULL,
	[SystemId] [int] NULL,
	[SymptomId] [int] NULL,
	[StepsId] [nchar](10) NULL,
 CONSTRAINT [PK_Snag_Reference_Preocedure] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Snag_Symptoms]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snag_Symptoms](
	[SymptomId] [int] IDENTITY(1,1) NOT NULL,
	[RectificationId] [int] NULL,
	[Symptom] [varchar](100) NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
 CONSTRAINT [PK_Snag_Symptoms] PRIMARY KEY CLUSTERED 
(
	[SymptomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_InitialDataCapture] ON 

GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (1, N'SNG737013', N'222', N'frggg', CAST(N'2023-05-13 18:10:59.800' AS DateTime), N'Minute', 33, N'Minute', 22, N'4', N'rr', N'ee', CAST(N'2023-05-13 18:10:59.813' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-13 18:11:19.810' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (2, N'SNG897767', N'4', N'tgg', CAST(N'2023-05-13 18:16:13.987' AS DateTime), N'Minute', 34, N'Minute', 66, N'fggf', N'fgfg', N'fgfgf', CAST(N'2023-05-13 18:16:13.997' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-13 18:16:32.950' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (3, N'SNG301723', N'5', N'ggggg', CAST(N'2023-05-13 18:18:22.450' AS DateTime), N'Minute', 44, N'Hour', 44, N'fggg', N'ggg', N'gggg', CAST(N'2023-05-13 18:18:22.457' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-13 18:18:37.703' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (4, N'SNG640766', N'55', N'ttt', CAST(N'2023-05-13 18:19:17.680' AS DateTime), N'Minute', 44, N'Minute', 44, N'vvv', N'vv', N'vv', CAST(N'2023-05-13 18:19:17.690' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-13 18:19:32.403' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (5, N'SNG333963', N'55', N'55', CAST(N'2023-05-13 18:20:36.770' AS DateTime), N'Minute', 55, N'Minute', 55, N'55', N'55', N'55', CAST(N'2023-05-13 18:20:36.780' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-13 18:20:48.077' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (6, N'SNG892971', N'3', N'ABC40554', CAST(N'2023-05-13 14:30:14.000' AS DateTime), N'Hour', 24, N'Hour', 12, N'Snag testing', N'5', N'test data', CAST(N'2023-05-14 14:30:14.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-14 14:32:16.743' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (7, N'SNG495024', N'6', N'ABC8877', CAST(N'2023-05-14 14:37:46.553' AS DateTime), N'Hour', 12, N'Hour', 12, N'dummy', N'test sample', N'3', CAST(N'2023-05-14 14:37:46.563' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-14 14:38:49.803' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (8, N'SNG736915', N'6', N'abc966', CAST(N'2023-05-14 14:41:27.080' AS DateTime), N'Minute', 36, N'Minute', 50, N'test', N'test', N'55', CAST(N'2023-05-14 14:41:27.090' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-14 14:42:38.717' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_InitialDataCapture] ([ID], [RefId], [Unit], [AC_No], [StartDate], [AFHrs], [AFVal], [ENGHrs], [ENGVal], [BriefOfSnag], [ENGOilLife], [SpareOnEXTN], [Date], [DateOfCompletion], [TimeForRepairHrs], [MANPOWER_UTILISED], [AIR_FRAME], [ELECT], [AEROENGINE], [Status], [CreatedOn], [ModifiedOn]) VALUES (9, N'SNG671181', N'6', N'sbi333', CAST(N'2023-05-14 14:43:25.443' AS DateTime), N'Minute', 34, N'Minute', 66, N'dummy', N'dummy', N'dummy', CAST(N'2023-05-14 14:43:25.457' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-05-14 14:43:52.477' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_InitialDataCapture] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectification_Items] ON 

GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (1, 1, N'OIL SEAPAGE/ LEAKAGE FROM OIL FILTER, MOUNTING OR HOUSING', CAST(N'2023-05-13 09:41:00.127' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (2, 1, N'OIL SEAPAGE/ LEAKAGE FROM OIL RETURN PIPE', CAST(N'2023-05-13 09:41:00.127' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (3, 1, N'OIL SEAPAGE/ LEAKAGE FROM MAGNETIC CHIP DETECTOR (MCD) MOUNTING POINT', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (4, 1, N'OIL SEAPAGE/ LEAKAGE FROM CENTRE SECTION LUB RETURN LINE', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (5, 2, N'LOW OIL PRESSURE AT IDLING RPM/ MAX RP', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (6, 2, N'OIL TEMP HIGH', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (7, 2, N'OIL SEAPAGE/ LEAKAGE FOUND IN OIL COOLER', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (8, 3, N'FUEL IN LUB CCT', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (9, 3, N'SOOT DEPOSIT IN TAIL PIPE', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
INSERT [dbo].[Snag_Rectification_Items] ([RectID], [SubSytemID], [RectificationItems], [CreatedOn], [ModifiedOn]) VALUES (10, 3, N'OIL SEAPAGE/ LEAKAGE FROM FOUND BELOW ENG TACO-GENR', CAST(N'2023-05-13 09:41:00.130' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectification_Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectification_Procedure] ON 

GO
INSERT [dbo].[Snag_Rectification_Procedure] ([RectificationProcedureId], [RectificationStepId], [ProcedureTitle], [ProcedureContent], [ProcedureLinkPath], [ProcedureLinkType], [CreatedOn]) VALUES (2, 1, N'COMPONENT ILLUSTRATIONS
', N'', N'Picture1.png', N'Image/Pdf', NULL)
GO
INSERT [dbo].[Snag_Rectification_Procedure] ([RectificationProcedureId], [RectificationStepId], [ProcedureTitle], [ProcedureContent], [ProcedureLinkPath], [ProcedureLinkType], [CreatedOn]) VALUES (3, 1, N'COMPONENT ILLUSTRATIONS
', N'', N'Picture2.jpg', N'Image/Pdf', NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectification_Procedure] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_RectificationStepReferences] ON 

GO
INSERT [dbo].[Snag_RectificationStepReferences] ([Id], [RectificationStepId], [LinkPath], [LinkType], [RefMaterialTitle], [RefMaterialContent], [CreatedOn]) VALUES (1, 1, N'Picture4.png', N'png', N'REFERENCE ARTOUSTE III B & III B1
', N'CHAPTER 72 
73.10.3 PG 203
', NULL)
GO
INSERT [dbo].[Snag_RectificationStepReferences] ([Id], [RectificationStepId], [LinkPath], [LinkType], [RefMaterialTitle], [RefMaterialContent], [CreatedOn]) VALUES (2, 1, N'Picture5.png', N'png', N'REFERENCE ARTOUSTE III B & III B1
', N'CHAPTER 72 
73.10.3 PG 203
', NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_RectificationStepReferences] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_RectificationSteps] ON 

GO
INSERT [dbo].[Snag_RectificationSteps] ([RectificationStepId], [RectificationId], [StepName], [StepDetails], [CreatedOn], [ModifiedOn]) VALUES (1, 1, N'Step 1', N'CIRCUIT BREAKER (28L) OR SELECTOR SWITCH (29L) FAULTY', NULL, NULL)
GO
INSERT [dbo].[Snag_RectificationSteps] ([RectificationStepId], [RectificationId], [StepName], [StepDetails], [CreatedOn], [ModifiedOn]) VALUES (2, 1, N'Step 2', N'FUSE 16P BURNT OUT', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_RectificationSteps] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectify_Subsystem] ON 

GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (1, 1, N'FUEL SYS
', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (2, 1, N'LUBRICATION SYS
', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (3, 1, N'AIR SYS
', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (4, 1, N'BREATHING & VENTING SYS
', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (5, 2, N'DC POWER SUPPLY SYS', CAST(N'2023-05-14 12:38:53.087' AS DateTime), CAST(N'2023-05-14 12:38:53.087' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (6, 2, N'LIGHTING SYS', CAST(N'2023-05-14 12:39:02.657' AS DateTime), CAST(N'2023-05-14 12:39:02.657' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (7, 2, N'STARTING SYS', CAST(N'2023-05-14 12:39:05.963' AS DateTime), CAST(N'2023-05-14 12:39:05.963' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (8, 2, N'CARGO & RESCUE SYS', CAST(N'2023-05-14 12:39:08.843' AS DateTime), CAST(N'2023-05-14 12:39:08.843' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (9, 3, N'MAIN ROTOR SYS', CAST(N'2023-05-14 12:39:16.733' AS DateTime), CAST(N'2023-05-14 12:39:16.733' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (10, 3, N'TAIL ROTOR SYS', CAST(N'2023-05-14 12:39:20.320' AS DateTime), CAST(N'2023-05-14 12:39:20.320' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (11, 3, N'HYD SYS', CAST(N'2023-05-14 12:39:23.160' AS DateTime), CAST(N'2023-05-14 12:39:23.160' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (12, 3, N'TAIL TXN', CAST(N'2023-05-14 12:39:26.037' AS DateTime), CAST(N'2023-05-14 12:39:26.037' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (13, 3, N'STRUCTURE', CAST(N'2023-05-14 12:39:28.323' AS DateTime), CAST(N'2023-05-14 12:39:28.323' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (14, 3, N'LANDING GEAR SYS', CAST(N'2023-05-14 12:39:31.017' AS DateTime), CAST(N'2023-05-14 12:39:31.017' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (15, 3, N'GENERAL', CAST(N'2023-05-14 12:39:34.763' AS DateTime), CAST(N'2023-05-14 12:39:34.763' AS DateTime))
GO
INSERT [dbo].[Snag_Rectify_Subsystem] ([SubsystemId], [SystemID], [SubsystemName], [CreatedOn], [ModifiedOn]) VALUES (16, 3, N'VIBRATIONS', CAST(N'2023-05-14 12:39:39.323' AS DateTime), CAST(N'2023-05-14 12:39:39.323' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectify_Subsystem] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectify_System] ON 

GO
INSERT [dbo].[Snag_Rectify_System] ([SystemID], [SystemName], [CreatedOn], [ModifiedOn]) VALUES (1, N'AERO ENGINE', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_System] ([SystemID], [SystemName], [CreatedOn], [ModifiedOn]) VALUES (2, N'ELECT', NULL, NULL)
GO
INSERT [dbo].[Snag_Rectify_System] ([SystemID], [SystemName], [CreatedOn], [ModifiedOn]) VALUES (3, N'AIR FRAME', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_Rectify_System] OFF
GO
SET IDENTITY_INSERT [dbo].[Snag_Symptoms] ON 

GO
INSERT [dbo].[Snag_Symptoms] ([SymptomId], [RectificationId], [Symptom], [Created], [Modified]) VALUES (1, 1, N'FROTHING IN OIL TANK 
', NULL, NULL)
GO
INSERT [dbo].[Snag_Symptoms] ([SymptomId], [RectificationId], [Symptom], [Created], [Modified]) VALUES (2, 1, N'LOWERING OR INCR OF OIL TEMP
', NULL, NULL)
GO
INSERT [dbo].[Snag_Symptoms] ([SymptomId], [RectificationId], [Symptom], [Created], [Modified]) VALUES (3, 1, N'INCR IN OIL PR
', NULL, NULL)
GO
INSERT [dbo].[Snag_Symptoms] ([SymptomId], [RectificationId], [Symptom], [Created], [Modified]) VALUES (4, 1, N'CHANGE IN COLOUR OF OIL
', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Snag_Symptoms] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetAllSubsystem]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[GetAllSubsystem]
	
AS
BEGIN
	Select * from Snag_Rectify_Subsystem 
END


GO
/****** Object:  StoredProcedure [dbo].[GetRectificationItems]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetRectificationItems]
	@SubSystemID int
AS
BEGIN
	
	Select * from Snag_Rectification_Items sr
	inner join Snag_Rectify_Subsystem  ss on ss.SubsystemId=sr.SubSytemID
	 where SubSytemID=@SubSystemID
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationNameBy ID]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetRectificationNameBy ID]
	@RectificationId int
AS
BEGIN
	Select * from Snag_Rectification_Items where RectID=@RectificationId
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationNameByID]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetRectificationNameByID]
	@RectificationId int
AS
BEGIN
	Select * from Snag_Rectification_Items where RectID=@RectificationId
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationProcedure]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRectificationProcedure]
	@StepID int
AS
BEGIN
	Select * from Snag_Rectification_Procedure where RectificationStepId=@StepID
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationStepReferences]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRectificationStepReferences]
	@StepID int
AS
BEGIN
	Select * from Snag_RectificationStepReferences where RectificationStepId=@StepID
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationStepReferencesById]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetRectificationStepReferencesById]
	@StepID int,
	@StepReferences Int
AS
BEGIN
	Select * from Snag_RectificationStepReferences where Id=@StepReferences
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationSteps]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRectificationSteps]
	@RectificationId int
AS
BEGIN
	Select * from Snag_RectificationSteps where RectificationId=@RectificationId
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectificationStepsById]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetRectificationStepsById]
	@RectificationId int,
	@StepID int
AS
BEGIN
	Select * from Snag_RectificationSteps where RectificationId=@RectificationId and RectificationStepId=@StepID
END

GO
/****** Object:  StoredProcedure [dbo].[GetRectifySubSystem]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRectifySubSystem]@id int ASBEGINSelect * from Snag_Rectify_Subsystem where systemid=@idEND
GO
/****** Object:  StoredProcedure [dbo].[GetRectifySystem]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRectifySystem]@id int	ASBEGINSelect * from Snag_Rectify_System where SystemID=@idEND
GO
/****** Object:  StoredProcedure [dbo].[GetReference]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReference]  @referenceId varchar(50)  AS  BEGIN  Select * from Snag_InitialDataCapture where RefId=@referenceId  END
GO
/****** Object:  StoredProcedure [dbo].[getSubsystemByPrefixText]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getSubsystemByPrefixText]
    @prefixText varchar(100)
AS
BEGIN
	Select * from Snag_Rectify_Subsystem where SubsystemName like '%' + @prefixText +'%'
END

GO
/****** Object:  StoredProcedure [dbo].[GetSymptomData]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetSymptomData]
	@RectificationId Int
AS
BEGIN
	Select * from Snag_Symptoms where RectificationId=@RectificationId
END


GO
/****** Object:  StoredProcedure [dbo].[InsertInitialDataCapture]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertInitialDataCapture]
	@RefId varchar(50),
	@Unit varchar(50),
	@Ac_no varchar(50),
	@StartDt datetime,
	@AFHrs varchar(50),
	@AFVal Int,
	@ENGHrs varchar(50),
	@ENGVal Int,
	@BriefOfSnag  varchar(200),
	@ENGOilLife varchar(200),
	@SpareOnEXTN varchar(100),
	@date datetime
AS
BEGIN
	 INSERT INTO [dbo].[Snag_InitialDataCapture]
           ([RefId]
           ,[Unit]
           ,[AC_No]
           ,[StartDate]
           ,[AFHrs]
           ,[AFVal]
           ,[ENGHrs]
           ,[ENGVal]
           ,[BriefOfSnag]
           ,[ENGOilLife]
           ,[SpareOnEXTN]
           ,[Date]
           ,[CreatedOn]
           ,[ModifiedOn])
     VALUES
           (@RefId
           ,@Unit
           ,@Ac_no
           ,@StartDt
           ,@AFHrs
           ,@AFVal
           ,@ENGHrs
           ,@ENGVal
           ,@BriefOfSnag
           ,@ENGOilLife
           ,@SpareOnEXTN
		   ,@date
           ,GETDATE()
           ,null)

		   Select top 1 * from Snag_InitialDataCapture order by  CreatedOn desc
END

GO
/****** Object:  StoredProcedure [dbo].[InsertReference_Procedure]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertReference_Procedure]
    @RefId Varchar(50),
	@RecId Int,
	@SubSystemID Int,
	@SystemId int,
	@SymptomId Int,
	@StepsId Int
AS
BEGIN
INSERT INTO [dbo].[Snag_Reference_Procedure]
           ([RefId]
           ,[RecId]
           ,[SubSystemID]
           ,[SystemId]
           ,[SymptomId]
           ,[StepsId])
     VALUES
           (@RefId
           ,@RecId
           ,@SubSystemID
           ,@SystemId
           ,@SymptomId
           ,@StepsId)
END

GO
/****** Object:  StoredProcedure [dbo].[Update_DataCaptureForm]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Update_DataCaptureForm]
 @RefId varchar(50)
AS
BEGIN
Update  Snag_InitialDataCapture set ModifiedOn =GETDATE() where RefId=@RefId
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCompletionForm]    Script Date: 14-05-2023 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpdateCompletionForm]@DateOfCompletion datetime,@TimeForRepairHrs varchar(50),@MANPOWER_UTILISED int,@AIR_FRAME varchar(50),@ELECT varchar(50),@AEROENGINE varchar(50),@RefId varchar(50)AsBEGINupdate Snag_InitialDataCapture set DateOfCompletion=@DateOfCompletion ,TimeForRepairHrs= @TimeForRepairHrs ,Status= '1' ,MANPOWER_UTILISED=@MANPOWER_UTILISED ,AIR_FRAME= @AIR_FRAME ,ELECT=@ELECT ,AEROENGINE=@AEROENGINE where RefId=@RefIdEND
GO
