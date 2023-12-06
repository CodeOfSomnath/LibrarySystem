using LibrarySystem;
var system = new LibrarySystemC();
//system.start();
var reader = new CsvReader("S:\\test.csv");
Console.WriteLine(reader.getContent());