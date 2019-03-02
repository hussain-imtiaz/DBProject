use master
go
drop database TVTDB
go
create database TVTDB
go
use TVTDB

--TABLES--
-->-->-->-->--
--Show	(includes all movies and tvshows)
--Movie
--TVShow
--Season
--Episode
--Genre
--Images
--Comments
--loginDetails
--Users
--Watchlist
--Watchhistory
-->-->-->-->--

create table Genre(
	genreID int NOT NULL,
	genreName varchar(20),
	primary key(genreID),
)

create table Movie(
	movieID int NOT NULL,--Primary Key
	movieName varchar(50),
	releaseDate date,	
	movieRatings int,	--Score out of 10
	genreID int NOT NULL,--FOREIGN from GENRE
	primary key(movieID),
	foreign key(genreID) references Genre(genreID) on delete no action on update cascade, 
)

create table TVShow(
	TVShowID int NOT NULL,
	TVShowName varchar(50),
	TVShowRatings int,
	genreID int NOT NULL,	--FOREIGN from GENRE
	primary key(TVShowID),
	foreign key(genreID) references Genre(genreID) on delete no action on update cascade,
)


create table Show(
	showID int NOT NULL,	--Primary Key
	showType varchar(10),
	movieID int NOT NULL,	--FOREIGN from MOVIE
	TVShowID int NOT NULL,	--FOREIGN from TVSHOW
	primary key(showID, showType), --Composite primary key to check foreign key constraint issue
	foreign key(TVShowID) references TVShow(TVShowID),
	foreign key(movieID) references Movie(movieID) on delete no action on update cascade,
	
)

create table Season(
	seasonID int NOT NULL,
	TVShowID int NOT NULL,	--FOREIGN from TVSHOW
	seasonNumber int,
	primary key(seasonID),
	foreign key(TVShowID) references TVShow(TVShowID) on delete cascade on update cascade,
)

create table Episode(
	episodeID int NOT NULL,
	seasonID int NOT NULL, --FOREIGN from Season
	episodeName varchar(50),
	episodeNumber int,
	primary key(episodeID),
	foreign key(seasonID) references Season(seasonID) on delete cascade on update cascade,
)

create table Users(	
	userID int NOT NULL,
	userName varchar(50),
	gender varchar(10),
	bDate date,
	primary key(userID),
)

create table Watchlists(
	userID int NOT NULL,	--FOREIGN from USERS
	showID int NOT NULL,	--FOREIGN from Show
	showType varchar(10),	--FOREIGN from Show
	primary Key(userID, showID),	--Composite primary key
	foreign key(userID) references Users(userID) on delete cascade on update cascade,
	foreign key(showID, showType) references Show(showID, showType) on delete cascade on update cascade,
)

create table Watchhistory(
	userID int NOT NULL,	--FOREIGN from USERS
	showID int NOT NULL,	--FOREIGN from Show
	showType varchar(10),	--FOREIGN from Show
	primary Key(userID, showID),	--Composite primary key
	foreign key(userID) references Users(userID) on delete cascade on update cascade,
	foreign key(showID, showType) references Show(showID, showType) on delete cascade on update cascade,
)

create table loginDetails(
	loginID int NOT NULL,
	userID int NOT NULL, 
	loginTime time NOT NULL,
	--SuspendTime can be calculated accordingly
	sessionTime int NOT NULL,
	primary key (loginID),
	foreign key(userID) references Users(userID) on delete cascade on update cascade,
)

create table Images(
	imageID int NOT NULL,
	imageLink varchar(100), --Local link to directory of image
	showID int NOT NULL,	--FOREIGN from Show
	showType varchar(10),	--FOREIGN from Show
	primary key (imageID),
	foreign key(showID, showType) references Show(showID, showType) on delete cascade on update cascade,
)

create table comments(
	commentID int NOT NULL,
	commentDesc varchar(240),
	showID int NOT NULL,	--FOREIGN from Show
	showType varchar(10),	--FOREIGN from Show
	primary key (commentID),
	foreign key(showID, showType) references Show(showID, showType) on delete cascade on update cascade,
)

--View all Tables
Select * from Show
Select * from Movie
Select * from TVShow
Select * from Season
Select * from Episode
Select * from Genre
Select * from Images
Select * from Comments
Select * from loginDetails
Select * from Users
Select * from Watchlists
Select * from Watchhistory

