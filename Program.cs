// See https://aka.ms/new-console-template for more information



string st1 = string.Empty;
st1 = "Halit Tiryaki";
string ad = "Halit";
string soyad = "Tiryaki";
string tamIsim = ad + " " + soyad;

int sayi1 = 5;
int sayi2 = 10;
int carpim = sayi1 * sayi2;

bool bool1 = 10>5;
Console.WriteLine(bool1);

string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int21);


string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);