

Console.Write("ShuLardan birini kiriting : U | T \n");
 char input = Convert.ToChar(Console.ReadLine());



  switch(input)
  {
    case 'U':
    Edge(6);
    break;

    case 'T':
    Triangle(5,6);
    break;
  }


void Edge(int height)

{
  for (int i = 1; i <= height; i++)
  {
      for (int j = 1; j <= i; j++)
     {
         Console.Write(" * ");
     }
      Console.WriteLine("");
  }
}






void Triangle(int height, int width)

 {
     for (int i = 0; i < height; i++) 
     {
        for (int j = 0; j < width; j++)
         {
            Console.Write(" * ");  
         }
        Console.WriteLine();  
     }
 }