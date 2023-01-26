// See https://aka.ms/new-console-template for more information
using PM01;
using System;

Car car1 = new Car("Audi",235,1f,0.02f);
Car car2 = new Car("RenaultLogan", 160, 1f, 0.02f);
Car car3 = new Car("BMW", 210, 1f, 0.01f);
Car car4 = new Car("Ferrari", 250, 1f, 0.03f);

Garage garage = new Garage();
garage.addCar(car1);
garage.addCar(car2);
garage.addCar(car3);

garage.getAll();

garage.changeCar(car4);

car1.Move(50);

garage.getAll();

garage.cleanCar(car1);

car4.Move(3);

garage.OrderByFuel();

garage.OrderBySpeed();

