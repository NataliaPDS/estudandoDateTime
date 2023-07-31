DateTime d1 = new DateTime(2023, 07, 24);
/*Console.WriteLine(d1.Year);
Console.WriteLine(d1.Day);
Console.WriteLine(d1.Month);
Console.WriteLine(d1.DayOfWeek);
Console.WriteLine(d1.DayOfYear);*/

Console.WriteLine(d1);

DateTime d2 = d1.AddDays(5);
Console.WriteLine(d2);

int idade = d2.Year - d1.Year; 
Console.WriteLine(idade);

TimeSpan ts = d1.Subtract(d2);
Console.WriteLine(ts);

Console.WriteLine(DateTime.Compare(d1, d2));
Console.WriteLine(d1.CompareTo(d2));

DateOnly dto = new DateOnly(2023, 07, 24);
Console.WriteLine(dto);
DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);

DateTime datanasc = Convert.ToDateTime(Console.ReadLine());
DateTime agr = DateTime.Today;

//DateTime mes = datanasc.Year;
