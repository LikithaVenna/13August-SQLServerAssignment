create proc sp_update
(@studroll varchar(20),
@studname varchar(20),
@studbranch varchar(20),
@studgrade varchar(20)
)

as 
begin
update StudentTable set studentname = @studname,studentbranch= @studbranch,studentgrade = @studgrade where studentrollno = @studroll
end
