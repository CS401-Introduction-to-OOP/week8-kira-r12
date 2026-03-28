Letter letter1 = new Letter("123", 23);
Letter letter2 = new Letter("321", 33);

Parcel parcel1 = new Parcel("111", 22, "20*30*78");
Parcel parcel2 = new Parcel("222", 90, "12*90*78");

letter1.PrintInfo();
parcel1.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();


myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);
Console.WriteLine($"Загальна вартість доставки: {myCargo.GetTotalCost()}");
