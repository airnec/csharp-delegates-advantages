//---------------------------------------------
// High flexibility and dynamic behavior
//---------------------------------------------
Dictionary<int, Func<int, int, int>> operations = new()
        {
            { 1, (a, b) => a + b },  // Toplama
            { 2, (a, b) => a - b },  // Çıkarma
            { 3, (a, b) => a * b },  // Çarpma
            { 4, (a, b) => a / b }   // Bölme
        };

Console.WriteLine("İşlem seçin (1: Toplama, 2: Çıkarma, 3: Çarpma, 4: Bölme):");
int secim = int.Parse(Console.ReadLine());

if (operations.ContainsKey(secim))
{
    Console.WriteLine("İki sayı girin:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    // Seçilen işlemi uyguluyoruz
    var result = operations[secim](a, b);
    Console.WriteLine($"Sonuç: {result}");
}
else
{
    Console.WriteLine("Geçersiz işlem!");
}

//---------------------------------------------
// Generic parameters and return types
//---------------------------------------------
Func<object, object> toUpper = (input) =>
{
    if (input is string str)
    {
        return str.ToUpper();
    }
    return input;
};

Console.WriteLine(toUpper("hello"));  // "HELLO"
Console.WriteLine(toUpper(123));     // 123


//---------------------------------------------
// Run multiple methods in a single delegate using the Multicast Delegate
//---------------------------------------------
Func<int, int, int> toplama = (x, y) => x + y;
Func<int, int, int> carpma = (x, y) => x * y;

// Multicast Delegate (Birden fazla metodu aynı anda çağırıyoruz)
Func<int, int, int> toplamCarpma = toplama + carpma;  // Hem toplama hem çarpma yapılacak

int sonuc = toplamCarpma(2, 3); // Hem 2+3 hem de 2*3 yapılır
Console.WriteLine($"Sonuç: {sonuc}");



//---------------------------------------------
// Short and readable code with the Lambda Expressions and Anonymous Methods
//---------------------------------------------
// Anonim metot ve lambda ifadeleriyle delegate kullanımının kısa yolu
Func<int, int, int> toplama2 = (x, y) => x + y;

Console.WriteLine(toplama2(3, 5)); // 8