create database musician
 use musician

 create table Musician(
 id int primary key,
 Name nvarchar(20) not null,
 Ph_number nvarchar(11) not null,
 City nvarchar(50) default 'cairo',
 street nvarchar(20),
 );

 create table instrument(
 Name nvarchar(20) primary key,
 keyy nvarchar not null,
 );

 create table Album (
 id int primary key,
 Tittle nvarchar(20),
 Date date ,
 Mus_id int references Musician(id)
 
 );

 create table song(
 Tittle nvarchar(20) primary key,
 Author nvarchar(20),
 );

 create table Album_song(
 Album_id int references Album(id),
 song_title nvarchar(20) references song(Tittle),
 primary key(song_title)
 );

create table  Mus_song (
Mus_id int references Musician(id),
Song_tittle nvarchar(20) references song(Tittle),
primary key(Mus_id , Song_tittle)
);



create table Mus_insturment(
Mus_id int references Musician(id),
inst_name nvarchar(20) references instrument(Name),
primary key(Mus_id , inst_name)
);

