# dotnet6Dojo

## Lib จำเป็นที่ใช้กับ Entity Framework

- Microsoft.EntityFrameworkCore.Design => เอาไว้ใช้สำหรับการ migration (Code First Migration)
- Microsoft.EntityFrameworkCore.Tools => เอาไว้ใช้สำหรับการ migration (Code First Migration)
- Microsoft.EntityFrameworkCore.SqlServer => ใช้กับ sql server database กับ entity framework

## must know

- config connection string ไว้ที่ appsettings.json
- dotnet tool install --global dotnet-ef ลง ef
- DbContext => session ที่เกี่ยวกับ database ไม่ว่าจะเป็นการ query,save data
- DbSet => map กับ table database
- register datacontext ที่ program.cs ก่อน swagger
- `global` using SuperHeroApi.Data => เป็นการ define ไว้ที่ program.cs เพื่อให้ที่เราสามารถเรียกใช้ได้เลยทุกที่ โดยไม่ต้องไป using เรียกใช้อีก
- SaveChangesAsync() => เรียกทุกครั้งที่มีการเปลี่ยนแปลงบน database ไม่ว่าจะเป็น add,update,delete
- run migration จะมี folder migration มีไฟล์อยู่ 2 แบบ คือ
  1. migration timestamp => จะเป็น file ที่มีคำสั่ง up(create table,add column),down (drop table,revert migration)
  2. data context model snapshot => แสดง state model หลังจากที่โดน run migration เอาไว้ให้ตัว ef มัน compute migration
- run migration แล้ว run database update เสร็จมันจะสร้าง table ef history=> เป็น log เก็บไว้ว่าเรา run migration อะไรบ้าง => ef มันจะใช้ table นี้ในการ compare ว่ามี migration ตัวไหนที่ยังไม่ได้มีใน table นี้มันจะทำการ run migration ตัวนั้น
- run migration ef มันจะเอา class model table มา compare ว่ามีการเปลี่ยนแปลงมั้ย ถ้ามีมันก็จะ generate code ใน up, down method ให้

## ef command (Microsoft.EntityFrameworkCore.Design)

- dotnet ef migrations add `ชื่อ migration` => คำสั่ง migration
- dotnet ef database update => คำสั่ง update database(ถ้าเรายังไม่มี database มันจะสร้าง database ให้แทน)
- dotnet ef migrations remove => revert last migration
