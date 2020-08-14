create proc sp_insert(
@studroll varchar(20),
@studname varchar(20),
@studbranch varchar(20),
@studgrade varchar(20)
)
as
begin
insert into StudentTable(StudentRollNo,StudentName,StudentBranch,StudentGrade) values(@studroll,@studname,@studbranch,@studgrade)
end