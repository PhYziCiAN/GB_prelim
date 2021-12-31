int[] a = new int[10]; //array with 10 random numbers
Random rnd=new Random();

for(int i=0;i<10;i++)
{
    a[i] = rnd.Next(1,50);
}
for(int i = 0;i < 10; i++) //++i лучше
{
    Console.WriteLine(a[i]);
}