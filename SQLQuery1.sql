use DBSchool
go
alter trigger changeLevel
on LogIn
after Insert, update
as
begin
	declare @level int
	set @level = (select level from inserted)

	declare @id int
	set @id = (select Id from inserted)

	declare @position nvarchar(50)
	set @position = (select position from Person where Person.id = @id)

	if(@position = '��������' and @level != 1)
		begin
		ROLLBACK TRAN
			print('�������� ����� ����� ������ 1-� ������� �������')
	
		end
	if(@position = '��������' and @level != 2)
		begin
		ROLLBACK TRAN
			print('�������� ����� ����� ������ 2-� ������� �������')
		
		end
	if(@position = '���������' and (@level < 3 or @level >7))
		begin
			ROLLBACK TRAN
			print('��������� ����� ����� 3 - 7 ������� �������')
			
		end
end
go
update LogIn
set level = 8
where Id = 1
go
insert into LogIn values('Krigin','kirill',8)
