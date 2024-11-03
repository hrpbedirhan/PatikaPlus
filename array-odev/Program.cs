namespace array_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //boş bir array oluşturduk
            int[] array = new int[10];

            //ilk 10 elemanını for ile ekledik
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            //foreach ile elemanlarını yazdırdık
            foreach (int arr  in array)
                Console.WriteLine(arr);

            Array.Resize(ref array, 11);

            //11. elemanı kullanıcıdan aldık ve listeye ekledik
            Console.Write("11. elemanı giriniz: ");
            int newItem = Convert.ToInt32(Console.ReadLine());
            array[10] = newItem;

            //listeyi sort metodu ile küçükten büyüğe sırayalıp reverse ile sıralamayı tersine çevirdik
            Array.Sort(array);
            Array.Reverse(array);

            //listenin son halini foreach ile yazdırdık
            foreach (int arr in array)
                Console.WriteLine(arr);
        }
    }
}
