using PatikaFlix_Project;

Console.WriteLine("PatikaFlixe Hoşgeldiniz");
List<Series> seriesList = new List<Series>();

string add = "";

do
{
    Series series = new Series();
    Console.WriteLine("Eklemek istediğiniz dizinin ismini giriniz");
    series.Name = Console.ReadLine();
    

    Console.WriteLine("Eklemek istediğiniz dizinin yapım yılını giriniz ");
    series.ProductionYear = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Dizinin türünü giriniz");
    series.Genre = Console.ReadLine();

    Console.WriteLine("Yayınlanma tarihini giriniz");
    series.RelaseYear = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yönetmen ismini giriniz");
    series.Director = Console.ReadLine();

    Console.WriteLine("Yayınlandığı platform hangisi ?");
    series.StreamPlatform = Console.ReadLine();
    seriesList.Add(series);

    Console.WriteLine("Başka bir dizi eklemek ister misiniz? (e/h)");
    add = Console.ReadLine().ToLower().Trim();

    while (add != "e" && add != "h")
    {
        Console.WriteLine("Geçerli giriş yapmadınız lütfen 'e' ya da 'h' seçeneklerinden birini seçiniz.");

        add = Console.ReadLine().ToLower().Trim();
    }

} while (add == "e");

var comedySeries = seriesList.Where(serie => serie.Genre == "Komedi");

List<ComediSeries> comediSeries = comedySeries.Select(serie => new ComediSeries
{
    Name = serie.Name,
    Genre = serie.Genre,
    Director = serie.Director,
}).ToList();

var sortedComediSeries = comediSeries.OrderBy(comediSeries => comediSeries.Name).ThenBy(serie => serie.Director).ToList();

foreach (var item in sortedComediSeries)
{
    Console.WriteLine(item);
}

