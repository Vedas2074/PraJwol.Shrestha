class Array
{
   void Learn1DArray()
   {
    //declaration of 1DArray
        byte[] array1 = new byte[10];

        array1[0] = 15;
        array1[1] = 25;
        array1[9] = 10;

        float[] array2 = new float[] {0.2f, 2.2f, 35.5f, 2.2f, 8.4f};
        //var x = array2.Length;

        char[] array3 = {'A', 'B', 'C', 'D'};

        float[] SubArray1 = array2[1..3]; // Ranged opertator

    
   }
   void LearnMultiDArray()
   {
     //declaration of MultiDimensional Array. Here its a 2D
        int[,] numbers1 = new int[3,4]; // , in int introduce 2d 
        numbers1[0,0] = 1;
        numbers1[2,3] = 25;

        decimal[,] numbers2 = {{2.3m, 3.6m},{4.5m, 5.6m}};
        //var x = numbers2.Length;

   }

   void LearnJaggedArray()
   {
       short[][] numbers = new short[4][];
       numbers[0] = new short[] {3, 4, 5};
       numbers[1] = new short[] {3, 4, 5};
       numbers[2] = new short[] {3, 4, 5 , 8};
   }
}