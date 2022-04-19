# dotnet6Dojo

## Lib จำเป็นที่ใช้กับ Entity Framework

- Microsoft.EntityFrameworkCore.Design => เอาไว้ใช้สำหรับการ migration (Code First Migration)
- Microsoft.EntityFrameworkCore.SqlServer => ใช้กับ sql server database กับ entity framework


## must know
- config connection string ไว้ที่ appsettings.json
- dotnet tool install --global dotnet-ef ลง ef 
- DbContext => session ที่เกี่ยวกับ database ไม่ว่าจะเป็นการ query,save data
- DbSet => map กับ table database
- register datacontext ที่ program.cs ก่อน swagger
- `global` using SuperHeroApi.Data => เป็นการ define ไว้ที่ program.cs เพื่อให้ที่เราสามารถเรียกใช้ได้เลยทุกที่ โดยไม่ต้องไป using เรียกใช้อีก
- SaveChangesAsync() => เรียกทุกครั้งที่มีการเปลี่ยนแปลงบน database ไม่ว่าจะเป็น add,update,delete

## ef command
- dotnet ef migrations add `ชื่อ migration` => คำสั่ง migration
- dotnet ef database update => คำสั่ง update database(ถ้าเรายังไม่มี database มันจะสร้าง database ให้แทน)