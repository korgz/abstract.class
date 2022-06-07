// See https://aka.ms/new-console-template for more information
using Lession10;



Vehiacle audi = new Car();
audi.Name = "Audi";
Car bmw = new Car();
bmw.Name = "Bmw";


audi.SoundHorn();
bmw.SoundHorn();


// audi.SppedUp(); Nēeksistē, jo metode Spped up ir tikai mašīnām
bmw.SppedUp();


// int bmwProductionYear = bmw.ProductionYear; Nevar piekļūt, jo pieejas līmenis ir protected

Bus mercedesBus = new Bus();

mercedesBus.SoundHorn();

bmw.StarttoDrive();
mercedesBus.StarttoDrive();