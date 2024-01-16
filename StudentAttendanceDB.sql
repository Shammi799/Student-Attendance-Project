CREATE DATABASE [StudentAttendanceDb]
 
CREATE TABLE [tblAttendance_location_Track](
	[sno] [bigint] NULL,
	[emp_id] [int] NULL,
	[emp_code] [varchar](200) NOT NULL,
	[Latitude] [varchar](200) NULL,
	[Longitude] [varchar](200) NULL,
	[ip_address] [varchar](200) NULL,
	[puchin_location] [varchar](max) NULL,
	[puchin_time] [varchar](100) NULL,
	[puchout_location] [varchar](max) NULL,
	[puchout_time] [nvarchar](50) NULL,
	[Attndate] [nvarchar](50) NULL,
	[DBsinkdate] [nvarchar](50) NULL,
	[status] [varchar](10) NULL,
	[DateCol] [nvarchar](100) NOT NULL,
	[ClickImage] [nvarchar](max) NULL,
	[punchoutimage] [nvarchar](max) NULL,
	[Multiple] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tblAttendance_location_Track] PRIMARY KEY CLUSTERED 
(
	[Multiple] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [TblStudent]    Script Date: 22-05-2023 23:26:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TblStudent](
	[Sno] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentID] [varchar](100) NULL,
	[StudentName] [varchar](100) NULL,
	[MobileNo] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[Location] [varchar](100) NULL,
	[IMEI] [varchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [varchar](100) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [tblAttendance_location_Track] ON 
GO
INSERT [tblAttendance_location_Track] ([sno], [emp_id], [emp_code], [Latitude], [Longitude], [ip_address], [puchin_location], [puchin_time], [puchout_location], [puchout_time], [Attndate], [DBsinkdate], [status], [DateCol], [ClickImage], [punchoutimage], [Multiple]) VALUES (1, 1, N'ST0001', N'', N'', N'::1', N'', N'2023/05/22 11:17:39 PM', N'', N'2023/05/22 11:20:44 PM', N'May 22 2023 11:17PM', N'May 22 2023 11:17PM', N'P', N'2023/05/22 11:17:40 PM', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [tblAttendance_location_Track] OFF
GO
SET IDENTITY_INSERT [TblStudent] ON 
GO
INSERT [TblStudent] ([Sno], [StudentID], [StudentName], [MobileNo], [Email], [Password], [Location], [IMEI], [CreatedOn], [CreatedBy]) VALUES (1, N'ST0001', N'Amit Kumar', N'9354589170', N'thakuramit948@gmail.com', N'12345', N'Delhi', N'', CAST(N'2023-05-22T22:52:19.433' AS DateTime), N'ST0001')
GO
SET IDENTITY_INSERT [TblStudent] OFF
GO
/****** Object:  StoredProcedure [check_out]    Script Date: 22-05-2023 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [check_out]    
(    
@puchout_time varchar(100),    
@emp_code varchar(100)    
)    
as    
begin    
select convert(varchar(10),puchout_time,103)as puchout_time,emp_code,  
substring(puchout_time,11,9) AS OutTime,    
substring(puchin_time,11,9) AS puchin_time,    
sno from tblAttendance_location_Track    
    
where emp_code=@emp_code and convert(varchar(10),puchout_time,103)=@puchout_time and puchout_time is not null    
    
    
end
GO
/****** Object:  StoredProcedure [tblAttendance_location_Track_duplicacy]    Script Date: 22-05-2023 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [tblAttendance_location_Track_duplicacy]    
(    
@date varchar(100),    
@emp_code varchar(100)    
)    
as    
begin    
select convert(varchar(10),puchin_time,103) from tblAttendance_location_Track    
where convert(varchar(10),puchin_time,103)=@date and emp_code=@emp_code    
end    
    
GO
/****** Object:  StoredProcedure [tblAttendance_userwise_Report]    Script Date: 22-05-2023 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [tblAttendance_userwise_Report]    
@emp_code varchar(100)    
AS    
BEGIN    
SELECT sno,emp_code,CONVERT(VARCHAR(10),DateCol, 103) AS Date,    
substring(puchin_time,11,12) AS inTime,substring(puchout_time,11,12) AS outTime    
    
from tblAttendance_location_Track     
    
where emp_code=@emp_code    
order by puchin_time desc    
    
END
GO
/****** Object:  StoredProcedure [update_puchout_select]    Script Date: 22-05-2023 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [update_puchout_select]  
  
(  
  
@date varchar(100),  
  
@emp_code varchar(100)  
  
)  
  
as  
  
begin  
  
select top(1)sno,emp_code from tblAttendance_location_Track  
  
where emp_code=@emp_code and convert(varchar(10),puchin_time,103)=@date  
  
order by sno desc  
  
end  
GO
/****** Object:  StoredProcedure [UspTblStudentSelectByID]    Script Date: 22-05-2023 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [UspTblStudentSelectByID]
(
@StudentID varchar(100),
@Password varchar(100)
)
As begin
select Sno,StudentID,StudentName,MobileNo,Email,Password,
Location,IMEI,CreatedOn,CreatedBy

from TblStudent where 
(StudentID=@StudentID) and  (Password=@Password)
End
