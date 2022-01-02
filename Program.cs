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
            Console.WriteLine("\n" + b[j]); //show second array version 1
        }
    }

int[] c = new int[10];

for (int k = 0; k < a.Length; k++)
    {
        if (a[k] > 8)
        {
            b[k] = a[k];
            Console.Write("  " + b[k]); //show second array version 2
        }
    }
