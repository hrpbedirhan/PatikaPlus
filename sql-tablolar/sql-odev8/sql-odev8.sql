--test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);


--Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
insert into employee (name, email, birthday) values ('Harris', 'hthorneloe0@arstechnica.com', '1933-12-09');
insert into employee (name, email, birthday) values ('Herb', 'hkezourec1@oracle.com', '1937-01-06');
insert into employee (name, email, birthday) values ('Jory', 'jhallowes2@dagondesign.com', '1929-06-28');
insert into employee (name, email, birthday) values ('Tye', 'tbrokenbrow3@weebly.com', '1984-10-14');
insert into employee (name, email, birthday) values ('Imogene', 'ijaniak4@altervista.org', '1949-04-14');
insert into employee (name, email, birthday) values ('Wallace', 'willem5@hibu.com', '1975-05-06');
insert into employee (name, email, birthday) values ('Imojean', 'imcgrouther6@ehow.com', '1990-06-18');
insert into employee (name, email, birthday) values ('Agace', 'aminchinden7@zdnet.com', '1978-02-09');
insert into employee (name, email, birthday) values ('Carolynn', 'chehnke8@baidu.com', '1906-04-25');
insert into employee (name, email, birthday) values ('Natty', 'ncalcott9@nydailynews.com', '1903-10-14');
insert into employee (name, email, birthday) values ('Catherine', 'cconkeya@go.com', '1957-06-14');
insert into employee (name, email, birthday) values ('Mellisa', 'mmunginb@ft.com', '1995-12-22');
insert into employee (name, email, birthday) values ('Griswold', 'gserrelsc@wikispaces.com', '1910-12-08');
insert into employee (name, email, birthday) values ('Roanne', 'rhymord@umn.edu', '1936-02-16');
insert into employee (name, email, birthday) values ('Darcy', 'dhannee@bing.com', '1956-11-08');
insert into employee (name, email, birthday) values ('Maryjane', 'maylwinf@redcross.org', '1983-02-03');
insert into employee (name, email, birthday) values ('Bartram', 'bbramhillg@unicef.org', '1928-03-23');
insert into employee (name, email, birthday) values ('Aime', 'akemellh@dot.gov', '1911-06-22');
insert into employee (name, email, birthday) values ('Humberto', 'hstatefieldi@t.co', '1991-12-23');
insert into employee (name, email, birthday) values ('Dyna', 'dpoundj@examiner.com', '1961-05-02');
insert into employee (name, email, birthday) values ('Farleigh', 'ftreacherk@amazon.co.jp', '1964-08-04');
insert into employee (name, email, birthday) values ('Milissent', 'mwildbloodl@usatoday.com', '1916-07-14');
insert into employee (name, email, birthday) values ('Leilah', 'lparncuttm@theglobeandmail.com', '1980-02-16');
insert into employee (name, email, birthday) values ('Evita', 'enowaczykn@theglobeandmail.com', '1979-10-15');
insert into employee (name, email, birthday) values ('Karena', 'kdyero@msu.edu', '1985-10-23');
insert into employee (name, email, birthday) values ('Woodrow', 'wmcgorleyp@lulu.com', '1927-10-23');
insert into employee (name, email, birthday) values ('Madelina', 'mbartolozziq@icio.us', '1942-01-12');
insert into employee (name, email, birthday) values ('El', 'emartir@hexun.com', '1987-01-10');
insert into employee (name, email, birthday) values ('Cristina', 'cbrickets@yellowbook.com', '1917-07-26');
insert into employee (name, email, birthday) values ('Gearard', 'gkarbyt@jugem.jp', '1990-11-23');
insert into employee (name, email, birthday) values ('Bernetta', 'bgreaveu@zdnet.com', '1994-01-08');
insert into employee (name, email, birthday) values ('Reta', 'rdartonv@dion.ne.jp', '1930-10-01');
insert into employee (name, email, birthday) values ('Michail', 'mbenningw@wired.com', '1901-06-02');
insert into employee (name, email, birthday) values ('Kelila', 'kshoebottomx@dropbox.com', '1990-11-05');
insert into employee (name, email, birthday) values ('Frankie', 'feveraly@unc.edu', '1959-12-29');
insert into employee (name, email, birthday) values ('Darcey', 'dbramptonz@seattletimes.com', '1952-08-14');
insert into employee (name, email, birthday) values ('Wendel', 'wbarnby10@ustream.tv', '1995-02-16');
insert into employee (name, email, birthday) values ('Aidan', 'atrower11@jalbum.net', '1949-03-02');
insert into employee (name, email, birthday) values ('Kaleena', 'khofner12@gov.uk', '1974-03-01');
insert into employee (name, email, birthday) values ('Romy', 'roughton13@sphinn.com', '1939-05-26');
insert into employee (name, email, birthday) values ('Cord', 'cbullocke14@topsy.com', '1913-09-16');
insert into employee (name, email, birthday) values ('Dulci', 'dmingotti15@hc360.com', '1964-07-03');
insert into employee (name, email, birthday) values ('Suzi', 'shaddeston16@google.co.jp', '1936-07-16');
insert into employee (name, email, birthday) values ('Benedict', 'bhurch17@skyrock.com', '1944-04-03');
insert into employee (name, email, birthday) values ('Arni', 'agillinghams18@examiner.com', '1995-06-02');
insert into employee (name, email, birthday) values ('Mair', 'mmerrgan19@ft.com', '1986-11-05');
insert into employee (name, email, birthday) values ('Grissel', 'gmallon1a@google.ru', '1942-12-07');
insert into employee (name, email, birthday) values ('Sutherlan', 'srehn1b@google.com', '1983-09-09');
insert into employee (name, email, birthday) values ('Priscilla', 'pcritchard1c@digg.com', '1989-09-15');
insert into employee (name, email, birthday) values ('Ginni', 'gconnell1d@techcrunch.com', '1997-03-03');

--Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
UPDATE employee
SET email = 'updated_email@example.com'
WHERE name = 'Ginni';
UPDATE employee
SET name = 'Updated Name'
WHERE birthday = '1989-09-15';
UPDATE employee
SET birthday = '2000-01-01'
WHERE email = 'srehn1b@google.com';
UPDATE employee
SET name = 'New Name'
WHERE id = 47;
UPDATE employee
SET email = 'new_email@example.com'
WHERE name LIKE '%Mair%';

--Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM employee
WHERE id = 20;
DELETE FROM employee
WHERE name = 'Woodrow';
DELETE FROM employee
WHERE birthday < '1990-01-01';
DELETE FROM employee
WHERE email = 'cbullocke14@topsy.com';
DELETE FROM employee
WHERE name LIKE 'M%';

