create database LTTQ_BTL_SMPlayer
go
use LTTQ_BTL_SMPlayer
go
create table tblUser(
	UserName	nvarchar(30)	not null	primary key,
	PassWord	nvarchar(100)	not null,
	FullName	nvarchar(200)	not null,
	Enable		int				not null,
	isOnline	int				not null
);
go
create table tblVideo(
	VideoId		nvarchar(30)	not null	primary key,
	UserName	nvarchar(30)	not null
		foreign key references tblUser(UserName),
	VideoName	nvarchar(100)	not null,
	Path	nvarchar(200)		not null
);
go
create table tblVideoList(
	ListId		nvarchar(30)	not null	primary key,
	UserName	nvarchar(30)	not null
		foreign key references tblUser(UserName),
	ListName	nvarchar(100)	not null	
);
go
create table tblVideoListDetail(
	ListId		nvarchar(30)	not null
		foreign key references tblVideoList(ListId),
	VideoId		nvarchar(30)	not null
		foreign key references tblVideo(VideoId)
);
go
create table tblLikeVideoDetail(
	UserName	nvarchar(30)	not null
		foreign key references tblUser(UserName),
	VideoId		nvarchar(30)	not null
		foreign key references tblVideo(VideoId)
);
go
create table tblMusic(
	MusicId		nvarchar(30)	not null	primary key,
	UserName	nvarchar(30)	not null
		foreign key references tblUser(UserName),
	MusicName	nvarchar(100)	not null,
	Path		nvarchar(200)	not null
);
go
create table tblMusicList(
	ListId		nvarchar(30)	not null	primary key,
	UserName	nvarchar(30)	not null
		foreign key references tblUser(UserName),
	ListName	nvarchar(100)	not null	
);
go
create table tblMusicListDetail(
	ListId		nvarchar(30)	not null
		foreign key references tblMusicList(ListId),
	MusicId		nvarchar(30)	not null
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
values(N'video31',N'user01',N'Luis Fonsi - Despacito ft. Daddy Yankee'
	,N'\\Videos\\Luis Fonsi - Despacito ft. Daddy Yankee.mp4') 
insert into tblVideo
values(N'video32',N'user01',N'Nightcore - Ignite - (K-391 '
	,N'\\Videos\\Nightcore - Ignite - (K-391 .mp4')
insert into tblVideo
values(N'video33',N'user01',N'Luis Fonsi - Despacito ft. Daddy Yankee'
	,N'\\Videos\\Luis Fonsi - Despacito ft. Daddy Yankee.mp4') 
insert into tblVideo
values(N'video34',N'user01',N'Nightcore - Ignite - (K-391 '
	,N'\\Videos\\Nightcore - Ignite - (K-391 .mp4')
	insert into tblVideo
values(N'video35',N'user01',N'Luis Fonsi - Despacito ft. Daddy Yankee'
	,N'\\Videos\\Luis Fonsi - Despacito ft. Daddy Yankee.mp4') 
insert into tblVideo
values(N'video36',N'user01',N'Nightcore - Ignite - (K-391 '
	,N'\\Videos\\Nightcore - Ignite - (K-391 .mp4')
insert into tblVideo
values(N'video37',N'user01',N'Luis Fonsi - Despacito ft. Daddy Yankee'
	,N'\\Videos\\Luis Fonsi - Despacito ft. Daddy Yankee.mp4') 
insert into tblVideo
values(N'video38',N'user01',N'Nightcore - Ignite - (K-391 '
	,N'\\Videos\\Nightcore - Ignite - (K-391 .mp4')


insert into tblMusic
values(N'music01',N'user01',N'BaseAfterBase',N'\\Musics\\BaseAfterBase.mp3')
insert into tblMusic
values(N'music02',N'user02',N'BeastMode',N'\\Musics\\BeastMode.mp3')
insert into tblMusic
values(N'music03',N'user03',N'CantLetGo',N'\\Musics\\CantLetGo.mp3')
insert into tblMusic
values(N'music04',N'user01',N'Clubstep',N'\\Musics\\Clubstep.mp3')
insert into tblMusic
values(N'music05',N'user01',N'Clutterfunk',N'\\Musics\\Clutterfunk.mp3')
insert into tblMusic
values(N'music06',N'user02',N'DryOut',N'\\Musics\\DryOut.mp3')
insert into tblMusic
values(N'music07',N'user03',N'Electrodynamix',N'\\Musics\\Electrodynamix.mp3')
insert into tblMusic
values(N'music08',N'user04',N'Electroman',N'\\Musics\\Electroman.mp3')
insert into tblMusic
values(N'music10',N'user03',N'HexagonForce',N'\Musics\HexagonForce.mp3')
insert into tblMusic
values(N'music11',N'user02',N'Jumper',N'\Musics\Jumper.mp3')


insert into tblMusicList
values(N'msl01',N'user01',N'list name 01')
select * from tblUser where Username=N'user01'
update tblUser
set PassWord=N''
where UserName=N''
/*
đoạn này để test
*/
select count(UserName) as Likes
from tblLikeVideoDetail
where VideoId=N'video34'

select tblVideo.UserName,tblVideo.VideoId,FullName,VideoName,Path 
from 
	tblLikeVideoDetail join tblUser on tblLikeVideoDetail.UserName = tblUser.UserName 
	join tblVideo on tblVideo.VideoId = tblLikeVideoDetail.VideoId 
	
where tblUser.UserName = N'user01'
select MusicName,Path,FullName,tblMusic.UserName,MusicId
from tblMusic join tblUser on tblMusic.UserName=tblUser.UserName

select tblVideo.UserName,tblVideo.VideoId,FullName,VideoName,Path 
from tblLikeVideoDetail join tblUser on tblLikeVideoDetail.UserName = tblUser.UserName 
join tblVideo on tblVideo.VideoId = tblLikeVideoDetail.VideoId 
where tblUser.UserName = N'user01'

select VideoName,Path,FullName,tblVideo.UserName,tblVideo.VideoId
from
	(select VideoId	
	from tblLikeVideoDetail
	where UserName = N'user03') t1
	join tblVideo on t1.VideoId=tblVideo.VideoId
	join tblUser on tblVideo.UserName=tblUser.UserName
select * from tblUser where UserName=N'admin'
update tblUser
set isOnline=0
where tblUser.UserName=N'admin'
insert into tblUser
values(N'',N'',N'',1,0)
select * from tblVideo
select * from tblMusicListDetail
where UserName=N'user03'
select * from tblMusicListDetail
where ListId=N'lms63834615692' and MusicId=N'ms63834606546'
insert into tblMusicListDetail
values(N'',N'')
 --MusicName,Path,FullName,MusicId

 select Path,MusicName,t2.MusicId,FullName
 from
	 (select Path,MusicName,t1.MusicId,UserName
	from 
		(select MusicId,ListId from tblMusicListDetail
		where ListId=N'lms63834622284') t1
	join tblMusic on tblMusic.MusicId=t1.MusicId) t2
join tblUser on tblUser.UserName=t2.UserName
select * from tblMusicListDetail
delete tblMusicListDetail
where ListId=N''and MusicId=N''

--drop csdl
DROP TABLE dbo.tblMusicListDetail;
DROP TABLE dbo.tblVideoListDetail;
DROP TABLE dbo.tblLikeVideoDetail;
DROP TABLE dbo.tblMusicList;
DROP TABLE dbo.tblVideoList;
DROP TABLE dbo.tblMusic;
DROP TABLE dbo.tblVideo;
DROP TABLE dbo.tblUser;



