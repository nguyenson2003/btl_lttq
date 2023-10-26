create database LTTQ_BTL_SMPlayer
go
use LTTQ_BTL_SMPlayer
go
create table tblUser(
	UserName	nvarchar(10)	not null	primary key,
	PassWord	nvarchar(100)	not null,
	FullName	nvarchar(200)	not null,
	Enable		int				not null,
	isOnline	int				not null
);
go
create table tblVideo(
	VideoId		nvarchar(10)	not null	primary key,
	UserName	nvarchar(10)	not null
		foreign key references tblUser(UserName),
	VideoName	nvarchar(100)	not null,
	Path	nvarchar(200)		not null,
	Likes	int				not null	
);
go
create table tblVideoList(
	ListId		nvarchar(10)	not null	primary key,
	UserName	nvarchar(10)	not null
		foreign key references tblUser(UserName),
	ListName	nvarchar(100)	not null	
);
go
create table tblVideoListDetail(
	ListId		nvarchar(10)	not null
		foreign key references tblVideoList(ListId),
	MusicId		nvarchar(10)	not null
		foreign key references tblVideo(VideoId)
);
go
create table tblMusic(
	MusicId		nvarchar(10)	not null	primary key,
	UserName	nvarchar(10)	not null
		foreign key references tblUser(UserName),
	MusicName	nvarchar(100)	not null,
	Path		nvarchar(200)	not null
);
go
create table tblMusicList(
	ListId		nvarchar(10)	not null	primary key,
	UserName	nvarchar(10)	not null
		foreign key references tblUser(UserName),
	ListName	nvarchar(100)	not null	
);
go
create table tblMusicListDetail(
	ListId		nvarchar(10)	not null
		foreign key references tblMusicList(ListId),
	MusicId		nvarchar(10)	not null
		foreign key references tblMusic(MusicId)
);
go
--insert value
insert into tblUser
values(N'admin',N'123',N'Lê Văn Minh',1,0)
insert into tblUser
values(N'user01',N'123',N'Lê Văn Minh',1,0)
insert into tblUser
values(N'user02',N'123',N'Trần Kim Anh',1,0)
insert into tblUser
values(N'user03',N'123',N'Nguyễn Quỳnh Sơn',1,0)
insert into tblUser
values(N'user04',N'123',N'Lê Thị Mỹ Linh',1,0)
insert into tblUser
values(N'user05',N'123',N'Ngô Phan Diệu Linh',1,0)


insert into tblVideo
values(N'video01',N'user01',N'Luis Fonsi - Despacito ft. Daddy Yankee'
	,N'D:\Downloads\Video\Luis Fonsi - Despacito ft. Daddy Yankee.mp4',10) 
insert into tblVideo
values(N'video02',N'user01',N'Nightcore - Ignite - (K-391 '
	,N'D:\Downloads\Video\Nightcore - Ignite - (K-391 .mp4',11)


update tblUser
set isOnline=0
where tblUser.UserName=N'admin'
insert into tblUser
values(N'',N'',N'',1,0)
select * from tblVideo


--drop csdl
DROP TABLE dbo.tblMusicListDetail;
DROP TABLE dbo.tblVideoListDetail;
DROP TABLE dbo.tblMusicList;
DROP TABLE dbo.tblVideoList;
DROP TABLE dbo.tblMusic;
DROP TABLE dbo.tblVideo;
DROP TABLE dbo.tblUser;



