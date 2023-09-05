int[] array = new int[4];
int count = 0;
for(int i =0; i < array.GetLength(0); i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "  ");
}
for(int i =0; i < array.GetLength(0); i++){
    if((array[i] % 2) == 0){
        count++;
    }
}
Console.WriteLine("Result = " + count);