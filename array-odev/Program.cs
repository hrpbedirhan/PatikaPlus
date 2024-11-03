namespace array_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //boş bir liste oluşturduk
            List<int> array = new List<int>();

            //ilk 10 elemanını for ile ekledik
            for (int i = 0; i < 10; i++)
            {
                array.Add(i + 1);
            }

            //foreach ile elemanlarını yazdırdık
            foreach (int arr  in array)
                Console.WriteLine(arr);

            //11. elemanı kullanıcıdan aldık ve listeye ekledik
            Console.Write("11. elemanı giriniz: ");
            int newItem = Convert.ToInt32(Console.ReadLine());
            array.Add(newItem);

            //listeyi sort metodu ile küçükten büyüğe sırayalıp reverse ile sıralamayı tersine çevirdik
            array.Sort();
            array.Reverse();

            //listenin son halini foreach ile yazdırdık
            foreach (int arr in array)
                Console.WriteLine(arr);
        }
    }
}
