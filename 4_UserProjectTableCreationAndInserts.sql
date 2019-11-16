USE [Greenslate]
GO

/****** Object:  Table [dbo].[UserProject]    Script Date: 11/16/2019 4:45:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserProject](
	[UserId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[AssignedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_UserAndProject] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UserProject]  WITH CHECK ADD  CONSTRAINT [FK_UserProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO

ALTER TABLE [dbo].[UserProject] CHECK CONSTRAINT [FK_UserProject_Project]
GO

ALTER TABLE [dbo].[UserProject]  WITH CHECK ADD  CONSTRAINT [FK_UserProject_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[UserProject] CHECK CONSTRAINT [FK_UserProject_User]
GO



Insert into [dbo].[UserProject] values
( 1, 1, 1, '2019-11-15 13:03:24.027'),
( 1, 2, 1, '2019-11-16 09:38:35.810'),
( 1, 5, 1, '2019-10-16 16:32:44.163'),
( 1, 6, 0, '2019-10-16 16:33:58.467'),
( 1, 16, 0, '2019-10-16 16:35:35.173'),
( 2, 3, 0, '2019-11-16 09:38:35.817'),
( 2, 4, 1, '2019-11-19 12:21:47.010'),
( 2, 7, 1, '2019-11-09 16:37:11.570'),
( 2, 8, 1, '2019-11-09 16:38:04.150'),
( 2, 10, 0, '2019-09-16 16:38:28.260'),
( 4, 9, 0, '2019-10-31 16:39:24.970'),
( 4, 11, 0, '2019-11-07 16:39:54.907'),
( 4, 12, 1, '2019-11-06 16:40:15.710'),
( 4, 12, 0, '2019-11-23 16:40:32.740'),
( 4, 14, 1, '2019-11-09 16:43:19.407')