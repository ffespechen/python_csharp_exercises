// http://inventwithpython.com/pythongently/exercise8/

string ruta = Path.Combine(Environment.CurrentDirectory, "texto.txt");
string texto1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam facilisis nibh in euismod dignissim. Vivamus eros eros, efficitur a libero dictum, imperdiet faucibus lacus.";
string texto2 = "Немає нікого, хто любив би самий біль, хто б шукав його чи хотів би його зазнавати тільки через те, що він - біль...";

WriteToFile(ruta, texto1);
AppendToFile(ruta, texto2);
ReadFromFile(ruta);