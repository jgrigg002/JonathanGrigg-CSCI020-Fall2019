using System;
using System.IO;


namespace csci20FinalProject
{

    //Mountain class creates a mountain range on the map
    public class Mountain
    {
        private int x = 0;
        private int y = 0;
        public Mountain(int i, int j)
        {
            x = i;
            y = j;
        }
        //WARNING the array that will be passed has three dimensions!!! take this into account!!!
        public void stampMap(ref char[ , , ] map)
        {
            //sets up mountain 'stamp' onto map.
            int start = 1;
            var rand = new Random();
            start = rand.Next(0, x);
            int count = 1;
            int direction = rand.Next(2, 4);
            //Console.WriteLine(map.GetLength(0));
            //Console.WriteLine(map.GetLength(1));
            //Console.WriteLine(map.GetLength(2));
            //Console.WriteLine(x + " " + y);
            //direction = 2;
            map[start, count, 0] = 'M';
            start++;
            //starts the top to bottom printing of the mountain range
            while (count <= y-2)
            {
                //needed for the angle of print
                switch (direction)
                {
                    //printing to the rightand down
                    case 2:
                        //if on right edge
                        if (start == y)
                        {
                            count = y - 1;
                            break;
                        }
                        //printing
                        else if (start <=y)
                        {
                            ;
                            map[start, count,0] = 'M';
                            Console.WriteLine(map[start, count, 0]);
                            start++;
                        }
                        break;
                    //if straight down
                    case 3:
                        map[start, count, 0] = 'M';
                        Console.WriteLine(map[start, count, 0]);
                        break;
                    //if left and down
                    case 4:
                        //if left edge of map
                        if (start == 0)
                        {
                            count = y - 1;
                            break;
                        }
                        else if (start >= 0)
                        {
                            start--;
                            map[start, count, 0] = 'M';
                            Console.WriteLine(map[start, count, 0]);
                        }
                        break;

                }
                count++;
            }

        }



    }

    //River class creates a river on the map dependent on the mountian
    public class River
    {
        private int x = 0;
        private int y = 0;
        public River(int i, int j)
        {
            x = i;
            y = j;
        }
    }

    //This class stamps objects down onto the map but does not over lay them on exsisting objects
    public class Stamp
    {
        private int x = 0;
        private int y = 0;
        public Stamp(int i, int j)
        {
            x = i;
            y = j;
        }
    }

    public class Combine
    {
        private int x = 0;
        private int y = 0;
        public Combine(int i, int j)
        {
            x = i;
            y = j;
        }
    }

    class Program
    {
        static void Main()
        {
            int i = 0;
            int j = 0;
            mapSize(ref i, ref j);
            //test print of map size function.
            //Console.WriteLine(i + " " + j);
            char[ , , ] map = new char[i,j,3];
            char[ , ] mapE = new char[i,j];


            //class object creations. Map size passed on construction.
            Mountain mntn = new Mountain(i, j);
            River rvr = new River(i, j);
            Stamp stmp = new Stamp(i, j);
            Combine cmbn = new Combine(i, j);

            mntn.stampMap(ref map);
            StreamWriter writer;
            writer = new StreamWriter("mapOutput.cvs");
            writer.WriteLine();
            for (int a = 0; a <= map.GetLength(0)-1; a++)
            {
                for (int b = 0; b <= map.GetLength(1)-1; b++)
                {
                    writer.Write(map[a, b, 0]);
                }
                writer.WriteLine();
            }
            writer.Close();
            //function that sets map size
            void mapSize(ref int i, ref int j)
            {
                Console.WriteLine("type value for x, press enter.\nThen type value for y, press enter.\nrecommended size is 200 by 200");
                i = int.Parse(Console.ReadLine());
                j = int.Parse(Console.ReadLine());
            }
        
        }
    }
}
