CREATE TABLE HocSinh 
(
 Ten varchar(100),
 Diachi varchar(255),
 Cmnd varchar(100),
 ngaysinh varchar(100)
);

CREATE TABLE GiaoVien 
(
 Ten varchar(100),
 Diachi varchar(255),
 Cmnd varchar(100),
 ngaysinh varchar(100)
);

INSERT INTO HocSinh (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva', 'hcm', '12345','10/13/2004');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva2', 'hcm', '12354','08/21/2004');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva3', 'hcm', '12356','01/01/2004');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva4', 'hcm', '12365','11/03/2004');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva5', 'hcm', '12367','02/01/2004');

INSERT INTO GiaoVien (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva', 'hcm', '12345','06/18/1990');
INSERT INTO GiaoVien (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva2', 'hcm', '12354',' 02/20/1995');
INSERT INTO GiaoVien (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva3', 'hcm', '12356','04/17/1989');
INSERT INTO GiaoVien (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva4', 'hcm', '12365','01/12/1990');
INSERT INTO GiaoVien (Ten, Diachi, Cmnd, ngaysinh)
VALUES ('nva5', 'hcm', '12367','11/11/1997');


select *from HocSinh
select *from GiaoVien
delete from HocSinh
delete from GiaoVien
