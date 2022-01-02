int[] a = new int[10]; //array with 10 random numbers
Random rnd=new Random();

for(int i=0;i<10;i++)
    {
        a[i] = rnd.Next(1,50);
    }
for(int i = 0;i < 10; i++) //show first array
    {
        Console.Write("  "+ a[i]);
    }
int[] b = new int[10];

for (int j = 0; j < a.Length; j++)
    {
        if (a[j] % 2 ==0)
        {
            b[j] = a[j];
            Console.WriteLine("\n" + b[j]); //show second array
        }
    }

