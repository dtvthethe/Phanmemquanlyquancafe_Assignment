create database QLCF
go
use QLCF
go
create table nguoi_dung
(
ma_tk char(5) primary key ,
ten nvarchar(50) ,
dia_chi nvarchar(200),
sdt char(11)not null,
email varchar(100)not null,
img nvarchar(10)
)

create table dang_nhap
(
ma_tk char(5) unique Foreign Key (ma_tk) References nguoi_dung(ma_tk),
ten_dang_nhap nvarchar(30) unique ,
mat_khau nvarchar(30),
chuc_vu varchar(10)
)


create table tang
(
ma_tang char(5) primary key ,
ten_tang nvarchar(30)  unique,
)


create table ban
(
ma_ban char(5) primary key ,
ten_ban nvarchar(30)  unique,
trang_thai bit ,
ma_tang char(5) Foreign Key (ma_tang) References tang(ma_tang)
)

create table loai_do_an
(
ma_loai char(5) primary key not null,
ten_loai nvarchar(30) not null
)

create table menu
(
ma_sp char(5) primary key ,
ten_sp nvarchar(30) ,
gia money ,
ma_loai char(5) Foreign Key (ma_loai) References loai_do_an(ma_loai),
img nvarchar(10) 
)

create table goi_mon
(
ma_goi_mon char(5) primary key ,
ma_tang char(5)  Foreign Key (ma_tang) References tang(ma_tang),
ma_ban char(5)  Foreign Key (ma_ban) References ban(ma_ban),
ma_tk char(5) Foreign Key (ma_tk) References nguoi_dung(ma_tk),
trang_thai bit
)

create table danh_sach_goi_mon
(
ma_goi_mon char(5)  Foreign Key (ma_goi_mon) References goi_mon(ma_goi_mon),
ma_sp char(5)  Foreign Key (ma_sp) References menu(ma_sp),
so_luong integer,
trang_thai bit
)
