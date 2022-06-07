// See https://aka.ms/new-console-template for more information
using Lession10;



Vehiacle audi = new Vehiacle();
Car bmw = new Car();


audi.SoundHorn();
bmw.SoundHorn();


// audi.SppedUp(); Nēeksistē, jo metode Spped up ir tikai mašīnām
bmw.SppedUp();


// int bmwProductionYear = bmw.ProductionYear; Nevar piekļūt, jo pieejas līmenis ir protected

Bus mercedesBus = new Bus();

mercedesBus.SoundHorn();